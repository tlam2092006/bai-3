using System.ComponentModel;
using System.Globalization;
using System.Text;

namespace bai_3
{
    public partial class Form1 : Form
    {
        private static readonly string[] DeviceTypes = ["Điện thoại", "Máy tính bảng", "Laptop", "Máy tính bàn", "Thiết bị khác"];
        private static readonly string[] OrderStatuses = ["Mới tiếp nhận", "Đang sửa", "Chờ linh kiện", "Hoàn tất", "Đã hủy"];

        private readonly BindingList<RepairOrder> _orders = [];
        private readonly BindingSource _bindingSource = new();
        private readonly ErrorProvider _errorProvider;
        private RepairOrder? _selectedOrder;
        private string? _selectedImagePath;
        private bool _isUpdatingView;

        public Form1()
        {
            InitializeComponent();
            _errorProvider = new ErrorProvider { ContainerControl = this };
            components.Add(_errorProvider);
            WireEvents();
        }

        private void WireEvents()
        {
            _bindingSource.DataSource = _orders;
            _ordersGrid.DataSource = _bindingSource;
            _exportMenuItem.Click += (_, _) => ExportVisibleOrders();
            _exitMenuItem.Click += (_, _) => Close();
            _ordersGrid.SelectionChanged += (_, _) => LoadSelectedOrder();
            _searchTextBox.TextChanged += (_, _) => RefreshVisibleOrders();
            _statusFilterComboBox.SelectedIndexChanged += (_, _) => RefreshVisibleOrders();
            _addButton.Click += (_, _) => AddOrder();
            _updateButton.Click += (_, _) => UpdateOrder();
            _deleteButton.Click += (_, _) => DeleteOrder();
            _clearButton.Click += (_, _) => ClearInput();
            _chooseImageButton.Click += (_, _) => ChooseImage();
            RefreshSummary(_orders);
        }

        private void ExportVisibleOrders()
        {
            using var dialog = new SaveFileDialog
            {
                Title = "Xuất danh sách đơn sửa chữa",
                Filter = "CSV (*.csv)|*.csv",
                DefaultExt = "csv",
                AddExtension = true,
                FileName = "repair-orders.csv",
                OverwritePrompt = true
            };

            if (dialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            try
            {
                using var writer = new StreamWriter(dialog.FileName, false, new UTF8Encoding(true));
                writer.WriteLine("Mã đơn,Tên khách hàng,Số điện thoại,Loại thiết bị,Mô tả lỗi,Ngày tiếp nhận,Chi phí dự kiến,Trạng thái");
                foreach (var order in GetVisibleOrders())
                {
                    string[] values =
                    [
                        order.OrderId,
                        order.CustomerName,
                        order.PhoneNumber,
                        order.DeviceType,
                        order.FaultDescription,
                        order.ReceivedDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                        order.EstimatedCost.ToString("N0", CultureInfo.CurrentCulture),
                        order.Status
                    ];
                    writer.WriteLine(string.Join(',', values.Select(EscapeCsv)));
                }
                MessageBox.Show(this, "Đã xuất danh sách đơn đang hiển thị.", "Xuất CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception) when (exception is IOException or UnauthorizedAccessException)
            {
                MessageBox.Show(this, $"Không thể xuất tệp CSV: {exception.Message}", "Lỗi xuất tệp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string EscapeCsv(string value) => $"\"{value.Replace("\"", "\"\"", StringComparison.Ordinal)}\"";

        private List<RepairOrder> GetVisibleOrders() => _bindingSource.List.Cast<RepairOrder>().ToList();

        private void RefreshVisibleOrders()
        {
            string search = _searchTextBox.Text.Trim();
            string selectedStatus = _statusFilterComboBox.SelectedItem?.ToString() ?? "Tất cả trạng thái";
            var visibleOrders = _orders.Where(order =>
                (selectedStatus == "Tất cả trạng thái" || order.Status == selectedStatus) &&
                (search.Length == 0 ||
                 order.OrderId.Contains(search, StringComparison.CurrentCultureIgnoreCase) ||
                 order.CustomerName.Contains(search, StringComparison.CurrentCultureIgnoreCase) ||
                 order.PhoneNumber.Contains(search, StringComparison.CurrentCultureIgnoreCase))).ToList();

            _isUpdatingView = true;
            _selectedOrder = null;
            _bindingSource.DataSource = new BindingList<RepairOrder>(visibleOrders);
            _ordersGrid.ClearSelection();
            if (_ordersGrid.CurrentCell is not null)
            {
                _ordersGrid.CurrentCell = null;
            }
            _isUpdatingView = false;
            RefreshSummary(visibleOrders);
        }

        private void RefreshSummary(IEnumerable<RepairOrder> visibleOrders)
        {
            var orders = visibleOrders.ToList();
            decimal outstandingCost = orders
                .Where(order => order.Status != "Hoàn tất")
                .Sum(order => order.EstimatedCost);
            _countStatusLabel.Text = $"Số đơn theo bộ lọc: {orders.Count}";
            _costStatusLabel.Text = $"Tổng chi phí dự kiến chưa hoàn tất: {outstandingCost:N0}";
        }

        private void LoadSelectedOrder()
        {
            if (_isUpdatingView || _ordersGrid.CurrentRow?.DataBoundItem is not RepairOrder order)
            {
                return;
            }

            _selectedOrder = order;
            _orderIdTextBox.Text = order.OrderId;
            _customerNameTextBox.Text = order.CustomerName;
            _phoneNumberTextBox.Text = order.PhoneNumber;
            _deviceTypeComboBox.SelectedItem = order.DeviceType;
            _faultDescriptionTextBox.Text = order.FaultDescription;
            _receivedDatePicker.Value = order.ReceivedDate;
            _estimatedCostTextBox.Text = order.EstimatedCost.ToString("0.##", CultureInfo.CurrentCulture);
            _statusComboBox.SelectedItem = order.Status;
            _selectedImagePath = order.ImagePath;
            ShowImage(order.ImagePath);
            ClearValidationErrors();
        }

        private void AddOrder()
        {
            if (!TryReadOrder(out var order))
            {
                return;
            }

            if (_orders.Any(existing => string.Equals(existing.OrderId, order.OrderId, StringComparison.CurrentCultureIgnoreCase)))
            {
                _errorProvider.SetError(_orderIdTextBox, "Mã đơn đã tồn tại.");
                _orderIdTextBox.Focus();
                return;
            }

            _orders.Add(order);
            RefreshVisibleOrders();
            SelectOrder(order);
        }

        private void UpdateOrder()
        {
            if (_selectedOrder is null)
            {
                MessageBox.Show(this, "Vui lòng chọn đơn cần cập nhật trong danh sách.", "Chưa chọn đơn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!TryReadOrder(out var updatedOrder))
            {
                return;
            }

            if (_orders.Any(existing => !ReferenceEquals(existing, _selectedOrder) &&
                string.Equals(existing.OrderId, updatedOrder.OrderId, StringComparison.CurrentCultureIgnoreCase)))
            {
                _errorProvider.SetError(_orderIdTextBox, "Mã đơn đã tồn tại.");
                _orderIdTextBox.Focus();
                return;
            }

            _selectedOrder.OrderId = updatedOrder.OrderId;
            _selectedOrder.CustomerName = updatedOrder.CustomerName;
            _selectedOrder.PhoneNumber = updatedOrder.PhoneNumber;
            _selectedOrder.DeviceType = updatedOrder.DeviceType;
            _selectedOrder.FaultDescription = updatedOrder.FaultDescription;
            _selectedOrder.ReceivedDate = updatedOrder.ReceivedDate;
            _selectedOrder.EstimatedCost = updatedOrder.EstimatedCost;
            _selectedOrder.Status = updatedOrder.Status;
            _selectedOrder.ImagePath = updatedOrder.ImagePath;
            RepairOrder savedOrder = _selectedOrder;
            RefreshVisibleOrders();
            SelectOrder(savedOrder);
        }

        private void DeleteOrder()
        {
            if (_selectedOrder is null)
            {
                MessageBox.Show(this, "Vui lòng chọn đơn cần xóa trong danh sách.", "Chưa chọn đơn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var answer = MessageBox.Show(this, $"Bạn có chắc muốn xóa đơn '{_selectedOrder.OrderId}' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer != DialogResult.Yes)
            {
                return;
            }

            _orders.Remove(_selectedOrder);
            ClearInput();
            RefreshVisibleOrders();
        }

        private bool TryReadOrder(out RepairOrder order)
        {
            ClearValidationErrors();
            bool isValid = true;
            string orderId = _orderIdTextBox.Text.Trim();
            string customerName = _customerNameTextBox.Text.Trim();
            string phoneNumber = _phoneNumberTextBox.Text.Trim();
            string description = _faultDescriptionTextBox.Text.Trim();

            if (orderId.Length == 0)
            {
                _errorProvider.SetError(_orderIdTextBox, "Vui lòng nhập mã đơn.");
                isValid = false;
            }
            if (customerName.Length == 0)
            {
                _errorProvider.SetError(_customerNameTextBox, "Vui lòng nhập tên khách hàng.");
                isValid = false;
            }
            if (phoneNumber.Length == 0)
            {
                _errorProvider.SetError(_phoneNumberTextBox, "Vui lòng nhập số điện thoại.");
                isValid = false;
            }
            if (description.Length == 0)
            {
                _errorProvider.SetError(_faultDescriptionTextBox, "Vui lòng nhập mô tả lỗi.");
                isValid = false;
            }

            bool costIsValid = decimal.TryParse(_estimatedCostTextBox.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out decimal estimatedCost) ||
                decimal.TryParse(_estimatedCostTextBox.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out estimatedCost);
            if (!costIsValid || estimatedCost < 0)
            {
                _errorProvider.SetError(_estimatedCostTextBox, "Chi phí phải là số không âm.");
                isValid = false;
            }

            if (!isValid)
            {
                order = new RepairOrder();
                return false;
            }

            order = new RepairOrder
            {
                OrderId = orderId,
                CustomerName = customerName,
                PhoneNumber = phoneNumber,
                DeviceType = _deviceTypeComboBox.SelectedItem?.ToString() ?? DeviceTypes[0],
                FaultDescription = description,
                ReceivedDate = _receivedDatePicker.Value.Date,
                EstimatedCost = estimatedCost,
                Status = _statusComboBox.SelectedItem?.ToString() ?? OrderStatuses[0],
                ImagePath = _selectedImagePath
            };
            return true;
        }

        private void ChooseImage()
        {
            using var dialog = new OpenFileDialog
            {
                Title = "Chọn ảnh thiết bị",
                Filter = "Tệp ảnh|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Tất cả tệp|*.*",
                CheckFileExists = true,
                Multiselect = false
            };

            if (dialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            try
            {
                using var image = Image.FromFile(dialog.FileName);
                var preview = new Bitmap(image);
                ReplacePreview(preview);
                _selectedImagePath = dialog.FileName;
            }
            catch (Exception exception) when (exception is IOException or UnauthorizedAccessException or ArgumentException)
            {
                MessageBox.Show(this, $"Không thể mở ảnh đã chọn: {exception.Message}", "Lỗi ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowImage(string? imagePath)
        {
            if (string.IsNullOrWhiteSpace(imagePath) || !File.Exists(imagePath))
            {
                ReplacePreview(null);
                return;
            }

            try
            {
                using var image = Image.FromFile(imagePath);
                ReplacePreview(new Bitmap(image));
            }
            catch (Exception exception) when (exception is IOException or UnauthorizedAccessException or ArgumentException)
            {
                ReplacePreview(null);
                MessageBox.Show(this, $"Không thể hiển thị ảnh thiết bị: {exception.Message}", "Lỗi ảnh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ReplacePreview(Image? image)
        {
            Image? oldImage = _devicePictureBox.Image;
            _devicePictureBox.Image = image;
            oldImage?.Dispose();
        }

        private void SelectOrder(RepairOrder order)
        {
            foreach (DataGridViewRow row in _ordersGrid.Rows)
            {
                if (ReferenceEquals(row.DataBoundItem, order))
                {
                    row.Selected = true;
                    if (row.Cells.Count > 0)
                    {
                        _ordersGrid.CurrentCell = row.Cells[0];
                    }
                    LoadSelectedOrder();
                    return;
                }
            }
        }

        private void ClearInput()
        {
            _selectedOrder = null;
            _orderIdTextBox.Clear();
            _customerNameTextBox.Clear();
            _phoneNumberTextBox.Clear();
            _deviceTypeComboBox.SelectedIndex = 0;
            _faultDescriptionTextBox.Clear();
            _receivedDatePicker.Value = DateTime.Today;
            _estimatedCostTextBox.Clear();
            _statusComboBox.SelectedIndex = 0;
            _selectedImagePath = null;
            ReplacePreview(null);
            ClearValidationErrors();
            _orderIdTextBox.Focus();
        }

        private void ClearValidationErrors()
        {
            _errorProvider.Clear();
        }
    }
}

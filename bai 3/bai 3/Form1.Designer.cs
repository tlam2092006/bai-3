namespace bai_3
{
    partial class Form1
    {
        private DataGridView _ordersGrid = null!;
        private TextBox _orderIdTextBox = null!;
        private TextBox _customerNameTextBox = null!;
        private TextBox _phoneNumberTextBox = null!;
        private ComboBox _deviceTypeComboBox = null!;
        private TextBox _faultDescriptionTextBox = null!;
        private DateTimePicker _receivedDatePicker = null!;
        private TextBox _estimatedCostTextBox = null!;
        private ComboBox _statusComboBox = null!;
        private PictureBox _devicePictureBox = null!;
        private TextBox _searchTextBox = null!;
        private ComboBox _statusFilterComboBox = null!;
        private ToolStripStatusLabel _countStatusLabel = null!;
        private ToolStripStatusLabel _costStatusLabel = null!;
        private Button _addButton = null!;
        private Button _updateButton = null!;
        private Button _deleteButton = null!;
        private Button _clearButton = null!;
        private Button _chooseImageButton = null!;
        private TableLayoutPanel _layoutRoot = null!;
        private TableLayoutPanel _orderPanel = null!;
        private TableLayoutPanel _fieldsPanel = null!;
        private FlowLayoutPanel _buttonsPanel = null!;
        private FlowLayoutPanel _searchPanel = null!;
        private TableLayoutPanel _imagePanel = null!;
        private MenuStrip _menuStrip = null!;
        private ToolStripMenuItem _fileMenu = null!;
        private ToolStripMenuItem _exportMenuItem = null!;
        private ToolStripMenuItem _exitMenuItem = null!;
        private StatusStrip _statusStrip = null!;
        private Label _orderIdLabel = null!;
        private Label _customerNameLabel = null!;
        private Label _phoneNumberLabel = null!;
        private Label _deviceTypeLabel = null!;
        private Label _receivedDateLabel = null!;
        private Label _estimatedCostLabel = null!;
        private Label _statusLabel = null!;
        private Label _faultDescriptionLabel = null!;
        private Label _searchLabel = null!;
        private Label _statusFilterLabel = null!;

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _ordersGrid = new DataGridView();
            _orderIdTextBox = new TextBox();
            _customerNameTextBox = new TextBox();
            _phoneNumberTextBox = new TextBox();
            _deviceTypeComboBox = new ComboBox();
            _faultDescriptionTextBox = new TextBox();
            _receivedDatePicker = new DateTimePicker();
            _estimatedCostTextBox = new TextBox();
            _statusComboBox = new ComboBox();
            _devicePictureBox = new PictureBox();
            _searchTextBox = new TextBox();
            _statusFilterComboBox = new ComboBox();
            _countStatusLabel = new ToolStripStatusLabel();
            _costStatusLabel = new ToolStripStatusLabel();
            _addButton = new Button();
            _updateButton = new Button();
            _deleteButton = new Button();
            _clearButton = new Button();
            _chooseImageButton = new Button();
            _layoutRoot = new TableLayoutPanel();
            _orderPanel = new TableLayoutPanel();
            _fieldsPanel = new TableLayoutPanel();
            _orderIdLabel = new Label();
            _customerNameLabel = new Label();
            _phoneNumberLabel = new Label();
            _deviceTypeLabel = new Label();
            _receivedDateLabel = new Label();
            _estimatedCostLabel = new Label();
            _statusLabel = new Label();
            _faultDescriptionLabel = new Label();
            _buttonsPanel = new FlowLayoutPanel();
            _imagePanel = new TableLayoutPanel();
            _searchPanel = new FlowLayoutPanel();
            _searchLabel = new Label();
            _statusFilterLabel = new Label();
            _menuStrip = new MenuStrip();
            _fileMenu = new ToolStripMenuItem();
            _exportMenuItem = new ToolStripMenuItem();
            _exitMenuItem = new ToolStripMenuItem();
            _statusStrip = new StatusStrip();
            ((System.ComponentModel.ISupportInitialize)_ordersGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_devicePictureBox).BeginInit();
            _layoutRoot.SuspendLayout();
            _orderPanel.SuspendLayout();
            _fieldsPanel.SuspendLayout();
            _buttonsPanel.SuspendLayout();
            _imagePanel.SuspendLayout();
            _searchPanel.SuspendLayout();
            _menuStrip.SuspendLayout();
            _statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // _ordersGrid
            // 
            _ordersGrid.AllowUserToAddRows = false;
            _ordersGrid.AllowUserToDeleteRows = false;
            _ordersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _ordersGrid.ColumnHeadersHeight = 29;
            _ordersGrid.Dock = DockStyle.Fill;
            _ordersGrid.Location = new Point(13, 444);
            _ordersGrid.MultiSelect = false;
            _ordersGrid.Name = "_ordersGrid";
            _ordersGrid.ReadOnly = true;
            _ordersGrid.RowHeadersVisible = false;
            _ordersGrid.RowHeadersWidth = 51;
            _ordersGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _ordersGrid.Size = new Size(1174, 309);
            _ordersGrid.TabIndex = 2;
            // 
            // _orderIdTextBox
            // 
            _orderIdTextBox.Dock = DockStyle.Fill;
            _orderIdTextBox.Location = new Point(108, 10);
            _orderIdTextBox.Margin = new Padding(3, 6, 8, 6);
            _orderIdTextBox.Name = "_orderIdTextBox";
            _orderIdTextBox.Size = new Size(297, 27);
            _orderIdTextBox.TabIndex = 1;
            // 
            // _customerNameTextBox
            // 
            _customerNameTextBox.Dock = DockStyle.Fill;
            _customerNameTextBox.Location = new Point(521, 10);
            _customerNameTextBox.Margin = new Padding(3, 6, 8, 6);
            _customerNameTextBox.Name = "_customerNameTextBox";
            _customerNameTextBox.Size = new Size(298, 27);
            _customerNameTextBox.TabIndex = 3;
            // 
            // _phoneNumberTextBox
            // 
            _phoneNumberTextBox.Dock = DockStyle.Fill;
            _phoneNumberTextBox.Location = new Point(108, 56);
            _phoneNumberTextBox.Margin = new Padding(3, 6, 8, 6);
            _phoneNumberTextBox.Name = "_phoneNumberTextBox";
            _phoneNumberTextBox.Size = new Size(297, 27);
            _phoneNumberTextBox.TabIndex = 5;
            // 
            // _deviceTypeComboBox
            // 
            _deviceTypeComboBox.Dock = DockStyle.Fill;
            _deviceTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _deviceTypeComboBox.Items.AddRange(new object[] { "Điện thoại", "Máy tính bảng", "Laptop", "Máy tính bàn", "Thiết bị khác" });
            _deviceTypeComboBox.Location = new Point(521, 53);
            _deviceTypeComboBox.Name = "_deviceTypeComboBox";
            _deviceTypeComboBox.Size = new Size(303, 28);
            _deviceTypeComboBox.TabIndex = 7;
            // 
            // _faultDescriptionTextBox
            // 
            _fieldsPanel.SetColumnSpan(_faultDescriptionTextBox, 3);
            _faultDescriptionTextBox.Dock = DockStyle.Fill;
            _faultDescriptionTextBox.Location = new Point(108, 191);
            _faultDescriptionTextBox.Multiline = true;
            _faultDescriptionTextBox.Name = "_faultDescriptionTextBox";
            _faultDescriptionTextBox.ScrollBars = ScrollBars.Vertical;
            _faultDescriptionTextBox.Size = new Size(716, 121);
            _faultDescriptionTextBox.TabIndex = 15;
            // 
            // _receivedDatePicker
            // 
            _receivedDatePicker.Dock = DockStyle.Fill;
            _receivedDatePicker.Format = DateTimePickerFormat.Short;
            _receivedDatePicker.Location = new Point(108, 99);
            _receivedDatePicker.Name = "_receivedDatePicker";
            _receivedDatePicker.Size = new Size(302, 27);
            _receivedDatePicker.TabIndex = 9;
            // 
            // _estimatedCostTextBox
            // 
            _estimatedCostTextBox.Dock = DockStyle.Fill;
            _estimatedCostTextBox.Location = new Point(521, 102);
            _estimatedCostTextBox.Margin = new Padding(3, 6, 8, 6);
            _estimatedCostTextBox.Name = "_estimatedCostTextBox";
            _estimatedCostTextBox.Size = new Size(298, 27);
            _estimatedCostTextBox.TabIndex = 11;
            // 
            // _statusComboBox
            // 
            _statusComboBox.Dock = DockStyle.Fill;
            _statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _statusComboBox.Items.AddRange(new object[] { "Mới tiếp nhận", "Đang sửa", "Chờ linh kiện", "Hoàn tất", "Đã hủy" });
            _statusComboBox.Location = new Point(108, 145);
            _statusComboBox.Name = "_statusComboBox";
            _statusComboBox.Size = new Size(302, 28);
            _statusComboBox.TabIndex = 13;
            // 
            // _devicePictureBox
            // 
            _devicePictureBox.BackColor = SystemColors.ControlLight;
            _devicePictureBox.BorderStyle = BorderStyle.FixedSingle;
            _devicePictureBox.Dock = DockStyle.Fill;
            _devicePictureBox.Location = new Point(7, 7);
            _devicePictureBox.Name = "_devicePictureBox";
            _devicePictureBox.Size = new Size(309, 307);
            _devicePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            _devicePictureBox.TabIndex = 0;
            _devicePictureBox.TabStop = false;
            // 
            // _searchTextBox
            // 
            _searchTextBox.Location = new Point(84, 11);
            _searchTextBox.Name = "_searchTextBox";
            _searchTextBox.PlaceholderText = "Mã đơn, tên khách hàng hoặc số điện thoại";
            _searchTextBox.Size = new Size(350, 27);
            _searchTextBox.TabIndex = 1;
            // 
            // _statusFilterComboBox
            // 
            _statusFilterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _statusFilterComboBox.Items.AddRange(new object[] { "Tất cả trạng thái", "Mới tiếp nhận", "Đang sửa", "Chờ linh kiện", "Hoàn tất", "Đã hủy" });
            _statusFilterComboBox.Location = new Point(572, 11);
            _statusFilterComboBox.Name = "_statusFilterComboBox";
            _statusFilterComboBox.Size = new Size(180, 28);
            _statusFilterComboBox.TabIndex = 3;
            // 
            // _countStatusLabel
            // 
            _countStatusLabel.Name = "_countStatusLabel";
            _countStatusLabel.Size = new Size(984, 20);
            _countStatusLabel.Spring = true;
            _countStatusLabel.Text = "Số đơn: 0";
            _countStatusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _costStatusLabel
            // 
            _costStatusLabel.Name = "_costStatusLabel";
            _costStatusLabel.Size = new Size(201, 20);
            _costStatusLabel.Text = "Tổng chi phí chưa hoàn tất: 0";
            // 
            // _addButton
            // 
            _addButton.AutoSize = true;
            _addButton.Location = new Point(3, 9);
            _addButton.Name = "_addButton";
            _addButton.Size = new Size(86, 32);
            _addButton.TabIndex = 0;
            _addButton.Text = "Thêm đơn";
            // 
            // _updateButton
            // 
            _updateButton.AutoSize = true;
            _updateButton.Location = new Point(95, 9);
            _updateButton.Name = "_updateButton";
            _updateButton.Size = new Size(78, 32);
            _updateButton.TabIndex = 1;
            _updateButton.Text = "Cập nhật";
            // 
            // _deleteButton
            // 
            _deleteButton.AutoSize = true;
            _deleteButton.Location = new Point(179, 9);
            _deleteButton.Name = "_deleteButton";
            _deleteButton.Size = new Size(75, 32);
            _deleteButton.TabIndex = 2;
            _deleteButton.Text = "Xóa";
            // 
            // _clearButton
            // 
            _clearButton.AutoSize = true;
            _clearButton.Location = new Point(260, 9);
            _clearButton.Name = "_clearButton";
            _clearButton.Size = new Size(77, 32);
            _clearButton.TabIndex = 3;
            _clearButton.Text = "Làm mới";
            // 
            // _chooseImageButton
            // 
            _chooseImageButton.Dock = DockStyle.Fill;
            _chooseImageButton.Location = new Point(7, 320);
            _chooseImageButton.Name = "_chooseImageButton";
            _chooseImageButton.Size = new Size(309, 36);
            _chooseImageButton.TabIndex = 1;
            _chooseImageButton.Text = "Chọn ảnh thiết bị...";
            // 
            // _layoutRoot
            // 
            _layoutRoot.ColumnCount = 1;
            _layoutRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            _layoutRoot.Controls.Add(_orderPanel, 0, 0);
            _layoutRoot.Controls.Add(_searchPanel, 0, 1);
            _layoutRoot.Controls.Add(_ordersGrid, 0, 2);
            _layoutRoot.Dock = DockStyle.Fill;
            _layoutRoot.Location = new Point(0, 28);
            _layoutRoot.Name = "_layoutRoot";
            _layoutRoot.Padding = new Padding(10);
            _layoutRoot.RowCount = 3;
            _layoutRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            _layoutRoot.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            _layoutRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            _layoutRoot.Size = new Size(1200, 766);
            _layoutRoot.TabIndex = 0;
            // 
            // _orderPanel
            // 
            _orderPanel.ColumnCount = 2;
            _orderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72F));
            _orderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28F));
            _orderPanel.Controls.Add(_fieldsPanel, 0, 0);
            _orderPanel.Controls.Add(_imagePanel, 1, 0);
            _orderPanel.Dock = DockStyle.Fill;
            _orderPanel.Location = new Point(13, 13);
            _orderPanel.Name = "_orderPanel";
            _orderPanel.Padding = new Padding(0, 0, 0, 8);
            _orderPanel.RowCount = 1;
            _orderPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _orderPanel.Size = new Size(1174, 377);
            _orderPanel.TabIndex = 0;
            // 
            // _fieldsPanel
            // 
            _fieldsPanel.ColumnCount = 4;
            _fieldsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            _fieldsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            _fieldsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            _fieldsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            _fieldsPanel.Controls.Add(_orderIdLabel, 0, 0);
            _fieldsPanel.Controls.Add(_orderIdTextBox, 1, 0);
            _fieldsPanel.Controls.Add(_customerNameLabel, 2, 0);
            _fieldsPanel.Controls.Add(_customerNameTextBox, 3, 0);
            _fieldsPanel.Controls.Add(_phoneNumberLabel, 0, 1);
            _fieldsPanel.Controls.Add(_phoneNumberTextBox, 1, 1);
            _fieldsPanel.Controls.Add(_deviceTypeLabel, 2, 1);
            _fieldsPanel.Controls.Add(_deviceTypeComboBox, 3, 1);
            _fieldsPanel.Controls.Add(_receivedDateLabel, 0, 2);
            _fieldsPanel.Controls.Add(_receivedDatePicker, 1, 2);
            _fieldsPanel.Controls.Add(_estimatedCostLabel, 2, 2);
            _fieldsPanel.Controls.Add(_estimatedCostTextBox, 3, 2);
            _fieldsPanel.Controls.Add(_statusLabel, 0, 3);
            _fieldsPanel.Controls.Add(_statusComboBox, 1, 3);
            _fieldsPanel.Controls.Add(_faultDescriptionLabel, 0, 4);
            _fieldsPanel.Controls.Add(_faultDescriptionTextBox, 1, 4);
            _fieldsPanel.Controls.Add(_buttonsPanel, 0, 5);
            _fieldsPanel.Dock = DockStyle.Fill;
            _fieldsPanel.Location = new Point(3, 3);
            _fieldsPanel.Name = "_fieldsPanel";
            _fieldsPanel.Padding = new Padding(0, 4, 12, 0);
            _fieldsPanel.RowCount = 6;
            _fieldsPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            _fieldsPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            _fieldsPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            _fieldsPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            _fieldsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _fieldsPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            _fieldsPanel.Size = new Size(839, 363);
            _fieldsPanel.TabIndex = 0;
            // 
            // _orderIdLabel
            // 
            _orderIdLabel.Dock = DockStyle.Fill;
            _orderIdLabel.Location = new Point(3, 4);
            _orderIdLabel.Name = "_orderIdLabel";
            _orderIdLabel.Size = new Size(99, 46);
            _orderIdLabel.TabIndex = 0;
            _orderIdLabel.Text = "Mã đơn:";
            // 
            // _customerNameLabel
            // 
            _customerNameLabel.Dock = DockStyle.Fill;
            _customerNameLabel.Location = new Point(416, 4);
            _customerNameLabel.Name = "_customerNameLabel";
            _customerNameLabel.Size = new Size(99, 46);
            _customerNameLabel.TabIndex = 2;
            _customerNameLabel.Text = "Tên khách hàng:";
            // 
            // _phoneNumberLabel
            // 
            _phoneNumberLabel.Dock = DockStyle.Fill;
            _phoneNumberLabel.Location = new Point(3, 50);
            _phoneNumberLabel.Name = "_phoneNumberLabel";
            _phoneNumberLabel.Size = new Size(99, 46);
            _phoneNumberLabel.TabIndex = 4;
            _phoneNumberLabel.Text = "Số điện thoại:";
            // 
            // _deviceTypeLabel
            // 
            _deviceTypeLabel.Dock = DockStyle.Fill;
            _deviceTypeLabel.Location = new Point(416, 50);
            _deviceTypeLabel.Name = "_deviceTypeLabel";
            _deviceTypeLabel.Size = new Size(99, 46);
            _deviceTypeLabel.TabIndex = 6;
            _deviceTypeLabel.Text = "Loại thiết bị:";
            // 
            // _receivedDateLabel
            // 
            _receivedDateLabel.Dock = DockStyle.Fill;
            _receivedDateLabel.Location = new Point(3, 96);
            _receivedDateLabel.Name = "_receivedDateLabel";
            _receivedDateLabel.Size = new Size(99, 46);
            _receivedDateLabel.TabIndex = 8;
            _receivedDateLabel.Text = "Ngày tiếp nhận:";
            // 
            // _estimatedCostLabel
            // 
            _estimatedCostLabel.Dock = DockStyle.Fill;
            _estimatedCostLabel.Location = new Point(416, 96);
            _estimatedCostLabel.Name = "_estimatedCostLabel";
            _estimatedCostLabel.Size = new Size(99, 46);
            _estimatedCostLabel.TabIndex = 10;
            _estimatedCostLabel.Text = "Chi phí dự kiến:";
            // 
            // _statusLabel
            // 
            _statusLabel.Dock = DockStyle.Fill;
            _statusLabel.Location = new Point(3, 142);
            _statusLabel.Name = "_statusLabel";
            _statusLabel.Size = new Size(99, 46);
            _statusLabel.TabIndex = 12;
            _statusLabel.Text = "Trạng thái:";
            // 
            // _faultDescriptionLabel
            // 
            _faultDescriptionLabel.Dock = DockStyle.Fill;
            _faultDescriptionLabel.Location = new Point(3, 188);
            _faultDescriptionLabel.Name = "_faultDescriptionLabel";
            _faultDescriptionLabel.Size = new Size(99, 127);
            _faultDescriptionLabel.TabIndex = 14;
            _faultDescriptionLabel.Text = "Mô tả lỗi:";
            // 
            // _buttonsPanel
            // 
            _fieldsPanel.SetColumnSpan(_buttonsPanel, 4);
            _buttonsPanel.Controls.Add(_addButton);
            _buttonsPanel.Controls.Add(_updateButton);
            _buttonsPanel.Controls.Add(_deleteButton);
            _buttonsPanel.Controls.Add(_clearButton);
            _buttonsPanel.Dock = DockStyle.Fill;
            _buttonsPanel.Location = new Point(3, 318);
            _buttonsPanel.Name = "_buttonsPanel";
            _buttonsPanel.Padding = new Padding(0, 6, 0, 0);
            _buttonsPanel.Size = new Size(821, 42);
            _buttonsPanel.TabIndex = 16;
            // 
            // _imagePanel
            // 
            _imagePanel.ColumnCount = 1;
            _imagePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            _imagePanel.Controls.Add(_devicePictureBox, 0, 0);
            _imagePanel.Controls.Add(_chooseImageButton, 0, 1);
            _imagePanel.Dock = DockStyle.Fill;
            _imagePanel.Location = new Point(848, 3);
            _imagePanel.Name = "_imagePanel";
            _imagePanel.Padding = new Padding(4);
            _imagePanel.RowCount = 2;
            _imagePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _imagePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            _imagePanel.Size = new Size(323, 363);
            _imagePanel.TabIndex = 1;
            // 
            // _searchPanel
            // 
            _searchPanel.Controls.Add(_searchLabel);
            _searchPanel.Controls.Add(_searchTextBox);
            _searchPanel.Controls.Add(_statusFilterLabel);
            _searchPanel.Controls.Add(_statusFilterComboBox);
            _searchPanel.Dock = DockStyle.Fill;
            _searchPanel.Location = new Point(13, 396);
            _searchPanel.Name = "_searchPanel";
            _searchPanel.Padding = new Padding(0, 8, 0, 4);
            _searchPanel.Size = new Size(1174, 42);
            _searchPanel.TabIndex = 1;
            _searchPanel.WrapContents = false;
            // 
            // _searchLabel
            // 
            _searchLabel.AutoSize = true;
            _searchLabel.Location = new Point(3, 14);
            _searchLabel.Margin = new Padding(3, 6, 5, 3);
            _searchLabel.Name = "_searchLabel";
            _searchLabel.Size = new Size(73, 20);
            _searchLabel.TabIndex = 0;
            _searchLabel.Text = "Tìm kiếm:";
            // 
            // _statusFilterLabel
            // 
            _statusFilterLabel.AutoSize = true;
            _statusFilterLabel.Location = new Point(461, 14);
            _statusFilterLabel.Margin = new Padding(24, 6, 5, 3);
            _statusFilterLabel.Name = "_statusFilterLabel";
            _statusFilterLabel.Size = new Size(103, 20);
            _statusFilterLabel.TabIndex = 2;
            _statusFilterLabel.Text = "Lọc trạng thái:";
            // 
            // _menuStrip
            // 
            _menuStrip.ImageScalingSize = new Size(20, 20);
            _menuStrip.Items.AddRange(new ToolStripItem[] { _fileMenu });
            _menuStrip.Location = new Point(0, 0);
            _menuStrip.Name = "_menuStrip";
            _menuStrip.Size = new Size(1200, 28);
            _menuStrip.TabIndex = 2;
            // 
            // _fileMenu
            // 
            _fileMenu.DropDownItems.AddRange(new ToolStripItem[] { _exportMenuItem, _exitMenuItem });
            _fileMenu.Name = "_fileMenu";
            _fileMenu.Size = new Size(48, 24);
            _fileMenu.Text = "Tệp";
            // 
            // _exportMenuItem
            // 
            _exportMenuItem.Name = "_exportMenuItem";
            _exportMenuItem.Size = new Size(330, 26);
            _exportMenuItem.Text = "Xuất danh sách đang hiển thị ra CSV";
            // 
            // _exitMenuItem
            // 
            _exitMenuItem.Name = "_exitMenuItem";
            _exitMenuItem.Size = new Size(330, 26);
            _exitMenuItem.Text = "Thoát";
            // 
            // _statusStrip
            // 
            _statusStrip.ImageScalingSize = new Size(20, 20);
            _statusStrip.Items.AddRange(new ToolStripItem[] { _countStatusLabel, _costStatusLabel });
            _statusStrip.Location = new Point(0, 794);
            _statusStrip.Name = "_statusStrip";
            _statusStrip.Size = new Size(1200, 26);
            _statusStrip.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 820);
            Controls.Add(_layoutRoot);
            Controls.Add(_statusStrip);
            Controls.Add(_menuStrip);
            MainMenuStrip = _menuStrip;
            MinimumSize = new Size(900, 680);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Repair Service Tracker";
            ((System.ComponentModel.ISupportInitialize)_ordersGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)_devicePictureBox).EndInit();
            _layoutRoot.ResumeLayout(false);
            _orderPanel.ResumeLayout(false);
            _fieldsPanel.ResumeLayout(false);
            _fieldsPanel.PerformLayout();
            _buttonsPanel.ResumeLayout(false);
            _buttonsPanel.PerformLayout();
            _imagePanel.ResumeLayout(false);
            _searchPanel.ResumeLayout(false);
            _searchPanel.PerformLayout();
            _menuStrip.ResumeLayout(false);
            _menuStrip.PerformLayout();
            _statusStrip.ResumeLayout(false);
            _statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}

namespace HRMngt.View
{
    partial class ThumbTicketView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtChooseUserID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cmbChooseType = new System.Windows.Forms.ComboBox();
            this.cmbChooseMonth = new System.Windows.Forms.ComboBox();
            this.btnCreateThumbTicket = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvThumbTicketTable = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.TypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContentCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoneyCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRead = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlSalaryDetail = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSalaryDetail = new System.Windows.Forms.Button();
            this.pnlThumbTicket = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThumbTicket = new System.Windows.Forms.Button();
            this.pnlCalendar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThumbTicketTable)).BeginInit();
            this.pnlSalaryDetail.SuspendLayout();
            this.pnlThumbTicket.SuspendLayout();
            this.pnlCalendar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::HRMngt.Properties.Resources.read;
            this.dataGridViewImageColumn1.MinimumWidth = 10;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 200;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::HRMngt.Properties.Resources.update;
            this.dataGridViewImageColumn2.MinimumWidth = 10;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 200;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::HRMngt.Properties.Resources.delete;
            this.dataGridViewImageColumn3.MinimumWidth = 10;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 200;
            // 
            // txtChooseUserID
            // 
            this.txtChooseUserID.Location = new System.Drawing.Point(377, 123);
            this.txtChooseUserID.Name = "txtChooseUserID";
            this.txtChooseUserID.Size = new System.Drawing.Size(140, 32);
            this.txtChooseUserID.StateCommon.Border.Color1 = System.Drawing.SystemColors.ControlDarkDark;
            this.txtChooseUserID.StateCommon.Border.Color2 = System.Drawing.SystemColors.ControlDarkDark;
            this.txtChooseUserID.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtChooseUserID.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.txtChooseUserID.StateCommon.Content.Color1 = System.Drawing.SystemColors.ControlDarkDark;
            this.txtChooseUserID.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChooseUserID.TabIndex = 5;
            this.txtChooseUserID.Text = "Mã NV";
            // 
            // cmbChooseType
            // 
            this.cmbChooseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChooseType.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbChooseType.FormattingEnabled = true;
            this.cmbChooseType.Items.AddRange(new object[] {
            "Thumb Up",
            "Ticket"});
            this.cmbChooseType.Location = new System.Drawing.Point(209, 121);
            this.cmbChooseType.Name = "cmbChooseType";
            this.cmbChooseType.Size = new System.Drawing.Size(140, 33);
            this.cmbChooseType.TabIndex = 4;
            this.cmbChooseType.Text = "Loại";
            // 
            // cmbChooseMonth
            // 
            this.cmbChooseMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChooseMonth.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbChooseMonth.FormattingEnabled = true;
            this.cmbChooseMonth.Items.AddRange(new object[] {
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.cmbChooseMonth.Location = new System.Drawing.Point(40, 121);
            this.cmbChooseMonth.Name = "cmbChooseMonth";
            this.cmbChooseMonth.Size = new System.Drawing.Size(140, 33);
            this.cmbChooseMonth.TabIndex = 3;
            this.cmbChooseMonth.Text = "Tháng";
            // 
            // btnCreateThumbTicket
            // 
            this.btnCreateThumbTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateThumbTicket.Location = new System.Drawing.Point(1041, 107);
            this.btnCreateThumbTicket.Name = "btnCreateThumbTicket";
            this.btnCreateThumbTicket.Size = new System.Drawing.Size(106, 52);
            this.btnCreateThumbTicket.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnCreateThumbTicket.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnCreateThumbTicket.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnCreateThumbTicket.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(158)))), ((int)(((byte)(26)))));
            this.btnCreateThumbTicket.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(158)))), ((int)(((byte)(26)))));
            this.btnCreateThumbTicket.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCreateThumbTicket.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnCreateThumbTicket.StateCommon.Border.Rounding = 10;
            this.btnCreateThumbTicket.StateCommon.Border.Width = 1;
            this.btnCreateThumbTicket.StateCommon.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(158)))), ((int)(((byte)(26)))));
            this.btnCreateThumbTicket.StateCommon.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(158)))), ((int)(((byte)(26)))));
            this.btnCreateThumbTicket.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateThumbTicket.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnCreateThumbTicket.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btnCreateThumbTicket.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0);
            this.btnCreateThumbTicket.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(158)))), ((int)(((byte)(26)))));
            this.btnCreateThumbTicket.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(158)))), ((int)(((byte)(26)))));
            this.btnCreateThumbTicket.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnCreateThumbTicket.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btnCreateThumbTicket.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnCreateThumbTicket.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnCreateThumbTicket.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnCreateThumbTicket.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(158)))), ((int)(((byte)(26)))));
            this.btnCreateThumbTicket.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(158)))), ((int)(((byte)(26)))));
            this.btnCreateThumbTicket.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnCreateThumbTicket.StateTracking.Content.LongText.Color1 = System.Drawing.Color.White;
            this.btnCreateThumbTicket.StateTracking.Content.LongText.Color2 = System.Drawing.Color.White;
            this.btnCreateThumbTicket.StateTracking.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnCreateThumbTicket.StateTracking.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btnCreateThumbTicket.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCreateThumbTicket.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCreateThumbTicket.StateTracking.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btnCreateThumbTicket.StateTracking.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btnCreateThumbTicket.TabIndex = 2;
            this.btnCreateThumbTicket.Values.Text = "Tạo";
            // 
            // dgvThumbTicketTable
            // 
            this.dgvThumbTicketTable.AllowUserToAddRows = false;
            this.dgvThumbTicketTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThumbTicketTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThumbTicketTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeCol,
            this.TimeCol,
            this.UserIDCol,
            this.ContentCol,
            this.MoneyCol,
            this.StateCol,
            this.btnRead,
            this.btnUpdate,
            this.btnDelete});
            this.dgvThumbTicketTable.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dgvThumbTicketTable.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuSeparator;
            this.dgvThumbTicketTable.HideOuterBorders = true;
            this.dgvThumbTicketTable.Location = new System.Drawing.Point(40, 178);
            this.dgvThumbTicketTable.Name = "dgvThumbTicketTable";
            this.dgvThumbTicketTable.ReadOnly = true;
            this.dgvThumbTicketTable.RowHeadersVisible = false;
            this.dgvThumbTicketTable.RowHeadersWidth = 90;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvThumbTicketTable.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThumbTicketTable.RowTemplate.Height = 50;
            this.dgvThumbTicketTable.RowTemplate.ReadOnly = true;
            this.dgvThumbTicketTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThumbTicketTable.ShowCellErrors = false;
            this.dgvThumbTicketTable.ShowCellToolTips = false;
            this.dgvThumbTicketTable.ShowEditingIcon = false;
            this.dgvThumbTicketTable.ShowRowErrors = false;
            this.dgvThumbTicketTable.Size = new System.Drawing.Size(1086, 520);
            this.dgvThumbTicketTable.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ContextMenuSeparator;
            this.dgvThumbTicketTable.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.dgvThumbTicketTable.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvThumbTicketTable.StateCommon.DataCell.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.dgvThumbTicketTable.StateCommon.DataCell.Content.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.dgvThumbTicketTable.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(1);
            this.dgvThumbTicketTable.StateCommon.DataCell.Content.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.dgvThumbTicketTable.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvThumbTicketTable.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvThumbTicketTable.StateCommon.HeaderColumn.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.dgvThumbTicketTable.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.dgvThumbTicketTable.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvThumbTicketTable.StateCommon.HeaderColumn.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.dgvThumbTicketTable.StateCommon.HeaderColumn.Content.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.dgvThumbTicketTable.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.dgvThumbTicketTable.StateCommon.HeaderColumn.Content.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.dgvThumbTicketTable.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dgvThumbTicketTable.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.dgvThumbTicketTable.StateSelected.DataCell.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.dgvThumbTicketTable.TabIndex = 1;
            // 
            // TypeCol
            // 
            this.TypeCol.HeaderText = "Loại";
            this.TypeCol.MinimumWidth = 10;
            this.TypeCol.Name = "TypeCol";
            this.TypeCol.ReadOnly = true;
            this.TypeCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TypeCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TypeCol.Width = 200;
            // 
            // TimeCol
            // 
            this.TimeCol.HeaderText = "Thời gian";
            this.TimeCol.MinimumWidth = 10;
            this.TimeCol.Name = "TimeCol";
            this.TimeCol.ReadOnly = true;
            this.TimeCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TimeCol.Width = 300;
            // 
            // UserIDCol
            // 
            this.UserIDCol.HeaderText = "Mã NV";
            this.UserIDCol.MinimumWidth = 10;
            this.UserIDCol.Name = "UserIDCol";
            this.UserIDCol.ReadOnly = true;
            this.UserIDCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UserIDCol.Width = 200;
            // 
            // ContentCol
            // 
            this.ContentCol.HeaderText = "Lý do";
            this.ContentCol.MinimumWidth = 10;
            this.ContentCol.Name = "ContentCol";
            this.ContentCol.ReadOnly = true;
            this.ContentCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ContentCol.Width = 200;
            // 
            // MoneyCol
            // 
            this.MoneyCol.HeaderText = "Số tiền";
            this.MoneyCol.MinimumWidth = 10;
            this.MoneyCol.Name = "MoneyCol";
            this.MoneyCol.ReadOnly = true;
            this.MoneyCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MoneyCol.Width = 200;
            // 
            // StateCol
            // 
            this.StateCol.HeaderText = "Trạng thái";
            this.StateCol.MinimumWidth = 10;
            this.StateCol.Name = "StateCol";
            this.StateCol.ReadOnly = true;
            this.StateCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StateCol.Width = 200;
            // 
            // btnRead
            // 
            this.btnRead.HeaderText = "";
            this.btnRead.Image = global::HRMngt.Properties.Resources.read;
            this.btnRead.MinimumWidth = 10;
            this.btnRead.Name = "btnRead";
            this.btnRead.ReadOnly = true;
            this.btnRead.Width = 200;
            // 
            // btnUpdate
            // 
            this.btnUpdate.HeaderText = "";
            this.btnUpdate.Image = global::HRMngt.Properties.Resources.update;
            this.btnUpdate.MinimumWidth = 10;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ReadOnly = true;
            this.btnUpdate.Width = 200;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "";
            this.btnDelete.Image = global::HRMngt.Properties.Resources.delete;
            this.btnDelete.MinimumWidth = 10;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Width = 200;
            // 
            // pnlSalaryDetail
            // 
            this.pnlSalaryDetail.Controls.Add(this.panel3);
            this.pnlSalaryDetail.Controls.Add(this.btnSalaryDetail);
            this.pnlSalaryDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSalaryDetail.Location = new System.Drawing.Point(775, 3);
            this.pnlSalaryDetail.Name = "pnlSalaryDetail";
            this.pnlSalaryDetail.Size = new System.Drawing.Size(381, 94);
            this.pnlSalaryDetail.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(381, 3);
            this.panel3.TabIndex = 5;
            // 
            // btnSalaryDetail
            // 
            this.btnSalaryDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalaryDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaryDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalaryDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnSalaryDetail.Location = new System.Drawing.Point(-9, -15);
            this.btnSalaryDetail.Name = "btnSalaryDetail";
            this.btnSalaryDetail.Size = new System.Drawing.Size(408, 122);
            this.btnSalaryDetail.TabIndex = 3;
            this.btnSalaryDetail.Text = "Bảng lương";
            this.btnSalaryDetail.UseVisualStyleBackColor = true;
            // 
            // pnlThumbTicket
            // 
            this.pnlThumbTicket.Controls.Add(this.panel1);
            this.pnlThumbTicket.Controls.Add(this.btnThumbTicket);
            this.pnlThumbTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThumbTicket.Location = new System.Drawing.Point(389, 3);
            this.pnlThumbTicket.Name = "pnlThumbTicket";
            this.pnlThumbTicket.Size = new System.Drawing.Size(380, 94);
            this.pnlThumbTicket.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(158)))), ((int)(((byte)(26)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 3);
            this.panel1.TabIndex = 3;
            // 
            // btnThumbTicket
            // 
            this.btnThumbTicket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThumbTicket.BackColor = System.Drawing.Color.White;
            this.btnThumbTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThumbTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(158)))), ((int)(((byte)(26)))));
            this.btnThumbTicket.Location = new System.Drawing.Point(-9, -10);
            this.btnThumbTicket.Name = "btnThumbTicket";
            this.btnThumbTicket.Size = new System.Drawing.Size(403, 117);
            this.btnThumbTicket.TabIndex = 2;
            this.btnThumbTicket.Text = "Khen thưởng/Kỷ luật";
            this.btnThumbTicket.UseVisualStyleBackColor = false;
            // 
            // pnlCalendar
            // 
            this.pnlCalendar.Controls.Add(this.panel2);
            this.pnlCalendar.Controls.Add(this.btnCalendar);
            this.pnlCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCalendar.Location = new System.Drawing.Point(3, 3);
            this.pnlCalendar.Name = "pnlCalendar";
            this.pnlCalendar.Size = new System.Drawing.Size(380, 94);
            this.pnlCalendar.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 3);
            this.panel2.TabIndex = 4;
            // 
            // btnCalendar
            // 
            this.btnCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnCalendar.Location = new System.Drawing.Point(-20, -3);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(413, 103);
            this.btnCalendar.TabIndex = 1;
            this.btnCalendar.Text = "Lịch làm";
            this.btnCalendar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.pnlSalaryDetail, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlCalendar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlThumbTicket, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1159, 100);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // ThumbTicketView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1159, 737);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtChooseUserID);
            this.Controls.Add(this.cmbChooseType);
            this.Controls.Add(this.cmbChooseMonth);
            this.Controls.Add(this.btnCreateThumbTicket);
            this.Controls.Add(this.dgvThumbTicketTable);
            this.Name = "ThumbTicketView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThumbTicketTable)).EndInit();
            this.pnlSalaryDetail.ResumeLayout(false);
            this.pnlThumbTicket.ResumeLayout(false);
            this.pnlCalendar.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtChooseUserID;
        private System.Windows.Forms.ComboBox cmbChooseType;
        private System.Windows.Forms.ComboBox cmbChooseMonth;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCreateThumbTicket;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvThumbTicketTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContentCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneyCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateCol;
        private System.Windows.Forms.DataGridViewImageColumn btnRead;
        private System.Windows.Forms.DataGridViewImageColumn btnUpdate;
        private System.Windows.Forms.DataGridViewImageColumn btnDelete;
        private System.Windows.Forms.Panel pnlSalaryDetail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSalaryDetail;
        private System.Windows.Forms.Panel pnlThumbTicket;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThumbTicket;
        private System.Windows.Forms.Panel pnlCalendar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
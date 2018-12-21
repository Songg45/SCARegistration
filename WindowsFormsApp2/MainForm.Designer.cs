namespace WindowsFormsApp2
{
    partial class MainForm
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
            this.SCANameBox = new System.Windows.Forms.TextBox();
            this.RealNameLabel = new System.Windows.Forms.Label();
            this.SCANameLabel = new System.Windows.Forms.Label();
            this.RealNameBox = new System.Windows.Forms.TextBox();
            this.MemberLabel = new System.Windows.Forms.Label();
            this.MemberBox = new System.Windows.Forms.TextBox();
            this.RegistrationData = new System.Data.DataSet();
            this.Information = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.AddButton = new System.Windows.Forms.Button();
            this.AuditButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.GetMemberButton = new System.Windows.Forms.Button();
            this.RegistrationDataView = new System.Windows.Forms.DataGridView();
            this.memberNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCANameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kingdomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KingdomLabel = new System.Windows.Forms.Label();
            this.KingdomBox = new System.Windows.Forms.TextBox();
            this.ExpiresLabel = new System.Windows.Forms.Label();
            this.ExpiresBox = new System.Windows.Forms.TextBox();
            this.MembershipActiveLabel = new System.Windows.Forms.Label();
            this.MembershipActiveBox = new System.Windows.Forms.ComboBox();
            this.hiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Information)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // SCANameBox
            // 
            this.SCANameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SCANameBox.Location = new System.Drawing.Point(368, 26);
            this.SCANameBox.Name = "SCANameBox";
            this.SCANameBox.Size = new System.Drawing.Size(176, 20);
            this.SCANameBox.TabIndex = 3;
            // 
            // RealNameLabel
            // 
            this.RealNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RealNameLabel.AutoSize = true;
            this.RealNameLabel.Location = new System.Drawing.Point(234, 9);
            this.RealNameLabel.Name = "RealNameLabel";
            this.RealNameLabel.Size = new System.Drawing.Size(60, 13);
            this.RealNameLabel.TabIndex = 1;
            this.RealNameLabel.Text = "Real Name";
            // 
            // SCANameLabel
            // 
            this.SCANameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SCANameLabel.AutoSize = true;
            this.SCANameLabel.Location = new System.Drawing.Point(429, 10);
            this.SCANameLabel.Name = "SCANameLabel";
            this.SCANameLabel.Size = new System.Drawing.Size(59, 13);
            this.SCANameLabel.TabIndex = 2;
            this.SCANameLabel.Text = "SCA Name";
            // 
            // RealNameBox
            // 
            this.RealNameBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RealNameBox.Location = new System.Drawing.Point(157, 26);
            this.RealNameBox.Name = "RealNameBox";
            this.RealNameBox.Size = new System.Drawing.Size(205, 20);
            this.RealNameBox.TabIndex = 2;
            // 
            // MemberLabel
            // 
            this.MemberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemberLabel.AutoSize = true;
            this.MemberLabel.Location = new System.Drawing.Point(44, 10);
            this.MemberLabel.Name = "MemberLabel";
            this.MemberLabel.Size = new System.Drawing.Size(74, 13);
            this.MemberLabel.TabIndex = 4;
            this.MemberLabel.Text = "Membership #";
            // 
            // MemberBox
            // 
            this.MemberBox.Location = new System.Drawing.Point(12, 26);
            this.MemberBox.Name = "MemberBox";
            this.MemberBox.Size = new System.Drawing.Size(127, 20);
            this.MemberBox.TabIndex = 1;
            // 
            // RegistrationData
            // 
            this.RegistrationData.DataSetName = "RegistrationData";
            this.RegistrationData.Tables.AddRange(new System.Data.DataTable[] {
            this.Information});
            // 
            // Information
            // 
            this.Information.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6});
            this.Information.TableName = "Information";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "MemberNumber";
            this.dataColumn1.ColumnName = "MemberNumber";
            this.dataColumn1.DataType = typeof(long);
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "Real Name";
            this.dataColumn2.ColumnName = "RealName";
            // 
            // dataColumn3
            // 
            this.dataColumn3.Caption = "SCA Name";
            this.dataColumn3.ColumnName = "SCAName";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Kingdom";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Expires";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "Status";
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.AddButton.Location = new System.Drawing.Point(452, 92);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(92, 20);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AuditButton
            // 
            this.AuditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AuditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AuditButton.Location = new System.Drawing.Point(12, 198);
            this.AuditButton.Name = "AuditButton";
            this.AuditButton.Size = new System.Drawing.Size(75, 23);
            this.AuditButton.TabIndex = 10;
            this.AuditButton.Text = "Audit";
            this.AuditButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Location = new System.Drawing.Point(469, 198);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // GetMemberButton
            // 
            this.GetMemberButton.Cursor = System.Windows.Forms.Cursors.Help;
            this.GetMemberButton.Location = new System.Drawing.Point(12, 92);
            this.GetMemberButton.Name = "GetMemberButton";
            this.GetMemberButton.Size = new System.Drawing.Size(127, 20);
            this.GetMemberButton.TabIndex = 8;
            this.GetMemberButton.Text = "Get Member Info";
            this.GetMemberButton.UseVisualStyleBackColor = true;
            this.GetMemberButton.Click += new System.EventHandler(this.GetMemberButton_Click);
            // 
            // RegistrationDataView
            // 
            this.RegistrationDataView.AllowUserToAddRows = false;
            this.RegistrationDataView.AllowUserToDeleteRows = false;
            this.RegistrationDataView.AllowUserToResizeColumns = false;
            this.RegistrationDataView.AllowUserToResizeRows = false;
            this.RegistrationDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistrationDataView.AutoGenerateColumns = false;
            this.RegistrationDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RegistrationDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.RegistrationDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegistrationDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberNumberDataGridViewTextBoxColumn,
            this.realNameDataGridViewTextBoxColumn,
            this.sCANameDataGridViewTextBoxColumn,
            this.kingdomDataGridViewTextBoxColumn,
            this.expiresDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.RegistrationDataView.Cursor = System.Windows.Forms.Cursors.No;
            this.RegistrationDataView.DataMember = "Information";
            this.RegistrationDataView.DataSource = this.RegistrationData;
            this.RegistrationDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.RegistrationDataView.Location = new System.Drawing.Point(12, 118);
            this.RegistrationDataView.Name = "RegistrationDataView";
            this.RegistrationDataView.ReadOnly = true;
            this.RegistrationDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.RegistrationDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.RegistrationDataView.Size = new System.Drawing.Size(532, 74);
            this.RegistrationDataView.TabIndex = 0;
            this.RegistrationDataView.TabStop = false;
            // 
            // memberNumberDataGridViewTextBoxColumn
            // 
            this.memberNumberDataGridViewTextBoxColumn.DataPropertyName = "MemberNumber";
            this.memberNumberDataGridViewTextBoxColumn.HeaderText = "MemberNumber";
            this.memberNumberDataGridViewTextBoxColumn.Name = "memberNumberDataGridViewTextBoxColumn";
            this.memberNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // realNameDataGridViewTextBoxColumn
            // 
            this.realNameDataGridViewTextBoxColumn.DataPropertyName = "RealName";
            this.realNameDataGridViewTextBoxColumn.HeaderText = "RealName";
            this.realNameDataGridViewTextBoxColumn.Name = "realNameDataGridViewTextBoxColumn";
            this.realNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sCANameDataGridViewTextBoxColumn
            // 
            this.sCANameDataGridViewTextBoxColumn.DataPropertyName = "SCAName";
            this.sCANameDataGridViewTextBoxColumn.HeaderText = "SCAName";
            this.sCANameDataGridViewTextBoxColumn.Name = "sCANameDataGridViewTextBoxColumn";
            this.sCANameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kingdomDataGridViewTextBoxColumn
            // 
            this.kingdomDataGridViewTextBoxColumn.DataPropertyName = "Kingdom";
            this.kingdomDataGridViewTextBoxColumn.HeaderText = "Kingdom";
            this.kingdomDataGridViewTextBoxColumn.Name = "kingdomDataGridViewTextBoxColumn";
            this.kingdomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expiresDataGridViewTextBoxColumn
            // 
            this.expiresDataGridViewTextBoxColumn.DataPropertyName = "Expires";
            this.expiresDataGridViewTextBoxColumn.HeaderText = "Expires";
            this.expiresDataGridViewTextBoxColumn.Name = "expiresDataGridViewTextBoxColumn";
            this.expiresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // KingdomLabel
            // 
            this.KingdomLabel.AutoSize = true;
            this.KingdomLabel.Location = new System.Drawing.Point(44, 51);
            this.KingdomLabel.Name = "KingdomLabel";
            this.KingdomLabel.Size = new System.Drawing.Size(48, 13);
            this.KingdomLabel.TabIndex = 11;
            this.KingdomLabel.Text = "Kingdom";
            // 
            // KingdomBox
            // 
            this.KingdomBox.Location = new System.Drawing.Point(12, 67);
            this.KingdomBox.Name = "KingdomBox";
            this.KingdomBox.Size = new System.Drawing.Size(127, 20);
            this.KingdomBox.TabIndex = 4;
            // 
            // ExpiresLabel
            // 
            this.ExpiresLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExpiresLabel.AutoSize = true;
            this.ExpiresLabel.Location = new System.Drawing.Point(234, 51);
            this.ExpiresLabel.Name = "ExpiresLabel";
            this.ExpiresLabel.Size = new System.Drawing.Size(41, 13);
            this.ExpiresLabel.TabIndex = 13;
            this.ExpiresLabel.Text = "Expires";
            // 
            // ExpiresBox
            // 
            this.ExpiresBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExpiresBox.Location = new System.Drawing.Point(206, 66);
            this.ExpiresBox.Name = "ExpiresBox";
            this.ExpiresBox.Size = new System.Drawing.Size(100, 20);
            this.ExpiresBox.TabIndex = 5;
            // 
            // MembershipActiveLabel
            // 
            this.MembershipActiveLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MembershipActiveLabel.AutoSize = true;
            this.MembershipActiveLabel.Location = new System.Drawing.Point(402, 51);
            this.MembershipActiveLabel.Name = "MembershipActiveLabel";
            this.MembershipActiveLabel.Size = new System.Drawing.Size(103, 13);
            this.MembershipActiveLabel.TabIndex = 15;
            this.MembershipActiveLabel.Text = "Membership Active?";
            // 
            // MembershipActiveBox
            // 
            this.MembershipActiveBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MembershipActiveBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.MembershipActiveBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.MembershipActiveBox.Items.AddRange(new object[] {
            "Active",
            "Expired",
            "NA"});
            this.MembershipActiveBox.Location = new System.Drawing.Point(393, 66);
            this.MembershipActiveBox.Name = "MembershipActiveBox";
            this.MembershipActiveBox.Size = new System.Drawing.Size(121, 21);
            this.MembershipActiveBox.TabIndex = 6;
            // 
            // hiDataGridViewTextBoxColumn
            // 
            this.hiDataGridViewTextBoxColumn.DataPropertyName = "Hi";
            this.hiDataGridViewTextBoxColumn.HeaderText = "Hi";
            this.hiDataGridViewTextBoxColumn.Name = "hiDataGridViewTextBoxColumn";
            this.hiDataGridViewTextBoxColumn.Width = 509;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(556, 233);
            this.Controls.Add(this.MembershipActiveBox);
            this.Controls.Add(this.MembershipActiveLabel);
            this.Controls.Add(this.ExpiresBox);
            this.Controls.Add(this.ExpiresLabel);
            this.Controls.Add(this.KingdomBox);
            this.Controls.Add(this.KingdomLabel);
            this.Controls.Add(this.RegistrationDataView);
            this.Controls.Add(this.GetMemberButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.AuditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MemberBox);
            this.Controls.Add(this.MemberLabel);
            this.Controls.Add(this.RealNameBox);
            this.Controls.Add(this.SCANameLabel);
            this.Controls.Add(this.RealNameLabel);
            this.Controls.Add(this.SCANameBox);
            this.Name = "MainForm";
            this.Text = "Sign In";
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Information)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label RealNameLabel;
        private System.Windows.Forms.Label SCANameLabel;
        private System.Windows.Forms.Label MemberLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button AuditButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button GetMemberButton;
        private System.Windows.Forms.DataGridView RegistrationDataView;
        private System.Windows.Forms.Label KingdomLabel;
        private System.Windows.Forms.Label ExpiresLabel;
        private System.Windows.Forms.Label MembershipActiveLabel;
        public System.Windows.Forms.TextBox KingdomBox;
        public System.Windows.Forms.TextBox ExpiresBox;
        public System.Windows.Forms.ComboBox MembershipActiveBox;
        public System.Windows.Forms.TextBox SCANameBox;
        public System.Windows.Forms.TextBox RealNameBox;
        public System.Windows.Forms.TextBox MemberBox;
        public System.Data.DataSet RegistrationData;
        public System.Data.DataTable Information;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn realNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCANameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kingdomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hiDataGridViewTextBoxColumn;
    }
}


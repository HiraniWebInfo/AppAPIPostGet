namespace App9M
{
    partial class frmLoginAPI
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label4 = new Label();
            txtRespBody = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtReqText = new TextBox();
            txtAPIUrl = new TextBox();
            btnGo = new Button();
            cboReqType = new ComboBox();
            dgvParameters = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            source = new DataGridViewTextBoxColumn();
            pathValue = new DataGridViewTextBoxColumn();
            FinalValue = new DataGridViewTextBoxColumn();
            CreatedDate = new DataGridViewTextBoxColumn();
            UpdatedDate = new DataGridViewTextBoxColumn();
            label6 = new Label();
            cboType = new ComboBox();
            cboSource = new ComboBox();
            txtName = new TextBox();
            btnSave = new Button();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtPathValue = new TextBox();
            btnSaveNclose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvParameters).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 470);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 18;
            label4.Text = "Response Body";
            // 
            // txtRespBody
            // 
            txtRespBody.Location = new Point(10, 488);
            txtRespBody.Multiline = true;
            txtRespBody.Name = "txtRespBody";
            txtRespBody.ReadOnly = true;
            txtRespBody.ScrollBars = ScrollBars.Both;
            txtRespBody.Size = new Size(524, 99);
            txtRespBody.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 350);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 16;
            label3.Text = "Request Body";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 289);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 12;
            label2.Text = "Request URL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 289);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 11;
            label1.Text = "Request Type";
            // 
            // txtReqText
            // 
            txtReqText.Location = new Point(10, 368);
            txtReqText.Multiline = true;
            txtReqText.Name = "txtReqText";
            txtReqText.ScrollBars = ScrollBars.Both;
            txtReqText.Size = new Size(524, 99);
            txtReqText.TabIndex = 17;
            // 
            // txtAPIUrl
            // 
            txtAPIUrl.Location = new Point(116, 312);
            txtAPIUrl.Name = "txtAPIUrl";
            txtAPIUrl.Size = new Size(312, 23);
            txtAPIUrl.TabIndex = 14;
            // 
            // btnGo
            // 
            btnGo.Location = new Point(434, 312);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(100, 23);
            btnGo.TabIndex = 15;
            btnGo.Text = "Go";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // cboReqType
            // 
            cboReqType.FormattingEnabled = true;
            cboReqType.Items.AddRange(new object[] { "GET", "POST", "PUT", "PATCH", "DELETE" });
            cboReqType.Location = new Point(10, 312);
            cboReqType.Name = "cboReqType";
            cboReqType.Size = new Size(100, 23);
            cboReqType.TabIndex = 13;
            cboReqType.SelectedIndexChanged += cboReqType_SelectedIndexChanged;
            // 
            // dgvParameters
            // 
            dgvParameters.AllowUserToAddRows = false;
            dgvParameters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParameters.Columns.AddRange(new DataGridViewColumn[] { id, name, type, source, pathValue, FinalValue, CreatedDate, UpdatedDate });
            dgvParameters.Location = new Point(12, 91);
            dgvParameters.Name = "dgvParameters";
            dgvParameters.ReadOnly = true;
            dgvParameters.RowHeadersVisible = false;
            dgvParameters.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParameters.Size = new Size(524, 190);
            dgvParameters.TabIndex = 10;
            dgvParameters.UserDeletingRow += dgvParameters_UserDeletingRow;
            dgvParameters.DoubleClick += dgvParameters_DoubleClick;
            // 
            // id
            // 
            id.DataPropertyName = "Id";
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.2F);
            id.DefaultCellStyle = dataGridViewCellStyle1;
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 30;
            // 
            // name
            // 
            name.DataPropertyName = "Name";
            name.DefaultCellStyle = dataGridViewCellStyle1;
            name.HeaderText = "Name";
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 140;
            // 
            // type
            // 
            type.DataPropertyName = "Type";
            type.DefaultCellStyle = dataGridViewCellStyle1;
            type.HeaderText = "Type";
            type.Name = "type";
            type.ReadOnly = true;
            type.Width = 50;
            // 
            // source
            // 
            source.DataPropertyName = "Source";
            source.DefaultCellStyle = dataGridViewCellStyle1;
            source.HeaderText = "Source";
            source.Name = "source";
            source.ReadOnly = true;
            source.Width = 50;
            // 
            // pathValue
            // 
            pathValue.DataPropertyName = "PathValue";
            pathValue.DefaultCellStyle = dataGridViewCellStyle1;
            pathValue.HeaderText = "Path / Value";
            pathValue.Name = "pathValue";
            pathValue.ReadOnly = true;
            pathValue.Width = 251;
            // 
            // FinalValue
            // 
            FinalValue.DataPropertyName = "FinalValue";
            FinalValue.DefaultCellStyle = dataGridViewCellStyle1;
            FinalValue.HeaderText = "FinalValue";
            FinalValue.Name = "FinalValue";
            FinalValue.ReadOnly = true;
            FinalValue.Visible = false;
            // 
            // CreatedDate
            // 
            CreatedDate.DataPropertyName = "CreatedDate";
            CreatedDate.DefaultCellStyle = dataGridViewCellStyle1;
            CreatedDate.HeaderText = "CreatedDate";
            CreatedDate.Name = "CreatedDate";
            CreatedDate.ReadOnly = true;
            CreatedDate.Visible = false;
            // 
            // UpdatedDate
            // 
            UpdatedDate.DataPropertyName = "UpdatedDate";
            UpdatedDate.DefaultCellStyle = dataGridViewCellStyle1;
            UpdatedDate.HeaderText = "UpdatedDate";
            UpdatedDate.Name = "UpdatedDate";
            UpdatedDate.ReadOnly = true;
            UpdatedDate.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 73);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 27;
            label6.Text = "Parameters";
            // 
            // cboType
            // 
            cboType.FormattingEnabled = true;
            cboType.Items.AddRange(new object[] { "Static", "Capture" });
            cboType.Location = new Point(118, 28);
            cboType.Name = "cboType";
            cboType.Size = new Size(87, 23);
            cboType.TabIndex = 6;
            // 
            // cboSource
            // 
            cboSource.FormattingEnabled = true;
            cboSource.Items.AddRange(new object[] { "---", "Header", "Body" });
            cboSource.Location = new Point(211, 28);
            cboSource.Name = "cboSource";
            cboSource.Size = new Size(86, 23);
            cboSource.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(436, 57);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 23);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 10);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 2;
            label5.Text = "Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(211, 10);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 3;
            label7.Text = "Source";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 9);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 1;
            label8.Text = "Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(303, 9);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 4;
            label9.Text = "Path / Value";
            // 
            // txtPathValue
            // 
            txtPathValue.Location = new Point(303, 28);
            txtPathValue.Name = "txtPathValue";
            txtPathValue.Size = new Size(233, 23);
            txtPathValue.TabIndex = 8;
            // 
            // btnSaveNclose
            // 
            btnSaveNclose.Location = new Point(434, 597);
            btnSaveNclose.Name = "btnSaveNclose";
            btnSaveNclose.Size = new Size(100, 23);
            btnSaveNclose.TabIndex = 20;
            btnSaveNclose.Text = "Save && Close";
            btnSaveNclose.UseVisualStyleBackColor = true;
            btnSaveNclose.Click += btnSaveNclose_Click;
            // 
            // frmLoginAPI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 632);
            Controls.Add(btnSaveNclose);
            Controls.Add(label9);
            Controls.Add(txtPathValue);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(btnSave);
            Controls.Add(txtName);
            Controls.Add(cboSource);
            Controls.Add(cboType);
            Controls.Add(label6);
            Controls.Add(dgvParameters);
            Controls.Add(label4);
            Controls.Add(txtRespBody);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtReqText);
            Controls.Add(txtAPIUrl);
            Controls.Add(btnGo);
            Controls.Add(cboReqType);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLoginAPI";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Set Login API";
            FormClosed += frmLoginAPI_FormClosed;
            Load += frmLoginAPI_Load;
            ((System.ComponentModel.ISupportInitialize)dgvParameters).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox txtRespBody;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtReqText;
        private TextBox txtAPIUrl;
        private Button btnGo;
        private ComboBox cboReqType;
        private DataGridView dgvParameters;
        private Label label6;
        private ComboBox cboType;
        private ComboBox cboSource;
        private TextBox txtName;
        private Button btnSave;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtPathValue;
        private Button btnSaveNclose;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn source;
        private DataGridViewTextBoxColumn pathValue;
        private DataGridViewTextBoxColumn FinalValue;
        private DataGridViewTextBoxColumn CreatedDate;
        private DataGridViewTextBoxColumn UpdatedDate;
    }
}
namespace App9M
{
    partial class frmSetParams
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
            label1 = new Label();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            comboBox1 = new ComboBox();
            label3 = new Label();
            lstDynVariables = new ListBox();
            btnAdd = new Button();
            label4 = new Label();
            btnCancel = new Button();
            btnSaveNClose = new Button();
            dgvHeaders = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            HeaderKey = new DataGridViewTextBoxColumn();
            HeaderValue = new DataGridViewTextBoxColumn();
            HeaderFinalValue = new DataGridViewTextBoxColumn();
            CreatedDate = new DataGridViewTextBoxColumn();
            UpdatedDate = new DataGridViewTextBoxColumn();
            txtValue = new TextBox();
            txtHeader = new TextBox();
            label2 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHeaders).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Query String", "Url" });
            comboBox1.Location = new Point(91, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(599, 9);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 8;
            label3.Text = "Dynamic variables";
            // 
            // lstDynVariables
            // 
            lstDynVariables.FormattingEnabled = true;
            lstDynVariables.ItemHeight = 15;
            lstDynVariables.Location = new Point(599, 27);
            lstDynVariables.Name = "lstDynVariables";
            lstDynVariables.Size = new Size(189, 349);
            lstDynVariables.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(463, 87);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 99);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 17;
            label4.Text = "Headers";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(449, 382);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSaveNClose
            // 
            btnSaveNClose.Location = new Point(340, 382);
            btnSaveNClose.Name = "btnSaveNClose";
            btnSaveNClose.Size = new Size(91, 23);
            btnSaveNClose.TabIndex = 16;
            btnSaveNClose.Text = "Save && Close";
            btnSaveNClose.UseVisualStyleBackColor = true;
            // 
            // dgvHeaders
            // 
            dgvHeaders.AllowUserToAddRows = false;
            dgvHeaders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHeaders.Columns.AddRange(new DataGridViewColumn[] { Id, HeaderKey, HeaderValue, HeaderFinalValue, CreatedDate, UpdatedDate });
            dgvHeaders.Location = new Point(12, 116);
            dgvHeaders.Name = "dgvHeaders";
            dgvHeaders.ReadOnly = true;
            dgvHeaders.RowHeadersVisible = false;
            dgvHeaders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHeaders.Size = new Size(526, 260);
            dgvHeaders.TabIndex = 15;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 42;
            // 
            // HeaderKey
            // 
            HeaderKey.DataPropertyName = "HeaderKey";
            HeaderKey.HeaderText = "HeaderKey";
            HeaderKey.Name = "HeaderKey";
            HeaderKey.ReadOnly = true;
            HeaderKey.Width = 230;
            // 
            // HeaderValue
            // 
            HeaderValue.DataPropertyName = "HeaderValue";
            HeaderValue.HeaderText = "HeaderValue";
            HeaderValue.Name = "HeaderValue";
            HeaderValue.ReadOnly = true;
            HeaderValue.Width = 250;
            // 
            // HeaderFinalValue
            // 
            HeaderFinalValue.DataPropertyName = "HeaderFinalValue";
            HeaderFinalValue.HeaderText = "HeaderFinalValue";
            HeaderFinalValue.Name = "HeaderFinalValue";
            HeaderFinalValue.ReadOnly = true;
            HeaderFinalValue.Visible = false;
            // 
            // CreatedDate
            // 
            CreatedDate.DataPropertyName = "CreatedDate";
            CreatedDate.HeaderText = "CreatedDate";
            CreatedDate.Name = "CreatedDate";
            CreatedDate.ReadOnly = true;
            CreatedDate.Visible = false;
            // 
            // UpdatedDate
            // 
            UpdatedDate.DataPropertyName = "UpdatedDate";
            UpdatedDate.HeaderText = "UpdatedDate";
            UpdatedDate.Name = "UpdatedDate";
            UpdatedDate.ReadOnly = true;
            UpdatedDate.Visible = false;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(278, 58);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(260, 23);
            txtValue.TabIndex = 13;
            // 
            // txtHeader
            // 
            txtHeader.Location = new Point(12, 58);
            txtHeader.Name = "txtHeader";
            txtHeader.Size = new Size(260, 23);
            txtHeader.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 40);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 11;
            label2.Text = "Value";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 40);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 10;
            label5.Text = "Header";
            // 
            // frmSetParams
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveNClose);
            Controls.Add(dgvHeaders);
            Controls.Add(txtValue);
            Controls.Add(txtHeader);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(lstDynVariables);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSetParams";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "frmSetParams";
            ((System.ComponentModel.ISupportInitialize)dgvHeaders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private ComboBox comboBox1;
        private Label label3;
        private ListBox lstDynVariables;
        private Button btnAdd;
        private Label label4;
        private Button btnCancel;
        private Button btnSaveNClose;
        private DataGridView dgvHeaders;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn HeaderKey;
        private DataGridViewTextBoxColumn HeaderValue;
        private DataGridViewTextBoxColumn HeaderFinalValue;
        private DataGridViewTextBoxColumn CreatedDate;
        private DataGridViewTextBoxColumn UpdatedDate;
        private TextBox txtValue;
        private TextBox txtHeader;
        private Label label2;
        private Label label5;
    }
}
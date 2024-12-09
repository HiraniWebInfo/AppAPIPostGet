using System.Security.Cryptography;

namespace App9M
{
    partial class frmSetHeaders
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
            label2 = new Label();
            txtHeader = new TextBox();
            txtValue = new TextBox();
            lstDynVariables = new ListBox();
            dgvHeaders = new DataGridView();
            btnSaveNClose = new Button();
            btnCancel = new Button();
            label3 = new Label();
            label4 = new Label();
            btnAdd = new Button();
            Id = new DataGridViewTextBoxColumn();
            HeaderKey = new DataGridViewTextBoxColumn();
            HeaderValue = new DataGridViewTextBoxColumn();
            HeaderFinalValue = new DataGridViewTextBoxColumn();
            CreatedDate = new DataGridViewTextBoxColumn();
            UpdatedDate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvHeaders).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Header";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 9);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Value";
            // 
            // txtHeader
            // 
            txtHeader.Location = new Point(12, 27);
            txtHeader.Name = "txtHeader";
            txtHeader.Size = new Size(260, 23);
            txtHeader.TabIndex = 3;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(278, 27);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(260, 23);
            txtValue.TabIndex = 4;
            // 
            // lstDynVariables
            // 
            lstDynVariables.FormattingEnabled = true;
            lstDynVariables.ItemHeight = 15;
            lstDynVariables.Location = new Point(544, 27);
            lstDynVariables.Name = "lstDynVariables";
            lstDynVariables.Size = new Size(189, 349);
            lstDynVariables.TabIndex = 7;
            lstDynVariables.DoubleClick += lstDynVariables_DoubleClick;
            // 
            // dgvHeaders
            // 
            dgvHeaders.AllowUserToAddRows = false;
            dgvHeaders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHeaders.Columns.AddRange(new DataGridViewColumn[] { Id, HeaderKey, HeaderValue, HeaderFinalValue, CreatedDate, UpdatedDate });
            dgvHeaders.Location = new Point(12, 85);
            dgvHeaders.Name = "dgvHeaders";
            dgvHeaders.ReadOnly = true;
            dgvHeaders.RowHeadersVisible = false;
            dgvHeaders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHeaders.Size = new Size(526, 260);
            dgvHeaders.TabIndex = 6;
            dgvHeaders.UserDeletingRow += dgvHeaders_UserDeletingRow;
            dgvHeaders.DoubleClick += dgvHeaders_DoubleClick;
            // 
            // btnSaveNClose
            // 
            btnSaveNClose.Location = new Point(340, 351);
            btnSaveNClose.Name = "btnSaveNClose";
            btnSaveNClose.Size = new Size(91, 23);
            btnSaveNClose.TabIndex = 8;
            btnSaveNClose.Text = "Save && Close";
            btnSaveNClose.UseVisualStyleBackColor = true;
            btnSaveNClose.Click += btnSaveNClose_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(449, 351);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(544, 9);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 2;
            label3.Text = "Dynamic variables";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 68);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 9;
            label4.Text = "Headers";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(463, 56);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
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
            // frmSetHeaders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 385);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveNClose);
            Controls.Add(dgvHeaders);
            Controls.Add(lstDynVariables);
            Controls.Add(txtValue);
            Controls.Add(txtHeader);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmSetHeaders";
            Text = "frmSetHeaders";
            Load += frmSetHeaders_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHeaders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtHeader;
        private TextBox txtValue;
        private ListBox lstDynVariables;
        private DataGridView dgvHeaders;
        private Button btnSaveNClose;
        private Button btnCancel;
        private Label label3;
        private Label label4;
        private Button btnAdd;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn HeaderKey;
        private DataGridViewTextBoxColumn HeaderValue;
        private DataGridViewTextBoxColumn HeaderFinalValue;
        private DataGridViewTextBoxColumn CreatedDate;
        private DataGridViewTextBoxColumn UpdatedDate;
    }
}
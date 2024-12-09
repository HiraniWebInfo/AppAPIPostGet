namespace App9M
{
    partial class frmMain9M
    {
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
            btnSetBaseUrl = new Button();
            btnSetLoginApi = new Button();
            btnSetRefreshAPI = new Button();
            btnSetHeaders = new Button();
            cboReqType = new ComboBox();
            lstAPI = new ListBox();
            btnSetParams = new Button();
            btnGo = new Button();
            txtAPIUrl = new TextBox();
            txtReqText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtRespBody = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnSavetoList = new Button();
            prgAPIprogress = new ProgressBar();
            bgwRefreshToken = new System.ComponentModel.BackgroundWorker();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnSetBaseUrl
            // 
            btnSetBaseUrl.AutoSize = true;
            btnSetBaseUrl.Location = new Point(14, 12);
            btnSetBaseUrl.Name = "btnSetBaseUrl";
            btnSetBaseUrl.Size = new Size(78, 25);
            btnSetBaseUrl.TabIndex = 1;
            btnSetBaseUrl.Text = "Set Base Url";
            btnSetBaseUrl.UseVisualStyleBackColor = true;
            btnSetBaseUrl.Click += btnSetBaseUrl_Click;
            // 
            // btnSetLoginApi
            // 
            btnSetLoginApi.AutoSize = true;
            btnSetLoginApi.Location = new Point(98, 11);
            btnSetLoginApi.Name = "btnSetLoginApi";
            btnSetLoginApi.Size = new Size(88, 25);
            btnSetLoginApi.TabIndex = 2;
            btnSetLoginApi.Text = "Set Login API";
            btnSetLoginApi.UseVisualStyleBackColor = true;
            btnSetLoginApi.Click += btnSetLoginApi_Click;
            // 
            // btnSetRefreshAPI
            // 
            btnSetRefreshAPI.AutoSize = true;
            btnSetRefreshAPI.Location = new Point(432, 12);
            btnSetRefreshAPI.Name = "btnSetRefreshAPI";
            btnSetRefreshAPI.Size = new Size(100, 25);
            btnSetRefreshAPI.TabIndex = 5;
            btnSetRefreshAPI.Text = "Set Refresh API";
            btnSetRefreshAPI.UseVisualStyleBackColor = true;
            btnSetRefreshAPI.Click += btnSetRefreshAPI_Click;
            // 
            // btnSetHeaders
            // 
            btnSetHeaders.AutoSize = true;
            btnSetHeaders.Location = new Point(192, 12);
            btnSetHeaders.Name = "btnSetHeaders";
            btnSetHeaders.Size = new Size(115, 25);
            btnSetHeaders.TabIndex = 3;
            btnSetHeaders.Text = "Set Global headers";
            btnSetHeaders.UseVisualStyleBackColor = true;
            btnSetHeaders.Click += btnSetHeaders_Click;
            // 
            // cboReqType
            // 
            cboReqType.FormattingEnabled = true;
            cboReqType.Items.AddRange(new object[] { "GET", "POST", "PUT", "PATCH", "DELETE" });
            cboReqType.Location = new Point(12, 79);
            cboReqType.Name = "cboReqType";
            cboReqType.Size = new Size(100, 23);
            cboReqType.TabIndex = 8;
            cboReqType.SelectedIndexChanged += cboReqType_SelectedIndexChanged;
            // 
            // lstAPI
            // 
            lstAPI.FormattingEnabled = true;
            lstAPI.ItemHeight = 15;
            lstAPI.Items.AddRange(new object[] { "1", "2", "3" });
            lstAPI.Location = new Point(565, 38);
            lstAPI.Name = "lstAPI";
            lstAPI.Size = new Size(223, 469);
            lstAPI.TabIndex = 18;
            lstAPI.DoubleClick += lstAPI_DoubleClick;
            // 
            // btnSetParams
            // 
            btnSetParams.AutoSize = true;
            btnSetParams.Location = new Point(313, 11);
            btnSetParams.Name = "btnSetParams";
            btnSetParams.Size = new Size(113, 25);
            btnSetParams.TabIndex = 4;
            btnSetParams.Text = "Set Global Params";
            btnSetParams.UseVisualStyleBackColor = true;
            // 
            // btnGo
            // 
            btnGo.Location = new Point(436, 79);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(100, 23);
            btnGo.TabIndex = 10;
            btnGo.Text = "Go";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // txtAPIUrl
            // 
            txtAPIUrl.Location = new Point(118, 79);
            txtAPIUrl.Name = "txtAPIUrl";
            txtAPIUrl.Size = new Size(312, 23);
            txtAPIUrl.TabIndex = 9;
            // 
            // txtReqText
            // 
            txtReqText.Location = new Point(12, 135);
            txtReqText.Multiline = true;
            txtReqText.Name = "txtReqText";
            txtReqText.ScrollBars = ScrollBars.Both;
            txtReqText.Size = new Size(524, 151);
            txtReqText.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 6;
            label1.Text = "Request Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 56);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 7;
            label2.Text = "Request URL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 11;
            label3.Text = "Request Body";
            // 
            // txtRespBody
            // 
            txtRespBody.Location = new Point(12, 323);
            txtRespBody.Multiline = true;
            txtRespBody.Name = "txtRespBody";
            txtRespBody.ReadOnly = true;
            txtRespBody.ScrollBars = ScrollBars.Both;
            txtRespBody.Size = new Size(524, 151);
            txtRespBody.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 305);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 13;
            label4.Text = "Response Body";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(565, 16);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 17;
            label5.Text = "API List";
            // 
            // btnSavetoList
            // 
            btnSavetoList.Location = new Point(12, 484);
            btnSavetoList.Name = "btnSavetoList";
            btnSavetoList.Size = new Size(100, 23);
            btnSavetoList.TabIndex = 15;
            btnSavetoList.Text = "Save to list";
            btnSavetoList.UseVisualStyleBackColor = true;
            // 
            // prgAPIprogress
            // 
            prgAPIprogress.Location = new Point(330, 484);
            prgAPIprogress.Name = "prgAPIprogress";
            prgAPIprogress.Size = new Size(206, 23);
            prgAPIprogress.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(98, 117);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 19;
            label6.Text = "Requst Headers";
            // 
            // frmMain9M
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 519);
            Controls.Add(label6);
            Controls.Add(prgAPIprogress);
            Controls.Add(btnSavetoList);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtRespBody);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtReqText);
            Controls.Add(txtAPIUrl);
            Controls.Add(btnGo);
            Controls.Add(btnSetParams);
            Controls.Add(lstAPI);
            Controls.Add(cboReqType);
            Controls.Add(btnSetHeaders);
            Controls.Add(btnSetRefreshAPI);
            Controls.Add(btnSetLoginApi);
            Controls.Add(btnSetBaseUrl);
            Name = "frmMain9M";
            Text = "App9M : The tiny low weight API tool";
            FormClosed += frmMain9M_FormClosed;
            Load += frmMain9M_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSetBaseUrl;
        private Button btnSetLoginApi;
        private Button btnSetRefreshAPI;
        private Button btnSetHeaders;
        private ComboBox cboReqType;
        private ListBox lstAPI;
        private Button btnSetParams;
        private Button btnGo;
        private TextBox txtAPIUrl;
        private TextBox txtReqText;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtRespBody;
        private Label label4;
        private Label label5;
        private Button btnSavetoList;
        private ProgressBar prgAPIprogress;
        private System.ComponentModel.BackgroundWorker bgwRefreshToken;
        private Label label6;
    }
}

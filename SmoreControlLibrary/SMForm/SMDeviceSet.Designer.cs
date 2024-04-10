namespace SmoreControlLibrary.SMForm
{
    partial class SMDeviceSet
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbCamlen = new System.Windows.Forms.Label();
            this.ttProjName = new SmoreControlLibrary.SMForm.TextTable();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaveConfig = new SmoreControlLibrary.SMButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ttProductName = new SmoreControlLibrary.SMForm.TextTable();
            this.ttNumber = new SmoreControlLibrary.SMForm.TextTable();
            this.ttDetectUser = new SmoreControlLibrary.SMForm.TextTable();
            this.ttDetectDate = new SmoreControlLibrary.SMForm.TextTable();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 35);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "设备信息设置";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(813, 515);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lbCamlen, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ttProjName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.ttProductName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.ttNumber, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.ttDetectUser, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.ttDetectDate, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 54);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(400, 458);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lbCamlen
            // 
            this.lbCamlen.BackColor = System.Drawing.Color.Transparent;
            this.lbCamlen.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCamlen.ForeColor = System.Drawing.Color.Black;
            this.lbCamlen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCamlen.Location = new System.Drawing.Point(3, 0);
            this.lbCamlen.Name = "lbCamlen";
            this.lbCamlen.Size = new System.Drawing.Size(114, 91);
            this.lbCamlen.TabIndex = 8;
            this.lbCamlen.Text = "项目名称";
            this.lbCamlen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ttProjName
            // 
            this.ttProjName.Location = new System.Drawing.Point(123, 3);
            this.ttProjName.Name = "ttProjName";
            this.ttProjName.Size = new System.Drawing.Size(274, 85);
            this.ttProjName.TabIndex = 24;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(409, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(401, 458);
            this.listBox1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSaveConfig);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(409, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 45);
            this.panel2.TabIndex = 2;
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSaveConfig.BackColorShow = false;
            this.btnSaveConfig.BtnBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSaveConfig.BtnFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveConfig.BtnForeColor = System.Drawing.Color.Black;
            this.btnSaveConfig.BtnImage = null;
            this.btnSaveConfig.BtnText = "保存参数";
            this.btnSaveConfig.ConerRadius = 15;
            this.btnSaveConfig.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSaveConfig.FillColor = System.Drawing.Color.Transparent;
            this.btnSaveConfig.IsRadius = true;
            this.btnSaveConfig.IsShowRect = false;
            this.btnSaveConfig.IsShowTips = false;
            this.btnSaveConfig.Location = new System.Drawing.Point(0, 0);
            this.btnSaveConfig.MouseUpColor = System.Drawing.Color.Empty;
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnSaveConfig.RectWidth = 1;
            this.btnSaveConfig.Size = new System.Drawing.Size(74, 45);
            this.btnSaveConfig.TabIndex = 35;
            this.btnSaveConfig.TabStop = false;
            this.btnSaveConfig.TipsText = "";
            this.btnSaveConfig.BtnClick += new System.EventHandler(this.btnSaveConfig_BtnClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(3, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 91);
            this.label2.TabIndex = 25;
            this.label2.Text = "产品名称";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(3, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 91);
            this.label3.TabIndex = 26;
            this.label3.Text = "委托单号";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(3, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 91);
            this.label4.TabIndex = 27;
            this.label4.Text = "检测人员";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(3, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 91);
            this.label5.TabIndex = 28;
            this.label5.Text = "检测日期";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ttProductName
            // 
            this.ttProductName.Location = new System.Drawing.Point(123, 94);
            this.ttProductName.Name = "ttProductName";
            this.ttProductName.Size = new System.Drawing.Size(274, 85);
            this.ttProductName.TabIndex = 29;
            // 
            // ttNumber
            // 
            this.ttNumber.Location = new System.Drawing.Point(123, 185);
            this.ttNumber.Name = "ttNumber";
            this.ttNumber.Size = new System.Drawing.Size(274, 85);
            this.ttNumber.TabIndex = 30;
            // 
            // ttDetectUser
            // 
            this.ttDetectUser.Location = new System.Drawing.Point(123, 276);
            this.ttDetectUser.Name = "ttDetectUser";
            this.ttDetectUser.Size = new System.Drawing.Size(274, 85);
            this.ttDetectUser.TabIndex = 31;
            // 
            // ttDetectDate
            // 
            this.ttDetectDate.Location = new System.Drawing.Point(123, 367);
            this.ttDetectDate.Name = "ttDetectDate";
            this.ttDetectDate.Size = new System.Drawing.Size(274, 85);
            this.ttDetectDate.TabIndex = 32;
            // 
            // SMDeviceSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "SMDeviceSet";
            this.Size = new System.Drawing.Size(813, 550);
            this.Load += new System.EventHandler(this.SMDeviceSet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Label lbCamlen;
        //private TextTable ttCamLen;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel2;
        private TextTable ttProjName;
        private SMButton btnSaveConfig;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        private TextTable ttProductName;
        private TextTable ttNumber;
        private TextTable ttDetectUser;
        private TextTable ttDetectDate;
        //private SMButton btnSaveConfig;
    }
}

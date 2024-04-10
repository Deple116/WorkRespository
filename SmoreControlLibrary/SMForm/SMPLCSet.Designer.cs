namespace SmoreControlLibrary.SMForm
{
    partial class SMPLCSet
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
            this.btnBackwardRD = new SmoreControlLibrary.SMButton();
            this.btnBackwardWD = new SmoreControlLibrary.SMButton();
            this.btnForwardRD = new SmoreControlLibrary.SMButton();
            this.btnForWardWD = new SmoreControlLibrary.SMButton();
            this.btnStopRD = new SmoreControlLibrary.SMButton();
            this.btnStopWD = new SmoreControlLibrary.SMButton();
            this.btnCallZeroRD = new SmoreControlLibrary.SMButton();
            this.btnCallZeroWD = new SmoreControlLibrary.SMButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartRD = new SmoreControlLibrary.SMButton();
            this.btnStartWD = new SmoreControlLibrary.SMButton();
            this.lbBackWard = new System.Windows.Forms.Label();
            this.lbForward = new System.Windows.Forms.Label();
            this.lbStop = new System.Windows.Forms.Label();
            this.lbBackZero = new System.Windows.Forms.Label();
            this.lbStart = new System.Windows.Forms.Label();
            this.lbReadData = new System.Windows.Forms.Label();
            this.lbWriteData = new System.Windows.Forms.Label();
            this.lbAdress = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.ttStartVal = new SmoreControlLibrary.SMForm.TextTable();
            this.ttCallZeroAdr = new SmoreControlLibrary.SMForm.TextTable();
            this.ttCallbackZeroVal = new SmoreControlLibrary.SMForm.TextTable();
            this.ttStopAdr = new SmoreControlLibrary.SMForm.TextTable();
            this.ttStopVal = new SmoreControlLibrary.SMForm.TextTable();
            this.ttForwardAdr = new SmoreControlLibrary.SMForm.TextTable();
            this.ttForWardVal = new SmoreControlLibrary.SMForm.TextTable();
            this.ttBackwardAdr = new SmoreControlLibrary.SMForm.TextTable();
            this.ttBackWardVal = new SmoreControlLibrary.SMForm.TextTable();
            this.ttStartAdr = new SmoreControlLibrary.SMForm.TextTable();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ttPort = new SmoreControlLibrary.SMForm.TextTable();
            this.ttIP = new SmoreControlLibrary.SMForm.TextTable();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaveConfig = new SmoreControlLibrary.SMButton();
            this.btnPLCDDisConnect = new SmoreControlLibrary.SMButton();
            this.smButton2 = new SmoreControlLibrary.SMButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLC设置";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 1, 1);
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
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnBackwardRD, 4, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnBackwardWD, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnForwardRD, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnForWardWD, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnStopRD, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnStopWD, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnCallZeroRD, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnCallZeroWD, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnStartRD, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnStartWD, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbBackWard, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lbForward, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lbStop, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbBackZero, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbStart, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbReadData, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbWriteData, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbAdress, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ttStartVal, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.ttCallZeroAdr, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.ttCallbackZeroVal, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.ttStopAdr, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.ttStopVal, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.ttForwardAdr, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.ttForWardVal, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.ttBackwardAdr, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.ttBackWardVal, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.ttStartAdr, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 54);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(400, 458);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // btnBackwardRD
            // 
            this.btnBackwardRD.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBackwardRD.BackColorShow = false;
            this.btnBackwardRD.BtnBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBackwardRD.BtnFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBackwardRD.BtnForeColor = System.Drawing.Color.Black;
            this.btnBackwardRD.BtnImage = null;
            this.btnBackwardRD.BtnText = "执行";
            this.btnBackwardRD.ConerRadius = 15;
            this.btnBackwardRD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackwardRD.FillColor = System.Drawing.Color.Transparent;
            this.btnBackwardRD.IsRadius = true;
            this.btnBackwardRD.IsShowRect = false;
            this.btnBackwardRD.IsShowTips = false;
            this.btnBackwardRD.Location = new System.Drawing.Point(323, 228);
            this.btnBackwardRD.MouseUpColor = System.Drawing.Color.Empty;
            this.btnBackwardRD.Name = "btnBackwardRD";
            this.btnBackwardRD.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnBackwardRD.RectWidth = 1;
            this.btnBackwardRD.Size = new System.Drawing.Size(74, 39);
            this.btnBackwardRD.TabIndex = 22;
            this.btnBackwardRD.TabStop = false;
            this.btnBackwardRD.TipsText = "";
            this.btnBackwardRD.BtnClick += new System.EventHandler(this.btnBackwardRD_BtnClick);
            // 
            // btnBackwardWD
            // 
            this.btnBackwardWD.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBackwardWD.BackColorShow = false;
            this.btnBackwardWD.BtnBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBackwardWD.BtnFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBackwardWD.BtnForeColor = System.Drawing.Color.Black;
            this.btnBackwardWD.BtnImage = null;
            this.btnBackwardWD.BtnText = "执行";
            this.btnBackwardWD.ConerRadius = 15;
            this.btnBackwardWD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackwardWD.FillColor = System.Drawing.Color.Transparent;
            this.btnBackwardWD.IsRadius = true;
            this.btnBackwardWD.IsShowRect = false;
            this.btnBackwardWD.IsShowTips = false;
            this.btnBackwardWD.Location = new System.Drawing.Point(243, 228);
            this.btnBackwardWD.MouseUpColor = System.Drawing.Color.Empty;
            this.btnBackwardWD.Name = "btnBackwardWD";
            this.btnBackwardWD.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnBackwardWD.RectWidth = 1;
            this.btnBackwardWD.Size = new System.Drawing.Size(74, 39);
            this.btnBackwardWD.TabIndex = 21;
            this.btnBackwardWD.TabStop = false;
            this.btnBackwardWD.TipsText = "";
            this.btnBackwardWD.BtnClick += new System.EventHandler(this.btnBackwardWD_BtnClick);
            // 
            // btnForwardRD
            // 
            this.btnForwardRD.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnForwardRD.BackColorShow = false;
            this.btnForwardRD.BtnBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnForwardRD.BtnFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnForwardRD.BtnForeColor = System.Drawing.Color.Black;
            this.btnForwardRD.BtnImage = null;
            this.btnForwardRD.BtnText = "执行";
            this.btnForwardRD.ConerRadius = 15;
            this.btnForwardRD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForwardRD.FillColor = System.Drawing.Color.Transparent;
            this.btnForwardRD.IsRadius = true;
            this.btnForwardRD.IsShowRect = false;
            this.btnForwardRD.IsShowTips = false;
            this.btnForwardRD.Location = new System.Drawing.Point(323, 183);
            this.btnForwardRD.MouseUpColor = System.Drawing.Color.Empty;
            this.btnForwardRD.Name = "btnForwardRD";
            this.btnForwardRD.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnForwardRD.RectWidth = 1;
            this.btnForwardRD.Size = new System.Drawing.Size(74, 39);
            this.btnForwardRD.TabIndex = 20;
            this.btnForwardRD.TabStop = false;
            this.btnForwardRD.TipsText = "";
            this.btnForwardRD.BtnClick += new System.EventHandler(this.btnForwardRD_BtnClick);
            // 
            // btnForWardWD
            // 
            this.btnForWardWD.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnForWardWD.BackColorShow = false;
            this.btnForWardWD.BtnBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnForWardWD.BtnFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnForWardWD.BtnForeColor = System.Drawing.Color.Black;
            this.btnForWardWD.BtnImage = null;
            this.btnForWardWD.BtnText = "执行";
            this.btnForWardWD.ConerRadius = 15;
            this.btnForWardWD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForWardWD.FillColor = System.Drawing.Color.Transparent;
            this.btnForWardWD.IsRadius = true;
            this.btnForWardWD.IsShowRect = false;
            this.btnForWardWD.IsShowTips = false;
            this.btnForWardWD.Location = new System.Drawing.Point(243, 183);
            this.btnForWardWD.MouseUpColor = System.Drawing.Color.Empty;
            this.btnForWardWD.Name = "btnForWardWD";
            this.btnForWardWD.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnForWardWD.RectWidth = 1;
            this.btnForWardWD.Size = new System.Drawing.Size(74, 39);
            this.btnForWardWD.TabIndex = 19;
            this.btnForWardWD.TabStop = false;
            this.btnForWardWD.TipsText = "";
            this.btnForWardWD.BtnClick += new System.EventHandler(this.btnForWardWD_BtnClick);
            // 
            // btnStopRD
            // 
            this.btnStopRD.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnStopRD.BackColorShow = false;
            this.btnStopRD.BtnBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnStopRD.BtnFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStopRD.BtnForeColor = System.Drawing.Color.Black;
            this.btnStopRD.BtnImage = null;
            this.btnStopRD.BtnText = "执行";
            this.btnStopRD.ConerRadius = 15;
            this.btnStopRD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStopRD.FillColor = System.Drawing.Color.Transparent;
            this.btnStopRD.IsRadius = true;
            this.btnStopRD.IsShowRect = false;
            this.btnStopRD.IsShowTips = false;
            this.btnStopRD.Location = new System.Drawing.Point(323, 138);
            this.btnStopRD.MouseUpColor = System.Drawing.Color.Empty;
            this.btnStopRD.Name = "btnStopRD";
            this.btnStopRD.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnStopRD.RectWidth = 1;
            this.btnStopRD.Size = new System.Drawing.Size(74, 39);
            this.btnStopRD.TabIndex = 18;
            this.btnStopRD.TabStop = false;
            this.btnStopRD.TipsText = "";
            this.btnStopRD.BtnClick += new System.EventHandler(this.btnStopRD_BtnClick);
            // 
            // btnStopWD
            // 
            this.btnStopWD.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnStopWD.BackColorShow = false;
            this.btnStopWD.BtnBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnStopWD.BtnFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStopWD.BtnForeColor = System.Drawing.Color.Black;
            this.btnStopWD.BtnImage = null;
            this.btnStopWD.BtnText = "执行";
            this.btnStopWD.ConerRadius = 15;
            this.btnStopWD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStopWD.FillColor = System.Drawing.Color.Transparent;
            this.btnStopWD.IsRadius = true;
            this.btnStopWD.IsShowRect = false;
            this.btnStopWD.IsShowTips = false;
            this.btnStopWD.Location = new System.Drawing.Point(243, 138);
            this.btnStopWD.MouseUpColor = System.Drawing.Color.Empty;
            this.btnStopWD.Name = "btnStopWD";
            this.btnStopWD.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnStopWD.RectWidth = 1;
            this.btnStopWD.Size = new System.Drawing.Size(74, 39);
            this.btnStopWD.TabIndex = 17;
            this.btnStopWD.TabStop = false;
            this.btnStopWD.TipsText = "";
            this.btnStopWD.BtnClick += new System.EventHandler(this.btnStopWD_BtnClick);
            // 
            // btnCallZeroRD
            // 
            this.btnCallZeroRD.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCallZeroRD.BackColorShow = false;
            this.btnCallZeroRD.BtnBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCallZeroRD.BtnFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCallZeroRD.BtnForeColor = System.Drawing.Color.Black;
            this.btnCallZeroRD.BtnImage = null;
            this.btnCallZeroRD.BtnText = "执行";
            this.btnCallZeroRD.ConerRadius = 15;
            this.btnCallZeroRD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCallZeroRD.FillColor = System.Drawing.Color.Transparent;
            this.btnCallZeroRD.IsRadius = true;
            this.btnCallZeroRD.IsShowRect = false;
            this.btnCallZeroRD.IsShowTips = false;
            this.btnCallZeroRD.Location = new System.Drawing.Point(323, 93);
            this.btnCallZeroRD.MouseUpColor = System.Drawing.Color.Empty;
            this.btnCallZeroRD.Name = "btnCallZeroRD";
            this.btnCallZeroRD.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnCallZeroRD.RectWidth = 1;
            this.btnCallZeroRD.Size = new System.Drawing.Size(74, 39);
            this.btnCallZeroRD.TabIndex = 16;
            this.btnCallZeroRD.TabStop = false;
            this.btnCallZeroRD.TipsText = "";
            this.btnCallZeroRD.BtnClick += new System.EventHandler(this.btnCallZeroRD_BtnClick);
            // 
            // btnCallZeroWD
            // 
            this.btnCallZeroWD.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCallZeroWD.BackColorShow = false;
            this.btnCallZeroWD.BtnBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCallZeroWD.BtnFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCallZeroWD.BtnForeColor = System.Drawing.Color.Black;
            this.btnCallZeroWD.BtnImage = null;
            this.btnCallZeroWD.BtnText = "执行";
            this.btnCallZeroWD.ConerRadius = 15;
            this.btnCallZeroWD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCallZeroWD.FillColor = System.Drawing.Color.Transparent;
            this.btnCallZeroWD.IsRadius = true;
            this.btnCallZeroWD.IsShowRect = false;
            this.btnCallZeroWD.IsShowTips = false;
            this.btnCallZeroWD.Location = new System.Drawing.Point(243, 93);
            this.btnCallZeroWD.MouseUpColor = System.Drawing.Color.Empty;
            this.btnCallZeroWD.Name = "btnCallZeroWD";
            this.btnCallZeroWD.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnCallZeroWD.RectWidth = 1;
            this.btnCallZeroWD.Size = new System.Drawing.Size(74, 39);
            this.btnCallZeroWD.TabIndex = 15;
            this.btnCallZeroWD.TabStop = false;
            this.btnCallZeroWD.TipsText = "";
            this.btnCallZeroWD.BtnClick += new System.EventHandler(this.btnCallZeroWD_BtnClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(163, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 45);
            this.label2.TabIndex = 14;
            this.label2.Text = "写入值";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartRD
            // 
            this.btnStartRD.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnStartRD.BackColorShow = false;
            this.btnStartRD.BtnBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnStartRD.BtnFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartRD.BtnForeColor = System.Drawing.Color.Black;
            this.btnStartRD.BtnImage = null;
            this.btnStartRD.BtnText = "执行";
            this.btnStartRD.ConerRadius = 15;
            this.btnStartRD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartRD.FillColor = System.Drawing.Color.Transparent;
            this.btnStartRD.IsRadius = true;
            this.btnStartRD.IsShowRect = false;
            this.btnStartRD.IsShowTips = false;
            this.btnStartRD.Location = new System.Drawing.Point(323, 48);
            this.btnStartRD.MouseUpColor = System.Drawing.Color.Empty;
            this.btnStartRD.Name = "btnStartRD";
            this.btnStartRD.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnStartRD.RectWidth = 1;
            this.btnStartRD.Size = new System.Drawing.Size(74, 39);
            this.btnStartRD.TabIndex = 13;
            this.btnStartRD.TabStop = false;
            this.btnStartRD.TipsText = "";
            this.btnStartRD.BtnClick += new System.EventHandler(this.btnStartRD_BtnClick);
            // 
            // btnStartWD
            // 
            this.btnStartWD.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnStartWD.BackColorShow = false;
            this.btnStartWD.BtnBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnStartWD.BtnFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartWD.BtnForeColor = System.Drawing.Color.Black;
            this.btnStartWD.BtnImage = null;
            this.btnStartWD.BtnText = "执行";
            this.btnStartWD.ConerRadius = 15;
            this.btnStartWD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartWD.FillColor = System.Drawing.Color.Transparent;
            this.btnStartWD.IsRadius = true;
            this.btnStartWD.IsShowRect = false;
            this.btnStartWD.IsShowTips = false;
            this.btnStartWD.Location = new System.Drawing.Point(243, 48);
            this.btnStartWD.MouseUpColor = System.Drawing.Color.Empty;
            this.btnStartWD.Name = "btnStartWD";
            this.btnStartWD.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnStartWD.RectWidth = 1;
            this.btnStartWD.Size = new System.Drawing.Size(74, 39);
            this.btnStartWD.TabIndex = 12;
            this.btnStartWD.TabStop = false;
            this.btnStartWD.TipsText = "";
            this.btnStartWD.BtnClick += new System.EventHandler(this.btnStartWD_BtnClick);
            // 
            // lbBackWard
            // 
            this.lbBackWard.BackColor = System.Drawing.Color.Transparent;
            this.lbBackWard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBackWard.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbBackWard.ForeColor = System.Drawing.Color.Black;
            this.lbBackWard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbBackWard.Location = new System.Drawing.Point(3, 225);
            this.lbBackWard.Name = "lbBackWard";
            this.lbBackWard.Size = new System.Drawing.Size(74, 45);
            this.lbBackWard.TabIndex = 11;
            this.lbBackWard.Text = "反转";
            this.lbBackWard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbForward
            // 
            this.lbForward.BackColor = System.Drawing.Color.Transparent;
            this.lbForward.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbForward.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbForward.ForeColor = System.Drawing.Color.Black;
            this.lbForward.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbForward.Location = new System.Drawing.Point(3, 180);
            this.lbForward.Name = "lbForward";
            this.lbForward.Size = new System.Drawing.Size(74, 45);
            this.lbForward.TabIndex = 10;
            this.lbForward.Text = "正转";
            this.lbForward.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbStop
            // 
            this.lbStop.BackColor = System.Drawing.Color.Transparent;
            this.lbStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStop.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbStop.ForeColor = System.Drawing.Color.Black;
            this.lbStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbStop.Location = new System.Drawing.Point(3, 135);
            this.lbStop.Name = "lbStop";
            this.lbStop.Size = new System.Drawing.Size(74, 45);
            this.lbStop.TabIndex = 9;
            this.lbStop.Text = "停止";
            this.lbStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBackZero
            // 
            this.lbBackZero.BackColor = System.Drawing.Color.Transparent;
            this.lbBackZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBackZero.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbBackZero.ForeColor = System.Drawing.Color.Black;
            this.lbBackZero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbBackZero.Location = new System.Drawing.Point(3, 90);
            this.lbBackZero.Name = "lbBackZero";
            this.lbBackZero.Size = new System.Drawing.Size(74, 45);
            this.lbBackZero.TabIndex = 8;
            this.lbBackZero.Text = "回零";
            this.lbBackZero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbStart
            // 
            this.lbStart.BackColor = System.Drawing.Color.Transparent;
            this.lbStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStart.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbStart.ForeColor = System.Drawing.Color.Black;
            this.lbStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbStart.Location = new System.Drawing.Point(3, 45);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(74, 45);
            this.lbStart.TabIndex = 7;
            this.lbStart.Text = "启动";
            this.lbStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbReadData
            // 
            this.lbReadData.BackColor = System.Drawing.Color.Transparent;
            this.lbReadData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbReadData.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbReadData.ForeColor = System.Drawing.Color.Black;
            this.lbReadData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbReadData.Location = new System.Drawing.Point(323, 0);
            this.lbReadData.Name = "lbReadData";
            this.lbReadData.Size = new System.Drawing.Size(74, 45);
            this.lbReadData.TabIndex = 6;
            this.lbReadData.Text = "读数据";
            this.lbReadData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbWriteData
            // 
            this.lbWriteData.BackColor = System.Drawing.Color.Transparent;
            this.lbWriteData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbWriteData.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbWriteData.ForeColor = System.Drawing.Color.Black;
            this.lbWriteData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbWriteData.Location = new System.Drawing.Point(243, 0);
            this.lbWriteData.Name = "lbWriteData";
            this.lbWriteData.Size = new System.Drawing.Size(74, 45);
            this.lbWriteData.TabIndex = 5;
            this.lbWriteData.Text = "写数据";
            this.lbWriteData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAdress
            // 
            this.lbAdress.BackColor = System.Drawing.Color.Transparent;
            this.lbAdress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAdress.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbAdress.ForeColor = System.Drawing.Color.Black;
            this.lbAdress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbAdress.Location = new System.Drawing.Point(83, 0);
            this.lbAdress.Name = "lbAdress";
            this.lbAdress.Size = new System.Drawing.Size(74, 45);
            this.lbAdress.TabIndex = 4;
            this.lbAdress.Text = "寄存器地址";
            this.lbAdress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl1.Location = new System.Drawing.Point(3, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(74, 45);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "\\";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ttStartVal
            // 
            this.ttStartVal.Location = new System.Drawing.Point(163, 48);
            this.ttStartVal.Name = "ttStartVal";
            this.ttStartVal.Size = new System.Drawing.Size(74, 39);
            this.ttStartVal.TabIndex = 24;
            // 
            // ttCallZeroAdr
            // 
            this.ttCallZeroAdr.Location = new System.Drawing.Point(83, 93);
            this.ttCallZeroAdr.Name = "ttCallZeroAdr";
            this.ttCallZeroAdr.Size = new System.Drawing.Size(74, 39);
            this.ttCallZeroAdr.TabIndex = 25;
            // 
            // ttCallbackZeroVal
            // 
            this.ttCallbackZeroVal.Location = new System.Drawing.Point(163, 93);
            this.ttCallbackZeroVal.Name = "ttCallbackZeroVal";
            this.ttCallbackZeroVal.Size = new System.Drawing.Size(74, 39);
            this.ttCallbackZeroVal.TabIndex = 26;
            // 
            // ttStopAdr
            // 
            this.ttStopAdr.Location = new System.Drawing.Point(83, 138);
            this.ttStopAdr.Name = "ttStopAdr";
            this.ttStopAdr.Size = new System.Drawing.Size(74, 39);
            this.ttStopAdr.TabIndex = 27;
            // 
            // ttStopVal
            // 
            this.ttStopVal.Location = new System.Drawing.Point(163, 138);
            this.ttStopVal.Name = "ttStopVal";
            this.ttStopVal.Size = new System.Drawing.Size(74, 39);
            this.ttStopVal.TabIndex = 28;
            // 
            // ttForwardAdr
            // 
            this.ttForwardAdr.Location = new System.Drawing.Point(83, 183);
            this.ttForwardAdr.Name = "ttForwardAdr";
            this.ttForwardAdr.Size = new System.Drawing.Size(74, 39);
            this.ttForwardAdr.TabIndex = 29;
            // 
            // ttForWardVal
            // 
            this.ttForWardVal.Location = new System.Drawing.Point(163, 183);
            this.ttForWardVal.Name = "ttForWardVal";
            this.ttForWardVal.Size = new System.Drawing.Size(74, 39);
            this.ttForWardVal.TabIndex = 30;
            // 
            // ttBackwardAdr
            // 
            this.ttBackwardAdr.Location = new System.Drawing.Point(83, 228);
            this.ttBackwardAdr.Name = "ttBackwardAdr";
            this.ttBackwardAdr.Size = new System.Drawing.Size(74, 39);
            this.ttBackwardAdr.TabIndex = 31;
            // 
            // ttBackWardVal
            // 
            this.ttBackWardVal.Location = new System.Drawing.Point(163, 228);
            this.ttBackWardVal.Name = "ttBackWardVal";
            this.ttBackWardVal.Size = new System.Drawing.Size(74, 39);
            this.ttBackWardVal.TabIndex = 32;
            // 
            // ttStartAdr
            // 
            this.ttStartAdr.Location = new System.Drawing.Point(83, 48);
            this.ttStartAdr.Name = "ttStartAdr";
            this.ttStartAdr.Size = new System.Drawing.Size(74, 39);
            this.ttStartAdr.TabIndex = 23;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ttPort, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.ttIP, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(400, 45);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(283, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 45);
            this.label4.TabIndex = 34;
            this.label4.Text = "端口";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 45);
            this.label3.TabIndex = 33;
            this.label3.Text = "IP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ttPort
            // 
            this.ttPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ttPort.Location = new System.Drawing.Point(343, 3);
            this.ttPort.Name = "ttPort";
            this.ttPort.Size = new System.Drawing.Size(54, 39);
            this.ttPort.TabIndex = 33;
            // 
            // ttIP
            // 
            this.ttIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ttIP.Location = new System.Drawing.Point(43, 3);
            this.ttIP.Name = "ttIP";
            this.ttIP.Size = new System.Drawing.Size(234, 39);
            this.ttIP.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSaveConfig);
            this.panel2.Controls.Add(this.btnPLCDDisConnect);
            this.panel2.Controls.Add(this.smButton2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(409, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 45);
            this.panel2.TabIndex = 3;
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
            this.btnSaveConfig.Location = new System.Drawing.Point(148, 0);
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
            // btnPLCDDisConnect
            // 
            this.btnPLCDDisConnect.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPLCDDisConnect.BackColorShow = false;
            this.btnPLCDDisConnect.BtnBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPLCDDisConnect.BtnFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPLCDDisConnect.BtnForeColor = System.Drawing.Color.Black;
            this.btnPLCDDisConnect.BtnImage = null;
            this.btnPLCDDisConnect.BtnText = "断开";
            this.btnPLCDDisConnect.ConerRadius = 15;
            this.btnPLCDDisConnect.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPLCDDisConnect.FillColor = System.Drawing.Color.Transparent;
            this.btnPLCDDisConnect.IsRadius = true;
            this.btnPLCDDisConnect.IsShowRect = false;
            this.btnPLCDDisConnect.IsShowTips = false;
            this.btnPLCDDisConnect.Location = new System.Drawing.Point(74, 0);
            this.btnPLCDDisConnect.MouseUpColor = System.Drawing.Color.Empty;
            this.btnPLCDDisConnect.Name = "btnPLCDDisConnect";
            this.btnPLCDDisConnect.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnPLCDDisConnect.RectWidth = 1;
            this.btnPLCDDisConnect.Size = new System.Drawing.Size(74, 45);
            this.btnPLCDDisConnect.TabIndex = 33;
            this.btnPLCDDisConnect.TabStop = false;
            this.btnPLCDDisConnect.TipsText = "";
            this.btnPLCDDisConnect.BtnClick += new System.EventHandler(this.btnPLCDDisConnect_BtnClick);
            // 
            // smButton2
            // 
            this.smButton2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.smButton2.BackColorShow = false;
            this.smButton2.BtnBackColor = System.Drawing.SystemColors.ControlDark;
            this.smButton2.BtnFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.smButton2.BtnForeColor = System.Drawing.Color.Black;
            this.smButton2.BtnImage = null;
            this.smButton2.BtnText = "连接";
            this.smButton2.ConerRadius = 15;
            this.smButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.smButton2.FillColor = System.Drawing.Color.Transparent;
            this.smButton2.IsRadius = true;
            this.smButton2.IsShowRect = false;
            this.smButton2.IsShowTips = false;
            this.smButton2.Location = new System.Drawing.Point(0, 0);
            this.smButton2.MouseUpColor = System.Drawing.Color.Empty;
            this.smButton2.Name = "smButton2";
            this.smButton2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.smButton2.RectWidth = 1;
            this.smButton2.Size = new System.Drawing.Size(74, 45);
            this.smButton2.TabIndex = 34;
            this.smButton2.TabStop = false;
            this.smButton2.TipsText = "";
            this.smButton2.BtnClick += new System.EventHandler(this.smButton2_BtnClick);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(409, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(401, 458);
            this.listBox1.TabIndex = 4;
            // 
            // SMPLCSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "SMPLCSet";
            this.Size = new System.Drawing.Size(813, 550);
            this.Load += new System.EventHandler(this.SMPLCSet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Label lbWriteData;
        public System.Windows.Forms.Label lbAdress;
        public System.Windows.Forms.Label lbl1;
        public System.Windows.Forms.Label lbBackWard;
        public System.Windows.Forms.Label lbForward;
        public System.Windows.Forms.Label lbStop;
        public System.Windows.Forms.Label lbBackZero;
        public System.Windows.Forms.Label lbStart;
        public System.Windows.Forms.Label lbReadData;
        private SMButton btnBackwardRD;
        private SMButton btnBackwardWD;
        private SMButton btnForwardRD;
        private SMButton btnForWardWD;
        private SMButton btnStopRD;
        private SMButton btnStopWD;
        private SMButton btnCallZeroRD;
        private SMButton btnCallZeroWD;
        public System.Windows.Forms.Label label2;
        private SMButton btnStartRD;
        private SMButton btnStartWD;
        private TextTable ttStartAdr;
        private TextTable ttStartVal;
        private TextTable ttCallZeroAdr;
        private TextTable ttCallbackZeroVal;
        private TextTable ttStopAdr;
        private TextTable ttStopVal;
        private TextTable ttForwardAdr;
        private TextTable ttForWardVal;
        private TextTable ttBackwardAdr;
        private TextTable ttBackWardVal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        private TextTable ttPort;
        private TextTable ttIP;
        private System.Windows.Forms.Panel panel2;
        private SMButton btnPLCDDisConnect;
        private SMButton smButton2;
        private System.Windows.Forms.ListBox listBox1;
        private SMButton btnSaveConfig;
    }
}

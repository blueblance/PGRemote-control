namespace PGRemote_control
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

         #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_linkpg = new System.Windows.Forms.Button();
            this.btn_bta = new System.Windows.Forms.Button();
            this.btn_pgabort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_hs = new System.Windows.Forms.RadioButton();
            this.btn_lp = new System.Windows.Forms.RadioButton();
            this.btn_savecam = new System.Windows.Forms.Button();
            this.btn_opencam = new System.Windows.Forms.Button();
            this.textbox_dt = new System.Windows.Forms.TextBox();
            this.textbox_par = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_longwrite = new System.Windows.Forms.Button();
            this.btn_shortwrite = new System.Windows.Forms.Button();
            this.btn_openbmp = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_1lane = new System.Windows.Forms.RadioButton();
            this.btn_2lane = new System.Windows.Forms.RadioButton();
            this.btn_3lane = new System.Windows.Forms.RadioButton();
            this.btn_4lane = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox_lpfreq = new System.Windows.Forms.TextBox();
            this.textbox_hsfreq = new System.Windows.Forms.TextBox();
            this.openvideopic = new System.Windows.Forms.OpenFileDialog();
            this.textbox_videopicpath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_senvideopic = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textbox_smrps = new System.Windows.Forms.TextBox();
            this.btn_sendsmrps = new System.Windows.Forms.Button();
            this.btn_dcsread = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textbox_readreg = new System.Windows.Forms.TextBox();
            this.btn_genread = new System.Windows.Forms.Button();
            this.textbox_fortest = new System.Windows.Forms.TextBox();
            this.btn_fortest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_runautotest = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textboxwaittime = new System.Windows.Forms.TextBox();
            this.textboxrpcsave = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.opendutpath = new System.Windows.Forms.OpenFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.textboxhsa = new System.Windows.Forms.TextBox();
            this.textboxvsa = new System.Windows.Forms.TextBox();
            this.textboxvbp = new System.Windows.Forms.TextBox();
            this.textboxhbp = new System.Windows.Forms.TextBox();
            this.textboxvfp = new System.Windows.Forms.TextBox();
            this.textboxhfp = new System.Windows.Forms.TextBox();
            this.textboxvact = new System.Windows.Forms.TextBox();
            this.textboxhact = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textboxfr = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textboxtagetbitrate = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textbox_fortest2 = new System.Windows.Forms.TextBox();
            this.textbox_fortest3 = new System.Windows.Forms.TextBox();
            this.backgroundWorkerwebcam = new System.ComponentModel.BackgroundWorker();
            this.btn_stopwebcam = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkBox_webcam = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btn_stoploop = new System.Windows.Forms.Button();
            this.btn_openautotest = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textbox_autotestfile = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label_skewstate = new System.Windows.Forms.Label();
            this.btn_skewstop = new System.Windows.Forms.Button();
            this.text_skewinterval = new System.Windows.Forms.TextBox();
            this.btn_skewautotest = new System.Windows.Forms.Button();
            this.textbox_skewend = new System.Windows.Forms.TextBox();
            this.textbox_skewstart = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button13 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textbox_hsautospare = new System.Windows.Forms.TextBox();
            this.textbox_hsautoend = new System.Windows.Forms.TextBox();
            this.textbox_hsautostart = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btn_setfluke6 = new System.Windows.Forms.Button();
            this.combobox_portname6 = new System.Windows.Forms.ComboBox();
            this.btn_setfluke5 = new System.Windows.Forms.Button();
            this.combobox_portname5 = new System.Windows.Forms.ComboBox();
            this.btn_setfluke4 = new System.Windows.Forms.Button();
            this.combobox_portname4 = new System.Windows.Forms.ComboBox();
            this.btn_setfluke3 = new System.Windows.Forms.Button();
            this.combobox_portname3 = new System.Windows.Forms.ComboBox();
            this.btn_setfluke2 = new System.Windows.Forms.Button();
            this.combobox_portname2 = new System.Windows.Forms.ComboBox();
            this.btn_setfluke1 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.combobox_portname1 = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundworker_skew = new System.ComponentModel.BackgroundWorker();
            this.label_skewui = new System.Windows.Forms.Label();
            this.label_skewtime = new System.Windows.Forms.Label();
            this.btn_dislinkpg = new System.Windows.Forms.Button();
            this.openrpcpath = new System.Windows.Forms.OpenFileDialog();
            this.btn_exerpc = new System.Windows.Forms.Button();
            this.textbox_statusmsg = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.progressBar_Pot = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textbox_inirpc = new System.Windows.Forms.TextBox();
            this.btn_selini = new System.Windows.Forms.Button();
            this.openinirpc = new System.Windows.Forms.OpenFileDialog();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.backgroundworker_swing = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.settingFlukeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.openfileautoset = new System.Windows.Forms.OpenFileDialog();
            this.backgroundworker_hsspeed = new System.ComponentModel.BackgroundWorker();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.openfiletestseq = new System.Windows.Forms.OpenFileDialog();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort3 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort4 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort5 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort6 = new System.IO.Ports.SerialPort(this.components);
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.btn_swingskewauto = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.backgroundskewswing = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1150, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(57, 22);
            this.textBox1.TabIndex = 0;
            // 
            // btn_linkpg
            // 
            this.btn_linkpg.Location = new System.Drawing.Point(1119, 217);
            this.btn_linkpg.Name = "btn_linkpg";
            this.btn_linkpg.Size = new System.Drawing.Size(75, 23);
            this.btn_linkpg.TabIndex = 1;
            this.btn_linkpg.Text = "連接PG";
            this.btn_linkpg.UseVisualStyleBackColor = true;
            this.btn_linkpg.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_bta
            // 
            this.btn_bta.Location = new System.Drawing.Point(1119, 245);
            this.btn_bta.Name = "btn_bta";
            this.btn_bta.Size = new System.Drawing.Size(75, 23);
            this.btn_bta.TabIndex = 2;
            this.btn_bta.Text = "BTA";
            this.btn_bta.UseVisualStyleBackColor = true;
            this.btn_bta.Click += new System.EventHandler(this.btn_bta_Click);
            // 
            // btn_pgabort
            // 
            this.btn_pgabort.Location = new System.Drawing.Point(1119, 273);
            this.btn_pgabort.Name = "btn_pgabort";
            this.btn_pgabort.Size = new System.Drawing.Size(75, 23);
            this.btn_pgabort.TabIndex = 3;
            this.btn_pgabort.Text = "PG Abort";
            this.btn_pgabort.UseVisualStyleBackColor = true;
            this.btn_pgabort.Click += new System.EventHandler(this.btn_pgabort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1086, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "PG狀態";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_hs);
            this.groupBox1.Controls.Add(this.btn_lp);
            this.groupBox1.Location = new System.Drawing.Point(953, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 69);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HS/LP mode";
            // 
            // btn_hs
            // 
            this.btn_hs.AutoSize = true;
            this.btn_hs.Location = new System.Drawing.Point(5, 40);
            this.btn_hs.Name = "btn_hs";
            this.btn_hs.Size = new System.Drawing.Size(73, 16);
            this.btn_hs.TabIndex = 1;
            this.btn_hs.TabStop = true;
            this.btn_hs.Text = "HS MODE";
            this.btn_hs.UseVisualStyleBackColor = true;
            this.btn_hs.CheckedChanged += new System.EventHandler(this.btn_hs_CheckedChanged);
            // 
            // btn_lp
            // 
            this.btn_lp.AutoSize = true;
            this.btn_lp.Checked = true;
            this.btn_lp.Location = new System.Drawing.Point(6, 16);
            this.btn_lp.Name = "btn_lp";
            this.btn_lp.Size = new System.Drawing.Size(72, 16);
            this.btn_lp.TabIndex = 0;
            this.btn_lp.TabStop = true;
            this.btn_lp.Text = "LP MODE";
            this.btn_lp.UseVisualStyleBackColor = true;
            this.btn_lp.CheckedChanged += new System.EventHandler(this.btn_lp_CheckedChanged);
            // 
            // btn_savecam
            // 
            this.btn_savecam.Location = new System.Drawing.Point(1119, 329);
            this.btn_savecam.Name = "btn_savecam";
            this.btn_savecam.Size = new System.Drawing.Size(75, 23);
            this.btn_savecam.TabIndex = 7;
            this.btn_savecam.Text = "儲存圖檔";
            this.btn_savecam.UseVisualStyleBackColor = true;
            this.btn_savecam.Click += new System.EventHandler(this.btn_savecam_Click);
            // 
            // btn_opencam
            // 
            this.btn_opencam.Location = new System.Drawing.Point(1119, 301);
            this.btn_opencam.Name = "btn_opencam";
            this.btn_opencam.Size = new System.Drawing.Size(75, 23);
            this.btn_opencam.TabIndex = 8;
            this.btn_opencam.Text = "WEBCAM";
            this.btn_opencam.UseVisualStyleBackColor = true;
            this.btn_opencam.Click += new System.EventHandler(this.btn_opencam_Click);
            // 
            // textbox_dt
            // 
            this.textbox_dt.Location = new System.Drawing.Point(95, 18);
            this.textbox_dt.Name = "textbox_dt";
            this.textbox_dt.Size = new System.Drawing.Size(57, 22);
            this.textbox_dt.TabIndex = 9;
            this.textbox_dt.Text = "00";
            // 
            // textbox_par
            // 
            this.textbox_par.Location = new System.Drawing.Point(95, 48);
            this.textbox_par.Name = "textbox_par";
            this.textbox_par.Size = new System.Drawing.Size(57, 22);
            this.textbox_par.TabIndex = 10;
            this.textbox_par.Text = "00";
            this.textbox_par.TextChanged += new System.EventHandler(this.textbox_par_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "Data type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "Parameter";
            // 
            // btn_longwrite
            // 
            this.btn_longwrite.Location = new System.Drawing.Point(33, 93);
            this.btn_longwrite.Name = "btn_longwrite";
            this.btn_longwrite.Size = new System.Drawing.Size(75, 23);
            this.btn_longwrite.TabIndex = 13;
            this.btn_longwrite.Text = "Long Write";
            this.btn_longwrite.UseVisualStyleBackColor = true;
            this.btn_longwrite.Click += new System.EventHandler(this.btn_longwrite_Click);
            // 
            // btn_shortwrite
            // 
            this.btn_shortwrite.Location = new System.Drawing.Point(136, 93);
            this.btn_shortwrite.Name = "btn_shortwrite";
            this.btn_shortwrite.Size = new System.Drawing.Size(75, 23);
            this.btn_shortwrite.TabIndex = 14;
            this.btn_shortwrite.Text = "Short Write";
            this.btn_shortwrite.UseVisualStyleBackColor = true;
            // 
            // btn_openbmp
            // 
            this.btn_openbmp.Location = new System.Drawing.Point(940, 465);
            this.btn_openbmp.Name = "btn_openbmp";
            this.btn_openbmp.Size = new System.Drawing.Size(75, 23);
            this.btn_openbmp.TabIndex = 15;
            this.btn_openbmp.Text = "開啟圖檔";
            this.btn_openbmp.UseVisualStyleBackColor = true;
            this.btn_openbmp.Click += new System.EventHandler(this.btn_openbmp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_1lane);
            this.groupBox2.Controls.Add(this.btn_2lane);
            this.groupBox2.Controls.Add(this.btn_3lane);
            this.groupBox2.Controls.Add(this.btn_4lane);
            this.groupBox2.Location = new System.Drawing.Point(828, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(106, 101);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LANE CNT";
            // 
            // btn_1lane
            // 
            this.btn_1lane.AutoSize = true;
            this.btn_1lane.Location = new System.Drawing.Point(5, 82);
            this.btn_1lane.Name = "btn_1lane";
            this.btn_1lane.Size = new System.Drawing.Size(51, 16);
            this.btn_1lane.TabIndex = 3;
            this.btn_1lane.Text = "1 lane";
            this.btn_1lane.UseVisualStyleBackColor = true;
            this.btn_1lane.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // btn_2lane
            // 
            this.btn_2lane.AutoSize = true;
            this.btn_2lane.Location = new System.Drawing.Point(5, 60);
            this.btn_2lane.Name = "btn_2lane";
            this.btn_2lane.Size = new System.Drawing.Size(51, 16);
            this.btn_2lane.TabIndex = 2;
            this.btn_2lane.Text = "2 lane";
            this.btn_2lane.UseVisualStyleBackColor = true;
            this.btn_2lane.CheckedChanged += new System.EventHandler(this.btn_2lane_CheckedChanged);
            // 
            // btn_3lane
            // 
            this.btn_3lane.AutoSize = true;
            this.btn_3lane.Location = new System.Drawing.Point(5, 38);
            this.btn_3lane.Name = "btn_3lane";
            this.btn_3lane.Size = new System.Drawing.Size(51, 16);
            this.btn_3lane.TabIndex = 1;
            this.btn_3lane.Text = "3 lane";
            this.btn_3lane.UseVisualStyleBackColor = true;
            this.btn_3lane.CheckedChanged += new System.EventHandler(this.btn_3lane_CheckedChanged);
            // 
            // btn_4lane
            // 
            this.btn_4lane.AutoSize = true;
            this.btn_4lane.Checked = true;
            this.btn_4lane.Location = new System.Drawing.Point(5, 15);
            this.btn_4lane.Name = "btn_4lane";
            this.btn_4lane.Size = new System.Drawing.Size(51, 16);
            this.btn_4lane.TabIndex = 0;
            this.btn_4lane.TabStop = true;
            this.btn_4lane.Text = "4 lane";
            this.btn_4lane.UseVisualStyleBackColor = true;
            this.btn_4lane.CheckedChanged += new System.EventHandler(this.btn_4lane_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1086, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "LP FREQ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1086, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "HS FREQ";
            // 
            // textbox_lpfreq
            // 
            this.textbox_lpfreq.Location = new System.Drawing.Point(1150, 101);
            this.textbox_lpfreq.Name = "textbox_lpfreq";
            this.textbox_lpfreq.Size = new System.Drawing.Size(57, 22);
            this.textbox_lpfreq.TabIndex = 18;
            this.textbox_lpfreq.Text = "18";
            // 
            // textbox_hsfreq
            // 
            this.textbox_hsfreq.Location = new System.Drawing.Point(1150, 71);
            this.textbox_hsfreq.Name = "textbox_hsfreq";
            this.textbox_hsfreq.Size = new System.Drawing.Size(57, 22);
            this.textbox_hsfreq.TabIndex = 17;
            this.textbox_hsfreq.Text = "250";
            // 
            // openvideopic
            // 
            this.openvideopic.FileName = "openFileDialog1";
            this.openvideopic.Filter = " (*.bmp)|*.bmp";
            // 
            // textbox_videopicpath
            // 
            this.textbox_videopicpath.Location = new System.Drawing.Point(1002, 424);
            this.textbox_videopicpath.Name = "textbox_videopicpath";
            this.textbox_videopicpath.Size = new System.Drawing.Size(57, 22);
            this.textbox_videopicpath.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(936, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "圖檔位置";
            // 
            // btn_senvideopic
            // 
            this.btn_senvideopic.Location = new System.Drawing.Point(1043, 465);
            this.btn_senvideopic.Name = "btn_senvideopic";
            this.btn_senvideopic.Size = new System.Drawing.Size(75, 23);
            this.btn_senvideopic.TabIndex = 24;
            this.btn_senvideopic.Text = "送圖";
            this.btn_senvideopic.UseVisualStyleBackColor = true;
            this.btn_senvideopic.Click += new System.EventHandler(this.btn_senvideopic_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "SMRPS";
            // 
            // textbox_smrps
            // 
            this.textbox_smrps.Location = new System.Drawing.Point(95, 129);
            this.textbox_smrps.Name = "textbox_smrps";
            this.textbox_smrps.Size = new System.Drawing.Size(57, 22);
            this.textbox_smrps.TabIndex = 25;
            this.textbox_smrps.Text = "1";
            // 
            // btn_sendsmrps
            // 
            this.btn_sendsmrps.Location = new System.Drawing.Point(86, 166);
            this.btn_sendsmrps.Name = "btn_sendsmrps";
            this.btn_sendsmrps.Size = new System.Drawing.Size(75, 23);
            this.btn_sendsmrps.TabIndex = 27;
            this.btn_sendsmrps.Text = "SEND";
            this.btn_sendsmrps.UseVisualStyleBackColor = true;
            this.btn_sendsmrps.Click += new System.EventHandler(this.btn_sendsmrps_Click);
            // 
            // btn_dcsread
            // 
            this.btn_dcsread.Location = new System.Drawing.Point(30, 254);
            this.btn_dcsread.Name = "btn_dcsread";
            this.btn_dcsread.Size = new System.Drawing.Size(75, 23);
            this.btn_dcsread.TabIndex = 30;
            this.btn_dcsread.Text = "DCS READ";
            this.btn_dcsread.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 12);
            this.label8.TabIndex = 29;
            this.label8.Text = "Register";
            // 
            // textbox_readreg
            // 
            this.textbox_readreg.Location = new System.Drawing.Point(95, 208);
            this.textbox_readreg.Name = "textbox_readreg";
            this.textbox_readreg.Size = new System.Drawing.Size(57, 22);
            this.textbox_readreg.TabIndex = 28;
            this.textbox_readreg.Text = "0A";
            // 
            // btn_genread
            // 
            this.btn_genread.Location = new System.Drawing.Point(133, 254);
            this.btn_genread.Name = "btn_genread";
            this.btn_genread.Size = new System.Drawing.Size(75, 23);
            this.btn_genread.TabIndex = 31;
            this.btn_genread.Text = "GEN READ";
            this.btn_genread.UseVisualStyleBackColor = true;
            // 
            // textbox_fortest
            // 
            this.textbox_fortest.Location = new System.Drawing.Point(61, 33);
            this.textbox_fortest.Name = "textbox_fortest";
            this.textbox_fortest.Size = new System.Drawing.Size(100, 22);
            this.textbox_fortest.TabIndex = 32;
            // 
            // btn_fortest
            // 
            this.btn_fortest.Location = new System.Drawing.Point(61, 70);
            this.btn_fortest.Name = "btn_fortest";
            this.btn_fortest.Size = new System.Drawing.Size(75, 23);
            this.btn_fortest.TabIndex = 33;
            this.btn_fortest.Text = "test button2";
            this.btn_fortest.UseVisualStyleBackColor = true;
            this.btn_fortest.Click += new System.EventHandler(this.btn_fortest_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_runautotest
            // 
            this.btn_runautotest.Location = new System.Drawing.Point(1119, 465);
            this.btn_runautotest.Name = "btn_runautotest";
            this.btn_runautotest.Size = new System.Drawing.Size(75, 23);
            this.btn_runautotest.TabIndex = 38;
            this.btn_runautotest.Text = "執行Auto test";
            this.btn_runautotest.UseVisualStyleBackColor = true;
            this.btn_runautotest.Click += new System.EventHandler(this.btn_runautotest_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(425, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 40;
            this.button2.Text = "Setting and send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textboxwaittime
            // 
            this.textboxwaittime.Location = new System.Drawing.Point(36, 21);
            this.textboxwaittime.Name = "textboxwaittime";
            this.textboxwaittime.Size = new System.Drawing.Size(52, 22);
            this.textboxwaittime.TabIndex = 41;
            this.textboxwaittime.Text = "1000";
            // 
            // textboxrpcsave
            // 
            this.textboxrpcsave.Location = new System.Drawing.Point(597, 568);
            this.textboxrpcsave.Name = "textboxrpcsave";
            this.textboxrpcsave.Size = new System.Drawing.Size(100, 22);
            this.textboxrpcsave.TabIndex = 42;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(704, 568);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 43;
            this.button3.Text = "選擇檔案輸出";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // opendutpath
            // 
            this.opendutpath.FileName = "openFileDialog1";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1119, 161);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 44;
            this.button4.Text = "Send Setting";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textboxhsa
            // 
            this.textboxhsa.Location = new System.Drawing.Point(438, 33);
            this.textboxhsa.Name = "textboxhsa";
            this.textboxhsa.Size = new System.Drawing.Size(58, 22);
            this.textboxhsa.TabIndex = 45;
            this.textboxhsa.Text = "80";
            // 
            // textboxvsa
            // 
            this.textboxvsa.Location = new System.Drawing.Point(438, 76);
            this.textboxvsa.Name = "textboxvsa";
            this.textboxvsa.Size = new System.Drawing.Size(58, 22);
            this.textboxvsa.TabIndex = 48;
            this.textboxvsa.Text = "3";
            // 
            // textboxvbp
            // 
            this.textboxvbp.Location = new System.Drawing.Point(505, 76);
            this.textboxvbp.Name = "textboxvbp";
            this.textboxvbp.Size = new System.Drawing.Size(58, 22);
            this.textboxvbp.TabIndex = 49;
            this.textboxvbp.Text = "4";
            // 
            // textboxhbp
            // 
            this.textboxhbp.Location = new System.Drawing.Point(503, 33);
            this.textboxhbp.Name = "textboxhbp";
            this.textboxhbp.Size = new System.Drawing.Size(58, 22);
            this.textboxhbp.TabIndex = 46;
            this.textboxhbp.Text = "80";
            // 
            // textboxvfp
            // 
            this.textboxvfp.Location = new System.Drawing.Point(572, 76);
            this.textboxvfp.Name = "textboxvfp";
            this.textboxvfp.Size = new System.Drawing.Size(58, 22);
            this.textboxvfp.TabIndex = 50;
            this.textboxvfp.Text = "5";
            // 
            // textboxhfp
            // 
            this.textboxhfp.Location = new System.Drawing.Point(573, 33);
            this.textboxhfp.Name = "textboxhfp";
            this.textboxhfp.Size = new System.Drawing.Size(58, 22);
            this.textboxhfp.TabIndex = 47;
            this.textboxhfp.Text = "80";
            // 
            // textboxvact
            // 
            this.textboxvact.Location = new System.Drawing.Point(639, 76);
            this.textboxvact.Name = "textboxvact";
            this.textboxvact.Size = new System.Drawing.Size(58, 22);
            this.textboxvact.TabIndex = 52;
            this.textboxvact.Text = "1920";
            // 
            // textboxhact
            // 
            this.textboxhact.Location = new System.Drawing.Point(642, 33);
            this.textboxhact.Name = "textboxhact";
            this.textboxhact.Size = new System.Drawing.Size(58, 22);
            this.textboxhact.TabIndex = 51;
            this.textboxhact.Text = "1080";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(454, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 12);
            this.label10.TabIndex = 53;
            this.label10.Text = "HSA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(519, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 12);
            this.label11.TabIndex = 54;
            this.label11.Text = "HBP";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(590, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 12);
            this.label12.TabIndex = 55;
            this.label12.Text = "HFP";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(653, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 12);
            this.label13.TabIndex = 56;
            this.label13.Text = "HACT";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(644, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 12);
            this.label14.TabIndex = 60;
            this.label14.Text = "VACT";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(582, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 12);
            this.label15.TabIndex = 59;
            this.label15.Text = "VFP";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(518, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 12);
            this.label16.TabIndex = 58;
            this.label16.Text = "VBP";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(454, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 12);
            this.label17.TabIndex = 57;
            this.label17.Text = "VSA";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(710, 57);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 12);
            this.label18.TabIndex = 62;
            this.label18.Text = "Frame rate";
            // 
            // textboxfr
            // 
            this.textboxfr.Location = new System.Drawing.Point(706, 76);
            this.textboxfr.Name = "textboxfr";
            this.textboxfr.Size = new System.Drawing.Size(58, 22);
            this.textboxfr.TabIndex = 53;
            this.textboxfr.Text = "60";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "24bit",
            "18bit Lossly",
            "18bit",
            "16bit"});
            this.comboBox1.Location = new System.Drawing.Point(957, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 20);
            this.comboBox1.TabIndex = 63;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textboxtagetbitrate
            // 
            this.textboxtagetbitrate.Location = new System.Drawing.Point(37, 53);
            this.textboxtagetbitrate.Name = "textboxtagetbitrate";
            this.textboxtagetbitrate.Size = new System.Drawing.Size(57, 22);
            this.textboxtagetbitrate.TabIndex = 64;
            this.textboxtagetbitrate.Text = "1000";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(102, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 12);
            this.label19.TabIndex = 65;
            this.label19.Text = "目標速度(Mbps)";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(61, 161);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 67;
            this.button5.Text = "reset test";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_changed);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(166, 122);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 69;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(166, 76);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 68;
            this.button7.Text = "test return";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textbox_fortest2
            // 
            this.textbox_fortest2.Location = new System.Drawing.Point(236, 33);
            this.textbox_fortest2.Name = "textbox_fortest2";
            this.textbox_fortest2.Size = new System.Drawing.Size(181, 22);
            this.textbox_fortest2.TabIndex = 70;
            // 
            // textbox_fortest3
            // 
            this.textbox_fortest3.Location = new System.Drawing.Point(271, 64);
            this.textbox_fortest3.Name = "textbox_fortest3";
            this.textbox_fortest3.Size = new System.Drawing.Size(100, 22);
            this.textbox_fortest3.TabIndex = 71;
            // 
            // backgroundWorkerwebcam
            // 
            this.backgroundWorkerwebcam.WorkerSupportsCancellation = true;
            this.backgroundWorkerwebcam.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerwebcam_DoWork);
            this.backgroundWorkerwebcam.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerwebcam_ProgressChanged);
            // 
            // btn_stopwebcam
            // 
            this.btn_stopwebcam.Location = new System.Drawing.Point(1119, 357);
            this.btn_stopwebcam.Name = "btn_stopwebcam";
            this.btn_stopwebcam.Size = new System.Drawing.Size(75, 23);
            this.btn_stopwebcam.TabIndex = 72;
            this.btn_stopwebcam.Text = "WEBCAM STOP";
            this.btn_stopwebcam.UseVisualStyleBackColor = true;
            this.btn_stopwebcam.Click += new System.EventHandler(this.btn_stopwebcam_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(605, 137);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(264, 398);
            this.tabControl1.TabIndex = 73;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkedListBox2);
            this.tabPage2.Controls.Add(this.checkedListBox1);
            this.tabPage2.Controls.Add(this.checkBox_webcam);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.btn_stoploop);
            this.tabPage2.Controls.Add(this.btn_openautotest);
            this.tabPage2.Controls.Add(this.textboxwaittime);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.textboxtagetbitrate);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(256, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Video mode Autotest";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "24bit",
            "18bit",
            "16bit"});
            this.checkedListBox2.Location = new System.Drawing.Point(161, 121);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(55, 72);
            this.checkedListBox2.TabIndex = 71;
            this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "LP blanking non burst event",
            "LP blanking non burst Pulse",
            "LP blanking burst ",
            "HS blanking non burst event",
            "HS blanking non burst Pulse",
            "HS blanking burst "});
            this.checkedListBox1.Location = new System.Drawing.Point(6, 121);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(149, 100);
            this.checkedListBox1.TabIndex = 69;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // checkBox_webcam
            // 
            this.checkBox_webcam.AutoSize = true;
            this.checkBox_webcam.Location = new System.Drawing.Point(37, 93);
            this.checkBox_webcam.Name = "checkBox_webcam";
            this.checkBox_webcam.Size = new System.Drawing.Size(100, 16);
            this.checkBox_webcam.TabIndex = 68;
            this.checkBox_webcam.Text = "開啟WEBCAM";
            this.checkBox_webcam.UseVisualStyleBackColor = true;
            this.checkBox_webcam.CheckedChanged += new System.EventHandler(this.checkBox_webcam_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(101, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 12);
            this.label20.TabIndex = 67;
            this.label20.Text = "送圖秒數(mS)";
            // 
            // btn_stoploop
            // 
            this.btn_stoploop.BackgroundImage = global::PGRemote_control.Properties.Resources._20150408105629248_easyicon_net_721;
            this.btn_stoploop.FlatAppearance.BorderSize = 0;
            this.btn_stoploop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stoploop.Location = new System.Drawing.Point(144, 281);
            this.btn_stoploop.Name = "btn_stoploop";
            this.btn_stoploop.Size = new System.Drawing.Size(72, 72);
            this.btn_stoploop.TabIndex = 66;
            this.btn_stoploop.UseVisualStyleBackColor = true;
            this.btn_stoploop.Click += new System.EventHandler(this.btn_stoploop_Click);
            // 
            // btn_openautotest
            // 
            this.btn_openautotest.BackgroundImage = global::PGRemote_control.Properties.Resources._12331;
            this.btn_openautotest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_openautotest.FlatAppearance.BorderSize = 0;
            this.btn_openautotest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openautotest.Location = new System.Drawing.Point(37, 281);
            this.btn_openautotest.Name = "btn_openautotest";
            this.btn_openautotest.Size = new System.Drawing.Size(72, 72);
            this.btn_openautotest.TabIndex = 35;
            this.btn_openautotest.UseVisualStyleBackColor = true;
            this.btn_openautotest.Click += new System.EventHandler(this.btn_openautotest_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textbox_autotestfile);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.btn_shortwrite);
            this.tabPage3.Controls.Add(this.textbox_dt);
            this.tabPage3.Controls.Add(this.textbox_par);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.btn_longwrite);
            this.tabPage3.Controls.Add(this.textbox_readreg);
            this.tabPage3.Controls.Add(this.textbox_smrps);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.btn_sendsmrps);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.btn_dcsread);
            this.tabPage3.Controls.Add(this.btn_genread);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(256, 372);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textbox_autotestfile
            // 
            this.textbox_autotestfile.Location = new System.Drawing.Point(123, 297);
            this.textbox_autotestfile.Name = "textbox_autotestfile";
            this.textbox_autotestfile.Size = new System.Drawing.Size(57, 22);
            this.textbox_autotestfile.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 12);
            this.label9.TabIndex = 39;
            this.label9.Text = "Auto Test File";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button11);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label_skewstate);
            this.tabPage1.Controls.Add(this.btn_skewstop);
            this.tabPage1.Controls.Add(this.text_skewinterval);
            this.tabPage1.Controls.Add(this.btn_skewautotest);
            this.tabPage1.Controls.Add(this.textbox_skewend);
            this.tabPage1.Controls.Add(this.textbox_skewstart);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(256, 372);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Skew test";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(15, 165);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(97, 23);
            this.button11.TabIndex = 80;
            this.button11.Text = "Swing Auto start";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(95, 58);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 12);
            this.label21.TabIndex = 79;
            this.label21.Text = "結束Bit Rate";
            // 
            // label_skewstate
            // 
            this.label_skewstate.AutoSize = true;
            this.label_skewstate.Location = new System.Drawing.Point(95, 31);
            this.label_skewstate.Name = "label_skewstate";
            this.label_skewstate.Size = new System.Drawing.Size(67, 12);
            this.label_skewstate.TabIndex = 77;
            this.label_skewstate.Text = "起始Bit Rate";
            // 
            // btn_skewstop
            // 
            this.btn_skewstop.Location = new System.Drawing.Point(16, 268);
            this.btn_skewstop.Name = "btn_skewstop";
            this.btn_skewstop.Size = new System.Drawing.Size(97, 23);
            this.btn_skewstop.TabIndex = 78;
            this.btn_skewstop.Text = "Skew Auto Stop";
            this.btn_skewstop.UseVisualStyleBackColor = true;
            this.btn_skewstop.Click += new System.EventHandler(this.btn_skewstop_Click);
            // 
            // text_skewinterval
            // 
            this.text_skewinterval.Location = new System.Drawing.Point(15, 87);
            this.text_skewinterval.Name = "text_skewinterval";
            this.text_skewinterval.Size = new System.Drawing.Size(35, 22);
            this.text_skewinterval.TabIndex = 77;
            this.text_skewinterval.Text = "50";
            // 
            // btn_skewautotest
            // 
            this.btn_skewautotest.Location = new System.Drawing.Point(15, 133);
            this.btn_skewautotest.Name = "btn_skewautotest";
            this.btn_skewautotest.Size = new System.Drawing.Size(97, 23);
            this.btn_skewautotest.TabIndex = 75;
            this.btn_skewautotest.Text = "Skew Auto start";
            this.btn_skewautotest.UseVisualStyleBackColor = true;
            this.btn_skewautotest.Click += new System.EventHandler(this.btn_skewautotest_Click);
            // 
            // textbox_skewend
            // 
            this.textbox_skewend.Location = new System.Drawing.Point(15, 58);
            this.textbox_skewend.Name = "textbox_skewend";
            this.textbox_skewend.Size = new System.Drawing.Size(35, 22);
            this.textbox_skewend.TabIndex = 76;
            this.textbox_skewend.Text = "1500";
            // 
            // textbox_skewstart
            // 
            this.textbox_skewstart.Location = new System.Drawing.Point(15, 27);
            this.textbox_skewstart.Name = "textbox_skewstart";
            this.textbox_skewstart.Size = new System.Drawing.Size(35, 22);
            this.textbox_skewstart.TabIndex = 75;
            this.textbox_skewstart.Text = "400";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button13);
            this.tabPage4.Controls.Add(this.label22);
            this.tabPage4.Controls.Add(this.label23);
            this.tabPage4.Controls.Add(this.textbox_hsautospare);
            this.tabPage4.Controls.Add(this.textbox_hsautoend);
            this.tabPage4.Controls.Add(this.textbox_hsautostart);
            this.tabPage4.Controls.Add(this.button12);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(256, 372);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "HS SPEED";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(30, 169);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(97, 24);
            this.button13.TabIndex = 88;
            this.button13.Text = "HS SPEED stop";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(101, 57);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(67, 12);
            this.label22.TabIndex = 87;
            this.label22.Text = "結束Bit Rate";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(101, 30);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 12);
            this.label23.TabIndex = 85;
            this.label23.Text = "起始Bit Rate";
            // 
            // textbox_hsautospare
            // 
            this.textbox_hsautospare.Location = new System.Drawing.Point(21, 86);
            this.textbox_hsautospare.Name = "textbox_hsautospare";
            this.textbox_hsautospare.Size = new System.Drawing.Size(35, 22);
            this.textbox_hsautospare.TabIndex = 86;
            this.textbox_hsautospare.Text = "5";
            // 
            // textbox_hsautoend
            // 
            this.textbox_hsautoend.Location = new System.Drawing.Point(21, 57);
            this.textbox_hsautoend.Name = "textbox_hsautoend";
            this.textbox_hsautoend.Size = new System.Drawing.Size(35, 22);
            this.textbox_hsautoend.TabIndex = 84;
            this.textbox_hsautoend.Text = "1500";
            // 
            // textbox_hsautostart
            // 
            this.textbox_hsautostart.Location = new System.Drawing.Point(21, 26);
            this.textbox_hsautostart.Name = "textbox_hsautostart";
            this.textbox_hsautostart.Size = new System.Drawing.Size(35, 22);
            this.textbox_hsautostart.TabIndex = 83;
            this.textbox_hsautostart.Text = "80";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(30, 142);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(97, 23);
            this.button12.TabIndex = 82;
            this.button12.Text = "HS SPEED Auto start";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btn_setfluke6);
            this.tabPage5.Controls.Add(this.combobox_portname6);
            this.tabPage5.Controls.Add(this.btn_setfluke5);
            this.tabPage5.Controls.Add(this.combobox_portname5);
            this.tabPage5.Controls.Add(this.btn_setfluke4);
            this.tabPage5.Controls.Add(this.combobox_portname4);
            this.tabPage5.Controls.Add(this.btn_setfluke3);
            this.tabPage5.Controls.Add(this.combobox_portname3);
            this.tabPage5.Controls.Add(this.btn_setfluke2);
            this.tabPage5.Controls.Add(this.combobox_portname2);
            this.tabPage5.Controls.Add(this.btn_setfluke1);
            this.tabPage5.Controls.Add(this.button14);
            this.tabPage5.Controls.Add(this.combobox_portname1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(256, 372);
            this.tabPage5.TabIndex = 6;
            this.tabPage5.Text = "Fluke Set";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btn_setfluke6
            // 
            this.btn_setfluke6.Location = new System.Drawing.Point(142, 268);
            this.btn_setfluke6.Name = "btn_setfluke6";
            this.btn_setfluke6.Size = new System.Drawing.Size(75, 23);
            this.btn_setfluke6.TabIndex = 99;
            this.btn_setfluke6.Text = "Set Fluke";
            this.btn_setfluke6.UseVisualStyleBackColor = true;
            this.btn_setfluke6.Visible = false;
            this.btn_setfluke6.Click += new System.EventHandler(this.btn_setfluke6_Click);
            // 
            // combobox_portname6
            // 
            this.combobox_portname6.FormattingEnabled = true;
            this.combobox_portname6.Location = new System.Drawing.Point(30, 271);
            this.combobox_portname6.Name = "combobox_portname6";
            this.combobox_portname6.Size = new System.Drawing.Size(84, 20);
            this.combobox_portname6.TabIndex = 98;
            this.combobox_portname6.Visible = false;
            // 
            // btn_setfluke5
            // 
            this.btn_setfluke5.Location = new System.Drawing.Point(142, 229);
            this.btn_setfluke5.Name = "btn_setfluke5";
            this.btn_setfluke5.Size = new System.Drawing.Size(75, 23);
            this.btn_setfluke5.TabIndex = 97;
            this.btn_setfluke5.Text = "Set Fluke";
            this.btn_setfluke5.UseVisualStyleBackColor = true;
            this.btn_setfluke5.Visible = false;
            this.btn_setfluke5.Click += new System.EventHandler(this.btn_setfluke5_Click);
            // 
            // combobox_portname5
            // 
            this.combobox_portname5.FormattingEnabled = true;
            this.combobox_portname5.Location = new System.Drawing.Point(30, 232);
            this.combobox_portname5.Name = "combobox_portname5";
            this.combobox_portname5.Size = new System.Drawing.Size(84, 20);
            this.combobox_portname5.TabIndex = 96;
            this.combobox_portname5.Visible = false;
            // 
            // btn_setfluke4
            // 
            this.btn_setfluke4.Location = new System.Drawing.Point(142, 191);
            this.btn_setfluke4.Name = "btn_setfluke4";
            this.btn_setfluke4.Size = new System.Drawing.Size(75, 23);
            this.btn_setfluke4.TabIndex = 95;
            this.btn_setfluke4.Text = "Set Fluke";
            this.btn_setfluke4.UseVisualStyleBackColor = true;
            this.btn_setfluke4.Visible = false;
            this.btn_setfluke4.Click += new System.EventHandler(this.btn_setfluke4_Click);
            // 
            // combobox_portname4
            // 
            this.combobox_portname4.FormattingEnabled = true;
            this.combobox_portname4.Location = new System.Drawing.Point(30, 194);
            this.combobox_portname4.Name = "combobox_portname4";
            this.combobox_portname4.Size = new System.Drawing.Size(84, 20);
            this.combobox_portname4.TabIndex = 94;
            this.combobox_portname4.Visible = false;
            // 
            // btn_setfluke3
            // 
            this.btn_setfluke3.Location = new System.Drawing.Point(142, 153);
            this.btn_setfluke3.Name = "btn_setfluke3";
            this.btn_setfluke3.Size = new System.Drawing.Size(75, 23);
            this.btn_setfluke3.TabIndex = 93;
            this.btn_setfluke3.Text = "Set Fluke";
            this.btn_setfluke3.UseVisualStyleBackColor = true;
            this.btn_setfluke3.Visible = false;
            this.btn_setfluke3.Click += new System.EventHandler(this.btn_setfluke3_Click);
            // 
            // combobox_portname3
            // 
            this.combobox_portname3.FormattingEnabled = true;
            this.combobox_portname3.Location = new System.Drawing.Point(30, 156);
            this.combobox_portname3.Name = "combobox_portname3";
            this.combobox_portname3.Size = new System.Drawing.Size(84, 20);
            this.combobox_portname3.TabIndex = 92;
            this.combobox_portname3.Visible = false;
            // 
            // btn_setfluke2
            // 
            this.btn_setfluke2.Location = new System.Drawing.Point(142, 114);
            this.btn_setfluke2.Name = "btn_setfluke2";
            this.btn_setfluke2.Size = new System.Drawing.Size(75, 23);
            this.btn_setfluke2.TabIndex = 91;
            this.btn_setfluke2.Text = "Set Fluke";
            this.btn_setfluke2.UseVisualStyleBackColor = true;
            this.btn_setfluke2.Visible = false;
            this.btn_setfluke2.Click += new System.EventHandler(this.btn_setfluke2_Click);
            // 
            // combobox_portname2
            // 
            this.combobox_portname2.FormattingEnabled = true;
            this.combobox_portname2.Location = new System.Drawing.Point(30, 117);
            this.combobox_portname2.Name = "combobox_portname2";
            this.combobox_portname2.Size = new System.Drawing.Size(84, 20);
            this.combobox_portname2.TabIndex = 90;
            this.combobox_portname2.Visible = false;
            // 
            // btn_setfluke1
            // 
            this.btn_setfluke1.BackColor = System.Drawing.Color.Transparent;
            this.btn_setfluke1.Location = new System.Drawing.Point(142, 76);
            this.btn_setfluke1.Name = "btn_setfluke1";
            this.btn_setfluke1.Size = new System.Drawing.Size(75, 23);
            this.btn_setfluke1.TabIndex = 89;
            this.btn_setfluke1.Text = "Set Fluke";
            this.btn_setfluke1.UseVisualStyleBackColor = false;
            this.btn_setfluke1.Visible = false;
            this.btn_setfluke1.Click += new System.EventHandler(this.btn_setfluke_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(37, 30);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 88;
            this.button14.Text = "Get Fluke";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // combobox_portname1
            // 
            this.combobox_portname1.FormattingEnabled = true;
            this.combobox_portname1.Location = new System.Drawing.Point(30, 79);
            this.combobox_portname1.Name = "combobox_portname1";
            this.combobox_portname1.Size = new System.Drawing.Size(84, 20);
            this.combobox_portname1.TabIndex = 87;
            this.combobox_portname1.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // backgroundworker_skew
            // 
            this.backgroundworker_skew.WorkerSupportsCancellation = true;
            this.backgroundworker_skew.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundworker_skew_DoWork);
            this.backgroundworker_skew.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundworker_skew_ProgressChanged);
            this.backgroundworker_skew.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundworker_skew_RunWorkerCompleted);
            // 
            // label_skewui
            // 
            this.label_skewui.AutoSize = true;
            this.label_skewui.Location = new System.Drawing.Point(906, 249);
            this.label_skewui.Name = "label_skewui";
            this.label_skewui.Size = new System.Drawing.Size(28, 12);
            this.label_skewui.TabIndex = 75;
            this.label_skewui.Text = "none";
            // 
            // label_skewtime
            // 
            this.label_skewtime.AutoSize = true;
            this.label_skewtime.Location = new System.Drawing.Point(906, 273);
            this.label_skewtime.Name = "label_skewtime";
            this.label_skewtime.Size = new System.Drawing.Size(11, 12);
            this.label_skewtime.TabIndex = 76;
            this.label_skewtime.Text = "0";
            // 
            // btn_dislinkpg
            // 
            this.btn_dislinkpg.Location = new System.Drawing.Point(1119, 189);
            this.btn_dislinkpg.Name = "btn_dislinkpg";
            this.btn_dislinkpg.Size = new System.Drawing.Size(75, 23);
            this.btn_dislinkpg.TabIndex = 77;
            this.btn_dislinkpg.Text = "中斷PG連線";
            this.btn_dislinkpg.UseVisualStyleBackColor = true;
            this.btn_dislinkpg.Click += new System.EventHandler(this.btn_dislinkpg_Click);
            // 
            // openrpcpath
            // 
            this.openrpcpath.FileName = "openFileDialog1";
            // 
            // btn_exerpc
            // 
            this.btn_exerpc.Location = new System.Drawing.Point(1119, 386);
            this.btn_exerpc.Name = "btn_exerpc";
            this.btn_exerpc.Size = new System.Drawing.Size(75, 23);
            this.btn_exerpc.TabIndex = 78;
            this.btn_exerpc.Text = "RPC file";
            this.btn_exerpc.UseVisualStyleBackColor = true;
            this.btn_exerpc.Click += new System.EventHandler(this.btn_exerpc_Click);
            // 
            // textbox_statusmsg
            // 
            this.textbox_statusmsg.Location = new System.Drawing.Point(953, 156);
            this.textbox_statusmsg.Name = "textbox_statusmsg";
            this.textbox_statusmsg.Size = new System.Drawing.Size(100, 22);
            this.textbox_statusmsg.TabIndex = 79;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(61, 104);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 80;
            this.button8.Text = "test button";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // progressBar_Pot
            // 
            this.progressBar_Pot.Location = new System.Drawing.Point(908, 189);
            this.progressBar_Pot.Maximum = 255;
            this.progressBar_Pot.Name = "progressBar_Pot";
            this.progressBar_Pot.Size = new System.Drawing.Size(188, 13);
            this.progressBar_Pot.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_Pot.TabIndex = 81;
            this.progressBar_Pot.Value = 128;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(940, 211);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 198);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(565, 401);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // textbox_inirpc
            // 
            this.textbox_inirpc.Location = new System.Drawing.Point(597, 540);
            this.textbox_inirpc.Name = "textbox_inirpc";
            this.textbox_inirpc.Size = new System.Drawing.Size(100, 22);
            this.textbox_inirpc.TabIndex = 82;
            // 
            // btn_selini
            // 
            this.btn_selini.Location = new System.Drawing.Point(703, 537);
            this.btn_selini.Name = "btn_selini";
            this.btn_selini.Size = new System.Drawing.Size(94, 23);
            this.btn_selini.TabIndex = 83;
            this.btn_selini.Text = "選擇ini RPC";
            this.btn_selini.UseVisualStyleBackColor = true;
            this.btn_selini.Click += new System.EventHandler(this.btn_selini_Click);
            // 
            // openinirpc
            // 
            this.openinirpc.FileName = "openFileDialog1";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(938, 537);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(97, 23);
            this.button9.TabIndex = 84;
            this.button9.Text = "test webcam";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1110, 415);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(97, 23);
            this.button10.TabIndex = 85;
            this.button10.Text = "HW RESET";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // backgroundworker_swing
            // 
            this.backgroundworker_swing.WorkerSupportsCancellation = true;
            this.backgroundworker_swing.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundworker_swing_DoWork);
            this.backgroundworker_swing.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundworker_swing_ProgressChanged);
            this.backgroundworker_swing.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundworker_swing_RunWorkerCompleted);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripDropDownButton1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1252, 25);
            this.toolStrip1.TabIndex = 86;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.ToolTipText = "Build Auto sequence";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingFlukeToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // settingFlukeToolStripMenuItem
            // 
            this.settingFlukeToolStripMenuItem.Name = "settingFlukeToolStripMenuItem";
            this.settingFlukeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.settingFlukeToolStripMenuItem.Text = "Setting Fluke";
            this.settingFlukeToolStripMenuItem.Click += new System.EventHandler(this.settingFlukeToolStripMenuItem_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel1.Text = "ECC計算";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // openfileautoset
            // 
            this.openfileautoset.FileName = "openFileDialog1";
            this.openfileautoset.Filter = " (*.txt)|*.txt";
            // 
            // backgroundworker_hsspeed
            // 
            this.backgroundworker_hsspeed.WorkerSupportsCancellation = true;
            this.backgroundworker_hsspeed.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundworker_hsspeed_DoWork);
            this.backgroundworker_hsspeed.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundworker_hsspeed_ProgressChanged);
            this.backgroundworker_hsspeed.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundworker_hsspeed_RunWorkerCompleted);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM3";
            // 
            // openfiletestseq
            // 
            this.openfiletestseq.FileName = "openFileDialog1";
            this.openfiletestseq.Filter = " (*.txt)|*.txt";
            // 
            // serialPort2
            // 
            this.serialPort2.BaudRate = 115200;
            this.serialPort2.PortName = "COM3";
            // 
            // serialPort3
            // 
            this.serialPort3.BaudRate = 115200;
            this.serialPort3.PortName = "COM3";
            // 
            // serialPort4
            // 
            this.serialPort4.BaudRate = 115200;
            this.serialPort4.PortName = "COM4";
            // 
            // serialPort5
            // 
            this.serialPort5.BaudRate = 115200;
            this.serialPort5.PortName = "COM3";
            // 
            // serialPort6
            // 
            this.serialPort6.BaudRate = 115200;
            this.serialPort6.PortName = "COM3";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(940, 567);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 87;
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(940, 608);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 88;
            this.button16.Text = "thread test";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // btn_swingskewauto
            // 
            this.btn_swingskewauto.Location = new System.Drawing.Point(1062, 537);
            this.btn_swingskewauto.Name = "btn_swingskewauto";
            this.btn_swingskewauto.Size = new System.Drawing.Size(75, 23);
            this.btn_swingskewauto.TabIndex = 89;
            this.btn_swingskewauto.Text = "Swing+skew";
            this.btn_swingskewauto.UseVisualStyleBackColor = true;
            this.btn_swingskewauto.Click += new System.EventHandler(this.btn_swingskewauto_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(1062, 608);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 90;
            this.button17.Text = "swing skew c";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(1062, 568);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(111, 23);
            this.button18.TabIndex = 91;
            this.button18.Text = "swing+skew video";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // backgroundskewswing
            // 
            this.backgroundskewswing.WorkerSupportsCancellation = true;
            this.backgroundskewswing.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundskewswing_DoWork);
            this.backgroundskewswing.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundskewswing_ProgressChanged);
            this.backgroundskewswing.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundskewswing_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 670);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.btn_swingskewauto);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btn_selini);
            this.Controls.Add(this.textbox_inirpc);
            this.Controls.Add(this.progressBar_Pot);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_openbmp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textbox_videopicpath);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textbox_statusmsg);
            this.Controls.Add(this.btn_senvideopic);
            this.Controls.Add(this.btn_exerpc);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_dislinkpg);
            this.Controls.Add(this.label_skewtime);
            this.Controls.Add(this.label_skewui);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_fortest);
            this.Controls.Add(this.btn_stopwebcam);
            this.Controls.Add(this.textbox_fortest3);
            this.Controls.Add(this.textbox_fortest2);
            this.Controls.Add(this.textboxrpcsave);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_runautotest);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textboxfr);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textboxvact);
            this.Controls.Add(this.textboxhact);
            this.Controls.Add(this.textboxvfp);
            this.Controls.Add(this.textboxhfp);
            this.Controls.Add(this.textboxvbp);
            this.Controls.Add(this.textboxhbp);
            this.Controls.Add(this.textboxvsa);
            this.Controls.Add(this.textboxhsa);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textbox_fortest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textbox_lpfreq);
            this.Controls.Add(this.textbox_hsfreq);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_opencam);
            this.Controls.Add(this.btn_savecam);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_pgabort);
            this.Controls.Add(this.btn_bta);
            this.Controls.Add(this.btn_linkpg);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "=";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_linkpg;
        private System.Windows.Forms.Button btn_bta;
        private System.Windows.Forms.Button btn_pgabort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btn_lp;
        private System.Windows.Forms.RadioButton btn_hs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_savecam;
        private System.Windows.Forms.Button btn_opencam;
        private System.Windows.Forms.TextBox textbox_dt;
        private System.Windows.Forms.TextBox textbox_par;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_longwrite;
        private System.Windows.Forms.Button btn_shortwrite;
        private System.Windows.Forms.Button btn_openbmp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton btn_3lane;
        private System.Windows.Forms.RadioButton btn_4lane;
        private System.Windows.Forms.RadioButton btn_1lane;
        private System.Windows.Forms.RadioButton btn_2lane;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbox_lpfreq;
        private System.Windows.Forms.TextBox textbox_hsfreq;
        private System.Windows.Forms.OpenFileDialog openvideopic;
        private System.Windows.Forms.TextBox textbox_videopicpath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_senvideopic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textbox_smrps;
        private System.Windows.Forms.Button btn_sendsmrps;
        private System.Windows.Forms.Button btn_dcsread;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textbox_readreg;
        private System.Windows.Forms.Button btn_genread;
        private System.Windows.Forms.TextBox textbox_fortest;
        private System.Windows.Forms.Button btn_fortest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_runautotest;
        private System.Windows.Forms.Button btn_openautotest;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textboxwaittime;
        private System.Windows.Forms.TextBox textboxrpcsave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog opendutpath;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textboxhsa;
        private System.Windows.Forms.TextBox textboxvsa;
        private System.Windows.Forms.TextBox textboxvbp;
        private System.Windows.Forms.TextBox textboxhbp;
        private System.Windows.Forms.TextBox textboxvfp;
        private System.Windows.Forms.TextBox textboxhfp;
        private System.Windows.Forms.TextBox textboxvact;
        private System.Windows.Forms.TextBox textboxhact;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textboxfr;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textboxtagetbitrate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_stoploop;
        private System.Windows.Forms.Button button5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textbox_fortest2;
        private System.Windows.Forms.TextBox textbox_fortest3;
        private System.ComponentModel.BackgroundWorker backgroundWorkerwebcam;
        private System.Windows.Forms.Button btn_stopwebcam;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_skewautotest;
        private System.Windows.Forms.TextBox textbox_skewend;
        private System.Windows.Forms.TextBox textbox_skewstart;
        private System.ComponentModel.BackgroundWorker backgroundworker_skew;
        private System.Windows.Forms.TextBox text_skewinterval;
        private System.Windows.Forms.Label label_skewui;
        private System.Windows.Forms.Label label_skewtime;
        private System.Windows.Forms.Button btn_skewstop;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label_skewstate;
        private System.Windows.Forms.Button btn_dislinkpg;
        private System.Windows.Forms.OpenFileDialog openrpcpath;
        private System.Windows.Forms.Button btn_exerpc;
        private System.Windows.Forms.CheckBox checkBox_webcam;
        private System.Windows.Forms.TextBox textbox_autotestfile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textbox_statusmsg;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ProgressBar progressBar_Pot;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox textbox_inirpc;
        private System.Windows.Forms.Button btn_selini;
        private System.Windows.Forms.OpenFileDialog openinirpc;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.ComponentModel.BackgroundWorker backgroundworker_swing;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.OpenFileDialog openfileautoset;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textbox_hsautospare;
        private System.Windows.Forms.TextBox textbox_hsautoend;
        private System.Windows.Forms.TextBox textbox_hsautostart;
        private System.Windows.Forms.Button button12;
        private System.ComponentModel.BackgroundWorker backgroundworker_hsspeed;
        private System.Windows.Forms.Button button13;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.OpenFileDialog openfiletestseq;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem settingFlukeToolStripMenuItem;
        private System.Windows.Forms.ComboBox combobox_portname1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btn_setfluke1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btn_setfluke6;
        private System.Windows.Forms.ComboBox combobox_portname6;
        private System.Windows.Forms.Button btn_setfluke5;
        private System.Windows.Forms.ComboBox combobox_portname5;
        private System.Windows.Forms.Button btn_setfluke4;
        private System.Windows.Forms.ComboBox combobox_portname4;
        private System.Windows.Forms.Button btn_setfluke3;
        private System.Windows.Forms.ComboBox combobox_portname3;
        private System.Windows.Forms.Button btn_setfluke2;
        private System.Windows.Forms.ComboBox combobox_portname2;
        private System.IO.Ports.SerialPort serialPort2;
        private System.IO.Ports.SerialPort serialPort3;
        private System.IO.Ports.SerialPort serialPort4;
        private System.IO.Ports.SerialPort serialPort5;
        private System.IO.Ports.SerialPort serialPort6;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button btn_swingskewauto;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.ComponentModel.BackgroundWorker backgroundskewswing;
    }
}


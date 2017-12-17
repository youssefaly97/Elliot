namespace NoNameQuad_GUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.checkbox_leg_t1 = new System.Windows.Forms.CheckBox();
            this.textbox_alpha_t1 = new System.Windows.Forms.TextBox();
            this.comboBox_legNumber_t1 = new System.Windows.Forms.ComboBox();
            this.label_gamma_t1 = new System.Windows.Forms.Label();
            this.label_beta_t1 = new System.Windows.Forms.Label();
            this.label_alpha_t1 = new System.Windows.Forms.Label();
            this.label_legnumber_t1 = new System.Windows.Forms.Label();
            this.textbox_gamma_t1 = new System.Windows.Forms.TextBox();
            this.textbox_beta_t1 = new System.Windows.Forms.TextBox();
            this.button_applyChanges_t1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textbox_xHold_t2 = new System.Windows.Forms.TextBox();
            this.comboBox_legChoice_t2 = new System.Windows.Forms.ComboBox();
            this.button_apply_t2 = new System.Windows.Forms.Button();
            this.textbox_zHold_t2 = new System.Windows.Forms.TextBox();
            this.textbox_yHold_t2 = new System.Windows.Forms.TextBox();
            this.label_zHold_t2 = new System.Windows.Forms.Label();
            this.label_yHold_t2 = new System.Windows.Forms.Label();
            this.label_xHold_t2 = new System.Windows.Forms.Label();
            this.label_zCoord_t2 = new System.Windows.Forms.Label();
            this.label_yCoord_t2 = new System.Windows.Forms.Label();
            this.label_xCoord_t2 = new System.Windows.Forms.Label();
            this.label_currCoordinates_t2 = new System.Windows.Forms.Label();
            this.label_legNumber_t2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button_Serv0_t3 = new System.Windows.Forms.Button();
            this.button_Serv180_t3 = new System.Windows.Forms.Button();
            this.button_Serv90_t3 = new System.Windows.Forms.Button();
            this.label_Serv0_t3 = new System.Windows.Forms.Label();
            this.label_Serv180_t3 = new System.Windows.Forms.Label();
            this.label_Serv90_t3 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox_inverseK_t1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_servos_t2 = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_inverseK_t1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_servos_t2)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-3, -2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(605, 298);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::NoNameQuad_GUI.Properties.Resources.Capture;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.checkbox_leg_t1);
            this.tabPage1.Controls.Add(this.textbox_alpha_t1);
            this.tabPage1.Controls.Add(this.pictureBox_inverseK_t1);
            this.tabPage1.Controls.Add(this.comboBox_legNumber_t1);
            this.tabPage1.Controls.Add(this.label_gamma_t1);
            this.tabPage1.Controls.Add(this.label_beta_t1);
            this.tabPage1.Controls.Add(this.label_alpha_t1);
            this.tabPage1.Controls.Add(this.label_legnumber_t1);
            this.tabPage1.Controls.Add(this.textbox_gamma_t1);
            this.tabPage1.Controls.Add(this.textbox_beta_t1);
            this.tabPage1.Controls.Add(this.button_applyChanges_t1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(597, 272);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Servo Control";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(35, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Data Type";
            this.label2.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Location = new System.Drawing.Point(114, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 25);
            this.panel2.TabIndex = 27;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radioButton3.Location = new System.Drawing.Point(74, 5);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(46, 17);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Byte";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radioButton4.Location = new System.Drawing.Point(3, 5);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(52, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "String";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // checkbox_leg_t1
            // 
            this.checkbox_leg_t1.AutoSize = true;
            this.checkbox_leg_t1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.checkbox_leg_t1.Location = new System.Drawing.Point(247, 27);
            this.checkbox_leg_t1.Name = "checkbox_leg_t1";
            this.checkbox_leg_t1.Size = new System.Drawing.Size(63, 17);
            this.checkbox_leg_t1.TabIndex = 26;
            this.checkbox_leg_t1.Text = "All Legs";
            this.checkbox_leg_t1.UseVisualStyleBackColor = true;
            this.checkbox_leg_t1.CheckedChanged += new System.EventHandler(this.checkbox_leg_t1_CheckedChanged);
            // 
            // textbox_alpha_t1
            // 
            this.textbox_alpha_t1.Location = new System.Drawing.Point(114, 90);
            this.textbox_alpha_t1.Name = "textbox_alpha_t1";
            this.textbox_alpha_t1.Size = new System.Drawing.Size(100, 20);
            this.textbox_alpha_t1.TabIndex = 25;
            this.textbox_alpha_t1.UseWaitCursor = true;
            // 
            // comboBox_legNumber_t1
            // 
            this.comboBox_legNumber_t1.FormattingEnabled = true;
            this.comboBox_legNumber_t1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBox_legNumber_t1.Location = new System.Drawing.Point(114, 21);
            this.comboBox_legNumber_t1.Name = "comboBox_legNumber_t1";
            this.comboBox_legNumber_t1.Size = new System.Drawing.Size(100, 21);
            this.comboBox_legNumber_t1.TabIndex = 23;
            this.comboBox_legNumber_t1.UseWaitCursor = true;
            this.comboBox_legNumber_t1.SelectedIndexChanged += new System.EventHandler(this.comboBox_legNumber_t1_SelectedIndexChanged);
            // 
            // label_gamma_t1
            // 
            this.label_gamma_t1.AutoSize = true;
            this.label_gamma_t1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_gamma_t1.Location = new System.Drawing.Point(35, 177);
            this.label_gamma_t1.Name = "label_gamma_t1";
            this.label_gamma_t1.Size = new System.Drawing.Size(43, 13);
            this.label_gamma_t1.TabIndex = 21;
            this.label_gamma_t1.Text = "Gamma";
            this.label_gamma_t1.UseWaitCursor = true;
            // 
            // label_beta_t1
            // 
            this.label_beta_t1.AutoSize = true;
            this.label_beta_t1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_beta_t1.Location = new System.Drawing.Point(35, 134);
            this.label_beta_t1.Name = "label_beta_t1";
            this.label_beta_t1.Size = new System.Drawing.Size(29, 13);
            this.label_beta_t1.TabIndex = 20;
            this.label_beta_t1.Text = "Beta";
            this.label_beta_t1.UseWaitCursor = true;
            // 
            // label_alpha_t1
            // 
            this.label_alpha_t1.AutoSize = true;
            this.label_alpha_t1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_alpha_t1.Location = new System.Drawing.Point(35, 93);
            this.label_alpha_t1.Name = "label_alpha_t1";
            this.label_alpha_t1.Size = new System.Drawing.Size(34, 13);
            this.label_alpha_t1.TabIndex = 19;
            this.label_alpha_t1.Text = "Alpha";
            this.label_alpha_t1.UseWaitCursor = true;
            // 
            // label_legnumber_t1
            // 
            this.label_legnumber_t1.AutoSize = true;
            this.label_legnumber_t1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_legnumber_t1.Location = new System.Drawing.Point(35, 28);
            this.label_legnumber_t1.Name = "label_legnumber_t1";
            this.label_legnumber_t1.Size = new System.Drawing.Size(65, 13);
            this.label_legnumber_t1.TabIndex = 17;
            this.label_legnumber_t1.Text = "Leg Number";
            this.label_legnumber_t1.UseWaitCursor = true;
            // 
            // textbox_gamma_t1
            // 
            this.textbox_gamma_t1.Location = new System.Drawing.Point(114, 174);
            this.textbox_gamma_t1.Name = "textbox_gamma_t1";
            this.textbox_gamma_t1.Size = new System.Drawing.Size(100, 20);
            this.textbox_gamma_t1.TabIndex = 16;
            this.textbox_gamma_t1.UseWaitCursor = true;
            this.textbox_gamma_t1.TextChanged += new System.EventHandler(this.textbox_gamma_t1_TextChanged);
            // 
            // textbox_beta_t1
            // 
            this.textbox_beta_t1.Location = new System.Drawing.Point(114, 131);
            this.textbox_beta_t1.Name = "textbox_beta_t1";
            this.textbox_beta_t1.Size = new System.Drawing.Size(100, 20);
            this.textbox_beta_t1.TabIndex = 15;
            this.textbox_beta_t1.UseWaitCursor = true;
            // 
            // button_applyChanges_t1
            // 
            this.button_applyChanges_t1.Location = new System.Drawing.Point(114, 216);
            this.button_applyChanges_t1.Name = "button_applyChanges_t1";
            this.button_applyChanges_t1.Size = new System.Drawing.Size(100, 33);
            this.button_applyChanges_t1.TabIndex = 13;
            this.button_applyChanges_t1.Text = "Apply Changes";
            this.button_applyChanges_t1.UseVisualStyleBackColor = true;
            this.button_applyChanges_t1.UseWaitCursor = true;
            this.button_applyChanges_t1.Click += new System.EventHandler(this.button_applyChanges_t1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::NoNameQuad_GUI.Properties.Resources.Capture;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.textbox_xHold_t2);
            this.tabPage2.Controls.Add(this.comboBox_legChoice_t2);
            this.tabPage2.Controls.Add(this.button_apply_t2);
            this.tabPage2.Controls.Add(this.textbox_zHold_t2);
            this.tabPage2.Controls.Add(this.textbox_yHold_t2);
            this.tabPage2.Controls.Add(this.label_zHold_t2);
            this.tabPage2.Controls.Add(this.label_yHold_t2);
            this.tabPage2.Controls.Add(this.label_xHold_t2);
            this.tabPage2.Controls.Add(this.label_zCoord_t2);
            this.tabPage2.Controls.Add(this.label_yCoord_t2);
            this.tabPage2.Controls.Add(this.label_xCoord_t2);
            this.tabPage2.Controls.Add(this.label_currCoordinates_t2);
            this.tabPage2.Controls.Add(this.label_legNumber_t2);
            this.tabPage2.Controls.Add(this.pictureBox_servos_t2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(588, 272);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inverse Kinematics";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(39, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Data Type";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(143, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 25);
            this.panel1.TabIndex = 15;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radioButton2.Location = new System.Drawing.Point(74, 5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Byte";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radioButton1.Location = new System.Drawing.Point(3, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "String";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // textbox_xHold_t2
            // 
            this.textbox_xHold_t2.Location = new System.Drawing.Point(143, 119);
            this.textbox_xHold_t2.Name = "textbox_xHold_t2";
            this.textbox_xHold_t2.Size = new System.Drawing.Size(100, 20);
            this.textbox_xHold_t2.TabIndex = 14;
            // 
            // comboBox_legChoice_t2
            // 
            this.comboBox_legChoice_t2.FormattingEnabled = true;
            this.comboBox_legChoice_t2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox_legChoice_t2.Location = new System.Drawing.Point(143, 18);
            this.comboBox_legChoice_t2.Name = "comboBox_legChoice_t2";
            this.comboBox_legChoice_t2.Size = new System.Drawing.Size(100, 21);
            this.comboBox_legChoice_t2.TabIndex = 12;
            this.comboBox_legChoice_t2.SelectedIndexChanged += new System.EventHandler(this.comboBox_legChoice_t2_SelectedIndexChanged);
            // 
            // button_apply_t2
            // 
            this.button_apply_t2.Location = new System.Drawing.Point(234, 231);
            this.button_apply_t2.Name = "button_apply_t2";
            this.button_apply_t2.Size = new System.Drawing.Size(92, 23);
            this.button_apply_t2.TabIndex = 11;
            this.button_apply_t2.Text = "Apply Changes";
            this.button_apply_t2.UseVisualStyleBackColor = true;
            this.button_apply_t2.Click += new System.EventHandler(this.button_apply_t2_Click);
            // 
            // textbox_zHold_t2
            // 
            this.textbox_zHold_t2.Location = new System.Drawing.Point(143, 200);
            this.textbox_zHold_t2.Name = "textbox_zHold_t2";
            this.textbox_zHold_t2.Size = new System.Drawing.Size(100, 20);
            this.textbox_zHold_t2.TabIndex = 10;
            // 
            // textbox_yHold_t2
            // 
            this.textbox_yHold_t2.Location = new System.Drawing.Point(143, 158);
            this.textbox_yHold_t2.Name = "textbox_yHold_t2";
            this.textbox_yHold_t2.Size = new System.Drawing.Size(100, 20);
            this.textbox_yHold_t2.TabIndex = 9;
            // 
            // label_zHold_t2
            // 
            this.label_zHold_t2.AutoSize = true;
            this.label_zHold_t2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_zHold_t2.Location = new System.Drawing.Point(61, 207);
            this.label_zHold_t2.Name = "label_zHold_t2";
            this.label_zHold_t2.Size = new System.Drawing.Size(14, 13);
            this.label_zHold_t2.TabIndex = 7;
            this.label_zHold_t2.Text = "Z";
            // 
            // label_yHold_t2
            // 
            this.label_yHold_t2.AutoSize = true;
            this.label_yHold_t2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_yHold_t2.Location = new System.Drawing.Point(61, 161);
            this.label_yHold_t2.Name = "label_yHold_t2";
            this.label_yHold_t2.Size = new System.Drawing.Size(14, 13);
            this.label_yHold_t2.TabIndex = 6;
            this.label_yHold_t2.Text = "Y";
            // 
            // label_xHold_t2
            // 
            this.label_xHold_t2.AutoSize = true;
            this.label_xHold_t2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_xHold_t2.Location = new System.Drawing.Point(61, 119);
            this.label_xHold_t2.Name = "label_xHold_t2";
            this.label_xHold_t2.Size = new System.Drawing.Size(14, 13);
            this.label_xHold_t2.TabIndex = 5;
            this.label_xHold_t2.Text = "X";
            // 
            // label_zCoord_t2
            // 
            this.label_zCoord_t2.AutoSize = true;
            this.label_zCoord_t2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_zCoord_t2.Location = new System.Drawing.Point(287, 88);
            this.label_zCoord_t2.Name = "label_zCoord_t2";
            this.label_zCoord_t2.Size = new System.Drawing.Size(48, 13);
            this.label_zCoord_t2.TabIndex = 4;
            this.label_zCoord_t2.Text = "Z: NULL";
            // 
            // label_yCoord_t2
            // 
            this.label_yCoord_t2.AutoSize = true;
            this.label_yCoord_t2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_yCoord_t2.Location = new System.Drawing.Point(216, 88);
            this.label_yCoord_t2.Name = "label_yCoord_t2";
            this.label_yCoord_t2.Size = new System.Drawing.Size(48, 13);
            this.label_yCoord_t2.TabIndex = 3;
            this.label_yCoord_t2.Text = "Y: NULL";
            // 
            // label_xCoord_t2
            // 
            this.label_xCoord_t2.AutoSize = true;
            this.label_xCoord_t2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_xCoord_t2.Location = new System.Drawing.Point(140, 88);
            this.label_xCoord_t2.Name = "label_xCoord_t2";
            this.label_xCoord_t2.Size = new System.Drawing.Size(48, 13);
            this.label_xCoord_t2.TabIndex = 2;
            this.label_xCoord_t2.Text = "X: NULL";
            // 
            // label_currCoordinates_t2
            // 
            this.label_currCoordinates_t2.AutoSize = true;
            this.label_currCoordinates_t2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_currCoordinates_t2.Location = new System.Drawing.Point(22, 88);
            this.label_currCoordinates_t2.Name = "label_currCoordinates_t2";
            this.label_currCoordinates_t2.Size = new System.Drawing.Size(100, 13);
            this.label_currCoordinates_t2.TabIndex = 1;
            this.label_currCoordinates_t2.Text = "Current Coordinates";
            // 
            // label_legNumber_t2
            // 
            this.label_legNumber_t2.AutoSize = true;
            this.label_legNumber_t2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_legNumber_t2.Location = new System.Drawing.Point(39, 26);
            this.label_legNumber_t2.Name = "label_legNumber_t2";
            this.label_legNumber_t2.Size = new System.Drawing.Size(65, 13);
            this.label_legNumber_t2.TabIndex = 0;
            this.label_legNumber_t2.Text = "Leg Number";
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::NoNameQuad_GUI.Properties.Resources.Capture;
            this.tabPage3.Controls.Add(this.button_Serv0_t3);
            this.tabPage3.Controls.Add(this.button_Serv180_t3);
            this.tabPage3.Controls.Add(this.button_Serv90_t3);
            this.tabPage3.Controls.Add(this.label_Serv0_t3);
            this.tabPage3.Controls.Add(this.label_Serv180_t3);
            this.tabPage3.Controls.Add(this.label_Serv90_t3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(588, 272);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Servo Calibration";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button_Serv0_t3
            // 
            this.button_Serv0_t3.Location = new System.Drawing.Point(189, 121);
            this.button_Serv0_t3.Name = "button_Serv0_t3";
            this.button_Serv0_t3.Size = new System.Drawing.Size(75, 23);
            this.button_Serv0_t3.TabIndex = 5;
            this.button_Serv0_t3.Text = "idk";
            this.button_Serv0_t3.UseVisualStyleBackColor = true;
            this.button_Serv0_t3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_Serv180_t3
            // 
            this.button_Serv180_t3.Location = new System.Drawing.Point(189, 81);
            this.button_Serv180_t3.Name = "button_Serv180_t3";
            this.button_Serv180_t3.Size = new System.Drawing.Size(75, 23);
            this.button_Serv180_t3.TabIndex = 4;
            this.button_Serv180_t3.Text = "Shazam";
            this.button_Serv180_t3.UseVisualStyleBackColor = true;
            // 
            // button_Serv90_t3
            // 
            this.button_Serv90_t3.Location = new System.Drawing.Point(189, 41);
            this.button_Serv90_t3.Name = "button_Serv90_t3";
            this.button_Serv90_t3.Size = new System.Drawing.Size(75, 23);
            this.button_Serv90_t3.TabIndex = 3;
            this.button_Serv90_t3.Text = "Wosh";
            this.button_Serv90_t3.UseVisualStyleBackColor = true;
            // 
            // label_Serv0_t3
            // 
            this.label_Serv0_t3.AutoSize = true;
            this.label_Serv0_t3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_Serv0_t3.Location = new System.Drawing.Point(52, 126);
            this.label_Serv0_t3.Name = "label_Serv0_t3";
            this.label_Serv0_t3.Size = new System.Drawing.Size(109, 13);
            this.label_Serv0_t3.TabIndex = 2;
            this.label_Serv0_t3.Text = "Calibrate Servos to 0°";
            // 
            // label_Serv180_t3
            // 
            this.label_Serv180_t3.AutoSize = true;
            this.label_Serv180_t3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_Serv180_t3.Location = new System.Drawing.Point(52, 86);
            this.label_Serv180_t3.Name = "label_Serv180_t3";
            this.label_Serv180_t3.Size = new System.Drawing.Size(121, 13);
            this.label_Serv180_t3.TabIndex = 1;
            this.label_Serv180_t3.Text = "Calibrate Servos to 180°";
            this.label_Serv180_t3.Click += new System.EventHandler(this.Serv180_Click);
            // 
            // label_Serv90_t3
            // 
            this.label_Serv90_t3.AutoSize = true;
            this.label_Serv90_t3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_Serv90_t3.Location = new System.Drawing.Point(52, 46);
            this.label_Serv90_t3.Name = "label_Serv90_t3";
            this.label_Serv90_t3.Size = new System.Drawing.Size(115, 13);
            this.label_Serv90_t3.TabIndex = 0;
            this.label_Serv90_t3.Text = "Calibrate Servos to 90°";
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(0, 0);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(200, 100);
            this.tabPage5.TabIndex = 0;
            // 
            // pictureBox_inverseK_t1
            // 
            this.pictureBox_inverseK_t1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_inverseK_t1.Image")));
            this.pictureBox_inverseK_t1.Location = new System.Drawing.Point(326, 21);
            this.pictureBox_inverseK_t1.Name = "pictureBox_inverseK_t1";
            this.pictureBox_inverseK_t1.Size = new System.Drawing.Size(247, 214);
            this.pictureBox_inverseK_t1.TabIndex = 24;
            this.pictureBox_inverseK_t1.TabStop = false;
            this.pictureBox_inverseK_t1.UseWaitCursor = true;
            // 
            // pictureBox_servos_t2
            // 
            this.pictureBox_servos_t2.Image = global::NoNameQuad_GUI.Properties.Resources.leg_planes;
            this.pictureBox_servos_t2.Location = new System.Drawing.Point(353, 43);
            this.pictureBox_servos_t2.Name = "pictureBox_servos_t2";
            this.pictureBox_servos_t2.Size = new System.Drawing.Size(224, 191);
            this.pictureBox_servos_t2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_servos_t2.TabIndex = 13;
            this.pictureBox_servos_t2.TabStop = false;
            this.pictureBox_servos_t2.Click += new System.EventHandler(this.pictureBox_servos_t2_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::NoNameQuad_GUI.Properties.Resources.Capture;
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.button7);
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(588, 272);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Robot Movement";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImage = global::NoNameQuad_GUI.Properties.Resources.Celtic_style_crossed_circle_svg;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(119, 90);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(92, 74);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = global::NoNameQuad_GUI.Properties.Resources.rotd7;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Location = new System.Drawing.Point(479, 51);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 152);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::NoNameQuad_GUI.Properties.Resources.rotate_left_circular_arrow_interface_symbol_318_48657;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Location = new System.Drawing.Point(368, 51);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 152);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::NoNameQuad_GUI.Properties.Resources.left;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(11, 90);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 74);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::NoNameQuad_GUI.Properties.Resources.right;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(229, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 74);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::NoNameQuad_GUI.Properties.Resources._130900;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(119, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 74);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::NoNameQuad_GUI.Properties.Resources.up;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(119, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 74);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NoNameQuad_GUI.Properties.Resources.Capture;
            this.ClientSize = new System.Drawing.Size(602, 296);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "DEVELOPMENT GUI ";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_inverseK_t1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_servos_t2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;

        private System.Windows.Forms.TabPage tabPage5;

        private System.Windows.Forms.Label label_legNumber_t2;
        private System.Windows.Forms.Button button_apply_t2;
        private System.Windows.Forms.TextBox textbox_zHold_t2;
        private System.Windows.Forms.TextBox textbox_yHold_t2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_zHold_t2;
        private System.Windows.Forms.Label label_yHold_t2;
        private System.Windows.Forms.Label label_xHold_t2;
        private System.Windows.Forms.Label label_zCoord_t2;
        private System.Windows.Forms.Label label_yCoord_t2;
        private System.Windows.Forms.Label label_xCoord_t2;
        private System.Windows.Forms.Label label_currCoordinates_t2;
        private System.Windows.Forms.PictureBox pictureBox_servos_t2;
        private System.Windows.Forms.ComboBox comboBox_legChoice_t2;

        private System.Windows.Forms.Label label_Serv90_t3;
        private System.Windows.Forms.Button button_Serv0_t3;
        private System.Windows.Forms.Button button_Serv180_t3;
        private System.Windows.Forms.Button button_Serv90_t3;
        private System.Windows.Forms.Label label_Serv0_t3;
        private System.Windows.Forms.Label label_Serv180_t3;

        private System.Windows.Forms.PictureBox pictureBox_inverseK_t1;
        private System.Windows.Forms.ComboBox comboBox_legNumber_t1;
        private System.Windows.Forms.Label label_gamma_t1;
        private System.Windows.Forms.Label label_beta_t1;
        private System.Windows.Forms.Label label_alpha_t1;
        private System.Windows.Forms.Label label_legnumber_t1;
        private System.Windows.Forms.TextBox textbox_gamma_t1;
        private System.Windows.Forms.TextBox textbox_beta_t1;
    //    private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_applyChanges_t1;
        private System.Windows.Forms.TextBox textbox_xHold_t2;
        private System.Windows.Forms.TextBox textbox_alpha_t1;
        private System.Windows.Forms.CheckBox checkbox_leg_t1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button4;
    }
}


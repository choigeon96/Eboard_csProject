namespace EBoard_csProject
{
    partial class Form_Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Timer_Features = new System.Windows.Forms.Timer(this.components);
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStrip_PortSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_PortConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_PortDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Macro = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_MacroSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_MacroDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox_Macro = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_Timer_Features = new System.Windows.Forms.NumericUpDown();
            this.radioButton_BlinkInverse = new System.Windows.Forms.RadioButton();
            this.radioButton_Blink = new System.Windows.Forms.RadioButton();
            this.radioButton_RightShift = new System.Windows.Forms.RadioButton();
            this.radioButton_LeftShift = new System.Windows.Forms.RadioButton();
            this.radioButton_Basic = new System.Windows.Forms.RadioButton();
            this.button_ResetDM3 = new System.Windows.Forms.Button();
            this.button_ResetDM2 = new System.Windows.Forms.Button();
            this.button_ResetDM1 = new System.Windows.Forms.Button();
            this.button_AllDeselect = new System.Windows.Forms.Button();
            this.button_InverseSelect = new System.Windows.Forms.Button();
            this.button_AllSelect = new System.Windows.Forms.Button();
            this.button_Print = new System.Windows.Forms.Button();
            this.button_PrintStop = new System.Windows.Forms.Button();
            this.textBox_TextPrint = new System.Windows.Forms.TextBox();
            this.checkBox_TextPrint = new System.Windows.Forms.CheckBox();
            this.MenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Timer_Features)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer_Features
            // 
            this.Timer_Features.Tick += new System.EventHandler(this.Timer_Features_Tick);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MenuStrip.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_PortSelect,
            this.toolStrip_PortConnect,
            this.toolStrip_PortDisconnect,
            this.toolStrip_Macro,
            this.toolStrip_Help});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.MenuStrip.Size = new System.Drawing.Size(1584, 29);
            this.MenuStrip.TabIndex = 3;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // toolStrip_PortSelect
            // 
            this.toolStrip_PortSelect.Name = "toolStrip_PortSelect";
            this.toolStrip_PortSelect.Size = new System.Drawing.Size(77, 21);
            this.toolStrip_PortSelect.Text = "포트 선택";
            this.toolStrip_PortSelect.Click += new System.EventHandler(this.ToolStrip_PortSelect_Click);
            // 
            // toolStrip_PortConnect
            // 
            this.toolStrip_PortConnect.Name = "toolStrip_PortConnect";
            this.toolStrip_PortConnect.Size = new System.Drawing.Size(77, 21);
            this.toolStrip_PortConnect.Text = "포트 연결";
            this.toolStrip_PortConnect.Click += new System.EventHandler(this.ToolStrip_PortConnect_Click);
            // 
            // toolStrip_PortDisconnect
            // 
            this.toolStrip_PortDisconnect.Enabled = false;
            this.toolStrip_PortDisconnect.Name = "toolStrip_PortDisconnect";
            this.toolStrip_PortDisconnect.Size = new System.Drawing.Size(77, 21);
            this.toolStrip_PortDisconnect.Text = "연결 해제";
            this.toolStrip_PortDisconnect.Click += new System.EventHandler(this.ToolStrip_PortDisconnect_Click);
            // 
            // toolStrip_Macro
            // 
            this.toolStrip_Macro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip_MacroSave,
            this.ToolStrip_MacroDelete,
            this.toolStripSeparator1,
            this.toolStripComboBox_Macro});
            this.toolStrip_Macro.Name = "toolStrip_Macro";
            this.toolStrip_Macro.Size = new System.Drawing.Size(59, 21);
            this.toolStrip_Macro.Text = "매크로";
            this.toolStrip_Macro.Click += new System.EventHandler(this.toolStrip_Macro_Click);
            // 
            // ToolStrip_MacroSave
            // 
            this.ToolStrip_MacroSave.Name = "ToolStrip_MacroSave";
            this.ToolStrip_MacroSave.Size = new System.Drawing.Size(181, 22);
            this.ToolStrip_MacroSave.Text = "매크로 저장";
            this.ToolStrip_MacroSave.Click += new System.EventHandler(this.ToolStrip_MacroSave_Click);
            // 
            // ToolStrip_MacroDelete
            // 
            this.ToolStrip_MacroDelete.Name = "ToolStrip_MacroDelete";
            this.ToolStrip_MacroDelete.Size = new System.Drawing.Size(181, 22);
            this.ToolStrip_MacroDelete.Text = "매크로 삭제";
            this.ToolStrip_MacroDelete.Click += new System.EventHandler(this.ToolStrip_MacroDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripComboBox_Macro
            // 
            this.toolStripComboBox_Macro.Name = "toolStripComboBox_Macro";
            this.toolStripComboBox_Macro.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox_Macro.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_Macro_SelectedIndexChanged);
            // 
            // toolStrip_Help
            // 
            this.toolStrip_Help.Name = "toolStrip_Help";
            this.toolStrip_Help.Size = new System.Drawing.Size(59, 21);
            this.toolStrip_Help.Text = "도움말";
            this.toolStrip_Help.Click += new System.EventHandler(this.toolStrip_Help_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(5346, 562);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 60);
            this.button5.TabIndex = 9;
            this.button5.Text = "1번 패턴 초기화";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown_Timer_Features);
            this.groupBox1.Controls.Add(this.radioButton_BlinkInverse);
            this.groupBox1.Controls.Add(this.radioButton_Blink);
            this.groupBox1.Controls.Add(this.radioButton_RightShift);
            this.groupBox1.Controls.Add(this.radioButton_LeftShift);
            this.groupBox1.Controls.Add(this.radioButton_Basic);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(394, 704);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 145);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "기능 선택";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어 Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(822, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "속도 설정(ms)";
            // 
            // numericUpDown_Timer_Features
            // 
            this.numericUpDown_Timer_Features.Font = new System.Drawing.Font("나눔스퀘어 Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numericUpDown_Timer_Features.Location = new System.Drawing.Point(826, 80);
            this.numericUpDown_Timer_Features.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_Timer_Features.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_Timer_Features.Name = "numericUpDown_Timer_Features";
            this.numericUpDown_Timer_Features.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown_Timer_Features.TabIndex = 5;
            this.numericUpDown_Timer_Features.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_Timer_Features.ValueChanged += new System.EventHandler(this.numericUpDown_Timer_Features_ValueChanged);
            // 
            // radioButton_BlinkInverse
            // 
            this.radioButton_BlinkInverse.AutoSize = true;
            this.radioButton_BlinkInverse.Font = new System.Drawing.Font("나눔스퀘어 Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton_BlinkInverse.Location = new System.Drawing.Point(526, 84);
            this.radioButton_BlinkInverse.Name = "radioButton_BlinkInverse";
            this.radioButton_BlinkInverse.Size = new System.Drawing.Size(104, 27);
            this.radioButton_BlinkInverse.TabIndex = 4;
            this.radioButton_BlinkInverse.Text = "반전깜빡";
            this.radioButton_BlinkInverse.UseVisualStyleBackColor = true;
            // 
            // radioButton_Blink
            // 
            this.radioButton_Blink.AutoSize = true;
            this.radioButton_Blink.Font = new System.Drawing.Font("나눔스퀘어 Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton_Blink.Location = new System.Drawing.Point(526, 43);
            this.radioButton_Blink.Name = "radioButton_Blink";
            this.radioButton_Blink.Size = new System.Drawing.Size(104, 27);
            this.radioButton_Blink.TabIndex = 3;
            this.radioButton_Blink.Text = "깜빡깜빡";
            this.radioButton_Blink.UseVisualStyleBackColor = true;
            // 
            // radioButton_RightShift
            // 
            this.radioButton_RightShift.AutoSize = true;
            this.radioButton_RightShift.Font = new System.Drawing.Font("나눔스퀘어 Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton_RightShift.Location = new System.Drawing.Point(253, 84);
            this.radioButton_RightShift.Name = "radioButton_RightShift";
            this.radioButton_RightShift.Size = new System.Drawing.Size(123, 27);
            this.radioButton_RightShift.TabIndex = 2;
            this.radioButton_RightShift.Text = "오른쪽으로";
            this.radioButton_RightShift.UseVisualStyleBackColor = true;
            // 
            // radioButton_LeftShift
            // 
            this.radioButton_LeftShift.AutoSize = true;
            this.radioButton_LeftShift.Font = new System.Drawing.Font("나눔스퀘어 Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton_LeftShift.Location = new System.Drawing.Point(253, 43);
            this.radioButton_LeftShift.Name = "radioButton_LeftShift";
            this.radioButton_LeftShift.Size = new System.Drawing.Size(104, 27);
            this.radioButton_LeftShift.TabIndex = 1;
            this.radioButton_LeftShift.Text = "왼쪽으로";
            this.radioButton_LeftShift.UseVisualStyleBackColor = true;
            // 
            // radioButton_Basic
            // 
            this.radioButton_Basic.AutoSize = true;
            this.radioButton_Basic.Checked = true;
            this.radioButton_Basic.Font = new System.Drawing.Font("나눔스퀘어 Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton_Basic.Location = new System.Drawing.Point(31, 43);
            this.radioButton_Basic.Name = "radioButton_Basic";
            this.radioButton_Basic.Size = new System.Drawing.Size(66, 27);
            this.radioButton_Basic.TabIndex = 0;
            this.radioButton_Basic.TabStop = true;
            this.radioButton_Basic.Text = "기본";
            this.radioButton_Basic.UseVisualStyleBackColor = true;
            // 
            // button_ResetDM3
            // 
            this.button_ResetDM3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_ResetDM3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_ResetDM3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button_ResetDM3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin;
            this.button_ResetDM3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ResetDM3.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_ResetDM3.Location = new System.Drawing.Point(1070, 567);
            this.button_ResetDM3.Name = "button_ResetDM3";
            this.button_ResetDM3.Size = new System.Drawing.Size(180, 50);
            this.button_ResetDM3.TabIndex = 11;
            this.button_ResetDM3.Text = "3번 패턴 초기화";
            this.button_ResetDM3.UseVisualStyleBackColor = false;
            this.button_ResetDM3.Click += new System.EventHandler(this.button_ResetDM3_Click);
            // 
            // button_ResetDM2
            // 
            this.button_ResetDM2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_ResetDM2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_ResetDM2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button_ResetDM2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin;
            this.button_ResetDM2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ResetDM2.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_ResetDM2.Location = new System.Drawing.Point(544, 567);
            this.button_ResetDM2.Name = "button_ResetDM2";
            this.button_ResetDM2.Size = new System.Drawing.Size(180, 50);
            this.button_ResetDM2.TabIndex = 10;
            this.button_ResetDM2.Text = "2번 패턴 초기화";
            this.button_ResetDM2.UseVisualStyleBackColor = false;
            this.button_ResetDM2.Click += new System.EventHandler(this.button_ResetDM2_Click);
            // 
            // button_ResetDM1
            // 
            this.button_ResetDM1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_ResetDM1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_ResetDM1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button_ResetDM1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin;
            this.button_ResetDM1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ResetDM1.Font = new System.Drawing.Font("나눔스퀘어 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_ResetDM1.Location = new System.Drawing.Point(14, 567);
            this.button_ResetDM1.Name = "button_ResetDM1";
            this.button_ResetDM1.Size = new System.Drawing.Size(180, 50);
            this.button_ResetDM1.TabIndex = 8;
            this.button_ResetDM1.Text = "1번 패턴 초기화";
            this.button_ResetDM1.UseVisualStyleBackColor = false;
            this.button_ResetDM1.Click += new System.EventHandler(this.button_ResetDM1_Click);
            // 
            // button_AllDeselect
            // 
            this.button_AllDeselect.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_AllDeselect.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_AllDeselect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button_AllDeselect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin;
            this.button_AllDeselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AllDeselect.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_AllDeselect.Location = new System.Drawing.Point(12, 751);
            this.button_AllDeselect.Name = "button_AllDeselect";
            this.button_AllDeselect.Size = new System.Drawing.Size(180, 100);
            this.button_AllDeselect.TabIndex = 5;
            this.button_AllDeselect.Text = "초기화";
            this.button_AllDeselect.UseVisualStyleBackColor = false;
            this.button_AllDeselect.Click += new System.EventHandler(this.button_AllDeselect_Click);
            // 
            // button_InverseSelect
            // 
            this.button_InverseSelect.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_InverseSelect.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_InverseSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button_InverseSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin;
            this.button_InverseSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_InverseSelect.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_InverseSelect.Location = new System.Drawing.Point(200, 641);
            this.button_InverseSelect.Name = "button_InverseSelect";
            this.button_InverseSelect.Size = new System.Drawing.Size(180, 210);
            this.button_InverseSelect.TabIndex = 7;
            this.button_InverseSelect.Text = "선택 반전";
            this.button_InverseSelect.UseVisualStyleBackColor = false;
            this.button_InverseSelect.Click += new System.EventHandler(this.button_InverseSelect_Click);
            // 
            // button_AllSelect
            // 
            this.button_AllSelect.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_AllSelect.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_AllSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button_AllSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin;
            this.button_AllSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AllSelect.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_AllSelect.Location = new System.Drawing.Point(12, 641);
            this.button_AllSelect.Name = "button_AllSelect";
            this.button_AllSelect.Size = new System.Drawing.Size(180, 100);
            this.button_AllSelect.TabIndex = 6;
            this.button_AllSelect.Text = "전체 선택";
            this.button_AllSelect.UseVisualStyleBackColor = false;
            this.button_AllSelect.Click += new System.EventHandler(this.button_AllSelect_Click);
            // 
            // button_Print
            // 
            this.button_Print.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Print.Enabled = false;
            this.button_Print.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Print.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button_Print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin;
            this.button_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Print.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Print.Location = new System.Drawing.Point(1392, 697);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(180, 154);
            this.button_Print.TabIndex = 2;
            this.button_Print.Text = "출력";
            this.button_Print.UseVisualStyleBackColor = false;
            this.button_Print.Click += new System.EventHandler(this.Button_Print_Click);
            // 
            // button_PrintStop
            // 
            this.button_PrintStop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_PrintStop.Enabled = false;
            this.button_PrintStop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_PrintStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button_PrintStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin;
            this.button_PrintStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PrintStop.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_PrintStop.Location = new System.Drawing.Point(1392, 641);
            this.button_PrintStop.Name = "button_PrintStop";
            this.button_PrintStop.Size = new System.Drawing.Size(180, 50);
            this.button_PrintStop.TabIndex = 4;
            this.button_PrintStop.Text = "출력 중지";
            this.button_PrintStop.UseVisualStyleBackColor = false;
            this.button_PrintStop.Click += new System.EventHandler(this.Button_PrintStop_Click);
            // 
            // textBox_TextPrint
            // 
            this.textBox_TextPrint.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_TextPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_TextPrint.Location = new System.Drawing.Point(544, 649);
            this.textBox_TextPrint.MaxLength = 20;
            this.textBox_TextPrint.Name = "textBox_TextPrint";
            this.textBox_TextPrint.Size = new System.Drawing.Size(832, 35);
            this.textBox_TextPrint.TabIndex = 14;
            this.textBox_TextPrint.Leave += new System.EventHandler(this.textBox_TextPrint_Leave);
            // 
            // checkBox_TextPrint
            // 
            this.checkBox_TextPrint.AutoSize = true;
            this.checkBox_TextPrint.Font = new System.Drawing.Font("나눔스퀘어 Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox_TextPrint.Location = new System.Drawing.Point(409, 653);
            this.checkBox_TextPrint.Name = "checkBox_TextPrint";
            this.checkBox_TextPrint.Size = new System.Drawing.Size(129, 27);
            this.checkBox_TextPrint.TabIndex = 13;
            this.checkBox_TextPrint.Text = "텍스트 출력";
            this.checkBox_TextPrint.UseVisualStyleBackColor = true;
            this.checkBox_TextPrint.CheckedChanged += new System.EventHandler(this.checkBox_TextPrint_CheckedChanged);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.textBox_TextPrint);
            this.Controls.Add(this.checkBox_TextPrint);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_ResetDM3);
            this.Controls.Add(this.button_ResetDM2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button_ResetDM1);
            this.Controls.Add(this.button_InverseSelect);
            this.Controls.Add(this.button_AllSelect);
            this.Controls.Add(this.button_AllDeselect);
            this.Controls.Add(this.button_PrintStop);
            this.Controls.Add(this.button_Print);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Form_Main";
            this.Text = "DOTMATRIX";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Timer_Features)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer Timer_Features;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_PortConnect;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_PortDisconnect;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_Macro;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_Help;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_PortSelect;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_BlinkInverse;
        private System.Windows.Forms.RadioButton radioButton_Blink;
        private System.Windows.Forms.RadioButton radioButton_RightShift;
        private System.Windows.Forms.RadioButton radioButton_LeftShift;
        private System.Windows.Forms.RadioButton radioButton_Basic;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_MacroSave;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_MacroDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_Macro;
        private System.Windows.Forms.NumericUpDown numericUpDown_Timer_Features;
        private System.Windows.Forms.Button button_ResetDM3;
        private System.Windows.Forms.Button button_ResetDM2;
        private System.Windows.Forms.Button button_ResetDM1;
        private System.Windows.Forms.Button button_AllDeselect;
        private System.Windows.Forms.Button button_InverseSelect;
        private System.Windows.Forms.Button button_AllSelect;
        private System.Windows.Forms.Button button_Print;
        private System.Windows.Forms.Button button_PrintStop;
        private System.Windows.Forms.TextBox textBox_TextPrint;
        private System.Windows.Forms.CheckBox checkBox_TextPrint;
    }
}


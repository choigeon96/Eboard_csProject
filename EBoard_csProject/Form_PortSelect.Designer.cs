namespace EBoard_csProject
{
    partial class Form_PortSelect
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PortSelect));
            this.ComboBox_Comport = new System.Windows.Forms.ComboBox();
            this.button_Select = new System.Windows.Forms.Button();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // ComboBox_Comport
            // 
            this.ComboBox_Comport.Font = new System.Drawing.Font("나눔스퀘어", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ComboBox_Comport.FormattingEnabled = true;
            this.ComboBox_Comport.Location = new System.Drawing.Point(12, 16);
            this.ComboBox_Comport.Name = "ComboBox_Comport";
            this.ComboBox_Comport.Size = new System.Drawing.Size(155, 25);
            this.ComboBox_Comport.TabIndex = 0;
            // 
            // button_Select
            // 
            this.button_Select.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Select.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button_Select.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Select.Font = new System.Drawing.Font("나눔스퀘어", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Select.Location = new System.Drawing.Point(197, 16);
            this.button_Select.Name = "button_Select";
            this.button_Select.Size = new System.Drawing.Size(78, 29);
            this.button_Select.TabIndex = 1;
            this.button_Select.Text = "선택";
            this.button_Select.UseVisualStyleBackColor = true;
            this.button_Select.Click += new System.EventHandler(this.button_Select_Click);
            // 
            // Form_ComportSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 56);
            this.Controls.Add(this.button_Select);
            this.Controls.Add(this.ComboBox_Comport);
            this.Font = new System.Drawing.Font("나눔스퀘어", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_ComportSelect";
            this.Text = "포트 선택";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox_Comport;
        private System.Windows.Forms.Button button_Select;
        private System.IO.Ports.SerialPort SerialPort;
    }
}
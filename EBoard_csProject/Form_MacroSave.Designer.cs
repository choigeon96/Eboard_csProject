namespace EBoard_csProject
{
    partial class Form_MacroSave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MacroSave));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_MacroSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "매크로 이름 입력";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("나눔스퀘어 Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(15, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 25);
            this.textBox1.TabIndex = 1;
            // 
            // button_MacroSave
            // 
            this.button_MacroSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_MacroSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_MacroSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button_MacroSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin;
            this.button_MacroSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MacroSave.Font = new System.Drawing.Font("나눔스퀘어", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_MacroSave.Location = new System.Drawing.Point(246, 76);
            this.button_MacroSave.Name = "button_MacroSave";
            this.button_MacroSave.Size = new System.Drawing.Size(76, 28);
            this.button_MacroSave.TabIndex = 12;
            this.button_MacroSave.Text = "저장";
            this.button_MacroSave.UseVisualStyleBackColor = false;
            this.button_MacroSave.Click += new System.EventHandler(this.button_MacroSave_Click);
            // 
            // Form_MacroSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(334, 116);
            this.Controls.Add(this.button_MacroSave);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_MacroSave";
            this.Text = "매크로 저장";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_MacroSave;
    }
}
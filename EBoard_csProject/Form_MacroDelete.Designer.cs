namespace EBoard_csProject
{
    partial class Form_MacroDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MacroDelete));
            this.button_MacroDelete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_MacroDelete
            // 
            this.button_MacroDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_MacroDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_MacroDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.button_MacroDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin;
            this.button_MacroDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MacroDelete.Font = new System.Drawing.Font("나눔스퀘어", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_MacroDelete.Location = new System.Drawing.Point(200, 8);
            this.button_MacroDelete.Name = "button_MacroDelete";
            this.button_MacroDelete.Size = new System.Drawing.Size(76, 28);
            this.button_MacroDelete.TabIndex = 13;
            this.button_MacroDelete.Text = "삭제";
            this.button_MacroDelete.UseVisualStyleBackColor = false;
            this.button_MacroDelete.Click += new System.EventHandler(this.button_MacroDelete_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("나눔스퀘어", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 22);
            this.comboBox1.TabIndex = 14;
            // 
            // Form_MacroDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 47);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_MacroDelete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_MacroDelete";
            this.Text = "매크로 삭제";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_MacroDelete;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBoard_csProject
{
    public partial class Form_MacroDelete : Form
    {
        public Form_MacroDelete()
        {
            InitializeComponent();

            foreach (var item in DataManager.Macros)
            {
                comboBox1.Items.Add(item.MacroName);
            }
        }

        private void button_MacroDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Macro macro = DataManager.Macros.Single((x) => x.MacroName == comboBox1.Text);
                DataManager.Macros.Remove(macro);
                DataManager.Save();
                this.Close();
                MessageBox.Show("성공적으로 삭제되었습니다", "삭제 완료");
            }
            catch
            {
                MessageBox.Show("존재하지 않는 이름입니다!", "오류");
            }
        }
    }
}

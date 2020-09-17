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
    public partial class Form_MacroSave : Form
    {
        public Form_MacroSave()
        {
            InitializeComponent();
        }

        private void button_MacroSave_Click(object sender, EventArgs e)
        {
            Macro macro = new Macro();
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("저장할 이름을 입력해주세요", "오류");
            }
            else if (textBox1.Text.Trim() == "매크로 선택")
            {
                MessageBox.Show("다른 이름을 입력해주세요", "오류");
            }
            else if(DataManager.Macros.Exists((x) => x.MacroName == textBox1.Text.Trim()))
            {
                MessageBox.Show("이미 존재하는 이름입니다!", "오류");
            }
            else
            {
                macro.MacroName = textBox1.Text.Trim();
                for (int i = 0; i < 24; i++)
                {
                    macro.MacroStringData[i] = Packet.Data[i].ToString();
                }
                DataManager.Macros.Add(macro);
                DataManager.Save();
                this.Close();
                MessageBox.Show("성공적으로 저장되었습니다", "저장 완료");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace EBoard_csProject
{
    public partial class Form_PortSelect : Form
    {
        public Form_PortSelect()
        {
            InitializeComponent();

            ComboBox_Comport.BeginUpdate();
            ComboBox_Comport.Text = "포트 선택";
            foreach (string comport in SerialPort.GetPortNames())
                ComboBox_Comport.Items.Add(comport);
        }

        private void button_Select_Click(object sender, EventArgs e)
        {
            if(ComboBox_Comport.Text != "포트 선택")
            {
                Serial.ComportString = ComboBox_Comport.Text;
                this.Close();
                MessageBox.Show("포트를 선택한 후에는 포트 연결 버튼을 눌러주세요", "도움말");
            }
            else
            {
                MessageBox.Show("포트를 선택해 주세요", "오류");
            }
        }
    }
}

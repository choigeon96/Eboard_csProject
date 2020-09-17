using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EBoard_csProject
{
    public partial class Form_Main : Form
    {
        // 폼 내 도트매트릭스 개수
        private const int DM_Count = 3;
        Dotmatrix[] dot = new Dotmatrix[DM_Count];
        // 블링크 기능
        private bool BlinkFlag = false;

        // 메인 폼 생성자
        public Form_Main()
        {
            InitializeComponent();

            // 도트 매트릭스
            for (int i = 0; i < DM_Count; i++)
            {
                dot[i] = new Dotmatrix(i, this);
            }

            toolStripComboBox_Macro.BeginUpdate();

            // 시리얼 초기 설정
            Serial.SerialPort = serialPort1;
            Serial.Init();
        }

        private void Print()
        {
            button_PrintStop.Enabled = true;
            button_Print.Enabled = false;
            checkBox_TextPrint.Enabled = false;
            groupBox1.Enabled = false;
            textBox_TextPrint.Enabled = false;
        }

        // 출력 중지시
        private void PrintStop()
        {
            SendPacket.OFF();
            checkBox_TextPrint.Enabled = true;
            button_Print.Enabled = true;
            button_PrintStop.Enabled = false;
            Timer_Features.Enabled = false;
            groupBox1.Enabled = true;
            textBox_TextPrint.Enabled = true;
            SendPacket.ShiftStart = 0;
            BlinkFlag = false;
        }


        // 버튼 출력 (시리얼 전송 시작)
        private void Button_Print_Click(object sender, EventArgs e)
        {
            try
            {
                Print();
                if (checkBox_TextPrint.Checked == true)
                {
                    if (textBox_TextPrint.TextLength < 3)
                    {
                        MessageBox.Show("3글자 이상 입력해주세요", "오류");
                        PrintStop();
                    }
                    else
                    {
                        Packet.RemoveDataText();
                        Packet.InsertDataText(textBox_TextPrint.Text);
                        Packet.CalcChecksumText();
                        Timer_Features.Enabled = true;
                    }
                }
                else if(radioButton_Basic.Checked == true)
                {
                    Packet.CalcChecksum();
                    SendPacket.Normal();
                }
                else
                {
                    Timer_Features.Enabled = true;
                    if(radioButton_BlinkInverse.Checked == true)
                    {
                        Packet.CalcDataInverse();
                    }
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message, "오류");
            }
        }
        

        // 버튼 출력 중지 (시리얼 전송 종료)
        private void Button_PrintStop_Click(object sender, EventArgs e)
        {
            PrintStop();
        }


        // 메뉴바 포트 연결
        private void ToolStrip_PortConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Serial.ComportUpdate();
                Serial.Connect();
                MessageBox.Show("포트가 연결되었습니다.", serialPort1.PortName);
                // 텍스트 출력 체크 해제
                checkBox_TextPrint.Checked = false;
                // 메뉴바 포트 선택, 연결 비활성화 / 연결 해제 활성화
                toolStrip_PortSelect.Enabled = false;
                toolStrip_PortConnect.Enabled = false;
                toolStrip_PortDisconnect.Enabled = true;
                // 출력 활성화, 출력 중지 비활성화
                button_Print.Enabled = true;
                button_PrintStop.Enabled = false;
            }
            catch
            {
                MessageBox.Show("포트 선택 오류입니다", "오류");
            }
        }


        // 메뉴바 연결 해제
        private void ToolStrip_PortDisconnect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("포트 연결이 해제되었습니다.", serialPort1.PortName);
            Serial.ComportString = "";
            PrintStop();
            Serial.Disconnect();
            // 텍스트 출력 체크 해제
            checkBox_TextPrint.Checked = false;
            // 메뉴바 포트 선택, 연결 활성화 / 연결 해제 비활성화
            toolStrip_PortSelect.Enabled = true;
            toolStrip_PortConnect.Enabled = true;
            toolStrip_PortDisconnect.Enabled = false;
        }


        // 메뉴바 포트 선택
        private void ToolStrip_PortSelect_Click(object sender, EventArgs e)
        {
            Form_PortSelect form = new Form_PortSelect();
            form.ShowDialog();
        }


        // 버튼 전체 선택
        private void button_AllSelect_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < DM_Count; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    for(int k = 0; k < 8; k++)
                    {
                        Dotmatrix.DotSelect(dot[i], j, k);
                    }
                }
            }
        }
        

        // 버튼 초기화
        private void button_AllDeselect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DM_Count; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    for (int k = 0; k < 8; k++)
                    {
                        Dotmatrix.DotDeselect(dot[i], j, k);
                    }
                }
            }
        }
       

        // 버튼 선택 반전
        private void button_InverseSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DM_Count; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    for (int k = 0; k < 8; k++)
                    {
                        Dotmatrix.DotInverse(dot[i], j, k);
                    }
                }
            }
        }


        // 버튼 1번 도트매트릭스 초기화
        private void button_ResetDM1_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 8; j++)
            {
                for (int k = 0; k < 8; k++)
                {
                    Dotmatrix.DotDeselect(dot[0], j, k);
                }
            }
        }


        // 버튼 2번 도트매트릭스 초기화
        private void button_ResetDM2_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 8; j++)
            {
                for (int k = 0; k < 8; k++)
                {
                    Dotmatrix.DotDeselect(dot[1], j, k);
                }
            }
        }


        // 버튼 3번 도트매트릭스 초기화
        private void button_ResetDM3_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 8; j++)
            {
                for (int k = 0; k < 8; k++)
                {
                    Dotmatrix.DotDeselect(dot[2], j, k);
                }
            }
        }


        // 타이머 추가 기능작동
        private void Timer_Features_Tick(object sender, EventArgs e)
        {
            if(checkBox_TextPrint.Checked == true)
            {
                if (radioButton_LeftShift.Checked == true)
                {
                    SendPacket.PrintTextLS();
                }
                // 오른쪽 시프트
                else if (radioButton_RightShift.Checked == true)
                {
                    SendPacket.PrintTextRS();
                }
            }
            else
            {
                // 왼쪽 시프트
                if (radioButton_LeftShift.Checked == true)
                {
                    SendPacket.LeftShift();
                }
                // 오른쪽 시프트
                else if (radioButton_RightShift.Checked == true)
                {
                    SendPacket.RightShift();
                }
                // 블링크
                else if (radioButton_Blink.Checked == true)
                {
                    if (BlinkFlag == true)
                    {
                        SendPacket.Normal();
                        BlinkFlag = false;
                    }
                    else
                    {
                        SendPacket.OFF();
                        BlinkFlag = true;
                    }
                }
                // 반전 블링크
                else if (radioButton_BlinkInverse.Checked == true)
                {
                    if (BlinkFlag == true)
                    {
                        SendPacket.BlinkInverse();
                        BlinkFlag = false;
                    }
                    else
                    {
                        SendPacket.Normal();
                        BlinkFlag = true;
                    }
                }
            }
        }


        // 타이머 속도 조절
        private void numericUpDown_Timer_Features_ValueChanged(object sender, EventArgs e)
        {
            Timer_Features.Interval = (int)numericUpDown_Timer_Features.Value;
        }


        // 메뉴바 매크로 클릭 ( Macro.xml 파일 업데이트 )
        private void toolStrip_Macro_Click(object sender, EventArgs e)
        {
            toolStripComboBox_Macro.Text = "매크로 선택";
            toolStripComboBox_Macro.Items.Clear();
            foreach (var item in DataManager.Macros)
            {
                toolStripComboBox_Macro.Items.Add(item.MacroName);
            }
        }


        // 메뉴바_매크로 매크로 저장 클릭
        private void ToolStrip_MacroSave_Click(object sender, EventArgs e)
        {
            Form_MacroSave form = new Form_MacroSave();
            form.ShowDialog();
        }


        // 메뉴바_매크로 매크로 삭제 클릭
        private void ToolStrip_MacroDelete_Click(object sender, EventArgs e)
        {
            Form_MacroDelete form = new Form_MacroDelete();
            form.ShowDialog();
        }


        // 메뉴바_매크로 저장된 매크로 선택
        private void toolStripComboBox_Macro_SelectedIndexChanged(object sender, EventArgs e)
        {
            Macro macro = DataManager.Macros.Single((x) => x.MacroName == toolStripComboBox_Macro.Text);
            for(int i = 0; i < 24; i++)
            {
                int position = 0;
                int[] bufBin = new int[8];
                int bufData = 0; 
                // 매크로 문자열 -> byte로 변환
                bufData = byte.Parse(macro.MacroStringData[i]);

                // 1byte 10진수 -> 8bit 2진수 배열로 변환
                while(bufData != 0)
                {
                    bufBin[position++] = bufData % 2;
                    bufData /= 2;
                }
                for (int j = 0; j < 8; j++)
                {
                    if (bufBin[j] == 1)
                    {
                        // ImageState, SelectState 전환
                        // i/8 => 0, 1, 2
                        // i%8 => 0, 1, 2, 3, 4, 5, 6, 7
                        Dotmatrix.DotSelect(dot[i / 8], i % 8, j);
                    }
                    else
                    {
                        Dotmatrix.DotDeselect(dot[i / 8], i % 8, j);
                    }
                }
            }
        }


        // 메뉴바 도움말 클릭
        private void toolStrip_Help_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@".\Data\help.pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "오류");
            }
        }


        // 문자열 출력 버튼 클릭시
        private void checkBox_TextPrint_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_TextPrint.Checked == true)
            {
                radioButton_LeftShift.Checked = true;
                radioButton_Basic.Enabled = false;
                radioButton_Blink.Enabled = false;
                radioButton_BlinkInverse.Enabled = false;
            }
            else
            {
                radioButton_Basic.Checked = true;
                radioButton_Basic.Enabled = true;
                radioButton_Blink.Enabled = true;
                radioButton_BlinkInverse.Enabled = true;
            }
        }


        // 텍스트 박스 Leave Event  -  텍스트박스 영문자 제한(정규식)
        private void textBox_TextPrint_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[a-zA-Z]");
            Boolean ismatch = regex.IsMatch(textBox_TextPrint.Text);

            Regex regex2 = new Regex(@"[ㄱ-ㅎㅏ-ㅣ가-힣]");
            Boolean ismatch2 = regex2.IsMatch(textBox_TextPrint.Text);

            if (!ismatch || ismatch2)
            {
                MessageBox.Show("영문자만 입력해 주세요.");
                textBox_TextPrint.Text = Regex.Replace(textBox_TextPrint.Text, @"[ㄱ-ㅎㅏ-ㅣ가-힣]", "");
            }
        }
    }
}
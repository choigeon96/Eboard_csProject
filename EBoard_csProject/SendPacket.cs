using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBoard_csProject
{
    class SendPacket
    {
        public static int ShiftStart = 0;
        public static int ShiftStart_Text = 0;

        // 기본 출력(ON)
        public static void Normal()
        {
            Serial.SerialPort.Write(Packet.STX, 0, 1);
            Serial.SerialPort.Write(Packet.Data, 0, 24);
            Serial.SerialPort.Write(Packet.Checksum, 0, 1);
            Serial.SerialPort.Write(Packet.ETX, 0, 1);
        }

        // OFF
        public static void OFF()
        {
            Serial.SerialPort.Write(Packet.STX, 0, 1);
            for (int i = 0; i < 24; i++)
            {
                Serial.SerialPort.Write(Packet.Data_0, 0, 1);
            }
            Serial.SerialPort.Write(Packet.Checksum_0, 0, 1);
            Serial.SerialPort.Write(Packet.ETX, 0, 1);
        }

        // 왼쪽 시프트
        public static void LeftShift()
        {
            Serial.SerialPort.Write(Packet.STX, 0, 1);
            Serial.SerialPort.Write(Packet.Data, ShiftStart, 24 - ShiftStart);
            Serial.SerialPort.Write(Packet.Data, 0, ShiftStart);
            ShiftStart = (ShiftStart + 1) % 24;
            Serial.SerialPort.Write(Packet.Checksum, 0, 1);
            Serial.SerialPort.Write(Packet.ETX, 0, 1);
        }

        // 오른쪽 시프트
        public static void RightShift()
        {
            Serial.SerialPort.Write(Packet.STX, 0, 1);
            Serial.SerialPort.Write(Packet.Data, 24 - ShiftStart, ShiftStart);
            Serial.SerialPort.Write(Packet.Data, 0, 24 - ShiftStart);
            ShiftStart = (ShiftStart + 1) % 24;
            Serial.SerialPort.Write(Packet.Checksum, 0, 1);
            Serial.SerialPort.Write(Packet.ETX, 0, 1);
        }

        // 반전 블링크
        public static void BlinkInverse()
        {
            Serial.SerialPort.Write(Packet.STX, 0, 1);
            Serial.SerialPort.Write(Packet.DataInverse, 0, 24);
            Serial.SerialPort.Write(Packet.ChecksumInverse, 0, 1);
            Serial.SerialPort.Write(Packet.ETX, 0, 1);
        }

        // 텍스트 출력 왼쪽 시프트
        public static void PrintTextLS()
        {
            Serial.SerialPort.Write(Packet.STX, 0, 1);
            Serial.SerialPort.Write(Packet.Data_Text, ShiftStart_Text,
                Math.Min(24, Packet.Data_TextLength - ShiftStart_Text));
            Serial.SerialPort.Write(Packet.Data_Text, 0,
                Math.Max(0, 24 - (Packet.Data_TextLength - ShiftStart_Text)));
            Serial.SerialPort.Write(Packet.Checksum_Text, ShiftStart_Text, 1);
            Serial.SerialPort.Write(Packet.ETX, 0, 1);
            ShiftStart_Text = (ShiftStart_Text + 1) % Packet.Data_TextLength;
        }

        // 텍스트 출력 오른쪽 시프트
        public static void PrintTextRS()
        {
            Serial.SerialPort.Write(Packet.STX, 0, 1);
            Serial.SerialPort.Write(Packet.Data_Text, Packet.Data_TextLength - ShiftStart_Text,
                Math.Min(24, ShiftStart_Text));
            Serial.SerialPort.Write(Packet.Data_Text, 0,
                Math.Max(0, 24 - ShiftStart_Text));
            Serial.SerialPort.Write(Packet.Checksum_Text, (Packet.Data_TextLength - ShiftStart_Text) % Packet.Data_TextLength, 1);
            Serial.SerialPort.Write(Packet.ETX, 0, 1);
            ShiftStart_Text = (ShiftStart_Text + 1) % Packet.Data_TextLength;
        }
    }
}

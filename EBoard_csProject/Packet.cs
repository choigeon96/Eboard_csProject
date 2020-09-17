using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBoard_csProject
{
    class Packet
    {
        public static byte[] STX { get; set; }
        public static byte[] ETX { get; set; }
        public static byte[] Checksum { get; set; }
        public static byte[] Data { get; set; }

        public static byte[] DataInverse { get; set; }
        public static byte[] ChecksumInverse { get; set; }

        public static byte[] Data_0 { get; set; }
        public static byte[] Checksum_0 { get; set; }

        public static byte[] Data_Text { get; set; }
        public static byte[] Checksum_Text { get; set; }
        public static int Data_TextLength { get; set; }

        static Packet()
        {
            STX = new byte[1];
            STX[0] = new byte();
            STX[0] = 2;

            ETX = new byte[1];
            ETX[0] = new byte();
            ETX[0] = 3;

            Checksum = new byte[1];
            Checksum[0] = new byte();
            Checksum[0] = 0;

            Data = new byte[24];
            for (int i = 0; i < 24; i++)
            {
                Data[i] = new byte();
                Data[i] = 0;
            }

            DataInverse = new byte[24];
            for (int i = 0; i < 24; i++)
            {
                DataInverse[i] = new byte();
                DataInverse[i] = 0;
            }

            ChecksumInverse = new byte[1];
            ChecksumInverse[0] = new byte();
            ChecksumInverse[0] = 0;

            Data_0 = new byte[1];
            Data_0[0] = new byte();
            Data_0[0] = 0;

            Checksum_0 = new byte[1];
            Checksum_0[0] = new byte();
            Checksum_0[0] = 0;
            Checksum_0[0] = (byte)((~Checksum_0[0]) + 1);

            Data_Text = new byte[160];
            for (int i = 0; i < 160; i++)
            {
                Data_Text[i] = new byte();
                Data_Text[i] = 0;
            }

            Checksum_Text = new byte[160];
            for (int i = 0; i < 160; i++)
            {
                Checksum_Text[i] = new byte();
                Checksum_Text[i] = 0;
            }
        }

        public static void CalcChecksum(byte[] CS, byte[] _Data)
        {
            byte _checksum = 0;
            for (int i = 0; i < 24; i++)
            {
                _checksum += _Data[i];
            }
            CS[0] = (byte)((~_checksum) + 1);
        }

        public static void CalcChecksum()
        {
            byte _checksum = 0;
            for (int i = 0; i < 24; i++)
            {
                _checksum += Data[i];
            }
            Checksum[0] = (byte)((~_checksum) + 1);
        }

        public static void CalcDataInverse()
        {
            for (int i = 0; i < 24; i++)
            {
                DataInverse[i] = (byte)(~Data[i]);
            }
            CalcChecksum(ChecksumInverse, DataInverse);
        }

        public static void InsertDataText(string str)
        {
            int i = 0;
            foreach (var item in str)
            {
                if (item >= 97)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        Data_Text[i + j] = Font.SmallLetter[item - 97, j];
                    }
                }
                else if (item >= 65)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        Data_Text[i + j] = Font.CapitalLetter[item - 65, j];
                    }
                }
                else
                {
                    for (int j = 0; j < 8; j++)
                    {
                        Data_Text[i + j] = Font.Whitespace[j];
                    }
                }
                i += 8;
            }
            Data_TextLength = i;
        }

        public static void RemoveDataText()
        {
            Array.Clear(Data_Text, 0, Data_TextLength);
            Array.Clear(Checksum_Text, 0, Data_TextLength);
            SendPacket.ShiftStart_Text = 0;
            Data_TextLength = 0;
        }

        public static void CalcChecksumText()
        {
            for (int i = 0; i < Data_TextLength; i++)
            {
                byte _checksum = 0;
                for(int j = i; j < Math.Min(i + 24, Data_TextLength); j++)
                {
                    _checksum += Data_Text[j];
                }
                for(int j = 0; j < i - (Data_TextLength - 24); j++)
                {
                    _checksum += Data_Text[j];
                }
                Checksum_Text[i] = (byte)((~_checksum )+ 1);
            }
        }
    }
}

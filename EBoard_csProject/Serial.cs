using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBoard_csProject
{
    class Serial
    {
        public static string ComportString { get; set; }
        public static SerialPort SerialPort { get; set; }

        public static void Init()
        {
            SerialPort.BaudRate = 76800;
            SerialPort.DataBits = 8;
            SerialPort.Parity = Parity.None;
            SerialPort.StopBits = StopBits.One;
        }

        public static void ComportUpdate()
        {
            SerialPort.PortName = ComportString;
        }

        public static void Connect()
        {
            SerialPort.Open();
        }

        public static void Disconnect()
        {
            SerialPort.Close();
        }
    }
}

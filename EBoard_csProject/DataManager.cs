using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace EBoard_csProject
{
    class DataManager
    {
        public static List<Macro> Macros = new List<Macro>();

        static DataManager()
        {
            try
            {
                Load();
            }
            catch
            {
                Save();
            }
        }

        public static void Load()
        {
            try
            {
                string macroOutput = File.ReadAllText(@"./Data/Macro.xml");
                XElement macroXElement = XElement.Parse(macroOutput);
                Macros = (from item in macroXElement.Descendants("macro")
                          select new Macro()
                          {
                              MacroName = item.Element("macroName").Value,
                              MacroStringData = item.Element("macroData").Value.Split(new char[] { ',' })
                          }).ToList<Macro>();
            }
            catch (FileLoadException)
            {
                Save();
            }
        }

        public static void Save()
        {
            string macroOutput = "";
            macroOutput += "<macros>\n";
            foreach(var item in Macros)
            {
                macroOutput += "<macro>\n";
                macroOutput += "  <macroName>" + item.MacroName + "</macroName>\n";
                macroOutput += "  <macroData>" + item.MacroStringData[0];
                for(int i = 1; i < 24; i ++)
                {
                   macroOutput += "," + item.MacroStringData[i];
                }
                macroOutput += "</macroData>\n";
                macroOutput += "</macro>\n";
            }
            macroOutput += "</macros>\n";

            File.WriteAllText(@"./Data/Macro.xml", macroOutput);
        }
    }
}

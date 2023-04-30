using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuinsomTestProgram.SaveToFile
{
    internal class SaveFile
    {
        public bool SaveFileMethod(List<string> saveObj, string fileNamePath)
        {
            // Jeg konvertere listen over til StringBuilder fordi jeg på den måde kan styre hvor mange gange der skal skrives til filen og stadig have et opkald per linje.
            StringBuilder sb = new StringBuilder();
            bool result = false;
            sb.AppendLine("Start Time: " + DateTime.Now);
            foreach (string item in saveObj)
            {
                sb.AppendLine(item);
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(fileNamePath))
                {
                    writer.Write(sb);
                }
                result = true;
            }
            catch (Exception exp)
            {
                result = false;
            }

            return result;
        }
    }
}

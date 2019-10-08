using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Window_Price_Calculator
{
    class FilesHelper
    {
        public void Appendtexttofile(string path, string text)
        {
            if (text != null)
            {
                if (!File.Exists(path))
                {
                    string addText = text + Environment.NewLine;
                    File.WriteAllText(path, addText, encoding: Encoding.UTF8);
                }
                string appendText = text + Environment.NewLine;
                File.AppendAllText(path, appendText, encoding: Encoding.UTF8);
            }
        }
    }
}

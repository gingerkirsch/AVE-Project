using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCPU_16
{
    public static class HelpDictionary
    {
        public static Dictionary<string, string> CommandDescription;

        static HelpDictionary()
        {
            CommandDescription = new Dictionary<string, string>();

            var fs = new FileStream("Commands.txt", FileMode.Open);
            var sr = new StreamReader(fs);
            var s = sr.ReadToEnd();
            CommandDescription.Add("Commands", s);

            fs = new FileStream("SET.txt", FileMode.Open);
            sr = new StreamReader(fs);
            s = sr.ReadToEnd();
            CommandDescription.Add("SET", s);

            fs = new FileStream("ADD.txt", FileMode.Open);
            sr = new StreamReader(fs);
            s = sr.ReadToEnd();
            CommandDescription.Add("ADD", s);

            fs = new FileStream("SUB.txt", FileMode.Open);
            sr = new StreamReader(fs);
            s = sr.ReadToEnd();
            CommandDescription.Add("SUB", s);

            fs = new FileStream("MUL.txt", FileMode.Open);
            sr = new StreamReader(fs);
            s = sr.ReadToEnd();
            CommandDescription.Add("MUL", s);

            fs = new FileStream("MLI.txt", FileMode.Open);
            sr = new StreamReader(fs);
            s = sr.ReadToEnd();
            CommandDescription.Add("MLI", s);

            fs = new FileStream("DIV.txt", FileMode.Open);
            sr = new StreamReader(fs);
            s = sr.ReadToEnd();
            CommandDescription.Add("DIV", s);

            fs = new FileStream("DVI.txt", FileMode.Open);
            sr = new StreamReader(fs);
            s = sr.ReadToEnd();
            CommandDescription.Add("DVI", s);

            fs = new FileStream("MOD.txt", FileMode.Open);
            sr = new StreamReader(fs);
            s = sr.ReadToEnd();
            CommandDescription.Add("MOD", s);
        }
    }
}

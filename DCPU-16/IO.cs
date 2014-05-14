using System;
using System.IO;

namespace DCPU_16
{
    public static class IO
    {
        public static ushort[] Read(string path, int size)
        {
            try
            {
                var fs = new FileStream(path, FileMode.Open);
                var sr = new StreamReader(fs);

                var p = new ushort[size];
                var i = 0;
                while (sr.Peek() != -1)
                {
                    p[i] = ushort.Parse(sr.ReadLine());
                    i++;
                }
                return p;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static void Write(string path, string[] p)
        {
            var fs = new FileStream(path, FileMode.Create);
            var sw = new StreamWriter(fs);

            foreach (var i in p)
            {
                sw.Write(i);
                sw.Write('\n');
            }

            sw.Close();
            fs.Dispose();
        }
    }
}

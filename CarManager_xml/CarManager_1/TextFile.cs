using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager_1
{
    class TextFile
    {
        public static void FileLoad(string str, string btn)
        {
            DirectoryInfo di = new DirectoryInfo(@"./");
            if (!di.Exists)
            {
                di.Create();
            }
            using (StreamWriter writer = new StreamWriter(@"./ParkingHistroy.txt", true))
            {
                writer.WriteLine($"[{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")}] '{str}' {btn} 클릭");
            }
        }
    }
}

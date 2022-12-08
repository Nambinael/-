using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace оаоаоаоао
{
    internal static class Class1
    {
        static int i = 0;
        public static void qwe()
        {

            while (true)
            {
                Console.Clear();
                ConsoleKeyInfo key = new ConsoleKeyInfo('B', ConsoleKey.B, false, false, false);
                DriveInfo[] allDrives = DriveInfo.GetDrives();

                foreach (DriveInfo d in allDrives)
                {
                    Console.Write("   Drive {0}", d.Name);
                    if (d.IsReady == true)
                    {
                        Console.Write("   Всего:" + " " + d.TotalSize / 1073741824 + "Gb");
                        Console.WriteLine("   Доступно:" + " " + d.TotalFreeSpace / 1073741824 + "Gb");
                    }
                }

                arrows arrowe = new arrows();
                i = arrowe.mefedron(-1, 2);
                heroin(allDrives[i].Name);
            }
        }

        static void heroin(string kaif)
        {
            while (true)
            {


                string[] allFiles = Directory.GetFiles(kaif);
                string[] allPapkas = Directory.GetDirectories(kaif);
                int dlina = allPapkas.Length + allFiles.Length;
                Console.Clear();
                for (int g = 0; g < allPapkas.Length; g++)
                {
                    DirectoryInfo di1 = new DirectoryInfo(allPapkas[g]);
                    Console.WriteLine("  " + allPapkas[g]);
                    Console.SetCursorPosition(50, g);
                    Console.WriteLine( "|" + di1.CreationTime);
                }


                for (int g = 0; g < allFiles.Length; g++)
                {
                    FileInfo di2 = new FileInfo(allFiles[g]);
                    Console.WriteLine("  " + allFiles[g]);
                    Console.SetCursorPosition(50, g+allPapkas.Length);
                    Console.WriteLine("|" + di2.CreationTime);
                }

                arrows arrowe = new arrows();
                i = arrowe.mefedron(-1, dlina);
                if (i != -1)
                {
                    if (allPapkas.Length > i)

                    {
                        heroin(allPapkas[i]);
                    }
                    else
                    {
                        Process.Start(new ProcessStartInfo { FileName = allFiles[i], UseShellExecute = true });
                    }
                }
                else
                {
                    return;
                }
            }
        }
        
    }
}

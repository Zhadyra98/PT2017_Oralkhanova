﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(Console.ReadLine());
            FileSystemInfo[] fs = d.GetFileSystemInfos();
            StreamReader sr;
            int l = fs.Length;
 
            for (int i = 0; i < l - 1; i++)
            {
                if (fs[i].GetType() == typeof(FileInfo))
                {
                    sr = new StreamReader(fs[i].FullName);
                    string [] s = sr.ReadLine().Split();
                    
                   for (int j = 0; j < s.Length; j++)
                    {
                        if (s[j] == "t" && s[j + 1] == "e" && s[j + 2] == "s" && s[j + 3] == "t")
                        {
                            Console.WriteLine(fs[i].Name);
                        }

                    }
                   // sr.Close();
                }
                
                if(fs[i].GetType()==typeof(DirectoryInfo))
                {
                    string[] s = fs[i].FullName.Split();
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (s[j] == "t" && s[j + 1] == "e" && s[j + 2] == "s" && s[j + 3] == "t")
                        {
                            Console.WriteLine(fs[i].Name);
                        }

                    }

                }

            }
            Console.ReadKey();

         }
        }
    }


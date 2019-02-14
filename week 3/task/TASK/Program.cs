using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
                                            //I write 2 lab3`s tasks into one program.
        class FarManager                    // We created new class
        {
            public int cursor;      
            public bool ok;
            public int size;

            public FarManager()             
            {
                cursor = 0;
                ok = true;
            }
            public void Color(FileSystemInfo fs, int index)    // We created method that shows color
            {
                if (index == cursor)
                    Console.BackgroundColor = ConsoleColor.Red;

                else if (fs.GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            }

            public void Show(string path)  // Created method to show us files and folders
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                DirectoryInfo directory = new DirectoryInfo(path);
                directory = new DirectoryInfo(path);
                FileSystemInfo[] files = directory.GetFileSystemInfos();
                size = files.Length;
                for (int i = 0, k = 0; i < files.Length; i++)
                {
                    Color(files[i], k);
                    k++;
                    Console.WriteLine("{0}" + "." + " " + files[i].Name, k);
                }
            }
            public void Up() // cursor up - UpArrow
            {
                cursor--;
                if (cursor < 0)
                    cursor = size - 1;
            }
            public void Down() // cursor down DownArrow
            {
                cursor++;
                if (cursor == size)
                    cursor = 0;
            }
            public void Delete(FileSystemInfo fs) // Method to delete files and folders
            {
                if (fs.GetType() == typeof(DirectoryInfo))
                {
                    Directory.Delete(fs.FullName, true); // Delete folder(true means delete folder with things inside of him too)
                }
                else
                {
                    FileInfo file = new FileInfo(fs.FullName);
                    fs.Delete();
                }
            }
            public void TextFile(string path) //Reading .txt file method
            {
                Console.BackgroundColor = ConsoleColor.Black; // Change console`s backgroundcolor to black
                Console.Clear(); // Clean our console
                StreamReader sr = new StreamReader(path);//Create stream reader to read .txt file
                string s = sr.ReadToEnd();
                Console.WriteLine(s);

                ConsoleKeyInfo k = Console.ReadKey();

                if (k.Key == ConsoleKey.Backspace) // Close our .txt file and go outside of it
                {
                    sr.Close();//close stream reader
                    return;//Finish our method
                }
                else
                {
                    TextFile(path);
                }
            }

            public void Start(string path)
            {
                ConsoleKeyInfo consoleKey = Console.ReadKey(); 
                FileSystemInfo fs = null;
                while (consoleKey.Key != ConsoleKey.Escape) // You only stop working if you press Esc
                {
                    DirectoryInfo directory = new DirectoryInfo(path);
                    fs = directory.GetFileSystemInfos()[cursor];//Show file/folder where is cursor
                    Show(path);// Call our method Show
                    if (size != 0)
                    {
                        consoleKey = Console.ReadKey();

                        if (consoleKey.Key == ConsoleKey.UpArrow)
                        {
                            Up();
                        }
                        if (consoleKey.Key == ConsoleKey.DownArrow)
                        {
                            Down();
                        }
                        if (consoleKey.Key == ConsoleKey.Enter)
                        {
                            if (fs.GetType() == typeof(DirectoryInfo))
                            {
                                path = fs.FullName;
                                cursor = 0;
                            }
                            else if (fs.Name.EndsWith(".txt"))// if file end with .txt we call method TextFile();
                                TextFile(fs.FullName);
                        }
                        if (consoleKey.Key == ConsoleKey.Backspace)
                        {
                            directory = directory.Parent;
                            path = directory.FullName;
                            cursor = 0;
                        }
                        if (consoleKey.Key == ConsoleKey.D)
                        {
                            Delete(fs);// We call this method to delete file/folder
                            FileSystemInfo[] files = directory.GetFileSystemInfos();
                            size = files.Length;
                            cursor = 0;
                        }
                        if (consoleKey.Key == ConsoleKey.R)
                        {
                            string s = Console.ReadLine();
                            s = Path.Combine(directory.FullName, s);// We combine string s and directory.fullName
                            if (fs.GetType() == typeof(FileInfo))
                                File.Move(fs.FullName, s);//Use this to rename our file/folder
                            if (fs.GetType() == typeof(DirectoryInfo))
                                Directory.Move(fs.FullName, s);
                        }
                    }
                    else
                    {
                        consoleKey = Console.ReadKey();
                        if (consoleKey.Key == ConsoleKey.Backspace)
                        {
                            directory = directory.Parent;
                            path = directory.FullName;
                            cursor = 0;
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            FarManager far = new FarManager(); //Create object far
            far.Start("C:/Users/Шаихислам/source/repos/WEEK # 3/TASK");// call far`s method Start and send our path
        }
    }
}
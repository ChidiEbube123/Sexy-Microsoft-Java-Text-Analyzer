using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
namespace Text_File_Analyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            int wordcounter(string loc)
            {// better for larger
                string line;
       //         StreamWriter eelif = new StreamWriter(loc);
                StreamReader filee = new StreamReader(loc);
                line = filee.ReadLine();
          //      eelif.Close();
                int count = 0;
                while(line!= null)
                {
                    Console.WriteLine(line);
                    line = filee.ReadLine();
             //       eelif.WriteLine("Hallo");

                    if (line!=null)
                    {
                        count += line.Length;
                    }
                    else
                    {

                    }

                }
                return count;
            }
            void file_take_twoanalyzer(string loc)
            {
                string[] textLines1 = { "This is the first line",
                               "This is the second line",
                              "This is the third line" };

                File.WriteAllLines(loc, textLines1);
                File.WriteAllText(loc, "Hallo");
                Console.WriteLine(File.ReadAllText(loc));
            }
            string wordfrqcounter(string loc)
            {
                StreamReader sr = new StreamReader(loc);
                string thingy = sr.ReadLine();
                string longerthingy=thingy;
                while (thingy != null){
                    thingy = sr.ReadLine();
                    longerthingy += thingy;

                }
                string[] bonedigger = longerthingy.Split(" ");
                //openWith.Add("txt", "notepad.exe");
                Dictionary<string,int> dictionary_name = new Dictionary<string, int>();
                foreach(string i in bonedigger)
                {
                    if (dictionary_name.ContainsKey(i))
                    {
                        dictionary_name[i] += 1;
                    }
                    else
                    {
                        dictionary_name[i] = 1;
                    }

                }
                string result = "";
                foreach(KeyValuePair<string, int> e in dictionary_name)
                {

                    result+= $"{e.Key} : {e.Value}";
                }
                return result;


            }
            bool reg(string word)
            {
                Regex reggy = new Regex("[b]");//has b;
                reggy = new Regex("[^ar$]");//starts with a and ends with r
                reggy = new Regex("[^a...r$]");//four letter word that starts with a and ends with 
                return reggy.IsMatch(word);
            }
       //     Console.WriteLine(reg("amcer"));
          //  file_take_twoanalyzer("C:/Users/USER/Documents/flutterphp.txt");
       //     Console.WriteLine(wordcounter("C:/Users/USER/Documents/flutterphp.txt"));
            Console.WriteLine(wordfrqcounter("C:/Users/USER/Documents/flutterphp.txt"));
        }
    }
}
/*
 
Methods	Use
Create()	Create or overwrite a file in the specified path.
Open()	Opens a FileStream on the specified path with read / write access
WriteAllText()	Create a new file, writes the specified string to the file, and then closes the file
ReadAllText()	Opens a text file, reads all lines of the file, and then closes the file.
Copy()	Copies an existing file to a new file. Overwriting a file of the same name is not allowed.
AppendAllText()	Opens a file, appends the specified string to the file, and then closes the file. If the file does not exist, this method creates a file, writes the specified string to the file, then closes the file.
     */

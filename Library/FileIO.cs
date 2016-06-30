using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    ///
    /// Implement a while loop to read the file line by line and add each line to mediaFile
    /// Write a message to be written out when FileNotFoundException is thrown
    /// Write a message to be written when a general exception is thrown
    /// </summary>
    class FileIO : IFileInterface
    {
        public List<string> ReturnMediaFile(string path)
        {
            //initialize the list we'll be returning
            List<string> mediaFile = new List<string>();

            try
            {
                //check to see whether the file exists
                if (!File.Exists(path))
                {
                    //throw appropriate exepction
                    //implement
                    throw new Exception("File not found.");
                }

                //initialize the empty string we'll be using for each line
                string line;

                //open a StreamReader to the file specifcied in the path variable 
                //implement
                using (StreamReader reader = new StreamReader(path))
                {
                    line = reader.ReadLine();
                }
                Console.WriteLine(line);

                //while reading a new from file, add each line to mediaFile
                //as long as each new line is not null
                //implement            
                int count = 0;

                //reads the files and displays it line by line
                System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\library-teller\Library\Media.txt");
                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    count++;
                }
                //close your file
                file.Close();
                                                
            }
            catch (FileNotFoundException)
            {
                //write out appropriate message
                //implement
                Console.WriteLine("File not found.");
            }
            catch (Exception e)
            {
                //write out the message of e
                //implement
                Console.WriteLine("An unknown error occured.");            }

            return mediaFile;
        }

        //not yet implemented
        public void UpdateMediaFile(List<string> newMedia)
        {
            throw new NotImplementedException();
        }
    }
}

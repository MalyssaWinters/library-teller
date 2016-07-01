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
                    throw new FileNotFoundException();
                    //could also write
                    //throw new FileNotFoundException("File not found", path);
                }

                //initialize the empty string we'll be using for each line
                string line;

                //open a StreamReader to the file specifcied in the path variable 
                //implement
                using (StreamReader reader = new StreamReader(path))
                {
                    //while reading a new from file, add each line to mediaFile
                    //as long as each new line is not null
                    //implement  
                    line = reader.ReadLine(); //getting the FIRST line

                    //reads the files and displays it line by line
                    while (line != null)
                    {
                        mediaFile.Add(line);
                        line = reader.ReadLine(); //getting the NEXT line
                    }
                }
                //close your file
                //file.Close(); //do not need to use because "using" will close after it is used
                                                
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
                Console.WriteLine(e.Message); //will just show message
            }

            return mediaFile;
        }

        //not yet implemented
        public void UpdateMediaFile(List<string> newMedia)
        {
            throw new NotImplementedException();
        }
    }
}

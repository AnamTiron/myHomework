namespace Fundamentals2016.Part5
{
    using System;
    using System.IO;
    using System.Text;

    public class WorkWithFileExample
    {
        public string FileName { get; set; }

        public WorkWithFileExample(string fileName)
        {
            FileName = fileName;
        }

        public void ReadContent()
        {
            try
            {
                using (var fileStream = File.OpenRead(FileName))
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true))
                {
                    Console.WriteLine("\n\nFile content: \n");
                    var line = string.Empty;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                    Console.ReadKey();
                }
            }
            catch (FileNotFoundException e)
            {
                //throw new Exception(e.Message);
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }

        public void WriteContent()
        {
            // override the content:
            //StreamWriter file = new StreamWriter(FileName);

            // append data to existing content:
            StreamWriter file = new StreamWriter(FileName, true);

            try
            {
                // Compose a string that consists of three lines.
                string lines = "\nFirst line.\r\nSecond line.\r\nThird line.";

                // Write the string to a file.
                file.WriteLine(lines);
            }
            catch (Exception e)
            {
                //throw new Exception(e.Message);
                Console.WriteLine(e.Message);
                Console.ReadKey();

            }
            finally
            {
                file.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;

namespace Zippy
{
    class Program
    {
        static void Main(string[] args)
        {
            string zipPath = @"C:\\Users\\rainaldo crosbourne\\Documents\\GitHub\\Zippy\\zippy_files\\test.zip";

            string outputFile = @"C:\\Users\\rainaldo crosbourne\\Documents\\GitHub\\Zippy\\zippy_files\\t2.txt";
            //Create the zip archive
            //ZipFile.CreateFromDirectory(Path.GetDirectoryName(zipPath), zipPath);
            //Add entries to the archive
            //Close the archive
            //using (ZipArchive archive = ZipFile.OpenRead(zipPath))
            //{
                
            //}
            //Creates a new, blank zip file to work with - the file will be
            //finalized when the using statement completes
            using (ZipArchive newFile = ZipFile.Open(zipPath, ZipArchiveMode.Create))
            {
                ZipArchiveEntry readmeEntry = newFile.CreateEntry(Path.GetFileName(outputFile),CompressionLevel.Fastest);
                using (StreamWriter writer = new StreamWriter(readmeEntry.Open()))
                {
                    writer.WriteAsync("This is a test file writen and stream and added to zip file");
                }
                //using (System.IO.StreamWriter outFile = new System.IO.StreamWriter(outputFile))
                //{
                    //Output file name
                //    outFile.Write(string.Format("The test file\n"));
                //    //Iterate through Report dictionary                
               // }
                //newFile.CreateEntryFromFile(outputFile, Path.GetFileName(outputFile), CompressionLevel.Fastest);
            }
            Console.ReadKey();
        }
    }
}

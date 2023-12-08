using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Generator
{
    public class FolderGenerator
    {
        public FolderGenerator(int size = 1,string folderName = "Folder")
        {
            //GenerateRootFolder(folderName);
        }

        public void GenerateRootFolder(string folderName)
        {
            //FileReader read = new FileReader();
            //read.PrintFileContents();
            // Replace 'YourFolderName' with the desired folder name

            try
            {
                // Specify the path where you want to create the folder
                string folderPath = Path.Combine(Environment.CurrentDirectory, folderName);

                // Check if the folder doesn't exist, then create it
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                    Console.WriteLine($"Folder '{folderName}' created successfully at {folderPath}");
                }
                else
                {
                    Console.WriteLine($"Folder '{folderName}' already exists at {folderPath}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}

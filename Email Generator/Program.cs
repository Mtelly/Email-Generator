using System;
using System.IO;
using OfficeOpenXml;

class Program
{
    static void Main()
    {
        // Replace 'your_excel_file.xlsx' with the actual file path
        string excelFilePath = "test_file.xlsx";

        try
        {
            // Load the Excel package from the file
            using (var package = new ExcelPackage(new FileInfo(excelFilePath)))
            {
                // Get the first worksheet in the Excel file
                var worksheet = package.Workbook.Worksheets[0];

                // Get the number of rows and columns in the worksheet
                int rowCount = worksheet.Dimension.Rows;
                int colCount = worksheet.Dimension.Columns;

                // Print the header row
                for (int col = 1; col <= colCount; col++)
                {
                    Console.Write($"{worksheet.Cells[1, col].Text}\t");
                }
                Console.WriteLine();

                // Print the data rows
                for (int row = 2; row <= rowCount; row++)
                {
                    for (int col = 1; col <= colCount; col++)
                    {
                        Console.Write($"{worksheet.Cells[row, col].Text}\t");
                    }
                    Console.WriteLine();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}

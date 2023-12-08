using System;
using System.IO;
using Email_Generator;
using OfficeOpenXml;

class Program
{
    static void Main()
    {
        FileReader read = new FileReader();
        read.PrintFileContents();
    }
}

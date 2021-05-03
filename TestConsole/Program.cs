using System;
using 

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\Study\TestList.xlsx";

            var tt = ExeleParser.GetDataFromExcel(filePath);
        }
    }
}

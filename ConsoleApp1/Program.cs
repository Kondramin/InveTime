using System;
using System.Data;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\Study\TestList.xlsx";

            var dt = ExeleParser.GetDataFromExcel(filePath);

            //foreach (var item in dt)
            //{
            //    Console.WriteLine(item);
            //}

            // перебор всех столбцов
            //foreach(var row in dt.Rows)
            //{
            //    Console.WriteLine(row);
            //}

            foreach (DataColumn column in dt.Columns)
            {
                Console.Write("\t{0}", column.ColumnName);
                Console.WriteLine();
                // перебор всех строк таблицы
                foreach (DataRow row in dt.Rows)
                {
                    //получаем все ячейки строки
                    var cells = row.ItemArray;
                    foreach (object cell in cells)
                        Console.Write("\t{0}", cell);
                    Console.WriteLine();
                }


                //}
            }
        }
    }
}

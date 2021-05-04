using System;
using System.Data;

namespace TestConsele
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Study\TestList.xlsx";
            DataTable dt = ExeleParser.GetDataFromExcel(path);



            foreach (DataColumn column in dt.Columns)
                Console.Write("\t{0}", column.ColumnName);
            Console.WriteLine();
            // перебор всех строк таблицы
            foreach (DataRow row in dt.Rows)
            {
                // получаем все ячейки строки
                var cells = row.ItemArray;
                foreach (object cell in cells)
                    Console.Write("\t{0}", cell);
                Console.WriteLine();
            }

        }
    }
}

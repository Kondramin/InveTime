using ClosedXML.Excel;
using System.Data;

namespace InveTime.Services
{
    static class ExeleParser
    {
        //ClosedXML
        public static string[,] ImportExceltoDatatable(string filePath)
        {
                                                                        
            using (var workBook = new XLWorkbook(filePath))
            {
                                                                        
                var workSheet = workBook.Worksheet(1);




                var maxRowValue = workSheet.RowCount();
                var maxColumnValue = workSheet.ColumnCount();

               
                string[,] dataFromExcele = new string[maxRowValue, maxColumnValue];

                
                for (int i = 1; i <= maxColumnValue; i++)
                {
                    for(int j = 1; j <= maxRowValue; j++)
                    {
                        dataFromExcele[i, j] = workSheet.Cell(i, j).ToString();
                    }
                }



                return dataFromExcele;
                
            }
        }
    }
}

using ClosedXML.Excel;
using System;
using System.Data;

namespace TestConsele
{
    public class ExeleParser
    {
        public static DataTable GetDataFromExcel(string path)
        {

            var dt = new DataTable();


            using (var workBook = new XLWorkbook(path))
            {
                var workSheet = workBook.Worksheet(1);

                bool firstRow = true;
                foreach (var row in workSheet.Rows())
                {
                    if (firstRow)
                    {
                        foreach (var cell in row.Cells())
                        {
                            if (!string.IsNullOrEmpty(cell.Value.ToString()))
                            {
                                dt.Columns.Add(cell.Value.ToString());
                            }
                            else
                            {
                                break;
                            }
                        }
                        firstRow = false;
                    }
                    else
                    {
                        int i = 0;
                        var toInsert = dt.NewRow();
                        foreach (var cell in row.Cells(1, dt.Columns.Count))
                        {
                            try
                            {
                                toInsert[i] = cell.Value.ToString();
                            }
                            catch (Exception ex)
                            {

                            }
                            i++;
                        }
                        dt.Rows.Add(toInsert);
                    }
                }
                return dt;
            }
        }
    }
}

using ClosedXML.Excel;
using System;
using System.Data;

namespace InveTime.Services
{
    class ExeleParser
    {
        public static DataTable GetDataFromExcel(string path)
        {
            //Save the uploaded Excel file.


            var dt = new DataTable();
            //Open the Excel file using ClosedXML.
            using (var workBook = new XLWorkbook(path))
            {
                //Read the first Sheet from Excel file.
                var workSheet = workBook.Worksheet(1);


                var ff = workSheet.ColumnsUsed();
                var jl = ff.CellsUsed();
                //foreach(var row in workSheet.)
                //{

                //}

                //Loop through the Worksheet rows.
                bool firstRow = true;
                foreach (IXLRow row in workSheet.Rows())
                {
                    //Use the first row to add columns to DataTable.
                    if (firstRow)
                    {
                        foreach (IXLCell cell in row.Cells())
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
                        DataRow toInsert = dt.NewRow();
                        foreach (IXLCell cell in row.Cells(1, dt.Columns.Count))
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


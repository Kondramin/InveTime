using ClosedXML.Excel;
using InveTime.DataBase.DLL.Entityes;
using InveTime.Interfaces;
using InveTime.Services.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace InveTime.Services
{
    public class ParserService : IParserService
    {
        private readonly IRepository<Product> _ProductRepository;
        private readonly IRepository<Category> _TypeProductRepository;

        public ParserService(IRepository<Product> ProductRepository, IRepository<Category> TypeProductRepository)
        {
            _ProductRepository = ProductRepository;
            _TypeProductRepository = TypeProductRepository;
        }
        
        public ParserService(){ }
        
        
        
        public DataTable GetDataFromExcel(string path)
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

        public async Task<DataTable> GetDataFromExcelAsync(string path)
        {
            var dt = await Task.Run(() => GetDataFromExcel(path));
            return dt;
        }
        
        
        
        public void SaveDataInDataBase(DataTable data)
        {
            
            foreach (DataRow row in data.Rows)
            {
                
                var cells = row.ItemArray;
                var product = new Product()
                {
                    Barcode = cells[0].ToString(),
                    VendorCode = cells[1].ToString(),
                    Name = cells[2].ToString(),
                    AmountData = Convert.ToInt32(cells[3])
                };
                
                _ProductRepository.Add(product);

            }
            
        }

        public async Task SaveDataInDataBaseAsync(DataTable data)
        {

            foreach (DataRow row in data.Rows)
            {

                var cells = row.ItemArray;
                var product = new Product()
                {
                    Barcode = cells[0].ToString(),
                    VendorCode = cells[1].ToString(),
                    Name = cells[2].ToString(),
                    AmountData = Convert.ToInt32(cells[3])
                };

                await _ProductRepository.AddAsync(product);

            }
        }



        public void IdentifyTypeProduct()
        {
            var typeProducts = new List<Category>(_TypeProductRepository.Items);
        }
    }
}


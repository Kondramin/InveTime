using ClosedXML.Excel;
using InveTime.DataBase.DLL.Entityes;
using InveTime.Interfaces;
using InveTime.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace InveTime.Services
{
    public class ParserService : IParserService
    {
        private readonly IRepository<Product> _ProductRepository;
        private readonly IRepository<CategorySearching> _CategorySearchingRepository;

        public ParserService(IRepository<Product> ProductRepository,
            IRepository<CategorySearching> CategorySearchingRepository)
        {
            _ProductRepository = ProductRepository;
            _CategorySearchingRepository = CategorySearchingRepository;
        }
        



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



        public void IdentifyCategory()
        {

            var prodNullCategory = _ProductRepository.Items.Where(p => EF.Functions.Like(p.Category.Name, null));
            var categorySearch = _CategorySearchingRepository.Items;
            foreach(var cat in categorySearch)
            {
                string SQLcat = $"%{cat.Name}%";
                var selectedProdNullCategory = prodNullCategory.Where(p => EF.Functions.Like(p.Name, SQLcat));
                foreach(var product in selectedProdNullCategory)
                {
                    product.Category = cat.Category;
                    _ProductRepository.Update(product);
                }
            }
        }

        public async Task IdentifyCategoryAsync()
        {
            var prodNullCategory = _ProductRepository.Items.Where(p => EF.Functions.Like(p.Category.Name, null));
            var categorySearch = _CategorySearchingRepository.Items;
            foreach (var cat in categorySearch)
            {
                string SQLcat = $"%{cat.Name}%";
                var selectedProdNullCategory = prodNullCategory.Where(p => EF.Functions.Like(p.Name, SQLcat));
                foreach (var product in selectedProdNullCategory)
                {
                    product.Category = cat.Category;
                    await _ProductRepository.UpdateAsync(product);
                }
            }
        }
    }
}


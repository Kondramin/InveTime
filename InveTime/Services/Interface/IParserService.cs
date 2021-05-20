using System.Data;
using System.Threading.Tasks;

namespace InveTime.Services.Interface
{
    public interface IParserService
    {
        DataTable GetDataFromExcel(string path);
        Task<DataTable> GetDataFromExcelAsync(string path);
        void IdentifyCategory();
        Task IdentifyCategoryAsync();
        void SaveDataInDataBase(DataTable data);
        Task SaveDataInDataBaseAsync(DataTable data);
    }
}

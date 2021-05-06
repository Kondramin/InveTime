using System.Data;
using System.Threading.Tasks;

namespace InveTime.Services.Interface
{
    public interface IParserService
    {
        DataTable GetDataFromExcel(string path);
        Task<DataTable> GetDataFromExcelAsync(string path);
        void SaveDataInDataBase(DataTable data);
    }
}

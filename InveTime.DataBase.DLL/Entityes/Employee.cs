using InveTime.DataBase.DLL.Entityes.Base;

namespace InveTime.DataBase.DLL.Entityes
{
    public class Employee : Person
    {
        public string Login { get; set; }
        public string Password { get; set; }



        public int? PositionId { get; set; }
        public Position Position { get; set; }
    }
}

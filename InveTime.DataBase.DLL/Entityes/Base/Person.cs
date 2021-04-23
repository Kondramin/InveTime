namespace InveTime.DataBase.DLL.Entityes.Base
{
    public abstract class Person : NamedEntity
    {
        public string SecondName { get; set; }
        public string Patronymic { get; set; }
    }
}

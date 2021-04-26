using InveTime.Interfaces;

namespace InveTime.DataBase.DLL.Entityes.Base
{
    public abstract class Entity : IEntity
    {
        public int Id { get; set; }
    }
}

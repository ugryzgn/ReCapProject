using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
    public class OperationClaim : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }

    }
}

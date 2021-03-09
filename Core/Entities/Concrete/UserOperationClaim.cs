using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
    public class UserOperationClaim : IEntity
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int OperationClaimID { get; set; }

    }
}

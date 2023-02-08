namespace CustomerManagementSystem.Models
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }

    public abstract class EntityBase
    {
        public bool IsNew { get; private set; }
        
        public bool HasChanges { get; set; }

        public bool IsValid
        {
            get { return true; }
        }
  
        public EntityStateOption EntityState { get; set; }

    }
}

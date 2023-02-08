﻿namespace CustomerManagementSystem.Models
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }

    public abstract class EntityBase
    {
        public EntityStateOption EntityState { get; set; }
        public bool IsNew { get; private set; }
        
        public bool HasChanges { get; set; }

        public bool IsValid
        {
            get { return Validate(); }
        }
  
        public virtual bool Validate()
        {
            return true;
        }

    }
}

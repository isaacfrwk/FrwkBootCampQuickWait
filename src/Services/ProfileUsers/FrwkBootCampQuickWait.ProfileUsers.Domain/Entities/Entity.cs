﻿namespace FrwkBootCampQuickWait.ProfileUsers.Domain.Entities
{
    public class Entity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Entity()
        {
            Id = Guid.NewGuid();
            CreatedAt = new DateTime();
        }
    }
}

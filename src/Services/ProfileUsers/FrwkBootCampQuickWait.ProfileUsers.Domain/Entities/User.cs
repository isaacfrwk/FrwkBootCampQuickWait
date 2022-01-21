﻿namespace FrwkBootCampQuickWait.ProfileUsers.Domain.Entities
{
    public class User : Entity
    {
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Password { get; set; }

        public Address Address { get; set; }
    }
}

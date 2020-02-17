using System;

namespace E_comerce.Entity
{
    public class Users
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Userid { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Roles { get; set; }
        public string Token { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class User
    {
        public int Id { get; set; } // PK
        public int Role_Id { get; set; }
        public string First_Name { get; set; } = string.Empty;
        public string Last_Name { get; set; } = string.Empty;
        public string Email { get; set; }= "abc@gmail.com";
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime TokenCreated { get; set; }
        public DateTime TokenExpired { get; set; }
        public DateTime Date_Of_Birth { get; set; }
        public string Company_Name { get; set; }= string.Empty;
        public string Country { get; set; }= "VietNam";
        public string Address_1 { get; set; }= string.Empty;
        public string Address_2 { get; set; }= string.Empty;
        public string Town_City { get; set; }= string.Empty;
        public int ZipPost_Code { get; set; } = 74000;
        public string Phone_Number { get; set; } = "0123456789";
        public DateTime Created_Date { get; set; }
        public DateTime Updated_Date { get; set; }
        public virtual Cart? Cart { get; set; }
        // public int Cart_Id { get; set; }
        public virtual List<Order>? Orders { get; set; }
    }
}
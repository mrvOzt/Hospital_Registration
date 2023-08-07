using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Semafor_Hospital_Registrastion_System.Models
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        [Key]
        public string id_number { get; set; }

        //public User(string username, string password, string role, string id_number)
        //{
        //    this.username = username;
        //    this.password = password;
        //    this.role = role;
        //    this.id_number = id_number;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    internal class User
    {
        public int  UserID { get; set; }
        public int UserSurname { get; set; }
        public int UserName { get; set; }
        public int UserPatronymic { get; set; }
        public int UserLogin { get; set; }
        public int UserPassword { get; set; }
        public int RoleId { get; set; }

    }
}

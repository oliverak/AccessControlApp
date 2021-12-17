using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppUser
    {
        public AppUser()
        {
            UserName ="";
        }
        public int Id { get; set; }//konvencija zbog code first
        public string UserName { get; set; }
    }
}
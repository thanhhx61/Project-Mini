using AminLogin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AminLogin.Models.Product
{
    public class ListUser
    {
        public Pagination Pagination { get; set; }
        public List<AppIdentityUser> appIdentityUser { get; set; }
    }
}

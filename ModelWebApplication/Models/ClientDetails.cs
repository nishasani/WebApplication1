using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ClientDetails
    {
        public int Clientid { get; set; }
        public String ClientName { get; set; }
        public bool Gender { get; set; }
        public String Address { get; set; }
        public int mobilenumber { get; set; }
    }
}
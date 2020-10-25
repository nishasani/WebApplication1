using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;
namespace ModelWebApplication.Logic
{
    public class ClientLogic
    {
        ClientDetails objclient = new ClientDetails();

        public List<ClientDetails> get_StudentDetails()
        {
            var ClientDetails = new List<ClientDetails> { 
            new ClientDetails(){Clientid=1001,ClientName="John",Address="ABCD",mobilenumber=123456,Gender=true},
            new ClientDetails(){ Clientid=1002,ClientName="Stev",Address="XYZ",mobilenumber=56987,Gender=false}
            };
            return ClientDetails;
        }
    }
}

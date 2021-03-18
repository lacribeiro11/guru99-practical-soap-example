using System;
using System.Web;
using System.Web.Services;

namespace server
{
    [WebService(Name ="Calculator")]
    public class service : System.Web.Services.WebService
    {
        [WebMethod]
        public int add(int a, int b)
        {
            return a + b; 
        }
        [WebMethod]
        public int sub(int a, int b)
        {
            return a - b;
        }
        [WebMethod]
        public int mul(int a, int b)
        {
            return a * b;
        }
        [WebMethod]
        public int div(int a, int b)
        {
            return b == 0 ? 0 : a / b;
        }
    }
}

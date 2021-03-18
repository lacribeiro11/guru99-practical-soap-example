using System;
using System.Web;
using System.Web.Services;

namespace guru99practicalsoapexample
{
    [WebService(Name ="My Webservice")]
    public class webservice : System.Web.Services.WebService
    {
        [WebMethod]
        public string home()
        {
            return "My Service";
        }

    }
}

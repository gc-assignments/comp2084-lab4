using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace comp2084_lesson11
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            
        }

        //protected void Application_Error(object sender, EventArgs e)
        //{
        //    // an error hsa occured on the page
        //    var serverError = Server.GetLastError() as HttpException;

        //    if (null != serverError)
        //    {
        //        int errorCode = serverError.GetHttpCode();

        //        if (errorCode == 404)
        //        {
        //            Server.ClearError();
        //            Server.Transfer("/404.aspx");
        //        }
        //    }
        //}
    }
}
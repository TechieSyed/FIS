using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

using System.IO;
namespace Demo02_StateManagement
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["val1"] = "This is test";
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            Session["Key1"] = "No value specified by user";
        }
        protected void Application_Error(object sender, EventArgs e)
        {
            var path = Server.MapPath("~/Logs/Errors.txt");
            using (var fs = new FileStream(path, FileMode.Append, FileAccess.Write))
            using (var sw = new StreamWriter(fs))
            {
               
                Exception ex = Server.GetLastError();
               
                sw.WriteLine("DATE TIME OF ERROR : " + DateTime.Now);
                sw.WriteLine(ex.Message);
                sw.WriteLine(ex.StackTrace);
                sw.WriteLine("-------------------------------------------------------------------");
                sw.WriteLine();
                sw.Close();
                fs.Close();

               
            }
        }
    }
}
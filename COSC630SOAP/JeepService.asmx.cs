using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using Newtonsoft.Json;

namespace COSC630SOAP
{
    /// <summary>
    /// Summary description for JeepService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class JeepService : System.Web.Services.WebService
    {
        DataTable jeepServices = new DataTable();
        
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int Sum(int a, int b)
        {
            return a+b;
        }

        [WebMethod]
        public string JeepServices()
        {
            jeepServices.Columns.Add("Service");
            jeepServices.Columns.Add("Area");
            jeepServices.Rows.Add("Lift Kits", "Exterior Mods");
            jeepServices.Rows.Add("Bumpers and Winches", "Exterior Mods");
            jeepServices.Rows.Add("Rock Rails", "Exterior Mods");
            jeepServices.Rows.Add("Skid Plates and Armor", "Exterior Mods");
            jeepServices.Rows.Add("CB Radios", "Interior Mods");
            jeepServices.Rows.Add("Security and Storage", "Interior Mods");
            jeepServices.Rows.Add("Seat Covers", "Interior Mods");

            return JsonConvert.SerializeObject(jeepServices);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using Newtonsoft.Json;

namespace LeafLetAndWebService
{
    /// <summary>
    /// Summary description for wsMarker
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsMarker : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void Marker()
        {


            Marker marker = new Marker
            {
                type = "Feature",
                properties = new properties() { Name = "The Salvation Army Peacehaven Nursing Home", Status = "Operational", IconUrl = "/img/Hospital.png" },
                geometry = new geometry() { type = "Point", coordinates = new List<string> { "103.7828", "1.2951" } }
            };


            HttpContext.Current.Response.Write(JsonConvert.SerializeObject(marker, Formatting.Indented));
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void Markers()
        {
            List<Marker> markerts = new List<Marker>();

            Marker marker1 = new Marker
            {
                type = "Feature",
                properties = new properties() { Name = "The Salvation Army Peacehaven Nursing Home", Status = "Operational", IconUrl = "/img/Hospital.png" },
                geometry = new geometry() { type = "Point", coordinates = new List<string> { "103.7828", "1.2951" } }
            };
            Marker marker2 = new Marker
            {
                type = "Feature",
                properties = new properties() { Name = "The Salvation Army Peacehaven Nursing Home", Status = "Operational", IconUrl = "/img/Hospital.png" },
                geometry = new geometry() { type = "Point", coordinates = new List<string> { "103.9616977", "1.3538414" } }
            };

            markerts.Add(marker1);
            markerts.Add(marker2);


            HttpContext.Current.Response.Write(JsonConvert.SerializeObject(markerts, Formatting.Indented));
        }

    }

    public class Marker
    {
        public string type { get; set; }
        public properties properties { get; set; }
        public geometry geometry { get; set; }

    }

    public class properties
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public string IconUrl { get; set; }

    }

    public class geometry
    {
        public string type { get; set; }
        //public coordinate LatLng { get; set; }
        public List<string> coordinates { get; set; }
    }
    public class coordinate
    {
        public string lat { get; set; }
        public string lng { get; set; }
    }
}

using Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace BeerQuest.Helper
{
    public static class GoogleGeoCoding
    {
        public static double[] GetLatLong(Business business)
        {
            GoogleMap myMap = new GoogleMap();
            string url = "https://maps.googleapis.com/maps/api/geocode/json?address=" + business.Address + ",+" + business.City + ",+" + business.State + "&key=" + APIKey.SecretKey;
            WebRequest requestObject = WebRequest.Create(url);
            requestObject.Method = "GET";
            HttpWebResponse responseObject = null;
            responseObject = (HttpWebResponse)requestObject.GetResponse();
            string urlResult = null;
            using (Stream stream = responseObject.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                urlResult = sr.ReadToEnd();
                sr.Close();
            }

            double lat;
            double longitutde;

            myMap = JsonConvert.DeserializeObject<GoogleMap>(urlResult);
            try
            {
                lat = myMap.results[0].geometry.location.lat;
                longitutde = myMap.results[0].geometry.location.lng;
            }
            catch
            {
                return null;
            }
            double[] coords = new double[2];
            coords[0] = lat;
            coords[1] = longitutde;
            return coords;

        }
    }

    public class GoogleMap
    {
        public Result[] results { get; set; }
        public string status { get; set; }
    }

    public class Result
    {
        public Geometry geometry { get; set; }
    }

    public class Geometry
    {
        public Location location { get; set; }
        public string location_type { get; set; }
    }

    public class Location
    {
        public double lat { get; set; }
        public double lng { get; set; }
    }

}



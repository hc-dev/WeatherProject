using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebApplication6.Models;
namespace WebApplication6.Controllers
{
    public class MyWeatherController : Controller
    {
        // GET: MyWeather
        public ActionResult Index()
        {
            return View();            
        }

        [HttpPost]
        public ActionResult GetWeather(FormCollection values)
        { 
                using (var client = new WebClient())
            {
            //User Input
               var uCity = values["UserCity"];
               var uState = values["UserState"];
            //Pass user entered city and state into zip code api
                /*  var ZipApi = "http://api.zippopotam.us/us/" + uState + "/" + uCity;
                string ZipList = clientA.DownloadString(ZipApi);
                JObject ZipCodes = JObject.Parse(ZipList);
                //Get first zip code listed for entered city and state
                string MyZip = (string)ZipCodes["place"][0]["post code"];
                //Build the url for open weather api using retrieved zip code
                 public string WeatherApiUri = "http://api.openweathermap.org/data/2.5/weather?zip=" + MyZip + ",us&APPID=170945a535e2a0e23bd4fc35c9f9123a";*/
                string json = client.DownloadString("http://api.openweathermap.org/data/2.5/weather?zip=33510,us&APPID=170945a535e2a0e23bd4fc35c9f9123a");
                JObject WeatherReport = JObject.Parse(json);
                SuperData superData = new SuperData
                {
                    temp = (string)WeatherReport["main"]["temp"],
                    humidity = (string)WeatherReport["main"]["humidity"],
                    //Find a way to get the chance of rain from the data provided in the current weather data provided
                    //rainprob = 

                    sunset = (string)WeatherReport["sys"]["sunset"]
                };
                //Return Results using a partial view
                //return PartialView()


    }
            
        }
    }

}

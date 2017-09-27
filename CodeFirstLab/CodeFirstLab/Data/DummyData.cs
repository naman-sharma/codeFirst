using CodeFirstDev.Models.Juristiction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstLab.Data
{
    public class DummyData
    {
        public static System.Collections.Generic.List<Province> getProvinces(Models.ApplicationDbContext context)
        {
            List<Province> Provinces = new List<Province>{
                new Province()
                {
                    ProvinceName = "British Columbia",
                },
                new Province()
                {
                    ProvinceName = "Alberta"
                },
                new Province()
                {
                    ProvinceName = "Saskatchwen"
                },
        };
            return Provinces;
        }

        public static System.Collections.Generic.List<City> getCities(Models.ApplicationDbContext context)
        {
            List<City> Cities = new List<City>{
                new City()
                {
                    CityName = "Surrey",
                    Population = 2000,
                },
                new City()
                {
                    CityName = "Richmond",
                    Population = 1000,
                    //ProvinceName = context.Provinces.Find("British Columbia").ProvinceName,
                },
                new City()
                {
                    CityName = "Port Moody",
                    Population = 500,
                    //ProvinceName = context.Provinces.Find("British Columbia").ProvinceName,
                },
                new City()
                {
                    CityName = "Surrey",
                    Population = 2000,
                    //ProvinceName = context.Provinces.Find("British Columbia").ProvinceName,
                },
                new City()
                {
                    CityName = "Edmonton",
                    Population = 5000,
                    //ProvinceName = context.Provinces.Find("Alberta").ProvinceName,
                },
                new City()
                {
                    CityName = "Calgary",
                    Population = 500,
                    //ProvinceName = context.Provinces.Find("Alberta").ProvinceName,
                },
                new City()
                {
                    CityName = "LethBridge",
                    Population = 2000,
                    //ProvinceName = context.Provinces.Find("Alberta").ProvinceName,
                },
                new City()
                {
                    CityName = "Saskatoon",
                    Population = 2000,
                    //ProvinceName = context.Provinces.Find("Saskatchwen").ProvinceName,
                },
                new City()
                {
                    CityName = "Prarie",
                    Population = 8,
                    //ProvinceName = context.Provinces.Find("Saskatchwen").ProvinceName,
                },
                new City()
                {
                    CityName = "Wheat",
                    Population = 4,
                    //ProvinceName = context.Provinces.Find("Saskatchwen").ProvinceName,
                },
        };
            return Cities;
        }
    }
}
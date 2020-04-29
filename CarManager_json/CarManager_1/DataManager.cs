using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager_1
{
    class DataManager
    {
        public static List<Car> Cars = new List<Car>();

        static DataManager()
        {
            Load();
        }

        public static void Load()
        {
            string jsonFile = "./Cars.json";
            FileInfo fileInfo = new FileInfo(jsonFile);
            if (fileInfo.Exists)
            {
                string stCarValueJson = File.ReadAllText(@jsonFile);
                JObject jsonObjectCar = JObject.Parse(stCarValueJson);
                Cars = (from item in jsonObjectCar["cars"]["car"]
                        select new Car()
                        {
                            ParkingSpot = int.Parse(item["parkingSpot"].ToString()),
                            CarNumber = item["carNumber"].ToString(),
                            DriverName = item["driverName"].ToString(),
                            PhoneNumber = item["phoneNumber"].ToString(),
                            ParkingTime = DateTime.Parse(item["parkingTime"].ToString())
                        }).ToList<Car>();
            }
            else
            {
                var jCarArray = new JArray();
                for (int i = 1; i < 6; i++)
                {
                    var jCarObject = new JObject();
                    jCarObject.Add("parkingSpot", i);
                    jCarObject.Add("carNumber", "");
                    jCarObject.Add("driverName", "");
                    jCarObject.Add("phoneNumber", "");
                    jCarObject.Add("parkingTime", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                    jCarArray.Add(jCarObject);
                }

                var jCarArrayObject = new JObject();
                jCarArrayObject.Add("car", jCarArray);

                var jCarsObject = new JObject();
                jCarsObject.Add("cars", jCarArrayObject);

                File.WriteAllText(@"./Cars.json", jCarsObject.ToString());
            }
        }

        public static void Save()
        {
            var jCarArray = new JArray();
            foreach(var item in Cars)
            {
                var jCarObject = new JObject();
                jCarObject.Add("parkingSpot", item.ParkingSpot);
                jCarObject.Add("carNumber", item.CarNumber);
                jCarObject.Add("driverName", item.DriverName);
                jCarObject.Add("phoneNumber", item.PhoneNumber);
                jCarObject.Add("parkingTime", item.ParkingTime.ToLongDateString());
                jCarArray.Add(jCarObject);
            }

            var jCarArrayObject = new JObject();
            jCarArrayObject.Add("car", jCarArray);

            var jCarsObject = new JObject();
            jCarsObject.Add("cars", jCarArrayObject);

            File.WriteAllText(@"./Cars.json", jCarsObject.ToString());
        }
    }
}

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            try
            {
                string xmlFile = "./Cars.xml";
                FileInfo fileInfo = new FileInfo(xmlFile);
                if (fileInfo.Exists)
                {
                    string carsOutput = File.ReadAllText(@xmlFile);
                    XElement carsXElement = XElement.Parse(carsOutput);
                    Cars = (from item in carsXElement.Descendants("car")
                            select new Car()
                            {
                                ParkingSpot = int.Parse(item.Element("parkingSpot").Value),
                                CarNumber = item.Element("carNumber").Value,
                                DriverName = item.Element("driverName").Value,
                                PhoneNumber = item.Element("phoneNumber").Value,
                                ParkingTime = DateTime.Parse(item.Element("parkingTime").Value)
                            }).ToList<Car>();
                }
                else
                {
                    string carsOutPut = "";
                    carsOutPut += "<cars>\n";
                    foreach (var item in Cars)
                    {
                        for (int i = 1; i < 6; i++)
                        {
                            carsOutPut += "<car>\n";
                            carsOutPut += "<parkingSpot>" + i + "</parkingSpot>\n";
                            carsOutPut += "<carNumber>\"\"</carNumber>\n";
                            carsOutPut += "<driverName>\"\"</driverName>\n";
                            carsOutPut += "<phoneNumber>\"\"</phoneNumber>\n";
                            carsOutPut += "<parkingTime>" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "</parkingTime>\n";
                            carsOutPut += "</car>\n";
                        }
                    }
                    carsOutPut += "</cars>";

                    File.WriteAllText(@xmlFile, carsOutPut);
                }
            }
            catch (FileLoadException)
            {
                Save();
            }
        }

        public static void Save()
        {
            string carsOutPut = "";
            carsOutPut += "<cars>\n";
            foreach(var item in Cars)
            {
                carsOutPut += "<car>\n";
                carsOutPut += "<parkingSpot>" + item.ParkingSpot + "</parkingSpot>\n";
                carsOutPut += "<carNumber>" + item.CarNumber + "</carNumber>\n";
                carsOutPut += "<driverName>" + item.DriverName + "</driverName>\n";
                carsOutPut += "<phoneNumber>" + item.PhoneNumber + "</phoneNumber>\n";
                carsOutPut += "<parkingTime>" + item.ParkingTime + "</parkingTime>\n";
                carsOutPut += "</car>\n";
            }
            carsOutPut += "</cars>";

            File.WriteAllText(@"./Cars.xml", carsOutPut);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager_1
{
    class DB
    {
        public static List<Car> Cars = new List<Car>();
        public static SqlConnection conn = new SqlConnection();

        public static void ConnectDB()
        {
            conn.ConnectionString = string.Format("Data Source=({0});" +
                "Initial Catalog = {1};" +
                "Integrated Security = {2};" +
                "Timeout = 3",
                "local", "MYDB1", "SSPI");
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open(); //Open하면 DB연결
        }

        public static void SelectDB()
        {
            ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DB.conn;
            cmd.CommandText = "select * from Car_Manager";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Car_Manager");

            //db값을 list에 넣는 방법
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                Car car = new Car();
                car.ParkingSpot = int.Parse(item["Parking_Spot"].ToString());
                car.CarNumber = item["Car_Number"].ToString();
                car.DriverName = item["Driver_Name"].ToString();
                car.PhoneNumber = item["Phone_Number"].ToString();
                car.ParkingTime = DateTime.Parse(item["parking_Time"].ToString());
                Cars.Add(car);
            }
        }
    }
}

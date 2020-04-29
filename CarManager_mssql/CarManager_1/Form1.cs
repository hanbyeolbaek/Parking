using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager_1
{
    public partial class Form1 : Form
    {
        string contents = "";

        public Form1()
        {
            InitializeComponent();

            Text = "주차 관리";

            DB.SelectDB();

            dataGridView_CarManager.DataSource = DB.Cars;
            DB.conn.Close();
            dataGridView_CarManager.CurrentCellChanged += DataGridView_CarManager_CurrentCellChanged;
        }

        private void DataGridView_CarManager_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                var carData = dataGridView_CarManager.CurrentRow;
                textBox_ParkingSpot.Text = dataGridView_CarManager.CurrentRow.Cells[0].Value.ToString();
                textBox_CarNum.Text = dataGridView_CarManager.CurrentRow.Cells[1].Value.ToString();
                textBox_DriverName.Text = dataGridView_CarManager.CurrentRow.Cells[2].Value.ToString();
                textBox_PhoneNum.Text = dataGridView_CarManager.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception)
            {
                
            }
        }

        private void Query_Insert()
        {
            try
            {
                DB.ConnectDB();
                string sqlcommand = "Update Car_Manager Set Car_Number = @p1, Driver_Name = @p2, Phone_Number = @p3, Parking_Time = @p4 Where Parking_Spot = @p5";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = DB.conn;
                cmd.CommandType = CommandType.Text;
                //Column 명은 별도의 파라메터 형태를 선언함
                //SQL Injection을 방지
                cmd.Parameters.AddWithValue("@p1", textBox_CarNum.Text);
                cmd.Parameters.AddWithValue("@p2", textBox_DriverName.Text);
                cmd.Parameters.AddWithValue("@p3", textBox_PhoneNum.Text);
                cmd.Parameters.AddWithValue("@p4", DateTime.Now);
                cmd.Parameters.AddWithValue("@p5", textBox_ParkingSpot.Text);
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();
                DB.conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + Environment.NewLine + e.StackTrace);
            }
        }

        private void button_InCar_Click(object sender, EventArgs e)
        {
            try
            {
                Car car = DB.Cars.Single((x) => x.ParkingSpot.ToString() == textBox_ParkingSpot.Text);
                if (car.CarNumber != "")
                {
                    MessageBox.Show("이미 다른 차량이 주차되어있습니다.");

                    TextFile.FileLoad("주차된 차량 공간", "주차");

                    contents = $"[{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")}] '주차된 차량 공간' 주차 클릭";
                    listBox1.Items.Insert(0, contents);
                }
                else if (textBox_CarNum.Text.Trim() == "")
                {
                    MessageBox.Show("차량번호를 입력해주세요.");

                    TextFile.FileLoad("차량번호 미입력", "주차");

                    contents = $"[{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")}] '차량 번호 미입력' 주차 클릭";
                    listBox1.Items.Insert(0, contents);
                }
                else if (textBox_DriverName.Text.Trim() == "")
                {
                    MessageBox.Show("차주이름를 입력해주세요.");

                    TextFile.FileLoad("차주이름 미입력", "주차");

                    contents = $"[{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")}] '차주 이름 미입력' 주차 클릭";
                    listBox1.Items.Insert(0, contents);
                }
                else if (textBox_PhoneNum.Text.Trim() == "")
                {
                    MessageBox.Show("전화번호를 입력해주세요.");

                    TextFile.FileLoad("전화번호 미입력", "주차");

                    contents = $"[{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")}] '전화번호 미입력' 주차 클릭";
                    listBox1.Items.Insert(0, contents);
                }
                else
                {
                    car.CarNumber = textBox_CarNum.Text;
                    car.DriverName = textBox_DriverName.Text;
                    car.PhoneNumber = textBox_PhoneNum.Text;
                    car.ParkingTime = DateTime.Now;

                    dataGridView_CarManager.DataSource = null;
                    dataGridView_CarManager.DataSource = DB.Cars;
                    Query_Insert();

                    MessageBox.Show(car.CarNumber + " 차량이 주차되어있습니다.");

                    TextFile.FileLoad($"{car.CarNumber}", "주차");

                    contents = $"[{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")}] {car.CarNumber} 주차";
                    listBox1.Items.Insert(0, contents);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("존재하지 않는 공간입니다.");

                TextFile.FileLoad("존재하지 않는 공간", "주차");

                contents = $"[{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")}] '존재하지 않는 공간' 주차 클릭";
                listBox1.Items.Insert(0, contents);
            }
        }

        private void Query_Delete()
        {
            DB.ConnectDB();
            string sqlcommand = "Update Car_Manager Set Car_Number = @p1, Driver_Name = @p2, Phone_Number = @p3, Parking_Time = @p4 Where Parking_Spot = @p5";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DB.conn;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p1", "");
            cmd.Parameters.AddWithValue("@p2", "");
            cmd.Parameters.AddWithValue("@p3", "");
            cmd.Parameters.AddWithValue("@p4", DateTime.Now);
            cmd.Parameters.AddWithValue("@p5", textBox_ParkingSpot.Text);
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery();
            DB.conn.Close();
        }

        private void button_OutCar_Click(object sender, EventArgs e)
        {
            try
            {
                Car car = DB.Cars.Single((x) => x.ParkingSpot == int.Parse(textBox_ParkingSpot.Text));
                if (car.CarNumber != "")
                {

                    MessageBox.Show(car.CarNumber + "차량이 출차되어있습니다.");

                    TextFile.FileLoad($"{car.CarNumber}", "출차");

                    contents = $"[{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")}] {car.CarNumber} 출차";
                    listBox1.Items.Insert(0, contents);

                    Query_Delete();

                    foreach (var item in DB.Cars)
                    {
                        car.CarNumber = "";
                        car.DriverName = "";
                        car.PhoneNumber = "";
                        car.ParkingTime = DateTime.Now;
                    }

                    dataGridView_CarManager.DataSource = null;
                    dataGridView_CarManager.DataSource = DB.Cars;
                }
                else
                {
                    MessageBox.Show("출차할 차량이 존재하지 않습니다.");

                    TextFile.FileLoad("존재하지 않는 차량", "출차");

                    contents = $"[{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")}] '존재하지 않는 차량' 출차 클릭";
                    listBox1.Items.Insert(0, contents);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("존재하지 않는 차량입니다.");

                TextFile.FileLoad("존재하지 않는 차량", "출차");

                contents = $"[{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")}] '존재하지 않는 차량' 출차 클릭";
                listBox1.Items.Insert(0, contents);
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            try
            {
                Car car = DB.Cars.Single((x) => x.ParkingSpot.ToString() == textBox_Search.Text);
                if (car.ParkingSpot.ToString() == textBox_Search.Text && car.CarNumber != "")
                {
                    MessageBox.Show($"{car.CarNumber} 차량이 주차되어있습니다.");

                    TextFile.FileLoad($"{textBox_Search.Text}'번 '{car.CarNumber} 차량", "조회");

                    contents = $"[{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")}] {textBox_Search.Text}번의 {car.CarNumber} 차량 조회";
                    listBox1.Items.Insert(0, contents);
                }
                else
                {
                    MessageBox.Show($"{textBox_Search.Text}번에 차량이 존재하지 않습니다.");

                    TextFile.FileLoad($"{textBox_Search.Text}'번 '주차된 차량 없음", "조회");

                    contents = $"[{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")}] {textBox_Search.Text}번의 '주차된 차량 없음' 조회 클릭";
                    listBox1.Items.Insert(0, contents);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("존재하지 않는 공간번호 입니다.");

                TextFile.FileLoad("존재하지 않는 공간번호", "조회");

                contents = $"[{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")}] '존재하지 않는 공간번호' 조회 클릭";
                listBox1.Items.Insert(0, contents);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("현재시간 : yyyy년 MM월 dd일 HH시 mm분 ss초");
        }

        private void textBox_ParkingSpot_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void textBox_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }
    }
}

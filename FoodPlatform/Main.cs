using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;  //참조로 추가한다

namespace FoodPlatform
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
            label_id.Text = DataManager.id;
            Userdata();
        }

        private void pictureBox_chicken_Click(object sender, EventArgs e)
        {
            ChickenPage showchicken = new ChickenPage();         
            this.Visible = false;             // 현재 창(Window)를 닫기
            showchicken.ShowDialog();
        }

        private void button_charge_Click(object sender, EventArgs e)
        {
            charge showcharge = new charge();
            this.Visible = false;             // 현재 창(Window)를 닫기
            showcharge.ShowDialog();
        }

        private void Userdata()
        {
            DBconn dbconn = new DBconn();
            MySqlConnection conn = dbconn.Connection();
            MySqlConnection conn2 = dbconn.Connection();
            MySqlConnection conn3 = dbconn.Connection();

            string name = "select name from user where id = '" + label_id.Text + "'";
            string money = "select money from user where id = '" + label_id.Text + "'";
            string grade = "select grade from user where id = '" + label_id.Text + "'";

            MySqlCommand cmd = new MySqlCommand(name);
            MySqlCommand cmd2 = new MySqlCommand(money);
            MySqlCommand cmd3 = new MySqlCommand(grade);
            cmd.Connection = conn;
            cmd2.Connection = conn2;
            cmd3.Connection = conn3;

            conn.Open();
            conn2.Open();
            conn3.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            MySqlDataReader reader3 = cmd3.ExecuteReader();
            try
            {
                while (reader.Read() && reader2.Read() && reader3.Read())
                {
                    label_name.Text = (reader.GetString(0) + "님");
                    label_money.Text = (reader2.GetString(0) + "원");
                    label_grade.Text = (reader3.GetString(0));
                }
            }
            catch
            {
                
            }
            finally
            {
                conn.Close();
                conn2.Close();
                conn3.Close();
            }
        }
    }
}

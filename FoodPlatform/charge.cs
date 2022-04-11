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
    public partial class charge : Form
    {
        public charge()
        {
            InitializeComponent();
            label_id.Text = DataManager.id;
            Userdata();
        }

        private void button_charge_Click(object sender, EventArgs e)
        {
            DBconn dbconn = new DBconn();
            MySqlConnection conn = dbconn.Connection();

            if (textBox_charge.Text == "")
            {
                MessageBox.Show("충전할 금액을 입력하시오");
            }
            else
            {
                try
                {
                    // DB에 존재하는 값으로 로그인 시
                    conn.Open();
                    string sql = "update user set money= money +" + textBox_charge.Text + " where id='" + label_id.Text + "'";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("충전 되었습니다.");
                    Userdata();

                }
                catch (Exception)
                {

                }
                finally
                {
                    conn.Close();
                }

            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Main showMain = new Main();
            this.Visible = false;             // 현재 창(Window)를 닫기
            showMain.ShowDialog();
        }

        private void Userdata()
        {
            DBconn dbconn = new DBconn();
            MySqlConnection conn = dbconn.Connection();
            MySqlConnection conn2 = dbconn.Connection();

            string name = "select name from user where id = '" + label_id.Text + "'";
            string money = "select money from user where id = '" + label_id.Text + "'";

            MySqlCommand cmd = new MySqlCommand(name);
            MySqlCommand cmd2 = new MySqlCommand(money);
            cmd.Connection = conn;
            cmd2.Connection = conn2;

            conn.Open();
            conn2.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            try
            {
                while (reader.Read() && reader2.Read())
                {
                    label_name.Text = (reader.GetString(0) + "님");
                    label_money.Text = (reader2.GetString(0) + "원");
                }
            }
            catch
            {

            }
            finally
            {
                conn.Close();
                conn2.Close();
            }
        }
    }
}

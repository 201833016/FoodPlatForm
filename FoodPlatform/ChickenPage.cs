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

    public partial class ChickenPage : Form
    {

        public ChickenPage()
        {
            InitializeComponent();
            label_id.Text = DataManager.id;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DBconn dbconn = new DBconn();
            MySqlConnection conn = dbconn.Connection();
            try
            {
                conn.Open();
                string sql = "update ordermenu set foodprice = foodprice + 16000 Where id = 'all'";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                Total_FoodPrice();
                MessageBox.Show("치킨을 장바구니에 넣었습니다.", "Food Order");
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DBconn dbconn = new DBconn();
            MySqlConnection conn = dbconn.Connection();
            try
            {
                conn.Open();
                string sql = "update ordermenu set foodprice = foodprice + 3000 Where id = 'all'";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                Total_FoodPrice();
                MessageBox.Show("음료를 장바구니에 넣었습니다.", "Food Order");
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DBconn dbconn = new DBconn();
            MySqlConnection conn = dbconn.Connection();
            try
            {
                conn.Open();
                string sql = "update ordermenu set foodprice = foodprice + 1000 Where id = 'all'";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                Total_FoodPrice();
                MessageBox.Show("치킨 소스를 장바구니에 넣었습니다.", "Food Order");
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
        }
        private void ChickenPage_Load(object sender, EventArgs e)
        {
            Total_FoodPrice();
            UserMoney();
            Usergrade();
            Rankup();
        }

        private void button_order_Click(object sender, EventArgs e)
        {
            // 주문 버튼 클릭시
            DBconn dbconn = new DBconn();
            MySqlConnection conn = dbconn.Connection();

            int ordercount = int.Parse(label_ordercnt.Text);
            ordercount += 1;

            int mymoney = int.Parse(textBox_money.Text);
            int totalmoney = int.Parse(textBox_Totalmoney.Text);

            if (mymoney >= totalmoney)
            {
                try
                {
                    // DB에 존재하는 값으로 로그인 시
                    conn.Open();
                    string sql = "update user set ordercount= ordercount + 1 where id='" + label_id.Text + "'";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.ExecuteNonQuery();

                    string Foodtotalprice = textBox_Totalmoney.Text;
                    FoodOrder(Foodtotalprice);   // 유저의 돈에서 빼기
                    ResetOrdermenu();            // 장바구니 update로 초기화
                    Total_FoodPrice();
                    UserMoney();
                    Usergrade();
                    Rankup();
;                   MessageBox.Show("주문 되었습니다.", "Food Order");

                }
                catch (Exception)
                {

                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                ResetOrdermenu();            // 장바구니 update로 초기화
                Total_FoodPrice();
                UserMoney();
                Usergrade();
                Rankup();
                MessageBox.Show("잔액이 부족하여 취소 되었습니다.");
            }
        }

        private void Total_FoodPrice()
        {
            // 총액 표기 화
            DBconn dbconn = new DBconn();
            MySqlConnection conn = dbconn.Connection();
            string foodprice = "select foodprice from ordermenu";
            MySqlCommand cmd = new MySqlCommand(foodprice);
            cmd.Connection = conn;

            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    textBox_Totalmoney.Text = (reader.GetString(0));
                }
            }
            catch
            {
                conn.Close();
            }
        }

        private void FoodOrder(string Foodtotalprice)
        {
            // 사용자가 구매한 값
            DBconn dbconn = new DBconn();
            MySqlConnection conn = dbconn.Connection();
            try
            {
                conn.Open();
                string sql = "update user set money = money- " + Foodtotalprice + " Where id = '" + label_id.Text + "'";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
        }


        private void ResetOrdermenu()
        {
            // 장바구니 update로 초기화
            DBconn dbconn = new DBconn();
            MySqlConnection conn = dbconn.Connection();
            try
            {
                conn.Open();
                string sql = "update ordermenu set foodprice = 0";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        private void UserMoney()
        {
            DBconn dbconn = new DBconn();
            MySqlConnection conn = dbconn.Connection();
            string money = "select money from user where id = '" + label_id.Text + "'";
            MySqlCommand cmd = new MySqlCommand(money);
            cmd.Connection = conn;
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    textBox_money.Text = (reader.GetString(0));
                }
            }
            catch
            {
                conn.Close();
            }
        }

        private void Usergrade()
        {
            DBconn dbconn = new DBconn();
            MySqlConnection conn = dbconn.Connection();
            MySqlConnection conn2 = dbconn.Connection();

            string ordercnt = "select ordercount from user where id = '" + label_id.Text + "'";
            string grade = "select grade from user where id = '" + label_id.Text + "'";

            MySqlCommand cmd = new MySqlCommand(ordercnt);
            MySqlCommand cmd2 = new MySqlCommand(grade);
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
                    label_ordercnt.Text = (reader.GetString(0));
                    label_grade.Text = (reader2.GetString(0));
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

        private void Rankup()
        {
            DBconn dbconn = new DBconn();
            MySqlConnection conn = dbconn.Connection();

            int ordercount = int.Parse(label_ordercnt.Text);
            if (ordercount == 3)
            {
                // 3번이상 시키면 실버급
                try
                {
                    conn.Open();
                    string sql = "update user set grade = '실버' where id='" + label_id.Text + "'";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                    Usergrade();

                }
                catch
                {

                }
                finally
                {
                    conn.Close();
                }
            }
            else if(ordercount == 5)
            {
                // 5번이상 시키면 골드급
                try
                {
                    conn.Open();
                    string sql = "update user set grade = '골드' where id='" + label_id.Text + "'";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                    Usergrade();

                }
                catch
                {

                }
                finally
                {
                    conn.Close();
                }
            }
            else if (ordercount == 7)
            {
                // 7번이상 시키면 플래티넘급
                try
                {
                    conn.Open();
                    string sql = "update user set grade = '플래티넘' where id='" + label_id.Text + "'";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                    Usergrade();

                }
                catch
                {

                }
                finally
                {
                    conn.Close();
                }
            }

        }

        private void button_Main_Click(object sender, EventArgs e)
        {
            Main showMain = new Main();
            this.Visible = false;             // 현재 창(Window)를 닫기
            showMain.ShowDialog();
        }
    }
}

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
    public partial class Login : Form
    {
        //MySqlConnection connection = new MySqlConnection("Server=localhost;Database=foodplatform;Uid=root;Pwd=test1234;");
        // 서버 정보

        public Login()
        {
            InitializeComponent();
        }
        private void button_Join_Click(object sender, EventArgs e)
        {
            //회원가입
            Join showJoin = new Join();         // 추후 관리자 페이지 생성후, 변경예정
            this.Visible = false;             // 현재 창(Window)를 닫기
            showJoin.ShowDialog();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            // 로그인
            DBconn dbconn = new DBconn();
            MySqlConnection conn = dbconn.Connection();

            string LoginIdText = textBox_ID.Text;
            string LoginPWDText = textBox_Passwd.Text;

            if (LoginIdText.Trim() == "")
            {
                MessageBox.Show("아이디를 입력하시오");
            }
            else if (LoginPWDText.Trim() == "")
            {
                MessageBox.Show("비밀번호를 입력하시오");
            }
            else
            {
                if (LoginIdText == "admin" && LoginPWDText == "1234")
                {
                    // 관리자 코드 입력시
                    Main showMain = new Main();         // 추후 관리자 페이지 생성후, 변경예정
                    this.Visible = false;             // 현재 창(Window)를 닫기
                    showMain.ShowDialog();
                }
                else
                {
                    conn.Open();
                    try
                    {
                        // DB에 존재하는 값으로 로그인 시
                        string sql = "select * from user where id ='" + LoginIdText + "'and password = '"+ LoginPWDText +"';";
                        MySqlCommand command = new MySqlCommand(sql, conn);
                        command.ExecuteNonQuery();
                        MySqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            if (reader["id"].ToString() == LoginIdText && reader["password"].ToString() == LoginPWDText)
                            {
                                DataManager.id = reader["id"].ToString();
                                MessageBox.Show("환영합니다");


                                Main showMain = new Main();       
                                this.Visible = false;             // 현재 창(Window)를 닫기
                                showMain.ShowDialog();
                            }
                            else if (reader["id"].ToString() == LoginIdText)
                            {
                                MessageBox.Show("패스워드가 일치하지 않습니다.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("존재하지 않는 회원입니다.");
                        }

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


        }
    }
}

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
    public partial class Join : Form
    {
        // MySqlConnection connection = new MySqlConnection("Server=localhost;Database=foodplatform;Uid=root;Pwd=test1234;");
        // string Conn = "Server=localhost;Database=foodplatform;Uid=root;Pwd=test1234;";
        // 서버 정보

        public Join()
        {
            InitializeComponent();
        }


        private void button_Join_Click(object sender, EventArgs e)
        {
            DBconn dbconn = new DBconn();
            MySqlConnection conn = dbconn.Connection();

            string JoinIdText = textBox_ID.Text;
            string JoinPasswdText = textBox_Passwd.Text;
            string JoinNameText = textBox_name.Text;
            // 아이디, 비밀번호, 사용자 이름, 전화번호

            if (JoinIdText.Trim() == "")
            {
                MessageBox.Show("아이디를 입력하십시오.");
            }
            else if (JoinPasswdText.Trim() == "")
            {
                MessageBox.Show("비밀번호를 입력하십시오.");
            }
            else if (JoinNameText.Trim() == "")
            {
                MessageBox.Show("이름를 입력하십시오.");
            }

            else
            {
                // 회원가입의 조건 만족시
                conn.Open();
                
                string sql = "insert into user values('" + JoinIdText + "', '" + JoinPasswdText + "', '" + JoinNameText + "', 0, '브론즈', 0)";
                try
                {
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("회원가입 되었습니다.");

                    Login showLogin = new Login();         
                    this.Visible = false;             // 현재 창(Window)를 닫기
                    showLogin.ShowDialog();

                }
                catch (Exception)
                {
                    MessageBox.Show("이미 존재하는 아이디입니다.");
                }
                finally
                {

                }
            }
        }
    }
}

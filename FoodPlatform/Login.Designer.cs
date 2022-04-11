namespace FoodPlatform
{
    partial class Login
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_Passwd = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.button_Join = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "로그인";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "아이디";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "비밀번호";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(307, 137);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(100, 28);
            this.textBox_ID.TabIndex = 3;
            // 
            // textBox_Passwd
            // 
            this.textBox_Passwd.Location = new System.Drawing.Point(307, 213);
            this.textBox_Passwd.Name = "textBox_Passwd";
            this.textBox_Passwd.Size = new System.Drawing.Size(100, 28);
            this.textBox_Passwd.TabIndex = 4;
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(436, 293);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(148, 71);
            this.button_Login.TabIndex = 5;
            this.button_Login.Text = "로그인";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_Join
            // 
            this.button_Join.Location = new System.Drawing.Point(204, 293);
            this.button_Join.Name = "button_Join";
            this.button_Join.Size = new System.Drawing.Size(148, 71);
            this.button_Join.TabIndex = 6;
            this.button_Join.Text = "회원가입";
            this.button_Join.UseVisualStyleBackColor = true;
            this.button_Join.Click += new System.EventHandler(this.button_Join_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Join);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_Passwd);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_Passwd;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_Join;
    }
}


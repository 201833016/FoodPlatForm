namespace FoodPlatform
{
    partial class Join
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Join = new System.Windows.Forms.Button();
            this.textBox_Passwd = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Join
            // 
            this.button_Join.Location = new System.Drawing.Point(572, 315);
            this.button_Join.Name = "button_Join";
            this.button_Join.Size = new System.Drawing.Size(118, 72);
            this.button_Join.TabIndex = 13;
            this.button_Join.Text = "회원가입";
            this.button_Join.UseVisualStyleBackColor = true;
            this.button_Join.Click += new System.EventHandler(this.button_Join_Click);
            // 
            // textBox_Passwd
            // 
            this.textBox_Passwd.Location = new System.Drawing.Point(348, 216);
            this.textBox_Passwd.Name = "textBox_Passwd";
            this.textBox_Passwd.Size = new System.Drawing.Size(127, 28);
            this.textBox_Passwd.TabIndex = 11;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(348, 146);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(127, 28);
            this.textBox_ID.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "비밀번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "아이디";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "회원가입";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(348, 295);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(127, 28);
            this.textBox_name.TabIndex = 15;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(207, 298);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(44, 18);
            this.label_name.TabIndex = 14;
            this.label_name.Text = "이름";
            // 
            // Join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button_Join);
            this.Controls.Add(this.textBox_Passwd);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Join";
            this.Text = "Join";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Join;
        private System.Windows.Forms.TextBox textBox_Passwd;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_name;
    }
}
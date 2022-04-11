namespace FoodPlatform
{
    partial class ChickenPage
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_money = new System.Windows.Forms.TextBox();
            this.button_order = new System.Windows.Forms.Button();
            this.textBox_Totalmoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Main = new System.Windows.Forms.Button();
            this.label_grade = new System.Windows.Forms.Label();
            this.label_ordercnt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FoodPlatform.Properties.Resources.소스;
            this.pictureBox3.Location = new System.Drawing.Point(556, 64);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(193, 149);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FoodPlatform.Properties.Resources.콜라;
            this.pictureBox2.Location = new System.Drawing.Point(300, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FoodPlatform.Properties.Resources.치킨;
            this.pictureBox1.Location = new System.Drawing.Point(21, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(560, 20);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(62, 18);
            this.label_id.TabIndex = 3;
            this.label_id.Text = "아이디";
            this.label_id.Visible = false;
            // 
            // textBox_money
            // 
            this.textBox_money.Location = new System.Drawing.Point(556, 242);
            this.textBox_money.Name = "textBox_money";
            this.textBox_money.ReadOnly = true;
            this.textBox_money.Size = new System.Drawing.Size(193, 28);
            this.textBox_money.TabIndex = 5;
            // 
            // button_order
            // 
            this.button_order.Location = new System.Drawing.Point(556, 362);
            this.button_order.Name = "button_order";
            this.button_order.Size = new System.Drawing.Size(193, 57);
            this.button_order.TabIndex = 6;
            this.button_order.Text = "주문";
            this.button_order.UseVisualStyleBackColor = true;
            this.button_order.Click += new System.EventHandler(this.button_order_Click);
            // 
            // textBox_Totalmoney
            // 
            this.textBox_Totalmoney.Location = new System.Drawing.Point(556, 302);
            this.textBox_Totalmoney.Name = "textBox_Totalmoney";
            this.textBox_Totalmoney.ReadOnly = true;
            this.textBox_Totalmoney.Size = new System.Drawing.Size(193, 28);
            this.textBox_Totalmoney.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "충전된 금액";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "주문할 금액";
            // 
            // button_Main
            // 
            this.button_Main.Location = new System.Drawing.Point(21, 12);
            this.button_Main.Name = "button_Main";
            this.button_Main.Size = new System.Drawing.Size(88, 35);
            this.button_Main.TabIndex = 12;
            this.button_Main.Text = "뒤로가기";
            this.button_Main.UseVisualStyleBackColor = true;
            this.button_Main.Click += new System.EventHandler(this.button_Main_Click);
            // 
            // label_grade
            // 
            this.label_grade.AutoSize = true;
            this.label_grade.Location = new System.Drawing.Point(644, 20);
            this.label_grade.Name = "label_grade";
            this.label_grade.Size = new System.Drawing.Size(44, 18);
            this.label_grade.TabIndex = 13;
            this.label_grade.Text = "등급";
            // 
            // label_ordercnt
            // 
            this.label_ordercnt.AutoSize = true;
            this.label_ordercnt.Location = new System.Drawing.Point(708, 20);
            this.label_ordercnt.Name = "label_ordercnt";
            this.label_ordercnt.Size = new System.Drawing.Size(80, 18);
            this.label_ordercnt.TabIndex = 14;
            this.label_ordercnt.Text = "주문횟수";
            // 
            // ChickenPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_ordercnt);
            this.Controls.Add(this.label_grade);
            this.Controls.Add(this.button_Main);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Totalmoney);
            this.Controls.Add(this.button_order);
            this.Controls.Add(this.textBox_money);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ChickenPage";
            this.Text = "ChickenPage";
            this.Load += new System.EventHandler(this.ChickenPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_money;
        private System.Windows.Forms.Button button_order;
        private System.Windows.Forms.TextBox textBox_Totalmoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Main;
        private System.Windows.Forms.Label label_grade;
        private System.Windows.Forms.Label label_ordercnt;
    }
}
namespace FoodPlatform
{
    partial class Main
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
            this.label_id = new System.Windows.Forms.Label();
            this.label_grade = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_money = new System.Windows.Forms.Label();
            this.pictureBox_chicken = new System.Windows.Forms.PictureBox();
            this.button_charge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chicken)).BeginInit();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(446, 9);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(62, 18);
            this.label_id.TabIndex = 3;
            this.label_id.Text = "아이디";
            this.label_id.Visible = false;
            // 
            // label_grade
            // 
            this.label_grade.AutoSize = true;
            this.label_grade.Location = new System.Drawing.Point(553, 9);
            this.label_grade.Name = "label_grade";
            this.label_grade.Size = new System.Drawing.Size(44, 18);
            this.label_grade.TabIndex = 4;
            this.label_grade.Text = "등급";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(633, 9);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(44, 18);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "이름";
            // 
            // label_money
            // 
            this.label_money.AutoSize = true;
            this.label_money.Location = new System.Drawing.Point(729, 9);
            this.label_money.Name = "label_money";
            this.label_money.Size = new System.Drawing.Size(44, 18);
            this.label_money.TabIndex = 2;
            this.label_money.Text = "잔금";
            // 
            // pictureBox_chicken
            // 
            this.pictureBox_chicken.Image = global::FoodPlatform.Properties.Resources.치킨;
            this.pictureBox_chicken.Location = new System.Drawing.Point(67, 117);
            this.pictureBox_chicken.Name = "pictureBox_chicken";
            this.pictureBox_chicken.Size = new System.Drawing.Size(185, 158);
            this.pictureBox_chicken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_chicken.TabIndex = 1;
            this.pictureBox_chicken.TabStop = false;
            this.pictureBox_chicken.Click += new System.EventHandler(this.pictureBox_chicken_Click);
            // 
            // button_charge
            // 
            this.button_charge.Location = new System.Drawing.Point(636, 50);
            this.button_charge.Name = "button_charge";
            this.button_charge.Size = new System.Drawing.Size(134, 38);
            this.button_charge.TabIndex = 5;
            this.button_charge.Text = "잔액 충전";
            this.button_charge.UseVisualStyleBackColor = true;
            this.button_charge.Click += new System.EventHandler(this.button_charge_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_charge);
            this.Controls.Add(this.pictureBox_chicken);
            this.Controls.Add(this.label_grade);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_money);
            this.Controls.Add(this.label_name);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chicken)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_grade;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_money;
        private System.Windows.Forms.PictureBox pictureBox_chicken;
        private System.Windows.Forms.Button button_charge;
    }
}
namespace FoodPlatform
{
    partial class charge
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
            this.textBox_charge = new System.Windows.Forms.TextBox();
            this.button_charge = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.label_money = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(650, 26);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(62, 18);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "아이디";
            this.label_id.Visible = false;
            // 
            // textBox_charge
            // 
            this.textBox_charge.Location = new System.Drawing.Point(271, 262);
            this.textBox_charge.Name = "textBox_charge";
            this.textBox_charge.Size = new System.Drawing.Size(207, 28);
            this.textBox_charge.TabIndex = 1;
            // 
            // button_charge
            // 
            this.button_charge.Location = new System.Drawing.Point(518, 262);
            this.button_charge.Name = "button_charge";
            this.button_charge.Size = new System.Drawing.Size(172, 78);
            this.button_charge.TabIndex = 2;
            this.button_charge.Text = "충전";
            this.button_charge.UseVisualStyleBackColor = true;
            this.button_charge.Click += new System.EventHandler(this.button_charge_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(12, 12);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(128, 47);
            this.button_Exit.TabIndex = 3;
            this.button_Exit.Text = "메인으로";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(268, 136);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(44, 18);
            this.label_name.TabIndex = 4;
            this.label_name.Text = "이름";
            // 
            // label_money
            // 
            this.label_money.AutoSize = true;
            this.label_money.Location = new System.Drawing.Point(268, 193);
            this.label_money.Name = "label_money";
            this.label_money.Size = new System.Drawing.Size(44, 18);
            this.label_money.TabIndex = 5;
            this.label_money.Text = "잔액";
            // 
            // charge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_money);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_charge);
            this.Controls.Add(this.textBox_charge);
            this.Controls.Add(this.label_id);
            this.Name = "charge";
            this.Text = "charge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_charge;
        private System.Windows.Forms.Button button_charge;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_money;
    }
}
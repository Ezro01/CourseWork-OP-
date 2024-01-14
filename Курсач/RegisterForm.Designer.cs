namespace Курсач
{
    partial class RegisterForm
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
            this.ButtonRegister = new System.Windows.Forms.Button();
            this.PassField = new System.Windows.Forms.TextBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_Window = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseWindow = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ButtonHaveACC = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(42)))));
            this.ButtonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRegister.FlatAppearance.BorderSize = 0;
            this.ButtonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(86)))), ((int)(((byte)(25)))));
            this.ButtonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(173)))), ((int)(((byte)(83)))));
            this.ButtonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRegister.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRegister.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ButtonRegister.Location = new System.Drawing.Point(214, 537);
            this.ButtonRegister.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(376, 70);
            this.ButtonRegister.TabIndex = 14;
            this.ButtonRegister.Text = "Зарегестрироваться";
            this.ButtonRegister.UseVisualStyleBackColor = false;
            this.ButtonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // PassField
            // 
            this.PassField.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassField.Location = new System.Drawing.Point(188, 430);
            this.PassField.Margin = new System.Windows.Forms.Padding(6);
            this.PassField.Name = "PassField";
            this.PassField.Size = new System.Drawing.Size(492, 56);
            this.PassField.TabIndex = 13;
            this.PassField.UseSystemPasswordChar = true;
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.Location = new System.Drawing.Point(188, 254);
            this.LoginField.Margin = new System.Windows.Forms.Padding(6);
            this.LoginField.Multiline = true;
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(492, 67);
            this.LoginField.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(6)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.Close_Window);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CloseWindow);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 155);
            this.panel1.TabIndex = 9;
            // 
            // Close_Window
            // 
            this.Close_Window.AutoSize = true;
            this.Close_Window.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_Window.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_Window.ForeColor = System.Drawing.SystemColors.Window;
            this.Close_Window.Location = new System.Drawing.Point(756, 0);
            this.Close_Window.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Close_Window.Name = "Close_Window";
            this.Close_Window.Size = new System.Drawing.Size(48, 55);
            this.Close_Window.TabIndex = 5;
            this.Close_Window.Text = "х";
            this.Close_Window.Click += new System.EventHandler(this.Close_Window_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Californian FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(810, 155);
            this.label1.TabIndex = 4;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseWindow
            // 
            this.CloseWindow.AutoSize = true;
            this.CloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseWindow.ForeColor = System.Drawing.SystemColors.Window;
            this.CloseWindow.Location = new System.Drawing.Point(744, 0);
            this.CloseWindow.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(48, 55);
            this.CloseWindow.TabIndex = 3;
            this.CloseWindow.Text = "х";
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = global::Курсач.Properties.Resources._lock;
            this.pictureBox2.Image = global::Курсач.Properties.Resources._lock;
            this.pictureBox2.InitialImage = global::Курсач.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(61, 373);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Курсач.Properties.Resources.user;
            this.pictureBox1.Image = global::Курсач.Properties.Resources.user;
            this.pictureBox1.InitialImage = global::Курсач.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(61, 198);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(188, 207);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(204, 38);
            this.textBox2.TabIndex = 19;
            this.textBox2.Text = "Введите логин";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(188, 373);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(213, 38);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "Введите пароль";
            // 
            // ButtonHaveACC
            // 
            this.ButtonHaveACC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHaveACC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonHaveACC.Location = new System.Drawing.Point(168, 642);
            this.ButtonHaveACC.Name = "ButtonHaveACC";
            this.ButtonHaveACC.Size = new System.Drawing.Size(492, 49);
            this.ButtonHaveACC.TabIndex = 23;
            this.ButtonHaveACC.Text = "У меня уже есть аккаунт";
            this.ButtonHaveACC.UseVisualStyleBackColor = true;
            this.ButtonHaveACC.Click += new System.EventHandler(this.ButtonHaveACC_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(204)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(811, 704);
            this.Controls.Add(this.ButtonHaveACC);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ButtonRegister);
            this.Controls.Add(this.PassField);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonRegister;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CloseWindow;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ButtonHaveACC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Close_Window;
    }
}
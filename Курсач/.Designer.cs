using System.Drawing;

namespace Курсач
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseWindow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.PassField = new System.Windows.Forms.TextBox();
            this.ButtonAuth = new System.Windows.Forms.Button();
            this.Button_registr = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(6)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.CloseWindow);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 192);
            this.panel1.TabIndex = 2;
            // 
            // CloseWindow
            // 
            this.CloseWindow.AutoSize = true;
            this.CloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseWindow.ForeColor = System.Drawing.SystemColors.Window;
            this.CloseWindow.Location = new System.Drawing.Point(670, 0);
            this.CloseWindow.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(48, 55);
            this.CloseWindow.TabIndex = 3;
            this.CloseWindow.Text = "х";
            this.CloseWindow.Click += new System.EventHandler(this.CloseWindow_Click);
            this.CloseWindow.MouseEnter += new System.EventHandler(this.CloseWindow_MouseEnter);
            this.CloseWindow.MouseLeave += new System.EventHandler(this.CloseWindow_MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Californian FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(724, 192);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = global::Курсач.Properties.Resources._lock;
            this.pictureBox2.Image = global::Курсач.Properties.Resources._lock;
            this.pictureBox2.InitialImage = global::Курсач.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(58, 417);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Курсач.Properties.Resources.user;
            this.pictureBox1.Image = global::Курсач.Properties.Resources.user;
            this.pictureBox1.InitialImage = global::Курсач.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(58, 260);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.Location = new System.Drawing.Point(198, 316);
            this.LoginField.Margin = new System.Windows.Forms.Padding(6);
            this.LoginField.Multiline = true;
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(492, 67);
            this.LoginField.TabIndex = 6;
            // 
            // PassField
            // 
            this.PassField.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassField.Location = new System.Drawing.Point(198, 467);
            this.PassField.Margin = new System.Windows.Forms.Padding(6);
            this.PassField.Name = "PassField";
            this.PassField.Size = new System.Drawing.Size(492, 56);
            this.PassField.TabIndex = 7;
            this.PassField.UseSystemPasswordChar = true;
            // 
            // ButtonAuth
            // 
            this.ButtonAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(150)))), ((int)(((byte)(42)))));
            this.ButtonAuth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAuth.FlatAppearance.BorderSize = 0;
            this.ButtonAuth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(86)))), ((int)(((byte)(25)))));
            this.ButtonAuth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(173)))), ((int)(((byte)(83)))));
            this.ButtonAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAuth.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAuth.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ButtonAuth.Location = new System.Drawing.Point(198, 569);
            this.ButtonAuth.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonAuth.Name = "ButtonAuth";
            this.ButtonAuth.Size = new System.Drawing.Size(340, 87);
            this.ButtonAuth.TabIndex = 8;
            this.ButtonAuth.Text = "Войти";
            this.ButtonAuth.UseVisualStyleBackColor = false;
            this.ButtonAuth.Click += new System.EventHandler(this.ButtonAuth_Click);
            // 
            // Button_registr
            // 
            this.Button_registr.BackColor = System.Drawing.Color.White;
            this.Button_registr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_registr.FlatAppearance.BorderSize = 0;
            this.Button_registr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(86)))), ((int)(((byte)(25)))));
            this.Button_registr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(173)))), ((int)(((byte)(83)))));
            this.Button_registr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_registr.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_registr.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Button_registr.Location = new System.Drawing.Point(164, 688);
            this.Button_registr.Margin = new System.Windows.Forms.Padding(6);
            this.Button_registr.Name = "Button_registr";
            this.Button_registr.Size = new System.Drawing.Size(408, 53);
            this.Button_registr.TabIndex = 9;
            this.Button_registr.Text = "Зарегестрироваться";
            this.Button_registr.UseVisualStyleBackColor = false;
            this.Button_registr.Click += new System.EventHandler(this.Button_registr_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(198, 260);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 38);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Логин";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(198, 417);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(114, 38);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "Пароль";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(204)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(724, 774);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Button_registr);
            this.Controls.Add(this.ButtonAuth);
            this.Controls.Add(this.PassField);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CloseWindow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.Button ButtonAuth;
        private System.Windows.Forms.Button Button_registr;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}


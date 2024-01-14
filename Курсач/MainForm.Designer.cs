namespace Курсач
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_n = new System.Windows.Forms.Label();
            this.CloseWindow = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.n_txt = new System.Windows.Forms.TextBox();
            this.Resh_bt = new System.Windows.Forms.Button();
            this.Save_bt = new System.Windows.Forms.Button();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.n_lb = new System.Windows.Forms.Label();
            this.Prime_lb = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(6)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.label_n);
            this.panel1.Controls.Add(this.CloseWindow);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 254);
            this.panel1.TabIndex = 0;
            // 
            // label_n
            // 
            this.label_n.AutoSize = true;
            this.label_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_n.ForeColor = System.Drawing.SystemColors.Window;
            this.label_n.Location = new System.Drawing.Point(155, 191);
            this.label_n.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_n.Name = "label_n";
            this.label_n.Size = new System.Drawing.Size(694, 51);
            this.label_n.TabIndex = 6;
            this.label_n.Text = "Введите натуральное число n ⩾ 2";
            // 
            // CloseWindow
            // 
            this.CloseWindow.AutoSize = true;
            this.CloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseWindow.ForeColor = System.Drawing.SystemColors.Window;
            this.CloseWindow.Location = new System.Drawing.Point(1784, 0);
            this.CloseWindow.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(48, 55);
            this.CloseWindow.TabIndex = 5;
            this.CloseWindow.Text = "х";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Californian FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(947, 254);
            this.label3.TabIndex = 4;
            this.label3.Text = "Решито Аткина";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Californian FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(947, 254);
            this.label1.TabIndex = 1;
            this.label1.Text = "Решито Аткина";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // n_txt
            // 
            this.n_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n_txt.Location = new System.Drawing.Point(119, 285);
            this.n_txt.Margin = new System.Windows.Forms.Padding(6);
            this.n_txt.Multiline = true;
            this.n_txt.Name = "n_txt";
            this.n_txt.Size = new System.Drawing.Size(468, 70);
            this.n_txt.TabIndex = 1;
            // 
            // Resh_bt
            // 
            this.Resh_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Resh_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Resh_bt.Location = new System.Drawing.Point(627, 285);
            this.Resh_bt.Margin = new System.Windows.Forms.Padding(6);
            this.Resh_bt.Name = "Resh_bt";
            this.Resh_bt.Size = new System.Drawing.Size(280, 121);
            this.Resh_bt.TabIndex = 5;
            this.Resh_bt.Text = "Найти простые числа";
            this.Resh_bt.UseVisualStyleBackColor = true;
            this.Resh_bt.Click += new System.EventHandler(this.Resh_bt_Click);
            // 
            // Save_bt
            // 
            this.Save_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_bt.Location = new System.Drawing.Point(627, 474);
            this.Save_bt.Margin = new System.Windows.Forms.Padding(6);
            this.Save_bt.Name = "Save_bt";
            this.Save_bt.Size = new System.Drawing.Size(280, 146);
            this.Save_bt.TabIndex = 6;
            this.Save_bt.Text = "Сохранить простые числа скриншотом\r\n";
            this.Save_bt.UseVisualStyleBackColor = true;
            this.Save_bt.Click += new System.EventHandler(this.Save_bt_Click);
            // 
            // buttonEnd
            // 
            this.buttonEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnd.Location = new System.Drawing.Point(627, 680);
            this.buttonEnd.Margin = new System.Windows.Forms.Padding(6);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(280, 121);
            this.buttonEnd.TabIndex = 7;
            this.buttonEnd.Text = "Закончить работу";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // n_lb
            // 
            this.n_lb.AutoSize = true;
            this.n_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n_lb.Location = new System.Drawing.Point(15, 293);
            this.n_lb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.n_lb.Name = "n_lb";
            this.n_lb.Size = new System.Drawing.Size(92, 55);
            this.n_lb.TabIndex = 8;
            this.n_lb.Text = "n =";
            // 
            // Prime_lb
            // 
            this.Prime_lb.AutoSize = true;
            this.Prime_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prime_lb.Location = new System.Drawing.Point(15, 384);
            this.Prime_lb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Prime_lb.Name = "Prime_lb";
            this.Prime_lb.Size = new System.Drawing.Size(377, 55);
            this.Prime_lb.TabIndex = 9;
            this.Prime_lb.Text = "Простые числа:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(14, 453);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(573, 348);
            this.dataGridView1.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(204)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(947, 827);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Prime_lb);
            this.Controls.Add(this.n_lb);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.Save_bt);
            this.Controls.Add(this.Resh_bt);
            this.Controls.Add(this.n_txt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CloseWindow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox n_txt;
        private System.Windows.Forms.Button Resh_bt;
        private System.Windows.Forms.Button Save_bt;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.Label n_lb;
        private System.Windows.Forms.Label Prime_lb;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
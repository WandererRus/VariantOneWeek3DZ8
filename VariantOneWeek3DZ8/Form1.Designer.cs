namespace VariantOneWeek3DZ8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_destination = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_destHours = new System.Windows.Forms.TextBox();
            this.tb_destMinutes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_destSeconds = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_filterRoute = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_defaultRoute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(29, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(742, 244);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер маршрута";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип автобуса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Место назначения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Время отправления";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(567, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Время прибытия";
            // 
            // tb_destination
            // 
            this.tb_destination.Location = new System.Drawing.Point(29, 336);
            this.tb_destination.Name = "tb_destination";
            this.tb_destination.Size = new System.Drawing.Size(304, 23);
            this.tb_destination.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Укажите место назначения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Часы";
            // 
            // tb_destHours
            // 
            this.tb_destHours.Location = new System.Drawing.Point(381, 336);
            this.tb_destHours.Name = "tb_destHours";
            this.tb_destHours.Size = new System.Drawing.Size(91, 23);
            this.tb_destHours.TabIndex = 9;
            // 
            // tb_destMinutes
            // 
            this.tb_destMinutes.Location = new System.Drawing.Point(487, 336);
            this.tb_destMinutes.Name = "tb_destMinutes";
            this.tb_destMinutes.Size = new System.Drawing.Size(91, 23);
            this.tb_destMinutes.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(487, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Минуты";
            // 
            // tb_destSeconds
            // 
            this.tb_destSeconds.Location = new System.Drawing.Point(584, 336);
            this.tb_destSeconds.Name = "tb_destSeconds";
            this.tb_destSeconds.Size = new System.Drawing.Size(91, 23);
            this.tb_destSeconds.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(584, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Секунды";
            // 
            // btn_filterRoute
            // 
            this.btn_filterRoute.Location = new System.Drawing.Point(29, 383);
            this.btn_filterRoute.Name = "btn_filterRoute";
            this.btn_filterRoute.Size = new System.Drawing.Size(347, 23);
            this.btn_filterRoute.TabIndex = 14;
            this.btn_filterRoute.Text = "Показать доступные маршруты";
            this.btn_filterRoute.UseVisualStyleBackColor = true;
            this.btn_filterRoute.Click += new System.EventHandler(this.btn_filterRoute_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(376, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(395, 30);
            this.label10.TabIndex = 15;
            this.label10.Text = "Укажите желаемое время прибытия \r\n(будут показаны маршруты прибывающее сегодня до" +
    " этого времени)";
            // 
            // btn_defaultRoute
            // 
            this.btn_defaultRoute.Location = new System.Drawing.Point(424, 383);
            this.btn_defaultRoute.Name = "btn_defaultRoute";
            this.btn_defaultRoute.Size = new System.Drawing.Size(347, 23);
            this.btn_defaultRoute.TabIndex = 16;
            this.btn_defaultRoute.Text = "Показать все маршруты";
            this.btn_defaultRoute.UseVisualStyleBackColor = true;
            this.btn_defaultRoute.Click += new System.EventHandler(this.btn_defaultRoute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 418);
            this.Controls.Add(this.btn_defaultRoute);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_filterRoute);
            this.Controls.Add(this.tb_destSeconds);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_destMinutes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_destHours);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_destination);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tb_destination;
        private Label label6;
        private Label label7;
        private TextBox tb_destHours;
        private TextBox tb_destMinutes;
        private Label label8;
        private TextBox tb_destSeconds;
        private Label label9;
        private Button btn_filterRoute;
        private Label label10;
        private Button btn_defaultRoute;
    }
}
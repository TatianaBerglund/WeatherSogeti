namespace WeatherApiKontorsApp
{
    partial class Form1
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
            this.lbl_cityName = new System.Windows.Forms.Label();
            this.lbl_country = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Temp = new System.Windows.Forms.Label();
            this.lbl_Forcast = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.Label();
            this.Pressure = new System.Windows.Forms.Label();
            this.lbl_temperatura = new System.Windows.Forms.Label();
            this.lbl2_pressure = new System.Windows.Forms.Label();
            this.Humidity = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.Label();
            this.lbl2_speed = new System.Windows.Forms.Label();
            this.lbl2_humidity = new System.Windows.Forms.Label();
            this.lbl2_tempelatura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_cityName
            // 
            this.lbl_cityName.AutoSize = true;
            this.lbl_cityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cityName.ForeColor = System.Drawing.Color.Blue;
            this.lbl_cityName.Location = new System.Drawing.Point(66, 42);
            this.lbl_cityName.Name = "lbl_cityName";
            this.lbl_cityName.Size = new System.Drawing.Size(226, 42);
            this.lbl_cityName.TabIndex = 0;
            this.lbl_cityName.Text = "Gothenburg";
            this.lbl_cityName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_country.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_country.Location = new System.Drawing.Point(69, 84);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(86, 24);
            this.lbl_country.TabIndex = 1;
            this.lbl_country.Text = "Sweden\r\n";
            this.lbl_country.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(69, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(204, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 62);
            this.label4.TabIndex = 3;
            this.label4.Text = "C\r\n\r\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_Temp
            // 
            this.lbl_Temp.AutoSize = true;
            this.lbl_Temp.Location = new System.Drawing.Point(89, 171);
            this.lbl_Temp.Name = "lbl_Temp";
            this.lbl_Temp.Size = new System.Drawing.Size(0, 13);
            this.lbl_Temp.TabIndex = 4;
            this.lbl_Temp.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_Forcast
            // 
            this.lbl_Forcast.AutoSize = true;
            this.lbl_Forcast.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Forcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Forcast.ForeColor = System.Drawing.Color.Green;
            this.lbl_Forcast.Location = new System.Drawing.Point(671, 48);
            this.lbl_Forcast.MaximumSize = new System.Drawing.Size(150, 50);
            this.lbl_Forcast.Name = "lbl_Forcast";
            this.lbl_Forcast.Size = new System.Drawing.Size(150, 37);
            this.lbl_Forcast.TabIndex = 5;
            this.lbl_Forcast.Text = "Forecast";
            this.lbl_Forcast.Click += new System.EventHandler(this.lbl_Forcast_Click);
            // 
            // Day
            // 
            this.Day.AutoSize = true;
            this.Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Day.Location = new System.Drawing.Point(660, 137);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(45, 24);
            this.Day.TabIndex = 6;
            this.Day.Text = "Day";
            this.Day.Click += new System.EventHandler(this.lbl_wind_Click);
            // 
            // Pressure
            // 
            this.Pressure.AutoSize = true;
            this.Pressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pressure.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Pressure.Location = new System.Drawing.Point(657, 185);
            this.Pressure.Name = "Pressure";
            this.Pressure.Size = new System.Drawing.Size(106, 25);
            this.Pressure.TabIndex = 7;
            this.Pressure.Text = "Pressure";
            this.Pressure.Click += new System.EventHandler(this.lbl_description_Click);
            // 
            // lbl_temperatura
            // 
            this.lbl_temperatura.AutoSize = true;
            this.lbl_temperatura.Location = new System.Drawing.Point(779, 123);
            this.lbl_temperatura.Name = "lbl_temperatura";
            this.lbl_temperatura.Size = new System.Drawing.Size(0, 13);
            this.lbl_temperatura.TabIndex = 8;
            // 
            // lbl2_pressure
            // 
            this.lbl2_pressure.AutoSize = true;
            this.lbl2_pressure.Location = new System.Drawing.Point(839, 185);
            this.lbl2_pressure.Name = "lbl2_pressure";
            this.lbl2_pressure.Size = new System.Drawing.Size(45, 13);
            this.lbl2_pressure.TabIndex = 9;
            this.lbl2_pressure.Text = "labelPre";
            this.lbl2_pressure.Click += new System.EventHandler(this.lbl_pressure_Click);
            // 
            // Humidity
            // 
            this.Humidity.AutoSize = true;
            this.Humidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Humidity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Humidity.Location = new System.Drawing.Point(657, 226);
            this.Humidity.Name = "Humidity";
            this.Humidity.Size = new System.Drawing.Size(103, 25);
            this.Humidity.TabIndex = 10;
            this.Humidity.Text = "Humidity";
            this.Humidity.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speed.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Speed.Location = new System.Drawing.Point(657, 266);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(79, 25);
            this.Speed.TabIndex = 11;
            this.Speed.Text = "Speed";
            this.Speed.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lbl2_speed
            // 
            this.lbl2_speed.AutoSize = true;
            this.lbl2_speed.Location = new System.Drawing.Point(839, 273);
            this.lbl2_speed.Name = "lbl2_speed";
            this.lbl2_speed.Size = new System.Drawing.Size(48, 13);
            this.lbl2_speed.TabIndex = 12;
            this.lbl2_speed.Text = "labelSpe";
            this.lbl2_speed.Click += new System.EventHandler(this.lbl_speed_Click);
            // 
            // lbl2_humidity
            // 
            this.lbl2_humidity.AutoSize = true;
            this.lbl2_humidity.Location = new System.Drawing.Point(839, 232);
            this.lbl2_humidity.Name = "lbl2_humidity";
            this.lbl2_humidity.Size = new System.Drawing.Size(43, 13);
            this.lbl2_humidity.TabIndex = 13;
            this.lbl2_humidity.Text = "labelHu";
            this.lbl2_humidity.Click += new System.EventHandler(this.lbl_humidity_Click);
            // 
            // lbl2_tempelatura
            // 
            this.lbl2_tempelatura.AutoSize = true;
            this.lbl2_tempelatura.Location = new System.Drawing.Point(839, 148);
            this.lbl2_tempelatura.Name = "lbl2_tempelatura";
            this.lbl2_tempelatura.Size = new System.Drawing.Size(56, 13);
            this.lbl2_tempelatura.TabIndex = 14;
            this.lbl2_tempelatura.Text = "labelTemp";
            this.lbl2_tempelatura.Click += new System.EventHandler(this.lbl_tempelatura_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 430);
            this.Controls.Add(this.lbl2_tempelatura);
            this.Controls.Add(this.lbl2_humidity);
            this.Controls.Add(this.lbl2_speed);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.Humidity);
            this.Controls.Add(this.lbl2_pressure);
            this.Controls.Add(this.lbl_temperatura);
            this.Controls.Add(this.Pressure);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.lbl_Forcast);
            this.Controls.Add(this.lbl_Temp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_country);
            this.Controls.Add(this.lbl_cityName);
            this.Name = "Form1";
            this.Text = "temperatura";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cityName;
        private System.Windows.Forms.Label lbl_country;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Temp;
        private System.Windows.Forms.Label lbl_Forcast;
        private System.Windows.Forms.Label Day;
        private System.Windows.Forms.Label Pressure;
        private System.Windows.Forms.Label lbl_temperatura;
        private System.Windows.Forms.Label lbl2_pressure;
        private System.Windows.Forms.Label Humidity;
        private System.Windows.Forms.Label Speed;
        private System.Windows.Forms.Label lbl2_speed;
        private System.Windows.Forms.Label lbl2_humidity;
        private System.Windows.Forms.Label lbl2_tempelatura;
    }
}


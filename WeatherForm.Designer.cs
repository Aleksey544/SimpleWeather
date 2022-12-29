namespace SimpleWeather
{
    partial class WeatherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherForm));
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CurrentCityLabel = new System.Windows.Forms.Label();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.FellsTemperatureLabel = new System.Windows.Forms.Label();
            this.MinTemperatureLabel = new System.Windows.Forms.Label();
            this.MaxTemperatureLabel = new System.Windows.Forms.Label();
            this.PressureLabel = new System.Windows.Forms.Label();
            this.HumidityLabel = new System.Windows.Forms.Label();
            this.WeatherConditionsLabel = new System.Windows.Forms.Label();
            this.CloudyLabel = new System.Windows.Forms.Label();
            this.SpeedWindLabel = new System.Windows.Forms.Label();
            this.VisibilityLabel = new System.Windows.Forms.Label();
            this.WeatherShowPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherShowPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.BackColor = System.Drawing.Color.Yellow;
            this.InputTextBox.Font = new System.Drawing.Font("Consolas", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTextBox.ForeColor = System.Drawing.Color.Black;
            this.InputTextBox.Location = new System.Drawing.Point(103, 12);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(297, 46);
            this.InputTextBox.TabIndex = 0;
            this.InputTextBox.Text = "Введите город...";
            this.InputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBox_KeyPress);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.Cyan;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitButton.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SubmitButton.Location = new System.Drawing.Point(146, 55);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(213, 42);
            this.SubmitButton.TabIndex = 1;
            this.SubmitButton.Text = "УЗНАТЬ ПОГОДУ";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CurrentCityLabel
            // 
            this.CurrentCityLabel.AutoSize = true;
            this.CurrentCityLabel.BackColor = System.Drawing.Color.Transparent;
            this.CurrentCityLabel.Font = new System.Drawing.Font("Franklin Gothic Heavy", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentCityLabel.ForeColor = System.Drawing.Color.White;
            this.CurrentCityLabel.Location = new System.Drawing.Point(12, 128);
            this.CurrentCityLabel.Name = "CurrentCityLabel";
            this.CurrentCityLabel.Size = new System.Drawing.Size(264, 38);
            this.CurrentCityLabel.TabIndex = 2;
            this.CurrentCityLabel.Text = "Текущий город:";
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.BackColor = System.Drawing.Color.Transparent;
            this.TemperatureLabel.Font = new System.Drawing.Font("Franklin Gothic Heavy", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TemperatureLabel.ForeColor = System.Drawing.Color.White;
            this.TemperatureLabel.Location = new System.Drawing.Point(12, 175);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(232, 38);
            this.TemperatureLabel.TabIndex = 3;
            this.TemperatureLabel.Text = "Температура:";
            // 
            // FellsTemperatureLabel
            // 
            this.FellsTemperatureLabel.AutoSize = true;
            this.FellsTemperatureLabel.BackColor = System.Drawing.Color.Transparent;
            this.FellsTemperatureLabel.Font = new System.Drawing.Font("Franklin Gothic Heavy", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FellsTemperatureLabel.ForeColor = System.Drawing.Color.White;
            this.FellsTemperatureLabel.Location = new System.Drawing.Point(12, 222);
            this.FellsTemperatureLabel.Name = "FellsTemperatureLabel";
            this.FellsTemperatureLabel.Size = new System.Drawing.Size(211, 38);
            this.FellsTemperatureLabel.TabIndex = 4;
            this.FellsTemperatureLabel.Text = "Ощущается:";
            // 
            // MinTemperatureLabel
            // 
            this.MinTemperatureLabel.AutoSize = true;
            this.MinTemperatureLabel.BackColor = System.Drawing.Color.Transparent;
            this.MinTemperatureLabel.Font = new System.Drawing.Font("Franklin Gothic Heavy", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinTemperatureLabel.ForeColor = System.Drawing.Color.White;
            this.MinTemperatureLabel.Location = new System.Drawing.Point(12, 269);
            this.MinTemperatureLabel.Name = "MinTemperatureLabel";
            this.MinTemperatureLabel.Size = new System.Drawing.Size(231, 38);
            this.MinTemperatureLabel.TabIndex = 5;
            this.MinTemperatureLabel.Text = "Минимально:";
            // 
            // MaxTemperatureLabel
            // 
            this.MaxTemperatureLabel.AutoSize = true;
            this.MaxTemperatureLabel.BackColor = System.Drawing.Color.Transparent;
            this.MaxTemperatureLabel.Font = new System.Drawing.Font("Franklin Gothic Heavy", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxTemperatureLabel.ForeColor = System.Drawing.Color.White;
            this.MaxTemperatureLabel.Location = new System.Drawing.Point(12, 316);
            this.MaxTemperatureLabel.Name = "MaxTemperatureLabel";
            this.MaxTemperatureLabel.Size = new System.Drawing.Size(247, 38);
            this.MaxTemperatureLabel.TabIndex = 6;
            this.MaxTemperatureLabel.Text = "Максимально:";
            // 
            // PressureLabel
            // 
            this.PressureLabel.AutoSize = true;
            this.PressureLabel.BackColor = System.Drawing.Color.Transparent;
            this.PressureLabel.Font = new System.Drawing.Font("Franklin Gothic Heavy", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PressureLabel.ForeColor = System.Drawing.Color.White;
            this.PressureLabel.Location = new System.Drawing.Point(12, 555);
            this.PressureLabel.Name = "PressureLabel";
            this.PressureLabel.Size = new System.Drawing.Size(178, 38);
            this.PressureLabel.TabIndex = 7;
            this.PressureLabel.Text = "Давление:";
            // 
            // HumidityLabel
            // 
            this.HumidityLabel.AutoSize = true;
            this.HumidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.HumidityLabel.Font = new System.Drawing.Font("Franklin Gothic Heavy", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HumidityLabel.ForeColor = System.Drawing.Color.White;
            this.HumidityLabel.Location = new System.Drawing.Point(12, 363);
            this.HumidityLabel.Name = "HumidityLabel";
            this.HumidityLabel.Size = new System.Drawing.Size(197, 38);
            this.HumidityLabel.TabIndex = 8;
            this.HumidityLabel.Text = "Влажность:";
            // 
            // WeatherConditionsLabel
            // 
            this.WeatherConditionsLabel.AutoSize = true;
            this.WeatherConditionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.WeatherConditionsLabel.Font = new System.Drawing.Font("Franklin Gothic Heavy", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeatherConditionsLabel.ForeColor = System.Drawing.Color.White;
            this.WeatherConditionsLabel.Location = new System.Drawing.Point(12, 603);
            this.WeatherConditionsLabel.Name = "WeatherConditionsLabel";
            this.WeatherConditionsLabel.Size = new System.Drawing.Size(155, 38);
            this.WeatherConditionsLabel.TabIndex = 9;
            this.WeatherConditionsLabel.Text = "Условия:";
            // 
            // CloudyLabel
            // 
            this.CloudyLabel.AutoSize = true;
            this.CloudyLabel.BackColor = System.Drawing.Color.Transparent;
            this.CloudyLabel.Font = new System.Drawing.Font("Franklin Gothic Heavy", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloudyLabel.ForeColor = System.Drawing.Color.White;
            this.CloudyLabel.Location = new System.Drawing.Point(12, 410);
            this.CloudyLabel.Name = "CloudyLabel";
            this.CloudyLabel.Size = new System.Drawing.Size(210, 38);
            this.CloudyLabel.TabIndex = 10;
            this.CloudyLabel.Text = "Облачность:";
            // 
            // SpeedWindLabel
            // 
            this.SpeedWindLabel.AutoSize = true;
            this.SpeedWindLabel.BackColor = System.Drawing.Color.Transparent;
            this.SpeedWindLabel.Font = new System.Drawing.Font("Franklin Gothic Heavy", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpeedWindLabel.ForeColor = System.Drawing.Color.White;
            this.SpeedWindLabel.Location = new System.Drawing.Point(12, 458);
            this.SpeedWindLabel.Name = "SpeedWindLabel";
            this.SpeedWindLabel.Size = new System.Drawing.Size(272, 38);
            this.SpeedWindLabel.TabIndex = 11;
            this.SpeedWindLabel.Text = "Скорость ветра:";
            // 
            // VisibilityLabel
            // 
            this.VisibilityLabel.AutoSize = true;
            this.VisibilityLabel.BackColor = System.Drawing.Color.Transparent;
            this.VisibilityLabel.Font = new System.Drawing.Font("Franklin Gothic Heavy", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisibilityLabel.ForeColor = System.Drawing.Color.White;
            this.VisibilityLabel.Location = new System.Drawing.Point(12, 507);
            this.VisibilityLabel.Name = "VisibilityLabel";
            this.VisibilityLabel.Size = new System.Drawing.Size(199, 38);
            this.VisibilityLabel.TabIndex = 12;
            this.VisibilityLabel.Text = "Видимость:";
            // 
            // WeatherShowPictureBox
            // 
            this.WeatherShowPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.WeatherShowPictureBox.InitialImage = null;
            this.WeatherShowPictureBox.Location = new System.Drawing.Point(318, 175);
            this.WeatherShowPictureBox.Name = "WeatherShowPictureBox";
            this.WeatherShowPictureBox.Size = new System.Drawing.Size(157, 179);
            this.WeatherShowPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WeatherShowPictureBox.TabIndex = 13;
            this.WeatherShowPictureBox.TabStop = false;
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(496, 661);
            this.Controls.Add(this.WeatherShowPictureBox);
            this.Controls.Add(this.VisibilityLabel);
            this.Controls.Add(this.SpeedWindLabel);
            this.Controls.Add(this.CloudyLabel);
            this.Controls.Add(this.WeatherConditionsLabel);
            this.Controls.Add(this.HumidityLabel);
            this.Controls.Add(this.PressureLabel);
            this.Controls.Add(this.MaxTemperatureLabel);
            this.Controls.Add(this.MinTemperatureLabel);
            this.Controls.Add(this.FellsTemperatureLabel);
            this.Controls.Add(this.TemperatureLabel);
            this.Controls.Add(this.CurrentCityLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.InputTextBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WeatherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Простой погодник";
            ((System.ComponentModel.ISupportInitialize)(this.WeatherShowPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label CurrentCityLabel;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.Label FellsTemperatureLabel;
        private System.Windows.Forms.Label MinTemperatureLabel;
        private System.Windows.Forms.Label MaxTemperatureLabel;
        private System.Windows.Forms.Label PressureLabel;
        private System.Windows.Forms.Label HumidityLabel;
        private System.Windows.Forms.Label WeatherConditionsLabel;
        private System.Windows.Forms.Label CloudyLabel;
        private System.Windows.Forms.Label SpeedWindLabel;
        private System.Windows.Forms.Label VisibilityLabel;
        private System.Windows.Forms.PictureBox WeatherShowPictureBox;
    }
}


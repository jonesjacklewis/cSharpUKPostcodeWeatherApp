namespace cSharpWeatherApp
{
    partial class formDetails
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
            this.pbWeatherIcon = new System.Windows.Forms.PictureBox();
            this.lblTempValue = new System.Windows.Forms.Label();
            this.lblTempUnit = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblWind = new System.Windows.Forms.Label();
            this.lblHumidityValue = new System.Windows.Forms.Label();
            this.lblWindValue = new System.Windows.Forms.Label();
            this.btnCelsius = new System.Windows.Forms.Button();
            this.btnFahrenheit = new System.Windows.Forms.Button();
            this.btnKelvin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblWeatherDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pbWeatherIcon
            // 
            this.pbWeatherIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbWeatherIcon.Location = new System.Drawing.Point(183, 98);
            this.pbWeatherIcon.Name = "pbWeatherIcon";
            this.pbWeatherIcon.Size = new System.Drawing.Size(100, 50);
            this.pbWeatherIcon.TabIndex = 0;
            this.pbWeatherIcon.TabStop = false;
            // 
            // lblTempValue
            // 
            this.lblTempValue.AutoSize = true;
            this.lblTempValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTempValue.Location = new System.Drawing.Point(327, 98);
            this.lblTempValue.Name = "lblTempValue";
            this.lblTempValue.Size = new System.Drawing.Size(32, 25);
            this.lblTempValue.TabIndex = 1;
            this.lblTempValue.Text = "00";
            // 
            // lblTempUnit
            // 
            this.lblTempUnit.AutoSize = true;
            this.lblTempUnit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTempUnit.Location = new System.Drawing.Point(365, 98);
            this.lblTempUnit.Name = "lblTempUnit";
            this.lblTempUnit.Size = new System.Drawing.Size(32, 25);
            this.lblTempUnit.TabIndex = 2;
            this.lblTempUnit.Text = "*C";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocation.Location = new System.Drawing.Point(140, 9);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(327, 65);
            this.lblLocation.TabIndex = 3;
            this.lblLocation.Text = "Weather at {{}}";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Location = new System.Drawing.Point(40, 247);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(57, 15);
            this.lblHumidity.TabIndex = 5;
            this.lblHumidity.Text = "Humidity";
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.Location = new System.Drawing.Point(40, 284);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(35, 15);
            this.lblWind.TabIndex = 6;
            this.lblWind.Text = "Wind";
            // 
            // lblHumidityValue
            // 
            this.lblHumidityValue.AutoSize = true;
            this.lblHumidityValue.Location = new System.Drawing.Point(123, 247);
            this.lblHumidityValue.Name = "lblHumidityValue";
            this.lblHumidityValue.Size = new System.Drawing.Size(29, 15);
            this.lblHumidityValue.TabIndex = 8;
            this.lblHumidityValue.Text = "00%";
            // 
            // lblWindValue
            // 
            this.lblWindValue.AutoSize = true;
            this.lblWindValue.Location = new System.Drawing.Point(123, 284);
            this.lblWindValue.Name = "lblWindValue";
            this.lblWindValue.Size = new System.Drawing.Size(47, 15);
            this.lblWindValue.TabIndex = 9;
            this.lblWindValue.Text = "00 mph";
            // 
            // btnCelsius
            // 
            this.btnCelsius.Location = new System.Drawing.Point(402, 198);
            this.btnCelsius.Name = "btnCelsius";
            this.btnCelsius.Size = new System.Drawing.Size(75, 23);
            this.btnCelsius.TabIndex = 10;
            this.btnCelsius.Text = "Celsius";
            this.btnCelsius.UseVisualStyleBackColor = true;
            this.btnCelsius.Click += new System.EventHandler(this.btnCelsius_Click);
            // 
            // btnFahrenheit
            // 
            this.btnFahrenheit.Location = new System.Drawing.Point(402, 245);
            this.btnFahrenheit.Name = "btnFahrenheit";
            this.btnFahrenheit.Size = new System.Drawing.Size(75, 23);
            this.btnFahrenheit.TabIndex = 11;
            this.btnFahrenheit.Text = "Fahrenheit";
            this.btnFahrenheit.UseVisualStyleBackColor = true;
            this.btnFahrenheit.Click += new System.EventHandler(this.btnFahrenheit_Click);
            // 
            // btnKelvin
            // 
            this.btnKelvin.Location = new System.Drawing.Point(402, 284);
            this.btnKelvin.Name = "btnKelvin";
            this.btnKelvin.Size = new System.Drawing.Size(75, 23);
            this.btnKelvin.TabIndex = 12;
            this.btnKelvin.Text = "Kelvin";
            this.btnKelvin.UseVisualStyleBackColor = true;
            this.btnKelvin.Click += new System.EventHandler(this.btnKelvin_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(402, 332);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblWeatherDesc
            // 
            this.lblWeatherDesc.AutoSize = true;
            this.lblWeatherDesc.Location = new System.Drawing.Point(183, 169);
            this.lblWeatherDesc.Name = "lblWeatherDesc";
            this.lblWeatherDesc.Size = new System.Drawing.Size(78, 15);
            this.lblWeatherDesc.TabIndex = 14;
            this.lblWeatherDesc.Text = "weather_desc";
            // 
            // formDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.lblWeatherDesc);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnKelvin);
            this.Controls.Add(this.btnFahrenheit);
            this.Controls.Add(this.btnCelsius);
            this.Controls.Add(this.lblWindValue);
            this.Controls.Add(this.lblHumidityValue);
            this.Controls.Add(this.lblWind);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblTempUnit);
            this.Controls.Add(this.lblTempValue);
            this.Controls.Add(this.pbWeatherIcon);
            this.Name = "formDetails";
            this.Text = "Weather App | Details";
            this.Load += new System.EventHandler(this.formDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbWeatherIcon;
        private Label lblTempValue;
        private Label lblTempUnit;
        private Label lblLocation;
        private Label lblHumidity;
        private Label lblWind;
        private Label lblHumidityValue;
        private Label lblWindValue;
        private Button btnCelsius;
        private Button btnFahrenheit;
        private Button btnKelvin;
        private Button btnBack;
        private Label lblWeatherDesc;
    }
}
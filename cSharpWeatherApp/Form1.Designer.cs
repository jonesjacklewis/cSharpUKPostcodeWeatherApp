namespace cSharpWeatherApp
{
    partial class formLocation
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
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblWeather = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(183, 143);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(100, 23);
            this.txtPostcode.TabIndex = 0;
            this.txtPostcode.TextChanged += new System.EventHandler(this.txtPostcode_TextChanged);
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(36, 146);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(56, 15);
            this.lblPostcode.TabIndex = 1;
            this.lblPostcode.Text = "Postcode";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(183, 204);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Search";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWeather.Location = new System.Drawing.Point(110, 22);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(220, 65);
            this.lblWeather.TabIndex = 3;
            this.lblWeather.Text = "Weather";
            // 
            // formLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 341);
            this.Controls.Add(this.lblWeather);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.txtPostcode);
            this.MaximumSize = new System.Drawing.Size(450, 380);
            this.MinimumSize = new System.Drawing.Size(450, 380);
            this.Name = "formLocation";
            this.Text = "Weather App | Location";
            this.Load += new System.EventHandler(this.formLocation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPostcode;
        private Label lblPostcode;
        private Button btnSubmit;
        private Label lblWeather;
    }
}
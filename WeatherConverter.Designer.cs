
namespace TemperatureConversion
{
    partial class WeatherConverter
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
            this.txtBox_fahrenheit = new System.Windows.Forms.TextBox();
            this.txtBox_celsius = new System.Windows.Forms.TextBox();
            this.txtBox_kelvin = new System.Windows.Forms.TextBox();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.lblKelvin = new System.Windows.Forms.Label();
            this.btn_fahrenheitGo = new System.Windows.Forms.Button();
            this.btn_celsiusGo = new System.Windows.Forms.Button();
            this.btn_kelvinGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_fahrenheit
            // 
            this.txtBox_fahrenheit.Location = new System.Drawing.Point(78, 25);
            this.txtBox_fahrenheit.Name = "txtBox_fahrenheit";
            this.txtBox_fahrenheit.Size = new System.Drawing.Size(100, 20);
            this.txtBox_fahrenheit.TabIndex = 3;
            // 
            // txtBox_celsius
            // 
            this.txtBox_celsius.Location = new System.Drawing.Point(78, 55);
            this.txtBox_celsius.Name = "txtBox_celsius";
            this.txtBox_celsius.Size = new System.Drawing.Size(100, 20);
            this.txtBox_celsius.TabIndex = 4;
            // 
            // txtBox_kelvin
            // 
            this.txtBox_kelvin.Location = new System.Drawing.Point(78, 84);
            this.txtBox_kelvin.Name = "txtBox_kelvin";
            this.txtBox_kelvin.Size = new System.Drawing.Size(100, 20);
            this.txtBox_kelvin.TabIndex = 5;
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(15, 28);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(57, 13);
            this.lblFahrenheit.TabIndex = 6;
            this.lblFahrenheit.Text = "Fahrenheit";
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Location = new System.Drawing.Point(15, 58);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(40, 13);
            this.lblCelsius.TabIndex = 7;
            this.lblCelsius.Text = "Celsius";
            // 
            // lblKelvin
            // 
            this.lblKelvin.AutoSize = true;
            this.lblKelvin.Location = new System.Drawing.Point(15, 87);
            this.lblKelvin.Name = "lblKelvin";
            this.lblKelvin.Size = new System.Drawing.Size(36, 13);
            this.lblKelvin.TabIndex = 8;
            this.lblKelvin.Text = "Kelvin";
            // 
            // btn_fahrenheitGo
            // 
            this.btn_fahrenheitGo.Location = new System.Drawing.Point(196, 23);
            this.btn_fahrenheitGo.Name = "btn_fahrenheitGo";
            this.btn_fahrenheitGo.Size = new System.Drawing.Size(59, 23);
            this.btn_fahrenheitGo.TabIndex = 0;
            this.btn_fahrenheitGo.Text = "Go";
            this.btn_fahrenheitGo.UseVisualStyleBackColor = true;
            this.btn_fahrenheitGo.Click += new System.EventHandler(this.btn_fahrenheitGo_Click);
            // 
            // btn_celsiusGo
            // 
            this.btn_celsiusGo.Location = new System.Drawing.Point(196, 52);
            this.btn_celsiusGo.Name = "btn_celsiusGo";
            this.btn_celsiusGo.Size = new System.Drawing.Size(59, 23);
            this.btn_celsiusGo.TabIndex = 1;
            this.btn_celsiusGo.Text = "Go";
            this.btn_celsiusGo.UseVisualStyleBackColor = true;
            this.btn_celsiusGo.Click += new System.EventHandler(this.btn_celsiusGo_Click);
            // 
            // btn_kelvinGo
            // 
            this.btn_kelvinGo.Location = new System.Drawing.Point(196, 81);
            this.btn_kelvinGo.Name = "btn_kelvinGo";
            this.btn_kelvinGo.Size = new System.Drawing.Size(59, 23);
            this.btn_kelvinGo.TabIndex = 2;
            this.btn_kelvinGo.Text = "Go";
            this.btn_kelvinGo.UseVisualStyleBackColor = true;
            this.btn_kelvinGo.Click += new System.EventHandler(this.btn_kelvinGo_Click);
            // 
            // WeatherConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 137);
            this.Controls.Add(this.lblKelvin);
            this.Controls.Add(this.lblCelsius);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.txtBox_kelvin);
            this.Controls.Add(this.txtBox_celsius);
            this.Controls.Add(this.txtBox_fahrenheit);
            this.Controls.Add(this.btn_kelvinGo);
            this.Controls.Add(this.btn_celsiusGo);
            this.Controls.Add(this.btn_fahrenheitGo);
            this.Name = "WeatherConverter";
            this.Text = "Weather Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBox_fahrenheit;
        private System.Windows.Forms.TextBox txtBox_celsius;
        private System.Windows.Forms.TextBox txtBox_kelvin;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Label lblKelvin;
        private System.Windows.Forms.Button btn_fahrenheitGo;
        private System.Windows.Forms.Button btn_celsiusGo;
        private System.Windows.Forms.Button btn_kelvinGo;
    }
}


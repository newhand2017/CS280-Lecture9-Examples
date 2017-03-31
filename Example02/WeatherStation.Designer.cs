namespace Example02
{
    partial class WeatherStation
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
            this.components = new System.ComponentModel.Container();
            this.tempLabel = new System.Windows.Forms.Label();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.humidtyLabel = new System.Windows.Forms.Label();
            this.tempTextBox = new System.Windows.Forms.TextBox();
            this.pressureTextBox = new System.Windows.Forms.TextBox();
            this.humidtyTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.dataTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tempLabel.Location = new System.Drawing.Point(63, 44);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(44, 16);
            this.tempLabel.TabIndex = 0;
            this.tempLabel.Text = "Temp";
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.pressureLabel.Location = new System.Drawing.Point(214, 44);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(60, 16);
            this.pressureLabel.TabIndex = 0;
            this.pressureLabel.Text = "Pressure";
            // 
            // humidtyLabel
            // 
            this.humidtyLabel.AutoSize = true;
            this.humidtyLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.humidtyLabel.Location = new System.Drawing.Point(381, 44);
            this.humidtyLabel.Name = "humidtyLabel";
            this.humidtyLabel.Size = new System.Drawing.Size(52, 16);
            this.humidtyLabel.TabIndex = 0;
            this.humidtyLabel.Text = "umidty";
            // 
            // tempTextBox
            // 
            this.tempTextBox.Location = new System.Drawing.Point(37, 103);
            this.tempTextBox.Name = "tempTextBox";
            this.tempTextBox.Size = new System.Drawing.Size(100, 22);
            this.tempTextBox.TabIndex = 1;
            // 
            // pressureTextBox
            // 
            this.pressureTextBox.Location = new System.Drawing.Point(194, 103);
            this.pressureTextBox.Name = "pressureTextBox";
            this.pressureTextBox.Size = new System.Drawing.Size(100, 22);
            this.pressureTextBox.TabIndex = 2;
            // 
            // humidtyTextBox
            // 
            this.humidtyTextBox.Location = new System.Drawing.Point(354, 103);
            this.humidtyTextBox.Name = "humidtyTextBox";
            this.humidtyTextBox.Size = new System.Drawing.Size(100, 22);
            this.humidtyTextBox.TabIndex = 3;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("新細明體", 12F);
            this.startButton.Location = new System.Drawing.Point(523, 92);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(83, 33);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Star";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.messageLabel.Location = new System.Drawing.Point(37, 168);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(569, 166);
            this.messageLabel.TabIndex = 6;
            this.messageLabel.Text = "Message";
            // 
            // dataTimer
            // 
            this.dataTimer.Tick += new System.EventHandler(this.dataTimer_Tick);
            // 
            // WeatherStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 782);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.humidtyTextBox);
            this.Controls.Add(this.pressureTextBox);
            this.Controls.Add(this.tempTextBox);
            this.Controls.Add(this.humidtyLabel);
            this.Controls.Add(this.pressureLabel);
            this.Controls.Add(this.tempLabel);
            this.Name = "WeatherStation";
            this.Text = "WeatherStation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.Label humidtyLabel;
        private System.Windows.Forms.TextBox tempTextBox;
        private System.Windows.Forms.TextBox pressureTextBox;
        private System.Windows.Forms.TextBox humidtyTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label messageLabel;
        public System.Windows.Forms.Timer dataTimer;
    }
}
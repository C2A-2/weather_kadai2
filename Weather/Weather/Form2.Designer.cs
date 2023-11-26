namespace Weather
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.titelLabel = new System.Windows.Forms.Label();
            this.weatherCodelabel = new System.Windows.Forms.Label();
            this.temMaxlabel = new System.Windows.Forms.Label();
            this.temMinLabel = new System.Windows.Forms.Label();
            this.windSpeedLabel = new System.Windows.Forms.Label();
            this.rainFallParLabel = new System.Windows.Forms.Label();
            this.uvLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HGS明朝E", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(398, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "☺たくくんのおてんきよほう☺";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(71, 182);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(44, 18);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "日付";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // titelLabel
            // 
            this.titelLabel.AutoSize = true;
            this.titelLabel.Font = new System.Drawing.Font("MS UI Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titelLabel.Location = new System.Drawing.Point(392, 98);
            this.titelLabel.Name = "titelLabel";
            this.titelLabel.Size = new System.Drawing.Size(165, 56);
            this.titelLabel.TabIndex = 3;
            this.titelLabel.Text = "label2";
            // 
            // weatherCodelabel
            // 
            this.weatherCodelabel.AutoSize = true;
            this.weatherCodelabel.Location = new System.Drawing.Point(242, 182);
            this.weatherCodelabel.Name = "weatherCodelabel";
            this.weatherCodelabel.Size = new System.Drawing.Size(44, 18);
            this.weatherCodelabel.TabIndex = 4;
            this.weatherCodelabel.Text = "天気";
            this.weatherCodelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // temMaxlabel
            // 
            this.temMaxlabel.AutoSize = true;
            this.temMaxlabel.Location = new System.Drawing.Point(399, 182);
            this.temMaxlabel.Name = "temMaxlabel";
            this.temMaxlabel.Size = new System.Drawing.Size(80, 18);
            this.temMaxlabel.TabIndex = 5;
            this.temMaxlabel.Text = "最高気温";
            this.temMaxlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // temMinLabel
            // 
            this.temMinLabel.AutoSize = true;
            this.temMinLabel.Location = new System.Drawing.Point(564, 182);
            this.temMinLabel.Name = "temMinLabel";
            this.temMinLabel.Size = new System.Drawing.Size(80, 18);
            this.temMinLabel.TabIndex = 6;
            this.temMinLabel.Text = "最低気温";
            this.temMinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // windSpeedLabel
            // 
            this.windSpeedLabel.AutoSize = true;
            this.windSpeedLabel.Location = new System.Drawing.Point(745, 182);
            this.windSpeedLabel.Name = "windSpeedLabel";
            this.windSpeedLabel.Size = new System.Drawing.Size(44, 18);
            this.windSpeedLabel.TabIndex = 7;
            this.windSpeedLabel.Text = "風速";
            this.windSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rainFallParLabel
            // 
            this.rainFallParLabel.AutoSize = true;
            this.rainFallParLabel.Location = new System.Drawing.Point(913, 182);
            this.rainFallParLabel.Name = "rainFallParLabel";
            this.rainFallParLabel.Size = new System.Drawing.Size(80, 18);
            this.rainFallParLabel.TabIndex = 8;
            this.rainFallParLabel.Text = "降水確率";
            this.rainFallParLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uvLabel
            // 
            this.uvLabel.AutoSize = true;
            this.uvLabel.Location = new System.Drawing.Point(1088, 182);
            this.uvLabel.Name = "uvLabel";
            this.uvLabel.Size = new System.Drawing.Size(62, 18);
            this.uvLabel.TabIndex = 9;
            this.uvLabel.Text = "紫外線";
            this.uvLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.closeButton.Location = new System.Drawing.Point(916, 482);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(151, 73);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "閉じる";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 563);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.uvLabel);
            this.Controls.Add(this.rainFallParLabel);
            this.Controls.Add(this.windSpeedLabel);
            this.Controls.Add(this.temMinLabel);
            this.Controls.Add(this.temMaxlabel);
            this.Controls.Add(this.weatherCodelabel);
            this.Controls.Add(this.titelLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label titelLabel;
        private System.Windows.Forms.Label weatherCodelabel;
        private System.Windows.Forms.Label temMaxlabel;
        private System.Windows.Forms.Label temMinLabel;
        private System.Windows.Forms.Label windSpeedLabel;
        private System.Windows.Forms.Label rainFallParLabel;
        private System.Windows.Forms.Label uvLabel;
        private System.Windows.Forms.Button closeButton;
    }
}
namespace Weather
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.latBox = new System.Windows.Forms.TextBox();
            this.lonBox = new System.Windows.Forms.TextBox();
            this.maxtemCheckBox = new System.Windows.Forms.CheckBox();
            this.mintemCheckBox = new System.Windows.Forms.CheckBox();
            this.winspCheckBox = new System.Windows.Forms.CheckBox();
            this.startButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.rainFallParCheckBox = new System.Windows.Forms.CheckBox();
            this.uvCheckBox = new System.Windows.Forms.CheckBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.CIEComboBox = new System.Windows.Forms.ComboBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.timezonecomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HGS明朝E", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(203, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "☺たくくんのおてんきよほう☺";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(24, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "緯度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(24, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "経度";
            // 
            // latBox
            // 
            this.latBox.Location = new System.Drawing.Point(90, 162);
            this.latBox.Name = "latBox";
            this.latBox.Size = new System.Drawing.Size(179, 25);
            this.latBox.TabIndex = 3;
            this.latBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lonBox
            // 
            this.lonBox.Location = new System.Drawing.Point(90, 214);
            this.lonBox.Name = "lonBox";
            this.lonBox.Size = new System.Drawing.Size(179, 25);
            this.lonBox.TabIndex = 4;
            this.lonBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // maxtemCheckBox
            // 
            this.maxtemCheckBox.AutoSize = true;
            this.maxtemCheckBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.maxtemCheckBox.Location = new System.Drawing.Point(28, 311);
            this.maxtemCheckBox.Name = "maxtemCheckBox";
            this.maxtemCheckBox.Size = new System.Drawing.Size(136, 28);
            this.maxtemCheckBox.TabIndex = 8;
            this.maxtemCheckBox.Text = "最高気温";
            this.maxtemCheckBox.UseVisualStyleBackColor = true;
            // 
            // mintemCheckBox
            // 
            this.mintemCheckBox.AutoSize = true;
            this.mintemCheckBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mintemCheckBox.Location = new System.Drawing.Point(189, 311);
            this.mintemCheckBox.Name = "mintemCheckBox";
            this.mintemCheckBox.Size = new System.Drawing.Size(136, 28);
            this.mintemCheckBox.TabIndex = 9;
            this.mintemCheckBox.Text = "最低気温";
            this.mintemCheckBox.UseVisualStyleBackColor = true;
            // 
            // winspCheckBox
            // 
            this.winspCheckBox.AutoSize = true;
            this.winspCheckBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.winspCheckBox.Location = new System.Drawing.Point(535, 311);
            this.winspCheckBox.Name = "winspCheckBox";
            this.winspCheckBox.Size = new System.Drawing.Size(86, 28);
            this.winspCheckBox.TabIndex = 10;
            this.winspCheckBox.Text = "風速";
            this.winspCheckBox.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startButton.Location = new System.Drawing.Point(28, 379);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(308, 60);
            this.startButton.TabIndex = 11;
            this.startButton.Text = "実行";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.resetButton.Location = new System.Drawing.Point(387, 379);
            this.resetButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(173, 62);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "リセット";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // rainFallParCheckBox
            // 
            this.rainFallParCheckBox.AutoSize = true;
            this.rainFallParCheckBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rainFallParCheckBox.Location = new System.Drawing.Point(355, 311);
            this.rainFallParCheckBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rainFallParCheckBox.Name = "rainFallParCheckBox";
            this.rainFallParCheckBox.Size = new System.Drawing.Size(136, 28);
            this.rainFallParCheckBox.TabIndex = 13;
            this.rainFallParCheckBox.Text = "降水確率";
            this.rainFallParCheckBox.UseVisualStyleBackColor = true;
            // 
            // uvCheckBox
            // 
            this.uvCheckBox.AutoSize = true;
            this.uvCheckBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.uvCheckBox.Location = new System.Drawing.Point(670, 311);
            this.uvCheckBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uvCheckBox.Name = "uvCheckBox";
            this.uvCheckBox.Size = new System.Drawing.Size(111, 28);
            this.uvCheckBox.TabIndex = 15;
            this.uvCheckBox.Text = "紫外線";
            this.uvCheckBox.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.exitButton.Location = new System.Drawing.Point(613, 381);
            this.exitButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(168, 60);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "終了";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CIEComboBox
            // 
            this.CIEComboBox.FormattingEnabled = true;
            this.CIEComboBox.Items.AddRange(new object[] {
            "東京",
            "シンガポール",
            "シドニー",
            "ニューヨーク",
            "シカゴ",
            "ロサンゼルス",
            "ベルリン",
            "ロンドン",
            "モスクワ"});
            this.CIEComboBox.Location = new System.Drawing.Point(612, 187);
            this.CIEComboBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CIEComboBox.Name = "CIEComboBox";
            this.CIEComboBox.Size = new System.Drawing.Size(169, 26);
            this.CIEComboBox.TabIndex = 17;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // timezonecomboBox
            // 
            this.timezonecomboBox.FormattingEnabled = true;
            this.timezonecomboBox.Items.AddRange(new object[] {
            "東京",
            "シンガポール",
            "シドニー",
            "ニューヨーク",
            "シカゴ",
            "ロサンゼルス",
            "ベルリン",
            "ロンドン",
            "モスクワ"});
            this.timezonecomboBox.Location = new System.Drawing.Point(612, 101);
            this.timezonecomboBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.timezonecomboBox.Name = "timezonecomboBox";
            this.timezonecomboBox.Size = new System.Drawing.Size(169, 26);
            this.timezonecomboBox.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(309, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "1つ以上選択";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(459, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "タイムゾーン";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(531, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "首都";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(286, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 28);
            this.label7.TabIndex = 23;
            this.label7.Text = "←どちらか入力→";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 500);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timezonecomboBox);
            this.Controls.Add(this.CIEComboBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.uvCheckBox);
            this.Controls.Add(this.rainFallParCheckBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.winspCheckBox);
            this.Controls.Add(this.mintemCheckBox);
            this.Controls.Add(this.maxtemCheckBox);
            this.Controls.Add(this.lonBox);
            this.Controls.Add(this.latBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "天気予報";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox latBox;
        private System.Windows.Forms.TextBox lonBox;
        private System.Windows.Forms.CheckBox maxtemCheckBox;
        private System.Windows.Forms.CheckBox mintemCheckBox;
        private System.Windows.Forms.CheckBox winspCheckBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.CheckBox rainFallParCheckBox;
        private System.Windows.Forms.CheckBox uvCheckBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox CIEComboBox;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ComboBox timezonecomboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}


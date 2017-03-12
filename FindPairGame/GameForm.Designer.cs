namespace FindPairGame
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.sizeChoise = new System.Windows.Forms.GroupBox();
            this.largeSize = new System.Windows.Forms.RadioButton();
            this.mediumSize = new System.Windows.Forms.RadioButton();
            this.smallSize = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.exitToMain = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.hiscoreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.tryLabel = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.resetHiscore = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryChoise = new System.Windows.Forms.GroupBox();
            this.Fruits = new System.Windows.Forms.RadioButton();
            this.Animals = new System.Windows.Forms.RadioButton();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.restartButton = new System.Windows.Forms.Button();
            this.congaratLabel = new System.Windows.Forms.Label();
            this.sizeChoise.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.categoryChoise.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sizeChoise
            // 
            this.sizeChoise.BackColor = System.Drawing.Color.Transparent;
            this.sizeChoise.Controls.Add(this.largeSize);
            this.sizeChoise.Controls.Add(this.mediumSize);
            this.sizeChoise.Controls.Add(this.smallSize);
            this.sizeChoise.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.sizeChoise.Location = new System.Drawing.Point(40, 25);
            this.sizeChoise.Name = "sizeChoise";
            this.sizeChoise.Size = new System.Drawing.Size(146, 153);
            this.sizeChoise.TabIndex = 7;
            this.sizeChoise.TabStop = false;
            this.sizeChoise.Text = "Size";
            // 
            // largeSize
            // 
            this.largeSize.AutoSize = true;
            this.largeSize.Location = new System.Drawing.Point(29, 109);
            this.largeSize.Name = "largeSize";
            this.largeSize.Size = new System.Drawing.Size(80, 29);
            this.largeSize.TabIndex = 2;
            this.largeSize.TabStop = true;
            this.largeSize.Text = "Large";
            this.largeSize.UseVisualStyleBackColor = true;
            // 
            // mediumSize
            // 
            this.mediumSize.AutoSize = true;
            this.mediumSize.Location = new System.Drawing.Point(29, 78);
            this.mediumSize.Name = "mediumSize";
            this.mediumSize.Size = new System.Drawing.Size(100, 29);
            this.mediumSize.TabIndex = 1;
            this.mediumSize.TabStop = true;
            this.mediumSize.Text = "Medium";
            this.mediumSize.UseVisualStyleBackColor = true;
            // 
            // smallSize
            // 
            this.smallSize.Location = new System.Drawing.Point(29, 44);
            this.smallSize.Name = "smallSize";
            this.smallSize.Size = new System.Drawing.Size(80, 28);
            this.smallSize.TabIndex = 0;
            this.smallSize.TabStop = true;
            this.smallSize.Text = "Small";
            this.smallSize.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(214)))), ((int)(((byte)(209)))));
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.startButton.Location = new System.Drawing.Point(40, 303);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(350, 84);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Play";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitToMain
            // 
            this.exitToMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(234)))));
            this.exitToMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(213)))));
            this.exitToMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(223)))));
            this.exitToMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitToMain.Location = new System.Drawing.Point(3, 69);
            this.exitToMain.Name = "exitToMain";
            this.exitToMain.Size = new System.Drawing.Size(102, 48);
            this.exitToMain.TabIndex = 30;
            this.exitToMain.TabStop = false;
            this.exitToMain.Text = "Exit to main menu";
            this.exitToMain.UseVisualStyleBackColor = false;
            this.exitToMain.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(56, 164);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(29, 34);
            this.scoreLabel.TabIndex = 11;
            this.scoreLabel.Text = "0";
            // 
            // hiscoreLabel
            // 
            this.hiscoreLabel.AutoSize = true;
            this.hiscoreLabel.Font = new System.Drawing.Font("Impact", 20F);
            this.hiscoreLabel.Location = new System.Drawing.Point(56, 276);
            this.hiscoreLabel.Name = "hiscoreLabel";
            this.hiscoreLabel.Size = new System.Drawing.Size(29, 34);
            this.hiscoreLabel.TabIndex = 12;
            this.hiscoreLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Score :";
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.Transparent;
            this.gamePanel.Controls.Add(this.tryLabel);
            this.gamePanel.Controls.Add(this.Label);
            this.gamePanel.Controls.Add(this.resetHiscore);
            this.gamePanel.Controls.Add(this.label2);
            this.gamePanel.Controls.Add(this.hiscoreLabel);
            this.gamePanel.Controls.Add(this.label1);
            this.gamePanel.Controls.Add(this.scoreLabel);
            this.gamePanel.Controls.Add(this.exitToMain);
            this.gamePanel.Location = new System.Drawing.Point(646, 12);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(126, 426);
            this.gamePanel.TabIndex = 14;
            this.gamePanel.Visible = false;
            // 
            // tryLabel
            // 
            this.tryLabel.AutoSize = true;
            this.tryLabel.Font = new System.Drawing.Font("Impact", 20F);
            this.tryLabel.Location = new System.Drawing.Point(56, 221);
            this.tryLabel.Name = "tryLabel";
            this.tryLabel.Size = new System.Drawing.Size(29, 34);
            this.tryLabel.TabIndex = 17;
            this.tryLabel.Text = "0";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(3, 238);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(42, 13);
            this.Label.TabIndex = 16;
            this.Label.Text = "Trying :";
            // 
            // resetHiscore
            // 
            this.resetHiscore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(234)))));
            this.resetHiscore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(213)))));
            this.resetHiscore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(223)))));
            this.resetHiscore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetHiscore.Location = new System.Drawing.Point(3, 343);
            this.resetHiscore.Name = "resetHiscore";
            this.resetHiscore.Size = new System.Drawing.Size(102, 48);
            this.resetHiscore.TabIndex = 30;
            this.resetHiscore.TabStop = false;
            this.resetHiscore.Text = "Reset hiscore";
            this.resetHiscore.UseVisualStyleBackColor = false;
            this.resetHiscore.Click += new System.EventHandler(this.resetHiscore_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hiscore :";
            // 
            // categoryChoise
            // 
            this.categoryChoise.BackColor = System.Drawing.Color.Transparent;
            this.categoryChoise.Controls.Add(this.Fruits);
            this.categoryChoise.Controls.Add(this.Animals);
            this.categoryChoise.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.categoryChoise.Location = new System.Drawing.Point(244, 25);
            this.categoryChoise.Name = "categoryChoise";
            this.categoryChoise.Size = new System.Drawing.Size(146, 153);
            this.categoryChoise.TabIndex = 15;
            this.categoryChoise.TabStop = false;
            this.categoryChoise.Text = "Category";
            // 
            // Fruits
            // 
            this.Fruits.AutoSize = true;
            this.Fruits.Checked = true;
            this.Fruits.Location = new System.Drawing.Point(23, 44);
            this.Fruits.Name = "Fruits";
            this.Fruits.Size = new System.Drawing.Size(78, 29);
            this.Fruits.TabIndex = 1;
            this.Fruits.TabStop = true;
            this.Fruits.Text = "Fruits";
            this.Fruits.UseVisualStyleBackColor = true;
            // 
            // Animals
            // 
            this.Animals.AutoSize = true;
            this.Animals.Location = new System.Drawing.Point(23, 74);
            this.Animals.Name = "Animals";
            this.Animals.Size = new System.Drawing.Size(100, 29);
            this.Animals.TabIndex = 0;
            this.Animals.Text = "Animals";
            this.Animals.UseVisualStyleBackColor = true;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Transparent;
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menuPanel.Controls.Add(this.categoryChoise);
            this.menuPanel.Controls.Add(this.sizeChoise);
            this.menuPanel.Controls.Add(this.startButton);
            this.menuPanel.Location = new System.Drawing.Point(175, 140);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(429, 414);
            this.menuPanel.TabIndex = 16;
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.Transparent;
            this.restartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(213)))));
            this.restartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(223)))));
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.restartButton.Location = new System.Drawing.Point(220, 180);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(200, 200);
            this.restartButton.TabIndex = 17;
            this.restartButton.Text = "♕\r\nRestart";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Visible = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // congaratLabel
            // 
            this.congaratLabel.AutoSize = true;
            this.congaratLabel.BackColor = System.Drawing.Color.Transparent;
            this.congaratLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.congaratLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.congaratLabel.Location = new System.Drawing.Point(216, 107);
            this.congaratLabel.Name = "congaratLabel";
            this.congaratLabel.Size = new System.Drawing.Size(204, 42);
            this.congaratLabel.TabIndex = 18;
            this.congaratLabel.Text = "Well done!";
            this.congaratLabel.Visible = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 642);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.congaratLabel);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.restartButton);
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.Text = "Find the pair";
            this.sizeChoise.ResumeLayout(false);
            this.sizeChoise.PerformLayout();
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.categoryChoise.ResumeLayout(false);
            this.categoryChoise.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox sizeChoise;
        private System.Windows.Forms.RadioButton largeSize;
        private System.Windows.Forms.RadioButton mediumSize;
        private System.Windows.Forms.RadioButton smallSize;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitToMain;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label hiscoreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox categoryChoise;
        private System.Windows.Forms.RadioButton Fruits;
        private System.Windows.Forms.RadioButton Animals;
        private System.Windows.Forms.Button resetHiscore;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label tryLabel;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label congaratLabel;
    }
}


namespace Сalculator
{
    partial class Main
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ButtonWhiteOrBlack = new System.Windows.Forms.PictureBox();
            this.ButtonRollUp = new System.Windows.Forms.PictureBox();
            this.ButtonToClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonEqual = new System.Windows.Forms.Button();
            this.ButtonDot = new System.Windows.Forms.Button();
            this.ButtonZero = new System.Windows.Forms.Button();
            this.ButtonAddition = new System.Windows.Forms.Button();
            this.ButtonThree = new System.Windows.Forms.Button();
            this.ButtonTwo = new System.Windows.Forms.Button();
            this.ButtonOne = new System.Windows.Forms.Button();
            this.ButtonSubtraction = new System.Windows.Forms.Button();
            this.ButtonSix = new System.Windows.Forms.Button();
            this.ButtonFive = new System.Windows.Forms.Button();
            this.ButtonFour = new System.Windows.Forms.Button();
            this.ButtonMultiplication = new System.Windows.Forms.Button();
            this.ButtonNine = new System.Windows.Forms.Button();
            this.ButtonEight = new System.Windows.Forms.Button();
            this.ButtonSeven = new System.Windows.Forms.Button();
            this.ButtonDivision = new System.Windows.Forms.Button();
            this.ButtonPercent = new System.Windows.Forms.Button();
            this.ClearEntrance = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonWhiteOrBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRollUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonToClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.White;
            this.TopPanel.Controls.Add(this.ButtonWhiteOrBlack);
            this.TopPanel.Controls.Add(this.ButtonRollUp);
            this.TopPanel.Controls.Add(this.ButtonToClose);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(400, 42);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // ButtonWhiteOrBlack
            // 
            this.ButtonWhiteOrBlack.Image = global::Сalculator.Properties.Resources.WhiteBlack;
            this.ButtonWhiteOrBlack.Location = new System.Drawing.Point(247, 0);
            this.ButtonWhiteOrBlack.Name = "ButtonWhiteOrBlack";
            this.ButtonWhiteOrBlack.Size = new System.Drawing.Size(42, 42);
            this.ButtonWhiteOrBlack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonWhiteOrBlack.TabIndex = 2;
            this.ButtonWhiteOrBlack.TabStop = false;
            this.ButtonWhiteOrBlack.Click += new System.EventHandler(this.ButtonWhiteOrBlack_Click);
            // 
            // ButtonRollUp
            // 
            this.ButtonRollUp.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonRollUp.Image = global::Сalculator.Properties.Resources.RollUp;
            this.ButtonRollUp.Location = new System.Drawing.Point(295, 0);
            this.ButtonRollUp.Name = "ButtonRollUp";
            this.ButtonRollUp.Size = new System.Drawing.Size(42, 42);
            this.ButtonRollUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonRollUp.TabIndex = 1;
            this.ButtonRollUp.TabStop = false;
            this.ButtonRollUp.Click += new System.EventHandler(this.ButtonRollUp_Click);
            // 
            // ButtonToClose
            // 
            this.ButtonToClose.Image = global::Сalculator.Properties.Resources.ToClose;
            this.ButtonToClose.Location = new System.Drawing.Point(343, 0);
            this.ButtonToClose.Name = "ButtonToClose";
            this.ButtonToClose.Size = new System.Drawing.Size(42, 42);
            this.ButtonToClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonToClose.TabIndex = 0;
            this.ButtonToClose.TabStop = false;
            this.ButtonToClose.Click += new System.EventHandler(this.ButtonToClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ButtonEqual);
            this.panel1.Controls.Add(this.ButtonDot);
            this.panel1.Controls.Add(this.ButtonZero);
            this.panel1.Controls.Add(this.ButtonAddition);
            this.panel1.Controls.Add(this.ButtonThree);
            this.panel1.Controls.Add(this.ButtonTwo);
            this.panel1.Controls.Add(this.ButtonOne);
            this.panel1.Controls.Add(this.ButtonSubtraction);
            this.panel1.Controls.Add(this.ButtonSix);
            this.panel1.Controls.Add(this.ButtonFive);
            this.panel1.Controls.Add(this.ButtonFour);
            this.panel1.Controls.Add(this.ButtonMultiplication);
            this.panel1.Controls.Add(this.ButtonNine);
            this.panel1.Controls.Add(this.ButtonEight);
            this.panel1.Controls.Add(this.ButtonSeven);
            this.panel1.Controls.Add(this.ButtonDivision);
            this.panel1.Controls.Add(this.ButtonPercent);
            this.panel1.Controls.Add(this.ClearEntrance);
            this.panel1.Controls.Add(this.Clear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 495);
            this.panel1.TabIndex = 2;
            // 
            // ButtonEqual
            // 
            this.ButtonEqual.FlatAppearance.BorderSize = 0;
            this.ButtonEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEqual.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonEqual.Location = new System.Drawing.Point(300, 395);
            this.ButtonEqual.Name = "ButtonEqual";
            this.ButtonEqual.Size = new System.Drawing.Size(85, 85);
            this.ButtonEqual.TabIndex = 19;
            this.ButtonEqual.Text = "=";
            this.ButtonEqual.UseVisualStyleBackColor = true;
            this.ButtonEqual.Click += new System.EventHandler(this.ButtonEqual_Click);
            // 
            // ButtonDot
            // 
            this.ButtonDot.FlatAppearance.BorderSize = 0;
            this.ButtonDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDot.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDot.Location = new System.Drawing.Point(205, 395);
            this.ButtonDot.Name = "ButtonDot";
            this.ButtonDot.Size = new System.Drawing.Size(85, 85);
            this.ButtonDot.TabIndex = 18;
            this.ButtonDot.Text = ",";
            this.ButtonDot.UseVisualStyleBackColor = true;
            this.ButtonDot.Click += new System.EventHandler(this.ButtonSeven_Click);
            // 
            // ButtonZero
            // 
            this.ButtonZero.FlatAppearance.BorderSize = 0;
            this.ButtonZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonZero.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonZero.Location = new System.Drawing.Point(15, 395);
            this.ButtonZero.Name = "ButtonZero";
            this.ButtonZero.Size = new System.Drawing.Size(180, 85);
            this.ButtonZero.TabIndex = 17;
            this.ButtonZero.Text = "0";
            this.ButtonZero.UseVisualStyleBackColor = true;
            this.ButtonZero.Click += new System.EventHandler(this.ButtonSeven_Click);
            // 
            // ButtonAddition
            // 
            this.ButtonAddition.FlatAppearance.BorderSize = 0;
            this.ButtonAddition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddition.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddition.Location = new System.Drawing.Point(300, 300);
            this.ButtonAddition.Name = "ButtonAddition";
            this.ButtonAddition.Size = new System.Drawing.Size(85, 85);
            this.ButtonAddition.TabIndex = 15;
            this.ButtonAddition.Text = "+";
            this.ButtonAddition.UseVisualStyleBackColor = true;
            this.ButtonAddition.Click += new System.EventHandler(this.ButtonPercent_Click);
            // 
            // ButtonThree
            // 
            this.ButtonThree.FlatAppearance.BorderSize = 0;
            this.ButtonThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonThree.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonThree.Location = new System.Drawing.Point(205, 300);
            this.ButtonThree.Name = "ButtonThree";
            this.ButtonThree.Size = new System.Drawing.Size(85, 85);
            this.ButtonThree.TabIndex = 14;
            this.ButtonThree.Text = "3";
            this.ButtonThree.UseVisualStyleBackColor = true;
            this.ButtonThree.Click += new System.EventHandler(this.ButtonSeven_Click);
            // 
            // ButtonTwo
            // 
            this.ButtonTwo.FlatAppearance.BorderSize = 0;
            this.ButtonTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTwo.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonTwo.Location = new System.Drawing.Point(110, 300);
            this.ButtonTwo.Name = "ButtonTwo";
            this.ButtonTwo.Size = new System.Drawing.Size(85, 85);
            this.ButtonTwo.TabIndex = 13;
            this.ButtonTwo.Text = "2";
            this.ButtonTwo.UseVisualStyleBackColor = true;
            this.ButtonTwo.Click += new System.EventHandler(this.ButtonSeven_Click);
            // 
            // ButtonOne
            // 
            this.ButtonOne.FlatAppearance.BorderSize = 0;
            this.ButtonOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOne.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonOne.Location = new System.Drawing.Point(15, 300);
            this.ButtonOne.Name = "ButtonOne";
            this.ButtonOne.Size = new System.Drawing.Size(85, 85);
            this.ButtonOne.TabIndex = 12;
            this.ButtonOne.Text = "1";
            this.ButtonOne.UseVisualStyleBackColor = true;
            this.ButtonOne.Click += new System.EventHandler(this.ButtonSeven_Click);
            // 
            // ButtonSubtraction
            // 
            this.ButtonSubtraction.FlatAppearance.BorderSize = 0;
            this.ButtonSubtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSubtraction.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSubtraction.Location = new System.Drawing.Point(300, 205);
            this.ButtonSubtraction.Name = "ButtonSubtraction";
            this.ButtonSubtraction.Size = new System.Drawing.Size(85, 85);
            this.ButtonSubtraction.TabIndex = 11;
            this.ButtonSubtraction.Text = "-";
            this.ButtonSubtraction.UseVisualStyleBackColor = true;
            this.ButtonSubtraction.Click += new System.EventHandler(this.ButtonPercent_Click);
            // 
            // ButtonSix
            // 
            this.ButtonSix.FlatAppearance.BorderSize = 0;
            this.ButtonSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSix.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSix.Location = new System.Drawing.Point(205, 205);
            this.ButtonSix.Name = "ButtonSix";
            this.ButtonSix.Size = new System.Drawing.Size(85, 85);
            this.ButtonSix.TabIndex = 10;
            this.ButtonSix.Text = "6";
            this.ButtonSix.UseVisualStyleBackColor = true;
            this.ButtonSix.Click += new System.EventHandler(this.ButtonSeven_Click);
            // 
            // ButtonFive
            // 
            this.ButtonFive.FlatAppearance.BorderSize = 0;
            this.ButtonFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFive.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonFive.Location = new System.Drawing.Point(110, 205);
            this.ButtonFive.Name = "ButtonFive";
            this.ButtonFive.Size = new System.Drawing.Size(85, 85);
            this.ButtonFive.TabIndex = 9;
            this.ButtonFive.Text = "5";
            this.ButtonFive.UseVisualStyleBackColor = true;
            this.ButtonFive.Click += new System.EventHandler(this.ButtonSeven_Click);
            // 
            // ButtonFour
            // 
            this.ButtonFour.FlatAppearance.BorderSize = 0;
            this.ButtonFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFour.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonFour.Location = new System.Drawing.Point(15, 205);
            this.ButtonFour.Name = "ButtonFour";
            this.ButtonFour.Size = new System.Drawing.Size(85, 85);
            this.ButtonFour.TabIndex = 8;
            this.ButtonFour.Text = "4";
            this.ButtonFour.UseVisualStyleBackColor = true;
            this.ButtonFour.Click += new System.EventHandler(this.ButtonSeven_Click);
            // 
            // ButtonMultiplication
            // 
            this.ButtonMultiplication.FlatAppearance.BorderSize = 0;
            this.ButtonMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMultiplication.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMultiplication.Location = new System.Drawing.Point(300, 110);
            this.ButtonMultiplication.Name = "ButtonMultiplication";
            this.ButtonMultiplication.Size = new System.Drawing.Size(85, 85);
            this.ButtonMultiplication.TabIndex = 7;
            this.ButtonMultiplication.Text = "*";
            this.ButtonMultiplication.UseVisualStyleBackColor = true;
            this.ButtonMultiplication.Click += new System.EventHandler(this.ButtonPercent_Click);
            // 
            // ButtonNine
            // 
            this.ButtonNine.FlatAppearance.BorderSize = 0;
            this.ButtonNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNine.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonNine.Location = new System.Drawing.Point(205, 110);
            this.ButtonNine.Name = "ButtonNine";
            this.ButtonNine.Size = new System.Drawing.Size(85, 85);
            this.ButtonNine.TabIndex = 6;
            this.ButtonNine.Text = "9";
            this.ButtonNine.UseVisualStyleBackColor = true;
            this.ButtonNine.Click += new System.EventHandler(this.ButtonSeven_Click);
            // 
            // ButtonEight
            // 
            this.ButtonEight.FlatAppearance.BorderSize = 0;
            this.ButtonEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEight.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonEight.Location = new System.Drawing.Point(110, 110);
            this.ButtonEight.Name = "ButtonEight";
            this.ButtonEight.Size = new System.Drawing.Size(85, 85);
            this.ButtonEight.TabIndex = 5;
            this.ButtonEight.Text = "8";
            this.ButtonEight.UseVisualStyleBackColor = true;
            this.ButtonEight.Click += new System.EventHandler(this.ButtonSeven_Click);
            // 
            // ButtonSeven
            // 
            this.ButtonSeven.FlatAppearance.BorderSize = 0;
            this.ButtonSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSeven.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSeven.Location = new System.Drawing.Point(15, 110);
            this.ButtonSeven.Name = "ButtonSeven";
            this.ButtonSeven.Size = new System.Drawing.Size(85, 85);
            this.ButtonSeven.TabIndex = 4;
            this.ButtonSeven.Text = "7";
            this.ButtonSeven.UseVisualStyleBackColor = true;
            this.ButtonSeven.Click += new System.EventHandler(this.ButtonSeven_Click);
            // 
            // ButtonDivision
            // 
            this.ButtonDivision.FlatAppearance.BorderSize = 0;
            this.ButtonDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDivision.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDivision.Location = new System.Drawing.Point(300, 15);
            this.ButtonDivision.Name = "ButtonDivision";
            this.ButtonDivision.Size = new System.Drawing.Size(85, 85);
            this.ButtonDivision.TabIndex = 3;
            this.ButtonDivision.Text = "/";
            this.ButtonDivision.UseVisualStyleBackColor = true;
            this.ButtonDivision.Click += new System.EventHandler(this.ButtonPercent_Click);
            // 
            // ButtonPercent
            // 
            this.ButtonPercent.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ButtonPercent.FlatAppearance.BorderSize = 0;
            this.ButtonPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPercent.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPercent.Location = new System.Drawing.Point(205, 15);
            this.ButtonPercent.Name = "ButtonPercent";
            this.ButtonPercent.Size = new System.Drawing.Size(85, 85);
            this.ButtonPercent.TabIndex = 2;
            this.ButtonPercent.Text = "%";
            this.ButtonPercent.UseVisualStyleBackColor = true;
            this.ButtonPercent.UseWaitCursor = true;
            this.ButtonPercent.Click += new System.EventHandler(this.ButtonPercent_Click);
            // 
            // ClearEntrance
            // 
            this.ClearEntrance.FlatAppearance.BorderSize = 0;
            this.ClearEntrance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearEntrance.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearEntrance.Location = new System.Drawing.Point(110, 15);
            this.ClearEntrance.Name = "ClearEntrance";
            this.ClearEntrance.Size = new System.Drawing.Size(85, 85);
            this.ClearEntrance.TabIndex = 1;
            this.ClearEntrance.Text = "CE";
            this.ClearEntrance.UseVisualStyleBackColor = true;
            this.ClearEntrance.Click += new System.EventHandler(this.ClearEntrance_Click);
            // 
            // Clear
            // 
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(15, 15);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(85, 85);
            this.Clear.TabIndex = 0;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBox.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox.Location = new System.Drawing.Point(0, 42);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(400, 64);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "0";
            this.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonWhiteOrBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRollUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonToClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonEqual;
        private System.Windows.Forms.Button ButtonDot;
        private System.Windows.Forms.Button ButtonZero;
        private System.Windows.Forms.Button ButtonAddition;
        private System.Windows.Forms.Button ButtonThree;
        private System.Windows.Forms.Button ButtonTwo;
        private System.Windows.Forms.Button ButtonOne;
        private System.Windows.Forms.Button ButtonSubtraction;
        private System.Windows.Forms.Button ButtonSix;
        private System.Windows.Forms.Button ButtonFive;
        private System.Windows.Forms.Button ButtonFour;
        private System.Windows.Forms.Button ButtonMultiplication;
        private System.Windows.Forms.Button ButtonNine;
        private System.Windows.Forms.Button ButtonEight;
        private System.Windows.Forms.Button ButtonSeven;
        private System.Windows.Forms.Button ButtonDivision;
        private System.Windows.Forms.Button ButtonPercent;
        private System.Windows.Forms.Button ClearEntrance;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.PictureBox ButtonWhiteOrBlack;
        private System.Windows.Forms.PictureBox ButtonRollUp;
        private System.Windows.Forms.PictureBox ButtonToClose;
    }
}


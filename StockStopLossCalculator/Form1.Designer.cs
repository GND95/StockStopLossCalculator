namespace StockStopLossCalculator
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
            this.startPriceTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buyIncrementTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stopLossTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buyPoint1TB = new System.Windows.Forms.TextBox();
            this.stopLoss1TB = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.buyPoint2TB = new System.Windows.Forms.TextBox();
            this.stopLoss2TB = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.buyPoint3TB = new System.Windows.Forms.TextBox();
            this.stopLoss3TB = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.buyPoint4TB = new System.Windows.Forms.TextBox();
            this.stopLoss4TB = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.buyPoint5TB = new System.Windows.Forms.TextBox();
            this.stopLoss5TB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ChangeResultTB = new System.Windows.Forms.TextBox();
            this.Y1TB = new System.Windows.Forms.TextBox();
            this.Y2TB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.priorCashValueTB = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.gainLossTB = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startPriceTB
            // 
            this.startPriceTB.Location = new System.Drawing.Point(6, 39);
            this.startPriceTB.Name = "startPriceTB";
            this.startPriceTB.Size = new System.Drawing.Size(116, 26);
            this.startPriceTB.TabIndex = 0;
            this.startPriceTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.startPriceTB_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stock Start Price";
            // 
            // buyIncrementTB
            // 
            this.buyIncrementTB.Location = new System.Drawing.Point(140, 39);
            this.buyIncrementTB.Name = "buyIncrementTB";
            this.buyIncrementTB.Size = new System.Drawing.Size(116, 26);
            this.buyIncrementTB.TabIndex = 1;
            this.buyIncrementTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buyIncrementTB_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buy Increments (%)";
            // 
            // stopLossTB
            // 
            this.stopLossTB.Location = new System.Drawing.Point(271, 39);
            this.stopLossTB.Name = "stopLossTB";
            this.stopLossTB.Size = new System.Drawing.Size(112, 26);
            this.stopLossTB.TabIndex = 2;
            this.stopLossTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stopLossTB_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Stop Loss (%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Target Price #";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Entry/Sell Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Stop Loss Value";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(2, 122);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(128, 40);
            this.textBox4.TabIndex = 0;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "First Position";
            // 
            // buyPoint1TB
            // 
            this.buyPoint1TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyPoint1TB.Location = new System.Drawing.Point(140, 122);
            this.buyPoint1TB.Multiline = true;
            this.buyPoint1TB.Name = "buyPoint1TB";
            this.buyPoint1TB.ReadOnly = true;
            this.buyPoint1TB.Size = new System.Drawing.Size(116, 40);
            this.buyPoint1TB.TabIndex = 0;
            this.buyPoint1TB.TabStop = false;
            // 
            // stopLoss1TB
            // 
            this.stopLoss1TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopLoss1TB.Location = new System.Drawing.Point(267, 122);
            this.stopLoss1TB.Multiline = true;
            this.stopLoss1TB.Name = "stopLoss1TB";
            this.stopLoss1TB.ReadOnly = true;
            this.stopLoss1TB.Size = new System.Drawing.Size(116, 40);
            this.stopLoss1TB.TabIndex = 0;
            this.stopLoss1TB.TabStop = false;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(2, 168);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(128, 40);
            this.textBox7.TabIndex = 0;
            this.textBox7.TabStop = false;
            this.textBox7.Text = "Second Position";
            // 
            // buyPoint2TB
            // 
            this.buyPoint2TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyPoint2TB.Location = new System.Drawing.Point(140, 168);
            this.buyPoint2TB.Multiline = true;
            this.buyPoint2TB.Name = "buyPoint2TB";
            this.buyPoint2TB.ReadOnly = true;
            this.buyPoint2TB.Size = new System.Drawing.Size(116, 40);
            this.buyPoint2TB.TabIndex = 0;
            this.buyPoint2TB.TabStop = false;
            // 
            // stopLoss2TB
            // 
            this.stopLoss2TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopLoss2TB.Location = new System.Drawing.Point(267, 168);
            this.stopLoss2TB.Multiline = true;
            this.stopLoss2TB.Name = "stopLoss2TB";
            this.stopLoss2TB.ReadOnly = true;
            this.stopLoss2TB.Size = new System.Drawing.Size(116, 40);
            this.stopLoss2TB.TabIndex = 0;
            this.stopLoss2TB.TabStop = false;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(2, 214);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(128, 40);
            this.textBox10.TabIndex = 0;
            this.textBox10.TabStop = false;
            this.textBox10.Text = "Third Position";
            // 
            // buyPoint3TB
            // 
            this.buyPoint3TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyPoint3TB.Location = new System.Drawing.Point(140, 214);
            this.buyPoint3TB.Multiline = true;
            this.buyPoint3TB.Name = "buyPoint3TB";
            this.buyPoint3TB.ReadOnly = true;
            this.buyPoint3TB.Size = new System.Drawing.Size(116, 40);
            this.buyPoint3TB.TabIndex = 0;
            this.buyPoint3TB.TabStop = false;
            // 
            // stopLoss3TB
            // 
            this.stopLoss3TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopLoss3TB.Location = new System.Drawing.Point(267, 214);
            this.stopLoss3TB.Multiline = true;
            this.stopLoss3TB.Name = "stopLoss3TB";
            this.stopLoss3TB.ReadOnly = true;
            this.stopLoss3TB.Size = new System.Drawing.Size(116, 40);
            this.stopLoss3TB.TabIndex = 0;
            this.stopLoss3TB.TabStop = false;
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(2, 260);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(128, 40);
            this.textBox13.TabIndex = 0;
            this.textBox13.TabStop = false;
            this.textBox13.Text = "Fourth Position";
            // 
            // buyPoint4TB
            // 
            this.buyPoint4TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyPoint4TB.Location = new System.Drawing.Point(140, 260);
            this.buyPoint4TB.Multiline = true;
            this.buyPoint4TB.Name = "buyPoint4TB";
            this.buyPoint4TB.ReadOnly = true;
            this.buyPoint4TB.Size = new System.Drawing.Size(116, 40);
            this.buyPoint4TB.TabIndex = 0;
            this.buyPoint4TB.TabStop = false;
            // 
            // stopLoss4TB
            // 
            this.stopLoss4TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopLoss4TB.Location = new System.Drawing.Point(267, 260);
            this.stopLoss4TB.Multiline = true;
            this.stopLoss4TB.Name = "stopLoss4TB";
            this.stopLoss4TB.ReadOnly = true;
            this.stopLoss4TB.Size = new System.Drawing.Size(116, 40);
            this.stopLoss4TB.TabIndex = 0;
            this.stopLoss4TB.TabStop = false;
            // 
            // textBox16
            // 
            this.textBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.Location = new System.Drawing.Point(2, 306);
            this.textBox16.Multiline = true;
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(128, 40);
            this.textBox16.TabIndex = 0;
            this.textBox16.TabStop = false;
            this.textBox16.Text = "Fifth Position";
            // 
            // buyPoint5TB
            // 
            this.buyPoint5TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyPoint5TB.Location = new System.Drawing.Point(140, 306);
            this.buyPoint5TB.Multiline = true;
            this.buyPoint5TB.Name = "buyPoint5TB";
            this.buyPoint5TB.ReadOnly = true;
            this.buyPoint5TB.Size = new System.Drawing.Size(116, 40);
            this.buyPoint5TB.TabIndex = 0;
            this.buyPoint5TB.TabStop = false;
            // 
            // stopLoss5TB
            // 
            this.stopLoss5TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopLoss5TB.Location = new System.Drawing.Point(267, 306);
            this.stopLoss5TB.Multiline = true;
            this.stopLoss5TB.Name = "stopLoss5TB";
            this.stopLoss5TB.ReadOnly = true;
            this.stopLoss5TB.Size = new System.Drawing.Size(116, 40);
            this.stopLoss5TB.TabIndex = 0;
            this.stopLoss5TB.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(142, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 59);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(396, -17);
            this.label7.MaximumSize = new System.Drawing.Size(2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(2, 0);
            this.label7.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(558, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 64);
            this.button2.TabIndex = 6;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Start Value";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(554, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "End Value";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(408, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 25);
            this.label10.TabIndex = 7;
            this.label10.Text = "Percent Change";
            // 
            // ChangeResultTB
            // 
            this.ChangeResultTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.ChangeResultTB.Location = new System.Drawing.Point(413, 127);
            this.ChangeResultTB.Multiline = true;
            this.ChangeResultTB.Name = "ChangeResultTB";
            this.ChangeResultTB.ReadOnly = true;
            this.ChangeResultTB.Size = new System.Drawing.Size(139, 64);
            this.ChangeResultTB.TabIndex = 8;
            this.ChangeResultTB.TabStop = false;
            this.ChangeResultTB.Text = "%";
            // 
            // Y1TB
            // 
            this.Y1TB.Location = new System.Drawing.Point(413, 39);
            this.Y1TB.Name = "Y1TB";
            this.Y1TB.Size = new System.Drawing.Size(112, 26);
            this.Y1TB.TabIndex = 4;
            this.Y1TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Y1TB_KeyDown);
            // 
            // Y2TB
            // 
            this.Y2TB.Location = new System.Drawing.Point(544, 39);
            this.Y2TB.Name = "Y2TB";
            this.Y2TB.Size = new System.Drawing.Size(112, 26);
            this.Y2TB.TabIndex = 5;
            this.Y2TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Y2TB_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(419, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Prior Cash Value";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(409, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Potential Gain/Loss";
            // 
            // priorCashValueTB
            // 
            this.priorCashValueTB.Location = new System.Drawing.Point(413, 237);
            this.priorCashValueTB.Name = "priorCashValueTB";
            this.priorCashValueTB.Size = new System.Drawing.Size(133, 26);
            this.priorCashValueTB.TabIndex = 11;
            this.priorCashValueTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.priorCashValueTB_KeyDown);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(558, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 38);
            this.button3.TabIndex = 12;
            this.button3.Text = "Calculate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gainLossTB
            // 
            this.gainLossTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.gainLossTB.Location = new System.Drawing.Point(413, 306);
            this.gainLossTB.Multiline = true;
            this.gainLossTB.Name = "gainLossTB";
            this.gainLossTB.ReadOnly = true;
            this.gainLossTB.Size = new System.Drawing.Size(259, 40);
            this.gainLossTB.TabIndex = 13;
            this.gainLossTB.TabStop = false;
            this.gainLossTB.Text = "$";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(558, 352);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 59);
            this.button4.TabIndex = 14;
            this.button4.Text = "Restart";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 423);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.gainLossTB);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.priorCashValueTB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Y2TB);
            this.Controls.Add(this.Y1TB);
            this.Controls.Add(this.ChangeResultTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopLoss5TB);
            this.Controls.Add(this.stopLoss4TB);
            this.Controls.Add(this.stopLoss3TB);
            this.Controls.Add(this.stopLoss2TB);
            this.Controls.Add(this.stopLoss1TB);
            this.Controls.Add(this.stopLossTB);
            this.Controls.Add(this.buyPoint5TB);
            this.Controls.Add(this.buyPoint4TB);
            this.Controls.Add(this.buyPoint3TB);
            this.Controls.Add(this.buyPoint2TB);
            this.Controls.Add(this.buyPoint1TB);
            this.Controls.Add(this.buyIncrementTB);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.startPriceTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Stop-Loss Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox startPriceTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox buyIncrementTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stopLossTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox buyPoint1TB;
        private System.Windows.Forms.TextBox stopLoss1TB;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox buyPoint2TB;
        private System.Windows.Forms.TextBox stopLoss2TB;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox buyPoint3TB;
        private System.Windows.Forms.TextBox stopLoss3TB;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox buyPoint4TB;
        private System.Windows.Forms.TextBox stopLoss4TB;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox buyPoint5TB;
        private System.Windows.Forms.TextBox stopLoss5TB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ChangeResultTB;
        private System.Windows.Forms.TextBox Y1TB;
        private System.Windows.Forms.TextBox Y2TB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox priorCashValueTB;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox gainLossTB;
        private System.Windows.Forms.Button button4;
    }
}


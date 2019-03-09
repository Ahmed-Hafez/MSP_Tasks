namespace Calculator
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
            this.resultTxt = new System.Windows.Forms.TextBox();
            this.equalBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.decimalBtn = new System.Windows.Forms.Button();
            this.number0Btn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.number3Btn = new System.Windows.Forms.Button();
            this.number2Btn = new System.Windows.Forms.Button();
            this.number1Btn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.multiplyBtn = new System.Windows.Forms.Button();
            this.number6Btn = new System.Windows.Forms.Button();
            this.number5Btn = new System.Windows.Forms.Button();
            this.number4Btn = new System.Windows.Forms.Button();
            this.divideBtn = new System.Windows.Forms.Button();
            this.number9Btn = new System.Windows.Forms.Button();
            this.number8Btn = new System.Windows.Forms.Button();
            this.number7Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultTxt
            // 
            this.resultTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTxt.Location = new System.Drawing.Point(16, 48);
            this.resultTxt.Margin = new System.Windows.Forms.Padding(4);
            this.resultTxt.Name = "resultTxt";
            this.resultTxt.ReadOnly = true;
            this.resultTxt.Size = new System.Drawing.Size(341, 34);
            this.resultTxt.TabIndex = 39;
            this.resultTxt.Text = "0";
            this.resultTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // equalBtn
            // 
            this.equalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalBtn.Location = new System.Drawing.Point(288, 214);
            this.equalBtn.Margin = new System.Windows.Forms.Padding(4);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(71, 118);
            this.equalBtn.TabIndex = 38;
            this.equalBtn.Text = "=";
            this.equalBtn.UseVisualStyleBackColor = true;
            this.equalBtn.Click += new System.EventHandler(this.equalBtn_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusBtn.Location = new System.Drawing.Point(220, 277);
            this.plusBtn.Margin = new System.Windows.Forms.Padding(4);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(60, 55);
            this.plusBtn.TabIndex = 37;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.OperationBtns_Click);
            // 
            // decimalBtn
            // 
            this.decimalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalBtn.Location = new System.Drawing.Point(152, 277);
            this.decimalBtn.Margin = new System.Windows.Forms.Padding(4);
            this.decimalBtn.Name = "decimalBtn";
            this.decimalBtn.Size = new System.Drawing.Size(60, 55);
            this.decimalBtn.TabIndex = 36;
            this.decimalBtn.Text = ".";
            this.decimalBtn.UseVisualStyleBackColor = true;
            this.decimalBtn.Click += new System.EventHandler(this.decimalBtn_Click);
            // 
            // number0Btn
            // 
            this.number0Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number0Btn.Location = new System.Drawing.Point(16, 277);
            this.number0Btn.Margin = new System.Windows.Forms.Padding(4);
            this.number0Btn.Name = "number0Btn";
            this.number0Btn.Size = new System.Drawing.Size(128, 55);
            this.number0Btn.TabIndex = 35;
            this.number0Btn.Text = "0";
            this.number0Btn.UseVisualStyleBackColor = true;
            this.number0Btn.Click += new System.EventHandler(this.NumberBtns_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusBtn.Location = new System.Drawing.Point(220, 214);
            this.minusBtn.Margin = new System.Windows.Forms.Padding(4);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(60, 55);
            this.minusBtn.TabIndex = 34;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.OperationBtns_Click);
            // 
            // number3Btn
            // 
            this.number3Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number3Btn.Location = new System.Drawing.Point(152, 214);
            this.number3Btn.Margin = new System.Windows.Forms.Padding(4);
            this.number3Btn.Name = "number3Btn";
            this.number3Btn.Size = new System.Drawing.Size(60, 55);
            this.number3Btn.TabIndex = 33;
            this.number3Btn.Text = "3";
            this.number3Btn.UseVisualStyleBackColor = true;
            this.number3Btn.Click += new System.EventHandler(this.NumberBtns_Click);
            // 
            // number2Btn
            // 
            this.number2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number2Btn.Location = new System.Drawing.Point(84, 214);
            this.number2Btn.Margin = new System.Windows.Forms.Padding(4);
            this.number2Btn.Name = "number2Btn";
            this.number2Btn.Size = new System.Drawing.Size(60, 55);
            this.number2Btn.TabIndex = 32;
            this.number2Btn.Text = "2";
            this.number2Btn.UseVisualStyleBackColor = true;
            this.number2Btn.Click += new System.EventHandler(this.NumberBtns_Click);
            // 
            // number1Btn
            // 
            this.number1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number1Btn.Location = new System.Drawing.Point(16, 214);
            this.number1Btn.Margin = new System.Windows.Forms.Padding(4);
            this.number1Btn.Name = "number1Btn";
            this.number1Btn.Size = new System.Drawing.Size(60, 55);
            this.number1Btn.TabIndex = 31;
            this.number1Btn.Text = "1";
            this.number1Btn.UseVisualStyleBackColor = true;
            this.number1Btn.Click += new System.EventHandler(this.NumberBtns_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(288, 90);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(71, 117);
            this.clearBtn.TabIndex = 30;
            this.clearBtn.Text = "C";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // multiplyBtn
            // 
            this.multiplyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyBtn.Location = new System.Drawing.Point(220, 152);
            this.multiplyBtn.Margin = new System.Windows.Forms.Padding(4);
            this.multiplyBtn.Name = "multiplyBtn";
            this.multiplyBtn.Size = new System.Drawing.Size(60, 55);
            this.multiplyBtn.TabIndex = 29;
            this.multiplyBtn.Text = "*";
            this.multiplyBtn.UseVisualStyleBackColor = true;
            this.multiplyBtn.Click += new System.EventHandler(this.OperationBtns_Click);
            // 
            // number6Btn
            // 
            this.number6Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number6Btn.Location = new System.Drawing.Point(152, 152);
            this.number6Btn.Margin = new System.Windows.Forms.Padding(4);
            this.number6Btn.Name = "number6Btn";
            this.number6Btn.Size = new System.Drawing.Size(60, 55);
            this.number6Btn.TabIndex = 28;
            this.number6Btn.Text = "6";
            this.number6Btn.UseVisualStyleBackColor = true;
            this.number6Btn.Click += new System.EventHandler(this.NumberBtns_Click);
            // 
            // number5Btn
            // 
            this.number5Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number5Btn.Location = new System.Drawing.Point(84, 152);
            this.number5Btn.Margin = new System.Windows.Forms.Padding(4);
            this.number5Btn.Name = "number5Btn";
            this.number5Btn.Size = new System.Drawing.Size(60, 55);
            this.number5Btn.TabIndex = 27;
            this.number5Btn.Text = "5";
            this.number5Btn.UseVisualStyleBackColor = true;
            this.number5Btn.Click += new System.EventHandler(this.NumberBtns_Click);
            // 
            // number4Btn
            // 
            this.number4Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number4Btn.Location = new System.Drawing.Point(16, 152);
            this.number4Btn.Margin = new System.Windows.Forms.Padding(4);
            this.number4Btn.Name = "number4Btn";
            this.number4Btn.Size = new System.Drawing.Size(60, 55);
            this.number4Btn.TabIndex = 26;
            this.number4Btn.Text = "4";
            this.number4Btn.UseVisualStyleBackColor = true;
            this.number4Btn.Click += new System.EventHandler(this.NumberBtns_Click);
            // 
            // divideBtn
            // 
            this.divideBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideBtn.Location = new System.Drawing.Point(220, 89);
            this.divideBtn.Margin = new System.Windows.Forms.Padding(4);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(60, 55);
            this.divideBtn.TabIndex = 24;
            this.divideBtn.Text = "/";
            this.divideBtn.UseVisualStyleBackColor = true;
            this.divideBtn.Click += new System.EventHandler(this.OperationBtns_Click);
            // 
            // number9Btn
            // 
            this.number9Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number9Btn.Location = new System.Drawing.Point(152, 89);
            this.number9Btn.Margin = new System.Windows.Forms.Padding(4);
            this.number9Btn.Name = "number9Btn";
            this.number9Btn.Size = new System.Drawing.Size(60, 55);
            this.number9Btn.TabIndex = 23;
            this.number9Btn.Text = "9";
            this.number9Btn.UseVisualStyleBackColor = true;
            this.number9Btn.Click += new System.EventHandler(this.NumberBtns_Click);
            // 
            // number8Btn
            // 
            this.number8Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number8Btn.Location = new System.Drawing.Point(84, 89);
            this.number8Btn.Margin = new System.Windows.Forms.Padding(4);
            this.number8Btn.Name = "number8Btn";
            this.number8Btn.Size = new System.Drawing.Size(60, 55);
            this.number8Btn.TabIndex = 22;
            this.number8Btn.Text = "8";
            this.number8Btn.UseVisualStyleBackColor = true;
            this.number8Btn.Click += new System.EventHandler(this.NumberBtns_Click);
            // 
            // number7Btn
            // 
            this.number7Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number7Btn.Location = new System.Drawing.Point(16, 89);
            this.number7Btn.Margin = new System.Windows.Forms.Padding(4);
            this.number7Btn.Name = "number7Btn";
            this.number7Btn.Size = new System.Drawing.Size(60, 55);
            this.number7Btn.TabIndex = 21;
            this.number7Btn.Text = "7";
            this.number7Btn.UseVisualStyleBackColor = true;
            this.number7Btn.Click += new System.EventHandler(this.NumberBtns_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 360);
            this.Controls.Add(this.resultTxt);
            this.Controls.Add(this.equalBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.decimalBtn);
            this.Controls.Add(this.number0Btn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.number3Btn);
            this.Controls.Add(this.number2Btn);
            this.Controls.Add(this.number1Btn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.multiplyBtn);
            this.Controls.Add(this.number6Btn);
            this.Controls.Add(this.number5Btn);
            this.Controls.Add(this.number4Btn);
            this.Controls.Add(this.divideBtn);
            this.Controls.Add(this.number9Btn);
            this.Controls.Add(this.number8Btn);
            this.Controls.Add(this.number7Btn);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultTxt;
        private System.Windows.Forms.Button equalBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button decimalBtn;
        private System.Windows.Forms.Button number0Btn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button number3Btn;
        private System.Windows.Forms.Button number2Btn;
        private System.Windows.Forms.Button number1Btn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button multiplyBtn;
        private System.Windows.Forms.Button number6Btn;
        private System.Windows.Forms.Button number5Btn;
        private System.Windows.Forms.Button number4Btn;
        private System.Windows.Forms.Button divideBtn;
        private System.Windows.Forms.Button number9Btn;
        private System.Windows.Forms.Button number8Btn;
        private System.Windows.Forms.Button number7Btn;
    }
}


namespace NumberingSystemConverter
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
            this.label1 = new System.Windows.Forms.Label();
            this.binaryTxt = new System.Windows.Forms.TextBox();
            this.hexadecimalTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.decimalTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.octalTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.binaryBtn = new System.Windows.Forms.Button();
            this.octalBtn = new System.Windows.Forms.Button();
            this.decimalBtn = new System.Windows.Forms.Button();
            this.hexadecimalBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Binary(2)";
            // 
            // binaryTxt
            // 
            this.binaryTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryTxt.Location = new System.Drawing.Point(212, 24);
            this.binaryTxt.Name = "binaryTxt";
            this.binaryTxt.Size = new System.Drawing.Size(218, 27);
            this.binaryTxt.TabIndex = 1;
            // 
            // hexadecimalTxt
            // 
            this.hexadecimalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexadecimalTxt.Location = new System.Drawing.Point(212, 123);
            this.hexadecimalTxt.Name = "hexadecimalTxt";
            this.hexadecimalTxt.Size = new System.Drawing.Size(218, 27);
            this.hexadecimalTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hexadecimal(16)";
            // 
            // decimalTxt
            // 
            this.decimalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalTxt.Location = new System.Drawing.Point(212, 90);
            this.decimalTxt.Name = "decimalTxt";
            this.decimalTxt.Size = new System.Drawing.Size(218, 27);
            this.decimalTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Decimal(10)";
            // 
            // octalTxt
            // 
            this.octalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.octalTxt.Location = new System.Drawing.Point(212, 57);
            this.octalTxt.Name = "octalTxt";
            this.octalTxt.Size = new System.Drawing.Size(218, 27);
            this.octalTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Octal(8)";
            // 
            // binaryBtn
            // 
            this.binaryBtn.Location = new System.Drawing.Point(437, 24);
            this.binaryBtn.Name = "binaryBtn";
            this.binaryBtn.Size = new System.Drawing.Size(119, 27);
            this.binaryBtn.TabIndex = 8;
            this.binaryBtn.Text = "Convert";
            this.binaryBtn.UseVisualStyleBackColor = true;
            this.binaryBtn.Click += new System.EventHandler(this.binaryBtn_Click);
            // 
            // octalBtn
            // 
            this.octalBtn.Location = new System.Drawing.Point(437, 57);
            this.octalBtn.Name = "octalBtn";
            this.octalBtn.Size = new System.Drawing.Size(119, 27);
            this.octalBtn.TabIndex = 9;
            this.octalBtn.Text = "Convert";
            this.octalBtn.UseVisualStyleBackColor = true;
            this.octalBtn.Click += new System.EventHandler(this.octalBtn_Click);
            // 
            // decimalBtn
            // 
            this.decimalBtn.Location = new System.Drawing.Point(436, 89);
            this.decimalBtn.Name = "decimalBtn";
            this.decimalBtn.Size = new System.Drawing.Size(119, 27);
            this.decimalBtn.TabIndex = 10;
            this.decimalBtn.Text = "Convert";
            this.decimalBtn.UseVisualStyleBackColor = true;
            this.decimalBtn.Click += new System.EventHandler(this.decimalBtn_Click);
            // 
            // hexadecimalBtn
            // 
            this.hexadecimalBtn.Location = new System.Drawing.Point(436, 123);
            this.hexadecimalBtn.Name = "hexadecimalBtn";
            this.hexadecimalBtn.Size = new System.Drawing.Size(119, 27);
            this.hexadecimalBtn.TabIndex = 11;
            this.hexadecimalBtn.Text = "Convert";
            this.hexadecimalBtn.UseVisualStyleBackColor = true;
            this.hexadecimalBtn.Click += new System.EventHandler(this.hexadecimalBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 161);
            this.Controls.Add(this.hexadecimalBtn);
            this.Controls.Add(this.decimalBtn);
            this.Controls.Add(this.octalBtn);
            this.Controls.Add(this.binaryBtn);
            this.Controls.Add(this.octalTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.decimalTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hexadecimalTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.binaryTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Numbering System Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox binaryTxt;
        private System.Windows.Forms.TextBox hexadecimalTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox decimalTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox octalTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button binaryBtn;
        private System.Windows.Forms.Button octalBtn;
        private System.Windows.Forms.Button decimalBtn;
        private System.Windows.Forms.Button hexadecimalBtn;
    }
}


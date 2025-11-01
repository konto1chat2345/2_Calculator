namespace _2_Calculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.MultipleButton = new System.Windows.Forms.Button();
            this.DivisionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "My calculator application";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter first number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(257, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 26);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter second number:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(257, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(351, 26);
            this.textBox2.TabIndex = 4;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(58, 310);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 36);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Dodaj";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubtractButton
            // 
            this.SubtractButton.Location = new System.Drawing.Point(204, 310);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(75, 36);
            this.SubtractButton.TabIndex = 6;
            this.SubtractButton.Text = "Odejmij";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.SubtractButton_Click);
            // 
            // MultipleButton
            // 
            this.MultipleButton.Location = new System.Drawing.Point(372, 310);
            this.MultipleButton.Name = "MultipleButton";
            this.MultipleButton.Size = new System.Drawing.Size(75, 36);
            this.MultipleButton.TabIndex = 7;
            this.MultipleButton.Text = "Pomnóż";
            this.MultipleButton.UseVisualStyleBackColor = true;
            this.MultipleButton.Click += new System.EventHandler(this.MultipleButton_Click);
            // 
            // DivisionButton
            // 
            this.DivisionButton.Location = new System.Drawing.Point(510, 310);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(75, 36);
            this.DivisionButton.TabIndex = 8;
            this.DivisionButton.Text = "Podziel";
            this.DivisionButton.UseVisualStyleBackColor = true;
            this.DivisionButton.Click += new System.EventHandler(this.DivisionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DivisionButton);
            this.Controls.Add(this.MultipleButton);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mój kalkulator ZIOOM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SubtractButton;
        private System.Windows.Forms.Button MultipleButton;
        private System.Windows.Forms.Button DivisionButton;
    }
}



namespace PercentCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.changeoutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.difoutput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.calc_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input1.Location = new System.Drawing.Point(21, 34);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(300, 43);
            this.input1.TabIndex = 0;
            // 
            // input2
            // 
            this.input2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input2.Location = new System.Drawing.Point(21, 110);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(300, 43);
            this.input2.TabIndex = 1;
            this.input2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // changeoutput
            // 
            this.changeoutput.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeoutput.Location = new System.Drawing.Point(20, 174);
            this.changeoutput.Name = "changeoutput";
            this.changeoutput.Size = new System.Drawing.Size(300, 43);
            this.changeoutput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start Price";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "End Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "% Change";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // difoutput
            // 
            this.difoutput.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.difoutput.Location = new System.Drawing.Point(21, 244);
            this.difoutput.Name = "difoutput";
            this.difoutput.Size = new System.Drawing.Size(300, 43);
            this.difoutput.TabIndex = 6;
            this.difoutput.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Difference";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // calc_button
            // 
            this.calc_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calc_button.Location = new System.Drawing.Point(119, 311);
            this.calc_button.Name = "calc_button";
            this.calc_button.Size = new System.Drawing.Size(97, 42);
            this.calc_button.TabIndex = 3;
            this.calc_button.Text = "CALCULATE";
            this.calc_button.UseVisualStyleBackColor = false;
            this.calc_button.Click += new System.EventHandler(this.calc_button_Click_1);
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.Gainsboro;
            this.clear_button.Location = new System.Drawing.Point(234, 311);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(86, 42);
            this.clear_button.TabIndex = 4;
            this.clear_button.Text = "CLEAR";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(345, 450);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.calc_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.difoutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeoutput);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Name = "Form1";
            this.Text = "Gain/Loss Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox changeoutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox difoutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calc_button;
        private System.Windows.Forms.Button clear_button;
    }
}


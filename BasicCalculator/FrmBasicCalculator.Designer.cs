namespace BasicCalculator
{
    partial class FrmBasicCalculator
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
            this.textBox_Number1 = new System.Windows.Forms.TextBox();
            this.cmBox_Operator = new System.Windows.Forms.ComboBox();
            this.textBox_Number2 = new System.Windows.Forms.TextBox();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Calculator";
            // 
            // textBox_Number1
            // 
            this.textBox_Number1.Location = new System.Drawing.Point(17, 55);
            this.textBox_Number1.Multiline = true;
            this.textBox_Number1.Name = "textBox_Number1";
            this.textBox_Number1.Size = new System.Drawing.Size(197, 45);
            this.textBox_Number1.TabIndex = 1;
            // 
            // cmBox_Operator
            // 
            this.cmBox_Operator.FormattingEnabled = true;
            this.cmBox_Operator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmBox_Operator.Location = new System.Drawing.Point(51, 116);
            this.cmBox_Operator.Name = "cmBox_Operator";
            this.cmBox_Operator.Size = new System.Drawing.Size(121, 21);
            this.cmBox_Operator.TabIndex = 3;
            // 
            // textBox_Number2
            // 
            this.textBox_Number2.Location = new System.Drawing.Point(17, 143);
            this.textBox_Number2.Multiline = true;
            this.textBox_Number2.Name = "textBox_Number2";
            this.textBox_Number2.Size = new System.Drawing.Size(197, 45);
            this.textBox_Number2.TabIndex = 4;
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(17, 210);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(197, 80);
            this.textBox_Result.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmBasicCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 357);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.textBox_Number2);
            this.Controls.Add(this.cmBox_Operator);
            this.Controls.Add(this.textBox_Number1);
            this.Controls.Add(this.label1);
            this.Name = "FrmBasicCalculator";
            this.Text = "FrmBasicCalculator";
            this.Load += new System.EventHandler(this.FrmBasicCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Number1;
        private System.Windows.Forms.ComboBox cmBox_Operator;
        private System.Windows.Forms.TextBox textBox_Number2;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Button button1;
    }
}


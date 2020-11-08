namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGen = new System.Windows.Forms.Button();
            this.matrix2 = new System.Windows.Forms.DataGridView();
            this.matrix1 = new System.Windows.Forms.DataGridView();
            this.lbl = new System.Windows.Forms.Label();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrix2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.btnGen);
            this.panel1.Controls.Add(this.matrix2);
            this.panel1.Controls.Add(this.matrix1);
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Controls.Add(this.nud1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 454);
            this.panel1.TabIndex = 0;
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(366, 79);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 23);
            this.btnGen.TabIndex = 4;
            this.btnGen.Text = "OK";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // matrix2
            // 
            this.matrix2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix2.Location = new System.Drawing.Point(476, 164);
            this.matrix2.Name = "matrix2";
            this.matrix2.Size = new System.Drawing.Size(240, 150);
            this.matrix2.TabIndex = 3;
            // 
            // matrix1
            // 
            this.matrix1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix1.Location = new System.Drawing.Point(90, 164);
            this.matrix1.Name = "matrix1";
            this.matrix1.Size = new System.Drawing.Size(240, 150);
            this.matrix1.TabIndex = 2;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(119, 39);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(172, 13);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Adjon meg egy számot 5-15 között!";
            // 
            // nud1
            // 
            this.nud1.Location = new System.Drawing.Point(139, 79);
            this.nud1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nud1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(120, 20);
            this.nud1.TabIndex = 0;
            this.nud1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(352, 343);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrix2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.DataGridView matrix2;
        private System.Windows.Forms.DataGridView matrix1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.NumericUpDown nud1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}


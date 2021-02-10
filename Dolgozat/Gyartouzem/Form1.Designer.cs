namespace Gyartouzem
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label szallitasNapjaLabel;
            System.Windows.Forms.Label iD_MegrendelesFejlecLabel;
            System.Windows.Forms.Label megrendelesSzamLabel;
            System.Windows.Forms.Label megrendelesDatumaLabel;
            System.Windows.Forms.Label iDvevoLabel;
            this.hataridosDataset = new Gyartouzem.HataridosDataset();
            this.megrendelesFejlecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.megrendelesFejlecTableAdapter = new Gyartouzem.HataridosDatasetTableAdapters.MegrendelesFejlecTableAdapter();
            this.tableAdapterManager = new Gyartouzem.HataridosDatasetTableAdapters.TableAdapterManager();
            this.szallitasNapjaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.iD_MegrendelesFejlecTextBox = new System.Windows.Forms.TextBox();
            this.megrendelesSzamTextBox = new System.Windows.Forms.TextBox();
            this.megrendelesDatumaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.iDvevoTextBox = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            szallitasNapjaLabel = new System.Windows.Forms.Label();
            iD_MegrendelesFejlecLabel = new System.Windows.Forms.Label();
            megrendelesSzamLabel = new System.Windows.Forms.Label();
            megrendelesDatumaLabel = new System.Windows.Forms.Label();
            iDvevoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hataridosDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.megrendelesFejlecBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hataridosDataset
            // 
            this.hataridosDataset.DataSetName = "HataridosDataset";
            this.hataridosDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // megrendelesFejlecBindingSource
            // 
            this.megrendelesFejlecBindingSource.DataMember = "MegrendelesFejlec";
            this.megrendelesFejlecBindingSource.DataSource = this.hataridosDataset;
            // 
            // megrendelesFejlecTableAdapter
            // 
            this.megrendelesFejlecTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MegrendelesFejlecTableAdapter = this.megrendelesFejlecTableAdapter;
            this.tableAdapterManager.UpdateOrder = Gyartouzem.HataridosDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // szallitasNapjaLabel
            // 
            szallitasNapjaLabel.AutoSize = true;
            szallitasNapjaLabel.Location = new System.Drawing.Point(40, 23);
            szallitasNapjaLabel.Name = "szallitasNapjaLabel";
            szallitasNapjaLabel.Size = new System.Drawing.Size(79, 13);
            szallitasNapjaLabel.TabIndex = 1;
            szallitasNapjaLabel.Text = "Szallitas Napja:";
            // 
            // szallitasNapjaDateTimePicker
            // 
            this.szallitasNapjaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.megrendelesFejlecBindingSource, "SzallitasNapja", true));
            this.szallitasNapjaDateTimePicker.Location = new System.Drawing.Point(125, 23);
            this.szallitasNapjaDateTimePicker.Name = "szallitasNapjaDateTimePicker";
            this.szallitasNapjaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.szallitasNapjaDateTimePicker.TabIndex = 2;
            // 
            // iD_MegrendelesFejlecLabel
            // 
            iD_MegrendelesFejlecLabel.AutoSize = true;
            iD_MegrendelesFejlecLabel.Location = new System.Drawing.Point(37, 86);
            iD_MegrendelesFejlecLabel.Name = "iD_MegrendelesFejlecLabel";
            iD_MegrendelesFejlecLabel.Size = new System.Drawing.Size(116, 13);
            iD_MegrendelesFejlecLabel.TabIndex = 2;
            iD_MegrendelesFejlecLabel.Text = "ID Megrendeles Fejlec:";
            // 
            // iD_MegrendelesFejlecTextBox
            // 
            this.iD_MegrendelesFejlecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.megrendelesFejlecBindingSource, "ID_MegrendelesFejlec", true));
            this.iD_MegrendelesFejlecTextBox.Location = new System.Drawing.Point(159, 83);
            this.iD_MegrendelesFejlecTextBox.Name = "iD_MegrendelesFejlecTextBox";
            this.iD_MegrendelesFejlecTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_MegrendelesFejlecTextBox.TabIndex = 3;
            // 
            // megrendelesSzamLabel
            // 
            megrendelesSzamLabel.AutoSize = true;
            megrendelesSzamLabel.Location = new System.Drawing.Point(37, 112);
            megrendelesSzamLabel.Name = "megrendelesSzamLabel";
            megrendelesSzamLabel.Size = new System.Drawing.Size(100, 13);
            megrendelesSzamLabel.TabIndex = 4;
            megrendelesSzamLabel.Text = "Megrendeles Szam:";
            // 
            // megrendelesSzamTextBox
            // 
            this.megrendelesSzamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.megrendelesFejlecBindingSource, "MegrendelesSzam", true));
            this.megrendelesSzamTextBox.Location = new System.Drawing.Point(159, 109);
            this.megrendelesSzamTextBox.Name = "megrendelesSzamTextBox";
            this.megrendelesSzamTextBox.Size = new System.Drawing.Size(200, 20);
            this.megrendelesSzamTextBox.TabIndex = 5;
            // 
            // megrendelesDatumaLabel
            // 
            megrendelesDatumaLabel.AutoSize = true;
            megrendelesDatumaLabel.Location = new System.Drawing.Point(37, 139);
            megrendelesDatumaLabel.Name = "megrendelesDatumaLabel";
            megrendelesDatumaLabel.Size = new System.Drawing.Size(111, 13);
            megrendelesDatumaLabel.TabIndex = 6;
            megrendelesDatumaLabel.Text = "Megrendeles Datuma:";
            // 
            // megrendelesDatumaDateTimePicker
            // 
            this.megrendelesDatumaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.megrendelesFejlecBindingSource, "MegrendelesDatuma", true));
            this.megrendelesDatumaDateTimePicker.Location = new System.Drawing.Point(159, 135);
            this.megrendelesDatumaDateTimePicker.Name = "megrendelesDatumaDateTimePicker";
            this.megrendelesDatumaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.megrendelesDatumaDateTimePicker.TabIndex = 7;
            // 
            // iDvevoLabel
            // 
            iDvevoLabel.AutoSize = true;
            iDvevoLabel.Location = new System.Drawing.Point(40, 170);
            iDvevoLabel.Name = "iDvevoLabel";
            iDvevoLabel.Size = new System.Drawing.Size(45, 13);
            iDvevoLabel.TabIndex = 10;
            iDvevoLabel.Text = "IDvevo:";
            // 
            // iDvevoTextBox
            // 
            this.iDvevoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.megrendelesFejlecBindingSource, "IDvevo", true));
            this.iDvevoTextBox.Location = new System.Drawing.Point(162, 167);
            this.iDvevoTextBox.Name = "iDvevoTextBox";
            this.iDvevoTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDvevoTextBox.TabIndex = 11;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(290, 246);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "OK";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ugrás a másik formra";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(iD_MegrendelesFejlecLabel);
            this.Controls.Add(this.iD_MegrendelesFejlecTextBox);
            this.Controls.Add(megrendelesSzamLabel);
            this.Controls.Add(this.megrendelesSzamTextBox);
            this.Controls.Add(megrendelesDatumaLabel);
            this.Controls.Add(this.megrendelesDatumaDateTimePicker);
            this.Controls.Add(iDvevoLabel);
            this.Controls.Add(this.iDvevoTextBox);
            this.Controls.Add(szallitasNapjaLabel);
            this.Controls.Add(this.szallitasNapjaDateTimePicker);
            this.Name = "Form1";
            this.Text = "Határidők";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hataridosDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.megrendelesFejlecBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HataridosDataset hataridosDataset;
        private System.Windows.Forms.BindingSource megrendelesFejlecBindingSource;
        private HataridosDatasetTableAdapters.MegrendelesFejlecTableAdapter megrendelesFejlecTableAdapter;
        private HataridosDatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker szallitasNapjaDateTimePicker;
        private System.Windows.Forms.TextBox iD_MegrendelesFejlecTextBox;
        private System.Windows.Forms.TextBox megrendelesSzamTextBox;
        private System.Windows.Forms.DateTimePicker megrendelesDatumaDateTimePicker;
        private System.Windows.Forms.TextBox iDvevoTextBox;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label1;
    }
}



namespace yeniimaj
{
    partial class depo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(depo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.combocari = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combotur = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.combopersonel = new System.Windows.Forms.ComboBox();
            this.comboarac = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.printyazici = new System.Drawing.Printing.PrintDocument();
            this.printdialog = new System.Windows.Forms.PrintPreviewDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yeniimajservisDataSet5 = new yeniimaj.yeniimajservisDataSet5();
            this.mUHASEBEFISBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mUHASEBEFISTableAdapter = new yeniimaj.yeniimajservisDataSet5TableAdapters.MUHASEBEFISTableAdapter();
            this.mUHASEBEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tURDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERSONELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRACPLAKADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mIKTARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kDVSIZBIRIMFIYATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tASIMAUCRETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCIKLAMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gENELTOPLAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tARIHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yeniimajservisDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mUHASEBEFISBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1305, 389);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(14, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.combocari);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.combotur);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1305, 79);
            this.panel2.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(695, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "CARİ:";
            // 
            // combocari
            // 
            this.combocari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combocari.FormattingEnabled = true;
            this.combocari.Location = new System.Drawing.Point(756, 49);
            this.combocari.Name = "combocari";
            this.combocari.Size = new System.Drawing.Size(159, 21);
            this.combocari.TabIndex = 24;
            this.combocari.SelectedIndexChanged += new System.EventHandler(this.combocari_SelectedIndexChanged);
            this.combocari.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(695, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "TÜR:";
            // 
            // combotur
            // 
            this.combotur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combotur.FormattingEnabled = true;
            this.combotur.Items.AddRange(new object[] {
            "",
            "ALIS",
            "SATIS"});
            this.combotur.Location = new System.Drawing.Point(756, 19);
            this.combotur.Name = "combotur";
            this.combotur.Size = new System.Drawing.Size(159, 21);
            this.combotur.TabIndex = 22;
            this.combotur.SelectedValueChanged += new System.EventHandler(this.combotur_SelectedValueChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Info;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageIndex = 8;
            this.button4.ImageList = this.imageList3;
            this.button4.Location = new System.Drawing.Point(1022, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 42);
            this.button4.TabIndex = 21;
            this.button4.Text = "KAYIT ARA";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "CIKIS.png");
            this.imageList3.Images.SetKeyName(1, "DELETE.png");
            this.imageList3.Images.SetKeyName(2, "Ekran Görüntüsü (3).png");
            this.imageList3.Images.SetKeyName(3, "GRAFİK.png");
            this.imageList3.Images.SetKeyName(4, "icons8_checkmark_26px.png");
            this.imageList3.Images.SetKeyName(5, "icons8_ecg_50px.png");
            this.imageList3.Images.SetKeyName(6, "icons8_ok_30px.png");
            this.imageList3.Images.SetKeyName(7, "icons8_update_left_rotation_48px.png");
            this.imageList3.Images.SetKeyName(8, "SEWARCH.png");
            this.imageList3.Images.SetKeyName(9, "GOSTER2.png");
            this.imageList3.Images.SetKeyName(10, "LİST.png");
            this.imageList3.Images.SetKeyName(11, "PRİNT.png");
            this.imageList3.Images.SetKeyName(12, "SEWARCH.png");
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 11;
            this.button3.ImageList = this.imageList3;
            this.button3.Location = new System.Drawing.Point(1154, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 42);
            this.button3.TabIndex = 20;
            this.button3.Text = "EXCELE AKTAR";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.date1);
            this.panel4.Controls.Add(this.date2);
            this.panel4.Location = new System.Drawing.Point(2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(393, 84);
            this.panel4.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(136, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "TARİHLER ARASI SEÇ";
            // 
            // date1
            // 
            this.date1.Location = new System.Drawing.Point(10, 39);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(177, 20);
            this.date1.TabIndex = 9;
            // 
            // date2
            // 
            this.date2.Location = new System.Drawing.Point(213, 39);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(177, 20);
            this.date2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.combopersonel);
            this.panel3.Controls.Add(this.comboarac);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(401, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 86);
            this.panel3.TabIndex = 15;
            // 
            // combopersonel
            // 
            this.combopersonel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combopersonel.FormattingEnabled = true;
            this.combopersonel.Items.AddRange(new object[] {
            ""});
            this.combopersonel.Location = new System.Drawing.Point(107, 47);
            this.combopersonel.Name = "combopersonel";
            this.combopersonel.Size = new System.Drawing.Size(143, 21);
            this.combopersonel.TabIndex = 15;
            this.combopersonel.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboarac
            // 
            this.comboarac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboarac.FormattingEnabled = true;
            this.comboarac.Items.AddRange(new object[] {
            ""});
            this.comboarac.Location = new System.Drawing.Point(107, 19);
            this.comboarac.Name = "comboarac";
            this.comboarac.Size = new System.Drawing.Size(143, 21);
            this.comboarac.TabIndex = 14;
            this.comboarac.SelectedIndexChanged += new System.EventHandler(this.comboarac_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "PLAKA NO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "PERSONEL:";
            // 
            // printyazici
            // 
           
            // 
            // printdialog
            // 
            this.printdialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printdialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printdialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printdialog.Document = this.printyazici;
            this.printdialog.Enabled = true;
            this.printdialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printdialog.Icon")));
            this.printdialog.Name = "printdialog";
            this.printdialog.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mUHASEBEIDDataGridViewTextBoxColumn,
            this.tURDataGridViewTextBoxColumn,
            this.cARIDataGridViewTextBoxColumn,
            this.pERSONELDataGridViewTextBoxColumn,
            this.aRACPLAKADataGridViewTextBoxColumn,
            this.mIKTARDataGridViewTextBoxColumn,
            this.kDVSIZBIRIMFIYATDataGridViewTextBoxColumn,
            this.tASIMAUCRETDataGridViewTextBoxColumn,
            this.aCIKLAMADataGridViewTextBoxColumn,
            this.gENELTOPLAMDataGridViewTextBoxColumn,
            this.tARIHDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mUHASEBEFISBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1305, 389);
            this.dataGridView1.TabIndex = 2;
            // 
            // yeniimajservisDataSet5
            // 
            this.yeniimajservisDataSet5.DataSetName = "yeniimajservisDataSet5";
            this.yeniimajservisDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mUHASEBEFISBindingSource
            // 
            this.mUHASEBEFISBindingSource.DataMember = "MUHASEBEFIS";
            this.mUHASEBEFISBindingSource.DataSource = this.yeniimajservisDataSet5;
            // 
            // mUHASEBEFISTableAdapter
            // 
            this.mUHASEBEFISTableAdapter.ClearBeforeFill = true;
            // 
            // mUHASEBEIDDataGridViewTextBoxColumn
            // 
            this.mUHASEBEIDDataGridViewTextBoxColumn.DataPropertyName = "MUHASEBEID";
            this.mUHASEBEIDDataGridViewTextBoxColumn.HeaderText = "MUHASEBEID";
            this.mUHASEBEIDDataGridViewTextBoxColumn.Name = "mUHASEBEIDDataGridViewTextBoxColumn";
            this.mUHASEBEIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tURDataGridViewTextBoxColumn
            // 
            this.tURDataGridViewTextBoxColumn.DataPropertyName = "TUR";
            this.tURDataGridViewTextBoxColumn.HeaderText = "TUR";
            this.tURDataGridViewTextBoxColumn.Name = "tURDataGridViewTextBoxColumn";
            // 
            // cARIDataGridViewTextBoxColumn
            // 
            this.cARIDataGridViewTextBoxColumn.DataPropertyName = "CARI";
            this.cARIDataGridViewTextBoxColumn.HeaderText = "CARI";
            this.cARIDataGridViewTextBoxColumn.Name = "cARIDataGridViewTextBoxColumn";
            // 
            // pERSONELDataGridViewTextBoxColumn
            // 
            this.pERSONELDataGridViewTextBoxColumn.DataPropertyName = "PERSONEL";
            this.pERSONELDataGridViewTextBoxColumn.HeaderText = "PERSONEL";
            this.pERSONELDataGridViewTextBoxColumn.Name = "pERSONELDataGridViewTextBoxColumn";
            // 
            // aRACPLAKADataGridViewTextBoxColumn
            // 
            this.aRACPLAKADataGridViewTextBoxColumn.DataPropertyName = "ARACPLAKA";
            this.aRACPLAKADataGridViewTextBoxColumn.HeaderText = "ARACPLAKA";
            this.aRACPLAKADataGridViewTextBoxColumn.Name = "aRACPLAKADataGridViewTextBoxColumn";
            // 
            // mIKTARDataGridViewTextBoxColumn
            // 
            this.mIKTARDataGridViewTextBoxColumn.DataPropertyName = "MIKTAR";
            this.mIKTARDataGridViewTextBoxColumn.HeaderText = "MIKTAR";
            this.mIKTARDataGridViewTextBoxColumn.Name = "mIKTARDataGridViewTextBoxColumn";
            // 
            // kDVSIZBIRIMFIYATDataGridViewTextBoxColumn
            // 
            this.kDVSIZBIRIMFIYATDataGridViewTextBoxColumn.DataPropertyName = "KDVSIZBIRIMFIYAT";
            this.kDVSIZBIRIMFIYATDataGridViewTextBoxColumn.HeaderText = "KDVSIZBIRIMFIYAT";
            this.kDVSIZBIRIMFIYATDataGridViewTextBoxColumn.Name = "kDVSIZBIRIMFIYATDataGridViewTextBoxColumn";
            // 
            // tASIMAUCRETDataGridViewTextBoxColumn
            // 
            this.tASIMAUCRETDataGridViewTextBoxColumn.DataPropertyName = "TASIMAUCRET";
            this.tASIMAUCRETDataGridViewTextBoxColumn.HeaderText = "TASIMAUCRET";
            this.tASIMAUCRETDataGridViewTextBoxColumn.Name = "tASIMAUCRETDataGridViewTextBoxColumn";
            // 
            // aCIKLAMADataGridViewTextBoxColumn
            // 
            this.aCIKLAMADataGridViewTextBoxColumn.DataPropertyName = "ACIKLAMA";
            this.aCIKLAMADataGridViewTextBoxColumn.HeaderText = "ACIKLAMA";
            this.aCIKLAMADataGridViewTextBoxColumn.Name = "aCIKLAMADataGridViewTextBoxColumn";
            // 
            // gENELTOPLAMDataGridViewTextBoxColumn
            // 
            this.gENELTOPLAMDataGridViewTextBoxColumn.DataPropertyName = "GENELTOPLAM";
            this.gENELTOPLAMDataGridViewTextBoxColumn.HeaderText = "GENELTOPLAM";
            this.gENELTOPLAMDataGridViewTextBoxColumn.Name = "gENELTOPLAMDataGridViewTextBoxColumn";
            // 
            // tARIHDataGridViewTextBoxColumn
            // 
            this.tARIHDataGridViewTextBoxColumn.DataPropertyName = "TARIH";
            this.tARIHDataGridViewTextBoxColumn.HeaderText = "TARIH";
            this.tARIHDataGridViewTextBoxColumn.Name = "tARIHDataGridViewTextBoxColumn";
            // 
            // depo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1325, 494);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "depo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "depo";
            this.Load += new System.EventHandler(this.depo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yeniimajservisDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mUHASEBEFISBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox combopersonel;
        private System.Windows.Forms.ComboBox comboarac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combotur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList imageList3;
        private System.Drawing.Printing.PrintDocument printyazici;
        private System.Windows.Forms.PrintPreviewDialog printdialog;
     //   private yeniimajservisDataSet3TableAdapters.MUHASEBETableAdapter mUHASEBETableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combocari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private yeniimajservisDataSet5 yeniimajservisDataSet5;
        private System.Windows.Forms.BindingSource mUHASEBEFISBindingSource;
        private yeniimajservisDataSet5TableAdapters.MUHASEBEFISTableAdapter mUHASEBEFISTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUHASEBEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tURDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSONELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRACPLAKADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIKTARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kDVSIZBIRIMFIYATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tASIMAUCRETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCIKLAMADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gENELTOPLAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tARIHDataGridViewTextBoxColumn;
    }
}
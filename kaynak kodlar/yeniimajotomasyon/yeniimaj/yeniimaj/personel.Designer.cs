
namespace yeniimaj
{
    partial class personel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textadi = new System.Windows.Forms.TextBox();
            this.textemail = new System.Windows.Forms.TextBox();
            this.texttelefon = new System.Windows.Forms.TextBox();
            this.textmaas = new System.Windows.Forms.TextBox();
            this.textadres = new System.Windows.Forms.TextBox();
            this.textilce = new System.Windows.Forms.TextBox();
            this.textil = new System.Windows.Forms.TextBox();
            this.textsoyadi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btncikis = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pERSONELIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERSONELADIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERSONELSOYADIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıLCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDRESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERSONELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yeniimajservisDataSet1 = new yeniimaj.yeniimajservisDataSet1();
            this.pERSONELTableAdapter = new yeniimaj.yeniimajservisDataSet1TableAdapters.PERSONELTableAdapter();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yeniimajservisDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textadi);
            this.panel1.Controls.Add(this.textemail);
            this.panel1.Controls.Add(this.texttelefon);
            this.panel1.Controls.Add(this.textmaas);
            this.panel1.Controls.Add(this.textadres);
            this.panel1.Controls.Add(this.textilce);
            this.panel1.Controls.Add(this.textil);
            this.panel1.Controls.Add(this.textsoyadi);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 318);
            this.panel1.TabIndex = 18;
            // 
            // textadi
            // 
            this.textadi.Location = new System.Drawing.Point(95, 15);
            this.textadi.Name = "textadi";
            this.textadi.Size = new System.Drawing.Size(167, 20);
            this.textadi.TabIndex = 1;
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(95, 279);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(167, 20);
            this.textemail.TabIndex = 31;
            this.textemail.Tag = "8";
            // 
            // texttelefon
            // 
            this.texttelefon.Location = new System.Drawing.Point(95, 244);
            this.texttelefon.Name = "texttelefon";
            this.texttelefon.Size = new System.Drawing.Size(167, 20);
            this.texttelefon.TabIndex = 7;
            this.texttelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texttelefon_KeyPress);
            // 
            // textmaas
            // 
            this.textmaas.Location = new System.Drawing.Point(95, 211);
            this.textmaas.Name = "textmaas";
            this.textmaas.Size = new System.Drawing.Size(167, 20);
            this.textmaas.TabIndex = 6;
            this.textmaas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textmaas_KeyPress);
            // 
            // textadres
            // 
            this.textadres.Location = new System.Drawing.Point(95, 174);
            this.textadres.Name = "textadres";
            this.textadres.Size = new System.Drawing.Size(167, 20);
            this.textadres.TabIndex = 5;
            // 
            // textilce
            // 
            this.textilce.Location = new System.Drawing.Point(95, 128);
            this.textilce.Name = "textilce";
            this.textilce.Size = new System.Drawing.Size(167, 20);
            this.textilce.TabIndex = 4;
            // 
            // textil
            // 
            this.textil.Location = new System.Drawing.Point(95, 88);
            this.textil.Name = "textil";
            this.textil.Size = new System.Drawing.Size(167, 20);
            this.textil.TabIndex = 3;
            // 
            // textsoyadi
            // 
            this.textsoyadi.Location = new System.Drawing.Point(95, 49);
            this.textsoyadi.Name = "textsoyadi";
            this.textsoyadi.Size = new System.Drawing.Size(167, 20);
            this.textsoyadi.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(3, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "ADRES:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(3, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "E-MAİL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(3, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "TELEFON:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(4, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "MAAŞ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "İLCE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "İL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(4, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "SOYADİ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "ADİ:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnkaydet);
            this.panel3.Controls.Add(this.btncikis);
            this.panel3.Controls.Add(this.btnguncelle);
            this.panel3.Controls.Add(this.btnsil);
            this.panel3.Location = new System.Drawing.Point(12, 327);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(276, 80);
            this.panel3.TabIndex = 19;
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.SystemColors.Info;
            this.btnkaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkaydet.ImageIndex = 6;
            this.btnkaydet.ImageList = this.imageList1;
            this.btnkaydet.Location = new System.Drawing.Point(14, 3);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(98, 32);
            this.btnkaydet.TabIndex = 19;
            this.btnkaydet.Tag = "9";
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "CIKIS.png");
            this.imageList1.Images.SetKeyName(1, "DELETE.png");
            this.imageList1.Images.SetKeyName(2, "Ekran Görüntüsü (3).png");
            this.imageList1.Images.SetKeyName(3, "GRAFİK.png");
            this.imageList1.Images.SetKeyName(4, "icons8_checkmark_26px.png");
            this.imageList1.Images.SetKeyName(5, "icons8_ecg_50px.png");
            this.imageList1.Images.SetKeyName(6, "icons8_ok_30px.png");
            this.imageList1.Images.SetKeyName(7, "icons8_update_left_rotation_48px.png");
            this.imageList1.Images.SetKeyName(8, "SEWARCH.png");
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.SystemColors.Info;
            this.btncikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncikis.ImageIndex = 0;
            this.btncikis.ImageList = this.imageList1;
            this.btncikis.Location = new System.Drawing.Point(152, 45);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(98, 32);
            this.btncikis.TabIndex = 22;
            this.btncikis.Tag = "12";
            this.btncikis.Text = "ÇIKIŞ";
            this.btncikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.SystemColors.Info;
            this.btnguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguncelle.ImageIndex = 7;
            this.btnguncelle.ImageList = this.imageList1;
            this.btnguncelle.Location = new System.Drawing.Point(152, 3);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(98, 32);
            this.btnguncelle.TabIndex = 20;
            this.btnguncelle.Tag = "10";
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.SystemColors.Info;
            this.btnsil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsil.ImageIndex = 1;
            this.btnsil.ImageList = this.imageList1;
            this.btnsil.Location = new System.Drawing.Point(13, 45);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(98, 32);
            this.btnsil.TabIndex = 21;
            this.btnsil.Tag = "11";
            this.btnsil.Text = "KAYIDI SİL";
            this.btnsil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(294, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 404);
            this.panel2.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pERSONELIDDataGridViewTextBoxColumn,
            this.pERSONELADIDataGridViewTextBoxColumn,
            this.pERSONELSOYADIDataGridViewTextBoxColumn,
            this.ıLDataGridViewTextBoxColumn,
            this.ıLCEDataGridViewTextBoxColumn,
            this.aDRESDataGridViewTextBoxColumn,
            this.mAASDataGridViewTextBoxColumn,
            this.tELEFONDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pERSONELBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(820, 404);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // pERSONELIDDataGridViewTextBoxColumn
            // 
            this.pERSONELIDDataGridViewTextBoxColumn.DataPropertyName = "PERSONELID";
            this.pERSONELIDDataGridViewTextBoxColumn.HeaderText = "PERSONELID";
            this.pERSONELIDDataGridViewTextBoxColumn.Name = "pERSONELIDDataGridViewTextBoxColumn";
            this.pERSONELIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pERSONELIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pERSONELADIDataGridViewTextBoxColumn
            // 
            this.pERSONELADIDataGridViewTextBoxColumn.DataPropertyName = "PERSONELADI";
            this.pERSONELADIDataGridViewTextBoxColumn.HeaderText = "PERSONELADI";
            this.pERSONELADIDataGridViewTextBoxColumn.Name = "pERSONELADIDataGridViewTextBoxColumn";
            // 
            // pERSONELSOYADIDataGridViewTextBoxColumn
            // 
            this.pERSONELSOYADIDataGridViewTextBoxColumn.DataPropertyName = "PERSONELSOYADI";
            this.pERSONELSOYADIDataGridViewTextBoxColumn.HeaderText = "PERSONELSOYADI";
            this.pERSONELSOYADIDataGridViewTextBoxColumn.Name = "pERSONELSOYADIDataGridViewTextBoxColumn";
            // 
            // ıLDataGridViewTextBoxColumn
            // 
            this.ıLDataGridViewTextBoxColumn.DataPropertyName = "IL";
            this.ıLDataGridViewTextBoxColumn.HeaderText = "IL";
            this.ıLDataGridViewTextBoxColumn.Name = "ıLDataGridViewTextBoxColumn";
            // 
            // ıLCEDataGridViewTextBoxColumn
            // 
            this.ıLCEDataGridViewTextBoxColumn.DataPropertyName = "ILCE";
            this.ıLCEDataGridViewTextBoxColumn.HeaderText = "ILCE";
            this.ıLCEDataGridViewTextBoxColumn.Name = "ıLCEDataGridViewTextBoxColumn";
            // 
            // aDRESDataGridViewTextBoxColumn
            // 
            this.aDRESDataGridViewTextBoxColumn.DataPropertyName = "ADRES";
            this.aDRESDataGridViewTextBoxColumn.HeaderText = "ADRES";
            this.aDRESDataGridViewTextBoxColumn.Name = "aDRESDataGridViewTextBoxColumn";
            // 
            // mAASDataGridViewTextBoxColumn
            // 
            this.mAASDataGridViewTextBoxColumn.DataPropertyName = "MAAS";
            this.mAASDataGridViewTextBoxColumn.HeaderText = "MAAS";
            this.mAASDataGridViewTextBoxColumn.Name = "mAASDataGridViewTextBoxColumn";
            // 
            // tELEFONDataGridViewTextBoxColumn
            // 
            this.tELEFONDataGridViewTextBoxColumn.DataPropertyName = "TELEFON";
            this.tELEFONDataGridViewTextBoxColumn.HeaderText = "TELEFON";
            this.tELEFONDataGridViewTextBoxColumn.Name = "tELEFONDataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            // 
            // pERSONELBindingSource
            // 
            this.pERSONELBindingSource.DataMember = "PERSONEL";
            this.pERSONELBindingSource.DataSource = this.yeniimajservisDataSet1;
            // 
            // yeniimajservisDataSet1
            // 
            this.yeniimajservisDataSet1.DataSetName = "yeniimajservisDataSet1";
            this.yeniimajservisDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pERSONELTableAdapter
            // 
            this.pERSONELTableAdapter.ClearBeforeFill = true;
            // 
            // personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1120, 410);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "personel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "personel";
            this.Load += new System.EventHandler(this.personel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yeniimajservisDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.TextBox texttelefon;
        private System.Windows.Forms.TextBox textmaas;
        private System.Windows.Forms.TextBox textadres;
        private System.Windows.Forms.TextBox textilce;
        private System.Windows.Forms.TextBox textil;
        private System.Windows.Forms.TextBox textsoyadi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textadi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private yeniimajservisDataSet1 yeniimajservisDataSet1;
        private System.Windows.Forms.BindingSource pERSONELBindingSource;
        private yeniimajservisDataSet1TableAdapters.PERSONELTableAdapter pERSONELTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSONELIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSONELADIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSONELSOYADIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıLCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDRESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.ImageList imageList1;
    }
}
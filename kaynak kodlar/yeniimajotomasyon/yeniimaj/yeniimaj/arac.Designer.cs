
namespace yeniimaj
{
    partial class arac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(arac));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textkapasite = new System.Windows.Forms.TextBox();
            this.textplaka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.kaydet = new System.Windows.Forms.ImageList(this.components);
            this.btncikis = new System.Windows.Forms.Button();
            this.cıkıs = new System.Windows.Forms.ImageList(this.components);
            this.btnguncelle = new System.Windows.Forms.Button();
            this.güncelle = new System.Windows.Forms.ImageList(this.components);
            this.btnsil = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aRACIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLAKADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kAPASİTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRACBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yeniimajservisDataSet = new yeniimaj.yeniimajservisDataSet();
            this.aRACTableAdapter = new yeniimaj.yeniimajservisDataSetTableAdapters.ARACTableAdapter();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRACBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yeniimajservisDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textkapasite);
            this.panel1.Controls.Add(this.textplaka);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 102);
            this.panel1.TabIndex = 0;
            // 
            // textkapasite
            // 
            this.textkapasite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textkapasite.Location = new System.Drawing.Point(91, 60);
            this.textkapasite.Name = "textkapasite";
            this.textkapasite.Size = new System.Drawing.Size(134, 22);
            this.textkapasite.TabIndex = 3;
            this.textkapasite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textkapasite_KeyPress);
            // 
            // textplaka
            // 
            this.textplaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textplaka.Location = new System.Drawing.Point(91, 28);
            this.textplaka.Name = "textplaka";
            this.textplaka.Size = new System.Drawing.Size(134, 22);
            this.textplaka.TabIndex = 2;
            this.textplaka.TextChanged += new System.EventHandler(this.textplaka_TextChanged);
            this.textplaka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textplaka_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "KAPASİTE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLAKA NO:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnkaydet);
            this.panel3.Controls.Add(this.btncikis);
            this.panel3.Controls.Add(this.btnguncelle);
            this.panel3.Controls.Add(this.btnsil);
            this.panel3.Location = new System.Drawing.Point(3, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 80);
            this.panel3.TabIndex = 20;
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.Cornsilk;
            this.btnkaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkaydet.ImageKey = "icons8_ok_30px.png";
            this.btnkaydet.ImageList = this.kaydet;
            this.btnkaydet.Location = new System.Drawing.Point(14, 7);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(98, 32);
            this.btnkaydet.TabIndex = 19;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // kaydet
            // 
            this.kaydet.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("kaydet.ImageStream")));
            this.kaydet.TransparentColor = System.Drawing.Color.Transparent;
            this.kaydet.Images.SetKeyName(0, "icons8_ok_30px.png");
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.SystemColors.Info;
            this.btncikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncikis.ImageKey = "icons8_shutdown_26px.png";
            this.btncikis.ImageList = this.cıkıs;
            this.btncikis.Location = new System.Drawing.Point(130, 44);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(98, 32);
            this.btncikis.TabIndex = 22;
            this.btncikis.Text = "ÇIKIŞ";
            this.btncikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // cıkıs
            // 
            this.cıkıs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("cıkıs.ImageStream")));
            this.cıkıs.TransparentColor = System.Drawing.Color.Transparent;
            this.cıkıs.Images.SetKeyName(0, "icons8_shutdown_26px.png");
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.SystemColors.Info;
            this.btnguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguncelle.ImageKey = "icons8_update_left_rotation_48px.png";
            this.btnguncelle.ImageList = this.güncelle;
            this.btnguncelle.Location = new System.Drawing.Point(130, 6);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(98, 32);
            this.btnguncelle.TabIndex = 20;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // güncelle
            // 
            this.güncelle.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("güncelle.ImageStream")));
            this.güncelle.TransparentColor = System.Drawing.Color.Transparent;
            this.güncelle.Images.SetKeyName(0, "icons8_update_left_rotation_48px.png");
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.SystemColors.Info;
            this.btnsil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsil.ImageKey = "icons8_close_window_48px.png";
            this.btnsil.ImageList = this.sil;
            this.btnsil.Location = new System.Drawing.Point(13, 45);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(98, 32);
            this.btnsil.TabIndex = 21;
            this.btnsil.Text = "KAYIDI SİL";
            this.btnsil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // sil
            // 
            this.sil.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("sil.ImageStream")));
            this.sil.TransparentColor = System.Drawing.Color.Transparent;
            this.sil.Images.SetKeyName(0, "icons8_close_window_48px.png");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(232, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 189);
            this.panel2.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aRACIDDataGridViewTextBoxColumn,
            this.pLAKADataGridViewTextBoxColumn,
            this.kAPASİTEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aRACBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 189);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // aRACIDDataGridViewTextBoxColumn
            // 
            this.aRACIDDataGridViewTextBoxColumn.DataPropertyName = "ARACID";
            this.aRACIDDataGridViewTextBoxColumn.HeaderText = "ARACID";
            this.aRACIDDataGridViewTextBoxColumn.Name = "aRACIDDataGridViewTextBoxColumn";
            this.aRACIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pLAKADataGridViewTextBoxColumn
            // 
            this.pLAKADataGridViewTextBoxColumn.DataPropertyName = "PLAKA";
            this.pLAKADataGridViewTextBoxColumn.HeaderText = "PLAKA";
            this.pLAKADataGridViewTextBoxColumn.Name = "pLAKADataGridViewTextBoxColumn";
            // 
            // kAPASİTEDataGridViewTextBoxColumn
            // 
            this.kAPASİTEDataGridViewTextBoxColumn.DataPropertyName = "KAPASİTE";
            this.kAPASİTEDataGridViewTextBoxColumn.HeaderText = "KAPASİTE";
            this.kAPASİTEDataGridViewTextBoxColumn.Name = "kAPASİTEDataGridViewTextBoxColumn";
            // 
            // aRACBindingSource
            // 
            this.aRACBindingSource.DataMember = "ARAC";
            this.aRACBindingSource.DataSource = this.yeniimajservisDataSet;
            // 
            // yeniimajservisDataSet
            // 
            this.yeniimajservisDataSet.DataSetName = "yeniimajservisDataSet";
            this.yeniimajservisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aRACTableAdapter
            // 
            this.aRACTableAdapter.ClearBeforeFill = true;
            // 
            // arac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(578, 198);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "arac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "arac";
            this.Load += new System.EventHandler(this.arac_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRACBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yeniimajservisDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textkapasite;
        private System.Windows.Forms.TextBox textplaka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private yeniimajservisDataSet yeniimajservisDataSet;
        private System.Windows.Forms.BindingSource aRACBindingSource;
        private yeniimajservisDataSetTableAdapters.ARACTableAdapter aRACTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRACIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLAKADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kAPASİTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.ImageList kaydet;
        private System.Windows.Forms.ImageList sil;
        private System.Windows.Forms.ImageList güncelle;
        private System.Windows.Forms.ImageList cıkıs;
    }
}

namespace yeniimaj
{
    partial class personelmaas
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.yeniimajservisDataSet7 = new yeniimaj.yeniimajservisDataSet7();
            this.button1 = new System.Windows.Forms.Button();
            this.pERSONELTableAdapter = new yeniimaj.yeniimajservisDataSet7TableAdapters.PERSONELTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.combopersonel = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yeniimajservisDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(182, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Seç:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(7, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 84);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dataGridView1.Size = new System.Drawing.Size(802, 84);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.ıLDataGridViewTextBoxColumn.Visible = false;
            // 
            // ıLCEDataGridViewTextBoxColumn
            // 
            this.ıLCEDataGridViewTextBoxColumn.DataPropertyName = "ILCE";
            this.ıLCEDataGridViewTextBoxColumn.HeaderText = "ILCE";
            this.ıLCEDataGridViewTextBoxColumn.Name = "ıLCEDataGridViewTextBoxColumn";
            this.ıLCEDataGridViewTextBoxColumn.Visible = false;
            // 
            // aDRESDataGridViewTextBoxColumn
            // 
            this.aDRESDataGridViewTextBoxColumn.DataPropertyName = "ADRES";
            this.aDRESDataGridViewTextBoxColumn.HeaderText = "ADRES";
            this.aDRESDataGridViewTextBoxColumn.Name = "aDRESDataGridViewTextBoxColumn";
            this.aDRESDataGridViewTextBoxColumn.Visible = false;
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
            this.eMAILDataGridViewTextBoxColumn.Visible = false;
            // 
            // pERSONELBindingSource
            // 
            this.pERSONELBindingSource.DataMember = "PERSONEL";
            this.pERSONELBindingSource.DataSource = this.yeniimajservisDataSet7;
            // 
            // yeniimajservisDataSet7
            // 
            this.yeniimajservisDataSet7.DataSetName = "yeniimajservisDataSet7";
            this.yeniimajservisDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sorgula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pERSONELTableAdapter
            // 
            this.pERSONELTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(802, 148);
            this.dataGridView2.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(7, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 148);
            this.panel2.TabIndex = 11;
            // 
            // combopersonel
            // 
            this.combopersonel.FormattingEnabled = true;
            this.combopersonel.Location = new System.Drawing.Point(289, 25);
            this.combopersonel.Name = "combopersonel";
            this.combopersonel.Size = new System.Drawing.Size(172, 21);
            this.combopersonel.TabIndex = 12;
            this.combopersonel.SelectedIndexChanged += new System.EventHandler(this.combopersonel_SelectedIndexChanged_1);
            // 
            // personelmaas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(825, 335);
            this.Controls.Add(this.combopersonel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "personelmaas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "personelmaas";
            this.Load += new System.EventHandler(this.personelmaas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yeniimajservisDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private yeniimajservisDataSet7 yeniimajservisDataSet7;
        private System.Windows.Forms.BindingSource pERSONELBindingSource;
        private yeniimajservisDataSet7TableAdapters.PERSONELTableAdapter pERSONELTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSONELIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSONELADIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSONELSOYADIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıLCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDRESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox combopersonel;
    }
}
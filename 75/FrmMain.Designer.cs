
namespace _75
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtPrID = new System.Windows.Forms.TextBox();
            this.LblPrID = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.CmbBxShr = new System.Windows.Forms.ComboBox();
            this.MskdTxtBxMaas = new System.Windows.Forms.MaskedTextBox();
            this.LblPrMslk = new System.Windows.Forms.Label();
            this.LblPrDrm = new System.Windows.Forms.Label();
            this.TxtPrMslk = new System.Windows.Forms.TextBox();
            this.LblPrMaas = new System.Windows.Forms.Label();
            this.LblPrShr = new System.Windows.Forms.Label();
            this.TxtPrSyd = new System.Windows.Forms.TextBox();
            this.LblPrSyd = new System.Windows.Forms.Label();
            this.TxtPrAd = new System.Windows.Forms.TextBox();
            this.LblPrAd = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnGrfk = new System.Windows.Forms.Button();
            this.BtnIsttsk = new System.Windows.Forms.Button();
            this.BtnTmzlk = new System.Windows.Forms.Button();
            this.BtnGnclle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnKydt = new System.Windows.Forms.Button();
            this.BtnLstle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabaniDataSet = new _75.PersonelVeriTabaniDataSet();
            this.tbl_PersonelTableAdapter = new _75.PersonelVeriTabaniDataSetTableAdapters.Tbl_PersonelTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.TxtPrID);
            this.groupBox1.Controls.Add(this.LblPrID);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.CmbBxShr);
            this.groupBox1.Controls.Add(this.MskdTxtBxMaas);
            this.groupBox1.Controls.Add(this.LblPrMslk);
            this.groupBox1.Controls.Add(this.LblPrDrm);
            this.groupBox1.Controls.Add(this.TxtPrMslk);
            this.groupBox1.Controls.Add(this.LblPrMaas);
            this.groupBox1.Controls.Add(this.LblPrShr);
            this.groupBox1.Controls.Add(this.TxtPrSyd);
            this.groupBox1.Controls.Add(this.LblPrSyd);
            this.groupBox1.Controls.Add(this.TxtPrAd);
            this.groupBox1.Controls.Add(this.LblPrAd);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 414);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TxtPrID
            // 
            this.TxtPrID.Location = new System.Drawing.Point(154, 40);
            this.TxtPrID.Name = "TxtPrID";
            this.TxtPrID.Size = new System.Drawing.Size(179, 27);
            this.TxtPrID.TabIndex = 1;
            // 
            // LblPrID
            // 
            this.LblPrID.AutoSize = true;
            this.LblPrID.Location = new System.Drawing.Point(48, 43);
            this.LblPrID.Name = "LblPrID";
            this.LblPrID.Size = new System.Drawing.Size(97, 19);
            this.LblPrID.TabIndex = 16;
            this.LblPrID.Text = "Personel ID:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(239, 255);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 23);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bekar";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(154, 255);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 23);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Evli";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // CmbBxShr
            // 
            this.CmbBxShr.FormattingEnabled = true;
            this.CmbBxShr.Location = new System.Drawing.Point(154, 172);
            this.CmbBxShr.Name = "CmbBxShr";
            this.CmbBxShr.Size = new System.Drawing.Size(179, 27);
            this.CmbBxShr.TabIndex = 4;
            // 
            // MskdTxtBxMaas
            // 
            this.MskdTxtBxMaas.Location = new System.Drawing.Point(154, 215);
            this.MskdTxtBxMaas.Mask = "0000";
            this.MskdTxtBxMaas.Name = "MskdTxtBxMaas";
            this.MskdTxtBxMaas.Size = new System.Drawing.Size(179, 27);
            this.MskdTxtBxMaas.TabIndex = 5;
            this.MskdTxtBxMaas.ValidatingType = typeof(int);
            // 
            // LblPrMslk
            // 
            this.LblPrMslk.AutoSize = true;
            this.LblPrMslk.Location = new System.Drawing.Point(86, 291);
            this.LblPrMslk.Name = "LblPrMslk";
            this.LblPrMslk.Size = new System.Drawing.Size(62, 19);
            this.LblPrMslk.TabIndex = 11;
            this.LblPrMslk.Text = "Meslek:";
            // 
            // LblPrDrm
            // 
            this.LblPrDrm.AutoSize = true;
            this.LblPrDrm.Location = new System.Drawing.Point(84, 255);
            this.LblPrDrm.Name = "LblPrDrm";
            this.LblPrDrm.Size = new System.Drawing.Size(64, 19);
            this.LblPrDrm.TabIndex = 9;
            this.LblPrDrm.Text = "Durum:";
            // 
            // TxtPrMslk
            // 
            this.TxtPrMslk.Location = new System.Drawing.Point(154, 291);
            this.TxtPrMslk.Name = "TxtPrMslk";
            this.TxtPrMslk.Size = new System.Drawing.Size(179, 27);
            this.TxtPrMslk.TabIndex = 6;
            // 
            // LblPrMaas
            // 
            this.LblPrMaas.AutoSize = true;
            this.LblPrMaas.Location = new System.Drawing.Point(98, 215);
            this.LblPrMaas.Name = "LblPrMaas";
            this.LblPrMaas.Size = new System.Drawing.Size(50, 19);
            this.LblPrMaas.TabIndex = 7;
            this.LblPrMaas.Text = "Maas:";
            // 
            // LblPrShr
            // 
            this.LblPrShr.AutoSize = true;
            this.LblPrShr.Location = new System.Drawing.Point(97, 175);
            this.LblPrShr.Name = "LblPrShr";
            this.LblPrShr.Size = new System.Drawing.Size(51, 19);
            this.LblPrShr.TabIndex = 5;
            this.LblPrShr.Text = "Şehir:";
            // 
            // TxtPrSyd
            // 
            this.TxtPrSyd.Location = new System.Drawing.Point(154, 128);
            this.TxtPrSyd.Name = "TxtPrSyd";
            this.TxtPrSyd.Size = new System.Drawing.Size(179, 27);
            this.TxtPrSyd.TabIndex = 3;
            // 
            // LblPrSyd
            // 
            this.LblPrSyd.AutoSize = true;
            this.LblPrSyd.Location = new System.Drawing.Point(25, 131);
            this.LblPrSyd.Name = "LblPrSyd";
            this.LblPrSyd.Size = new System.Drawing.Size(123, 19);
            this.LblPrSyd.TabIndex = 3;
            this.LblPrSyd.Text = "Personel Soyad:";
            // 
            // TxtPrAd
            // 
            this.TxtPrAd.Location = new System.Drawing.Point(154, 81);
            this.TxtPrAd.Name = "TxtPrAd";
            this.TxtPrAd.Size = new System.Drawing.Size(179, 27);
            this.TxtPrAd.TabIndex = 2;
            // 
            // LblPrAd
            // 
            this.LblPrAd.AutoSize = true;
            this.LblPrAd.Location = new System.Drawing.Point(48, 84);
            this.LblPrAd.Name = "LblPrAd";
            this.LblPrAd.Size = new System.Drawing.Size(100, 19);
            this.LblPrAd.TabIndex = 1;
            this.LblPrAd.Text = "Personel Ad:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.BtnGrfk);
            this.groupBox2.Controls.Add(this.BtnIsttsk);
            this.groupBox2.Controls.Add(this.BtnTmzlk);
            this.groupBox2.Controls.Add(this.BtnGnclle);
            this.groupBox2.Controls.Add(this.BtnSil);
            this.groupBox2.Controls.Add(this.BtnKydt);
            this.groupBox2.Controls.Add(this.BtnLstle);
            this.groupBox2.Location = new System.Drawing.Point(416, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 414);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // BtnGrfk
            // 
            this.BtnGrfk.Location = new System.Drawing.Point(69, 325);
            this.BtnGrfk.Name = "BtnGrfk";
            this.BtnGrfk.Size = new System.Drawing.Size(195, 36);
            this.BtnGrfk.TabIndex = 6;
            this.BtnGrfk.Text = "Grafikler";
            this.BtnGrfk.UseVisualStyleBackColor = true;
            this.BtnGrfk.Click += new System.EventHandler(this.BtnGrfk_Click);
            // 
            // BtnIsttsk
            // 
            this.BtnIsttsk.Location = new System.Drawing.Point(69, 273);
            this.BtnIsttsk.Name = "BtnIsttsk";
            this.BtnIsttsk.Size = new System.Drawing.Size(195, 36);
            this.BtnIsttsk.TabIndex = 5;
            this.BtnIsttsk.Text = "İstatistik";
            this.BtnIsttsk.UseVisualStyleBackColor = true;
            this.BtnIsttsk.Click += new System.EventHandler(this.BtnIsttsk_Click);
            // 
            // BtnTmzlk
            // 
            this.BtnTmzlk.Location = new System.Drawing.Point(69, 226);
            this.BtnTmzlk.Name = "BtnTmzlk";
            this.BtnTmzlk.Size = new System.Drawing.Size(195, 36);
            this.BtnTmzlk.TabIndex = 4;
            this.BtnTmzlk.Text = "Temizle";
            this.BtnTmzlk.UseVisualStyleBackColor = true;
            this.BtnTmzlk.Click += new System.EventHandler(this.BtnTmzlk_Click);
            // 
            // BtnGnclle
            // 
            this.BtnGnclle.Location = new System.Drawing.Point(69, 174);
            this.BtnGnclle.Name = "BtnGnclle";
            this.BtnGnclle.Size = new System.Drawing.Size(195, 36);
            this.BtnGnclle.TabIndex = 3;
            this.BtnGnclle.Text = "Güncelle";
            this.BtnGnclle.UseVisualStyleBackColor = true;
            this.BtnGnclle.Click += new System.EventHandler(this.BtnGnclle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(69, 127);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(195, 36);
            this.BtnSil.TabIndex = 2;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKydt
            // 
            this.BtnKydt.Location = new System.Drawing.Point(69, 72);
            this.BtnKydt.Name = "BtnKydt";
            this.BtnKydt.Size = new System.Drawing.Size(195, 36);
            this.BtnKydt.TabIndex = 1;
            this.BtnKydt.Text = "Kaydet";
            this.BtnKydt.UseVisualStyleBackColor = true;
            this.BtnKydt.Click += new System.EventHandler(this.BtnKydt_Click);
            // 
            // BtnLstle
            // 
            this.BtnLstle.Location = new System.Drawing.Point(69, 20);
            this.BtnLstle.Name = "BtnLstle";
            this.BtnLstle.Size = new System.Drawing.Size(195, 36);
            this.BtnLstle.TabIndex = 0;
            this.BtnLstle.Text = "Listele";
            this.BtnLstle.UseVisualStyleBackColor = true;
            this.BtnLstle.Click += new System.EventHandler(this.BtnLstle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 471);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(760, 172);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 146);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "Perid";
            this.peridDataGridViewTextBoxColumn.HeaderText = "Perid";
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            // 
            // perDurumDataGridViewCheckBoxColumn
            // 
            this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.HeaderText = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personelVeriTabaniDataSet;
            // 
            // personelVeriTabaniDataSet
            // 
            this.personelVeriTabaniDataSet.DataSetName = "PersonelVeriTabaniDataSet";
            this.personelVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(760, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(841, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(867, 584);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Raporlar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(937, 665);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Personel Takip Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbBxShr;
        private System.Windows.Forms.MaskedTextBox MskdTxtBxMaas;
        private System.Windows.Forms.Label LblPrMslk;
        private System.Windows.Forms.Label LblPrDrm;
        private System.Windows.Forms.TextBox TxtPrMslk;
        private System.Windows.Forms.Label LblPrMaas;
        private System.Windows.Forms.Label LblPrShr;
        private System.Windows.Forms.TextBox TxtPrSyd;
        private System.Windows.Forms.Label LblPrSyd;
        private System.Windows.Forms.TextBox TxtPrAd;
        private System.Windows.Forms.Label LblPrAd;
        private System.Windows.Forms.TextBox TxtPrID;
        private System.Windows.Forms.Label LblPrID;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnGrfk;
        private System.Windows.Forms.Button BtnIsttsk;
        private System.Windows.Forms.Button BtnTmzlk;
        private System.Windows.Forms.Button BtnGnclle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnKydt;
        private System.Windows.Forms.Button BtnLstle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PersonelVeriTabaniDataSet personelVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private PersonelVeriTabaniDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}


namespace OkulOtomasyon
{
    partial class FrmOgretmenler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgretmenler));
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.CmbBrans = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Cmbilce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Cmbil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.TxtAd = new DevExpress.XtraEditors.TextEdit();
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.PcrResim = new System.Windows.Forms.PictureBox();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.BtnResimSec = new DevExpress.XtraEditors.SimpleButton();
            this.RchAdres = new System.Windows.Forms.RichTextBox();
            this.TxtMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbBrans.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcrResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // vGridControl1
            // 
            this.vGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.vGridControl1.Location = new System.Drawing.Point(12, 12);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.Size = new System.Drawing.Size(1025, 799);
            this.vGridControl1.TabIndex = 1;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(1055, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(458, 799);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(456, 753);
            this.xtraTabPage1.Text = "Öğretmen Bilgi-1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(450, 907);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "groupControl1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.MskTelefon);
            this.groupControl2.Controls.Add(this.CmbBrans);
            this.groupControl2.Controls.Add(this.Cmbilce);
            this.groupControl2.Controls.Add(this.Cmbil);
            this.groupControl2.Controls.Add(this.MskTC);
            this.groupControl2.Controls.Add(this.TxtSoyad);
            this.groupControl2.Controls.Add(this.TxtAd);
            this.groupControl2.Controls.Add(this.TxtID);
            this.groupControl2.Controls.Add(this.labelControl13);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Location = new System.Drawing.Point(8, 8);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(450, 907);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "groupControl2";
            // 
            // MskTelefon
            // 
            this.MskTelefon.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTelefon.Location = new System.Drawing.Point(154, 286);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(209, 35);
            this.MskTelefon.TabIndex = 19;
            // 
            // CmbBrans
            // 
            this.CmbBrans.Location = new System.Drawing.Point(154, 438);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbBrans.Properties.Appearance.Options.UseFont = true;
            this.CmbBrans.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbBrans.Size = new System.Drawing.Size(209, 34);
            this.CmbBrans.TabIndex = 18;
            // 
            // Cmbilce
            // 
            this.Cmbilce.Location = new System.Drawing.Point(154, 391);
            this.Cmbilce.Name = "Cmbilce";
            this.Cmbilce.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cmbilce.Properties.Appearance.Options.UseFont = true;
            this.Cmbilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cmbilce.Size = new System.Drawing.Size(209, 34);
            this.Cmbilce.TabIndex = 17;
            // 
            // Cmbil
            // 
            this.Cmbil.Location = new System.Drawing.Point(154, 341);
            this.Cmbil.Name = "Cmbil";
            this.Cmbil.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cmbil.Properties.Appearance.Options.UseFont = true;
            this.Cmbil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cmbil.Size = new System.Drawing.Size(209, 34);
            this.Cmbil.TabIndex = 16;
            // 
            // MskTC
            // 
            this.MskTC.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTC.Location = new System.Drawing.Point(154, 240);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(209, 35);
            this.MskTC.TabIndex = 15;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(154, 193);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyad.Properties.Appearance.Options.UseFont = true;
            this.TxtSoyad.Size = new System.Drawing.Size(209, 34);
            this.TxtSoyad.TabIndex = 10;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(154, 144);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Properties.Appearance.Options.UseFont = true;
            this.TxtAd.Size = new System.Drawing.Size(209, 34);
            this.TxtAd.TabIndex = 9;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(154, 95);
            this.TxtID.Name = "TxtID";
            this.TxtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtID.Properties.Appearance.Options.UseFont = true;
            this.TxtID.Size = new System.Drawing.Size(209, 34);
            this.TxtID.TabIndex = 8;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(60, 448);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(73, 24);
            this.labelControl13.TabIndex = 7;
            this.labelControl13.Text = "BRANŞ :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(80, 401);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(53, 24);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "İLÇE :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(97, 344);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(36, 24);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = " İL :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(39, 292);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(94, 24);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "TELEFON :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(84, 248);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 24);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "T.C. :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(57, 199);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 24);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "SOYAD :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(94, 147);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 24);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "AD :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(99, 98);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID :";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.PcrResim);
            this.xtraTabPage2.Controls.Add(this.BtnTemizle);
            this.xtraTabPage2.Controls.Add(this.BtnGuncelle);
            this.xtraTabPage2.Controls.Add(this.BtnSil);
            this.xtraTabPage2.Controls.Add(this.BtnKaydet);
            this.xtraTabPage2.Controls.Add(this.BtnResimSec);
            this.xtraTabPage2.Controls.Add(this.RchAdres);
            this.xtraTabPage2.Controls.Add(this.TxtMail);
            this.xtraTabPage2.Controls.Add(this.labelControl15);
            this.xtraTabPage2.Controls.Add(this.labelControl16);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(456, 753);
            this.xtraTabPage2.Text = "Öğretmen Bilgi-2";
            // 
            // PcrResim
            // 
            this.PcrResim.Location = new System.Drawing.Point(212, 33);
            this.PcrResim.Name = "PcrResim";
            this.PcrResim.Size = new System.Drawing.Size(145, 147);
            this.PcrResim.TabIndex = 43;
            this.PcrResim.TabStop = false;
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(188, 673);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(169, 51);
            this.BtnTemizle.TabIndex = 42;
            this.BtnTemizle.Text = "Temizle";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(188, 607);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(169, 51);
            this.BtnGuncelle.TabIndex = 41;
            this.BtnGuncelle.Text = "Güncelle";
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(188, 539);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(169, 51);
            this.BtnSil.TabIndex = 40;
            this.BtnSil.Text = "Sil";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(188, 473);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(169, 51);
            this.BtnKaydet.TabIndex = 39;
            this.BtnKaydet.Text = "Kaydet";
            // 
            // BtnResimSec
            // 
            this.BtnResimSec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnResimSec.ImageOptions.Image")));
            this.BtnResimSec.Location = new System.Drawing.Point(188, 407);
            this.BtnResimSec.Name = "BtnResimSec";
            this.BtnResimSec.Size = new System.Drawing.Size(169, 51);
            this.BtnResimSec.TabIndex = 38;
            this.BtnResimSec.Text = "Resim Seç";
            // 
            // RchAdres
            // 
            this.RchAdres.Location = new System.Drawing.Point(148, 247);
            this.RchAdres.Name = "RchAdres";
            this.RchAdres.Size = new System.Drawing.Size(209, 146);
            this.RchAdres.TabIndex = 37;
            this.RchAdres.Text = "";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(148, 198);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMail.Properties.Appearance.Options.UseFont = true;
            this.TxtMail.Size = new System.Drawing.Size(209, 34);
            this.TxtMail.TabIndex = 36;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(26, 247);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(73, 24);
            this.labelControl15.TabIndex = 35;
            this.labelControl15.Text = "ADRES :";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(42, 202);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(57, 24);
            this.labelControl16.TabIndex = 34;
            this.labelControl16.Text = "MAİL :";
            // 
            // FrmOgretmenler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 823);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.vGridControl1);
            this.Name = "FrmOgretmenler";
            this.Text = "FrmOgretmenler";
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbBrans.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcrResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtSoyad;
        private DevExpress.XtraEditors.TextEdit TxtAd;
        private DevExpress.XtraEditors.TextEdit TxtID;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private DevExpress.XtraEditors.ComboBoxEdit CmbBrans;
        private DevExpress.XtraEditors.ComboBoxEdit Cmbilce;
        private DevExpress.XtraEditors.ComboBoxEdit Cmbil;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.SimpleButton BtnResimSec;
        private System.Windows.Forms.RichTextBox RchAdres;
        private DevExpress.XtraEditors.TextEdit TxtMail;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.PictureBox PcrResim;
    }
}
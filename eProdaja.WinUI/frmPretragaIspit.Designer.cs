
namespace eProdaja.WinUI
{
    partial class frmPretragaIspit
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
            this.vrstaProizvodaCombobox = new System.Windows.Forms.ComboBox();
            this.datumOdDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datumDoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.minIznosNovcaTextBox = new System.Windows.Forms.TextBox();
            this.tražiButton = new System.Windows.Forms.Button();
            this.pretragaIspitDataGridView = new System.Windows.Forms.DataGridView();
            this.lblSumaPrometa = new System.Windows.Forms.Label();
            this.pohraniRezultateButton = new System.Windows.Forms.Button();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupanPromet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pretragaIspitDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vrstaProizvodaCombobox
            // 
            this.vrstaProizvodaCombobox.FormattingEnabled = true;
            this.vrstaProizvodaCombobox.Location = new System.Drawing.Point(13, 13);
            this.vrstaProizvodaCombobox.Name = "vrstaProizvodaCombobox";
            this.vrstaProizvodaCombobox.Size = new System.Drawing.Size(121, 21);
            this.vrstaProizvodaCombobox.TabIndex = 0;
            // 
            // datumOdDateTimePicker
            // 
            this.datumOdDateTimePicker.Location = new System.Drawing.Point(151, 13);
            this.datumOdDateTimePicker.Name = "datumOdDateTimePicker";
            this.datumOdDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datumOdDateTimePicker.TabIndex = 1;
            // 
            // datumDoDateTimePicker
            // 
            this.datumDoDateTimePicker.Location = new System.Drawing.Point(370, 12);
            this.datumDoDateTimePicker.Name = "datumDoDateTimePicker";
            this.datumDoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datumDoDateTimePicker.TabIndex = 2;
            // 
            // minIznosNovcaTextBox
            // 
            this.minIznosNovcaTextBox.Location = new System.Drawing.Point(587, 12);
            this.minIznosNovcaTextBox.Name = "minIznosNovcaTextBox";
            this.minIznosNovcaTextBox.Size = new System.Drawing.Size(100, 20);
            this.minIznosNovcaTextBox.TabIndex = 3;
            this.minIznosNovcaTextBox.Text = "0";
            // 
            // tražiButton
            // 
            this.tražiButton.Location = new System.Drawing.Point(703, 12);
            this.tražiButton.Name = "tražiButton";
            this.tražiButton.Size = new System.Drawing.Size(75, 23);
            this.tražiButton.TabIndex = 4;
            this.tražiButton.Text = "Traži";
            this.tražiButton.UseVisualStyleBackColor = true;
            this.tražiButton.Click += new System.EventHandler(this.tražiButton_Click);
            // 
            // pretragaIspitDataGridView
            // 
            this.pretragaIspitDataGridView.AllowUserToAddRows = false;
            this.pretragaIspitDataGridView.AllowUserToDeleteRows = false;
            this.pretragaIspitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pretragaIspitDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.UkupanPromet});
            this.pretragaIspitDataGridView.Location = new System.Drawing.Point(13, 41);
            this.pretragaIspitDataGridView.Name = "pretragaIspitDataGridView";
            this.pretragaIspitDataGridView.ReadOnly = true;
            this.pretragaIspitDataGridView.Size = new System.Drawing.Size(765, 342);
            this.pretragaIspitDataGridView.TabIndex = 5;
            // 
            // lblSumaPrometa
            // 
            this.lblSumaPrometa.AutoSize = true;
            this.lblSumaPrometa.Location = new System.Drawing.Point(544, 397);
            this.lblSumaPrometa.Name = "lblSumaPrometa";
            this.lblSumaPrometa.Size = new System.Drawing.Size(35, 13);
            this.lblSumaPrometa.TabIndex = 6;
            this.lblSumaPrometa.Text = "label1";
            // 
            // pohraniRezultateButton
            // 
            this.pohraniRezultateButton.Location = new System.Drawing.Point(13, 386);
            this.pohraniRezultateButton.Name = "pohraniRezultateButton";
            this.pohraniRezultateButton.Size = new System.Drawing.Size(99, 23);
            this.pohraniRezultateButton.TabIndex = 7;
            this.pohraniRezultateButton.Text = "Pohrani rezultate";
            this.pohraniRezultateButton.UseVisualStyleBackColor = true;
            this.pohraniRezultateButton.Click += new System.EventHandler(this.pohraniRezultateButton_Click);
            // 
            // ImePrezime
            // 
            this.ImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImePrezime.DataPropertyName = "Kupac";
            this.ImePrezime.HeaderText = "Ime i prezime kupca";
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            // 
            // UkupanPromet
            // 
            this.UkupanPromet.DataPropertyName = "IznosSaPdv";
            this.UkupanPromet.HeaderText = "Ukupan promet";
            this.UkupanPromet.Name = "UkupanPromet";
            this.UkupanPromet.ReadOnly = true;
            this.UkupanPromet.Width = 150;
            // 
            // frmPretragaIspit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.pohraniRezultateButton);
            this.Controls.Add(this.lblSumaPrometa);
            this.Controls.Add(this.pretragaIspitDataGridView);
            this.Controls.Add(this.tražiButton);
            this.Controls.Add(this.minIznosNovcaTextBox);
            this.Controls.Add(this.datumDoDateTimePicker);
            this.Controls.Add(this.datumOdDateTimePicker);
            this.Controls.Add(this.vrstaProizvodaCombobox);
            this.Name = "frmPretragaIspit";
            this.Text = "frmPretragaIspit";
            this.Load += new System.EventHandler(this.frmPretragaIspit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pretragaIspitDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox vrstaProizvodaCombobox;
        private System.Windows.Forms.DateTimePicker datumOdDateTimePicker;
        private System.Windows.Forms.DateTimePicker datumDoDateTimePicker;
        private System.Windows.Forms.TextBox minIznosNovcaTextBox;
        private System.Windows.Forms.Button tražiButton;
        private System.Windows.Forms.DataGridView pretragaIspitDataGridView;
        private System.Windows.Forms.Label lblSumaPrometa;
        private System.Windows.Forms.Button pohraniRezultateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupanPromet;
    }
}
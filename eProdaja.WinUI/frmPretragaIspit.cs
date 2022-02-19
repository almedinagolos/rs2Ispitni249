using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdaja.WinUI
{
    public partial class frmPretragaIspit : Form
    {
        private readonly APIService _serviceIzlazi = new APIService("Izlazi");
        private readonly APIService _servicePretragaIspit = new APIService("PretragaIspit");
        private readonly APIService _serviceVrsteProizvoda = new APIService("VrsteProizvodum");
        public frmPretragaIspit()
        {
            InitializeComponent();
            pretragaIspitDataGridView.AutoGenerateColumns = false;
        }

        private async void frmPretragaIspit_Load(object sender, EventArgs e)
        {
            await UcitajVrsteProizvoda();
            await UcitajIzlaze();
        }

        private async Task UcitajVrsteProizvoda()
        {
            var list = await _serviceVrsteProizvoda.GetAll<List<Model.VrsteProizvodum>>(null);
            vrstaProizvodaCombobox.DataSource = list;
            vrstaProizvodaCombobox.ValueMember = "VrstaId";
            vrstaProizvodaCombobox.DisplayMember = "Naziv";
        }

        private async void tražiButton_Click(object sender, EventArgs e)
        {
            await UcitajIzlaze();
        }

        private async Task UcitajIzlaze()
        {
            var request = new Model.Requests.IzlaziSearchRequest
            {
                VrstaProizvodaId = int.Parse(vrstaProizvodaCombobox.SelectedValue.ToString()),
                DatumDo = datumDoDateTimePicker.Value,
                DatumOd = datumOdDateTimePicker.Value,
                MinIznosPrometa = int.Parse(minIznosNovcaTextBox.Text)
            };

            var list = await _serviceIzlazi.GetAll<List<Model.Izlazi>>(request);
            pretragaIspitDataGridView.DataSource = list;

            lblSumaPrometa.Text = $"Ukupni promet: {list.Sum(x => x.IznosSaPdv).ToString("0.00")} KM";
        }

        private async void pohraniRezultateButton_Click(object sender, EventArgs e)
        {
            var list = pretragaIspitDataGridView.DataSource as List<Model.Izlazi>;
            foreach (var item in list)
            {
                var request = new Model.Requests.PretragaIspitInsertRequest
                {
                    VrsteProizvodumId = int.Parse(vrstaProizvodaCombobox.SelectedValue.ToString()),
                    DatumDo = datumDoDateTimePicker.Value,
                    DatumOd = datumOdDateTimePicker.Value,
                    MinIznosPrometa = int.Parse(minIznosNovcaTextBox.Text),
                    IznosPrometa = item.IznosSaPdv,
                    KorisniciId = item.KorisnikId
                };

                await _servicePretragaIspit.Insert<Model.Izlazi>(request);
            }

            MessageBox.Show("Podaci uneseni u bazu.");
        }
    }
}

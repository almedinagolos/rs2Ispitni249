using eProdaja.Mobile.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Mobile.ViewModels
{
    public class PrometKorisnikaViewModel : BaseViewModel
    {
        private readonly APIService _korisniciService = new APIService("Korisnici");
        private readonly APIService _pretragaIspitService = new APIService("PretragaIspit");

        public ObservableCollection<Model.Korisnici> KorisnikList { get; set; } = new ObservableCollection<Model.Korisnici>();
        public ObservableCollection<Model.PretragaIspit> PretragaIspitList { get; set; } = new ObservableCollection<Model.PretragaIspit>();

        public async Task Init()
        {
            PretragaIspitList.Clear();

            var korisnici = await _korisniciService.Get<List<Model.Korisnici>>();

            KorisnikList.Clear();
            foreach (var item in korisnici)
            {
                KorisnikList.Add(item);
            }
        }

        private Model.Korisnici selectedKorisnik;

        public Model.Korisnici SelectedKorisnik
        {
            get { return selectedKorisnik; }
            set {
                SetProperty(ref selectedKorisnik, value);
                if(value != null)
                    LoadPretragaIspit();
            }
        }

        private async void LoadPretragaIspit()
        {
            var request = new Model.Requests.PretragaIspitSearchRequest
            {
                KorisnikId = selectedKorisnik.KorisnikId
            };

            var pretrageIspiti = await _pretragaIspitService.Get<List<Model.PretragaIspit>>(request);

            PretragaIspitList.Clear();
            foreach (var item in pretrageIspiti)
            {
                PretragaIspitList.Add(item);
            }
        }
    }
}

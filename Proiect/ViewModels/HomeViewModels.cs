using Proiect.Models;
using Proiect.Services;
using Proiect.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        ObservableCollection<Produse> _produses;

        public HomeViewModel()
        {
            LoadData();
        }

        public ObservableCollection<Produse> Produses
        {
            get { return _produses; }
            set
            {
                _produses = value;
                OnPropertyChanged();
            }
        }

        private void LoadData()
        {
            Produses = new ObservableCollection<Produse>();

            // Add first fake item
            Produses.Add(new Produse());

            foreach (var product in ProduseService.Instance.GetProducts())
                Produses.Add(product);
        }
    }
}

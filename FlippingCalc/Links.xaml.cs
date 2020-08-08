using CsvHelper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using ControlzEx.Theming;

namespace FlippingCalc
{
    /// <summary>
    /// Interaction logic for Links.xaml
    /// </summary>
    public partial class Links : MetroWindow, INotifyPropertyChanged
    {
        public Links()
        {
            InitializeComponent();
            DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
            e.Handled = true;
        }

        private ObservableCollection<LeagueCurrency> _LeagueCurrency;
        public ObservableCollection<LeagueCurrency> LeagueCurrency
        {
            get => _LeagueCurrency;
            set
            {
                _LeagueCurrency = value;
                OnPropertyChanged(nameof(LeagueCurrency));
            }
        }
        private ObservableCollection<LeagueFossil> _LeagueFossil;
        public ObservableCollection<LeagueFossil> LeagueFossil
        {
            get => _LeagueFossil;
            set
            {
                _LeagueFossil = value;
                OnPropertyChanged(nameof(LeagueFossil));
            }
        }
        private ObservableCollection<LeagueOil> _LeagueOil;
        public ObservableCollection<LeagueOil> LeagueOil
        {
            get => _LeagueOil;
            set
            {
                _LeagueOil = value;
                OnPropertyChanged(nameof(LeagueOil));
            }
        }
        private ObservableCollection<LeagueCatalyst> _LeagueCatalyst;
        public ObservableCollection<LeagueCatalyst> LeagueCatalyst
        {
            get => _LeagueCatalyst;
            set
            {
                _LeagueCatalyst = value;
                OnPropertyChanged(nameof(LeagueCatalyst));
            }
        }
        private ObservableCollection<LeagueFragment> _LeagueFragment;
        public ObservableCollection<LeagueFragment> LeagueFragment
        {
            get => _LeagueFragment;
            set
            {
                _LeagueFragment = value;
                OnPropertyChanged(nameof(LeagueFragment));
            }
        }
        private ObservableCollection<LeagueHCCurrency> _LeagueHCCurrency;
        public ObservableCollection<LeagueHCCurrency> LeagueHCCurrency
        {
            get => _LeagueHCCurrency;
            set
            {
                _LeagueHCCurrency = value;
                OnPropertyChanged(nameof(LeagueHCCurrency));
            }
        }
        private ObservableCollection<LeagueHCFossil> _LeagueHCFossil;
        public ObservableCollection<LeagueHCFossil> LeagueHCFossil
        {
            get => _LeagueHCFossil;
            set
            {
                _LeagueHCFossil = value;
                OnPropertyChanged(nameof(LeagueHCFossil));
            }
        }
        private ObservableCollection<LeagueHCOil> _LeagueHCOil;
        public ObservableCollection<LeagueHCOil> LeagueHCOil
        {
            get => _LeagueHCOil;
            set
            {
                _LeagueHCOil = value;
                OnPropertyChanged(nameof(LeagueHCOil));
            }
        }
        private ObservableCollection<LeagueHCCatalyst> _LeagueHCCatalyst;
        public ObservableCollection<LeagueHCCatalyst> LeagueHCCatalyst
        {
            get => _LeagueHCCatalyst;
            set
            {
                _LeagueHCCatalyst = value;
                OnPropertyChanged(nameof(LeagueHCCatalyst));
            }
        }
        private ObservableCollection<LeagueHCFragment> _LeagueHCFragment;
        public ObservableCollection<LeagueHCFragment> LeagueHCFragment
        {
            get => _LeagueHCFragment;
            set
            {
                _LeagueHCFragment = value;
                OnPropertyChanged(nameof(LeagueHCFragment));
            }
        }
        private ObservableCollection<StandardCurrency> _StandardCurrency;
        public ObservableCollection<StandardCurrency> StandardCurrency
        {
            get => _StandardCurrency;
            set
            {
                _StandardCurrency = value;
                OnPropertyChanged(nameof(StandardCurrency));
            }
        }
        private ObservableCollection<StandardFossil> _StandardFossil;
        public ObservableCollection<StandardFossil> StandardFossil
        {
            get => _StandardFossil;
            set
            {
                _StandardFossil = value;
                OnPropertyChanged(nameof(StandardFossil));
            }
        }
        private ObservableCollection<StandardOil> _StandardOil;
        public ObservableCollection<StandardOil> StandardOil
        {
            get => _StandardOil;
            set
            {
                _StandardOil = value;
                OnPropertyChanged(nameof(StandardOil));
            }
        }
        private ObservableCollection<StandardCatalyst> _StandardCatalyst;
        public ObservableCollection<StandardCatalyst> StandardCatalyst
        {
            get => _StandardCatalyst;
            set
            {
                _StandardCatalyst = value;
                OnPropertyChanged(nameof(StandardCatalyst));
            }
        }
        private ObservableCollection<StandardFragment> _StandardFragment;
        public ObservableCollection<StandardFragment> StandardFragment
        {
            get => _StandardFragment;
            set
            {
                _StandardFragment = value;
                OnPropertyChanged(nameof(StandardFragment));
            }
        }
        private ObservableCollection<HardcoreCurrency> _HardcoreCurrency;
        public ObservableCollection<HardcoreCurrency> HardcoreCurrency
        {
            get => _HardcoreCurrency;
            set
            {
                _HardcoreCurrency = value;
                OnPropertyChanged(nameof(HardcoreCurrency));
            }
        }
        private ObservableCollection<HardcoreFossil> _HardcoreFossil;
        public ObservableCollection<HardcoreFossil> HardcoreFossil
        {
            get => _HardcoreFossil;
            set
            {
                _HardcoreFossil = value;
                OnPropertyChanged(nameof(HardcoreFossil));
            }
        }
        private ObservableCollection<HardcoreOil> _HardcoreOil;
        public ObservableCollection<HardcoreOil> HardcoreOil
        {
            get => _HardcoreOil;
            set
            {
                _HardcoreOil = value;
                OnPropertyChanged(nameof(HardcoreOil));
            }
        }
        private ObservableCollection<HardcoreCatalyst> _HardcoreCatalyst;
        public ObservableCollection<HardcoreCatalyst> HardcoreCatalyst
        {
            get => _HardcoreCatalyst;
            set
            {
                _HardcoreCatalyst = value;
                OnPropertyChanged(nameof(HardcoreCatalyst));
            }
        }
        private ObservableCollection<HardcoreFragment> _HardcoreFragment;
        public ObservableCollection<HardcoreFragment> HardcoreFragment
        {
            get => _HardcoreFragment;
            set
            {
                _HardcoreFragment = value;
                OnPropertyChanged(nameof(HardcoreFragment));
            }
        }

        private void OnWindowLoad(object sender, RoutedEventArgs e)
        {
            using (var reader = new StreamReader("data\\Assets\\LeagueCurrency.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                var records = csv.GetRecords<LeagueCurrency>();
                LeagueCurrency = new ObservableCollection<LeagueCurrency>(records);
            }
            using (var reader = new StreamReader("data\\Assets\\LeagueFossil.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                var records = csv.GetRecords<LeagueFossil>();
                LeagueFossil = new ObservableCollection<LeagueFossil>(records);
            }
            using (var reader = new StreamReader("data\\Assets\\LeagueOil.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                var records = csv.GetRecords<LeagueOil>();
                LeagueOil = new ObservableCollection<LeagueOil>(records);
            }
            using (var reader = new StreamReader("data\\Assets\\LeagueCatalyst.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                var records = csv.GetRecords<LeagueCatalyst>();
                LeagueCatalyst = new ObservableCollection<LeagueCatalyst>(records);
            }
            using (var reader = new StreamReader("data\\Assets\\LeagueFragment.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                var records = csv.GetRecords<LeagueFragment>();
                LeagueFragment = new ObservableCollection<LeagueFragment>(records);
            }
            using (var reader = new StreamReader("data\\Assets\\LeagueHCCurrency.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                var records = csv.GetRecords<LeagueHCCurrency>();
                LeagueHCCurrency = new ObservableCollection<LeagueHCCurrency>(records);
            }
            using (var reader = new StreamReader("data\\Assets\\LeagueHCFossil.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                var records = csv.GetRecords<LeagueHCFossil>();
                LeagueHCFossil = new ObservableCollection<LeagueHCFossil>(records);
            }
            using (var reader = new StreamReader("data\\Assets\\LeagueHCOil.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                var records = csv.GetRecords<LeagueHCOil>();
                LeagueHCOil = new ObservableCollection<LeagueHCOil>(records);
            }
            using (var reader = new StreamReader("data\\Assets\\LeagueHCCatalyst.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                var records = csv.GetRecords<LeagueHCCatalyst>();
                LeagueHCCatalyst = new ObservableCollection<LeagueHCCatalyst>(records);
            }
            using (var reader = new StreamReader("data\\Assets\\LeagueHCFragment.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                var records = csv.GetRecords<LeagueHCFragment>();
                LeagueHCFragment = new ObservableCollection<LeagueHCFragment>(records);
            }
            using (var reader = new StreamReader("data\\Assets\\StandardCurrency.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                var records = csv.GetRecords<StandardCurrency>();
                StandardCurrency = new ObservableCollection<StandardCurrency>(records);
            }
            using (var reader = new StreamReader("data\\Assets\\StandardFossil.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                var records = csv.GetRecords<StandardFossil>();
                StandardFossil = new ObservableCollection<StandardFossil>(records);
            }
            using (var reader = new StreamReader("data\\Assets\\StandardOil.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                var records = csv.GetRecords<StandardOil>();
                StandardOil = new ObservableCollection<StandardOil>(records);
            }
            using (var reader = new StreamReader("data\\Assets\\StandardCatalyst.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                var records = csv.GetRecords<StandardCatalyst>();
                StandardCatalyst = new ObservableCollection<StandardCatalyst>(records);
            }
            using (var reader = new StreamReader("data\\Assets\\StandardFragment.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                var records = csv.GetRecords<StandardFragment>();
                StandardFragment = new ObservableCollection<StandardFragment>(records);
            }
            using (var reader = new StreamReader("data\\Assets\\HardcoreCurrency.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                var records = csv.GetRecords<HardcoreCurrency>();
                HardcoreCurrency = new ObservableCollection<HardcoreCurrency>(records);
            }
            using (var reader = new StreamReader("data\\Assets\\HardcoreFossil.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                var records = csv.GetRecords<HardcoreFossil>();
                HardcoreFossil = new ObservableCollection<HardcoreFossil>(records);
            }
            using (var reader = new StreamReader("data\\Assets\\HardcoreOil.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                var records = csv.GetRecords<HardcoreOil>();
                HardcoreOil = new ObservableCollection<HardcoreOil>(records);
            }
            using (var reader = new StreamReader("data\\Assets\\HardcoreCatalyst.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                var records = csv.GetRecords<HardcoreCatalyst>();
                HardcoreCatalyst = new ObservableCollection<HardcoreCatalyst>(records);
            }
            using (var reader = new StreamReader("data\\Assets\\HardcoreFragment.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                var records = csv.GetRecords<HardcoreFragment>();
                HardcoreFragment = new ObservableCollection<HardcoreFragment>(records);
            }
        }
    }
}

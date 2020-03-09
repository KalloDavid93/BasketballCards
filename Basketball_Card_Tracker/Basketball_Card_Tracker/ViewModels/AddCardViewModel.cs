using Basketball_Card_Tracker.Data;
using Basketball_Card_Tracker.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Basketball_Card_Tracker.ViewModels
{
    class AddCardViewModel : INotifyPropertyChanged
    {
        private readonly ViewModelBase _parentViewModel;
        public event PropertyChangedEventHandler PropertyChanged;

        public List<string> Inserts { get; set; }
        private Dictionary<string, int?> _parallels;
        public Dictionary<string, int?> Parallels
        {
            get { return _parallels; }
            set
            {
                _parallels = value;
                OnPropertyChanged();
            }
        }

        private string _insert;
        public string Insert
        {
            get { return _insert; }
            set
            {
                _insert = value;
                Numbered = null;
                SetParallels();
                OnPropertyChanged();
            }
        }
        public string Serial { get; set; }
        public string Player { get; set; }
        private string _parallel;
        public string Parallel
        {
            get { return _parallel; }
            set
            {
                _parallel = value;
                SetNumbered();
                OnPropertyChanged();
            }
        }

        private int? _numbered;
        public int? Numbered
        {
            get { return _numbered; }
            set
            {
                _numbered = value;
                OnPropertyChanged();
            }
        }

        public string Seller { get; set; }

        public AddCardViewModel(ViewModelBase viewModelBase)
        {
            _parentViewModel = viewModelBase;
            SetInserts();
        }

        public void GenerateCard()
        {
            using CardTrackerContext context = new CardTrackerContext();
            Card card = new Card(Insert, Serial, Player, Parallel, Numbered, Seller, _parentViewModel.Category);
            context.Add(card);
            context.SaveChanges();
            _parentViewModel.LoadTable();
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            System.Diagnostics.Debug.WriteLine("onpropertychanged");
        }

        private void SetInserts()
        {
            Inserts = new List<string>()
            {
                "Base", "Rookie Credentials", "Factions", "Symbols", "Status Quo",
                "New Breed", "Freshman Signatures", "Elite Signatures", "Legendary Signatures", 
                "Materials", "Rookie Essentials", "Swatches"
            };

        }
        private void SetParallels()
        {
            Parallels = new Dictionary<string, int?>();
            switch (Insert)
            {
                case "Base":
                    Parallels = SetBaseParallels();
                    break;
                case "Rookie Credentials":
                case "Factions":
                case "Symbols":
                case "Status Quo":
                    Parallels = SetSimpleInsertParallels();
                    break;
                case "New Breed":
                case "Freshman Signatures":
                case "Elite Signatures":
                    Parallels = SetPinkGold();
                    break;
                case "Legendary Signatures":
                    Parallels = SetLegendary();
                    break;
                case "Materials":
                    Parallels = SetMaterials();
                    break;
                case "Rookie Essentials":
                    Parallels = SetRookieEssentials();
                    break;
                case "Swatches":
                    Parallels = SetSwatches();
                    break;
            }
        }

        private Dictionary<string, int?> SetBaseParallels()
        {
            return new Dictionary<string, int?>()
                    {
                        { "Base", null},
                        { "Red", 299},
                        { "Blue", 199},
                        { "Purple", 149},
                        { "Green", 75},
                        { "Aspirations", null},
                        { "Status", null},
                        { "Gold", 10},
                        { "Kaleido", 1},
                        { "Orange", null},
                        { "Aqua", null},
                        { "Foundations", null},
                        { "Pursuit", null}
                    };
        }

        private Dictionary<string, int?> SetSimpleInsertParallels()
        {
            return new Dictionary<string, int?>()
                    {
                        { "Base", null },
                        { "Red", 299},
                        { "Blue", 199},
                        { "Purple", 149 },
                        { "Gold", 10}
                    };
        }

        private Dictionary<string, int?> SetPinkGold()
        {
            return new Dictionary<string, int?>()
                    {
                        { "Base", null },
                        { "Pink", 149},
                        { "Gold", 10}
                    };
        }

        private Dictionary<string, int?> SetLegendary()
        {
            return new Dictionary<string, int?>()
                    {
                        { "Base", null },
                        { "Pink", 99},
                        { "Gold", 10}
                    };
        }

        private Dictionary<string, int?> SetMaterials()
        {
            return new Dictionary<string, int?>()
                    {
                        { "Base", null },
                        { "Pink", 25},
                        { "Gold", 10}
                    };
        }

        private Dictionary<string, int?> SetRookieEssentials()
        {
            return new Dictionary<string, int?>()
                    {
                        { "Base", null },
                        { "Gold", 10}
                    };
        }

        private Dictionary<string, int?> SetSwatches()
        {
            return new Dictionary<string, int?>()
                    {
                        { "Base", 99 },
                        { "Gold", 10}
                    };
        }

        private void SetNumbered()
        {
            if (Parallel != null)
            {
                Parallels.TryGetValue(Parallel, out int? value);
                Numbered = value;
            }
        }
    }
}

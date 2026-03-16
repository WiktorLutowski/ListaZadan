using Lista.Commands;
using System.Collections.ObjectModel;

namespace Lista.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string newElementContent = default!;

        public string NewElementContent
        {
            get { return newElementContent; }
            set { newElementContent = value; OnPropertyChaneged(); }
        }

        public ObservableCollection<string> Elements { get; set; }

        public RelayCommand AddCommand { get; set; }

        public MainViewModel()
        {
            AddCommand = new(AddCommandMethod);
            Elements =
            [
                "Zakupy: chleb, masło, ser",
                "Do zrobienia: obiad, umyć podłogi",
                "weekend: kino, spacer z psem",
            ];

            NewElementContent = "";
        }

        private void AddCommandMethod()
        {
            if (string.IsNullOrEmpty(NewElementContent))
                return;

            Elements.Add(NewElementContent);

            NewElementContent = string.Empty;
        }
    }
}

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Lista.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChaneged([CallerMemberName]string propName = null!)
        {
            PropertyChanged?.Invoke(this, new(propName));
        }
    }
}

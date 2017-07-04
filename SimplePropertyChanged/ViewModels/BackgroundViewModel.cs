using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SimplePropertyChanged.ViewModels
{
    public class BackgroundViewModel : ObservableObject
    {
        private Brush _colour;

        public Brush Colour
        {
            get
            {
                if (_colour == null)
                    return Brushes.DodgerBlue;
                return _colour;
            }
            set
            {
                if (_colour == value) return;
                _colour = value;
                OnPropertyChanged("Colour");
            }
        }
    }
}

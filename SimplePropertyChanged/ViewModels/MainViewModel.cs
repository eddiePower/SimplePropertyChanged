using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SimplePropertyChanged.ViewModels
{
    public class MainViewModel
    {
        public PersonViewModel Person { get; private set; }
        public BackgroundViewModel Background { get; private set; }

        public MainViewModel()
        {
            //Empty constructor will return Unkowen when clicked.
            Person = new PersonViewModel();

            Background = new BackgroundViewModel();
        }

        public void SetBackground(Brush brushColour)
        {
            if (Background.Colour == brushColour) return;
            Background.Colour = brushColour;
        }
    }
}

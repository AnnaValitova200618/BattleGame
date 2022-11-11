using AAA.Services;
using EEEeee.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EEEeee.ViewMdels
{
    public class MainWindwVM
    {
       
        public CustomCommand OpenGame { get; set; } 

        public MainWindwVM()
        {
            OpenGame = new CustomCommand(() =>
            {
                App.SwitchMainWindow(new Window1());
                
            });
        }

    }
}

using AAA.Services;
using AAA.ViewModels;
using EEEeee.Services;
using EEEeee.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEEeee.ViewMdels
{
    public class AllPageVM: BaseVM
    {
        private readonly CurrentPageControl currentPageControl;

        public CustomCommand Exit { get; set; }

        public AllPageVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;

            Exit = new CustomCommand(() =>
            {
                currentPageControl.SetPage(new HeroPage(currentPageControl));
            });
        }
    }
}

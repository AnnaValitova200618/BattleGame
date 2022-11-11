using AAA.ViewModels;
using EEEeee.Services;
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

        public AllPageVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
        }
    }
}

using Fiorello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.ViewModel
{
    public class HomeVm
    {
        public List<SliderImage> SliderImages { get; set; }

        public SliderContext SliderContext { get; set; }

        public List<Experts> Experts { get; set; }
    }
}

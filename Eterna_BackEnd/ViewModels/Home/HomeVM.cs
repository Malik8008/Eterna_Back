using Eterna_BackEnd.Models;
using System.Collections.Generic;

namespace Eterna_BackEnd.ViewModels.Home
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; } 
        public List<HomeFirstCard> FirstCards { get; set; }
        public List <HomeSecondCard> SecondCards { get; set; }
        public List<Brand> Brands { get; set; }
    }
}

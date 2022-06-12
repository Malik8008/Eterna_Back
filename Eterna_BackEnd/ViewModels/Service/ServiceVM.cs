using Eterna_BackEnd.Models;
using System.Collections.Generic;

namespace Eterna_BackEnd.ViewModels.Service
{
    public class ServiceVM
    {
        public List<Setting> Settings { get; set; }
        public List<Card> Cards { get; set; }
        public List<Skill> Skills { get; set; }
        public List<ProgressBar> Progresss { get; set; }
    }
}

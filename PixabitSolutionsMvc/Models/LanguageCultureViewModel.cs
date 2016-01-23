using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PixabitSolutionsMvc.Models
{
    public class LanguageCultureViewModel
    {

        public LanguageCultureViewModel(string code, string desc)
        {
            Code = code;
            Description = desc;
        }
        public string Code { get; private set; }
        public string Description { get; private set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Multi_View_4.ViewModel
{
    public class PersonVM
    {

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Color { get; set; }
        public PersonVM(string firstName, string secondName, string color)
        {
            FirstName = firstName;
            SecondName = secondName;
            Color = color;
        }
    }
}

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Multi_View_4.ViewModel
{
    public class AddVM:ViewModelBase
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Color { get; set; }
        public RelayCommand AddBtn { get; set; }
        Messenger messenger = SimpleIoc.Default.GetInstance<Messenger>();

        public AddVM()
        {
            AddBtn = new RelayCommand(()=> 
            {
                PersonVM person = new PersonVM(FirstName, SecondName, Color);

                messenger.Send(new PropertyChangedMessage<PersonVM>(null, person, ""));
            });
        }
    }
}

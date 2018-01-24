using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Multi_View_4.ViewModel
{
    public class ListVM:ViewModelBase
    {

        public ObservableCollection<PersonVM> PersonList { get; set; }

        Messenger messenger = SimpleIoc.Default.GetInstance<Messenger>();
        public ListVM()
        {
            messenger.Register<PropertyChangedMessage<PersonVM>>(this, AddToList);
            PersonList = new ObservableCollection<PersonVM>();
        }

        private void AddToList(PropertyChangedMessage<PersonVM> person)
        {
            PersonList.Add(person.NewValue);
        }
    }
}

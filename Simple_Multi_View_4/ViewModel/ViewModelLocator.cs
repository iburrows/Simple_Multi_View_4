/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:Simple_Multi_View_4"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Practices.ServiceLocation;

namespace Simple_Multi_View_4.ViewModel
{

    public class ViewModelLocator
    {

        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);



            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<Messenger>(true);
            SimpleIoc.Default.Register<ListVM>(true);
            SimpleIoc.Default.Register<AddVM>(true);

        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public ListVM List
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ListVM>();
            }
        }

        public AddVM Add
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AddVM>();
            }
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}
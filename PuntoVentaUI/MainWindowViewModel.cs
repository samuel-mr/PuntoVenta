using Prism.Mvvm;
using PuntoVentaUI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVentaUI
{
  public class MainWindowViewModel : BindableBase
  {

    public MainWindowViewModel()
    {
      Title = "RETAIL NAME / LOGO";
      ItemsToSellViewModel = new ItemsToSellViewModel();
    }

    private string _Title;
    public string Title
    {
      get
      {
        return _Title;
      }
      set
      {
        if (_Title == value) return;
        _Title = value;
        RaisePropertyChanged(nameof(Title));
      }
    }


    private ItemsToSellViewModel _ItemsToSellViewModel;
    public ItemsToSellViewModel ItemsToSellViewModel
    {
      get
      {
        return _ItemsToSellViewModel;
      }
      set
      {
        if (_ItemsToSellViewModel == value) return;
        _ItemsToSellViewModel = value;
        RaisePropertyChanged(nameof(ItemsToSellViewModel));
      }
    }

  }
}

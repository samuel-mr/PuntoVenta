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
      HeaderViewModel = new HeaderViewModel();
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

    private HeaderViewModel _HeaderViewModel;
    public HeaderViewModel HeaderViewModel
    {
      get
      {
        return _HeaderViewModel;
      }
      set
      {
        if (_HeaderViewModel == value) return;
        _HeaderViewModel = value;
        RaisePropertyChanged(nameof(HeaderViewModel));
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

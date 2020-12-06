using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVentaUI.ViewModels
{
  public class ItemsToSellViewModel : BindableBase
  {
    public ItemsToSellViewModel()
    {
      Title = "gg";
      Items = new List<ItemProductModel>()
      {
        new ItemProductModel(){ Name = "Convers Gorilla 43x1", Code="#21334", Description = "##########", Discount = -0.10m, Price = 69.99m},
        new ItemProductModel(){ Name = "Conver AllStars Navy Blue 2x1", Code="#1233", Description = "##########", Discount = -0.20m, Price = 100m}
      };
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

    private List<ItemProductModel> _Items;
    public List<ItemProductModel> Items
    {
      get
      {
        return _Items;
      }
      set
      {
        if (_Items == value) return;
        _Items = value;
        RaisePropertyChanged(nameof(Items));
      }
    }

    public decimal Discount => Items.Sum(x => x.Discount);
    public decimal SubTotal => Items.Sum(x => x.Price);
    public decimal IGV => SubTotal * 0.18m;
    public decimal Total => Math.Round(SubTotal + IGV - Discount, 2);
  }

  public class ItemProductModel
  {
    public string Code { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal Discount { get; set; }
    public string Description { get; set; }
  }
}

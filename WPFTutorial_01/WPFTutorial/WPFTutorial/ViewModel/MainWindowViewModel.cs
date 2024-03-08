using System.Collections.ObjectModel;
using WPFTutorial.Model;
using WPFTutorial.MVVM;

namespace WPFTutorial.ViewModel;

public class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<Item> Items { get; set; }
    
    private Item selectedItem;

    public Item SelectedItem
    {
        get { return selectedItem; }
        set
        {
            selectedItem = value;
            OnPropertyChanged();
        }
    }

    public RelayCommand AddCommand =>
        new RelayCommand(execute => AddItem(),
            canExecute => { return true; });

    public RelayCommand DeleteCommand =>
        new RelayCommand(execute => DeleteItem(), 
            canExecute => selectedItem != null );

    public RelayCommand SaveCommand =>
        new RelayCommand(execute => Save(),
            canExecute => CanSave());    
    public MainWindowViewModel()
    {
        Items = new ObservableCollection<Item>();
    }

    private void AddItem()
    {
        Items.Add(new Item
        {
            Name = "New Item",
            SerialNumber = "XYZYX",
            Quantity = 0,
        });
    }

    private void DeleteItem()
    {
        Items.Remove(SelectedItem);
    }

    private void Save()
    {
        //save
    }

    private bool CanSave()
    {
        return true;
    }
}
using System;
using System.Collections.ObjectModel;
using System.Linq;
using ReactiveUI;

namespace AvaRxUI.ViewModels;

public class MainWindowViewModel : ViewModelBase, IScreen
{
    public RoutingState Router { get; }


    private readonly ObservableCollection<EntityViewModel> _entities;
    public ObservableCollection<EntityViewModel> Entities => _entities;


    public MainWindowViewModel()
    {
        Router = new RoutingState();
        
        _entities = new ObservableCollection<EntityViewModel>(
            Enumerable.Range(1, 50)
                .Select(i => new EntityViewModel { StringProp = Guid.NewGuid().ToString() }));
    }
}
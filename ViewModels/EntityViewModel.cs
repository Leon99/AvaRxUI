using ReactiveUI;

namespace AvaRxUI.ViewModels;

public class EntityViewModel : ViewModelBase
{
    [Reactive]
    public string StringProp { get; set; }
}
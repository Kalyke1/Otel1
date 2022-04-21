using OtelManager.Common.DataProvider;
using OtelManager.Common.Model;
using OtelManager.ViewModel.Command;
using System.Collections.ObjectModel;

namespace OtelManager.ViewModel
{
  public class MainViewModel : ViewModelBase
  {
        private OtelViewModel _selectedReservation;
    private readonly IOtelDataProvider _otelDataProvider;

    public MainViewModel(IOtelDataProvider otelDataProvider)
    {
      _otelDataProvider = otelDataProvider;
      LoadCommand = new DelegateCommand(Load);
    }

    public DelegateCommand LoadCommand { get; }

    public ObservableCollection<OtelViewModel> Reservations { get; } = new();
    public ObservableCollection<Room> Rooms { get; } = new();

    public OtelViewModel SelectedReservation
        {
      get => _selectedReservation;
      set
      {
        if (_selectedReservation != value)
        {
          _selectedReservation = value;
          RaisePropertyChanged();
          RaisePropertyChanged(nameof(IsReservationSelected));
        }
      }
    }

    public bool IsReservationSelected => SelectedReservation != null;

    public void Load()
    {
      var reservations = _otelDataProvider.LoadReservations();
      var rooms = _otelDataProvider.LoadRooms();

      Reservations.Clear();
      foreach (var reservation in reservations)
      {
          Reservations.Add(new OtelViewModel(reservation, _otelDataProvider));
      }

      Rooms.Clear();
      foreach (var room in rooms)
      {
          Rooms.Add(room);
      }
    }

  }
}

using OtelManager.Common.DataProvider;
using OtelManager.Common.Model;
using OtelManager.ViewModel;
using OtelManager.ViewModel.Command;
using System;
using System.ComponentModel;

namespace OtelManager.ViewModel
{
  public class OtelViewModel : ViewModelBase
  {
    private readonly Reservation _reservation;
    private readonly IOtelDataProvider _otelDataProvider;


    public OtelViewModel(Reservation reservation, IOtelDataProvider otelDataProvider)
    {
      _reservation = reservation;
      _otelDataProvider = otelDataProvider;
      SaveCommand = new DelegateCommand(Save, () => CanSave);
    }

    public DelegateCommand SaveCommand { get; }

    public string FirstName
    {
      get => _reservation.FirstName;
      set
      {
        if (_reservation.FirstName != value)
        {
          _reservation.FirstName = value;
          RaisePropertyChanged();
          RaisePropertyChanged(nameof(CanSave));
          SaveCommand.RaiseCanExecuteChanged();
        }
      }
    }

    public DateTimeOffset CheckInDate
        {
      get => _reservation.CheckInDate;
      set
      {
        if (_reservation.CheckInDate != value)
        {
          _reservation.CheckInDate = value;
          RaisePropertyChanged();
        }
      }
    }


    public int AdultCount
        {
      get => _reservation.AdultCount;
      set
      {
        if (_reservation.AdultCount != value)
        {
          _reservation.AdultCount = value;
          RaisePropertyChanged();
        }
      }
    }

    public bool IsBreakfast
        {
      get => _reservation.IsBreakfast;
      set
      {
        if (_reservation.IsBreakfast != value)
        {
          _reservation.IsBreakfast = value;
          RaisePropertyChanged();
        }
      }
    }

    public bool CanSave => !string.IsNullOrEmpty(FirstName);

    public void Save()
    {
        _otelDataProvider.SaveReservation(_reservation);
    }
  }
}

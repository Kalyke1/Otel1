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

    public string SurName
    {
        get => _reservation.SurName;
        set
        {
            if (_reservation.SurName != value)
            {
                _reservation.SurName = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(CanSave));
                SaveCommand.RaiseCanExecuteChanged();
            }
        }
    }

    public string PhoneNumber
        {
        get => _reservation.PhoneNumber;
        set
        {
            if (_reservation.PhoneNumber != value)
            {
                _reservation.PhoneNumber = value;
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

        public DateTime CheckInDateTime
        {
            get => _reservation.CheckInDate.DateTime;
            set
            {
                if (_reservation.CheckInDate != value)
                {
                    _reservation.CheckInDate = value;
                    RaisePropertyChanged();
                }
            }
        }


        public DateTime CheckOutDateTime
        {
            get => _reservation.CheckOutDate.DateTime;
            set
            {
                if (_reservation.CheckOutDate != value)
                {
                    _reservation.CheckOutDate = value;
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
        public int ChildCount
        {
            get => _reservation.ChildCount;
            set
            {
                if (_reservation.ChildCount != value)
                {
                    _reservation.ChildCount = value;
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
        public bool IsDinner
        {
            get => _reservation.IsDinner;
            set
            {
                if (_reservation.IsDinner != value)
                {
                    _reservation.IsDinner = value;
                    RaisePropertyChanged();
                }
            }
        }


        public int RoomId
    {
        get => _reservation.RoomId;
        set
        {
            if (_reservation.RoomId != value)
            {
                _reservation.RoomId = value;
                RaisePropertyChanged();
            }
        }
    }

        public bool CanSave => !string.IsNullOrEmpty(FirstName);

    public void Save()
    {
            _otelDataProvider.SaveReservation(_reservation); 
    }




    public string ListItemRsv
    {
            get => _reservation.FirstName + " " + _reservation.SurName;
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

    }
}

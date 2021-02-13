using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PopDink2.viewModel
{
    class viewModel : INotifyPropertyChanged
    {
        private bool displayPopup;

        public ICommand OpenPopupCommand { get; set; }

        public bool DisplayPopup
        {
            get
            {
                return displayPopup;
            }
            set
            {
                displayPopup = value;
                RaisePropertyChanged("DisplayPopup");
            }
        }

        public viewModel()
        {
            OpenPopupCommand = new Command(OpenPopup);
        }

        private void OpenPopup()
        {
            DisplayPopup = true;
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

    #endregion

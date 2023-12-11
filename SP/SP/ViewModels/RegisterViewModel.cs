using FreshMvvm;
using SP.Domain.Models;
using SP.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SP.ViewModels
{
    public class RegisterViewModel: FreshBasePageModel
    {
        private IIdentityService _identityService;

        public RegisterViewModel(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        #region Properties

        private bool isBusy;
        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                RaisePropertyChanged(nameof(IsBusy));
            }
        }


        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                RaisePropertyChanged(nameof(Email));
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                RaisePropertyChanged(nameof(Password));
            }
        }

        private bool _isShowCancel;
        public bool IsShowCancel
        {
            get { return _isShowCancel; }
            set
            {
                _isShowCancel = value;
                RaisePropertyChanged(nameof(IsShowCancel));
            }
        }

        #endregion


        #region Commands
        public ICommand RegisterCommand
        {
            get { return new Command(RegisterAction); }
        }

        private ICommand _cancelLoginCommand;
        public ICommand CancelLoginCommand
        {
            get { return _cancelLoginCommand = _cancelLoginCommand ?? new Command(CancelLoginAction); }
        }

        private ICommand _forgotPasswordCommand;
        public ICommand ForgotPasswordCommand
        {
            get { return _forgotPasswordCommand = _forgotPasswordCommand ?? new Command(ForgotPasswordAction); }
        }

        private ICommand _newAccountCommand;
        public ICommand NewAccountCommand
        {
            get { return _newAccountCommand = _newAccountCommand ?? new Command(NewAccountAction); }
        }

        #endregion


        #region Methods

        bool CanRegisterAction()
        {
            //Perform your "Can Login?" logic here...

            if (string.IsNullOrWhiteSpace(this.Email) || string.IsNullOrWhiteSpace(this.Password))
                return false;

            return true;
        }

        async void RegisterAction()
        {
            IsBusy = true;

            //TODO - perform your login action + navigate to the next page
            UserToken token = await _identityService.RegisterTokenAsync(Email, Password);

            IsBusy = false;
            //Simulate an API call to show busy/progress indicator            
            //Task.Delay(20000).ContinueWith((t) => IsBusy = false);

            ////Show the Cancel button after X seconds
            //Task.Delay(5000).ContinueWith((t) => IsShowCancel = true);
        }

        void CancelLoginAction()
        {
            //TODO - perform cancellation logic

            IsBusy = false;
            IsShowCancel = false;
        }

        void ForgotPasswordAction()
        {
            //TODO - navigate to your forgotten password page
            //Navigation.PushAsync(XXX);
        }

        async void NewAccountAction()
        {
            //TODO - navigate to your registration page
            await CoreMethods.PushPageModel<LoginViewModel>();
        }

        #endregion
    }
}

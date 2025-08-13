using Machine.ViewModels.Base;
using Machine.ViewModels.Messages;
using System.Windows.Input;

namespace Machine.Views.ViewModels
{
    class InjectorViewModel : BaseViewModel
    {
        public int Id { get; set; }

        private ICommand _inject;
        public ICommand Inject => _inject ?? (_inject = new RelayCommand(() => InjectImpl()));

        private void InjectImpl() => Messenger.Send(new InjectMessage() { InjectorId = Id });
    }
}

using Prism.Mvvm;

namespace WpfApplication1.ViewModels {

    /// <summary>
    /// Shell ViewModel
    /// </summary>
    public class ShellViewModel : BindableBase {

        #region property DisplayName

        /// <summary>
        /// Represent DisplayName property
        /// </summary>
        public string DisplayName {
            get { return _displayName; }
            set { SetProperty(ref _displayName, value); }
        }

        /// <summary>
        /// Backing field for property DisplayName
        /// </summary>
        private string _displayName = "WPF PRISM (MVVM) + DI (Autofac)";

        #endregion

    }
}

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace AreaCirculoAppMvvm.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public const double PI = 3.1415926535897931;

        private double _radio;
        private string _resultado;

        public string Resultado
        {
            get => _resultado;
            set
            {
                _resultado = value;
                OnPropertyChanged();
            }
        }

        public double Radio
        {
            get => _radio;
            set
            {
                _radio = value;
                OnPropertyChanged();
            }
        }

        public ICommand CalcularAreaCommand { get; }
        public ICommand LimpiarCommand { get; }

        public MainViewModel()
        {
            CalcularAreaCommand = new Command(CalcularArea);
            LimpiarCommand = new Command(LimpiarCampos);
        }

        private void CalcularArea()
        {
            double area = PI * Radio * Radio;
            Resultado = $"Área: {area:N2}";
        }

        private void LimpiarCampos()
        {
            Radio = 0;
            Resultado = string.Empty;
        }

        // Implementación de INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

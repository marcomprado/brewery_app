using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace bebrewery.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private int _contador;

        public int Contador
        {
            get => _contador;
            set
            {
                if (_contador != value)
                {
                    _contador = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Mensagem)); // atualiza o texto
                }
            }
        }

        public string Mensagem => $"Você clicou {Contador} vez(es)";

        public void Incrementar()
        {
            Contador++;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string nome = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nome));
        }
    }
}
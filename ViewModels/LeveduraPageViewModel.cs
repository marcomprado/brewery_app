using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using bebrewery.Models;
using System.Diagnostics;

namespace bebrewery.ViewModels
{
    public class LeveduraPageViewModel : INotifyPropertyChanged
    {
        private string tipo;
        private string estilo;
        private double atenuacao;
        private double tempIdeal;

        public string Tipo
        {
            get => tipo;
            set
            {
                tipo = value;
                OnPropertyChanged();
            }
        }

        public string Estilo
        {
            get => estilo;
            set
            {
                estilo = value;
                OnPropertyChanged();
            }
        }

        public double Atenuacao
        {
            get => atenuacao;
            set
            {
                atenuacao = value;
                OnPropertyChanged();
            }
        }

        public double TempIdeal
        {
            get => tempIdeal;
            set
            {
                tempIdeal = value;
                OnPropertyChanged();
            }
        }

        public ICommand SalvarCommand { get; }

        public LeveduraPageViewModel()
        {
            SalvarCommand = new Command(Salvar);
        }

        private void Salvar()
        {
            var levedura = new Levedura
            {
                Tipo = this.Tipo,
                Estilo = this.Estilo,
                Atenuacao = this.Atenuacao,
                TempIdeal = this.TempIdeal
            };

            Debug.WriteLine($"Levedura salva: {levedura.Tipo}, {levedura.Estilo}, {levedura.Atenuacao}%, {levedura.TempIdeal}°C");
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string nome = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nome));
        }
    }
}
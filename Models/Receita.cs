using System;
using System.Collections.Generic;

namespace bebrewery.Models
{
    public class Receita
    {
        // Informações gerais
        public string Nome { get; set; }
        public string Estilo { get; set; }
        public double VolumeLitros { get; set; }
        public double Rendimento { get; set; } // %
        public DateTime? DataBrassagem { get; set; }

        // Ingredientes
        public List<Malte> Maltes { get; set; } = new();
        public List<Lupulo> Lupulos { get; set; } = new();
        public Levedura Levedura { get; set; }
        public List<Adjunto> Adjuntos { get; set; } = new();

        // Parâmetros técnicos
        public double OG { get; set; }
        public double FG { get; set; }
        public double ABV => (OG - FG) * 131.25; // fórmula estimada
        public double IBU { get; set; }
        public double CorEBC { get; set; }
        public double EficienciaBrassagem { get; set; }

        // Etapas do processo
        public double TempMostura { get; set; }
        public int TempoMosturaMin { get; set; }
        public int TempoFervuraMin { get; set; }
        public string RampasTemperatura { get; set; }
        public int FermentacaoPrimariaDias { get; set; }
        public int FermentacaoSecundariaDias { get; set; }
        public double TempFermentacao { get; set; }
        public string Carbonatacao { get; set; }
    }
}
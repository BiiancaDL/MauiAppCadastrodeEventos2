namespace MauiAppCadastrodeEventos2.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; } = DateTime.Now;
        public DateTime DataTermino { get; set; } = DateTime.Now;
        public int? NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public double? CustoPorParticipante { get; set; }

        public int DuracaoDias => (DataTermino - DataInicio).Days;
        public double CustoTotal => (NumeroParticipantes ?? 0) * (CustoPorParticipante ?? 0);
    }
}

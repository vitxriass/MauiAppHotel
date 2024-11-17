
namespace MauiAppHotel.Views
{
    internal class Hospedagem
    {
        public Quarto QuartoSelecionado { get; internal set; }
        public int QntAdultos { get; internal set; }
        public int QntCriancas { get; internal set; }
        public DateTime DataCheckIn { get; internal set; }
        public DateTime DataCheckOut { get; internal set; }
    }
}
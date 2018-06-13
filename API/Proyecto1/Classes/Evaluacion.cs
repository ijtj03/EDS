namespace Proyecto1.Services
{
    public class Evaluacion
    {
        public int IdEvaluacion { get; set; }
        public string Carnet { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string TipoBeca { get; set; }
        public int Recomienda { get; set; }
        public int HorasAsignadas { get; set; }
        public int HorasLaboradas { get; set; }
        public string Observaciones { get; set; }
        public bool Revisado { get; set; }

    }
}
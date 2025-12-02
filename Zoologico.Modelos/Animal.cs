using System.ComponentModel.DataAnnotations;

namespace Zoologico.Modelos
{
    public class Animal
    {
        [Key] public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int EspecieCodigo { get; set; }
        public int RazaCodigo { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }

    }
}

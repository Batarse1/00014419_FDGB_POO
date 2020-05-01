namespace Labo_06
{
    public class Evaluacion
    {
        protected int porcentaje;
        protected string nombre;
        
        public Evaluacion(int porcentaje, string nombre)
        {
            this.porcentaje = porcentaje;
            this.nombre = nombre;
        }
        
        public int Porcentaje => porcentaje;
        public string Nombre => nombre;

        public override string ToString()
        {
            return $"{nameof(porcentaje)}: {porcentaje}\n{nameof(nombre)}: {nombre}\n";
        }
    }
}
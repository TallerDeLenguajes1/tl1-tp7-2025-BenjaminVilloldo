
namespace espacioCalculadora
{
    public class Calculadora
    {
        private double dato; //atributo
        
        //constructor
        public Calculadora()
        {
            dato = 10;
        }
        
        public double Resultado { get { return dato; } } //es una propiedad, permiten devolver valores de los atributos privados
        public void Sumar(double termino)
        {
            dato = dato + termino;
        }
        public void Restar(double termino)
        {
            dato -= termino;
        }
        public void Multiplicar(double termino)
        {
            dato = dato * termino;
        }

        public void dividir(double termino)
        {
            if (termino != 0)
            {
                dato = dato / termino;
            }
            else
            {
                dato = -9999;
            }
        }
        public void limpiar()
        {
            dato = 10;
        }
        
    }
}
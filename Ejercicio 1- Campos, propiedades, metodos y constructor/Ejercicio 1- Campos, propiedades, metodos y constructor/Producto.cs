namespace Ejercicio_1__Campos__propiedades__metodos_y_constructor
{
    public class Producto
    {
        public const double IVA = 0.21; 

        private double _precio; 

        public double Precio
        {
            get 
            { 
                return _precio; 
            }
            set
            {
                if (value < 0)
                {
                    _precio = 0;
                }
                else
                {
                    _precio = value;
                }
                    
            }
        }
        
        public double precioConIVA()
        {
            return Precio * (1 + IVA); 
        }

        public Producto(double precioInicial)
        {
            Precio = precioInicial; 
        }

      
    }
}

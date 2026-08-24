namespace Ejercicio3
{
    public class Agenda
    {
        private string[] dias = new string[7];

        public string this[int indice]
        {
            get
            {
                return dias[indice];
            }
            set
            {
                dias[indice] = value;
            }
        }
    }
}

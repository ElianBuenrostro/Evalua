namespace Evalua
{
    public class Variable
    {
        public enum TipoDato
        {
            Char,Int,Float
        }
        string nombre;
        float valor;
        TipoDato tipo;

        public Variable(string nombre, TipoDato tipo)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            valor = 0;
        }

        protected void setValor(float valor)
        {
            this.valor = valor;
        }

        public float getValor()
        {
            return this.valor;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public TipoDato getTipo()
        {
            return this.tipo;
        }

        public void setValor(string nombre, float resultado){

        }

    }
}
namespace EspacioCalculadora
{
    //no poner writeLine en clases.
    //no escribir en pantalla el valor.
    public class Calculadora
    {
        private double dato;

        public double Resultado{ get => dato; set => dato = value;}

        public void Sumar(double termino){
            dato+= termino;
        }
         public void Restar(double termino){
            dato-=termino;
        }
         public void Multiplicar(double termino){
            dato*=termino;
        }
         public void Dividir(double termino){
            if(termino!= 0){ dato/=termino;}
           
        }
         public void Limpiar(){
            dato=0;
        }
        
    }
}
using System;
using System.Text;

namespace ConsoleApp2
{
    public class Conver
    {

        double comp, vend;

        public Conver()
        {

        }

        public Conver(double comp)
        {
            this.comp = comp;
        }

        public void setComp(double comp)
        {
            this.comp=comp;
        }

        public void setVend(double vend)
        {
            this.vend = vend;   
        }

        public void Menu()
        {
            Console.WriteLine("Que accion desea realizar? ");
            Console.WriteLine("1-Compar. 2-Vender");
        }

        public void Menu1()
        {
            Console.WriteLine("Que tipo de divisas desea elegir?");
            Console.WriteLine("1-Dolar. 2-Euro");
        }

        public  int validar(String Mensaje)
        {
            int num = 0, v;
            do
            {
                v = 1;
                try
                {
                    Console.WriteLine(Mensaje);
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    v = 0;
                    Console.WriteLine("No se aceptan letras: ", error.Message);
                }
            } while (v == 0);
            return num;
        }
        
    }

}
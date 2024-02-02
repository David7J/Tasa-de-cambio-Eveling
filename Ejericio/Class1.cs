using System;
using ConsoleApp2;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Pdiagno
    {
        public static void Main(string[] args)
        {
            Conver c = new Conver();
            int opc;
            double b, v;

            c.Menu();

            do
            {
                opc = c.validar("Seleccione");

            } while (opc <= 0 || opc > 2);

            switch (opc)
            {
                case 1:
                    {
                        c.Menu1();

                        do
                        {
                            opc = c.validar("Seleccione");
                        }while (opc <= 0 || opc > 2);

                        switch (opc)
                        {

                            case 1:
                                {
                                    do
                                    {
                                        b = c.validar("Digite la cantidad de dolar a comprar: ");
                                    }while(b <= 0 || b > 9000);
                                    double dev = b * 36.99;
                                    Console.WriteLine("El total requerido en cordobas es:" + dev);
                            break;
                                }

                            case 2:
                                {
                                    do
                                    {
                                        v = c.validar("Digite la cantidad de euros a comprar: ");
                                    } while (v <= 0 || v > 9000);
                                    double ven = v * 1.1360;
                                    Console.WriteLine("El total requerido en cordobas es: " + ven);
                            break;
                                }
                        }
                break;
                    }

                case 2:
                    {
                        c.Menu1();

                        do
                        {
                            opc = c.validar("Seleccione");
                        } while (opc <= 0 || opc > 2);

                        switch (opc)
                        {

                            case 1:
                                {
                                    do
                                    {
                                        b = c.validar("Digite la cantidad de dolar a vender: ");
                                    } while (b <= 0 || b > 9000);
                                    double dev = b * 36.10;
                                    Console.WriteLine("El total requerido en cordobas es:" + dev);
                                    break;
                                }

                            case 2:
                                {
                                    do
                                    {
                                        v = c.validar("Digite la cantidad de euros a vender: ");
                                    } while (v <= 0 || v > 9000);
                                    double ven = v * 1.1360;
                                    Console.WriteLine("El total recibido en cordobas es: " + ven);
                                    break;
                                }
                        }
                        break;
                    }

            }
        }

    }
}

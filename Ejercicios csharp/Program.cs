using Ejercicios_csharp.Ejercicios;


internal class Program
{
    private static void Main(string[] args)
    {
        int opcionEjercicio;
        EjerciciosSolucion ejerciciosSolucion = new EjerciciosSolucion();
        do
        {
            Console.WriteLine("Escriba un numero para mostrar la solucion a ese ejercicio(1 al 20) y 21 para salir");
            opcionEjercicio = Int32.Parse(Console.ReadLine());
        
           
            switch(opcionEjercicio)
            {
                case 1:
                    ejerciciosSolucion.ejercicio1();
                    break;
                case 2:
                    ejerciciosSolucion.ejercicio2();
                    break;
                case 3:
                    ejerciciosSolucion.ejercicio3();
                    break;
                case 4:
                    ejerciciosSolucion.ejercicio4();
                    break;
                case 5:
                    ejerciciosSolucion.ejercicio5();
                    break;
                case 6:
                    ejerciciosSolucion.ejercicio6();
                    break;
                case 7:
                    ejerciciosSolucion.ejercicio7();
                    break;
                case 8:
                    ejerciciosSolucion.ejercicio8();
                    break;
                case 9:
                    ejerciciosSolucion.ejercicio9();
                    break;
                case 10:
                    ejerciciosSolucion.ejercicio10();
                    break;
                case 11:
                    ejerciciosSolucion.ejercicio11();
                    break;
                case 12:
                    ejerciciosSolucion.ejercicio12();
                    break;
                case 13:
                    ejerciciosSolucion.ejercicio13();
                    break;
                case 14:
                    ejerciciosSolucion.ejercicio14();
                    break;
                case 15:
                    ejerciciosSolucion.ejercicio15();
                    break;
                case 16:
                    ejerciciosSolucion.ejercicio16();
                    break;
                case 17:
                    ejerciciosSolucion.ejercicio17();
                    break;
                case 18:
                    ejerciciosSolucion.ejercicio18();
                    break;
                case 19:
                    ejerciciosSolucion.ejercicio19();
                    break;
                case 20:
                    ejerciciosSolucion.ejercicio20();
                    break;
                case 21:
                    break;
                default:
                    Console.WriteLine("Seleccione una opcion correcta");
                    break;
            }
        } while (opcionEjercicio != 21);



       Ejercicios ejercicios = new Ejercicios ();
        ejercicios.ejercicio1();
        ejercicios.ejercicio2();
        ejercicios.ejercicio3();
        ejercicios.ejercicio4();
        ejercicios.ejercicio5();
        ejercicios.ejercicio6();
        ejercicios.ejercicio7();
        ejercicios.ejercicio8();
        ejercicios.ejercicio9();
        ejercicios.ejercicio10();
        ejercicios.ejercicio11();
        ejercicios.ejercicio12();
        ejercicios.ejercicio13();
        ejercicios.ejercicio14();
        ejercicios.ejercicio15();
        ejercicios.ejercicio16();
        ejercicios.ejercicio17();
        ejercicios.ejercicio18();
        ejercicios.ejercicio19();
        ejercicios.ejercicio20();





    }

}
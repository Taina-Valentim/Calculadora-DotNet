using System;

namespace Calculadora{
    class Program{
        static void Main(string[] args){
            do{
                Console.Clear();
                Menu();
            }while(true);
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("Escolha a operação");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            int op = int.Parse(Console.ReadLine());
                if(op == 5)
                    System.Environment.Exit(0);
                if(op > 0 && op <5){
                    float v1 = PedeNumero(1);
                    float v2 = PedeNumero(2);
                    float resultado = Calcula(v1, v2, op);

                    if(v2 == 0 && op == 4)
                        Console.WriteLine("Não é possível dividir por 0!");
                    else
                        Console.WriteLine($"O resultado da operação é: {resultado}");
                    Console.ReadKey();
                }
        }

        static float PedeNumero(int sequencia){
            Console.WriteLine($"Digite o {sequencia}º valor: ");
            float v = float.Parse(Console.ReadLine());
            return v;
        }

        static float Calcula(float numero1, float numero2, int operador){
            Console.Clear();
            if(operador == 1)
                return numero1 + numero2;

            else if(operador == 2)
                return numero1 - numero2;

            else if(operador == 3)
                return numero1 * numero2;

            else if(operador == 4){
                if (numero2 != 0)
                    return numero1 / numero2;
                else
                    return 0;
            }
            else
                return 0;
        }
    }
}
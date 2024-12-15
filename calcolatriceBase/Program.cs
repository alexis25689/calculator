using System;
using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace Name
{
    internal class Class {
        public const float PIGRECO = 3.14f;
        //OPERATIONS
        /// <summary>
        /// sum of two numbers
        /// </summary>
        /// <param name="a">first number</param>
        /// <param name="b">second number</param>
        /// <returns>a and b' sum</returns>
        public int addition(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        /// <summary>
        /// product of two numbers
        /// </summary>
        /// <param name="a">first number</param>
        /// <param name="b">second number</param>
        /// <returns>a and b' product</returns>
        public int multiplication(int a, int b)
        {
            int product = a * b;
            return product;
        }

        /// <summary>
        /// subtraction of two numbers
        /// </summary>
        /// <param name="a">first number</param>
        /// <param name="b">second number</param>
        /// <returns>a and b' difference</returns>
        public int subtraction(int a, int b){
            int difference = a - b;
            return difference;
        }

        /// <summary>
        /// quotient of two numbers
        /// </summary>
        /// <param name="a">first number</param>
        /// <param name="b">second number</param>
        /// <returns>a and b' quotient</returns>
        public double division(int a, int b){
            double quotient = a/b;
            return quotient;
        }

        public void twoNumbers(){
             Console.Write("inserisci il primo numero: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inserisci il secondo numero numero: ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(@"Cosa scegli:
                                    1. addizione
                                    2. sottrazione
                                    3. moltiplicazione
                                    4. divisione");
                int x = Convert.ToInt32(Console.ReadLine());
                switch(x){
                    case 1:
                        addition(a,b);
                        Console.ReadLine();
                        break;
                    case 2:
                        subtraction(a,b);
                        Console.ReadLine();
                        break; 
                    case 3:
                        multiplication(a,b);
                        Console.ReadLine();
                        break;
                    case 4:
                        division(a,b);
                        Console.ReadLine();
                        break;  
                }
        }

        public void moreThanTwoNumber(int howManyNum){
            Console.WriteLine(@"cosa scegli:
                                1. addizione
                                2. sottrazione
                                3. moltiplicazione
                                4. divisione
                              ");
                            int x = Convert.ToInt32(Console.ReadLine());
                            switch(x)
                            {
                                case 1:
                                    int somma = 0;
                                    for(int i=0; i<howManyNum; i++){
                                        Console.Write("Inserisci un numero: ");
                                        int num = Convert.ToInt32(Console.ReadLine());
                                        somma = somma + num;
                                    }
                                    Console.WriteLine(somma);
                                    break;
                                case 2:
                                    int sottrazione = 0;
                                    for(int i=0; i<howManyNum; i++){
                                        Console.Write("Inserisci un numero: ");
                                        int num = Convert.ToInt32(Console.ReadLine());
                                        somma = num - sottrazione;
                                    }
                                    Console.WriteLine(sottrazione);
                                    break;
                                case 3:
                                    int moltiplicazione = 1;
                                    for(int i=0; i<howManyNum; i++){
                                        Console.Write("Inserisci un numero: ");
                                        int num = Convert.ToInt32(Console.ReadLine());
                                        moltiplicazione = moltiplicazione * num;
                                    }
                                    Console.WriteLine(moltiplicazione);
                                    break;
                                case 4:
                                    int divisione = 0;
                                    for(int i=0; i<howManyNum; i++){
                                        Console.Write("Inserisci un numero: ");
                                        int num = Convert.ToInt32(Console.ReadLine());
                                        divisione = num / divisione;
                                    }
                                    Console.WriteLine(divisione);
                                    break;
                            }
        }

        public void onlyOneNumber(){
            Console.WriteLine(@"Cosa scegli:
                                                1. potenza
                                                2. radice
                                                3. frazione
                                                4. percentuale");
                            int x = Convert.ToInt32(Console.ReadLine());
                            switch(x){
                                case 1:
                                    int pot = 0;

                                    Console.Write("Inserisci un numero: ");
                                    int num = Convert.ToInt32(Console.ReadLine());
                                    
                                    pot = num * num;
                                    Console.WriteLine(pot);
                                    Console.ReadLine();
                                    break;

                                case 2:
                                    Console.Write("Inserisci un numero: ");
                                    double numb = Convert.ToDouble(Console.ReadLine());
                                    double root= Math.Sqrt(numb);

                                    Console.WriteLine(root);
                                    Console.ReadLine();
                                    break;
                                
                                case 3:
                                    Console.Write("Inserisci un numero: ");
                                    int number = Convert.ToInt32(Console.ReadLine());
                                    int fraction = 1/number;

                                    Console.WriteLine(fraction);
                                    Console.ReadLine();
                                    break;

                                case 4:
                                    Console.Write("Inserisci un numero: ");
                                    int numero = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Quanta percentuale vuoi estrarre? ");
                                    int percentuale = Convert.ToInt32(Console.ReadLine());
                                    int percentual = (numero/100)*percentuale;

                                    Console.WriteLine(percentual);
                                    Console.ReadLine();                    
                                    break;
                            }
        }
            
        public void Main(){
            Console.WriteLine("Quanti numeri vuoi inserire ? ");
            int howMany = Convert.ToInt32(Console.ReadLine());
            if (howMany == 2)
            {
                twoNumbers();  
            }
            else if (howMany > 2)
            {
                moreThanTwoNumber(howMany);               
            }
            else if (howMany == 1){
             onlyOneNumber(); 
            }

        }

        
    }
}
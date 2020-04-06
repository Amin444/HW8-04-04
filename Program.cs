using System;

namespace HW8_06_04
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Добро пожаловать в Alif Convertetion Bank:");
            System.Console.Write("Введите сколько сомони вы хотите конвертировать:");
            double Som =double.Parse(Console.ReadLine());
           Converter mn = new Converter() { EUR = 11.02, RUB = 0.13, USD = 10.98};
           System.Console.Write("напишите в какой валюте вы хотите получить 1-'USD' 3-'EUR' 4-'RUB':");
                int currency=int.Parse(Console.ReadLine());
                    switch(currency)
                    {
                            case 1:
                              {
                        System.Console.WriteLine("$ " + mn.usd(Som));
                        System.Console.WriteLine("som " + mn.usdsom(Som));
                         }break;

                         case 3:
                              {
                        System.Console.WriteLine("E " + mn.eur(Som));
                        System.Console.WriteLine("som " + mn.eursom(Som));
                         }break;

                         case 4:
                              {
                        System.Console.WriteLine("P " + mn.rub(Som));
                        System.Console.WriteLine("som " + mn.rubsom(Som));
                         }break;
                    }
                    /////////////////////////////////////////////////////////
               Emploee E = new Emploee() { lastname = "Ashurov", name = "Sangali", position="builder", payment = 1500 };
            System.Console.WriteLine(E.PaynemtwithProc());

                    Console.ReadKey();
        }
    }
        class Converter
        {
            public double USD{get;set;}
            public double EUR{get;set;}
            public double RUB{get;set;}
            public Converter()
            {
                this.USD=USD;
                this.EUR=EUR;
                this.RUB=RUB;
                
            }
             public double usd(double Som)
            {
                return Som/USD;
            }
             public double eur(double Som)
            {
                return Som/EUR;
            }              
                    public double rub(double Som)
            {
                return Som/RUB;
            }   
                  public double usdsom(double Som)
            {
                return usd(Som)*USD;
            }  
               public double eursom(double Som)
            {
                return eur(Som)*EUR;
            }  
               public double rubsom(double Som)
            {
                return rub(Som)*RUB;
            }   
        }
           
               class Emploee
    {
        public string name { get; set; }
        public string lastname { get; set; }
        public double payment { get; set; }
        public string position{get;set;}
        public double PaynemtwithProc()
        {
            return payment * 0.14;
        }
           
           }
                                          

}


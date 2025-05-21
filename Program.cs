using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Car pt = new Car("",10350,"Жигули");
            pt.Show();
            Console.WriteLine( "Средний пробег = " + pt.Volume());
            Console.ReadKey();  
        }
    }
    class Car
    {
        private string marc; 
        private int mileage;
        private string gosNum;


        public int Mileage
        {
        get { return mileage; }
        set { if (value > 0) mileage = value; }
        }
        public string Marc
        {
            get { return marc; }
            set { if (value.Length > 0) marc = value; }
        }
        public string GosNum
        {
            get { return gosNum; }
            set { if (value.Length > 0) gosNum = value; }
        }

        public Car(string a, int b, string c) 
        {
            GosNum = a;
            Mileage = b;
            Marc = c;
        }
        public void Show()
        {
            Console.WriteLine("Описание машины: Марка {2} Гос.номер {1}, Пробег {0}", Mileage, GosNum, Marc);
        }
        public int Volume()
        {
            int V = Mileage / 5;
            return V;
        }
    }
}

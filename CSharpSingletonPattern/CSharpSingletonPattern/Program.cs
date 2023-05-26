using System;
using System.Runtime.ConstrainedExecution;

namespace CSharpSingletonPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //artık instanceyi "car" değişkenine atadık
            Car car=Car.Instance;
            //car değişkeniyle Car classındaki propertiese erişebiliyoruz
            car.Marka = "BMW";
            car.Model = 1999;
            Console.WriteLine(car.Model);
        }
    }
    //Car Sınıfı oluşturuyoruz
    public class Car
    {
        //static ifadeli instance tanımladık (sınıf kurulmadan çalışabilmesi için statik ifadesi kullandım)
        static Car instance;
        static Car()
        {
            instance = new Car();
        }

        //Constructor açtık(sınıf yapısını nesne yaptık), returnla istanceyi döndürüyoruz
        public static Car Instance
        {
            get { return instance; }
        }
        //
       
        //oluşturduğumuz carın özellikleri
        string marka;
        int model;
        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }
        public int Model
        {
            get { return model; }
            set { model = value; }
        }

    }
}
using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve islemli atama
            int x=3;
            int y=3;
            y=y+2;
            Console.WriteLine(y);
            y+=2;
            Console.WriteLine(y);
            y/=2;
            Console.WriteLine(y);
            x*=2;
            Console.WriteLine(x);

            //Mantiksal operatorler
            bool issucces=true;
            bool iscompleted=false;
            if(issucces && iscompleted)
                Console.WriteLine("Perfect!");
            
            if(issucces||iscompleted)
                Console.WriteLine("Great!");
            
            if(issucces &&! iscompleted)
                Console.WriteLine("fine");


            Console.WriteLine(" .....iliskisel operatorler.....");    
            //Iliskisel operatorler

            int a=3;
            int b=4;
            bool sonuc = a<b;
            Console.WriteLine(sonuc);
            sonuc=a>b;
            Console.WriteLine(sonuc);
            sonuc=a>=b;
            Console.WriteLine(sonuc);
            sonuc=a<=b;
            Console.WriteLine(sonuc);
            sonuc=a==b;
            Console.WriteLine(sonuc);
            sonuc=a!=b;
            Console.WriteLine(sonuc);

            
            Console.WriteLine(".....aritmatik operatorler.....");

            int sayi1=10;
            int sayi2=5;
            int sonuc1=sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1+sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1++;
            Console.WriteLine(sonuc1);

            int sonuc2=20%3; // mod alir.
            Console.WriteLine(sonuc2);
            

        }
    }
}

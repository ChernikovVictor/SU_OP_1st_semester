using System;

namespace ConsoleApplication1
{
    public class Frac
    {
        private int num, den;  // numerator, denominator
        public Frac()
        {
            num = 0;
            den = 1;
        }
        public Frac(int a, int b)
        {
            this.Num = a;
            this.Den = b;
        }
    
        public int Num
        {
            get { return num; }
            set { num = value; }
        }
    
        public int Den
        {
            get { return den; }
            set
            {
                if (value != 0) 
                    den = (this.Num == 0) ? 1 : value;
                else
                {
                    den = 1;
                    Console.WriteLine("Деление на нуль. Знаменателю присвоено значение 1");
                }
            }
        }

        public override string ToString()
        {
            return Convert.ToString(num) + '/' + Convert.ToString(den);
        }
    
        public void Sum(Frac a)
        {
            num = num * a.den + a.num * den;
            if (num == 0)
                den = 1;
            else
                den *= a.den;
            this.Reduce();
        }
    
        public void Dif(Frac a)
        {
            a.num *= -1;
            this.Sum(a);
            a.num *= -1;
            this.Reduce();
        }
    
        public void Compose(Frac a)
        {
            num *= a.num;
            if (num == 0)
                den = 1;
            else
                den *= a.den;
            this.Reduce();
        }
    
        public void Del(Frac a)
        {
            if (a.num != 0)
            {
                num *= a.den;
                den *= a.num;
            }
            this.Reduce();
        }
    
        // сокращение дроби
        public void Reduce()
        {
            if ((num < 0 && den < 0)  || (den < 0 && num > 0))
            {
                num *= -1;
                den *= -1;
            }
            int a = Math.Abs(num), b = Math.Abs(den);
            if (a != 0)
            {
                while (a != b)
                {
                    if (a < b)
                        b -= a;
                    else
                        a -= b;
                }
                num /= a;
                den /= a;
            }
        }
    
        public static Frac operator +(Frac a, Frac b)
        {
            return MyClass.Sum(a, b);
        }
        
        public static Frac operator -(Frac a, Frac b)
        {
            return MyClass.Dif(a, b);
        }
        
        public static Frac operator *(Frac a, Frac b)
        {
            return MyClass.Compose(a, b);
        }
        
        public static Frac operator /(Frac a, Frac b)
        {
            return MyClass.Del(a, b);
        }
    }    
}
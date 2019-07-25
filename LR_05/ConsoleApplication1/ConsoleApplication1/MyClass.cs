namespace ConsoleApplication1
{
    public class MyClass
    {
        public static Frac Sum(Frac a, Frac b)
        {
            Frac c = new Frac();
            c.Sum(a);
            c.Sum(b);
            return c;
        }
    
        public static Frac Dif(Frac a, Frac b)
        {
            Frac c = new Frac();
            c.Sum(a);
            c.Dif(b);
            return c;
        }

        public static Frac Compose(Frac a, Frac b)
        {
            Frac c = new Frac();
            c.Sum(a);
            c.Compose(b);
            return c;
        }

        public static Frac Del(Frac a, Frac b)
        {
            Frac c = new Frac();
            c.Sum(a);
            c.Del(b);
            return c;
        }
    }
}
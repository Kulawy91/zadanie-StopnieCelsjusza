namespace zadanie_StopnieCelsjusza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperatura pierwsza= new Temperatura();
            pierwsza.stopnieCelsjusza= 0;
            Console.WriteLine("Temperatura w Kelwinach wynosi:{0}, w stopniach Celsjusza: {1}, a w stopniach Fahrenheita {2}", pierwsza.stopnieKelwina , pierwsza.stopnieCelsjusza, pierwsza.StopnieFahrenheita);
            Temperatura druga = new Temperatura();
            druga.stopnieCelsjusza= 100;
            Console.WriteLine("Temperatura w Kelwinach wynosi:{0}, w stopniach Celsjusza: {1}, a w stopniach Fahrenheita {2}", druga.stopnieKelwina, druga.stopnieCelsjusza, druga.StopnieFahrenheita);
            Temperatura trzecia = new Temperatura();
            trzecia.stopnieCelsjusza= 36.6;
            Console.WriteLine("Temperatura w Kelwinach wynosi:{0}, w stopniach Celsjusza: {1}, a w stopniach Fahrenheita {2}", trzecia.stopnieKelwina, trzecia.stopnieCelsjusza, trzecia.StopnieFahrenheita);
            Temperatura czwarta = new Temperatura();
            czwarta.stopnieKelwina2 = 0;
            Console.WriteLine("Temperatura w Kelwinach wynosi:{0}, w stopniach Celsjusza: {1}, a w stopniach Fahrenheita {2}", czwarta.stopnieKelwina2, czwarta.stopnieCelsjusza2, czwarta.StopnieFahrenheita);
            Temperatura piąta = new Temperatura();
            piąta.StopnieFahrenheita2 = 0;
            Console.WriteLine("Temperatura w Kelwinach wynosi:{0}, w stopniach Celsjusza: {1}, a w stopniach Fahrenheita {2}", piąta.stopnieKelwina, piąta.stopnieCelsjusza3, piąta.StopnieFahrenheita2);
            Temperatura szósta = new Temperatura();
            szósta.StopnieFahrenheita2 = 100;
            Console.WriteLine("Temperatura w Kelwinach wynosi:{0}, w stopniach Celsjusza: {1}, a w stopniach Fahrenheita {2}", szósta.stopnieKelwina, szósta.stopnieCelsjusza3, szósta.StopnieFahrenheita2);
        }

    }
}
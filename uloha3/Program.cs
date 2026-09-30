decimal vyska = ZadajCislo("Zadaj výšku: ");
decimal polomer = ZadajCislo("Zadaj polomer: ");
decimal objem = VypocetObjem(vyska, polomer);
decimal povrch = VypocetPovrch(vyska, polomer);



decimal ZadajCislo(string text)
{
    Console.Write(text);
    string cislo1 = Console.ReadLine();
    return decimal.Parse(cislo1);
}



decimal VypocetObjem(decimal a, decimal b)
{
    decimal vysledokobjem = 1m / 3m * 3.14m * b * b * a;
    return vysledokobjem;
}



decimal VypocetPovrch(decimal a, decimal b)
{
    double adouble = (double)a;
    double bdouble = (double)b;
    decimal vysledokpovrch = 3.14m * b * b + 3.14m * b * (decimal)Math.Sqrt(adouble * adouble + bdouble * bdouble);
    decimal vysledokpovrch2 = (decimal)vysledokpovrch;
    return vysledokpovrch2;
}



Console.WriteLine("Objem je: " + objem);
Console.WriteLine("Povrch je: " + povrch);
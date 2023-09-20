using System;

namespace Orai230920
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Feladat: Alapok
            //Írj egy C# programot, amely megjeleníti a jelenlegi dátumot és időt a következő formában: "Az aktuális dátum és idő: [dátum] [idő]."
            DateTime now = DateTime.Now;
            Console.WriteLine($"A pontos idő most: {now}");

            //2.Feladat: Dátumok összehasonlítása
            //Készíts egy programot, amely két dátumot kér be a felhasználótól, majd megállapítja, hogy melyik dátum van korábban. Az eredményt a képernyőre írd ki.
            Console.Write("Adjon meg egy dátumot:  ");
            DateTime dt1 = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Adjon meg egy dátumot:  ");
            DateTime dt2 = Convert.ToDateTime(Console.ReadLine());
            if (dt1.CompareTo(dt2) < 0) Console.WriteLine($"Ez a dátom volt korábban:  {dt1}");
            else Console.WriteLine($"Ez a dátom volt korábban:  {dt2}");

            //3.Feladat: Időintervallum kiszámítása
            //Készíts egy programot, amely két időpontot(kezdeti és végdátumot) kér be a felhasználótól, majd számold ki és írd ki, hány nap telt el közöttük.
            Console.Write("Adjon meg egy dátumot:  ");
            DateTime dt3 = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Adjon meg egy dátumot:  ");
            DateTime dt4 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine($"A két dátum között { Math.Abs(dt3.CompareTo(dt4))} nap telt el");

            //4.Feladat: TimeSpan használata
            //Hozz létre egy TimeSpan objektumot, amely 2 napot, 5 órát és 30 percet reprezentál. Majd írd ki ezt az időtartamot az alábbi formában: "Az időtartam: 2 nap, 5 óra, 30 perc."
            TimeSpan ts1 = new TimeSpan(2, 5, 30, 0);
            Console.WriteLine($"Az időtartam: {ts1.Days} nap, {ts1.Hours} óra, {ts1.Minutes} perc.");


            //5.Feladat: Fájlbeolvasás és írás
            //Hozz létre egy szöveges állományt("adatok.txt"), amelyben egy sorban található egy dátum és egy időpont(pl. "2023-09-20 14:30").Írj egy programot, amely beolvassa ezt az állományt, majd kiírja a konzolra.



            //6.Feladat: Fájlban tárolt dátumok összegzése
            //Módosítsd a korábbi programot úgy, hogy beolvassa az "adatok.txt" állományban található dátumokat, majd számold ki és írd ki az összes időtartamot, ami az aktuális idő és a beolvasott dátum között van. Használd a TimeSpan objektumot az időtartamok számításához.



            //7.Feladat: LINQ használata
            //Használd a LINQ lekérdezést a "dátumok.txt" állományban található dátumok közötti legkorábbi és legkésőbbi dátum megtalálására, majd írd ki ezeket a dátumokat a konzolra.



            //8.Feladat: Keresés időtartam alapján
            //Készíts egy programot, amely egy megadott időtartam alapján keresi meg azokat a dátumokat az "adatok.txt" állományban, amelyek ezen időtartamon belül vannak.Írd ki ezeket a dátumokat a konzolra.



            //9.Feladat: Összegzés LINQ segítségével
            //Használj LINQ lekérdezést az "adatok.txt" állományban található dátumok közötti időtartamok összegzésére. Az eredményt írd ki a konzolra.



            //10.Feladat: Időrendi sorrendezés LINQ segítségével
            //Használj LINQ-t az "adatok.txt" állományban található dátumok időrendi sorrendezésére, majd írd ki az eredményt a konzolra.
        }
    }
}

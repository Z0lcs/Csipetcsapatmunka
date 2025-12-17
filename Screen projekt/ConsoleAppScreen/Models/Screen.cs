using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppScreen.Models
{
    static public class Screen
    {
        /// <summary>
        /// Téglalap rajzolása a képernyőn a megadott koordináták és méretek alapján. 
        /// </summary>
        /// <param name="x">X koordináta</param>
        /// <param name="y">Y koordináta</param>
        /// <param name="width">A téglalap szélessége</param>
        /// <param name="height">A téglalap magassága</param>
        /// <param name="sign">A téglalap rajzolásához használt karakter</param>
        static public void DrawRectangle(byte x, byte y, byte width, byte height, char sign = '*')
        {
            // TODO : (Jancsi) Téglalap rajzolásának implementációja a képernyőn
            if (x <0 || y < 0)
            {
                throw new ArgumentOutOfRangeException("A koordináták nem lehetnek 0-nál kisebbek!");
            }
            if (width < 0 || height < 0)
            {
                throw new ArgumentOutOfRangeException("A téglalap méretei nem lehetnek 0-nál kisebbek!");
            }
            for (int i = 0; i < height; i++, y++)
            {
                Console.SetCursorPosition(x, y);
                if (i == 0 || i == height - 1)
                {
                    Console.WriteLine(new string(sign, width));
                }
                else
                {
                    Console.WriteLine(sign + new string(' ', width - 2) + sign);
                }
            }
        }

        /// <summary>
        /// Kitöltött téglalap rajzolása a képernyőn a megadott koordináták és méretek alapján.
        /// </summary>
        /// <param name="x">X koordináta</param>
        /// <param name="y">Y koordináta</param>
        /// <param name="width">A kitöltött téglalap szélessége</param>
        /// <param name="height">A kitöltött téglalap magassága</param>
        /// <param name="sign">A kitöltéshez használt karakter</param>
        static public void FillRectangle(byte x, byte y, byte width, byte height, char sign = '■')
        {
            if (x < 0 || y < 0)
            {
                throw new ArgumentOutOfRangeException("A koordináták nem lehetnek 0-nál kisebbek!");
            }
            if (width < 0 || height < 0)
            {
                throw new ArgumentOutOfRangeException("A téglalap méretei nem lehetnek 0-nál kisebbek!");
            }
            // TODO : (Juliska) Kitöltött téglalap rajzolásának implementációja a képernyőn
            for (int i = 0; i < height; i++, y++)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(new string(sign, width));
            }
        }

        /// <summary>
        /// Vonal rajzolása a képernyőn a megadott kezdő és végpontok alapján.
        /// </summary>
        /// <param name="x1">X koordináta a kezdőpontban</param>
        /// <param name="y1">Y koordináta a kezdőpontban</param>
        /// <param name="x2">X koordináta a végpontban</param>
        /// <param name="y2">Y koordináta a végpontban</param>
        /// <param name="sign">A vonal rajzolásához használt karakter</param>
        static public void DrawLine(byte x1, byte y1, byte x2, byte y2, char sign = '*')
        {

            int xKulonbseg = Math.Abs(x2 - x1);
            int yKulonbseg = Math.Abs(y2 - y1);
            int xIrany = x1 < x2 ? 1 : -1;
            int yIrany = y1 < y2 ? 1 : -1;
            int kulonbseg = xKulonbseg - yKulonbseg;

            while (true)
            {
                if (x1 >= 0 && y1 >= 0)
                {
                    Console.SetCursorPosition(x1, y1);
                    Console.Write(sign);
                }

                if (x1 == x2 && y1 == y2) break;

                int e2 = 2 * kulonbseg;

                if (e2 > -yKulonbseg)
                {
                    kulonbseg -= yKulonbseg;
                    x1 = (byte)(x1 + xIrany);
                }

                if (e2 < xKulonbseg)
                {
                    kulonbseg += xKulonbseg;
                    y1 = (byte)(y1 + yIrany);
                }
            }
        }

        /// <summary>
        /// Adott szélességre középre igazítja a szöveget
        /// </summary>
        /// <param name="text">A középre igazítandó szöveg</param>
        /// <param name="width">A szélesség, amire igazítani kell</param>
        /// <returns>A szöveg középre igazított változata</returns>
        static public string AlignTextCenter(string text, int width)
        {
            // TODO : (Juliska) Szöveg középre igazításának implementációja
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentOutOfRangeException("Nem lehet üres szöveg!");
            }
            if (width<text.Length)
            {
                throw new ArgumentOutOfRangeException("A szélesség nem lehet kisebb, mint a szöveg!");
            }
            int kiszamolt = (width - text.Length) / 2;
            string kiiras = (new string(' ', kiszamolt)+text+ new string(' ', kiszamolt));
            return kiiras;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Keverve adja vissza a két szöveg karaktereit.
        /// </summary>
        /// <param name = "textA" > Az első szöveg.</param>
        /// <param name = "textB" > A második szöveg.</param>
        /// <returns>A két szöveg karaktereinek keverésével elkészített szöveg</returns>
        /// 
        public static string MixedStrings(string textA, string textB)
        {
            // TODO : (Jancsi) Két szöveg keverésének implementációja
            // 1. példa:
            // textA = "Hello"
            // textB = "World"
            // Kimenet: HWeolrllod

            // 2. példa:
            // textA = "abcd"
            // textB = "12345"
            // Kimenet: a1b2c3d45
            if (string.IsNullOrEmpty(textA)||string.IsNullOrEmpty(textB))
            {
                throw new ArgumentOutOfRangeException("Nem lehet üres szöveg!");
            }
            string vegeredmeny = "";
            int indexA = 0;
            int indexB = 0;
            do
            {
                vegeredmeny += textA[indexA];
                indexA++;
                vegeredmeny += textB[indexB];
                indexB++;

            } while (indexA != textA.Length && indexB != textB.Length);
            return vegeredmeny;
            //throw new NotImplementedException();
        }

        // TODO : (Juliska) Két szöveg ismételt váltakozásának implementációja
        /// <summary>
        /// Egymás után váltakozva szereplő szövegeket fűz egybe.
        /// </summary>
        /// <param name="textA">Az első szöveg.</param>
        /// <param name="textB">A második szöveg.</param>
        /// <param name="iteration">A fűzések ismétlési száma.</param>
        /// <returns>A két szöveg ismételt váltakozásával elkészített szöveg</returns>
        public static string RepeatedStrings(string textA, string textB, int iteration)
        {
            // példa:
            // textA = "Hi"
            // textB = "There"
            // iteration = 3
            // Kimenet: HiThereHiThereHiThere
            if (string.IsNullOrEmpty(textA) || string.IsNullOrEmpty(textB))
            {
                throw new ArgumentOutOfRangeException("Nem lehet üres szöveg!");
            }
            if (iteration < 1) 
            {
                throw new ArgumentOutOfRangeException("A fűzések ismétlési száma nem lehet kisebb, mint 1!");
            }
            string eredmeny = "";
            do
            {
                eredmeny += textA;
                eredmeny += textB;
                iteration--;
            } while (iteration!=0);
            return eredmeny;
            //throw new NotImplementedException();
        }
    }
}

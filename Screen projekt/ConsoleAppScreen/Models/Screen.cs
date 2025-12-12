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
            if (x1 < 0 || y1 < 0 || x2 < 0|| y2 < 0)
            {
                throw new ArgumentOutOfRangeException("A koordináták nem lehetnek 0-nál kisebbek!");
            }
            // TODO : (jancsi) Vonal rajzolásának implementációja a képernyőn
            if (x1 == x2)
            {
                byte width = (byte)(y2 - y1);
                for (int i = 0;i < width+1; i++,y1++)
                {
                    Console.SetCursorPosition(x1, y1);
                    Console.WriteLine(sign);
                }
            }
            else if (y1 == y2)
            {
                byte width = (byte)(x2 - x1);
                Console.SetCursorPosition(x1, y1);
                Console.WriteLine(new string(sign, width));
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
            throw new NotImplementedException();
        }

        /// <summary>
        /// Keverve adja vissza a két szöveg karaktereit.
        /// </summary>
        /// <param name="textA">Az első szöveg.</param>
        /// <param name="textB">A második szöveg.</param>
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
            //do
            //{

            //} while (indexA==0 && indexB == 0);
            throw new NotImplementedException();
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

            throw new NotImplementedException();
        }
    }
}

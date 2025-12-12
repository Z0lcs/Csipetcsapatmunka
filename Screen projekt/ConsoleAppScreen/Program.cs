using ConsoleAppScreen.Models;

namespace ConsoleAppScreen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Például egy téglalap rajzolása a képernyőn
            Screen.DrawRectangle(10, 5, 20, 10);
            // Például egy kitöltött téglalap rajzolása a képernyőn
            Screen.FillRectangle(40, 5, 20, 10);
            // Például egy vonal rajzolása a képernyőn
            Screen.DrawLine(10, 20, 60, 20);
            // Például szöveg középre igazítása
            string centeredText = Screen.AlignTextCenter("Középre igazított szöveg", 50);
            Console.WriteLine(centeredText);
            // Például két szöveg keverése
            string mixedText = Screen.MixedStrings("Hello", "World");
            Console.WriteLine(mixedText);
            // Például két szöveg ismétlése
            string repeatedText = Screen.RepeatedStrings("AB", "12", 5);
            Console.WriteLine(repeatedText);


        }
    }
}

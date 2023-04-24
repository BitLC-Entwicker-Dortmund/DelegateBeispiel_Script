namespace DelegateBeispiel_Script {

    delegate int CalculateHandler(int xxx, int yyy);
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, Delegate!");

            CalculateHandler calculate;  // deklarion Delegatevariable

            calculate = new CalculateHandler(Demo.Addition);
            //Demo.Addition(7, 8);
            int ergebnis = calculate(7, 8);
            Console.WriteLine(ergebnis);

            //// Erweiterung
            int[] array = { 1, 3, 5, 7 };
            Umwandeln(array, calculate); // ergibt: 2,4,6,8

            calculate = Demo.Subtraktion; // Ändere calculate-Variable auf Subtraktion
            // Beachte Umwaldeln-Methode ändert sich NICHT
            Umwandeln(array, calculate);

            Console.Read();
        }

        static void Umwandeln(int[] werte, CalculateHandler dieMethode) {
            for (int i = 0; i < werte.Length; i++) {
                werte[i] = dieMethode(werte[i], 1);
            }
            foreach (var item in werte) {
                Console.WriteLine(item);
            }
        }
    }
}
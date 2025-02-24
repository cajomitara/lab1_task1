namespace lab1_Agalakov_ISTb_23_2
{
    /*
        Задание 12:
        Дано натуральное число  1 ≤ n ≤ 9999, определяющее стоимость товара в копейках.
        Выразить стоимость в рублях и копейках, например, 3 рубля 21 копейка, 15 рублей 5 копеек, 1 рубль ровно и т. п.
    */
    public class Program
    {
        static void Main(string[] args)
        {
            string input;
            string output;

            do
            {
                Console.Write("Введите количество копеек от 1 до 9999: ");
                input = Console.ReadLine();
            } while (!isInputValid(input));

            output = Logic.ComputeKopeikas(input);

            Console.WriteLine(output);
        }
        public static bool isInputValid(string input)
        {
            if (int.TryParse(input, out int amount))
            {
                if (amount < 1 || amount > 9999)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            return true;
        }
    }
    public class Logic
    {
        public static string ComputeKopeikas(string input)
        {
            int amount = int.Parse(input);

            int rubles = amount / 100;
            int kopeiki = amount % 100;

            string rubles_name = "рублей";
            string kopeiki_name = "копеек";

            if (rubles % 10 == 1)
            {
                rubles_name = "рубль";
            }
            if (rubles % 10 >= 2 && rubles % 10 <= 4)
            {
                rubles_name = "рубля";
            }
            if (rubles % 100 >= 11 && rubles % 100 <= 20)
            {
                rubles_name = "рублей";
            }

            if (kopeiki % 10 == 1)
            {
                kopeiki_name = "копейка";
            }
            if (kopeiki % 10 >= 2 && kopeiki % 10 <= 4)
            {
                kopeiki_name = "копейки";
            }
            if (kopeiki % 100 >= 11 && kopeiki % 100 <= 20)
            {
                kopeiki_name = "копеек";
            }

            string output = rubles + " " + rubles_name + " " + kopeiki + " " + kopeiki_name;

            return output;
        }
    }
}
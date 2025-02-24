namespace lab1_Agalakov_ISTb_23_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string output;
            do
            {
                Console.Write("Введите количество копеек от 1 до 9999: ");
                input = Console.ReadLine();

                if (int.TryParse(input, out int amount))
                {
                    if (amount >= 1 && amount <= 9999)
                    {
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

                        output = rubles + " " + rubles_name + " " + kopeiki + " " + kopeiki_name;

                        break;
                    }
                    else
                    {
                        output = "Введите число от 1 до 9999.";
                        break;
                    }
                }
                else
                {
                    output = "Введите целое натуральное число.";
                    break;
                }
            } while (input != null);

            Console.WriteLine(output);
        }
    }
}
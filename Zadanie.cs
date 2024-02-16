internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Witaj w grze 'zgadnij liczbę'!");
        Console.WriteLine("Twoim zadaniem jest zgadnięcie liczby, o której pomyśli komputer, od 1 do 100");
        Console.WriteLine("Cześć, tutaj komputer, jaki masz nick?");
        var imie = Console.ReadLine();
        int punktygracza = 0;
    start:
        Console.WriteLine("A więc podejmujesz wyzwanie " +imie + "? Mam na myśli jakąś liczbę od 1 do 100. Zgadniesz jaką?");
        Random radom = new Random();
        int losowaliczba = radom.Next(1, 100);
        int odpowiedź = 0;
        while (odpowiedź != losowaliczba)
        {
            odpowiedź = Convert.ToInt32(Console.ReadLine());

            if (odpowiedź < losowaliczba)
            {
                Console.WriteLine("Zła odpowiedź, liczba, o której myślę jest większa od " + odpowiedź + ". Ciekawe czy zgadniesz.");
            }
            else if (odpowiedź > losowaliczba)
            {
                Console.WriteLine("Zła odpowiedź, liczba, o której myślę jest mniejsza od " + odpowiedź + ". Ciekawe czy zgadniesz.");
            }
            else
            {
                Console.WriteLine("Poprawna odpowiedź! Liczba o której myślałem to " + losowaliczba);
                punktygracza += 1;
            }
        }
        Console.WriteLine("Ilość odgadniętych licb: " + punktygracza);
        Console.WriteLine("Jeżeli chcesz kontynuować wcisnij dowolny klawisz");
        Console.ReadLine();
        goto start; //wiem, że goto nie jest dobrym rozwiązaniem i powinno się unikać jego stosowania
    }
}
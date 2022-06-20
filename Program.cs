    
internal class Program
{
     static void Main(string[] args)
    {
        Rehber rehber = new Rehber();
        rehber.islemlerGörüntüle();
        string input = Console.ReadLine().Trim();
        while (input!= "h")
        {
            int userOption;
            while (!int.TryParse(input, out userOption) || userOption > 5 || userOption < 1 || input == "e")
            {
                Console.WriteLine("Lütfen 1 ile 5 arasında bir işlem numarası seçiniz ");
                input = Console.ReadLine();
                
            }
                if (userOption == 1 )
                {
                    rehber.NumaraKaydet();
                    System.Console.WriteLine("Başka işlem yapmak ister misiniz E/H?");
                    input = Console.ReadLine().Trim().ToLower();
                    if (input=="e")
                    {
                         rehber.islemlerGörüntüle();
                    }
                    
                }
                else if (userOption == 2 )
                 {
                     rehber.NumaraSil();
                     System.Console.WriteLine("Başka işlem yapmak ister misiniz E/H?");
                    
                     input = Console.ReadLine().Trim().ToLower();
                     if (input=="e")
                        {
                            rehber.islemlerGörüntüle();
                        }
                 }
                else if (userOption == 3 )
                {
                    rehber.NumaraGuncelle();
                    System.Console.WriteLine("Başka işlem yapmak ister misiniz E/H?");
                    
                    input = Console.ReadLine().Trim().ToLower();
                    if (input=="e")
                    {
                         rehber.islemlerGörüntüle();
                    }
                }
                else if (userOption == 4 )
                {
                    rehber.rehberiListelemek();
                    System.Console.WriteLine("Başka işlem yapmak ister misiniz E/H?");
                    input = Console.ReadLine().Trim().ToLower();
                    if (input=="e")
                    {
                         rehber.islemlerGörüntüle();
                    }
                }
                else if (userOption == 5 )
                {
                    rehber.aramaYap();
                    System.Console.WriteLine("Başka işlem yapmak ister misiniz E/H?");
                    input = Console.ReadLine().Trim().ToLower();
                    if (input=="e")
                    {
                         rehber.islemlerGörüntüle();
                    }
                }
        }
        
    }
        
}




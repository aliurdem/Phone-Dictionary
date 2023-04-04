

using PhoneDirectory;

internal class Program
{
    private static void Main(string[] args)
    {
        PhoneDictionary phoneDictionary = new PhoneDictionary();
        string chooice;

        while (true) {
            Console.Write("1 - Telefon Numarası Kaydet" +
                "\n2 - Telefon Numarası Sil" +
                "\n3 - Telefon Numarası Güncelle" +
                "\n4 - Rehber Listeleme" +
                "\n5 - Rehberde Arama" +
                "\n6 - Çıkış"+
                "\nLütfen yapmak istediğiniz işlemi seçiniz : ");

            chooice = Console.ReadLine().Trim();

            switch (chooice) {
                case "1":
                    phoneDictionary.AddCard();
                    break;
                case "2":
                    phoneDictionary.RemoveCard();
                    break;
                case "3":
                    phoneDictionary.UpdateNumber();
                    break;
                case "4":
                    phoneDictionary.ListCards();
                    break;
                case "5":
                    phoneDictionary.SearchCard();
                    break;
                case "6": 
                    return;
                default:
                    Console.WriteLine("Geçersiz seçenek !");
                    break;

            }
        
        }
    }
}
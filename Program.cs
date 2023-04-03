

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
                    phoneDictionary.addCard();
                    break;
                case "2":
                    phoneDictionary.removeCard();
                    break;
                case "3":
                    phoneDictionary.updateNumber();
                    break;
                case "4":
                    phoneDictionary.listCards();
                    break;
                case "5":
                    phoneDictionary.searchCard();
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
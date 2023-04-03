using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PhoneDirectory
{
    public class PhoneDictionary
    {
        List<Card> cards = new List<Card>();

        public void addCard() {
            Console.Write("Enter Name : "); 
            string name = Console.ReadLine().Trim();
            Console.Write("Enter Surname : ");
            string surname = Console.ReadLine().Trim();
            string number;
            // Girilen telefon numarsının uygun formatta olması için regex kontrolü
            
            while (true) {
                Console.Write("Enter Number : ");
                number = Console.ReadLine().Trim();
                number.Replace(" ", "");
                Regex regex = new Regex(@"^\d{10}$");
                if (regex.IsMatch(number))
                    break;
                else
                    Console.WriteLine("Yeniden deneyiniz");
            }

            Card card = new Card(name,surname, number);
            cards.Add(card);
            Console.WriteLine("Kişi eklendi");  
          
        }

        public void removeCard() {
            while (true) {
                Console.Write("Numarasını silmek istediğiniz kişinin adını veya soyadını giriniz : ");
            string entry = Console.ReadLine().Trim();
                foreach (Card card in cards)
                {
                    if (card.Name.Equals(entry) || card.SurName.Equals(entry))
                    {
                        Console.WriteLine($"{card.Name} isimli kişi rehberden silinmek üzere, onaylıyor musnuz ? (Y/N)");
                        entry = Console.ReadLine().Trim().ToUpper();
                        
                        if (entry.Equals("Y"))
                            cards.Remove(card);
                        
                        else if(entry.Equals("N"))
                            Console.WriteLine("İşlem iptal edildi");
                        
                        else
                            Console.WriteLine("Geçersiz seçenek");
                        
                        return;
                    }
                    
                }
                Console.Write("Aradığınız kriterlere uygun sonuç bulunamadı." +
                        "\n1 - Silmeyi sonladnır" +
                        "\n2- Yeniden dene " +
                        "Lütfen seçin yapınız :");

                entry = Console.ReadLine().Trim();

                if (entry.Equals("1"))
                    return;

                else if (entry.Equals("2"))
                    continue;

                else
                    Console.WriteLine("Geçersiz seçenek :"); return;





            }
                
        }

        public void updateNumber() {
            string cardToUpdate;

            Console.Write("Güncellemek istediğiniz kişinin adnı veya soy adını giriniz : ");
            cardToUpdate = Console.ReadLine().Trim();

            foreach (Card card in cards) {
                if (card.Name.Equals(cardToUpdate) || card.SurName.Equals(cardToUpdate))
                {
                    Console.Write("Yeni Numarayı Giriniz : ");
                    string newNumber = Console.ReadLine().Trim();
                    // Girilen telefon numarsının uygun formatta olması için regex kontrolü
                    while (true)
                    {
                        Console.Write("Enter Number : ");
                        newNumber = Console.ReadLine().Trim();
                        newNumber.Replace(" ", "");
                        Regex regex = new Regex(@"^\d{10}$");
                        if (regex.IsMatch(newNumber))
                            break;
                        else
                            Console.WriteLine("Yeniden deneyiniz");
                    }
                    card.PhoneNumber = newNumber;
                    Console.WriteLine($"{card.Name} {card.SurName} adlı kişinin numarası güncellendi");
                    return;
                }
            }
            
                Console.Write("Aradığınız kayıt bulunamadı !" +
                    "\n1 - Yeniden dene" +
                    "\n2 - İptal et" +
                    "\n3 - Yeni kayıt oluştur" +
                    "\nLütfen bir işlem seçini : ");
                string answer = Console.ReadLine().Trim();

                switch (answer)
                {
                    case "1":
                        updateNumber();
                        break;

                    case "2":
                        return;

                    case "3":
                        addCard();
                        break;

                    default:
                        Console.WriteLine("Geçersiz seçene !");
                        break;

                 }   
        }

        public void listCards() {
            if (cards.Count != 0)
            {
                Console.Write("1 - A-Z" +
                "\n2 - Z-A" +
                "\nYapmak istediğiniz sıralama türünüzü seçiniz : ");
                string sortType = Console.ReadLine().Trim();
                cards.Sort();
                if (sortType == "2")
                    cards.Reverse();

                foreach (Card card in cards)
                {
                    card.showInfo();
                }
            }
            else {
                Console.WriteLine("Rehberinizde Kayıtlı Numara Bulunmamaktadır !");
            }   
              
           
        }

        public void searchCard() {
            while (true) {
                Console.Write("Aramak istediğiniz kişinin adını, soyadını veya telfon numarsını giriniz : ");
                string dataToSearch = Console.ReadLine().Trim();
                foreach (Card card in cards)
                {
                    if (card.Name.Equals(dataToSearch) || card.SurName.Equals(dataToSearch) || card.PhoneNumber.Equals(dataToSearch))
                    {
                        card.showInfo();
                        return;
                    }
                   
                }
                Console.Write("Aradığınız numara blunamadı ! " +
                        "\n Tekrar denemek ister misniz ? (Y/N) : ");
                string answer = Console.ReadLine().Trim().ToUpper();
                if (answer.Equals("Y"))
                    continue;
                else if (answer.Equals("N"))
                    return;
                else
                    Console.WriteLine("Geçersiz Seçenek ! ");



            }
        }

    }
}

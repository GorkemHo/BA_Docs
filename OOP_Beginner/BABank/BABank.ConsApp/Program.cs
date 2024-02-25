using BABank.BaseEntities;
using BABank.Entities;
using BABank.Entities.Accounts;
using BABank.Entities.Bankings;
using BABank.Methods;
using BABank.Shared.Queues;
using BABank.Shared.RegisteredAccounts;
using System.Linq;

namespace BABank.ConsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegisteredVipAccounts<VipAccount>.GetInstance.Add(new VipAccount(1));
            RegisteredVipAccounts<VipAccount>.GetInstance.Add(new VipAccount(2));
            RegisteredVipAccounts<VipAccount>.GetInstance.Add(new VipAccount(3));
            RegisteredVipAccounts<VipAccount>.GetInstance.Add(new VipAccount(4));

            RegisteredAccounts<Account>.GetInstance.Add(new Account(5));
            RegisteredAccounts<Account>.GetInstance.Add(new Account(6));
            RegisteredAccounts<Account>.GetInstance.Add(new Account(7));
            RegisteredAccounts<Account>.GetInstance.Add(new Account(8));

            Console.WriteLine("Hoşgeldiniz.");
            Console.WriteLine("TCKN giriniz.");
            var tckn = int.Parse(Console.ReadLine());


            Console.WriteLine("Lütfen işlem tipi seçin.");
            Console.WriteLine("VIP için 1 - Normal için 2'ye basınız.");
            var islemSecimi = Console.ReadKey();


            if (islemSecimi.ToString() == "1")
            {
                if (RegisteredVipAccounts<VipAccount>.GetInstance.Any(o => o.TCKN == tckn))
                {
                    VipAccount current = RegisteredVipAccounts<VipAccount>.GetInstance.Where(o => o.TCKN == tckn).FirstOrDefault();
                    VipQueue.GetInstance.Add(current);
                    Console.WriteLine("Sıraya eklendiniz.");
                }
                else Console.WriteLine("VIP müşterimiz değilsiniz. Lütfen detaylar için Destek ile iletişime geçiniz.");
            }
            else if (islemSecimi.ToString() == "2")
            {
                if (RegisteredAccounts<Account>.GetInstance.Any(o => o.TCKN == tckn))
                {
                    Account current = RegisteredAccounts<Account>.GetInstance.Where(o => o.TCKN == tckn).FirstOrDefault();
                    AccountQueue.GetInstance.Add(current);
                    Console.WriteLine("Sıraya eklendiniz.");
                }
                else Console.WriteLine("Müşterimiz değilsiniz. Müşteri olmak için Destek ekibi ile iletişime geçiniz.");
            }
            else Console.WriteLine("Geçerli bir değer girmediniz.");

            BoxOffice boxOfficeRepo = new BoxOffice();
            IndividualBanking ib = new IndividualBanking();

            Customer customer = BoxOfficeRepo.NextCustomer(boxOfficeRepo, ib);


            Console.WriteLine($"Sıradaki Müşteri: {customer.NameSurname}");

            Console.WriteLine($"Günlük Bireysel işlem adedi: {boxOfficeRepo.IndividualBankingCount.Count.ToString()}");
            Console.WriteLine($"Günlük Vip işlem adedi: {boxOfficeRepo.VIPBankingCount.Count.ToString()}");
        
        }
        

        // Normal müşteri listesi
        public static List<Account> Customers = new List<Account>
        {
            new Account(5),
            new Account(6),
            new Account(7),
            new Account(8),

        };
    }
}



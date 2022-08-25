using GameProject.Concrete;
using GameProject.Entities;
using GameProject.Abstract;
using GameProject.Adapters;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamermanager = new GamerManager(new GamerCheckManager());
            Gamer gamer1=new Gamer() { DateOfBirth = new DateTime(1985, 1, 6), FirstName = "Engin", SurName = "Demiroğ", NationalityId = "12345678912" };
            gamermanager.Save(gamer1);
            Game game1 = new Game() { Id = 1,GameName="Gamesword",GamePrice=100 };
            CampaignManager campaignmanager = new CampaignManager();
            Campaign campaign1 = new Campaign { CampaingName = "Büyük İndirim!", Id = 1, DiscountRate = 20 };
            campaignmanager.Add(campaign1);
            SalesManagement sales = new SalesManagement();
            sales.Selling(gamer1, game1, campaign1);
            sales.Selling(gamer1, game1);
                     

        }
    }
}
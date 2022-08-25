using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class SalesManagement : ISellService
    {
        public void Selling(Gamer gamer, Game game)
        {
            Console.WriteLine($"{game.GameName} Oyunu {gamer.FirstName} Adlı Kullanıcıya {game.GamePrice} TL ye tanımlanmıştır."); ;
        }

        public void Selling(Gamer gamer, Game game, Campaign campaign)
        {
            game.DiscountedPrice = game.GamePrice - (game.GamePrice * campaign.DiscountRate / 100);
            Console.WriteLine($"{game.GameName} Oyunu {gamer.FirstName} Adlı Kullanıcıya {campaign.CampaingName} " +
                $"Kampanyasıyla %{campaign.DiscountRate} indirimle {game.DiscountedPrice} TL ye tanımlanmıştır.");
        }
    }
}

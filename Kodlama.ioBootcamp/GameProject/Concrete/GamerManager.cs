using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        private IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine($"{gamer} Oyuncusu Silindi."); 
        }

        public void Save(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
                Console.WriteLine($"{gamer.FirstName} Oyuncusu Sisteme Kaydedildi.");
            else
                throw new Exception("Oyuncu Gerçek Kişi Değil.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine($"{gamer} Oyuncusu Güncellendi.");
        }
    }
}

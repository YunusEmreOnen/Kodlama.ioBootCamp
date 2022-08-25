using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface ISellService
    {
        void Selling(Gamer gamer,Game game);
        void Selling(Gamer gamer,Game game,Campaign campaign);
        
    }
}

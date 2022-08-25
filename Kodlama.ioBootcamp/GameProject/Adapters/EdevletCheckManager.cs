using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Adapters
{
    internal class EdevletCheckManager : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            if (gamer.NationalityId.Length == 11 && gamer.FirstName != null && gamer.SurName != null&&gamer.DateOfBirth!= Convert.ToDateTime("1.01.0001 00:00:00"))
                return true;
            else
                return false;
        }
    }
}

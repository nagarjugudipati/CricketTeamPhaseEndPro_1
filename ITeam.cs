using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketTeamPhaseEndPro_1
{
    public interface ITeam
    {
        void AddPlayer(Player player);
        void RemovePlayer(int playerId);
        Player GetPlayerById(int playerId);
        List<Player> GetPlayersByName(string playerName);
        List<Player> GetAllPlayers();
    }
}

using Core.DBInteraction;
using System.Collections.Generic;
using System.Linq;

namespace Core.PlayerNS
{
    public class PlayerRepository
    {
        private readonly IRepositoryShell _repository;
        private readonly List<Player> _players;


        public List<PlayerBasicInfo> BasicInfos => _players.Select(p => p.Info).ToList();

        public PlayerRepository(IRepositoryShell repository)
        {
            _repository = repository;

            _players = repository.GetAll<Player>();
        }

        public Player CreateNewPlayer(string name)
        {
            var newPlayer = new Player(name);

            _players.Add(newPlayer);
            _repository.Add(newPlayer);

            return newPlayer;
        }

        public Player GetPlayerByInfo(PlayerBasicInfo info)
        {
            return _players.FirstOrDefault(p => p.Info == info);
        }

    }
}

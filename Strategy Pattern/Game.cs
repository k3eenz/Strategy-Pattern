using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class Game
    {
        private Player _player;
        public Game(Player player)
        {
            _player = player;
        }
        public void StartGame()
        {
            Console.WriteLine("Выберите оружие: 1 - Топор, 2 - Лук, 3 - Меч");
            while (true)
            {
                string? input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        _player.SetWeapon(new Axe());
                        break;
                    case "2":
                        _player.SetWeapon(new Bow());
                        break;
                    case "3":
                        _player.SetWeapon(new Sword());
                        break;
                    default:
                        Console.WriteLine("Непарвильный выбор");
                        continue;
                }
                _player.Attack();
            }
        }
    }
}

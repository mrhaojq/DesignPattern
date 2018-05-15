using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
public    class Player
    {
        private string _name;
        private Strategy _strategy;
        private int _winCount;
        private int _loseCount;
        private int _gameCount;

        public Player(string name, Strategy strategy)
        {
            _name = name;
            _strategy = strategy;
            _winCount = 0;
            _loseCount = 0;
            _gameCount = 0;
        }

        public Hand NextHand()
        {
            return _strategy.NextHand();
        }

        public void Win()
        {
            _strategy.Study(true);
            _winCount++;
            _gameCount++;
        }

        public void Lose()
        {
            _strategy.Study(false);
            _loseCount++;
            _gameCount++;
        }

        public void Even()
        {
           // _strategy.Study(false);//平局任务是输了
            _gameCount++;
        }

        public override string ToString()
        {
            return $"{_name}:{_gameCount} games,{_winCount} win,{_loseCount} lose.";
        }
    }
}

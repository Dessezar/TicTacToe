using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Player
    {
        public Player(int player)
        {
            _player = player;
        }

        private int _player { get; set; }



        public int NextPlayer()
        {
            if (_player == 1)
            {
                _player = 2;
            }
            else
            {
                _player = 1;
            }

            return _player;
        }
        public int GetPlayer()
        {
            return _player;
        }
        public int SetPlayer(int player)
        {
            _player = player;
            return _player; 
        }

    }
}

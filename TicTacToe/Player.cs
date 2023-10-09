using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    static class Player
    {

        public static int _player = 2;


        public static int NextPlayer()
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
        public static int GetPlayer()
        {
            return _player;
        }
        public static int SetPlayer(int player)
        {
            _player = player;
            return _player;
        }

    }
}

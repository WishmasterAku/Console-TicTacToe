using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_TicTacToe
{
    class Player
    {
        private string _playerName;
        private char _playerSign;
        private int _playerTotalWins;
        private int totalwins = 0;
        public Player()
        {
            _playerName = "PlayerOne";
            _playerSign = 'X';
            _playerTotalWins = 0;
           
        }
        public Player(string playerName, char playerSign, int playerTotalWins)
        {
            _playerName = playerName;
            _playerSign = playerSign;
            _playerTotalWins = playerTotalWins;

        }
        public string GetPlayerName()
        {
            return _playerName;
        }
        public char GetPlayerSign()
        {
            return _playerSign;
        }
        public int GetPlayerTotalWins()
        {
            return _playerTotalWins;
            
        }
        public int IncreasedPlayerTotalWins()
        {
            return _playerTotalWins++;
        }
        

    }
}

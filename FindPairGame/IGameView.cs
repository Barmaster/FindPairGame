using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPairGame
{
    public interface IGameView
    {
        GameController Controller{ get;set; }
        void Show();
        void Close();
    }
}

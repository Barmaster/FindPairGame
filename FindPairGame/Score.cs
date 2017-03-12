using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPairGame
{
    public class Score
    {
        private int _score;
        private int _tryLeft;
        private static int _hiscore;
        public Score(int tryleft)
        {
            _tryLeft = tryleft;
            _score = 0;
            _hiscore = Int32.Parse(System.IO.File.ReadAllText(@"..\..\Data\record.txt"));
        }
        public int hiscore
        {
            get { return _hiscore; }
            set { _hiscore=value; System.IO.File.WriteAllText(@"..\..\Data\record.txt", _hiscore.ToString()); }
        }
        public int tryLeft
        {
            get { return _tryLeft; }
            set { _tryLeft = value; }
        }
        public int score
        {

            get
            {
                return _score;
            }

            set
            {
                _score = value;
                if (_score > _hiscore)
                {
                    _hiscore = score;
                    System.IO.File.WriteAllText(@"..\..\Data\record.txt", _hiscore.ToString());
                }
            }
        }

    }
}

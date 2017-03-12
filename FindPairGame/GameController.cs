using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindPairGame
{
    public class GameController
    {
        private GameModel model;
        private IGameView view;
        public GameController(GameModel gameModel, IGameView iGameView)
        {
            model = gameModel;
            view = iGameView;
            view.Controller = this;
        }
        public GameModel Model
        {
            get { return model; }
        }
        public void Run()
        {
           view.Show();
        }
        //Сообщаем модели выбранную конфигурацию игры(размер и категория)
        public void wantThisConfig(string sizeName,string categoryName)
        {
            model.setConfigModel(sizeName,categoryName);
        }
        //Сообщаем модели координаты выбранной карточки
        public void pushThisCard(int i, int j)
        {
            model.ifThisImage(i, j);
        }
        public void resetHiscore()
        {
            model.resetHiscore();
        }
        public void restart()
        {
            model.StartGameModel();
        }
    }
}

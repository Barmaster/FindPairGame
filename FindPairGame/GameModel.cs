using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindPairGame
{
    public class GameModel : INotifyPropertyChanged
    {
        //Непосрественно игровой процесс может находиться в 6 состояниях
        public enum EnumState { Start, FirstClick, SecondClickGood, SecondClickBad, FinalWin, FinalLose };

        private EnumState stateOfModel;

        private static Dictionary<string, Size> sizeModes;//Размеры поля которые могут быть использованны

        private Size currentMatrixSize;

        private string[,] imageAdressMatrix;//Матрица хранящая изображения карточек соотвествует игровому полю   
             
        private Score score;

        private string currentCategory;

        private Point currentPosition;// Для того что бы не перерисловывать каждый раз представление
                                      
        private Point previosPosition;

        public GameModel()
        {
            previosPosition = new Point(-1, -1);
            initSizes();
        }

        public Size CurrentMatrixSize
        {
            get { return currentMatrixSize; }
            set { currentMatrixSize = value; }
        }

        public EnumState StateOfModel
        {
            get { return stateOfModel; }
            set { stateOfModel = value; RaisePropertyChanged("state"); }
        }

        public Point CurrentPosition
        {
            get { return currentPosition; }
            set { currentPosition = value; }
        }
        public Point PreviousPosition
        {
            get { return previosPosition; }
            set { previosPosition = value; }
        }
        
        public String[,] ImageAdressMatrix
        {
            get { return imageAdressMatrix;}
            set { imageAdressMatrix = value; }
        }

        public Score Score
        {
            get { return score; }
            set { score = value; }
        }
       private void initSizes()
        {
            sizeModes = new Dictionary<string, Size>
            {
                ["Small"] = new Size(2, 2),
                ["Medium"] = new Size(4, 4),
                ["Large"] = new Size(6, 6)
            };
        }
        //Задаем конфигурацию модели
        public void setConfigModel(string size, string category)
        {
            currentMatrixSize = sizeModes[size];
            currentCategory = category;
            StartGameModel();
        }
        public void StartGameModel()
        {
            Score = new Score(currentMatrixSize.Height * currentMatrixSize.Width * 3);
            FillImageMatrix(currentCategory);
            StateOfModel = EnumState.Start;
        }
        //Заполняем матрицу случайным образом парами изображений(точнее адресами), в соотвествии с выбранной категорией
        public void FillImageMatrix(string category)
        {
            imageAdressMatrix = new string[currentMatrixSize.Height, currentMatrixSize.Width];
            Random random = new Random();
            List <String> btImages = new List<string>();
            List<int> positions = new List<int>();
            DirectoryInfo ourDir = new DirectoryInfo(@"..\..\" + category);
            foreach (FileInfo file_name in ourDir.GetFiles())
            {
                if ((file_name.Extension.ToLower() == ".png") ||
                    (file_name.Extension.ToLower() == ".jpg") ||
                    (file_name.Extension.ToLower() == ".bmp") ||
                    (file_name.Extension.ToLower() == ".jpeg"))
                {
                    btImages.Add(category + "\\" + file_name.Name);
                }
            }
            for(int i=0;i<currentMatrixSize.Height*currentMatrixSize.Width;i++)
            {
                positions.Add(i); 
            }
            while (positions.Count != 0)
            {
                string rImage = btImages[random.Next(0, btImages.Count)];
                int firstPosition = positions[random.Next(0, positions.Count)];
                imageAdressMatrix[firstPosition / currentMatrixSize.Width, firstPosition % currentMatrixSize.Width] = @"../../"+rImage;
                positions.Remove(firstPosition);
                int secondPosition = positions[random.Next(0, positions.Count)];
                imageAdressMatrix[secondPosition/currentMatrixSize.Width,secondPosition% currentMatrixSize.Width] = @"../../" + rImage;
                positions.Remove(secondPosition);
            }

        }
       
        //Анализируем совпадает ли предыдущее изображение с текущим(если предыдущее отсуствует то присваиваем ему адрес текущего)
        //Так же выясняется достигнут ли финал игрового процесса(успешный или не успешный)
        public void ifThisImage(int row, int column)
        {
            currentPosition = new Point(row, column);
            string curentImage = imageAdressMatrix[row, column];
            if (currentPosition!=previosPosition)
            {
                Score.tryLeft--;
                if (previosPosition.X==-1&&previosPosition.Y==-1)
                {
                    StateOfModel = EnumState.FirstClick;
                    previosPosition = currentPosition;
                }
                else
                {
                    if (curentImage.Equals(imageAdressMatrix[previosPosition.X, previosPosition.Y]))
                    {
                        Score.score += 2; RaisePropertyChanged("score");
                        StateOfModel = EnumState.SecondClickGood;
                    }
                    else
                    {
                        StateOfModel = EnumState.SecondClickBad;
                    }
                    previosPosition = new Point(-1,-1);
                }
                if (score.score == currentMatrixSize.Height * currentMatrixSize.Width)//В случае победы оставшиеся попытки прибавляются к счету
                {
                    score.score += score.tryLeft;
                    score.tryLeft = 0;
                    StateOfModel = EnumState.FinalWin;
                }
                else if (score.tryLeft == 0) StateOfModel = EnumState.FinalLose;
            }
        }
        public void resetHiscore()
        {
            Score.hiscore = 0;
            RaisePropertyChanged("hiscore");
        }
        public event PropertyChangedEventHandler PropertyChanged;
        //Оповощения об изменениях каких-либо свойств модели
        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

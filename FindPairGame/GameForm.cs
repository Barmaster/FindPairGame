using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindPairGame
{
    public partial class GameForm : Form, IGameView
    {
        private GameController controller;
        public GameForm()
        {
            InitializeComponent();
            SetBackground();
        }

        public GameController Controller
        {
            get
            {
                return controller;
            }

            set
            {
                controller=value;
                bindToModel(controller.Model); //Подписываемся на изменения в модели
            }
        }

        private void bindToModel(GameModel model)
        {
            model.PropertyChanged += Model_PropertyChanged;
        }

        private void Model_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "state")
            {
                stateModelChanged(Controller.Model.StateOfModel);
            }
            else if (e.PropertyName == "hiscore")
            {
                ScoreRefresh();
            }
        }
        
        //Перерисовка числовой информации характеризующей игровой процесс
        private void ScoreRefresh()
        {
            tryLabel.Text = Controller.Model.Score.tryLeft.ToString();
            hiscoreLabel.Text = Controller.Model.Score.hiscore.ToString();
            scoreLabel.Text = Controller.Model.Score.score.ToString();
            scoreLabel.Refresh();
            hiscoreLabel.Refresh();
            tryLabel.Refresh();
        }
        // Реакция на изменение состояния модели при выборе какой-либо карточки(карточка открывается и затем либо переварачивается либо исчезает)
        private void stateModelChanged(GameModel.EnumState State)
        {
            ScoreRefresh();
            if (State==GameModel.EnumState.Start) CreateTableForCards(Controller.Model.CurrentMatrixSize);//Рисуем сетку с кнопками(карточки)
            else {
                    TableLayoutPanel tableForCards = getCurentTableForCards();
                    Button clickButton = (Button)tableForCards.GetControlFromPosition(Controller.Model.CurrentPosition.Y, Controller.Model.CurrentPosition.X);
                    clickButton.BackgroundImage = new Bitmap(new Bitmap(Controller.Model.ImageAdressMatrix[Controller.Model.CurrentPosition.X, Controller.Model.CurrentPosition.Y]),
                    clickButton.Width, clickButton.Height);
                    clickButton.Refresh();
                    switch (State)
                    {
                        case GameModel.EnumState.SecondClickGood:
                            {
                                Thread.Sleep(300);
                                Button prevClickButton = (Button)tableForCards.GetControlFromPosition(Controller.Model.PreviousPosition.Y, Controller.Model.PreviousPosition.X);
                                prevClickButton.Visible = false;
                                clickButton.Visible = false;
                                break;
                            }
                        case GameModel.EnumState.SecondClickBad:
                            {
                                Thread.Sleep(500);
                                Button prevClickButton = (Button)tableForCards.GetControlFromPosition(Controller.Model.PreviousPosition.Y, Controller.Model.PreviousPosition.X);
                                prevClickButton.BackgroundImage = null;
                                clickButton.BackgroundImage = null;
                                break;
                            }
                        case GameModel.EnumState.FinalWin:
                            {
                                tableForCards.Dispose();
                                restartButton.Text = "♕\nRestart";
                                restartButton.Visible = true;
                                congaratLabel.Visible = true;
                                break;
                            }
                        case GameModel.EnumState.FinalLose:
                            {
                             tableForCards.Dispose();
                             restartButton.Text = "☹\nRestart";
                             restartButton.Visible = true;
                             break;
                            }
                      }
                }
            ScoreRefresh();
         }
        
        private void startButton_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = false;
            RadioButton Size = null;
            RadioButton Category = null;
            foreach (object o in sizeChoise.Controls)
            {
                if (((o as RadioButton) is RadioButton)&&(o as RadioButton).Checked) { Size = (RadioButton)o; break; }
            }
            foreach (object o in categoryChoise.Controls)
            {
                if (((o as RadioButton) is RadioButton)&&(o as RadioButton).Checked) { Category = (RadioButton)o; break; }
            }
            //Отправляем контроллеру выбранный размер поля и категорию карточек
            Controller.wantThisConfig(Size.Text,Category.Text);
        }
        // Получаем текущую сетку кнопок(наших карточек), если такова имеется
        private TableLayoutPanel getCurentTableForCards()
        {
            TableLayoutPanel t = null;
            foreach (object o in GameForm.ActiveForm.Controls)
            {
                if ((o as TableLayoutPanel) is TableLayoutPanel) { t = (TableLayoutPanel)o; break; }
            }
            return t;
        }
        //Создаем сетку и заполняем ее кнопками (наши карточки), затем её возвращаем
        private TableLayoutPanel CreateTableForCards(Size rowsAndColumns)
        {
            restartButton.Visible = false;
            congaratLabel.Visible = false;
            int rows = rowsAndColumns.Height;
            int columns = rowsAndColumns.Width;
            TableLayoutPanel tableForCard = new TableLayoutPanel();
            tableForCard.Visible = false;
            tableForCard.BackColor = Color.Transparent;
            tableForCard.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tableForCard.ColumnCount = columns;
            tableForCard.RowCount = rows;
            for (int i = 0; i < rows; i++)
            {
                tableForCard.RowStyles.Add(new RowStyle(SizeType.Percent, 1F));
            }
            for (int j = 0; j < columns; j++)
            {
                tableForCard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            }
            tableForCard.Location = new Point(20, 20);
            tableForCard.Size = new Size(600, 600);
            this.Controls.Add(tableForCard);
            List<Button> btnsList = new List<Button>();
            for (int i = 0; i < tableForCard.RowCount * tableForCard.ColumnCount; i++)
            {
                btnsList.Add(new Button());
                btnsList[i].FlatStyle = FlatStyle.Flat;
                btnsList[i].FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 230, 223);
                btnsList[i].FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 220, 213);
                btnsList[i].Anchor = ((AnchorStyles)((((AnchorStyles.Top
                | AnchorStyles.Bottom)
                | AnchorStyles.Left)
                | AnchorStyles.Right)));
                btnsList[i].BackColor = Color.FromArgb(231,242,234);
                tableForCard.Controls.Add(btnsList[i], i / tableForCard.ColumnCount, i % tableForCard.ColumnCount);
                btnsList[i].Click += new EventHandler(this.cardButton_Click);
                btnsList[i].TabStop = false;
            }
            tableForCard.Visible = true;
            gamePanel.Visible = true;
            return tableForCard;
        }
        //Нажимаем на карточку и отправляем координаты выбранной карточки
        private void cardButton_Click(object sender, EventArgs e)
        {
            TableLayoutPanel t = getCurentTableForCards();
            Controller.pushThisCard(t.GetRow((Control)sender), t.GetColumn((Control)sender));
        }
        //Выход в главное меню
        private void exitButton_Click(object sender, EventArgs e)
        {
            if (getCurentTableForCards() != null) getCurentTableForCards().Dispose();
            menuPanel.Visible = true;
            gamePanel.Visible = false;
            congaratLabel.Visible = false;
            restartButton.Visible = false;
        }
        // Сброс рекорда
        private void resetHiscore_Click(object sender, EventArgs e)
        {
            Controller.resetHiscore();
        }
        // Рестарт текущей конфигурации
        private void restartButton_Click(object sender, EventArgs e)
        {
            if (getCurentTableForCards()!=null) getCurentTableForCards().Dispose();
            Controller.restart();
        }
        public new void Show()
        {
            Application.Run(this);
        }
        private void SetBackground()
        {
            
            this.BackgroundImage = new Bitmap(@"../../Data/back.jpg");
        }
    }
}

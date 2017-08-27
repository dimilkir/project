using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace DIK
{
    /// <summary>
    /// Логика взаимодействия для MainPageWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        DispatcherTimer enemyTimer = new DispatcherTimer();
        DispatcherTimer targetTimer = new DispatcherTimer();
        bool humanCaptured = false;

        public MainWindow()
        {
            InitializeComponent();

            enemyTimer.Tick += EnemyTimer_Tick;
            enemyTimer.Interval = TimeSpan.FromSeconds(2);

            targetTimer.Tick += TargetTimer_Tick;
            targetTimer.Interval = TimeSpan.FromSeconds(.1);
        }

        private void TargetTimer_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 1;
            if (progressBar.Value >= progressBar.Maximum)
                EndTheGame();
            
        }

        private void EndTheGame()
        {
            enemyTimer.Stop();
            targetTimer.Stop();
            humanCaptured = false;
            StartButton.Visibility = Visibility.Visible;
            playArea.Children.Add(GameOverText);
        }

        private void EnemyTimer_Tick(object sender, EventArgs e)
        {
            addEnemy();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            StartGame();
        }

        private void StartGame()
        {
            Human.IsHitTestVisible = true;
            humanCaptured = false;
            progressBar.Value = 1;
            StartButton.Visibility = Visibility.Collapsed;
            playArea.Children.Clear();
            playArea.Children.Add(target);
            playArea.Children.Add(Human);
            enemyTimer.Start();
            targetTimer.Start();
        }

        private void addEnemy()
        {
            ContentControl enemy = new ContentControl();
            enemy.Template = Resources["EnemyTemplate"] as ControlTemplate;
            AnimateEnemy(enemy, 0, playArea.ActualWidth - 100, "(Canvas.Left)");
            AnimateEnemy(enemy, random.Next((int)playArea.ActualHeight - 100), random.Next((int)playArea.ActualHeight - 100), "(Canvas.Top)");
            playArea.Children.Add(enemy);

            enemy.MouseEnter += Enemy_MouseEnter;
        }

        private void Enemy_MouseEnter(object sender, MouseEventArgs e)
        {
            if (humanCaptured)
                EndTheGame();
        }

        private void AnimateEnemy(ContentControl enemy, double from, double to, string propertyToAnimate)
        {
            Storyboard storyboard = new Storyboard() { AutoReverse = true, RepeatBehavior = RepeatBehavior.Forever };
            DoubleAnimation animation = new DoubleAnimation()
            {
                From = from,
                To = to,
                Duration = new Duration(TimeSpan.FromSeconds(random.Next(4, 6)))
            };
            Storyboard.SetTarget(animation, enemy);
            PropertyPath pToAnimate = new PropertyPath(propertyToAnimate, enemy); 
            Storyboard.SetTargetProperty(animation, pToAnimate);
            storyboard.Children.Add(animation);
            storyboard.Begin();
        }

        private void Human_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (enemyTimer.IsEnabled)
            {
                humanCaptured = true;
                Human.IsHitTestVisible = false;
            }
        }

        private void target_MouseEnter(object sender, MouseEventArgs e)
        {
            if (targetTimer.IsEnabled && humanCaptured)
            {
                progressBar.Value = 0;
                Canvas.SetLeft(target, random.Next(100, (int)playArea.ActualWidth - 100));
                Canvas.SetTop(target, random.Next(100, (int)playArea.ActualHeight - 100));
                Canvas.SetLeft(Human, random.Next(100, (int)playArea.ActualWidth - 100));
                Canvas.SetTop(Human, random.Next(100, (int)playArea.ActualHeight - 100));
                humanCaptured = false;
                Human.IsHitTestVisible = true;
            }
        }

        private void grid_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void playArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (humanCaptured)
            {
                Point pointerPosition = e.GetPosition(null);
                Point relativePosition = grid.TransformToVisual(playArea).Transform(pointerPosition);
                if ((Math.Abs(relativePosition.X-Canvas.GetLeft(Human)) > Human.ActualWidth * 3) 
                    || (Math.Abs(relativePosition.Y - Canvas.GetTop(Human)) > Human.ActualHeight * 3))
                {
                    humanCaptured = false;
                    Human.IsHitTestVisible = true;
                }    
                else
                {
                    Canvas.SetLeft(Human, relativePosition.X - Human.ActualWidth / 2);
                    Canvas.SetTop(Human, relativePosition.Y - Human.ActualHeight / 2);
                }
            }
        }
    }
}

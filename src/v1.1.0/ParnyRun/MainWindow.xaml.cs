using System;
using System.Collections.Generic;
using System.IO.Ports;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ParnyRun
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer counterGame = new DispatcherTimer();
        Random rand = new Random();
        List<Rectangle> xoaVatCan = new List<Rectangle>();

        Rectangle rtgParny = new Rectangle();
        double matDat;
        bool daNhay = false, overGame = false;
        int diem = 0, lucNhay = 2, counterCactus = 80, tocDo = 1, gioiHanNhay = 100;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void windowMain_Loaded(object sender, RoutedEventArgs e)
        {
            AnchorWindow();
            this.Focus();
        }

        // ==========================
        // Su kien button

        private void btnBatDau_Click(object sender, RoutedEventArgs e)
        {
            matDat = rtgGround.Margin.Top + 50;
            MakeParny(rtgParny);

            VisibilityLayout(1);

            counterGame.Tick += GameLoop;
            counterGame.Interval = new TimeSpan(20);
            counterGame.Start();
        }

        private void btnCaiDat_Click(object sender, RoutedEventArgs e)
        {
            VisibilityLayout(1);
            txbIntro.Visibility = Visibility.Visible;
            lblDiem.Visibility = Visibility.Collapsed;
            Canvas.SetLeft(rtgPascal, 253);
            Canvas.SetTop(rtgPascal, 331);
        }

        public void MakeParny(Rectangle parny)
        {
            parny.Tag = "parny";
            parny.Width = 150;
            parny.Height = 200;
            parny.Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/parny.png")));

            Canvas.SetLeft(parny, 50);
            Canvas.SetTop(parny, matDat - parny.Height);
            if (!canvasScreen.Children.Contains(parny)) canvasScreen.Children.Add(parny);
        }

        public void MakeCactus()
        {
            int soCactus = rand.Next(1, 4);
            Rectangle cactus = new Rectangle()
            {
                Tag = "cactus",
                Width = rtgParny.Width / 1.5,
                Height = rtgParny.Height / 1.5,
                Fill = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Images/cactus" + soCactus + ".png")))
            };
            Canvas.SetLeft(cactus, windowMain.Width);
            Canvas.SetTop(cactus, matDat - cactus.Height);
            canvasScreen.Children.Add(cactus);
        }

        // ==========================
        // Tuy chinh cua so

        public void AnchorWindow()
        {
            windowMain.MaxHeight = windowMain.ActualHeight;
            windowMain.MinHeight = windowMain.ActualHeight;
            windowMain.MaxWidth = windowMain.ActualWidth;
            windowMain.MinWidth = windowMain.ActualWidth;
        }

        public void VisibilityLayout(int mode)
        {
            overGame = false;
            switch (mode)
            {
                case 1:
                    lblParnyRun.Visibility = Visibility.Collapsed;
                    btnBatDau.Visibility = Visibility.Collapsed;
                    btnCaiDat.Visibility = Visibility.Collapsed;
                    lblDiem.Visibility = Visibility.Visible;
                    txbIntro.Visibility = Visibility.Collapsed;

                    Canvas.SetLeft(rtgPascal, windowMain.Width - 1.4 * rtgPascal.Width);
                    Canvas.SetTop(rtgPascal, 0);
                    break;
                case 2:
                    lblParnyRun.Visibility = Visibility.Visible;
                    btnBatDau.Visibility = Visibility.Visible;
                    btnCaiDat.Visibility = Visibility.Visible;
                    lblDiem.Visibility = Visibility.Collapsed;
                    txbIntro.Visibility = Visibility.Visible;

                    Canvas.SetLeft(rtgPascal, 253);
                    Canvas.SetTop(rtgPascal, 331);
                    break;
            }
        }

        // ==========================
        // Logic chinh cua game

        private void GameLoop(object sender, EventArgs e)
        {
            // Qua trinh nhay sau khi nhan space
            if (matDat - (Canvas.GetTop(rtgParny) + rtgParny.Height) < gioiHanNhay)
            {
                if (daNhay) Canvas.SetTop(rtgParny, Canvas.GetTop(rtgParny) - lucNhay);
            }
            else daNhay = false;

            // Qua trinh roi xuong dat
            if (!daNhay) {
                if (Canvas.GetBottom(rtgParny) > matDat - rtgParny.Height) Canvas.SetTop(rtgParny, Canvas.GetTop(rtgParny) + lucNhay);
                else Canvas.SetTop(rtgParny, matDat - rtgParny.Height);
            }

            // Sinh obstacle
            counterCactus -= 1;
            if (counterCactus == 0)
            {
                MakeCactus();
                counterCactus = rand.Next(3000, 5000);
            }

            // Di chuyen vat can va kiem tra va cham
            foreach (var x in canvasScreen.Children)
            {
                if (x is Rectangle ct && (string)ct.Tag == "cactus")
                {
                    // Dich chuyen vat can
                    Canvas.SetLeft(ct, Canvas.GetLeft(ct) - tocDo);

                    // Roi khoi tam nhin thi xoa
                    if (Canvas.GetLeft(ct) < -500)
                    {
                        xoaVatCan.Add(ct);
                        diem++;
                        lblDiem.Content = "Điểm: " + diem.ToString();
                    }

                    // Tao hitbox
                    Rect parnyHitBox = new Rect(Canvas.GetLeft(rtgParny), Canvas.GetTop(rtgParny), rtgParny.Width, rtgParny.Height);
                    parnyHitBox.Inflate(-20, -20);
                    Rect vatCanHitBox = new Rect(Canvas.GetLeft(ct), Canvas.GetTop(ct), ct.Width, ct.Height);
                    vatCanHitBox.Inflate(-20, -20);
                    if (parnyHitBox.IntersectsWith(vatCanHitBox)) overGame = true;
                }
            }

            // Tro choi ket thuc
            if (overGame) GameOver();
        }

        public void GameOver()
        {
            // Xoa obstacle khi no ra khoi man hinh
            xoaVatCan.Clear();
            canvasScreen.Children.Remove(rtgParny);

            counterGame.Stop();
            VisibilityLayout(2);
            MessageBox.Show("Game Over! Điểm của bạn = " + diem.ToString(), "Kết Quả", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void windowMain_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiem tra da nhay hay chua
            if (e.Key == Key.Space && !daNhay)
            {
                daNhay = true;
            }
        }
    }
}
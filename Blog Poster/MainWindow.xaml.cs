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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Blog_Poster
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Message { get; set; } //TextBoxのTextプロパティにBindするプロパティの定義

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this; //MainWindow.xamlで使用するBindingソースを検索する基準を
                                     //自分自身(MainWindowクラスオブジェクト)にする
        }

        private void Post_Button_Click(object sender, RoutedEventArgs e)
        {
            //確認ウィンドウを開く
            var con = new confirmation(Message); //Message="本文"
            con.Show();
        }
    }
}

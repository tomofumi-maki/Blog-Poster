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
using System.Windows.Threading;

namespace Blog_Poster
{
    /// <summary>
    /// confirmation.xaml の相互作用ロジック
    /// </summary>
    public partial class confirmation : Window
    {
        public confirmation(string msg)
        {
            InitializeComponent();

            postingBodyText.Text = msg;
        }

        private void Posting_Button_Click(object sender, RoutedEventArgs e)
        {
            //本文を投稿

            //投稿完了の通知
            MessageBox.Show("Posted!");
            this.Close();
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

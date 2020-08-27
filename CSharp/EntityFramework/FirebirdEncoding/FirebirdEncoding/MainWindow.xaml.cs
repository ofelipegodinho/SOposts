using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace FirebirdEncoding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string appPath = AppContext.BaseDirectory;
            string connectionString = $"database=localhost/3050:{appPath}\\database\\test.fdb;user=sysdba;password=masterkey";          
            using (AppDbContext con = new AppDbContext(connectionString))
            {
                Product p = con.Products.First();
                lblDefault.Text = p.Name;
                var win1252 = Encoding.GetEncoding(1252);
                var utf8 = Encoding.UTF8;
                lblWIN1252.Text = Encoding.UTF8.GetString(Encoding.Convert(win1252, utf8, win1252.GetBytes(p.Name)));
                
            }
        }
    }
}

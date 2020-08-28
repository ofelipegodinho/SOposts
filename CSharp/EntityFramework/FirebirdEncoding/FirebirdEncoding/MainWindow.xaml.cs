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
                lblText.Text = p.Name;                
            }
        }
    }
}

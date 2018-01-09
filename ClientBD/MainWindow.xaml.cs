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

namespace ClientBD
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            if (!new InterfaceHandler.FormsChecker().IsWindowOK(this))
                MessageBox.Show("Вы заполнили не все поля, либо допустили ошибку при вводе");
            else if (new Authorization.AuthModule().CheckAuthData(tb_login.Text, pb_password.Password))
            {
                var mainForm = new Forms.MainForm();
                mainForm.Show();
               // this.Hide();
            }
            else
                MessageBox.Show("Ошибка авторизации", "Ошибка");
        }
    }
}

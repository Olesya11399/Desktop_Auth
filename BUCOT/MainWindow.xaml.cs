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


namespace BUCOT
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var regWindow = new Reg();
            regWindow.Show();
        }
        private void BtnLog_Click(object sender, RoutedEventArgs e)
        {
            WSREntities db = new WSREntities();
            Пользователь user = null;
            user = db.Пользователь.Where(p => p.Логин == TBLogin.Text && p.Пароль == TBPass.Text).FirstOrDefault();
            if (user != null)
            {
                MessageBox.Show("Вход выполнен!");

                if (user.Роль == "Директор")
                {
                    var newForm = new DirectorWindow();
                    newForm.Show();
                    this.Close();
                }

                if (user.Роль == "Менеджер")
                {
                    var newForm = new ManagerWindow();
                    newForm.Show();
                    this.Close();
                }
            }
            else MessageBox.Show("Пользователя с таким логином и паролем не существует!");

          

        }

    }
}

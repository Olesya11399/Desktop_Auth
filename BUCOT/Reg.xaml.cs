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

namespace BUCOT
{
    /// <summary>
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Window
    {
        private Пользователь _currentUser = new Пользователь();
        public Reg()
        {
            InitializeComponent();
            DataContext = _currentUser;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentUser.Наименование))
                errors.AppendLine("Укажите имя");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString()); ;
                return;
            }
            else
                _currentUser.Роль = "Заказчик";
                WSREntities.GetContext().Пользователь.Add(_currentUser);

            try {
                WSREntities.GetContext().SaveChanges();
                MessageBox.Show("Пользователь зарегистрирован");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
         
        }
    }
}

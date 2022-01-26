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
    /// Логика взаимодействия для AddEditWindow.xaml
    /// </summary>
    public partial class AddEditWindow : Window
    {
        private Изделие _currentIzdel = new Изделие();
        public AddEditWindow(Изделие selectedIzdel)
        {
            InitializeComponent();

            if (selectedIzdel != null)
                _currentIzdel = selectedIzdel;

            DataContext = _currentIzdel;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if(_currentIzdel.Артикул=="")
                WSREntities.GetContext().Изделие.Add(_currentIzdel);

            try
            {
                WSREntities.GetContext().SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}

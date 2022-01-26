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
    /// Логика взаимодействия для DirectorWindow.xaml
    /// </summary>
    public partial class DirectorWindow : Window
    {
       
        public DirectorWindow()
        {
            InitializeComponent();
            
           // DGridIzdeliya.ItemsSource = WSREntities.GetContext().Изделие.ToList();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            AddEditWindow addEdit = new AddEditWindow((sender as Button).DataContext as Изделие);
            addEdit.Show();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddEditWindow addEdit = new AddEditWindow(null);
            addEdit.Show();
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            var izdeliaForRemoving = DGridIzdeliya.SelectedItems.Cast<Изделие>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {izdeliaForRemoving.Count()} элементов?", "Внимание", 
                MessageBoxButton.YesNo, MessageBoxImage.Question)==MessageBoxResult.Yes)
            {
                try
                {
                    WSREntities.GetContext().Изделие.RemoveRange(izdeliaForRemoving);
                    WSREntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");

                    DGridIzdeliya.ItemsSource = WSREntities.GetContext().Изделие.ToList();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Frame_ContentRendered(object sender, EventArgs e)
        {

        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                WSREntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridIzdeliya.ItemsSource = WSREntities.GetContext().Изделие.ToList();
            }
        }
    }
}

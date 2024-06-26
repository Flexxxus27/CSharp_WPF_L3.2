using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CSharp_WPF_L3._2.src;

namespace CSharp_WPF_L3._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<ToDo> toDoList = new List<ToDo>();
        public MainWindow()
        {
            InitializeComponent();
            descriptionToDo.Text = "Описания нет";
            dateToDo.SelectedDate = DateTime.Today.AddDays(1);

            toDoList.Add(new ToDo("Родится", new DateTime(2024, 01, 01), "Важно!"));
            toDoList.Add(new ToDo("Посадить сына", new DateTime(2024, 01, 11), "Важно!"));
            toDoList.Add(new ToDo("Построить дерево", new DateTime(2024, 01, 12), "Важно!"));
            toDoList.Add(new ToDo("Вырастить дом", new DateTime(2024, 01, 13), "Важно!"));
            toDoList.Add(new ToDo("Умереть", new DateTime(2024, 01, 15), "Важно!"));

            RefreshToDoList();
            CheckboxEnableToDo_Unchecked(Owner, new RoutedEventArgs());
        }
        private void RefreshToDoList()
        {
            listToDo.ItemsSource = null;
            listToDo.ItemsSource = toDoList;
        }
        private void CheckboxEnableToDo_Checked(object sender, RoutedEventArgs e) 
        { 
            if(groupBoxToDo == null || buttonAdd == null) return;
            groupBoxToDo.Visibility = Visibility.Visible;
            buttonAdd.Visibility = Visibility.Visible;
            CreateToDo createToDo = new CreateToDo();
            createToDo.Show();
            this.Close();
            createToDo.Owner = this;
        }
        private void CheckboxEnableToDo_Unchecked(object sender, RoutedEventArgs e)
        {
            if(groupBoxToDo == null || buttonAdd == null) return;
            groupBoxToDo.Visibility = Visibility.Hidden;
            buttonAdd.Visibility = Visibility.Hidden;
        }
        private void ButtonRemoveToDo_Click(object sender, RoutedEventArgs e)
        {
            toDoList.Remove(listToDo.SelectedItem as ToDo);
            RefreshToDoList();
        }

        private void ButtonAddToDo_Click(object sender, RoutedEventArgs e)
        {
            if(!dateToDo.SelectedDate.HasValue)
            {
                MessageBox.Show("Дата повесилась", Name = "ошибка");
                return;
            }
            toDoList.Add(new ToDo(
                titleToDo.Text,
                (DateTime)dateToDo.SelectedDate,
                descriptionToDo.Text
                )
              );
            titleToDo.Text = null;
            descriptionToDo.Text = "Описание нет";
            RefreshToDoList();
        }
    }
}
/// основные св-ва окна Icon - иконка в левом верхнем левом углу экрана и в панели задач.
/// Св-ва Top и Left задают отступ от верхней и левой границы экраны.
/// Св-во ResizeMode - задает режим изменения режимов окна. Может принемать следующие значения:
/// CanMinimaize - окно можно только свернуть, 
/// NoResize - нельзя изменить начальные размеры, 
///     CanResize - менять размеры можно, 
///     CanResizeWithGrip - в правом нижнем углу окна появляется визуализация того, что у окна можно изменять размеры.
/// Св-во Title - заголовок окна.
/// Св-во WindowState - состояние окна. Возможные значения:
///     Maximized - раскрыто на весь экран, 
///     Minimized - свернуто, 
///     Normal - стандартное состояние.
/// В процессе работы окно проходит ряд этапов, которые могут быть доступны через обработку событий класса Window: 
///     Initialized - это событие возникает при инициализации окна, когда у него устанавливаются все св-ва, но до применения к нему стилей и привязки данных, 
///     Loaded - возникает после полной инициализации окна и применения к нему стилей и привязки данных. После генерации этого события
/// происходит визуализация элемента, и окно отображается на экране и становится видимым для пользователя, 
/// Closing - возникает при закрытии окна, 
/// Closed - возникает, когда окно становится закрытым,
/// Unloaded - возникает после закрытия окна при выгрузке всех связанных ресурсов из памяти.
///     
/// 
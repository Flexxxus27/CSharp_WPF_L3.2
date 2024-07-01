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
        public List<ToDo> TodoList;
        public MainWindow()
        {
            InitializeComponent();
           TodoList = new List<ToDo>();
            TodoList.Add(new ToDo("Дело 1","Описание", new DateTime(2024,01,10)));
            TodoList.Add(new ToDo("Дело 1", "Описание", new DateTime(2024, 01, 10)));
            TodoList.Add(new ToDo("Дело 1", "Описание", new DateTime(2024, 01, 10)));

            listToDo.ItemsSource = TodoList;
        }
        private void DeleteJob(object sender, ExecutedRoutedEventArgs e)
        {
            TodoList.Remove(listToDo.SelectedItem as ToDo);
            listToDo.ItemsSource = null;
            listToDo.ItemsSource = TodoList;
        }
        private void OpenWindow(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Owner = this;
            window1.Show();
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if(listToDo.SelectedItem != null) 
            {
                (listToDo.SelectedItem as ToDo).Done = true;
            }
        }
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            if (listToDo.SelectedItem != null)
            {
                (listToDo.SelectedItem as ToDo).Done = false;
            }
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
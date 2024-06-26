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

namespace CSharp_WPF_L3._2
{
    /// <summary>
    /// Логика взаимодействия для CreateToDo.xaml
    /// </summary>
    public partial class CreateToDo : Window
    {
        public CreateToDo()
        {
            InitializeComponent();
            
        }
    }
}




///DataGrid - это элемент управления отображением данных, который извлекает информацию из коллекции объектов и визуализирует ее в таблице. Каждая строка соответсвует отдельному объекту
///(чаще всего экземпляру класса), а каждый столбец - св-ву этого объекта(чаще все св-ва класса). Самый простой способ заполнения DataGrid элементами это привязка данных с автоматической
///генерацией столбцов.
///Св-ва DataGrid: 
///     RowBackground и AlternatingRowBackground - кисть, которая используется для закрашивания фона позади каждой строки(RowBackground), и фон чередующихся строк(Alter...).
///     ColumnheaderHeight - высота строки, отображающей заголовок столбцов, 
///     ColumnWidth - установка ширины по умолчанию для каждого столбца, 
///     RowHeight - высота строк, GridLinesVisibility - указывает,
///какие линии должны отображаться в сетке(Horizontal,Vertical, None, All), 
///     HeadersVisibility - указывает, какие заголовки должны отображаться(Column,Row,All,None), 
///     AutoGenerateColumn - активирует автоматическое создание столбцов, на основе приведенных в ItemSource данных, 
///     CanUserDeleteRows - активирует возможность удаления строк при нажатии кнопки Delete, 
///     CanUserAddRows -добавляет пустую строку в конце списка, которая предназначена для добавления новых элементов.
/// 
/// DataGrid поддерживает слудующие варианты столбцов:
///     DataGridTextColumn - отображает элемент TextBlock или TextBox при редактировании.
///     DataGridHyperlinkColumn - представляет гиперссылку и позволяет переходить по указанному адресу.
///     DataGridCheckBoxColumn - отображает элемент CheckBox.
///     DataGridComboBoxColumn - отображает выпадающий список - элемент ComboBox.
///     DataGridTemplateColumn - позволяет задать спецефичный шаблон для отображения столбцов.
///Шаблон ячейки - CellTemplate - элемент DataGridTemplateColumn предназначено для задания шаблона ячейки и может содержать в себе элемент DataTemplate.
///Детали строк. Это возможность элемента DataGrid выводит детали какой-либо строки при нажатии на нее. 
///     св-во RowDetailsTemplate - данное св-во может содержать элемент DataTemplate.
///     св-во RowDetailsVVisibilityMode - по умолчанию данное св-во установленно в значении VisibleWhenSelected(детали строки появляются при нажатии на нее), также есть возможность установить значение 
///Visible(детали всех строк будут видны всегда) или Collapsed (блокирует просмотр деталей строк).
///
///
///============ MVC(Model view controller) =============\\\

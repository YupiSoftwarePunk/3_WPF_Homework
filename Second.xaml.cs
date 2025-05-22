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

namespace _3_WPF_Homework
{
    /// <summary>
    /// Логика взаимодействия для Second.xaml
    /// </summary>
    public partial class Second : Window
    {
        public List<ToDo> todo= new List<ToDo>();

        public Second()
        {
            InitializeComponent();
            descriptionToDo.Text = "Описания нет";
            dateToDo.SelectedDate = DateTime.Now;

            todo.Add(new ToDo("Дописать проект", new DateTime(2025, 5, 23), "Доделать проект по мобилкам"));
            todo.Add(new ToDo("Поиграть в компьютерную игру", new DateTime(2025, 5, 24), "Поиграть в Farming Simulator 22"));
            todo.Add(new ToDo("Дописать проект", new DateTime(2025, 5, 23), "Доделать проект с математическими классами"));
            
            listToDo.ItemsSource = todo;
        }


        private void checkBoxChecked(object sender, RoutedEventArgs e)
        {
            if (groupBoxToDo != null)
            {
                groupBoxToDo.Visibility = Visibility.Visible;
            }
        }

        private void checkBoxUnchecked(object sender, RoutedEventArgs e)
        {
            groupBoxToDo.Visibility = Visibility.Hidden;
        }


        private void btnAdd(object sender, RoutedEventArgs e)
        {
            var temp = dateToDo.SelectedDate.Value;

            todo.Add(new ToDo(titleToDo.Text, new DateTime(temp.Year, temp.Month, temp.Day), descriptionToDo.Text));
        }

        private void btnDelete(object sender, RoutedEventArgs e)
        {
            if (listToDo.SelectedItem as ToDo == null)
            {
                return;
            }
            else
            {
                todo.Remove(listToDo.SelectedItem as ToDo);
            }
        }

        public class ToDo
        {
            private string name;
            private DateTime dateTime;
            private string discription;

            public ToDo(string name, DateTime dateTime, string discription)
            {
                this.name = name;
                this.dateTime = dateTime;
                this.discription = discription;
            }
        }
    }
}

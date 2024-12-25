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

namespace WpfApp10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); // Инициализация компонентов окна
        }

        private void CheckArrays_Click(object sender, RoutedEventArgs e)
        {
            // Задаем два массива для сравнения
            int[] array1 = { 5, 10, 15, 20, 25 }; // Первый массив
            int[] array2 = { 3, 12, 10, 18, 30 }; // Второй массив

            // Список для хранения результатов сравнения
            List<string> results = new List<string>();

            // Проверяем соответствующие элементы массивов
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] > array2[i]) // Если элемент первого массива больше соответствующего элемента второго массива
                {
                    results.Add($"Элемент {i + 1}: {array1[i]} > {array2[i]}"); // Добавляем результат в список
                }
            }

            // Выводим результаты в ListBox
            listBoxResults.Items.Clear(); // Очистка предыдущих результатов
            if (results.Count > 0) // Если есть результаты
            {
                foreach (var result in results)
                {
                    listBoxResults.Items.Add(result); // Добавляем каждый результат в ListBox
                }
            }
            else
            {
                listBoxResults.Items.Add("Нет элементов первого массива, которые превосходят соответствующие элементы второго."); // Сообщение если нет результатов
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(); // Закрытие приложения при нажатии кнопки "Выход"
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Кошеренков Максим Сергеевич\nНомер работы: 10\nЗадание: Проверить, сколько элементов первого массива превосходят соответствующие элементы второго.", "О программе");
            // Вывод информации о разработчике и задании при нажатии кнопки "О программе"
        }
    }
}
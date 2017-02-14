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

namespace Labra4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            LuoHenkilöt();

        }

        public void LuoHenkilöt()
        {
            Person person = new Person();
            person.FirstName = "Kirsi";
            person.LastName = "Kernel";
            person.Address = "torikatu 1";
            person.Age = 30;
            person.PhoneNumber = "020-12345678";
          

            Teacher teacher = new Teacher();
            teacher.FirstName = "Teppo";
            teacher.LastName = "Konsoli";
            teacher.Address = "piippukatu 2";
            teacher.Age = 40;
            teacher.PhoneNumber = "010-12345678";
            teacher.Room = "D100";

         //   Console.WriteLine(teacher.ToString());

            //huom kirjoitusvirhe
            Sudent student = new Sudent("Minna", "Husso", "J9090");
            student.Address = "kilju 3";
            student.Age = 20;
            student.PhoneNumber = "040-12345678";
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            LuoHenkilöt();
         //   string tietoa_opettajasta = teacher.ToString();
         // tämä ei toimi   
         //   Console.WriteLine(teacher.ToString());
         //   person.PersonMethod(); // This method belongs to Person!
        }
    }
}

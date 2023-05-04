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
using CitizenDevelopment1.Database;

namespace CitizenDevelopment1.Views
{
    public partial class UpdateView : UserControl
    {
        public UpdateView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string applicationName = TextBoxApplicationName.Text;
            string userName = TextBoxUserName.Text;
            string comment = TextBoxComment.Text;
            string id = TextBoxId.Text;
            int idConverted;
            bool isIdCorrect = int.TryParse(id, out idConverted);
            
            if (!isIdCorrect)
            { MessageBox.Show("Invalid Id!"); }
            else if (applicationName.Length < 1)
            {
                MessageBox.Show("Insert application name!");
            }
            else if (userName.Length < 1)
            {
                MessageBox.Show("Insert username!");
            }
            else if (comment.Length < 1)
            {
                MessageBox.Show("Insert comment!");
            }
            else
            {
                User user = new User(applicationName, userName, comment);

                bool isSuccess = AccessToDatabase.UpdateUser(idConverted, user);

                if(isSuccess)
                MessageBox.Show("Success!");
                else
                MessageBox.Show("Record with this Id is not exists!");

                TextBoxId.Text = "";
                TextBoxApplicationName.Text = "";
                TextBoxUserName.Text = "";
                TextBoxComment.Text = "";
            }
        }
    }
}

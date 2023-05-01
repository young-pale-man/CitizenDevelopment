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
    public partial class InsertView : UserControl
    {
        public InsertView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string applicationName = TextBoxApplicationName.Text;
            string userName = TextBoxUserName.Text;
            string comment = TextBoxComment.Text;

            if (applicationName.Length < 1)
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

                AccessToDatabase.SaveUser(user);
                MessageBox.Show("Success!");

                TextBoxApplicationName.Text = "";
                TextBoxUserName.Text = "";
                TextBoxComment.Text = "";
            }
        }
    }
}

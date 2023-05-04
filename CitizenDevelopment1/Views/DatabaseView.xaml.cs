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
    public partial class DatabaseView : System.Windows.Controls.UserControl
    {
        public DatabaseView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DatabaseListBox.Items.Clear();

            List<UsersOutput> users = AccessToDatabase.DatabaseUser();

            //column names
            DatabaseListBox.Items.Add("Id");
            DatabaseListBox.Items.Add("ApplicationName");
            DatabaseListBox.Items.Add("UserName");
            DatabaseListBox.Items.Add("Comment");

            //column values
            users.ForEach(p =>
            {
                DatabaseListBox.Items.Add(p.id);
                DatabaseListBox.Items.Add(p.applicationName);
                DatabaseListBox.Items.Add(p.userName);
                DatabaseListBox.Items.Add(p.comment);
            });
        }
    }
}

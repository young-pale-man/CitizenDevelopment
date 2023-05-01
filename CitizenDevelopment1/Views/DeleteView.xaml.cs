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
using System.Windows.Forms;
using System.Data.SqlClient;
using CitizenDevelopment1.Database;
using MessageBox = System.Windows.Forms.MessageBox;

namespace CitizenDevelopment1.Views
{
    public partial class DeleteView : System.Windows.Controls.UserControl
    {
        public DeleteView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string id = TextBoxId.Text;
            int idConverted;
            bool isIdCorrect = int.TryParse(id, out idConverted);

            if (!isIdCorrect)
            { MessageBox.Show("Invalid Id!"); }
            
            else
            {
                AccessToDatabase.DeleteUser(idConverted);
                MessageBox.Show("Success!");
                TextBoxId.Text = "";
            }
        }
    }
}

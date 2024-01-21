using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text.Json;
using RestSharp;

namespace WinFormsApp1
{


    public class User
    {
        public string userName { get; set; }
        public string userPassword { get; set; }
        public string emailAddress { get; set; }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

     

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            var user = new User
            {
                userName        =   textBox1.Text,
                userPassword    =   textBox2.Text,
                emailAddress    =   textBox3.Text,
            };

            string jsonString = JsonSerializer.Serialize(user);
            var client = new RestClient("http://165.232.147.210:8080/register");

            var request = new RestRequest("/", Method.Post);
            request.AddHeader("Accept", "application/json");
            var body = user;
            request.AddJsonBody(body);
            var queryResult = client.Execute(request).Content;
            MessageBox.Show(queryResult);
     


        }


    }
}

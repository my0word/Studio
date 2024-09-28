namespace EdikIvan
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            string correctUsername = "admin";
            string correctPassword = "123";

            string enteredUsername = logtext.Text;
            string enteredPassword = passtext.Text;

            if (enteredUsername == correctUsername && enteredPassword == correctPassword)
            {
                Close();
            var thread = new Thread(openWindow);
            thread.Start();
            }
            else
            {
                MessageBox.Show("Логин или пароль не верен");
            }
        }
        private void openWindow()
        {
            Application.Run(new MainForm());
        }
    }
}

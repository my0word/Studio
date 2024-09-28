using System.Data;
using System.Data.SQLite;
using System.Text.RegularExpressions;

namespace EdikIvan
{
    public partial class LogForm : Form
    {
        public static SQLiteConnection DB = new SQLiteConnection(Database.connection);
        private Color originalColor;
        private System.Windows.Forms.Timer animationTimer;
        private int animationStep = 0;
        private int animationSteps = 20;
        private int animationDuration = 20;

        public LogForm()
        {
            InitializeComponent();
            originalColor = logBtn.BackColor;
            loadingProgressBar.Visible = false;
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = animationDuration / animationSteps;
            animationTimer.Tick += AnimationTimer_Tick;
            passtext.UseSystemPasswordChar = true;
            confirmPasstext.UseSystemPasswordChar = true;
            showPasswordBtn.Click += showPasswordBtn_Click;
            confirmShowPasswordBtn.Click += confirmShowPasswordBtn_Click;
            currentPasstext.UseSystemPasswordChar = true;
            newPasstext.UseSystemPasswordChar = true;
            confirmNewPasstext.UseSystemPasswordChar = true;
            changePasswordBtn.Click += changePasswordBtn_Click;
        }

        private async void changePasswordBtn_Click(object sender, EventArgs e)
        {
            string currentPassword = currentPasstext.Text;
            string newPassword = newPasstext.Text;
            string confirmNewPassword = confirmNewPasstext.Text;

            if (!IsValidPassword(newPassword))
            {
                ShowError("Пароль может содержать только буквы и цифры и должен быть от 3 до 20 символов.", changePasswordBtn);
                return;
            }

            if (newPassword != confirmNewPassword)
            {
                ShowError("Новые пароли не совпадают. Пожалуйста, попробуйте снова.", changePasswordBtn);
                return;
            }

            OpenConnection();

            string encryptedCurrentPassword = Encrypt(currentPassword);

            using (var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Users WHERE Login = @Login AND Password = @CurrentPassword", DB))
            {
                cmd.Parameters.AddWithValue("@Login", logtext.Text);
                cmd.Parameters.AddWithValue("@CurrentPassword", encryptedCurrentPassword);

                int count = Convert.ToInt32(await cmd.ExecuteScalarAsync());

                if (count > 0)
                {
                    string encryptedNewPassword = Encrypt(newPassword);
                    using (var updateCmd = new SQLiteCommand("UPDATE Users SET Password = @NewPassword WHERE Login = @Login", DB))
                    {
                        updateCmd.Parameters.AddWithValue("@NewPassword", encryptedNewPassword);
                        updateCmd.Parameters.AddWithValue("@Login", logtext.Text);
                        await updateCmd.ExecuteNonQueryAsync();
                        ShowSuccess(changePasswordBtn);
                        MessageBox.Show("Пароль успешно изменен!");
                    }
                }
                else
                {
                    ShowError("Текущий пароль неверен.", changePasswordBtn);
                }
            }

            CloseConnection();
        }

        private void showPasswordBtn_Click(object sender, EventArgs e)
        {
            if (passtext.UseSystemPasswordChar)
            {
                passtext.UseSystemPasswordChar = false;
                showPasswordBtn.Text = "Скрыть";
            }
            else
            {
                passtext.UseSystemPasswordChar = true;
                showPasswordBtn.Text = "Показать";
            }
        }

        private void confirmShowPasswordBtn_Click(object sender, EventArgs e)
        {
            if (confirmPasstext.UseSystemPasswordChar)
            {
                confirmPasstext.UseSystemPasswordChar = false;
                confirmShowPasswordBtn.Text = "Скрыть";
            }
            else
            {
                confirmPasstext.UseSystemPasswordChar = true;
                confirmShowPasswordBtn.Text = "Показать";
            }
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (animationStep < animationSteps)
            {
                UpdateButtonAnimation();
                animationStep++;
            }
            else
            {
                animationTimer.Stop();
                animationStep = 0;
            }
        }

        private void UpdateButtonAnimation()
        {
            float progress = (float)animationStep / animationSteps;
            logBtn.BackColor = Color.FromArgb(
                (int)(originalColor.R + (255 - originalColor.R) * progress),
                (int)(originalColor.G + (255 - originalColor.G) * progress),
                (int)(originalColor.B + (255 - originalColor.B) * progress)
            );

            int newWidth = logBtn.Width + (int)(1 * Math.Sin(progress * Math.PI));
            int newHeight = logBtn.Height + (int)(1 * Math.Sin(progress * Math.PI));
            logBtn.Size = new Size(newWidth, newHeight);
            logBtn.FlatAppearance.BorderSize = (int)(3 * progress);
            logBtn.BackColor = Color.FromArgb(
                (int)(255 - (255 * progress)),
                logBtn.BackColor.R,
                logBtn.BackColor.G,
                logBtn.BackColor.B
            );
        }

        private async void logBtn_Click(object sender, EventArgs e)
        {
            string Login = logtext.Text;
            string Password = passtext.Text;

            if (!IsValidLogin(Login))
            {
                ShowError("Логин может содержать только буквы и цифры и должен быть от 3 до 20 символов.", logBtn);
                return;
            }

            if (!IsValidPassword(Password))
            {
                ShowError("Пароль может содержать только буквы и цифры и должен быть от 3 до 20 символов.", logBtn);
                return;
            }

            OpenConnection();
            loadingProgressBar.Visible = true;

            string encryptedPassword = Encrypt(Password);

            using (var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Users WHERE Login = @Login AND Password = @Password", DB))
            {
                cmd.Parameters.AddWithValue("@Login", Login);
                cmd.Parameters.AddWithValue("@Password", encryptedPassword);

                int count = Convert.ToInt32(await cmd.ExecuteScalarAsync());

                if (count > 0)
                {
                    ShowSuccess(logBtn);
                    MessageBox.Show("Вход успешен!");
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    ShowError("Неверный логин или пароль.", logBtn);
                }
            }
            animationTimer.Start();
            CloseConnection();
            loadingProgressBar.Visible = false;
        }

        private async void regBtn_Click(object sender, EventArgs e)
        {
            string Login = logtext.Text;
            string Password = passtext.Text;
            string ConfirmPassword = confirmPasstext.Text;

            if (!IsValidLogin(Login))
            {
                ShowError("Логин может содержать только буквы и цифры и должен быть от 3 до 20 символов.", regBtn);
                return;
            }

            if (!IsValidPassword(Password))
            {
                ShowError("Пароль может содержать только буквы и цифры и должен быть от 3 до 20 символов.", regBtn);
                return;
            }

            if (Password != ConfirmPassword)
            {
                ShowError("Пароли не совпадают. Пожалуйста, попробуйте снова.", regBtn);
                return;
            }

            OpenConnection();
            loadingProgressBar.Visible = true;

            string encryptedPassword = Encrypt(Password);

            using (var cmd = new SQLiteCommand("INSERT INTO Users (Login, Password) VALUES (@Login, @Password)", DB))
            {
                cmd.Parameters.AddWithValue("@Login", Login);
                cmd.Parameters.AddWithValue("@Password", encryptedPassword);

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    ShowSuccess(regBtn);
                    MessageBox.Show("Регистрация успешна!");
                }
                catch (Exception ex)
                {
                    ShowError($"Регистрация не удалась: {ex.Message}", regBtn);
                }
            }

            CloseConnection();
            loadingProgressBar.Visible = false;
        }

        private bool IsValidLogin(string login)
        {
            return Regex.IsMatch(login, @"^[a-zA-Z0-9]{3,20}$");
        }

        private bool IsValidPassword(string password)
        {
            return Regex.IsMatch(password, @"^[a-zA-Z0-9]{3,20}$");
        }

        private void ShowSuccess(Button button)
        {
            button.BackColor = Color.LightGreen;
            ResetButtonColor(button);
        }

        private void ShowError(string message, Button button)
        {
            MessageBox.Show(message);
            button.BackColor = Color.LightCoral;
            ResetButtonColor(button);
        }

        private async void ResetButtonColor(Button button)
        {
            await Task.Delay(1000);
            button.BackColor = originalColor;
        }

        private void OpenConnection()
        {
            if (DB.State == ConnectionState.Closed)
            {
                DB.Open();
            }
        }

        private void CloseConnection()
        {
            if (DB.State == ConnectionState.Open)
            {
                DB.Close();
            }
        }

        private const string EncryptionKey = "mySecretKey";

        private string Encrypt(string plainText)
        {
            char[] key = EncryptionKey.ToCharArray();
            char[] text = plainText.ToCharArray();
            char[] result = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                result[i] = (char)(text[i] ^ key[i % key.Length]);
            }

            return new string(result);
        }
    }
}
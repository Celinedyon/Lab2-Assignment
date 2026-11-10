using System.Diagnostics;

namespace biscyle_business
{
    public class LoginSelectionForm : Form
    {
        private readonly TextBox txtUsername = new();
        private readonly TextBox txtPassword = new();
        private readonly Label lblError = new();

        public LoginSelectionForm()
        {
            Text = "Secure Access";
            Size = new Size(500, 420);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            BackColor = Color.FromArgb(245, 247, 250);

            var panel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(245, 247, 250),
                Padding = new Padding(30)
            };

            var lblTitle = new Label
            {
                Text = "Welcome Back",
                Font = new Font("Segoe UI", 20F, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 90, 160),
                AutoSize = false,
                Height = 40,
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter
            };

            var lblSubtitle = new Label
            {
                Text = "Sign in to continue",
                Font = new Font("Segoe UI", 10F, FontStyle.Italic),
                ForeColor = Color.FromArgb(100, 110, 130),
                AutoSize = false,
                Height = 24,
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter
            };

            var lblUser = new Label
            {
                Text = "Username",
                AutoSize = true,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Margin = new Padding(0, 20, 0, 5)
            };

            txtUsername.PlaceholderText = "Enter username";
            txtUsername.Font = new Font("Segoe UI", 10.5F);
            txtUsername.Size = new Size(360, 32);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;

            var lblPass = new Label
            {
                Text = "Password",
                AutoSize = true,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Margin = new Padding(0, 10, 0, 5)
            };

            txtPassword.PlaceholderText = "Enter password";
            txtPassword.Font = new Font("Segoe UI", 10.5F);
            txtPassword.Size = new Size(360, 32);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.UseSystemPasswordChar = true;

            lblError.ForeColor = Color.DarkRed;
            lblError.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblError.AutoSize = true;
            lblError.Text = "";
            lblError.MinimumSize = new Size(300, 20);

            var lblHint = new Label
            {
                Text = "Demo account: admin / 1234",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.FromArgb(80, 90, 110),
                AutoSize = true,
                Margin = new Padding(0, 8, 0, 0)
            };

            var btnLogin = new Button
            {
                Text = "Login",
                Size = new Size(160, 42),
                BackColor = Color.FromArgb(0, 140, 186),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Click += BtnLogin_Click;

            var flow = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = false,
                Padding = new Padding(0, 10, 0, 0),
                BackColor = Color.FromArgb(245, 247, 250)
            };

            flow.Controls.Add(lblUser);
            flow.Controls.Add(txtUsername);
            flow.Controls.Add(lblPass);
            flow.Controls.Add(txtPassword);
            flow.Controls.Add(lblError);
            flow.Controls.Add(lblHint);
            flow.Controls.Add(btnLogin);

            panel.Controls.Add(lblSubtitle);
            panel.Controls.Add(lblTitle);
            panel.Controls.Add(flow);
            Controls.Add(panel);

            AcceptButton = btnLogin;
        }

        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "admin" && txtPassword.Text == "1234")
            {
                ShowAppSelector();
                return;
            }

            lblError.Text = "Invalid username or password.";
        }

        private void ShowAppSelector()
        {
            Controls.Clear();
            Text = "Choose Application";
            Size = new Size(500, 360);
            BackColor = Color.FromArgb(245, 247, 250);

            var panel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(245, 247, 250),
                Padding = new Padding(30)
            };

            var lblWelcome = new Label
            {
                Text = "Choose an application",
                Font = new Font("Segoe UI", 20F, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 90, 160),
                AutoSize = false,
                Height = 42,
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter
            };

            var lblInfo = new Label
            {
                Text = "Select the tool you want to open",
                Font = new Font("Segoe UI", 10F, FontStyle.Italic),
                ForeColor = Color.FromArgb(100, 110, 130),
                AutoSize = false,
                Height = 30,
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter
            };

            var btnBicycle = new Button
            {
                Text = "Bicycle Business",
                Size = new Size(300, 54),
                Anchor = AnchorStyles.None,
                BackColor = Color.FromArgb(16, 123, 255),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnBicycle.FlatAppearance.BorderSize = 0;
            btnBicycle.Click += (_, _) => OpenBicycleApp();

            var btnMushroom = new Button
            {
                Text = "Mushroom Type",
                Size = new Size(300, 54),
                Anchor = AnchorStyles.None,
                BackColor = Color.FromArgb(34, 139, 34),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnMushroom.FlatAppearance.BorderSize = 0;
            btnMushroom.Click += (_, _) => OpenMushroomApp();

            var flow = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = false,
                Padding = new Padding(0, 15, 0, 0),
                BackColor = Color.FromArgb(245, 247, 250),
                BorderStyle = BorderStyle.None
            };

            flow.Controls.Add(btnBicycle);
            flow.Controls.Add(btnMushroom);

            panel.Controls.Add(lblInfo);
            panel.Controls.Add(lblWelcome);
            panel.Controls.Add(flow);
            Controls.Add(panel);
        }

        private void OpenBicycleApp()
        {
            Hide();

            using var bicycleForm = new Form1();
            bicycleForm.ShowDialog();

            Show();
            WindowState = FormWindowState.Normal;
        }

        private void OpenMushroomApp()
        {
            var mushroomExe = GetMushroomExecutablePath();

            if (string.IsNullOrWhiteSpace(mushroomExe) || !File.Exists(mushroomExe))
            {
                MessageBox.Show("Mushroom app was not found. Please build the project first.", "Missing App");
                return;
            }

            Hide();
            Process.Start(new ProcessStartInfo
            {
                FileName = mushroomExe,
                UseShellExecute = true
            });

            Show();
            WindowState = FormWindowState.Normal;
        }

        private static string? GetMushroomExecutablePath()
        {
            var rootFolder = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", ".."));
            var candidate = Path.Combine(rootFolder, "Mushroom-type", "Mushuroom-type", "bin", "Debug", "net8.0-windows", "Mushuroom-type.exe");

            return File.Exists(candidate) ? candidate : null;
        }
    }
}

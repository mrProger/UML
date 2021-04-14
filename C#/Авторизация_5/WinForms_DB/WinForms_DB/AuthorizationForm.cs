using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_DB
{
    public partial class AuthorizationForm : Form
    {
        Point lastPoint;

        public AuthorizationForm()
        {
            InitializeComponent();

            LoginInputBox.AutoSize = false;
            LoginInputBox.Size = new Size(LoginInputBox.Size.Width, 64);
            PasswordInputBox.AutoSize = false;
            PasswordInputBox.Size = new Size(PasswordInputBox.Size.Width, 64);

            ExitButton.MouseEnter += ExitButtonEnter;
            ExitButton.MouseLeave += ExitButtonLeave;
            
            BodyPanel.MouseMove += BodyPanelMove;
            BodyPanel.MouseDown += BodyPanelMouseDown;

            BackButton.MouseEnter += BackButtonEnter;
            BackButton.MouseLeave += BackButtonLeave;
        }

        private void ExitButtonClick(object sender, EventArgs e) => Close();
        private void ExitButtonEnter(object sender, EventArgs e) => ExitButton.ForeColor = Color.Blue;
        private void ExitButtonLeave(object sender, EventArgs e) => ExitButton.ForeColor = Color.Black;

        private void BodyPanelMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }
        private void BodyPanelMouseDown(object sender, MouseEventArgs e) => lastPoint = new Point(e.X, e.Y);

        private void BackButtonClick(object sender, EventArgs e) 
        {
            new MainForm().Show();
            Hide();
        }
        private void BackButtonEnter(object sender, EventArgs e) => BackButton.ForeColor = Color.Blue;
        private void BackButtonLeave(object sender, EventArgs e) => BackButton.ForeColor = Color.Black;
    }
}

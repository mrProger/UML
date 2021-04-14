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
    public partial class MainForm : Form
    {
        Point lastPoint;

        public MainForm()
        {
            InitializeComponent();

            ExitButton.MouseEnter += ExitButtonEnter;
            ExitButton.MouseLeave += ExitButtonLeave;

            BodyPanel.MouseDown += BodyPanelMouseDown;
            BodyPanel.MouseMove += BodyPanelMove;
        }

        private void ExitButtonClick(object sender, EventArgs e) => Close();
        private void ExitButtonEnter(object sender, EventArgs e) => ExitButton.ForeColor = Color.Blue;
        private void ExitButtonLeave(object sender, EventArgs e) => ExitButton.ForeColor = Color.Black;

        private void AuthorizationButtonClick(object sender, EventArgs e) 
        {
            new AuthorizationForm().Show();
            Hide();
        }

        private void BodyPanelMouseDown(object sender, MouseEventArgs e) => lastPoint = new Point(e.X, e.Y);
        private void BodyPanelMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void RegistrationButtonClick(object sender, EventArgs e) 
        {
            new RegistrationForm().Show();
            Hide();
        }
    }
}

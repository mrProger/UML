using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Хребтов_Упражнение2
{
    public partial class Form1 : Form
    {
        public Form1() { InitializeComponent(); }

        private void ExitButtonClick(object sender, EventArgs e) { Close(); }
        private void ExitButtonEnter(object sender, EventArgs e) { ExitButton.ForeColor = Color.Blue; }
        private void ExitButtonLeave(object sender, EventArgs e) { ExitButton.ForeColor = Color.Black; }

        private void Form1_Load(object sender, EventArgs e)
        {
            GraphicsPath myPath = new GraphicsPath(); 
            //myPath.AddPolygon(new Point[] { new Point(0, 0), new Point(0, this.Height), new Point(this.Width, 0) }); 
            myPath.AddEllipse(0, 0, this.Width, this.Height);  
            Region myRegion = new Region(myPath); 
            this.Region = myRegion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}

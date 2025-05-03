using Nakov.TurtleGraphics;

namespace TurtleLybrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 200;
            Turtle.Forward(100);
            Turtle.Rotate(120);
            Turtle.Forward(100);
            Turtle.Rotate(120);
            Turtle.Forward(100);
            Turtle.Rotate(120);
        }
    }
}

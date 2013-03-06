using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HelloWorld.Business;

namespace HelloWorld.WindowsUI
{
    public partial class Form1 : Form
    {
        
        private readonly MessageGenerator _generator;

        public Form1()
            : this(new MessageGenerator())
        {
            InitializeComponent();
        }

        public Form1(MessageGenerator generator)
        {
            _generator = generator;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(_generator.GetGreeting());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var generator = new MessageGenerator();
            MessageBox.Show(generator.GetGreeting());
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

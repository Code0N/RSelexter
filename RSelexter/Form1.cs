using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSelexter
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            itemsTextBox.Clear();
            resultLabel.Text = "Здесь будет случайно выбранная строка";
        }

        private void rselectButton_Click(object sender, EventArgs e)
        {

        }
    }
}

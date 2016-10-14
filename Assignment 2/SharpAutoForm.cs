using Assignment_2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class SharpAutoForm : Form
    {
        public SharpAutoForm()
        {
            InitializeComponent();
        }

        private void ArialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font font = new Font("Arial", 12.0f);

            AmountDueTextBox.Font = font;
            BasePriceTextBox.Font = font;
        }

        private void comicSansToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Font font = new Font("Comic Sans", 12.0f);

            AmountDueTextBox.Font = font;
            BasePriceTextBox.Font = font;
        }

        private void ColoursListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string imageString = Regex.Replace(ColoursListBox.Text, @"\s+", "");
            CarPictureBox.Image = (Image)Resources.ResourceManager.GetObject(imageString);
        }

        private void LucidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font font = new Font("Helvetica", 12.0f);

            AmountDueTextBox.Font = font;
            BasePriceTextBox.Font = font;
        }

        private void lucidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Font font = new Font("Lucida", 12.0f);

            AmountDueTextBox.Font = font;
            BasePriceTextBox.Font = font;
        }

        private void TimesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font font = new Font("Times New Roman", 12.0f);

            AmountDueTextBox.Font = font;
            BasePriceTextBox.Font = font;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Program will calculate how much a Toyota 86 will cost", "About This Program", MessageBoxButtons.OK);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

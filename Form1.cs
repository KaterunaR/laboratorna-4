using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_lab4
{
    public partial class Form1 : Form
    {
        private Wolf wolf;
        public Form1()
        {
            InitializeComponent();
            wolf = new Wolf(40, 2, 43, "Grey Wolf", "Forest");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Wolf Information:\n\n" +
                           $"Weight: {wolf.Weight} kg\n" +
                           $"Age: {wolf.Age} years\n" +
                           $"Daily Maintenance Cost: {wolf.DailyMaintenanceCost}$\n" +
                           $"Breed: {wolf.Breed}\n" +
                           $"Natural Habitat: {wolf.NaturalHabitat}",
                           "Wolf Info",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
        }
    }
}

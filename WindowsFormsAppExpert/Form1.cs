using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppExpert
{
    public partial class Form1 : Form
    {
        /*
        01  Молоко      
        02  Картофель
        03  Масло
        04  Яйца
        05  Мясо
        06  Мука        
        07  Лук
        08  Морковь
        09  Капуста
        10  Вода
        */
        public Dictionary<int, string> Dish; 

        // Add some elements to the dictionary. There are no
        // duplicate keys, but some of the values are duplicates.
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 0;
            foreach (int listBoxItem in listBox1.SelectedIndices)
            {
                id |= (1 << (listBoxItem));
            }
            
            try
            {
                label1.Text = id.ToString() + " " + Dish[id]; 
            }
            catch (KeyNotFoundException)
            {
                label1.Text = id.ToString() + " " + "Ничья";
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dish = new Dictionary<int, string>();
            Dish.Add(3, "Победит камень");
            Dish.Add(6, "Победят ножницы");
            Dish.Add(5, "Победит бумага");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

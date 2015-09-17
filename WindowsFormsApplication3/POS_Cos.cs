using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class POS_Cos : Form
    {
        private List<Meal> mealList = new List<Meal>();

        public POS_Cos()
        {
            InitializeComponent();
            initialize();
        }

        private void prepage_Click(object sender, EventArgs e)
        {
            npage.Enabled = true;
            prepage.Enabled = false;
            pgchanger(1, true);
            pgchanger(2, false);
        }

        private void npage_Click(object sender, EventArgs e)
        {
            prepage.Enabled = true;
            npage.Enabled = false;
            pgchanger(2, true);
            pgchanger(1, false);
        }

        private void mealbuttons_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            Meal m = mealList.Find(x => x.b == b);
            MessageBox.Show(m.name);
        }

        private void pgchanger(int pgnum,bool op)
        {
            List<Meal> result = mealList.FindAll(delegate(Meal item){return item.pg == pgnum;});
            foreach (Meal i in result)
            {
                i.b.Visible = op;
            }
        }

        private void initialize()
        {
            mealList.Add(new Meal() { name = "Big Mac", price = 39, b = button1, pg = 1 });
            mealList.Add(new Meal() { name = "4 Oz Beef Burger", price = 85, b = button2, pg = 1 });
            mealList.Add(new Meal() { name = "Double 4 Oz Beef Burger", price = 115, b = button3, pg = 1 });
            mealList.Add(new Meal() { name = "Bacon Beef Burger", price = 99, b = button4, pg = 1 });
            mealList.Add(new Meal() { name = "6 pcs Chicken Nugget", price = 69, b = button5, pg = 1 });
            mealList.Add(new Meal() { name = "9 pcs Chicken Nugget", price = 95, b = button6, pg = 1 });
            mealList.Add(new Meal() { name = "Fillet-O-Fish", price = 75, b = button7, pg = 1 });
            mealList.Add(new Meal() { name = "Pancake", price = 52, b = button8, pg = 1 });
            mealList.Add(new Meal() { name = "Pancake w/ Pork", price = 57, b = button9, pg = 1 });
            mealList.Add(new Meal() { name = "Big Breakfast", price = 95, b = button10, pg = 2 });
            mealList.Add(new Meal() { name = "McFurry", price = 49, b = button11, pg = 2 });
            mealList.Add(new Meal() { name = "Pinapple Pie", price = 28, b = button12, pg = 2 });
            mealList.Add(new Meal() { name = "Apple Pie", price = 28, b = button13, pg = 2 });
            mealList.Add(new Meal() { name = "Potato Chips(S)", price = 25, b = button14, pg = 2 });
            mealList.Add(new Meal() { name = "Potato Chips(L)", price = 49, b = button15, pg = 2 });

            foreach(Meal item in mealList){
                item.b.Text = item.name + "\n" + item.price + "NTD";
                item.b.Click += mealbuttons_Click;
            }
        }
    }

    public class Meal
    {
        public Button b;
        public string name;
        public int price;
        public int pg;
    }
}

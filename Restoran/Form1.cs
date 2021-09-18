using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox3.Text = 0.ToString() + "р";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
      
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
               
                    object item = listBox1.SelectedItem;
                    if (item != null)
                    {
                        char ind = item.ToString()[0];
                        string partSumm = ind.ToString();
                        int i = 1;
                        while (ind != 'р')
                        {
                            ind = item.ToString()[i];
                            partSumm = partSumm + ind.ToString();
                            i++;
                        }
                        partSumm = partSumm.Replace("р", string.Empty);
                        textBox3.Text = textBox3.Text.Replace("р", string.Empty);
                        textBox3.Text = (int.Parse(textBox3.Text) + int.Parse(partSumm)).ToString() + "р";

                        listBox2.Items.Add(item);
                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                object item = listBox2.SelectedItem;
                if (item != null)
                {
                    char ind = item.ToString()[0];
                    string partSumm = ind.ToString();
                    int i = 1;
                    while (ind != 'р')
                    {
                        ind = item.ToString()[i];
                        partSumm = partSumm + ind.ToString();
                        i++;
                    }
                    partSumm = partSumm.Replace("р", string.Empty);
                    textBox3.Text = textBox3.Text.Replace("р", string.Empty);
                    textBox3.Text = (int.Parse(textBox3.Text) - int.Parse(partSumm)).ToString() + "р";

                    listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number = listBox2.Items.Count;
            if (number > 1) 
            {
                DialogResult result = MessageBox.Show("Все заказали, вы уверены?",
    "Ресторан «Студент»", MessageBoxButtons.YesNo, MessageBoxIcon.Information,
    MessageBoxDefaultButton.Button3, MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes) { MessageBox.Show("С богом! Cумма заказа =" + textBox3.Text, "Ресторан «Студент»",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

                else
                {
                    MessageBox.Show("Давайте еще разок!", "Ресторан «Студент»",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
            }
            else
            {
                MessageBox.Show("Ваш заказ пуст!", "Ресторан «Студент»",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

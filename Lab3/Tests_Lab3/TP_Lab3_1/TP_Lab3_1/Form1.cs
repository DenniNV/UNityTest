using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TP_Lab3_1
{
    public partial class Form1 : Form
    {
        #region Constructors
        public Form1()
        {
            InitializeComponent();
        }

        #endregion


        #region Functions

        public void AddNewPath(string path)
        {
            string pattern = @"^\w{1}:(\\\w+)*$";
            if (Regex.IsMatch(path, pattern)) listBox1.Items.Add(path);
            else listBox2.Items.Add(path);
        }


        #endregion



        #region Events

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty) AddNewPath(textBox1.Text);
            else MessageBox.Show("Текстовое поле пустое!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedItem != null)
            {
                textBox1.Text = listBox2.SelectedItem.ToString();
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            else MessageBox.Show("Вы не выбрали строку для повторной проверки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion
    }
}

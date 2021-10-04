using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizPRG282
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
         private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AppContext.BaseDirectory);
            List<string[]> l = new List<string[]>();
            string txt;
           using (StreamReader reader = new StreamReader(AppContext.BaseDirectory + @"Test.txt"))
            {
                while ( (txt=reader.ReadLine())!=null)
                {
                    
                    l.Add(txt.Split(','));
                    
                }
                
            }
            foreach (var line in l)
            {
                string temp="";
                foreach (var info in line)
                {
                    temp += info;
                }
                listBox1.Items.Add(temp);
            }
        }
    }
}

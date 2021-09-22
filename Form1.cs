using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FordFulkerson
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        List<List<int>> graph = new List<List<int>>();   
        List<int> row = new List<int>();
        TextBox[] Textbox1 = new System.Windows.Forms.TextBox[100];
        
        public void button2_Click(object sender, EventArgs e)
        {
            int V = Convert.ToInt32(textBox1.Text);
            int x1 = 250;
            int y = 110;
            int lbl = 0;
               
           
            for (int i = 0; i < V; i++)
            {
                for (int j = 0; j < V; j++)
                {
                    Textbox1[lbl] = new System.Windows.Forms.TextBox
                    {
                        
                        Size = new Size(40, 20),
                        Location = new Point(x1, y)
                    };
                    Controls.Add(Textbox1[lbl]);
                    x1 += 60;
                    lbl++;
                }
                
                x1 = 250;
                y += 25;
            }
            int lbl1 = 0;
            int x2 = 265;
            int y1 = 85;
            string [] Text1 = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"};
            var Label1 = new System.Windows.Forms.Label[V];
            for (int j = 0; j < V; j++)
            {
                Label1[lbl1] = new System.Windows.Forms.Label
                {
                    Text = Text1[j],
                    Size = new Size(40, 20),
                    Location = new Point(x2, y1)
                };
                Controls.Add(Label1[lbl1]);
                x2 += 60;
                lbl1++;               
            }
            lbl1 = 0;
            x2 = 220;
            y1 = 115;
            for (int j = 0; j < V; j++)
            {
                Label1[lbl1] = new System.Windows.Forms.Label
                {
                    Text = Text1[j],
                    Size = new Size(40, 20),
                    Location = new Point(x2, y1)
                };
                Controls.Add(Label1[lbl1]);
                y1 += 25;
                lbl1++;
            }
        }        
        public void button1_Click(object sender, EventArgs e)
        {
            MaxFlow m = new MaxFlow();
            int V = Convert.ToInt32(textBox1.Text);
            int lbl = 0;
            for (int i = 0; i < V; i++)
            {
                row = new List<int>();
                for (int j = 0; j < V; j++)
                {
                    row.Add(Convert.ToInt32(Textbox1[lbl].Text));
                    lbl++;
                }
                graph.Add(row);                              
            }
            label2.Text = m.fordFulkerson(graph, 0, V-1, V).ToString();
                        

        }

    }
   
}

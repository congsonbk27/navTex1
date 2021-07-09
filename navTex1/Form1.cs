using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace navTex1
{
    public class dataStruct
    {
        public 
            int id;
        string ms_code;
        string ms_message;
        int ts_kHZ;
    
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            main();
        }



        public void main()
        {
            txtDirection.Text = "D:/word_An/navtex.txt";
            StreamReader read = new StreamReader(txtDirection.Text.ToString());

            string dataRead = read.ReadToEnd();

            txtMess.Text = dataRead;

            read.Close();
        }

        public void decoderText(string data)
        {
            dataStruct valueReturn;
            /*valueReturn.id = 5;*/

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog open;
            open = new OpenFileDialog();
            if(open.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(open.FileName);
                txtMess.Text = read.ReadToEnd();
                txtDirection.Text = open.FileName.ToString();
                read.Close();
            }
            
        }
    }
}

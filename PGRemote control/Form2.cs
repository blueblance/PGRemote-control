using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PGRemote_control
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string eccdata = hex2bin(textbox_packethead.Text) + hex2bin(textbox_data1.Text) + hex2bin(textbox_data2.Text);
            bool[] eccaray = new bool[24];
            for(int i = 0 ; i<24 ; i++)
            {
                if (eccdata[i] == '0')
                {
                    eccaray[i] = false;
                }
                else
                    eccaray[i] = true;
            }
            string p0 = bool2string(eccaray[0] ^ eccaray[1] ^ eccaray[2] ^ eccaray[4] ^ eccaray[5] ^ eccaray[7] ^ eccaray[10] ^ eccaray[11] ^ eccaray[13] ^ eccaray[16] ^ eccaray[20] ^ eccaray[21] ^ eccaray[22] ^ eccaray[23]);
            string p1 = bool2string(eccaray[0] ^ eccaray[1] ^eccaray[3] ^eccaray[4] ^eccaray[6] ^eccaray[8] ^eccaray[10] ^eccaray[12] ^eccaray[14] ^eccaray[17] ^eccaray[20] ^eccaray[21] ^eccaray[22] ^eccaray[23]);
            string p2 = bool2string(eccaray[0] ^eccaray[2] ^eccaray[3] ^eccaray[5] ^eccaray[6] ^eccaray[9] ^eccaray[11] ^eccaray[12] ^eccaray[15] ^eccaray[18] ^eccaray[20] ^eccaray[21] ^eccaray[22] );
            string p3 = bool2string(eccaray[1] ^eccaray[2] ^eccaray[3] ^eccaray[7] ^eccaray[8] ^eccaray[9] ^eccaray[13] ^eccaray[14] ^eccaray[15] ^eccaray[19] ^eccaray[20] ^eccaray[21] ^eccaray[23] );
            string p4 = bool2string(eccaray[4] ^eccaray[5] ^eccaray[6] ^eccaray[7] ^eccaray[8] ^eccaray[9] ^eccaray[16] ^eccaray[17] ^eccaray[18] ^eccaray[19] ^eccaray[20] ^eccaray[22] ^eccaray[23] );
            string p5 = bool2string(eccaray[10] ^ eccaray[11] ^ eccaray[12] ^ eccaray[13] ^ eccaray[14] ^ eccaray[15] ^ eccaray[16] ^ eccaray[17] ^ eccaray[18] ^ eccaray[19] ^ eccaray[21] ^ eccaray[22] ^ eccaray[23]);
            string p6 = "0";
            string p7 = "0";
            string secc = p0 + p1 + p2 + p3 + p4 + p5 + p6 + p7;

            textbox_ecc.Text = b2hex(secc);
            

        }
        private string hex2bin (string hexvalue)
        {
            //textbox_packethead.Text = Convert.ToInt32(textbox_packethead.Text, 16).ToString();
            string b = hexvalue;
            string d = null;
            //string e = null;
            for (int ctr = 0; ctr <= b.Length - 1; ctr++)
            {
                string a = b[ctr].ToString();
                string c = Convert.ToString(Convert.ToInt32(a, 16), 2).PadLeft(4, '0');
                for (int i = 0; i <= c.Length - 1; i++)
                {
                    d = c[i].ToString() + d;
                }
                //e = d + e;
                
            }
            return d;
        }
        private string bool2string (bool b)
        {
            if (b == true)
                return "1";
            else
                return "0";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private string b2hex (string binarystring)
        {
            double dec = 0;
            int a = 0;
            int b = 0;
            double dec2 = 0;
            for (int i = 0 ; i<= 3 ; i++)
            {
                    dec = Math.Pow(2, i) * Convert.ToInt32(binarystring[i].ToString());
                    a = a + Convert.ToInt32(dec);
            }
          
            for (int i = 4; i <=7 ; i++)
            {
                dec2 = Math.Pow(2, i-4) * Convert.ToInt32(binarystring[i].ToString());
                b = b + Convert.ToInt32(dec2);
            }
            string strHex = String.Format("{0:X}", b) + String.Format("{0:X}", a);
            return strHex;
        }

        
             
    }
}

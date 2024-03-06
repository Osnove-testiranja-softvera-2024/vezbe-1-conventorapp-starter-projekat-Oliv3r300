using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS2023_ConventorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if(rdnMass.Checked)
            {

                
                double rezultatMase = int.Parse(txtUnos.Text) / 2.2046;

                txtRezultat.Text = rezultatMase.ToString();

            
            }

            else if (rdnLength.Checked)
            {

                
               


                double rezultatDuzine = int.Parse(txtUnos.Text) * 2.54;

                txtRezultat.Text = rezultatDuzine.ToString();
                
            }
        }

        private void rdnMass_CheckedChanged(object sender, EventArgs e)
        {
            txtRezultat.Text = "";
            txtUnos.Text = "";
            label1.Text = "pounds";
            label2.Text = "kg";
        }

        private void rdnLength_CheckedChanged(object sender, EventArgs e)
        {
            txtRezultat.Text = "";
            txtUnos.Text = "";
            label1.Text = "feet";
            label2.Text = "m"; 
        }
    }
    }


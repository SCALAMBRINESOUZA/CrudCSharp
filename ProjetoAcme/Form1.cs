﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAcme
{

    

    public partial class Form1 : Form
    {
        string sdi = "HELLO";
        string sbv = "DO YOU AGAIN";
        string nome = "";
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show(sdi);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(sbv);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            nome = textBox1.Text;
            MessageBox.Show(sdi + " " + sbv + " " + nome);
            string msi = sdi + " " + sbv + " " + nome;
            textBox3.Text = msi.ToString();

            


        }


        public override string ToString()
        {
            return sdi + " " + sbv + " " + " " + nome;
        }
    }
}

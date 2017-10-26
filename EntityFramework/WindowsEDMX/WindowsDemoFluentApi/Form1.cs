﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDemoFluentApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            using (FacturacionDB db = new FacturacionDB())
            {
                Factura newFactura = new Factura() {

                    Fecha = DateTime.Now
                };
                db.Facturas.Add(newFactura);
                db.SaveChanges();
            }
        }
    }
}

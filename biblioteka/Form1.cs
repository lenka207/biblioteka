using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace biblioteka
{
    public partial class Form1 : Form
    {
        public string sifra = "123";
        public string ime = "ja";
        public bool administrator = false;
        public Form1()
        {
            InitializeComponent();
            SetCustomCursor();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        private void SetCustomCursor1()
        {
            /*
            // Učitaj sliku kursora iz resursa
            Cursor customCursor;
            using (var stream = new System.IO.MemoryStream(Properties.Resources.sl6))
            {
                customCursor = new Cursor(stream);
            }

            // Postavi kursor za celu formu
            this.Cursor = customCursor;
            */
        }
        private void SetCustomCursor()
        {
            try
            {
                // Učitaj sliku kursora iz resursa
                using (var stream = new MemoryStream(Properties.Resources.images))
                {
                    Cursor customCursor = new Cursor(stream);
                    // Postavi kursor za celu formu
                    this.Cursor = customCursor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to set custom cursor: " + ex.Message);
            }
        }
        private void username2(object sender, EventArgs e)
        {
            string username = username1.Text;
        }
            
        private void password_TextChanged(object sender, EventArgs e)
        {
            string password = this.password1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username1.Text == ime)
            {
                if (password1.Text == sifra)
                {
                    administrator = true;
                    MessageBox.Show("Tacno");
                }
            }
            if (administrator == false)
            {
                MessageBox.Show("Netacno ime ili sifra");
            }
        }

        private void izlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

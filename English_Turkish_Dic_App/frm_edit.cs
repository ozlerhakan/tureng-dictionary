using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace English_Turkish_Dic_App
{
    public partial class frm_edit : Form
    {
        private string tur = "", eng = "";
        public delegate void SaveClick(string words, bool isTr, bool isEng, string oldword);
        public event SaveClick eventSaveClick;

        public frm_edit()
        {
            InitializeComponent();
        }

        public frm_edit(string txtTur, string txtEng, Point locationFrm)
        {
            tur = txtTur;
            eng = txtEng;
            this.Location = new Point(locationFrm.X + 35, locationFrm.Y + 50);
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string compareWord = "";
            bool isTr = false, isEng = false;
            if (string.Equals(tur, txtTur.Text) && string.Equals(eng, txtEng.Text))
                return;
            else if (string.Equals(tur, txtTur.Text) && !string.Equals(eng, txtEng.Text))
            { compareWord = txtEng.Text.Trim().ToLower(); isEng = true; }
            else if (!string.Equals(tur, txtTur.Text) && string.Equals(eng, txtEng.Text))
            { compareWord = txtTur.Text.Trim().ToLower(); isTr = true; }
            else
            { compareWord = txtEng.Text.Trim().ToLower() + ";" + txtTur.Text.Trim().ToLower(); isEng = true; isTr = true; }

            eventSaveClick.Invoke(compareWord, isTr, isEng, tur + ";" + eng);
            this.Dispose();
            btnEnter.Enabled = false;
        }

        private void frm_edit_Load(object sender, EventArgs e)
        {
            txtEng.Text = eng;
            txtTur.Text = tur;
        }

        private void txtEng_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = true;
            }
        }

        private void txtTur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = true;
            }
        }
    }
}

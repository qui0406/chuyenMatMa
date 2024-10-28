﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string nguon = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static char[] P = nguon.ToCharArray();
        public static string Mahoa(string s, int k)
        {
            int mahoa_local = 0;
            char[] vanban = s.ToCharArray();
            int l = vanban.Length;
            char[] tmp_text = new char[l];
            int[] tmp_local = new int[l];
            int j = 0;
            while (j < l)
            {
                for (int i = 0; i < P.Length; i++)
                {
                    if (P[i] == vanban[j])
                    {
                        tmp_local[j] = i;
                        mahoa_local = tmp_local[j] + k;
                        if (mahoa_local >= P.Length) mahoa_local = mahoa_local -
                        P.Length;
                        tmp_text[j] = P[mahoa_local];
                    }
                }
                j++;
            }
            return new string(tmp_text);
        }
        public static string GiaiMa(string s, int k)
        {
            int mahoa_local = 0;
            char[] vanban = s.ToCharArray();
            int l = vanban.Length;
            char[] tmp_text = new char[l];
            int[] tmp_local = new int[l];
            int j = 0;
            while (j < l)
            {
                for (int i = 0; i < P.Length; i++)
                {
                    if (P[i] == vanban[j])
                    {
                        tmp_local[j] = i;
                        mahoa_local = tmp_local[j] - k; if (mahoa_local < 0) mahoa_local = mahoa_local + P.Length;
                        tmp_text[j] = P[mahoa_local];
                    }
                }
                j++;
            }
            return new string(tmp_text);
        }

        private void btnChuyenCaesar_Click(object sender, EventArgs e)
        {
            if (txtCaesar.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập văn bản", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtCaesar.Focus();
                return;
            }
            txtMaCaesar.Text = Mahoa(txtCaesar.Text, int.Parse(cbxKeyCaesar.Text));
        }

        private void txtCaesar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaCaesar_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnDichCaesar_Click(object sender, EventArgs e)
        {
            if (txtMaCaesar.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập văn bản mã hóa",
                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaCaesar.Focus();
                return;
            }
            txtCaesar.Text = GiaiMa(txtMaCaesar.Text, int.Parse(cbxKeyCaesar.Text));
        }

        private void cbxKeyCaesar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vigenereToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vigenereToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }
    }
}

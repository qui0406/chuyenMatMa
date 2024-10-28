using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static string nguon = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static char[] P = nguon.ToCharArray();
        public static int[] taokhoa(string vao, int[] key)
        {
            char[] vanban = vao.ToCharArray();
            int l = vanban.Length;
            int[] plant = new int[l];
            int j = 0;
            for (int i = 0; i < l; i++)
            {
                if (j > key.Length - 1) j = 0;
                plant[i] = key[j];
                j++;
            }
            return plant;
        }
        public static int[] chuyenmakey(string s)//Tìm vị trí thứ tự của chữ cái
        {
            char[] vanban = s.ToCharArray();
            int l = vanban.Length;
            int[] tmp_local = new int[l];
            int j = 0;
            while (j < l)
            {
                for (int i = 0; i < P.Length; i++)
                {
                    if (P[i] == vanban[j])
                    {
                        tmp_local[j] = i;
                    }
                }
                j++;
            }
            return tmp_local;
        }
        public static string Mahoa(string s, int[] khoa)
        {
            char[] vanban = s.ToCharArray();
            int l = vanban.Length;
            int[] tmp_local = new int[l];
            char[] temp = new char[l];
            int maso;
            for (int j = 0; j < l; j++)
            {
                for (int i = 0; i < P.Length; i++)
                {
                    if (P[i] == vanban[j])
                    {
                        tmp_local[j] = i;
                        maso = (tmp_local[j] + khoa[j]) % P.Length;
                        temp[j] = P[maso];
                    }
                }
            }
            return new string(temp);
        }
        public static string Giaima(string s, int[] khoa)
        {
            char[] vanban = s.ToCharArray();
            int l = vanban.Length;
            int[] tmp_local = new int[l];
            char[] temp = new char[l];
            int maso;
            for (int j = 0; j < l; j++)
            {
                for (int i = 0; i < P.Length; i++)
                {
                    if (P[i] == vanban[j])
                    {
                        tmp_local[j] = i;
                        maso = ((tmp_local[j] + P.Length) - khoa[j]) % P.Length;
                        temp[j] = P[maso];
                    }
                }
            }
            return new string(temp);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnChuyenCaesar_Click(object sender, EventArgs e)
        {

        }

        private void BtnDichVinegere_Click(object sender, EventArgs e)
        {
            if (txtMaVigenere.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập văn bản mã hóa ",
                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVigenere.Focus();
                return;
            }
            if (txtKeyVegenere.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập văn bản khóa",
                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKeyVegenere.Focus();
                return;
            }
            int[] key =
            chuyenmakey(txtKeyVegenere.Text);
            int[] dongkhoa = taokhoa(txtMaVigenere.Text,
            key);// lập độ dài khóa bằng độ dài văn bản
            txtVigenere.Text =
           Giaima(txtMaVigenere.Text, dongkhoa);
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnDichVinegere_Click(object sender, EventArgs e)
        {
          
        }

        private void txtMaVegenere_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChuyenVigenere_Click(object sender, EventArgs e)
        {
            if (txtVigenere.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập văn bản ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVigenere.Focus();
                return;
            }
            if (txtKeyVegenere.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập văn bản khóa",
               "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKeyVegenere.Focus();
                return;
            }
            int[] key =
            chuyenmakey(txtKeyVegenere.Text);
            int[] dongkhoa = taokhoa(txtVigenere.Text,
            key);
            txtMaVigenere.Text = Mahoa(txtVigenere.Text,
            dongkhoa);
        }

        private void btnDichVigenere_Click(object sender, EventArgs e)
        {
            if (txtMaVigenere.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập văn bản mã hóa ",
                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVigenere.Focus();
                return;
            }
            if (txtKeyVegenere.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập văn bản khóa",
                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKeyVegenere.Focus();
                return;
            }
            int[] key =
           chuyenmakey(txtKeyVegenere.Text);
            int[] dongkhoa = taokhoa(txtMaVigenere.Text,
            key);// lập độ dài khóa bằng độ dài văn bản
            txtVigenere.Text =
            Giaima(txtMaVigenere.Text, dongkhoa);
        }
    }
}

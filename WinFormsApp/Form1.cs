using System.Collections.Immutable;
using System.Xml;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public List<int> Tippek = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblEredmenyek.Text = "";
            btnSorsol.Enabled = false;
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 5; j++)
                {
                    CheckBox box = new CheckBox();
                    box.Text = (i + 1 + j * 9).ToString();
                    box.Location = new Point(i * 40, j * 40);
                    box.AutoSize = true;
                    box.CheckedChanged += checkBox1_CheckedChanged;
                    panel.Controls.Add(box);
                }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var box = (CheckBox)sender;
            if (box.Checked)
            {
                Tippek.Add(Convert.ToInt32(box.Text));
                if (Tippek.Count() == 6)
                {
                    btnSorsol.Enabled = true;
                    Kapcsol(false);
                }
            }
            else
            {
                Tippek.Remove(Convert.ToInt32(box.Text));
                btnSorsol.Enabled = false;
                Kapcsol(true);
            }
            lblEredmenyek.Text = "Tippek: " + String.Join(",", Tippek.ToImmutableSortedSet());
        }
        private void Kapcsol(bool kapcs)
        {
            foreach (CheckBox item in panel.Controls)
            {
                if (!item.Checked)
                {
                    item.Enabled = kapcs;
                }
            }
        }

        private void btnSorsol_Click(object sender, EventArgs e)
        {
            HashSet<int>kihuzottSzamok=new HashSet<int>();
            Random rnd=new Random();
            do
            {
                kihuzottSzamok.Add(rnd.Next(1,46));
            } while (kihuzottSzamok.Count != 6);
            lblEredmenyek.Text = "Tippek: " + String.Join(", ", Tippek.ToImmutableSortedSet())+Environment.NewLine;
            lblEredmenyek.Text += "Kihúzott Számok: " + String.Join(", ", kihuzottSzamok.ToImmutableSortedSet()) + Environment.NewLine;
            lblEredmenyek.Text = "Eltaláltál: " + kihuzottSzamok.Intersect(Tippek).Count()+"- ("+ String.Join(", ", kihuzottSzamok.Intersect(Tippek).ToImmutableSortedSet())+")";
        }
    }
}

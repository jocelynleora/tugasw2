namespace tugasw2
{
    public partial class FormWarna : Form
    {
        public FormWarna()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonProses_Click(object sender, EventArgs e)
        {
            if (txtBoxInput.Text.Contains("ISI: "))
            {
                var Input = txtBoxInput.Text.Split(':');
                labelbwh.Text = Input[1];
            }
                if (txtBoxInput.Text == "HIDE")
                {
                    labelbwh.Visible = false;
                }
                else if (txtBoxInput.Text == "SHOWN")
                {
                    labelbwh.Visible = true;
                }
                else if (txtBoxInput.Text == "WARNA: DEFAULT")
                {
                    labelbwh.ForeColor = Color.Black;
                }
                else if (txtBoxInput.Text == "WARNA: MERAH")
                {
                    labelbwh.ForeColor = Color.Red;
                }
                else if (txtBoxInput.Text == "WARNA: BIRU")
                {
                    labelbwh.ForeColor = Color.Blue;
                }
                else if (txtBoxInput.Text == "WARNA: HIJAU")
                {
                    labelbwh.ForeColor = Color.Green;
                }
                else if (txtBoxInput.Text == "BESARKAN")
            {
                var larger = labelbwh.Font.Size;
                larger++;
                labelbwh.Font = new Font(labelbwh.Font.FontFamily, larger);
            }
            else if (txtBoxInput.Text == "KECILKAN")
            {
                var smaller = labelbwh.Font.Size;
                smaller--;
                labelbwh.Font = new Font(labelbwh.Font.FontFamily, smaller);
            }
        }
        }
    }


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolokvezba
{
    public partial class Addpaper : Form
    {
        public Paper NewPaper { get; set; }
        ErrorProvider errorProvider = new ErrorProvider();

        private void Addpaper_Load(object sender, EventArgs e)
        {

        }
        public Addpaper()
        {
            InitializeComponent();
        }
        private bool ValidateInput()
        {
            if (Titletb.Text.Length == 0)
            {
                errorProvider.SetError(Titletb, "Must contain title");
                return false;
            }
            else errorProvider.SetError(Titletb, "");

            if (Author1tb.Text.Length == 0)
            {
                errorProvider.SetError(Author1tb, "Must have at least 1 author");
                return false;
            }
            else errorProvider.SetError(Author1tb, "");

            if (Keywordtb.Text.Length == 0 || Keywordtb.Text.Contains(' '))
            {
                errorProvider.SetError(Keywordtb, "Keywords must be seperated with comma");
                return false;
            }
            else errorProvider.SetError(Keywordtb, "");
            return true;
        }
        private void Okbtn_Click(object sender, EventArgs e)
        {

            if (ValidateInput())
            {
                List<String> authors = new List<string>();
                string[] keywords = Keywordtb.Text.Split(',');
                authors.Add(Author1tb.Text);
                if (!string.IsNullOrWhiteSpace(Author2tb.Text))
                    authors.Add(Author2tb.Text);
                if (!string.IsNullOrWhiteSpace(Author3tb.Text))
                    authors.Add(Author3tb.Text);
                if (!string.IsNullOrWhiteSpace(Author4tb.Text))
                    authors.Add(Author4tb.Text);
                if (!string.IsNullOrWhiteSpace(Author5tb.Text))
                    authors.Add(Author5tb.Text);
                NewPaper = new Paper(Titletb.Text, authors.ToArray(), keywords);
                this.DialogResult = DialogResult.OK;
                return;
            }

        }

        private void Titletb_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void Keywordtb_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void Author1tb_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}


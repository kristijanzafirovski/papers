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
    public partial class Form1 : Form
    {

        private Dictionary<string, int> authors = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();
            
        }
        

        private void Addpaperbtn_Click(object sender, EventArgs e)
        {
            Addpaper form = new Addpaper();
            if(form.ShowDialog() == DialogResult.OK)
            {
                Allpaperslb.Items.Add(form.NewPaper);
                RefreshLb(form.NewPaper, true);
            }

        }
        private void RefreshLb(Paper paper,bool increment)
        {
            List<String> list = new List<String>(paper.authors);
            //adding or deleting
            foreach (var item in list)
            {
                if (authors.ContainsKey(item) && increment)
                {
                    authors[item]++;
                }
                else if (!authors.ContainsKey(item) && increment)
                {
                    authors.Add(item, 1);
                }
                else if (authors.ContainsKey(item) && !increment)
                {
                    if (authors[item] > 1)
                    {
                        authors[item]--;
                    }
                    else authors.Remove(item);
                }
            }
            //update box
            Authorstb.Items.Clear();
            foreach (var item in authors)
            {

                string toAdd = item.Key + " - " + item.Value;
                Authorstb.Items.Add(toAdd);
            }
        }

        private void Deletepaperbtn_Click(object sender, EventArgs e)
        {
            if(Allpaperslb.SelectedItems.Count > 0)
            {
                RefreshLb((Paper)Allpaperslb.SelectedItem, false);
                Allpaperslb.Items.Remove(Allpaperslb.SelectedItem);
            }
        }
    }
}

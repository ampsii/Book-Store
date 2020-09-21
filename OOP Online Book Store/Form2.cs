using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Online_Book_Store
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpbxBook.Visible = true;
            grpbxMagazine.Visible = false;
            grpbxMusicCD.Visible = false;
            listView1.Visible = false;
            grpbxDelete.Visible = false;
            grpbxBook.Location = new Point(12, 24);
            this.Size = new Size(352, 317);
        }

        private void musicCDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpbxBook.Visible = false;
            grpbxMagazine.Visible = false;
            grpbxMusicCD.Visible = true;
            listView1.Visible = false;
            grpbxDelete.Visible = false;
            grpbxMusicCD.Location = new Point(12, 24);
            this.Size = new Size(316, 263);
        }

        private void magazineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpbxBook.Visible = false;
            grpbxMagazine.Visible = true;
            grpbxMusicCD.Visible = false;
            listView1.Visible = false;
            grpbxDelete.Visible = false;
            grpbxMagazine.Location = new Point(12, 24);
            this.Size = new Size(343, 270);
        }

        private void deleteItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbBoxDeleteName.SelectedIndex = -1;
            listView1.Visible = false;
            grpbxBook.Visible = false;
            grpbxMagazine.Visible = false;
            grpbxMusicCD.Visible = false;
            grpbxDelete.Visible = true;
            grpbxDelete.Location = new Point(12, 24);
            this.Size = new Size(343, 270);
        }


        private void bookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            grpbxBook.Visible = false;
            grpbxMagazine.Visible = false;
            grpbxMusicCD.Visible = false;
            grpbxDelete.Visible = false;
            listView1.Size = new Size(706, 265);
            this.Size = new Size(744, 337);
            listView1.Columns.Clear();
            listView1.Items.Clear();
            listView1.Columns.Add("Id", 100);
            listView1.Columns.Add("Name", 100);
            listView1.Columns.Add("Price", 100); 
            listView1.Columns.Add("quantity", 100);
            listView1.Columns.Add("ISBN Number", 100);
            listView1.Columns.Add("Author", 100);
            listView1.Columns.Add("Publisher", 100);
            listView1.Columns.Add("Page", 100);
            ProductLists books = ProductLists.CreateList();
            for(int i=0;i<books.Booklist.Count;i++)
            {
                ListViewItem bk = new ListViewItem(books.Booklist[i].printProperties());
                listView1.Items.Add(bk);
            }
        }

        private void musicCDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            grpbxBook.Visible = false;
            grpbxMagazine.Visible = false;
            grpbxMusicCD.Visible = false;
            grpbxDelete.Visible = false;
            listView1.Size = new Size(504, 265);
            this.Size = new Size(542, 337);
            listView1.Columns.Clear();
            listView1.Items.Clear();
            listView1.Columns.Add("Id", 100);
            listView1.Columns.Add("Name", 100);
            listView1.Columns.Add("Price", 100);
            listView1.Columns.Add("Quantity", 100);
            listView1.Columns.Add("Singer", 100);
            listView1.Columns.Add("Type", 100);
            ProductLists musiccds = ProductLists.CreateList();
            for (int i = 0; i < musiccds.MusicCDlist.Count; i++)
            {
                ListViewItem msccd = new ListViewItem(musiccds.MusicCDlist[i].printProperties());
                listView1.Items.Add(msccd);
            }
        }

        private void magazineToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            listView1.Visible = true;
            grpbxBook.Visible = false;
            grpbxMagazine.Visible = false;
            grpbxMusicCD.Visible = false;
            grpbxDelete.Visible = false;
            listView1.Size = new Size(504, 265);
            this.Size = new Size(542, 337);
            listView1.Columns.Clear();
            listView1.Items.Clear();
            listView1.Columns.Add("Id", 100);
            listView1.Columns.Add("Name", 100);
            listView1.Columns.Add("Price", 100);
            listView1.Columns.Add("Quantity", 100);
            listView1.Columns.Add("Issue", 100);
            listView1.Columns.Add("Type", 100);
            ProductLists magazines = ProductLists.CreateList();
            for (int i = 0; i < magazines.Magazinelist.Count; i++)
            {
                ListViewItem magazine = new ListViewItem(magazines.Magazinelist[i].printProperties());
                listView1.Items.Add(magazine);
            }
        }

        private void listCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            grpbxBook.Visible = false;
            grpbxMagazine.Visible = false;
            grpbxMusicCD.Visible = false;
            grpbxDelete.Visible = false;
            listView1.Size = new Size(504, 265);
            this.Size = new Size(542, 337);
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Customer ID", 100);
            listView1.Columns.Add("Name Surname",100);
            listView1.Columns.Add("Adress",100);
            listView1.Columns.Add("Email", 100);
            listView1.Columns.Add("Username", 100);
            CustomerList list = CustomerList.CreateList();
            for(int i=0;i<list.Cstmrlist.Count;i++)
            {
                ListViewItem cll = new ListViewItem(list.Cstmrlist[i].printCustomerDetails());
                listView1.Items.Add(cll); 
            }
           
        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                IdCount Cn = IdCount.Creator();
                book.Id = Cn.ProductId1;
                book.Name = txtNamebook.Text;
                book.Price = double.Parse(txtPriceBook.Text);
                book.ISBNnumber1 = int.Parse(txtISBNnumberbook.Text);
                book.Page = int.Parse(txtPagebook.Text);
                book.Publisher = txtPublisherbook.Text;
                book.Author = txtAuthorbook.Text;
                book.quantity = int.Parse(txtQuantityBok.Text);
                Cn.ProductId1 += 1;
                ProductLists Listspro = ProductLists.CreateList();
                Listspro.Booklist.Add(book);
                txtNamebook.Text = "";
                txtPriceBook.Text = "";
                txtISBNnumberbook.Text = "";
                txtPagebook.Text = "";
                txtPublisherbook.Text = "";
                txtAuthorbook.Text = "";
                txtQuantityBok.Text = "";
               
            }
            catch
            {
                MessageBox.Show("ERROR! Please enter true value");
            }
        
        }

        private void btnMusiccdAdd_Click(object sender, EventArgs e)
        {
            try
            {
                MusicCD musiccd = new MusicCD();
                IdCount Cn = IdCount.Creator();
                musiccd.Id = Cn.ProductId1;
                musiccd.Name = txtnamemusiccd.Text;
                musiccd.Price = double.Parse(txtPricemusiccd.Text);
                musiccd.Singer = txtSingermusiccd.Text;
                musiccd.Type = txtTypemusiccd.Text;
                musiccd.quantity = int.Parse(txtQuantityCD.Text);
                Cn.ProductId1 += 1;
                ProductLists Listspro = ProductLists.CreateList();
                Listspro.MusicCDlist.Add(musiccd);
                txtnamemusiccd.Text = "";
                txtPricemusiccd.Text = "";
                txtSingermusiccd.Text = "";
                txtTypemusiccd.Text = "";
                txtQuantityCD.Text = "";
            }
            catch 
            {
                MessageBox.Show("ERROR! Please enter true value");
            }
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Magazine magazine = new Magazine();
                IdCount Cn = IdCount.Creator();
                magazine.Id = Cn.ProductId1;
                magazine.Name = txtNamemagazine.Text;
                magazine.Price = double.Parse(txtPricemagazine.Text);
                magazine.Issue = int.Parse(txtIssuemagazine.Text);
                magazine.Type = txtTypemagazine.Text;
                magazine.quantity = int.Parse(txtQuantityMag.Text);
                Cn.ProductId1 += 1;
                ProductLists Listspro = ProductLists.CreateList();
                Listspro.Magazinelist.Add(magazine);
                txtNamemagazine.Text = "";
                txtPricemagazine.Text = "";
                txtIssuemagazine.Text = "";
                txtTypemagazine.Text = "";
                txtQuantityMag.Text = "";
            }
            catch
            {
                MessageBox.Show("ERROR! Please enter the right values");
            }
         
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Size = new Size(400, 400);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void cmbBoxDeleteName_DropDown(object sender, EventArgs e)
        {
            
            ProductLists items = ProductLists.CreateList();
            for (int i = 0; i < items.Booklist.Count; i++)
            {

                cmbBoxDeleteName.Items.Add(items.Booklist[i].Name);

            }
            for (int i = 0; i < items.MusicCDlist.Count; i++)
            {

                cmbBoxDeleteName.Items.Add(items.MusicCDlist[i].Name);

            }
            for (int i = 0; i < items.Magazinelist.Count; i++)
            {

                cmbBoxDeleteName.Items.Add(items.Magazinelist[i].Name);

            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string name = cmbBoxDeleteName.Text;
            bool gasit = false;
            ProductLists items = ProductLists.CreateList();
            for (int i = 0; i < items.Booklist.Count; i++)
            {
                gasit = name.Equals(items.Booklist[i].Name);
                if (gasit)
                {
                    items.Booklist.RemoveAt(i);
                    cmbBoxDeleteName.Items.Clear();
                    break;
                }

             }

            for (int i = 0; i < items.MusicCDlist.Count; i++)
            {
                gasit = name.Equals(items.MusicCDlist[i].Name);
                if (gasit)
                {
                    items.MusicCDlist.RemoveAt(i);
                    cmbBoxDeleteName.Items.Clear();
                    break;
                }



            }

            for (int i = 0; i < items.Magazinelist.Count; i++)
            {
                gasit = name.Equals(items.Magazinelist[i].Name);
                if (gasit)
                {
                    items.Magazinelist.RemoveAt(i);
                    cmbBoxDeleteName.Items.Clear();
                    break;
                }



            }
        }

        
    }
}

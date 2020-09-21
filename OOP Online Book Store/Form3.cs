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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int productdisplaycount = 0;
        int idDelete = 0;
        int quantityDelete = 0;
        int indexdelete = -1;
        ShoppingCart myShoppingChart = new ShoppingCart();
        private void btnListbook_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            listView1.Columns.Clear();
            listView1.Items.Clear();
            listView1.Columns.Add("Id", 100);
            listView1.Columns.Add("Name", 100);
            listView1.Columns.Add("Price", 100);
            listView1.Columns.Add("Quantity", 100);
            ProductLists books = ProductLists.CreateList();
            for (int i = 0; i < books.Booklist.Count; i++)
            {
                ListViewItem bk = new ListViewItem(books.Booklist[i].printProperties());
                listView1.Items.Add(bk);
            }
            productdisplaycount = 1;
            grpbxdetails.Visible = false;
            txtQuantitypro.Text = "";
        }
        private void btnListMusicCD_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            listView1.Columns.Clear();
            listView1.Items.Clear();
            listView1.Columns.Add("Id", 100);
            listView1.Columns.Add("Name", 100);
            listView1.Columns.Add("Price", 100);
            listView1.Columns.Add("Quantity", 100);
            ProductLists musiccds = ProductLists.CreateList();
            for (int i = 0; i < musiccds.MusicCDlist.Count; i++)
            {
                ListViewItem msccd = new ListViewItem(musiccds.MusicCDlist[i].printProperties());
                listView1.Items.Add(msccd);
            }
            productdisplaycount = 2;
            grpbxdetails.Visible = false;
            txtQuantitypro.Text = "";
        }

        private void btnListmagazine_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            listView1.Columns.Clear();
            listView1.Items.Clear();
            listView1.Columns.Add("Id", 100);
            listView1.Columns.Add("Name", 100);
            listView1.Columns.Add("Price", 100);
            listView1.Columns.Add("Quantity", 100);
            ProductLists magazines = ProductLists.CreateList();
            for (int i = 0; i < magazines.Magazinelist.Count; i++)
            {
                ListViewItem mgzn = new ListViewItem(magazines.Magazinelist[i].printProperties());
                listView1.Items.Add(mgzn);
            }
            productdisplaycount = 3;
            grpbxdetails.Visible = false;
            txtQuantitypro.Text = "";
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = -1;
            foreach (ListViewItem itm in listView1.SelectedItems)
            {
                if (itm.Selected)
                {
                    index = itm.Index;
                }
            }
            if(index==-1)
            {
                grpbxdetails.Visible = false;
            }
            else
            {
                grpbxdetails.Visible = true;
                if(productdisplaycount==1)
                {
                    label1.Text= "Id: " + listView1.Items[index].SubItems[0].Text;
                    label2.Text = "Name: " + listView1.Items[index].SubItems[1].Text;
                    label3.Text = "Price: " + listView1.Items[index].SubItems[2].Text;
                    label4.Text = "Quantity: " + listView1.Items[index].SubItems[3].Text;
                    label5.Text = "ISBN Number: " + listView1.Items[index].SubItems[4].Text;
                    label6.Text = "Author: " + listView1.Items[index].SubItems[5].Text;
                    label7.Text = "Publisher: " + listView1.Items[index].SubItems[6].Text;
                    label16.Text = "Page: " + listView1.Items[index].SubItems[7].Text;
                    txtnamepro.Text=listView1.Items[index].SubItems[1].Text;
                }
                if (productdisplaycount == 2)
                {
                    label1.Text = "Id: " + listView1.Items[index].SubItems[0].Text;
                    label2.Text = "Name: " + listView1.Items[index].SubItems[1].Text;
                    label3.Text = "Price: " + listView1.Items[index].SubItems[2].Text;
                    label4.Text = "Singer: " + listView1.Items[index].SubItems[3].Text;
                    label5.Text = "Type: " + listView1.Items[index].SubItems[4].Text;
                    label6.Text = "";
                    label7.Text = "";
                    txtnamepro.Text = listView1.Items[index].SubItems[1].Text;
                }
                if (productdisplaycount == 3)
                {
                    label1.Text = "Id: " + listView1.Items[index].SubItems[0].Text;
                    label2.Text = "Name: " + listView1.Items[index].SubItems[1].Text;
                    label3.Text = "Price: " + listView1.Items[index].SubItems[2].Text;
                    label4.Text = "Issue: " + listView1.Items[index].SubItems[3].Text;
                    label5.Text = "Type: " + listView1.Items[index].SubItems[4].Text;
                    label6.Text = "";
                    label7.Text = "";
                    txtnamepro.Text = listView1.Items[index].SubItems[1].Text;
                }
            }
        }

        private void btnShoppingcart_Click(object sender, EventArgs e)
        {
            
            listView2.Columns.Clear();
            listView2.Items.Clear();
            listView2.Columns.Add("Id", 100);
            listView2.Columns.Add("Name", 100);
            listView2.Columns.Add("Price", 100);
            listView2.Columns.Add("Quantity", 100);
            for (int i = 0; i < myShoppingChart.ItemsToPurchase.Count; i++)
            {
                ListViewItem pro = new ListViewItem(myShoppingChart.printProducts(i));
                listView2.Items.Add(pro);
            }
            grpbxShopping.Visible = false;
            grpbxShoppingcart.Visible = true;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Login lgn = Login.Creator();
            myShoppingChart.CustomerID1 = lgn.LoginCustomer1.CustomerID1;
            label10.Text = lgn.LoginCustomer1.Name1;
            btndeleteitem.Visible = false;
            grpbxShopping.Location = new Point(12, 12);
            this.Size = new Size(870, 460);
        }

        private void btnAdatocart_Click(object sender, EventArgs e)
        {
            ProductLists prolis = ProductLists.CreateList();
            
            
            try
            {
                if (int.Parse(txtQuantitypro.Text) > 0)
                {
                    
                    if (productdisplaycount == 1)
                    {
                        for (int i = 0; i < prolis.Booklist.Count; i++)
                        {
                            if (txtnamepro.Text == prolis.Booklist[i].Name)
                            {   if (checkIfPossible(prolis.Booklist[i].quantity, txtQuantitypro.Text))
                                {
                                    myShoppingChart.addProduct(prolis.Booklist[i], int.Parse(txtQuantitypro.Text));
                                    prolis.Booklist[i].quantity -= int.Parse(txtQuantitypro.Text);
                                    MessageBox.Show("Products have been added your cart");
                                    break;
                                }
                                else MessageBox.Show("We don't have that many items");
                            }
                        }
                    }
                    if (productdisplaycount == 2)
                    {
                        for (int i = 0; i < prolis.MusicCDlist.Count; i++)
                        {
                            if (txtnamepro.Text == prolis.MusicCDlist[i].Name)
                            {
                                if (checkIfPossible(prolis.MusicCDlist[i].quantity, txtQuantitypro.Text))
                                {
                                    myShoppingChart.addProduct(prolis.MusicCDlist[i], int.Parse(txtQuantitypro.Text));
                                    prolis.MusicCDlist[i].quantity -= int.Parse(txtQuantitypro.Text);
                                    MessageBox.Show("Products have been added your cart");
                                    break;
                                }
                            }
                        }
                    }
                    if (productdisplaycount == 3)
                    {
                        for (int i = 0; i < prolis.Magazinelist.Count; i++)
                        {
                            if (txtnamepro.Text == prolis.Magazinelist[i].Name)
                            { if (checkIfPossible(prolis.Magazinelist[i].quantity, txtQuantitypro.Text))
                                {
                                    myShoppingChart.addProduct(prolis.Magazinelist[i], int.Parse(txtQuantitypro.Text));
                                    prolis.Magazinelist[i].quantity -= int.Parse(txtQuantitypro.Text);
                                    MessageBox.Show("Products have been added your cart");
                                    break;
                                }
                            }
                        }
                    }
                    txtQuantitypro.Text = "";
                    
                }
                else
                {
                    MessageBox.Show("Incorrect data");
                    txtQuantitypro.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please Enter number value to Quantity");
                txtQuantitypro.Text = "";
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexdelete = -1;
            foreach (ListViewItem itm in listView2.SelectedItems)
            {
                if (itm.Selected)
                {
                    indexdelete = itm.Index;
                    string namedelete =  itm.SubItems[0].Text;
                    idDelete = int.Parse(namedelete);
                    namedelete = itm.SubItems[3].Text;
                    quantityDelete = int.Parse(namedelete);
                    btndeleteitem.Visible = true;
                }
            }
            
        }

        private void btndeleteitem_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < myShoppingChart.ItemsToPurchase.Count; i++)
            {

                if (idDelete == myShoppingChart.ItemsToPurchase[i].product.id)
                    myShoppingChart.ItemsToPurchase[i].product.quantity += quantityDelete;

            }
            myShoppingChart.removeProduct(indexdelete);
            btndeleteitem.Visible = false;
            listView2.Columns.Clear();
            listView2.Items.Clear();
            listView2.Columns.Add("Id", 100);
            listView2.Columns.Add("Name", 100);
            listView2.Columns.Add("Price", 100);
            listView2.Columns.Add("Quantity", 100);
            for (int i = 0; i < myShoppingChart.ItemsToPurchase.Count; i++)
            {
                ListViewItem pro = new ListViewItem(myShoppingChart.printProducts(i));
                listView2.Items.Add(pro);
            }

        }

        private void btnConfirmcart_Click(object sender, EventArgs e)
        {
            if(myShoppingChart.ItemsToPurchase.Count==0)
            {
                MessageBox.Show("Your Shopping Cart is empty");
            }
            else
            {   
                btnAddnewitem.Visible = false;
                btndeleteitem.Visible = false;
                btnConfirmcart.Visible = false;
                listView2.Enabled = false;
                Login lg = Login.Creator();
                txtConfirmcustomerid.Text = lg.LoginCustomer1.CustomerID1.ToString();
                txtConfirmname.Text = lg.LoginCustomer1.Name1;
                txtConfirmemail.Text = lg.LoginCustomer1.Email1;
                txtConfirmadress.Text = lg.LoginCustomer1.Address1;
                txtConfirmtotalprice.Text = myShoppingChart.calculateTotalPrice().ToString();
                grpbxConfirmcart.Visible = true;
            }
         
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                IPayment Crdtcrd = Takepayment.FactoryMethod("CreditCard");
                MessageBox.Show(Crdtcrd.paymentconfirmandtype()+"\n"+myShoppingChart.placeOrder()+"\n"+myShoppingChart.sendInvoicebySMS()+"\n"+myShoppingChart.sendInvoidcebyEmail());
                listView2.Columns.Clear();
                listView2.Items.Clear();
                this.Close();
            }
            if (radioButton2.Checked)
            {
                IPayment Csh = Takepayment.FactoryMethod("Cash");
                MessageBox.Show(Csh.paymentconfirmandtype()+"\n" + myShoppingChart.placeOrder() + "\n" + myShoppingChart.sendInvoicebySMS() + "\n" + myShoppingChart.sendInvoidcebyEmail());
                listView2.Columns.Clear();
                listView2.Items.Clear();
                this.Close();
            }
            if (radioButton3.Checked)
            {
                IPayment Chck = Takepayment.FactoryMethod("Check");
                MessageBox.Show(Chck.paymentconfirmandtype()+ "\n" + myShoppingChart.placeOrder() + "\n" + myShoppingChart.sendInvoicebySMS() + "\n" + myShoppingChart.sendInvoidcebyEmail());
                listView2.Columns.Clear();
                listView2.Items.Clear();
                this.Close();
            }
            
        }

        private void btnAddnewitem_Click(object sender, EventArgs e)
        {
            grpbxConfirmcart.Visible = false;
            grpbxShopping.Visible = true;
            grpbxShoppingcart.Visible = false;
        }

        private void btnConfirmcancel_Click(object sender, EventArgs e)
        {
            grpbxConfirmcart.Visible = false;
            btnAddnewitem.Visible = true;
            listView2.Enabled = true;
            btnConfirmcart.Visible = true;
            MessageBox.Show(myShoppingChart.cancelOrder());

        }

        private bool checkIfPossible(int t,string i)
        {
            int temporar = int.Parse(i);
            if (t - temporar >= 0)
                return true;
            else return false;

        }
    }
}

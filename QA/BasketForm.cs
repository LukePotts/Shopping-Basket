using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoppingBasket;
using System.IO;

namespace QA
{
    public partial class BasketForm : Form
    {
        public ShoppingBasket.ShoppingBasket ThisBasket;
        string BasketDisplayFormat = "{0}\t\t\t{1}\t\t\t{2}\t\t\t{3}";
        public BasketForm()
        {
            InitializeComponent();
            ThisBasket = ShoppingBasket.ShoppingBasket.Instance;            
            UpdatePage();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = Convert.ToString(ProductName.Text);
                decimal Price = Convert.ToDecimal(LatestPrice.Text);
                int ThisQuantity = Convert.ToInt32(Quantity.Value);
                bool Exists = ThisBasket.IsProductInBasket(Name);
                
                if (ThisBasket.ValidName(Name) && ThisBasket.ValidPrice(Price))
                {
                    if (Exists)
                    {
                            ThisBasket.AddProduct(Name, Price, ThisQuantity);

                    }
                    else
                    {
                        if (ThisBasket.ValidQuantity(ThisQuantity))
                        {
                            ThisBasket.AddProduct(Name, Price, ThisQuantity);
                        }
                        else
                        {
                            MessageBox.Show("Select a quantity to add");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("One or more of the values is invalid.");
                }
            }
            catch
            {
                MessageBox.Show("One or more of the values is invalid.");
            }
            UpdatePage();        
        }

        private void BasketForm_Load(object sender, EventArgs e)
        {

        }

        

        public void UpdatePage()
        {
            UpdateBasket();
            UpdateNoOfItems();
            UpdateTotal();
        }
        private void UpdateBasket()
        {
            Basket.Items.Clear();
            foreach (OrderItem i in ThisBasket.OrderItems)
            {
                Basket.Items.Add(string.Format(BasketDisplayFormat, Convert.ToString(i.ProductName), Convert.ToInt32(i.Quantity), string.Format("{0:C}", i.LastestPrice), string.Format("{0:C}", i.TotalOrder)));
            }
        }
        private void UpdateNoOfItems()
        {
            int CountItems = 0;            
            foreach (OrderItem i in ThisBasket.OrderItems)
            {
                CountItems += i.Quantity;
            }
            NoItems.Text = Convert.ToString(CountItems);
        }
        private void UpdateTotal()
        {
            decimal CountCosts = 0;
            foreach (OrderItem i in ThisBasket.OrderItems)
            {
                CountCosts += i.TotalOrder;
            }
            Total.Text = string.Format("{0:C}",CountCosts);
        }

        private void ClearBasketButton_Click(object sender, EventArgs e)
        {
            ThisBasket.ClearBasket();
            UpdatePage();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (Basket.SelectedIndex!=-1)
            {
            OrderItem ItemToEdit = ThisBasket.GetOrderItemByName(Convert.ToString(Basket.SelectedItem).Split('\t')[0]);
            EditItem NewEditItem = new EditItem(ItemToEdit);
            NewEditItem.Show();
                NewEditItem.Text = ItemToEdit.ProductName;
            this.Hide();
            NewEditItem.FormClosing += EditItem_FormClosing;
            }
            else
            {
                MessageBox.Show("No item selected");
            }
        }

        private void EditItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdatePage();
            this.Show();
        }

        private void RemoveAllButton_Click(object sender, EventArgs e)
        {
            //switch (Basket.SelectedIndex)
            //{
            //    case -1 :
            //        MessageBox.Show("No item selected");
            //        break;
            //    default:
            //        ThisBasket.RemoveProduct(Convert.ToString(Basket.SelectedItem).Split('\t')[0]);
            //        UpdatePage();
            //        break;
            //}
                
            if (Basket.SelectedIndex == -1)
            {
                MessageBox.Show("No item selected");
            }
            else
            {
                ThisBasket.RemoveProduct(Convert.ToString(Basket.SelectedItem).Split('\t')[0]);
                UpdatePage();
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            ThisBasket.RemoveProduct(Convert.ToString(Basket.SelectedItem).Split('\t')[0] , 1);
            UpdatePage();
        }
        
        //using textwriter to convert the objects in the list to text and save this as a text file and displays with other info as a header and footer
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                //instantiate a SaveFileDialog box
                SaveFileDialog SaveFile = new SaveFileDialog();
                //filter the displayed items to .txt files only
                SaveFile.Filter = "Text|*.txt|All|*.*";
                //give the file a default name that identifies it to the user as a receipt but has the date and time as a unique identifier (user can change the default name)
                SaveFile.FileName = "Shopping Basket Receipt - " + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-ff") + ".txt";
                //display file dialogue
                SaveFile.ShowDialog();
                //when save is pressed
                //only save if file has a name
                if (!string.IsNullOrEmpty(SaveFile.FileName))
                {
                    string ToSave = string.Empty;
                    //puts each item in the list into one text bloc seperated by a new line
                    foreach (string l in Basket.Items)
                    {
                        ToSave = ToSave + l + Environment.NewLine;
                    }
                    //adds other info to text
                    //header
                        ToSave = "Shopping Basket App"
                        //subheader
                            + Environment.NewLine + "Receipt - " + Convert.ToString(DateTime.Now)
                            //space
                            + Environment.NewLine
                            //column headers
                            + Environment.NewLine + "Product\t\t\tQuantity\t\tPrice Per Unit\t\tTotal"
                            //underlining
                            + Environment.NewLine + string.Format(BasketDisplayFormat, "===", "===", "===", "===")
                            //adds text from list
                            + Environment.NewLine + ToSave
                            //space
                            + Environment.NewLine
                            //footer
                            + Environment.NewLine + "Luke Potts - QA Apprenticeship Coursework - Shopping Basket";
                    //saves all text to text file under name in the save as box
                        File.WriteAllText(SaveFile.FileName, ToSave);
                }
                else
                {
                    //tell user the file needs a name
                    MessageBox.Show("Please give the file a name");
                }
            }
            //safety measure to combat application failure
            catch (Exception error)
            {
                //if the file is not saved show messafe to user
                MessageBox.Show("File save failedwith error: " + error.Message);
            }           
        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductName_KeyDown(object sender, KeyEventArgs e)
        {            
            //if (e.KeyCode == Keys.Enter)
            //{
            //    AddButton
            //}
        }
    }
}

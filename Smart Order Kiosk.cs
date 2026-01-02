using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Order_Kiosk
{
    public partial class SmartOrderKiosk : Form
    {
        public SmartOrderKiosk()
        {
            InitializeComponent();
        }

        struct stItem
        {
            public string ItemName;
            public byte ItemPrice;
            public int Quantity;
            public int TotalPrice;
        }

        stItem Item = new stItem();
        stItem[] arrItems = new stItem[100];
        int ItemsCount = 0;
        int OrderSummaryTotal = 0;
        void ResetOrder()
        {
        
            cbItems.SelectedIndex = 0;
            nudQuantity.Value = 1;
            StoreItemInfo(cbItems.SelectedItem.ToString(), (int)nudQuantity.Value);
        

       }

        void ResetOrderSummary()
        {
            lvOrderSummary.Items.Clear();
       
            lblOrderSummaryTotal.Text = "$ 0";

            ItemsCount = 0;

            pnFullInfo.Visible = false;
        }

        byte GetItemPrice(string SelectedItem)
        {
            switch(SelectedItem)
            {
                case "Burger":
                    return 50;

                case "Cheese Burger":
                    return 60;

                case "Fries":
                    return 25;

                case "Pasta":
                    return 70;

                case "Pizza":
                    return 80;

                default:
                    return 65;
            }
        }

        Image GetItemImage(string SelectedItem)
        {
            switch (SelectedItem)
            {
                case "Burger":
                    return Properties.Resources.burger;

                case "Cheese Burger":
                    return Properties.Resources.Cheese_burger;

                case "Fries":
                    return Properties.Resources.Fries;

                case "Pasta":
                    return Properties.Resources.Pasta;

                case "Pizza":
                    return Properties.Resources.Pizza;

                default:
                    return Properties.Resources.Shawarma;
            }
        }

        int GetOrderTotal(byte ItemPrice, int Quantity)
        {
            return (int)ItemPrice * Quantity;
        }

        void UpdateSummaryInfo(string SelectedItem, int Quantity,int TotalPrice)
        {
         
            lblItem.Text = SelectedItem;
            pbItem.Image = GetItemImage(SelectedItem);
            lblQuantity.Text = Quantity.ToString();
            lblTotal.Text = $"$ {TotalPrice}";
        }

        void StoreItemInfo(string SelectedItem,int Quantity)
        {
            byte itemPrice = GetItemPrice(SelectedItem);

            Item.ItemName = SelectedItem;
            Item.ItemPrice = GetItemPrice(SelectedItem);
            Item.Quantity = Quantity;
            Item.TotalPrice = GetOrderTotal(itemPrice, Quantity);

            lblPrice.Text = $"$ {GetItemPrice(SelectedItem)}";

            UpdateSummaryInfo(SelectedItem, Quantity, Item.TotalPrice);
        }

        void UpdateOrderSummaryTotal()
        {
            lblOrderSummaryTotal.Text = $"$ { OrderSummaryTotal}";
        }

        void AddItemToArr()
        {
            arrItems[ItemsCount] = Item;
            ItemsCount++;
        }
        void AddItemToListView()
        {

            AddItemToArr();
            ListViewItem ListItem = new ListViewItem(Item.ItemName);
            ListItem.SubItems.Add(Item.Quantity.ToString());
            ListItem.SubItems.Add(Item.ItemPrice.ToString());
            ListItem.SubItems.Add(Item.TotalPrice.ToString());
         

            lvOrderSummary.Items.Add(ListItem);

            OrderSummaryTotal += Item.TotalPrice;
            UpdateOrderSummaryTotal();
        }

        void ShowOrderConfirmed()
        {
            MessageBox.Show("Order confirmed successfully ✅", "Confirm Order", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }


        void ShowSelectionScreen()
        {
            pnFullInfo.Visible = true;
            pnSelection.Visible = true;
            pnItemDetails.Visible = true;
            lvOrderSummary.Visible = false;
            lblOrderSummaryTotal.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            btnConfirmOrder.Visible = false;
        }
        
        void ShowOrderSummaryScreen()
        {
            pnFullInfo.Visible = true;
            pnSelection.Visible = false;
            pnItemDetails.Visible = false;
            lvOrderSummary.Visible = true;
            lblOrderSummaryTotal.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            btnConfirmOrder.Visible = true;
            
        }

        void RemoveItemFromArray(string ItemName)
        {
            stItem[] TempArr = new stItem[100];
            int arrlength = 0;
            for(int i=0;i < ItemsCount;i++)
            {
                if(arrItems[i].ItemName != ItemName)
                {
                    TempArr[arrlength] = arrItems[i];
                    arrlength++;
                }
            }


            arrItems = TempArr;
            ItemsCount--;
        }
        
        void RemoveItem()
        {
            if (lvOrderSummary.SelectedItems.Count>0)
            {
                RemoveItemFromArray(lvOrderSummary.SelectedItems[0].Text);
                OrderSummaryTotal -= Convert.ToInt32(lvOrderSummary.SelectedItems[0].SubItems[3].Text);
                lvOrderSummary.Items.Remove(lvOrderSummary.SelectedItems[0]);
                UpdateOrderSummaryTotal();
            }
           
        }

     
        private void newOrderToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
             newOrderToolStripMenuItem.ShowDropDown();
        }

     
        private void numericUpDown1_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void pnSelectionFood_VisibleChanged(object sender, EventArgs e)
        {
            if (pnFullInfo.Visible)
            {
                cbItems.SelectedIndex = 0;
                nudQuantity.Value = 1;
            }
 
        }

        private void cbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            StoreItemInfo(cbItems.SelectedItem.ToString(),(int)nudQuantity.Value);
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            StoreItemInfo(cbItems.SelectedItem.ToString(), (int)nudQuantity.Value);
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            AddItemToListView();
            ResetOrder();
        }

   

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            ShowOrderConfirmed();
            ResetOrderSummary();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetOrderSummary();
            pnFullInfo.Visible = false;
        }

        private void orderSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOrderSummaryScreen();
        }

        private void selectionfoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSelectionScreen();
        }

     

        private void removeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(lvOrderSummary.SelectedItems.Count>0)
            {
                RemoveItem();
            }

         
        }


        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem item = lvOrderSummary.GetItemAt(e.X, e.Y);

                if (item != null)
                {
                    item.Selected = true;
                }
                else
                {
                    lvOrderSummary.SelectedItems.Clear();
                }
            }

        }

       
    }
}

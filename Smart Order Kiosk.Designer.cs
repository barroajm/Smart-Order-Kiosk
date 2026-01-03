
namespace Smart_Order_Kiosk
{
    partial class SmartOrderKiosk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbHome = new System.Windows.Forms.TabPage();
            this.tbNewOrder = new System.Windows.Forms.TabPage();
            this.pnFullInfo = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.lblOrderSummaryTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lvOrderSummary = new System.Windows.Forms.ListView();
            this.clmItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnItemDetails = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbItem = new System.Windows.Forms.PictureBox();
            this.pnSelection = new System.Windows.Forms.Panel();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionfoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tbNewOrder.SuspendLayout();
            this.pnFullInfo.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.pnItemDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).BeginInit();
            this.pnSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbHome);
            this.tabControl1.Controls.Add(this.tbNewOrder);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 31);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1131, 700);
            this.tabControl1.TabIndex = 0;
            // 
            // tbHome
            // 
            this.tbHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbHome.BackgroundImage = global::Smart_Order_Kiosk.Properties.Resources.self_ordering_and_self_payment_kiosk_for_fast_food_chains_restaurants_and_retailers_floor_standing_vector;
            this.tbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbHome.Location = new System.Drawing.Point(4, 35);
            this.tbHome.Name = "tbHome";
            this.tbHome.Padding = new System.Windows.Forms.Padding(3);
            this.tbHome.Size = new System.Drawing.Size(1123, 661);
            this.tbHome.TabIndex = 0;
            this.tbHome.Text = "Home";
            // 
            // tbNewOrder
            // 
            this.tbNewOrder.BackgroundImage = global::Smart_Order_Kiosk.Properties.Resources.food_kiosk;
            this.tbNewOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbNewOrder.Controls.Add(this.pnFullInfo);
            this.tbNewOrder.Controls.Add(this.menuStrip1);
            this.tbNewOrder.Location = new System.Drawing.Point(4, 35);
            this.tbNewOrder.Name = "tbNewOrder";
            this.tbNewOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tbNewOrder.Size = new System.Drawing.Size(1123, 661);
            this.tbNewOrder.TabIndex = 1;
            this.tbNewOrder.Text = "New Order";
            this.tbNewOrder.UseVisualStyleBackColor = true;
            // 
            // pnFullInfo
            // 
            this.pnFullInfo.BackColor = System.Drawing.Color.White;
            this.pnFullInfo.Controls.Add(this.label7);
            this.pnFullInfo.Controls.Add(this.btnConfirmOrder);
            this.pnFullInfo.Controls.Add(this.lblOrderSummaryTotal);
            this.pnFullInfo.Controls.Add(this.label5);
            this.pnFullInfo.Controls.Add(this.label6);
            this.pnFullInfo.Controls.Add(this.lvOrderSummary);
            this.pnFullInfo.Controls.Add(this.pnItemDetails);
            this.pnFullInfo.Controls.Add(this.pnSelection);
            this.pnFullInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFullInfo.Location = new System.Drawing.Point(3, 47);
            this.pnFullInfo.Name = "pnFullInfo";
            this.pnFullInfo.Size = new System.Drawing.Size(1117, 611);
            this.pnFullInfo.TabIndex = 1;
            this.pnFullInfo.Visible = false;
            this.pnFullInfo.VisibleChanged += new System.EventHandler(this.pnSelectionFood_VisibleChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Traditional Arabic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(368, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 49);
            this.label7.TabIndex = 12;
            this.label7.Text = "Order Summary";
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnConfirmOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmOrder.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmOrder.Location = new System.Drawing.Point(427, 549);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(224, 47);
            this.btnConfirmOrder.TabIndex = 11;
            this.btnConfirmOrder.Text = "Confirm Order";
            this.btnConfirmOrder.UseVisualStyleBackColor = false;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // lblOrderSummaryTotal
            // 
            this.lblOrderSummaryTotal.AutoSize = true;
            this.lblOrderSummaryTotal.Font = new System.Drawing.Font("Traditional Arabic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSummaryTotal.ForeColor = System.Drawing.Color.Red;
            this.lblOrderSummaryTotal.Location = new System.Drawing.Point(545, 440);
            this.lblOrderSummaryTotal.Name = "lblOrderSummaryTotal";
            this.lblOrderSummaryTotal.Size = new System.Drawing.Size(91, 73);
            this.lblOrderSummaryTotal.TabIndex = 10;
            this.lblOrderSummaryTotal.Text = "$ 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Traditional Arabic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(326, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 73);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-10, 520);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1137, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------";
            // 
            // lvOrderSummary
            // 
            this.lvOrderSummary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmItem,
            this.clmQuantity,
            this.clmPrice,
            this.clmTotal});
            this.lvOrderSummary.ContextMenuStrip = this.contextMenuStrip1;
            this.lvOrderSummary.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvOrderSummary.FullRowSelect = true;
            this.lvOrderSummary.HideSelection = false;
            this.lvOrderSummary.Location = new System.Drawing.Point(-7, 52);
            this.lvOrderSummary.Name = "lvOrderSummary";
            this.lvOrderSummary.Size = new System.Drawing.Size(1114, 379);
            this.lvOrderSummary.TabIndex = 2;
            this.lvOrderSummary.UseCompatibleStateImageBehavior = false;
            this.lvOrderSummary.View = System.Windows.Forms.View.Details;
            this.lvOrderSummary.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // clmItem
            // 
            this.clmItem.Text = "Item";
            this.clmItem.Width = 200;
            // 
            // clmQuantity
            // 
            this.clmQuantity.Text = "Quantity";
            this.clmQuantity.Width = 200;
            // 
            // clmPrice
            // 
            this.clmPrice.Text = "Price";
            this.clmPrice.Width = 200;
            // 
            // clmTotal
            // 
            this.clmTotal.Text = "Total";
            this.clmTotal.Width = 200;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeItemToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // removeItemToolStripMenuItem
            // 
            this.removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            this.removeItemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeItemToolStripMenuItem.Text = "Remove item";
            this.removeItemToolStripMenuItem.Click += new System.EventHandler(this.removeItemToolStripMenuItem_Click);
            // 
            // pnItemDetails
            // 
            this.pnItemDetails.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnItemDetails.Controls.Add(this.lblTotal);
            this.pnItemDetails.Controls.Add(this.label4);
            this.pnItemDetails.Controls.Add(this.lblQuantity);
            this.pnItemDetails.Controls.Add(this.label3);
            this.pnItemDetails.Controls.Add(this.lblItem);
            this.pnItemDetails.Controls.Add(this.label2);
            this.pnItemDetails.Controls.Add(this.pbItem);
            this.pnItemDetails.Location = new System.Drawing.Point(604, 49);
            this.pnItemDetails.Name = "pnItemDetails";
            this.pnItemDetails.Size = new System.Drawing.Size(429, 474);
            this.pnItemDetails.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotal.Location = new System.Drawing.Point(189, 363);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(66, 39);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "$ 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(17, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 45);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total :";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.DimGray;
            this.lblQuantity.Location = new System.Drawing.Point(218, 264);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(37, 39);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(3, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantity:";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.ForeColor = System.Drawing.Color.DimGray;
            this.lblItem.Location = new System.Drawing.Point(140, 39);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(115, 35);
            this.lblItem.TabIndex = 4;
            this.lblItem.Text = "Burger";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(17, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Item:";
            // 
            // pbItem
            // 
            this.pbItem.Location = new System.Drawing.Point(85, 90);
            this.pbItem.Name = "pbItem";
            this.pbItem.Size = new System.Drawing.Size(262, 165);
            this.pbItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbItem.TabIndex = 0;
            this.pbItem.TabStop = false;
            // 
            // pnSelection
            // 
            this.pnSelection.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnSelection.Controls.Add(this.btnAddToOrder);
            this.pnSelection.Controls.Add(this.nudQuantity);
            this.pnSelection.Controls.Add(this.lblPrice);
            this.pnSelection.Controls.Add(this.label1);
            this.pnSelection.Controls.Add(this.cbItems);
            this.pnSelection.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnSelection.Location = new System.Drawing.Point(89, 49);
            this.pnSelection.Name = "pnSelection";
            this.pnSelection.Size = new System.Drawing.Size(420, 474);
            this.pnSelection.TabIndex = 0;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddToOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToOrder.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToOrder.Location = new System.Drawing.Point(113, 402);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(185, 47);
            this.btnAddToOrder.TabIndex = 5;
            this.btnAddToOrder.Text = "Add To Order";
            this.btnAddToOrder.UseVisualStyleBackColor = false;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nudQuantity.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(134, 184);
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(140, 46);
            this.nudQuantity.TabIndex = 4;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged);
            this.nudQuantity.Enter += new System.EventHandler(this.numericUpDown1_Enter);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.DimGray;
            this.lblPrice.Location = new System.Drawing.Point(222, 322);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(66, 39);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "$ 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(69, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Price:";
            // 
            // cbItems
            // 
            this.cbItems.BackColor = System.Drawing.Color.White;
            this.cbItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItems.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Items.AddRange(new object[] {
            "Burger",
            "Cheese Burger",
            "Fries",
            "Pasta",
            "Pizza",
            "Shawarma"});
            this.cbItems.Location = new System.Drawing.Point(66, 70);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(279, 37);
            this.cbItems.Sorted = true;
            this.cbItems.TabIndex = 1;
            this.cbItems.SelectedIndexChanged += new System.EventHandler(this.cbItems_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOrderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1117, 44);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newOrderToolStripMenuItem
            // 
            this.newOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectionfoodToolStripMenuItem,
            this.orderSummaryToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.newOrderToolStripMenuItem.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderToolStripMenuItem.Image = global::Smart_Order_Kiosk.Properties.Resources.download4;
            this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(181, 40);
            this.newOrderToolStripMenuItem.Text = "&New Order";
            this.newOrderToolStripMenuItem.MouseEnter += new System.EventHandler(this.newOrderToolStripMenuItem_MouseEnter);
            // 
            // selectionfoodToolStripMenuItem
            // 
            this.selectionfoodToolStripMenuItem.Image = global::Smart_Order_Kiosk.Properties.Resources.Cheese_burger;
            this.selectionfoodToolStripMenuItem.Name = "selectionfoodToolStripMenuItem";
            this.selectionfoodToolStripMenuItem.Size = new System.Drawing.Size(288, 40);
            this.selectionfoodToolStripMenuItem.Text = "Selection Food";
            this.selectionfoodToolStripMenuItem.Click += new System.EventHandler(this.selectionfoodToolStripMenuItem_Click);
            // 
            // orderSummaryToolStripMenuItem
            // 
            this.orderSummaryToolStripMenuItem.Image = global::Smart_Order_Kiosk.Properties.Resources.download1;
            this.orderSummaryToolStripMenuItem.Name = "orderSummaryToolStripMenuItem";
            this.orderSummaryToolStripMenuItem.Size = new System.Drawing.Size(288, 40);
            this.orderSummaryToolStripMenuItem.Text = "Order summary";
            this.orderSummaryToolStripMenuItem.Click += new System.EventHandler(this.orderSummaryToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Image = global::Smart_Order_Kiosk.Properties.Resources.download5;
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(288, 40);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // SmartOrderKiosk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 700);
            this.Controls.Add(this.tabControl1);
            this.Name = "SmartOrderKiosk";
            this.Text = "Smart Order Kiosk";
            this.tabControl1.ResumeLayout(false);
            this.tbNewOrder.ResumeLayout(false);
            this.tbNewOrder.PerformLayout();
            this.pnFullInfo.ResumeLayout(false);
            this.pnFullInfo.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.pnItemDetails.ResumeLayout(false);
            this.pnItemDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).EndInit();
            this.pnSelection.ResumeLayout(false);
            this.pnSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbHome;
        private System.Windows.Forms.TabPage tbNewOrder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectionfoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.Panel pnFullInfo;
        private System.Windows.Forms.Panel pnItemDetails;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbItem;
        private System.Windows.Forms.Panel pnSelection;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbItems;
        private System.Windows.Forms.ListView lvOrderSummary;
        private System.Windows.Forms.ColumnHeader clmItem;
        private System.Windows.Forms.ColumnHeader clmQuantity;
        private System.Windows.Forms.ColumnHeader clmPrice;
        private System.Windows.Forms.ColumnHeader clmTotal;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Label lblOrderSummaryTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeItemToolStripMenuItem;
    }
}


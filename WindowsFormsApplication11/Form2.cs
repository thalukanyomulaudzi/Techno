﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApplication11
{
    public partial class Form2 : Form
    {
        Button navButton;
        MmasweEntities4 db = new MmasweEntities4();
        public Form2()
        {
            InitializeComponent();
        }

        //Global Objects

      

        //Global Objects


        private void navigate(Button b)
        {
            if (navButton != null)
            {
                navButton.BackColor = Color.CornflowerBlue;
                navButton.TextAlign = ContentAlignment.MiddleLeft;
            }

            navButton = b;
            navButton.BackColor = Color.FromArgb(80, 120, 191);
            navButton.FlatAppearance.MouseOverBackColor = navButton.BackColor;
            navButton.TextAlign = ContentAlignment.MiddleRight;
        }


        void myMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
            
            if (navButton == btnMenu)
            {
              
                if (e.ClickedItem.Name.ToString() == "Deleted")
                {
                    Globals.menu.Hide();
                    if (dgvSupplier.Rows.Count != 0)
                    {
                        int id = Globals.MenuCombopassing;

                        Menu_Item deieteItem = db.Menu_Item.FirstOrDefault(c => c.Menu_Item_ID == id);

                        if (deieteItem != null)
                        {
                            db.Menu_Item.Remove(deieteItem);
                            db.SaveChanges();
                            MessageBox.Show("Stock item(" +deieteItem.Menu_Item_Name +") deleted successfully");

                        }
                        else
                        {
                            MessageBox.Show("Error:Stock item does not exist/No stock item selected,select a stock item");
                        }

                    }

                }
                else if (e.ClickedItem.Name.ToString() == "View")
                {
                    Globals.menu.Hide();
                    int id = Globals.MenuCombopassing;
                    Menu_Item item = db.Menu_Item.FirstOrDefault(c => c.Menu_Item_ID == id);
                    if(item != null)
                    {
                        frmMaintainMenuItem form = new frmMaintainMenuItem();
                        form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Error:Stock item does not exist/No stock item selected,select a stock item");
                    }

                }
            }




            //Suppliers Right Cick Event handlers

            if (navButton == btnEmployees)
            {

                if (e.ClickedItem.Name.ToString() == "Deleted")
                {
                    Globals.menu.Hide();
                    if (dgvSupplier.Rows.Count != 0)
                    {
                        int id = Globals.Employeepassing;

                        Employee deieteItem = db.Employees.FirstOrDefault(c => c.Employee_ID == id);

                        if (deieteItem != null)
                        {
                            db.Employees.Remove(deieteItem);
                            db.SaveChanges();
                            MessageBox.Show("Stock item(" + deieteItem.Employee_Name + ") deleted successfully");
                        }
                        else
                        {
                            MessageBox.Show("Error:Stock item does not exist/No stock item selected,select a stock item");
                        }

                    }

                }
                else if (e.ClickedItem.Name.ToString() == "View")
                {
                    Globals.menu.Hide();
                    int id = Globals.Employeepassing;
                    Employee item = db.Employees.FirstOrDefault(c => c.Employee_ID == id);
                    if (item != null)
                    {
                        Maintain_Employee form = new Maintain_Employee();
                        form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Error:Stock item does not exist/No stock item selected,select a stock item");
                    }

                }
            }


            //Suppliers Right click Handlers

            if (navButton == btnSuppliers11)
            {

                if (e.ClickedItem.Name.ToString() == "Deleted")
                {
                    Globals.menu.Hide();
                    if (dgvSupplier.Rows.Count != 0)
                    {
                        int id = Globals.Supplierpassing;

                        Supplier deieteItem = db.Suppliers.FirstOrDefault(c => c.Supllier_ID == id);

                        if (deieteItem != null)
                        {
                            db.Suppliers.Remove(deieteItem);
                            db.SaveChanges();
                            MessageBox.Show("Stock item(" + deieteItem.Supplier_Name + ") deleted successfully");
                        }
                        else
                        {
                            MessageBox.Show("Error:Stock item does not exist/No stock item selected,select a stock item");
                        }

                    }

                }
                else if (e.ClickedItem.Name.ToString() == "View")
                {
                    Globals.menu.Hide();
                    int id = Globals.Supplierpassing;
                    Supplier item = db.Suppliers.FirstOrDefault(c => c.Supllier_ID == id);
                    if (item != null)
                    {
                        SupplierForm form = new SupplierForm();
                        form.ShowDialog();
                        
                    }
                    else
                    {
                        MessageBox.Show("Error:Stock item does not exist/No stock item selected,select a stock item");
                    }
                    

                }
            }

            if (navButton == btnCombo)
            {

                if (e.ClickedItem.Name.ToString() == "Deleted")
                {
                    Globals.menu.Hide();
                    if (dgvSupplier.Rows.Count != 0)
                    {
                        int id = Globals.Combopassing;

                        Combo deieteItem = db.Comboes.FirstOrDefault(c => c.Combo_ID == id);

                        if (deieteItem != null)
                        {
                            db.Comboes.Remove(deieteItem);
                            db.SaveChanges();
                            MessageBox.Show("Stock item(" + deieteItem.Combo_Description + ") deleted successfully");
                        }
                        else
                        {
                            MessageBox.Show("Error:Stock item does not exist/No stock item selected,select a stock item");
                        }

                    }

                }
                else if (e.ClickedItem.Name.ToString() == "View")
                {
                    Globals.menu.Hide();
                    int id = Globals.Combopassing;
                    Combo item = db.Comboes.FirstOrDefault(c => c.Combo_ID == id);
                    if (item != null)
                    {
                         frmMaintainCombo form  = new frmMaintainCombo();
                         form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Error:Stock item does not exist/No stock item selected,select a stock item");
                    }

                }
            }

            if (navButton == btnCombo)
            {

                if (e.ClickedItem.Name.ToString() == "Deleted")
                {
                    Globals.menu.Hide();
                    if (dgvSupplier.Rows.Count != 0)
                    {
                        int id = Globals.Combopassing;

                        Combo deieteItem = db.Comboes.FirstOrDefault(c => c.Combo_ID == id);

                        if (deieteItem != null)
                        {
                            db.Comboes.Remove(deieteItem);
                            db.SaveChanges();
                            MessageBox.Show("Stock item(" + deieteItem.Combo_Description + ") deleted successfully");
                        }
                        else
                        {
                            MessageBox.Show("Error:Stock item does not exist/No stock item selected,select a stock item");
                        }

                    }

                }
                else if (e.ClickedItem.Name.ToString() == "View")
                {
                    Globals.menu.Hide();
                    int id = Globals.Combopassing;
                    Combo item = db.Comboes.FirstOrDefault(c => c.Combo_ID == id);
                    if (item != null)
                    {
                        frmMaintainCombo form = new frmMaintainCombo();
                        form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Error:Stock item does not exist/No stock item selected,select a stock item");
                    }

                }
            }

            //Stock Management Click Event Handlers
            //
            //-----------------------------------------------------------------------------------------------------//
            if (e.ClickedItem.Name.ToString() == "View" )
            {
                Globals.menu.Hide();

                int id = Globals.MStockpassing;
                Stock_Item itemEdited = db.Stock_Item.FirstOrDefault(c => c.Stock_ID ==id );
                if (itemEdited !=null)
                {
                    Maintain_Stock_Item myform = new Maintain_Stock_Item();
                    myform.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Error:Stock item does not exist/No stock item selected,select a stock item");
                }
                


                
            }

            else if (e.ClickedItem.Name.ToString() == "Check In")
            {
                Globals.menu.Hide();
                int id = Globals.MStockpassing;
                Stock_Item itemEdited = db.Stock_Item.FirstOrDefault(c => c.Stock_ID == id);
                if (itemEdited.Stock_Type_ID == 1)
                {
                    if (itemEdited != null)
                    {
                        Check_In_Stock_Item myform = new Check_In_Stock_Item();
                        myform.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Error:Stock item does not exist/No stock item selected,select a stock item");
                    }
                }
                else
                {
                    MessageBox.Show("Action not allowed in such stock item");
                }
            }

            else if (e.ClickedItem.Name.ToString() == "Check Out")
            {
                Globals.menu.Hide();
                int id = Globals.MStockpassing;
                Stock_Item itemEdited = db.Stock_Item.FirstOrDefault(c => c.Stock_ID == id);
                if (itemEdited.Stock_Type_ID == 1)
                {
                    if (itemEdited != null)
                    {
                        Check_Out_Stock_Item myform = new Check_Out_Stock_Item();
                        myform.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Error:Stock item does not exist/No stock item selected,select a stock item");
                    }
                }
                else
                {
                    MessageBox.Show("Action not allowed in such stock item");
                }
            }

            else if (e.ClickedItem.Name.ToString() == "Take")
            {
                Globals.menu.Hide();
                int id = Globals.MStockpassing;
                Stock_Item itemEdited = db.Stock_Item.FirstOrDefault(c => c.Stock_ID == id);
                if (itemEdited != null)
                {
                    Take_Stock_Item myform = new Take_Stock_Item();
                    myform.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Error:Stock item does not exist/No stock item selected,select a stock item");
                }
            }
            else if (e.ClickedItem.Name.ToString() == "Write Off")
            {
                Globals.menu.Hide();
                int id = Globals.MStockpassing;
                Stock_Item itemEdited = db.Stock_Item.FirstOrDefault(c => c.Stock_ID == id);
                if (itemEdited != null)
                {
                    Write_Off_stock_Item myform = new Write_Off_stock_Item();
                    myform.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Error:Stock item does not exist/No stock item selected,select a stock item");
                    
                }
            }

        }

        /*Employee Grid Mouse Click Func*/

        void employeeClick(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip myMenu = new System.Windows.Forms.ContextMenuStrip();
                int position_xy__row = dgvSupplier.HitTest(e.X, e.Y).RowIndex;
                if (position_xy__row >= 0)
                {
                    myMenu.Items.Add("Delete").Name = "Deleted";
                    myMenu.Items.Add("View").Name = "View";
                }


                myMenu.Show(dgvSupplier, new Point(e.X, e.Y));
                myMenu.ItemClicked += new ToolStripItemClickedEventHandler(myMenu_ItemClicked);
                Globals.menu = myMenu;

            }
        }



        /*Customer Grid Mouse Click Func*/

        void customerClick(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip myMenu = new System.Windows.Forms.ContextMenuStrip();
                int position_xy__row = dgvSupplier.HitTest(e.X, e.Y).RowIndex;
                if (position_xy__row >= 0)
                {
                    myMenu.Items.Add("Delete").Name = "Deleted";
                    myMenu.Items.Add("View").Name = "View";
                }


                myMenu.Show(dgvSupplier, new Point(e.X, e.Y));
                myMenu.ItemClicked += new ToolStripItemClickedEventHandler(myMenu_ItemClicked);
                Globals.menu = myMenu;

            }
        }

        /*Sales Grid Mouse Click Func*/

        void salesClick(Object sender, MouseEventArgs e)
        {
            
            
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip myMenu = new System.Windows.Forms.ContextMenuStrip();
                int position_xy__row = dgvSupplier.HitTest(e.X, e.Y).RowIndex;
                if (position_xy__row >= 0)
                {
                    myMenu.Items.Add("Delete").Name = "Deleted";
                    myMenu.Items.Add("View").Name = "View";
                }


                myMenu.Show(dgvSupplier, new Point(e.X, e.Y));
                myMenu.ItemClicked += new ToolStripItemClickedEventHandler(myMenu_ItemClicked);
                Globals.menu = myMenu;

            }
        }


        /*Menu Grid Mouse Click Func*/

        void Menu(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip myMenu = new System.Windows.Forms.ContextMenuStrip();
                int position_xy__row = dgvSupplier.HitTest(e.X, e.Y).RowIndex;
                if (position_xy__row >= 0)
                {
                    myMenu.Items.Add("Delete").Name = "Deleted";
                    myMenu.Items.Add("View").Name = "View";
                }


                myMenu.Show(dgvSupplier, new Point(e.X, e.Y));
                myMenu.ItemClicked += new ToolStripItemClickedEventHandler(myMenu_ItemClicked);
                Globals.menu = myMenu;

            }
        }

        /*Combo Grid Mouse Click Func*/

        void comboClick(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip myMenu = new System.Windows.Forms.ContextMenuStrip();
                int position_xy__row = dgvSupplier.HitTest(e.X, e.Y).RowIndex;
                if (position_xy__row >= 0)
                {
                    myMenu.Items.Add("Delete").Name = "Deleted";
                    myMenu.Items.Add("View").Name = "View";
                }


                myMenu.Show(dgvSupplier, new Point(e.X, e.Y));
                myMenu.ItemClicked += new ToolStripItemClickedEventHandler(myMenu_ItemClicked);
                Globals.menu = myMenu;
            }
        }


        /*Combo Grid Mouse Click Func*/

        void supplierClick(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip myMenu = new System.Windows.Forms.ContextMenuStrip();
                int position_xy__row = dgvSupplier.HitTest(e.X, e.Y).RowIndex;
                if (position_xy__row >= 0)
                {
                    myMenu.Items.Add("Delete").Name = "Deleted";
                    myMenu.Items.Add("View").Name = "View";
                }


                myMenu.Show(dgvSupplier, new Point(e.X, e.Y));
                myMenu.ItemClicked += new ToolStripItemClickedEventHandler(myMenu_ItemClicked);
                Globals.menu = myMenu;
            }
        }



        void Stock_mouse_click(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip myMenu = new System.Windows.Forms.ContextMenuStrip();
                int position_xy__row = dgvSupplier.HitTest(e.X, e.Y).RowIndex;
                if (position_xy__row >= 0)
                {
                    myMenu.Items.Add("Maintain").Name = "View";
                    myMenu.Items.Add("Check In").Name = "Check In";
                    myMenu.Items.Add("Check Out").Name = "Check Out";
                    myMenu.Items.Add("Take").Name = "Take";
                    myMenu.Items.Add("Write Off").Name = "Write Off";


                }

                frmAdd_New_Stock_Item myform = new frmAdd_New_Stock_Item();

                myMenu.Show(dgvSupplier, new Point(e.X, e.Y));
                myMenu.ItemClicked += new ToolStripItemClickedEventHandler(myMenu_ItemClicked);
                Globals.menu = myMenu;
                
            }

        }





      
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            
        }

        private void empBtn_Click(object sender, EventArgs e)
        {
            header.Text = "Employee";


         
            if (navButton != btnEmployees)
            {
                navigate(btnEmployees);
            }

            var customers = from p in db.Employees
                            select new
                            {
                                EmpId = p.Employee_ID,
                                EmpName = p.Employee_Name,
                                EmpSurname = p.Employee_Surname,
                                EmpIdentity = p.Employee_Identity_Number,
                                Adress = p.Adress,
                                EmailAdree = p.Email_Adress,
                                ContactNo = p.Contact_Number,
                                NextOfKinName = p.Next_Of_Kin_Name,
                                NextOfKinNumber = p.Next_Of_Kin_Contact_Number,
                                GenderId = p.Gender_ID,
                                UserId = p.User_ID

                            };
            dgvSupplier.DataSource = customers.ToList();
            dgvSupplier.ClearSelection();
            db.SaveChanges();
            //if (dgvSupplier.Rows.Count != 0)
            //{
            //    Globals.Employeepassing = dgvSupplier.Rows[0].Cells[0].Value;
            //}
            dgvSupplier.MouseClick += new MouseEventHandler(employeeClick);
        }

        private void clientBtn_Click(object sender, EventArgs e)
        {
            header.Text = "Customer";



            if (navButton != btnCustomer)
            {
                navigate(btnCustomer);
            }

            var customers = from p in db.Customers
                            select new
                            {
                                CustomerId = p.Customer_ID,
                                CustomerName = p.Customer_Name,
                                CustomerSurname = p.Customer_Surname,
                                CustContactNo = p.Customer_Contact_Number,
                                CustomerAdress = p.Customer_Adress,
                                SuburbId = p.Suburb_ID,
                                CityId = p.City_ID


                            };
            dgvSupplier.DataSource = customers.ToList();
            dgvSupplier.ClearSelection();
            db.SaveChanges();
            //if (dgvSupplier.Rows.Count != 0)
            //{
            //    Globals.Customerpassing = dgvSupplier.Rows[0].Cells[0].Value;
            //}
            dgvSupplier.MouseClick += new MouseEventHandler(customerClick);
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            header.Text = "Stock";
            btnTheAdd.Text = "Add Stock Item";
            if (navButton != btnStock)
            {
                navigate(btnStock);
            }

            var customers = from p in db.Stock_Item
                            select new
                            {
                                StockId = p.Stock_ID,
                                StockItemName = p.Stock_Item_Name,
                                Quantity = p.Stock_Item_Quantity,
                                Description = p.Stock_Item_Description,
                                StockTypeId = p.Stock_Type_ID,
                                StockPriceId = p.Stock_Price_ID,
                                //ItemWrietOffId = p.Write_Off_ID

                            };
         
            dgvSupplier.DataSource = customers.ToList();
            dgvSupplier.ClearSelection();
            db.SaveChanges();
            //if (dgvSupplier.Rows.Count != 0)
            //{
               
            //    Globals.MStockpassing = dgvSupplier.Rows[0].Cells[0].Value;
            //}
            dgvSupplier.MouseClick += new MouseEventHandler(Stock_mouse_click);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            header.Text = "Combo";

            if (navButton != btnCombo)
            {
                navigate(btnCombo);
            }

            var customers = from p in db.Comboes
                            select new
                            {
                                ComboId = p.Combo_ID,
                                Description = p.Combo_Description,
                                ComboPrice = p.Combo_Price,
                                ComboTypeId = p.Combo_Type_ID,
                                ComboPriceId = p.Combo_Price_ID

                            };
            dgvSupplier.DataSource = customers.ToList();
            dgvSupplier.ClearSelection();
            db.SaveChanges();
            //if (dgvSupplier.Rows.Count != 0)
            //{
            //    Globals.Combopassing = dgvSupplier.Rows[0].Cells[0].Value;
            //}

            dgvSupplier.MouseClick += new MouseEventHandler(comboClick);
        }

        private void jobOBtn_Click(object sender, EventArgs e)
        {
            header.Text = "Menu";

            if (navButton != btnMenu)
            {
                navigate(btnMenu);
            }

            var customers = from p in db.Menu_Item
                            select new
                            {
                                MenuItemId = p.Menu_Item_ID,
                                MenuItemName = p.Menu_Item_Name,
                                MeniItemDescription = p.Menu_Item_Description,
                                MenuItemPrice = p.Menu_Item_Price,
                                MenuItemTypeId = p.Menu_Item_Type_ID,
                                MenuPriceId = p.Menu_Price_ID
                               

                            };
            dgvSupplier.DataSource = customers.ToList();
            dgvSupplier.ClearSelection();
            db.SaveChanges();
            //if (dgvSupplier.Rows.Count != 0)
            //{
            //    Globals.MenuCombopassing = dgvSupplier.Rows[0].Cells[0].Value;
            //}

            dgvSupplier.MouseClick += new MouseEventHandler(Menu);
        }

        private void quoteBtn_Click(object sender, EventArgs e)
        {
            header.Text = "Orders";



            if (navButton != btnSalesOrders)
            {
                navigate(btnSalesOrders);
            }

            var customers = from p in db.Customer_Order
                            select new
                            {
                                OrderId = p.Order_ID,
                                OrderStatus = p.Order_Status,
                                OrderDate = p.Order_Date,
                                SaleVatAmount = p.Sale_Vat_Amount,
                                CustomerId = p.Customer_ID,
                                PaymentId = p.Payment_ID,
                                EmployeeId = p.Employee_ID,
                                DeliveryStausId = p.Delivery_Status_ID

                            };
            dgvSupplier.DataSource = customers.ToList();
            dgvSupplier.ClearSelection();
            db.SaveChanges();
            //if (dgvSupplier.Rows.Count != 0)
            //{
            //    Globals.Salespassing = dgvSupplier.Rows[0].Cells[0].Value;
            //}
            dgvSupplier.MouseClick += new MouseEventHandler(salesClick);
        }

        private void btnSuppliers11_Click(object sender, EventArgs e)
        {
            header.Text = "Suppliers";



            if (navButton != btnSuppliers11)
            {
                navigate(btnSuppliers11);
            }

            var customers = from p in db.Suppliers
                            select new
                            {
                                SupplierId = p.Supllier_ID,
                                SupplierName = p.Supplier_Name,
                                AdressId = p.Address_ID,
                                SupplierTypeId = p.Supplier_Type_ID,
                                

                            };
            dgvSupplier.DataSource = customers.ToList();
            dgvSupplier.ClearSelection();
            db.SaveChanges();
            //if (dgvSupplier.Rows.Count != 0)
            //{
            //    Globals.Supplierpassing = dgvSupplier.Rows[0].Cells[0].Value;
            //}
            dgvSupplier.MouseClick += new MouseEventHandler(supplierClick);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            if(navButton == btnStock)
            {
                frmAdd_New_Stock_Item frm = new frmAdd_New_Stock_Item();
                frm.ShowDialog();

            }

            else if(navButton == btnMenu)
            {
                Menu_And_Combo form = new Menu_And_Combo();
                form.ShowDialog();

            }
        }
       

        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

          
        }

        private void button11_Click(object sender, EventArgs e)
        {

            
           
        }

        private void txtSearchNew_TextChanged(object sender, EventArgs e)
        {
            if (navButton == btnStock)
            {
                int id=900000000;
                double Quantity=9000000000;
                if (!(txtSearchNew.Text == ""))
                {
                    int number;
                    bool result = Int32.TryParse(txtSearchNew.Text, out number);
                    if (result)
                    {
                        // Conversion to a number was successful.
                        // The number variable contains your value. 
                        id = Convert.ToInt32(txtSearchNew.Text);
                        Quantity = (Convert.ToDouble(txtSearchNew.Text));
                    }
                    else
                    {
                        id = 900000000;
                        Quantity = 9000000000;

                    }
                    dgvSupplier.DataSource = db.Stock_Item.Where(c => c.Stock_ID == id || c.Stock_Item_Name.Contains(txtSearchNew.Text)
                    || c.Stock_Item_Description.Contains(txtSearchNew.Text) || c.Stock_Item_Quantity == Quantity).ToList();
                }

                else
                {

                    dgvSupplier.DataSource = db.Stock_Item.ToList();
                }

              
            }


            if (navButton == btnCombo)
            {
                int id = 900000000;
                double Price = 9000000000;
                if (!(txtSearchNew.Text == ""))
                {
                    int number;
                    bool result = Int32.TryParse(txtSearchNew.Text, out number);
                    if (result)
                    {
                        // Conversion to a number was successful.
                        // The number variable contains your value. 
                        id = Convert.ToInt32(txtSearchNew.Text);
                        Price = (Convert.ToDouble(txtSearchNew.Text));
                    }
                    else
                    {
                        id = 900000000;
                        Price = 9000000000;

                    }
                    dgvSupplier.DataSource = db.Comboes.Where(c => c.Combo_ID == id || c.Combo_Price == Price || c.Combo_Description.Contains(txtSearchNew.Text)
                    ).ToList();
                }

                else
                {

                    dgvSupplier.DataSource = db.Stock_Item.ToList();
                }


            }

            dgvSupplier.ClearSelection();
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (navButton == btnStock)
            {
                if (dgvSupplier.SelectedRows.Count > 0)
                {
                    int rowindex = dgvSupplier.CurrentCell.RowIndex;
                    Globals.MStockpassing = dgvSupplier.Rows[rowindex].Cells[0].Value;
                }
         
            }
            else if (navButton == btnMenu)
            {
                if (dgvSupplier.SelectedRows.Count > 0)
                { 
                int rowindex = dgvSupplier.CurrentCell.RowIndex;
                Globals.MenuCombopassing = dgvSupplier.Rows[rowindex].Cells[0].Value;
            }
            }

            else if (navButton == btnSuppliers11)
            {
                if (dgvSupplier.SelectedRows.Count > 0)
                {
                    int rowindex = dgvSupplier.CurrentCell.RowIndex;
                    Globals.Supplierpassing = dgvSupplier.Rows[rowindex].Cells[0].Value;
                }
            }

            else if (navButton == btnEmployees)
            {
                if (dgvSupplier.SelectedRows.Count > 0)
                {
                    int rowindex = dgvSupplier.CurrentCell.RowIndex;
                    Globals.Employeepassing = dgvSupplier.Rows[rowindex].Cells[0].Value;
                }
            }

            else if (navButton == btnCustomer)
            {
                if (dgvSupplier.SelectedRows.Count > 0)
                {
                    int rowindex = dgvSupplier.CurrentCell.RowIndex;
                    Globals.Customerpassing = dgvSupplier.Rows[rowindex].Cells[0].Value;
                }
            }

            else if (navButton == btnSalesOrders)
            {
                if (dgvSupplier.SelectedRows.Count > 0)
                {
                    int rowindex = dgvSupplier.CurrentCell.RowIndex;
                    Globals.Salespassing = dgvSupplier.Rows[rowindex].Cells[0].Value;
                }
            }

            else if (navButton == btnCombo)
            {
                if (dgvSupplier.SelectedRows.Count > 0)
                {
                    int rowindex = dgvSupplier.CurrentCell.RowIndex;
                    Globals.MenuCombopassing = dgvSupplier.Rows[rowindex].Cells[0].Value;
                }
            }

        }

        private void dgvSupplier_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Globals.refresher == true)
            {
                if (navButton == btnStock)
                {
                    var customers = from p in db.Stock_Item
                                    select new
                                    {
                                        StockId = p.Stock_ID,
                                        StockItemName = p.Stock_Item_Name,
                                        Quantity = p.Stock_Item_Quantity,
                                        Description = p.Stock_Item_Description,
                                        StockTypeId = p.Stock_Type_ID,
                                        StockPriceId = p.Stock_Price_ID,
                                      

                                    };

                    dgvSupplier.DataSource = customers.ToList();
                    dgvSupplier.ClearSelection();
                    db.SaveChanges();
                }
                else if (navButton == btnSuppliers11)
                {
                    var customers = from p in db.Suppliers
                                    select new
                                    {
                                        SupplierId = p.Supllier_ID,
                                        SupplierName = p.Supplier_Name,
                                        AdressId = p.Address_ID,
                                        SupplierTypeId = p.Supplier_Type_ID,


                                    };
                    dgvSupplier.DataSource = customers.ToList();
                    dgvSupplier.ClearSelection();
                    db.SaveChanges();
                }

                else if (navButton == btnEmployees)
                {
                    var customers = from p in db.Employees
                                    select new
                                    {
                                        EmpId = p.Employee_ID,
                                        EmpName = p.Employee_Name,
                                        EmpSurname = p.Employee_Surname,
                                        EmpIdentity = p.Employee_Identity_Number,
                                        Adress = p.Adress,
                                        EmailAdree = p.Email_Adress,
                                        ContactNo = p.Contact_Number,
                                        NextOfKinName = p.Next_Of_Kin_Name,
                                        NextOfKinNumber = p.Next_Of_Kin_Contact_Number,
                                        GenderId = p.Gender_ID,
                                        UserId = p.User_ID

                                    };
                    dgvSupplier.DataSource = customers.ToList();
                    dgvSupplier.ClearSelection();
                    db.SaveChanges();
                }

                else if (navButton == btnCustomer)
                {
                    dgvSupplier.DataSource = db.Customers.ToList();
                    db.SaveChanges();
                }

                else if (navButton == btnSalesOrders)
                {
                    var customers = from p in db.Customer_Order
                                    select new
                                    {
                                        OrderId = p.Order_ID,
                                        OrderStatus = p.Order_Status,
                                        OrderDate = p.Order_Date,
                                        SaleVatAmount = p.Sale_Vat_Amount,
                                        CustomerId = p.Customer_ID,
                                        PaymentId = p.Payment_ID,
                                        EmployeeId = p.Employee_ID,
                                        DeliveryStausId = p.Delivery_Status_ID

                                    };
                    dgvSupplier.DataSource = customers.ToList();
                    dgvSupplier.ClearSelection();
                    db.SaveChanges();
                }

                else if (navButton == btnMenu)
                {
                    var customers = from p in db.Menu_Item
                                    select new
                                    {
                                        MenuItemId = p.Menu_Item_ID,
                                        MenuItemName = p.Menu_Item_Name,
                                        MeniItemDescription = p.Menu_Item_Description,
                                        MenuItemPrice = p.Menu_Item_Price,
                                        MenuItemTypeId = p.Menu_Item_Type_ID,
                                        MenuPriceId = p.Menu_Price_ID


                                    };
                    dgvSupplier.DataSource = customers.ToList();
                    dgvSupplier.ClearSelection();
                    db.SaveChanges();
                }
                else if (navButton == btnCombo)
                {
                    var customers = from p in db.Comboes
                                    select new
                                    {
                                        ComboId = p.Combo_ID,
                                        Description = p.Combo_Description,
                                        ComboPrice = p.Combo_Price,
                                        ComboTypeId = p.Combo_Type_ID,
                                        ComboPriceId = p.Combo_Price_ID

                                    };
                    dgvSupplier.DataSource = customers.ToList();
                    dgvSupplier.ClearSelection();
                    db.SaveChanges();
                }
                Globals.refresher = false;
               
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
///////////////////////////////////////////////////////////////////////////////////////////////////
using MySql.Data.MySqlClient;

namespace WarehouseManager
{
    public partial class Inventory : Form
    {
        private MySqlConnection _connection;
        private MySqlCommand _command;
        private string _empName;
        private int _pId;
        private MySqlDataAdapter _dgvFill;
        private int _searchProduct;

        public Inventory(MySqlConnection conn, MySqlCommand cmd, string empName, int permId)
        {
            InitializeComponent();
            _connection = conn;
            _command = cmd;
            _empName = empName;
            _pId = permId;
            staInventory.Items["tslLoggedUser"].Text = empName;

            if (_pId > 3)
            {
                logOutToolStripMenuItem.Enabled = false;
                quitToolStripMenuItem.Visible = true;
                ControlBox = false;
            }
            else
            {
                logOutToolStripMenuItem.Enabled = true;
                quitToolStripMenuItem.Visible = false;
            }
            if (_connection.State == ConnectionState.Open)
            {
                staInventory.Items["tslServerStatus"].Text = @"Connected";
                staInventory.Items["tslServerStatus"].ForeColor = Color.Green;

                connectToolStripMenuItem.Enabled = false;
                disconnectToolStripMenuItem.Enabled = true;
            }
            else
            {
                staInventory.Items["tslServerStatus"].Text = @"Disconnected";
                staInventory.Items["tslServerStatus"].ForeColor = Color.OrangeRed;

                connectToolStripMenuItem.Enabled = true;
                disconnectToolStripMenuItem.Enabled = false;
            }
        }

        public Inventory()
        {
            InitializeComponent();
        }

        //I HAVE TO FORCE CONNECTION UP AND DOWN FOR RELOAD BUTTON... I THINK????
        private bool OpenConnection()
        {
            try
            {
                _connection.Open();
                return true;
            }
            catch (MySqlException)
            {
                return false;
            }
        }

        private void Inventory_Load()
        {
            //const string server = "192.168.1.78";
            const string server = "173.180.133.176";
            const string db = "hi-tec";
            const string id = "root";
            const string pass = "superpassword";
            const string port = "3306";

            const string connectionString = "SERVER=" + server + ";PORT=" + port + ";DATABASE=" + db + ";UID=" + id + ";PASSWORD=" + pass + ";";
            _connection = new MySqlConnection(connectionString);

            //User permission verification to display inventory information on DVG
            if (OpenConnection())
            {
                if (_pId <= 3)
                {
                    _dgvFill = new MySqlDataAdapter("SELECT P.product_id AS SKU, P.product_name AS PRODUCTNAME, P.product_stock AS STOCK, SH.shelf_number AS SHELFNUM, AI.aisle_number AS AISLENUM, SE.section_name AS SECTIONNAME FROM product AS P INNER JOIN shelf AS SH ON P.shelf_id = SH.shelf_id INNER JOIN aisle AS AI ON SH.aisle_id = AI.aisle_id INNER JOIN section AS SE ON AI.section_id = SE.section_id", _connection);
                    DataSet DS = new DataSet();
                    _dgvFill.Fill(DS);
                    dgvInvDisplay.DataSource = DS.Tables[0];
                }
                else
                {
                    _dgvFill = new MySqlDataAdapter("SELECT P.product_id AS SKU, P.product_name AS PRODUCTNAME, P.product_stock AS STOCK, M.manufacturer_name AS MANUFACTURER, P.product_price as PRICE, SH.shelf_number AS SHELFNUM, AI.aisle_number AS AISLENUM, SE.section_name AS SECTIONNAME FROM product AS P INNER JOIN shelf AS SH ON P.shelf_id = SH.shelf_id INNER JOIN aisle AS AI ON SH.aisle_id = AI.aisle_id INNER JOIN section AS SE ON AI.section_id = SE.section_id INNER JOIN manufacturer AS M ON P.manufacturer_id = M.manufacturer_id ORDER BY SKU", _connection);
                    DataSet DS = new DataSet();
                    _dgvFill.Fill(DS);
                    dgvInvDisplay.DataSource = DS.Tables[0];
                }
            }
        }
        //I am worlds greatest programmer
        private void refresh_Click_1(object sender, EventArgs e)
        {
            Inventory_Load();
	        tscTxtSearch.Text = "";
        }

        private void Inventory_Load_1(object sender, EventArgs e)
        {
            Inventory_Load();
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////
        //Menu Control, User Information & Status Display Components

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _connection?.Close();
            Hide();
            var login = new FormMain();
            login.Closed += (s, args) => Close();
            login.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new WarehouseAppAbout();
            about.Closed += (s, args) => Close();
            about.Show();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_connection.State != ConnectionState.Closed) return;
            //const string server = "192.168.1.78";
            const string server = "173.180.133.176";
            const string db = "hi-tec";
            const string id = "root";
            const string pass = "superpassword";
            const string port = "3306";

            const string connectionString = "SERVER=" + server + ";PORT=" + port + ";DATABASE=" + db + ";UID=" + id + ";PASSWORD=" + pass + ";";
            _connection = new MySqlConnection(connectionString);

            _connection.Open();

            staInventory.Items["tslServerStatus"].Text = @"Connected";
            staInventory.Items["tslServerStatus"].ForeColor = Color.Green;

            connectToolStripMenuItem.Enabled = false;
            disconnectToolStripMenuItem.Enabled = true;
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _connection?.Close();

            staInventory.Items["tslServerStatus"].Text = @"Disconnected";
            staInventory.Items["tslServerStatus"].ForeColor = Color.OrangeRed;

            connectToolStripMenuItem.Enabled = true;
            disconnectToolStripMenuItem.Enabled = false;
        }

        //Auto Resize Column Width after Data Binding is completed
        private void dgvInvDisplay_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvInvDisplay.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void tscBtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                _searchProduct = short.Parse(tscTxtSearch.Text);
                DisplayOrder(_searchProduct);
            }
            catch (FormatException) //for shitty inputs
            {
                MessageBox.Show(@"Please use proper syntax", @"Improper Syntax", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex) //for no rows/order
            {
                MessageBox.Show(ex.Message, @"Incorrect Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayOrder(int SKU)
        {
            if (_pId <= 3)
            {
                var query = "SELECT P.product_id AS SKU, P.product_name AS PRODUCTNAME, P.product_stock AS STOCK, SH.shelf_number AS SHELFNUM, AI.aisle_number AS AISLENUM, SE.section_name AS SECTIONNAME FROM product AS P INNER JOIN shelf AS SH ON P.shelf_id = SH.shelf_id INNER JOIN aisle AS AI ON SH.aisle_id = AI.aisle_id INNER JOIN section AS SE ON AI.section_id = SE.section_id";
                query += " WHERE P.product_id = '" + SKU + "'";

                var DS = new DataSet();
                dgvInvDisplay.DataSource = null;

                var mda = new MySqlDataAdapter(query, _connection);
                mda.Fill(DS, "SKU");

                dgvInvDisplay.DataSource = DS.Tables[0];

                //Check for empty result meaning no record found
                if (DS.Tables["SKU"].Rows.Count == 0)
                {
                    tscTxtSearch.Text = "";
                    throw new ArgumentException("No product with the ID " + SKU + " was found.");
                }

            }
            else
            {
                var query = "SELECT P.product_id AS SKU, P.product_name AS PRODUCTNAME, P.product_stock AS STOCK, M.manufacturer_name AS MANUFACTURER, P.product_price as PRICE, SH.shelf_number AS SHELFNUM, AI.aisle_number AS AISLENUM, SE.section_name AS SECTIONNAME FROM product AS P INNER JOIN shelf AS SH ON P.shelf_id = SH.shelf_id INNER JOIN aisle AS AI ON SH.aisle_id = AI.aisle_id INNER JOIN section AS SE ON AI.section_id = SE.section_id INNER JOIN manufacturer AS M ON P.manufacturer_id = M.manufacturer_id";
                query += " WHERE P.product_id = '" + SKU + "'";

                var DS = new DataSet();
                dgvInvDisplay.DataSource = null;

                var mda = new MySqlDataAdapter(query, _connection);
                mda.Fill(DS, "SKU");

                dgvInvDisplay.DataSource = DS.Tables[0];

                //Check for empty result meaning no record found
                if (DS.Tables["SKU"].Rows.Count == 0)
                {
                    tscTxtSearch.Text = "";
                    throw new ArgumentException("No product with the ID " + SKU + " was found.");
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterBill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int AccountType = 1;
        static List<Account> accountsList = new List<Account>();
        static int selectedIndex = -1;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Calculate the center position of the screen
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int formWidth = this.Width;
            int formHeight = this.Height;

            int left = (screenWidth - formWidth) / 2;
            int top = (screenHeight - formHeight) / 2;

            // Set the form's location to center screen
            this.Location = new Point(left, top);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            cbxHouseHolde.Checked = true;

            cbxBusinees.Checked = false;
            cbxBusinees.Checked = false;
            cbxGovernane.Checked = false;
            /*   cbxBusinees.CheckedChanged += checkBox_CheckedChanged;
               cbxHouseHolde.CheckedChanged += checkBox_CheckedChanged;
               cbxManuafacture.CheckedChanged += checkBox_CheckedChanged;
               cbxGovernane.CheckedChanged += checkBox_CheckedChanged;*/

            LoadDataGridView();

            dataGridView1.CellClick += DataGridView1_CellClick;


        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Check if a valid cell was clicked
            {
                DataGridViewCell clickedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Access the value of the clicked cell
                object cellValue = clickedCell.Value;

                // Do something with the cell value
                MessageBox.Show("Clicked row index Value: " + e.RowIndex);


                Account accountSelected = accountsList[e.RowIndex];


                selectedIndex = e.RowIndex;

                txtName.Text = accountSelected.Name;
                txtIndexLast.Text = accountSelected.LastMonthIndex.ToString();
                txtIndexThis.Text = accountSelected.ThisMonthIndex.ToString();
                txtPeopleCount.Text = accountSelected.PeopleCount.ToString();

                int AccountType = accountSelected.AccountType;

                switch (AccountType)
                {
                    case 1:
                        cbxHouseHolde.Checked = true;
                        cbxManuafacture.Checked = false;
                        cbxBusinees.Checked = false;
                        cbxGovernane.Checked = false;
                        break;

                    case 2:
                        cbxHouseHolde.Checked = false;
                        cbxManuafacture.Checked = false;
                        cbxBusinees.Checked = true;
                        cbxGovernane.Checked = false;
                        break;

                    case 3:
                        cbxHouseHolde.Checked = false;
                        cbxManuafacture.Checked = false;
                        cbxBusinees.Checked = false;
                        cbxGovernane.Checked = true;
                        break;
                    case 4:
                        cbxHouseHolde.Checked = false;
                        cbxManuafacture.Checked = true;
                        cbxBusinees.Checked = false;
                        cbxGovernane.Checked = false;

                        break;
                }



            }
        }


        private void LoadDataGridView()
        {

            // Create columns
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.HeaderText = "Name";
            column1.Name = "Name";

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.HeaderText = "LastMonthIndex";
            column2.Name = "LastMonthIndex";

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.HeaderText = "ThisMonthIndex";
            column3.Name = "ThisMonthIndex";

            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.HeaderText = "AccountType";
            column4.Name = "AccountType";

            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            column5.HeaderText = "PeopleCount";
            column5.Name = "PeopleCount";


            DataGridViewTextBoxColumn column6 = new DataGridViewTextBoxColumn();
            column6.HeaderText = "AccountTypeString";
            column6.Name = "AccountTypeString";


            DataGridViewTextBoxColumn column7 = new DataGridViewTextBoxColumn();
            column7.HeaderText = "TotalIndex";
            column7.Name = "TotalIndex";

            DataGridViewTextBoxColumn column8 = new DataGridViewTextBoxColumn();
            column8.HeaderText = "Cost";
            column8.Name = "Cost";



            // Add columns to the DataGridView control
            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);
            dataGridView1.Columns.Add(column4);
            dataGridView1.Columns.Add(column5);
            dataGridView1.Columns.Add(column6);
            dataGridView1.Columns.Add(column7);
            dataGridView1.Columns.Add(column8);


            dataGridView1.Columns["Name"].DataPropertyName = "Name";
            dataGridView1.Columns["LastMonthIndex"].DataPropertyName = "LastMonthIndex";
            dataGridView1.Columns["ThisMonthIndex"].DataPropertyName = "ThisMonthIndex";
            dataGridView1.Columns["AccountType"].DataPropertyName = "AccountType";
            dataGridView1.Columns["PeopleCount"].DataPropertyName = "PeopleCount";
            dataGridView1.Columns["AccountTypeString"].DataPropertyName = "AccountTypeString";
            dataGridView1.Columns["TotalIndex"].DataPropertyName = "TotalIndex";
            dataGridView1.Columns["Cost"].DataPropertyName = "Cost";


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }





        }

      /*  private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox clickedCheckBox = (CheckBox)sender;

            if (clickedCheckBox.Checked)
            {
                // Uncheck all other checkboxes except the clicked one
                foreach (Control control in Controls)
                {
                    if (control is CheckBox checkBox && checkBox != clickedCheckBox)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
        }*/

        private void button1_Click(object sender, EventArgs e)
        {

            string username = txtName.Text;
            double lastMonthIndex = double.Parse(txtIndexLast.Text);

            double thisMonthIndex = double.Parse(txtIndexThis.Text);

            int peopleCount = 0;
            try
            {
                peopleCount = int.Parse(txtPeopleCount.Text);

            }
            catch (Exception ex)
            {

            }
                

            int accountType = AccountType;
            Account account = new Account();
            account.Name = username;
            account.AccountType = accountType;
            account.LastMonthIndex = lastMonthIndex;
            account.ThisMonthIndex = thisMonthIndex;
            account.PeopleCount = peopleCount;
            account.TotalIndex = thisMonthIndex - lastMonthIndex;


            switch (accountType)
            {
                case 1:
                    double Consump = (thisMonthIndex - lastMonthIndex) / peopleCount;
                    account.AccountTypeString = "HouseHold";
                    if (Consump <= 10)
                    {
                        account.Cost = Consump * 5973;
                    }
                    else if (Consump <= 20)
                    {
                        account.Cost = Consump * 7052;
                    }
                    else if (Consump <= 30)
                    {
                        account.Cost = Consump * 8699;
                    }
                    else
                    {
                        account.Cost = Consump * 15929;
                    }

                    break;
                case 2:
                    account.AccountTypeString = "Business";
                account.Cost = (thisMonthIndex - lastMonthIndex) * 9955;

                    break;
                case 3:
                    account.AccountTypeString = "Goverment";
                    account.Cost = (thisMonthIndex - lastMonthIndex) * 11615;

                    break;
                case 4:
                    account.AccountTypeString = "Manuafacture";
                    account.Cost = (thisMonthIndex - lastMonthIndex) * 22068;

                    break;



            }

            accountsList.Add(account);

            dataGridView1.DataSource = null; 

            dataGridView1.DataSource = accountsList;


        }

        private void cbxHouseHolde_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox clickedCheckBox = (CheckBox)sender;

            if (clickedCheckBox.Checked)
            {
                // Uncheck all other checkboxes except the clicked one
                foreach (Control control in Controls)
                {
                    if (control is CheckBox checkBox && checkBox != clickedCheckBox)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
            //cbxHouseHolde.Checked = true;

            AccountType = 1;
            cbxManuafacture.Checked = false;
            cbxBusinees.Checked = false;
            cbxGovernane.Checked = false;

        }

        private void cbxBusinees_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox clickedCheckBox = (CheckBox)sender;

            if (clickedCheckBox.Checked)
            {
                // Uncheck all other checkboxes except the clicked one
                foreach (Control control in Controls)
                {
                    if (control is CheckBox checkBox && checkBox != clickedCheckBox)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
            AccountType = 2;

            //cbxBusinees.Checked = true;
            cbxHouseHolde.Checked = false;
            cbxManuafacture.Checked = false;
            cbxGovernane.Checked = false;
        }

        private void cbxGovernane_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox clickedCheckBox = (CheckBox)sender;

            if (clickedCheckBox.Checked)
            {
                // Uncheck all other checkboxes except the clicked one
                foreach (Control control in Controls)
                {
                    if (control is CheckBox checkBox && checkBox != clickedCheckBox)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
            AccountType = 3;

            cbxBusinees.Checked = false;
            cbxHouseHolde.Checked = false;
            cbxManuafacture.Checked = false;
            //cbxGovernane.Checked = true;
        }

        private void cbxManuafacture_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox clickedCheckBox = (CheckBox)sender;

            if (clickedCheckBox.Checked)
            {
                // Uncheck all other checkboxes except the clicked one
                foreach (Control control in Controls)
                {
                    if (control is CheckBox checkBox && checkBox != clickedCheckBox)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
            AccountType = 4;

            cbxBusinees.Checked = false;
            cbxHouseHolde.Checked = false;
            cbxGovernane.Checked = false;
            //cbxManuafacture.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string username = txtName.Text;
            double lastMonthIndex = double.Parse(txtIndexLast.Text);

            double thisMonthIndex = double.Parse(txtIndexThis.Text);

            int peopleCount = 0;
            try
            {
                peopleCount = int.Parse(txtPeopleCount.Text);

            }
            catch (Exception ex)
            {

            }


            int accountType = AccountType;
            Account account = new Account();
            account.Name = username;
            account.AccountType = accountType;
            account.LastMonthIndex = lastMonthIndex;
            account.ThisMonthIndex = thisMonthIndex;
            account.PeopleCount = peopleCount;
            account.TotalIndex = thisMonthIndex - lastMonthIndex;


            switch (accountType)
            {
                case 1:
                    double Consump = (thisMonthIndex - lastMonthIndex) / peopleCount;
                    account.AccountTypeString = "HouseHold";
                    if (Consump <= 10)
                    {
                        account.Cost = Consump * 5973;
                    }
                    else if (Consump <= 20)
                    {
                        account.Cost = Consump * 7052;
                    }
                    else if (Consump <= 30)
                    {
                        account.Cost = Consump * 8699;
                    }
                    else
                    {
                        account.Cost = Consump * 15929;
                    }

                    break;
                case 2:
                    account.AccountTypeString = "Business";
                    account.Cost = (thisMonthIndex - lastMonthIndex) * 9955;

                    break;
                case 3:
                    account.AccountTypeString = "Goverment";
                    account.Cost = (thisMonthIndex - lastMonthIndex) * 11615;

                    break;
                case 4:
                    account.AccountTypeString = "Manuafacture";
                    account.Cost = (thisMonthIndex - lastMonthIndex) * 22068;

                    break;

            }


            accountsList[selectedIndex].Name = account.Name;
            accountsList[selectedIndex].Cost = account.Cost;
            accountsList[selectedIndex].AccountTypeString = account.AccountTypeString;
            accountsList[selectedIndex].LastMonthIndex = account.LastMonthIndex;
            accountsList[selectedIndex].ThisMonthIndex = account.ThisMonthIndex;
            accountsList[selectedIndex].AccountType = account.AccountType;
            accountsList[selectedIndex].TotalIndex = account.TotalIndex;
            accountsList[selectedIndex].PeopleCount = account.PeopleCount;
            //Refrest datagridview

            dataGridView1.DataSource = null;

            dataGridView1.DataSource = accountsList;




        }

        private void button3_Click(object sender, EventArgs e)
        {
            accountsList.RemoveAt(selectedIndex);
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = accountsList;
        }
    }
}

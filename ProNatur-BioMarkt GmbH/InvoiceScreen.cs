using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatur_BioMarkt_GmbH
{
    public partial class InvoiceScreen : Form
    {
        private SqlConnection databaseConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Madarier\Documents\ProNatur-Biomarkt GmbH.mdf;Integrated Security = True; Connect Timeout = 30");
        private int lastSelectedInvoiceKey;
        public InvoiceScreen()
        {
            InitializeComponent();

            ShowInvoices();
        }

        private void btnInvoiceSave_Click(object sender, EventArgs e)
        {
            if (textBoxInvoiceReceiver.Text == ""
                || textBoxInvoiceBillText.Text == ""
                || textBoxInvoiceTotalPrice.Text == "")
            {
                MessageBox.Show("Bitte fülle alle Werte aus.");

                return;
            }
            // save product name in database
            string invoiceReceiver = textBoxInvoiceReceiver.Text;
            string invoiceBillText = textBoxInvoiceBillText.Text;
            string invoiceTotalPrice = textBoxInvoiceTotalPrice.Text;

            string query = string.Format("insert into Invoices values('{0}', '{1}', '{2}')", invoiceReceiver, invoiceBillText, invoiceTotalPrice);
            ExecuteQuery(query);

            ClearAllFields();
            ShowInvoices();
        }

        private void btnInvoiceEdit_Click(object sender, EventArgs e)
        {
            if (lastSelectedInvoiceKey == 0)
            {
                MessageBox.Show("Bitte wähle zuerst eine Rechnung aus");
                return;
            }

            // save product name in database
            string invoiceReceiver = textBoxInvoiceReceiver.Text;
            string invoiceBillText = textBoxInvoiceBillText.Text;
            string invoiceTotalPrice = textBoxInvoiceTotalPrice.Text;

            string query = string.Format("update Invoices set Receiver='{0}', BillText='{1}', TotalPrice='{2}' where Id={3}", 
                invoiceReceiver, invoiceBillText, invoiceTotalPrice, lastSelectedInvoiceKey);
            ExecuteQuery(query);

            ShowInvoices();
        }

        private void btnInvoiceClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void btnInvoiceDelete_Click(object sender, EventArgs e)
        {
            if (lastSelectedInvoiceKey == 0)
            {
                MessageBox.Show("Bitte wähle zuerst eine Rechnung aus");
                return;
            }
            string query = string.Format("delete from Invoices where Id={0};", lastSelectedInvoiceKey);
            ExecuteQuery(query);
            ClearAllFields();
            ShowInvoices();
        }

        private void btnInvoiceScreenBack_Click(object sender, EventArgs e)
        {
            MainMenuScreen mainMenu = new MainMenuScreen();
            mainMenu.Show();

            this.Hide();
        }

        private void ExecuteQuery(string query)
        {
            databaseConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, databaseConnection);
            sqlCommand.ExecuteNonQuery();
            databaseConnection.Close();
        }

        private void ShowInvoices()
        {
            // Start
            databaseConnection.Open();

            string query = "select * from Invoices";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);

            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            invoiceDGV.DataSource = dataSet.Tables[0];

            invoiceDGV.Columns[0].Visible = false;

            databaseConnection.Close();
        }

        private void ClearAllFields()
        {
            textBoxInvoiceReceiver.Text = "";
            textBoxInvoiceBillText.Text = "";
            textBoxInvoiceTotalPrice.Text = "";
        }

        private void invoiceDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxInvoiceReceiver.Text = invoiceDGV.SelectedRows[0].Cells[1].Value.ToString();
            textBoxInvoiceBillText.Text = invoiceDGV.SelectedRows[0].Cells[2].Value.ToString();
            textBoxInvoiceTotalPrice.Text = invoiceDGV.SelectedRows[0].Cells[3].Value.ToString();

            lastSelectedInvoiceKey = (int)invoiceDGV.SelectedRows[0].Cells[0].Value;
        }

        private void InvoiceScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

using CEPOS.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEPOS
{
    public partial class MainInterface : Form
    {
        public MainInterface()
        {
            InitializeComponent();
        }

        private void MainInterface_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_MouseEnter(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.Black;
        }

        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.Crimson;
        }

        private void btnProducts_MouseEnter(object sender, EventArgs e)
        {
            btnProducts.BackColor = Color.Black;
        }

        private void btnProducts_MouseLeave(object sender, EventArgs e)
        {
            btnProducts.BackColor = Color.Crimson;
        }

        private void btnSales_MouseEnter(object sender, EventArgs e)
        {
            btnSales.BackColor = Color.Black;
        }

        private void btnSales_MouseLeave(object sender, EventArgs e)
        {
            btnSales.BackColor = Color.Crimson;
        }

        private void btnPeople_MouseEnter(object sender, EventArgs e)
        {
            btnPeople.BackColor = Color.Black;
        }

        private void btnPeople_MouseLeave(object sender, EventArgs e)
        {
            btnPeople.BackColor = Color.Crimson;
        }

        private void btnExpenses_MouseEnter(object sender, EventArgs e)
        {
            btnExpenses.BackColor = Color.Black;
        }

        private void btnExpenses_MouseLeave(object sender, EventArgs e)
        {
            btnExpenses.BackColor = Color.Crimson;
        }

        private void btnReports_MouseEnter(object sender, EventArgs e)
        {
            btnReports.BackColor = Color.Black;
        }

        private void btnReports_MouseLeave(object sender, EventArgs e)
        {
            btnReports.BackColor = Color.Crimson;
        }

        private void btnPOS_MouseEnter(object sender, EventArgs e)
        {
            btnPOS.BackColor = Color.Crimson;
        }

        private void btnPOS_MouseLeave(object sender, EventArgs e)
        {
            btnPOS.BackColor = Color.DodgerBlue;
        }

        private void btnSettings_MouseEnter(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.Crimson;
        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.DodgerBlue;
        }

        private void btnEndOfDay_MouseEnter(object sender, EventArgs e)
        {
            btnEndOfDay.BackColor = Color.Crimson;
        }

        private void btnEndOfDay_MouseLeave(object sender, EventArgs e)
        {
            btnEndOfDay.BackColor = Color.DodgerBlue;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure?", "Quit Confirmation", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes){
                this.Close();
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductsManagement products = new ProductsManagement();
            products.Show();
        }

        private void btnDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProducts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPeople_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            PeopleManagement people = new PeopleManagement();
            people.Show();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            PurchaseManagement purchase = new PurchaseManagement();
            purchase.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            SalesManagement sales = new SalesManagement();
            sales.Show();
        }
    }
}

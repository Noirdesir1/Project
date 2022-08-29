using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopClient;

namespace ShopClient
{
    public partial class ShopClient : Form
    {
        private readonly IShopData m_shop;
        public ShopClient(IShopData shop)
        {
            InitializeComponent();
            m_shop = shop;
        }

        private async void buttonPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                await m_shop.Purchase(comboBoxList.Text.ToString());
                GetOrders();
            }
            catch (InvalidOperationException x)
            {
                InvalidOperationException i = x;
                MessageBox.Show(i.Message);
            }
        }

        private void ShopClient_Load(object sender, EventArgs e)
        {
            if (Connect())
            {
                InputFormInfo();
            }
            else
            {
                Application.Exit();
            }
        }
        private void InputFormInfo()
        {
            timerGetOrder.Start();
            GetOrders();
            GetProducts();
            Text += m_shop.UserName;
            Console.WriteLine(m_shop.UserName);
        }

        private void ShopperForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_shop.Disconnect();
        }

        private bool Connect()
        {
            return new FormLogin(m_shop).ShowDialog(this) == DialogResult.OK;
        }
        private async void GetOrders()
        {
            IList<Purchase> purchase = await m_shop.GetOrders();
            listBoxPurchase.Items.Clear();
            foreach (Purchase pur in purchase)
            {
                listBoxPurchase.Items.Add(pur.ToString());
            }
        }

        private async void GetProducts()
        {
            IList<Product> products = await m_shop.GetProducts();
            listBoxPurchase.Items.Clear();
            foreach (Product pro in products)
            {
                comboBoxList.Items.Add(pro.Name);
            }
        }
        private void comboBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonPurchase.Enabled = !string.IsNullOrEmpty(comboBoxList.SelectedItem?.ToString());

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
    }
}

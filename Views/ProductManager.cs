using Harvest_Management_System.Database;
using Harvest_Management_System.Models;
using Harvest_Management_System.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harvest_Management_System.Views
{
    public partial class ProductManager : Form
    {
        Carrot[] carrots = null;
        Product[] products = null;
        CarrotDAO carrotDAO = null;

        List<Carrot> carrotList = null;
        List<Product> productsList = null;

        public ProductManager()
        {
            InitializeComponent();
        }

        private void ProductManager_Load(object sender, EventArgs e)
        {
            carrots = new Carrot[11];
            products = new Product[4];
            carrotList = new List<Carrot>();
            productsList = new List<Product>();
            carrotDAO = CarrotDAO.getInstance();
            initFields();
        }

        private void initFields()
        {
            initCarrotArray();
            initProductsArray();
            GetCarrotList();
            SetCarrotArray();
            SetCarrotPrice();

        }

        private void initCarrotArray()
        {
            for (int i = 0; i < carrots.Length; i++)
                carrots[i] = new Carrot();
        }
        private void initProductsArray()
        {
            for (int i = 0; i < products.Length; i++)
                products[i] = new Product();
        }
        private void GetCarrotList()
        {
            try
            {
                carrotList.Clear();
                carrotList = carrotDAO.CarrotList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetCarrotArray()
        {
            if (carrotList.Count > 0)
            {
                foreach (Carrot carrot in carrotList)
                {
                    carrots[carrot.Id] = carrot;
                }
            }
        }

        private void SetCarrotPrice()
        {
            if (carrotList.Count > 0)
            {
                txtlblCarrot1PriceE.Text = carrots[1].EmployeePrice.ToString(); ;
                txtlblCarrot2PriceE.Text = carrots[2].EmployeePrice.ToString(); ;
                txtlblCarrot3PriceE.Text = carrots[3].EmployeePrice.ToString(); ;
                txtlblCarrot4PriceE.Text = carrots[4].EmployeePrice.ToString(); ;
                txtlblCarrot5PriceE.Text = carrots[5].EmployeePrice.ToString(); ;
                txtlblCarrot6PriceE.Text = carrots[6].EmployeePrice.ToString(); ;
                txtlblCarrot7PriceE.Text = carrots[7].EmployeePrice.ToString(); ;
                txtlblCarrot8PriceE.Text = carrots[8].EmployeePrice.ToString(); ;
                txtlblCarrot9PriceE.Text = carrots[9].EmployeePrice.ToString(); ;
                txtlblCarrot10PriceE.Text = carrots[10].EmployeePrice.ToString();
                txtlblCarrot1PriceC.Text = carrots[1].CompanyPrice.ToString();
                txtlblCarrot2PriceC.Text = carrots[2].CompanyPrice.ToString();
                txtlblCarrot3PriceC.Text = carrots[3].CompanyPrice.ToString();
                txtlblCarrot4PriceC.Text = carrots[4].CompanyPrice.ToString();
                txtlblCarrot5PriceC.Text = carrots[5].CompanyPrice.ToString();
                txtlblCarrot6PriceC.Text = carrots[6].CompanyPrice.ToString();
                txtlblCarrot7PriceC.Text = carrots[7].CompanyPrice.ToString();
                txtlblCarrot8PriceC.Text = carrots[8].CompanyPrice.ToString();
                txtlblCarrot9PriceC.Text = carrots[9].CompanyPrice.ToString();
                txtlblCarrot10PriceC.Text = carrots[10].CompanyPrice.ToString();
            }
        }

        private void btnValidateCarrotInput_Click(object sender, EventArgs e)
        {
            UpdateCarrotPrice();
        }

        private void UpdateCarrotPrice()
        {
            try
            {
                GetCarrotPrice();
                for (int i = 1; i < 11; i++)
                {
                    carrotDAO.UpdatePrice(carrots[i]);
                }
                MessageBox.Show("Les prix sont mis à jours");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetCarrotPrice()
        {
            try{
                carrots[1].EmployeePrice = Convert.ToDouble(txtlblCarrot1PriceE.Text);
                carrots[1].CompanyPrice = Convert.ToDouble(txtlblCarrot1PriceC.Text);
                carrots[2].EmployeePrice = Convert.ToDouble(txtlblCarrot2PriceE.Text);
                carrots[2].CompanyPrice = Convert.ToDouble(txtlblCarrot2PriceC.Text);
                carrots[3].EmployeePrice = Convert.ToDouble(txtlblCarrot3PriceE.Text);
                carrots[3].CompanyPrice = Convert.ToDouble(txtlblCarrot3PriceC.Text);
                carrots[4].EmployeePrice = Convert.ToDouble(txtlblCarrot4PriceE.Text);
                carrots[4].CompanyPrice = Convert.ToDouble(txtlblCarrot4PriceC.Text);
                carrots[5].EmployeePrice = Convert.ToDouble(txtlblCarrot5PriceE.Text);
                carrots[5].CompanyPrice = Convert.ToDouble(txtlblCarrot5PriceC.Text);
                carrots[6].EmployeePrice = Convert.ToDouble(txtlblCarrot6PriceE.Text);
                carrots[6].CompanyPrice = Convert.ToDouble(txtlblCarrot6PriceC.Text);
                carrots[7].EmployeePrice = Convert.ToDouble(txtlblCarrot7PriceE.Text);
                carrots[7].CompanyPrice = Convert.ToDouble(txtlblCarrot7PriceC.Text);
                carrots[8].EmployeePrice = Convert.ToDouble(txtlblCarrot8PriceE.Text);
                carrots[8].CompanyPrice = Convert.ToDouble(txtlblCarrot8PriceC.Text);
                carrots[9].EmployeePrice = Convert.ToDouble(txtlblCarrot9PriceE.Text);
                carrots[9].CompanyPrice = Convert.ToDouble(txtlblCarrot9PriceC.Text);
                carrots[10].EmployeePrice = Convert.ToDouble(txtlblCarrot10PriceE.Text);
                carrots[10].CompanyPrice = Convert.ToDouble(txtlblCarrot10PriceC.Text);

            }
            catch(Exception ex)
            {
                Logging.LogError(ex);
            }

        }

        private void ValidateNumberEntred(object sender, KeyPressEventArgs e)
        {
            Validation.ValidateNumberEntred(sender, e);
        }

        private void btnValidateRoundTurnipInput_Click(object sender, EventArgs e)
        {
            GetRoundTurnipPrice();
            UpdateProductPrice(1);
        }

        private void GetRoundTurnipPrice()
        {
            products[1].EmployeePrice = Convert.ToDouble(txtRoundTurnipPriceE.Text);
            products[1].CompanyPrice = Convert.ToDouble(txtRoundTurnipPriceC.Text);
        }

        private void btnValidateLongTurnipInput_Click(object sender, EventArgs e)
        {
            GetLongTurnipPrice();
            UpdateProductPrice(2);
        }

        private void GetLongTurnipPrice()
        {
            products[2].EmployeePrice = Convert.ToDouble(txtLongTurnipPriceE.Text);
            products[2].CompanyPrice = Convert.ToDouble(txtLongTurnipPriceC.Text);
        }

        private void btnValidateWatermelonInput_Click(object sender, EventArgs e)
        {
            GetWaterMelonPrice();
            UpdateProductPrice(3);
        }

        private void GetWaterMelonPrice()
        {
            products[3].EmployeePrice = Convert.ToDouble(txtWaterMelonPriceE.Text);
            products[3].CompanyPrice = Convert.ToDouble(txtWaterMelonPriceC.Text);
        }

        private void UpdateProductPrice(int i)
        {

        }

    }
}

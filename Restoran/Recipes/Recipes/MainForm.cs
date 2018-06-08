using System;
using System.Windows.Forms;
using RecipesDataUnit;
using ResipesEntities.Code;

namespace Recipes
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Unit.ProductsRepository.AddItem(new Product
            {
                Name = "Хлеб",
                Dimension = "шт."
            });
        }
    }
}

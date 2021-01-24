using Supermarket.Control;
using Supermarket.Type;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Supermarket
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        CategoryControl _categoryControl = new CategoryControl();


        private void CategoryForm_Load(object sender, EventArgs e)
        {
            CategoryList();
        }


        private void CategoryList()
        {

            dataGridView1.DataSource = _categoryControl.Select();
        }

        
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = dataGridView1.SelectedCells[0].RowIndex;
            CatIdTbl.Text = dataGridView1.Rows[a].Cells[0].Value.ToString();
            CatNameTbl.Text = dataGridView1.Rows[a].Cells[1].Value.ToString();
            CatDescTbl.Text = dataGridView1.Rows[a].Cells[2].Value.ToString();


        }


        private void BtnCategoryAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (CatIdTbl.Text == "")
                {
                    MessageBox.Show("Seçim Yapınız.");
                }
                else
                {
                    _categoryControl.Add(new CategoryType
                    {

                        CatId = Int32.Parse(CatIdTbl.Text),
                        CatName = CatNameTbl.Text,
                        CatDesc = CatDescTbl.Text


                    });
                    CategoryList();
                    MessageBox.Show("Category Succesfull");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCategoryEdit_Click(object sender, EventArgs e)
        {
            try
            {

                if (CatIdTbl.Text == "")
                {
                    MessageBox.Show("Seçim Yapınız.");
                }
                else
                {
                    _categoryControl.Update(new CategoryType
                    {

                        CatId = Int32.Parse(CatIdTbl.Text),
                        CatName = CatNameTbl.Text,
                        CatDesc = CatDescTbl.Text


                    });
                    CategoryList();
                    MessageBox.Show("Category Update");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCategoryDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (CatIdTbl.Text == "")
                {
                    MessageBox.Show("Seçim Yapınız.");
                }
                else
                {
                    _categoryControl.Delete(new CategoryType
                    {

                        CatId = Int32.Parse(CatIdTbl.Text)

                    });
                    CategoryList();
                    MessageBox.Show("Category Delete");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            this.Hide();
            productForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SellersForm sellersForm = new SellersForm();
            this.Hide();
            sellersForm.Show();
        }
    }
}

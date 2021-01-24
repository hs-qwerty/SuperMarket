using Supermarket.Type;
using Supermarket.VtAction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Control
{
    public class CategoryControl
    {

        CategoryAction _categoryAction = new CategoryAction();

        public void Add(CategoryType category)
        {
          

            try
            {
                if (category.CatName == "" || category.CatDesc == "" || category.CatId < 0)
                { 
                    throw new Exception("Veri Kontrol");
                }

                _categoryAction.Add(category);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public List<CategoryType> Select()
        {

            return _categoryAction.GetAll();
        }
        public DataTable Select2()
        {
            return _categoryAction.GetAll2();

        }
        public void Delete(CategoryType category)
        {

            try
            {
                if (category.CatId < 0)
                {
                    throw new Exception("Veri Kontrol");
                }

                _categoryAction.Delete(category);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

           


        }
        public void Update(CategoryType category)
        {
            try
            {
                if (category.CatName == "" || category.CatDesc == "" || category.CatId < 0)
                {
                    throw new Exception("Veri Kontrol");
                }

                _categoryAction.Update(category);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }


        public DataTable ComboProductSelect()
        {

            return _categoryAction.GetAllComboBox();
        }


    }
}

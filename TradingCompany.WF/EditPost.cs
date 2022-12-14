using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TradingCompany.BLL.Interfaces;
using TradingCompany.DTO;

namespace TradingCompany.WF
{
    public partial class EditPost : Form
    {
        private readonly IPostManager _postManager;
        private readonly IProductManager _productManager;
        private PostDTO _post;

        public EditPost(IPostManager postManager, IProductManager productManager, PostDTO post)
        {
            InitializeComponent();
            _postManager = postManager;
            _productManager = productManager;
            _post = post;

            if (post != null)
                txtPostID.Text = _post.PostID.ToString();
            
            UpdateForm();
        }

        private void UpdateForm()
        {
            BindProducts();

            if (_post != null)
            {
                txtTitle.Text = _post.Title;
                txtContent.Text = _post.Content;

                List<int> productIDs = _post.Products.Select(p => p.ProductID).ToList();
                for (int i = 0; i < clbProducts.Items.Count; i++)
                {
                    clbProducts.SetItemChecked(i, productIDs.Contains(((ProductDTO)clbProducts.Items[i]).ProductID));
                }
            }
        }

        private void BindProducts()
        {
            BindingList<ProductDTO> products = new BindingList<ProductDTO>(_productManager.GetAllProducts());
            bsProducts.DataSource = products;

            ListBox[] listBox = { clbProducts };
            foreach (var product in listBox)
            {
                product.DataSource = bsProducts;
                product.DisplayMember = "Name";
                product.ValueMember = "ProductID";
            }
        }

        private void SetProperties()
        {
            _post.Title = txtTitle.Text;
            _post.Content = txtContent.Text;
            _post.RowUpdateTime = DateTime.UtcNow;
            _post.Products.Clear();

            foreach (var product in clbProducts.CheckedItems)
                _post.Products.Add((ProductDTO)product);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_post == null)
                _post = new PostDTO();

            SetProperties();
            _postManager.UpdatePost(int.Parse(txtPostID.Text), _post);

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

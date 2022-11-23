using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradingCompany.BLL.Concrete;
using TradingCompany.BLL.Interfaces;
using TradingCompany.DTO;

namespace TradingCompany.WF
{
    public partial class PostList : Form
    {
        private readonly IPostManager _postManager;
        private readonly IProductManager _productManager;
        private List<PostDTO> _posts;

        public PostList(IPostManager postManager, IProductManager productManager)
        {
            InitializeComponent();
            _postManager = postManager;
            _productManager = productManager;
            RefreshGrid();
            SetComboboxValues();
        }

        private void RefreshGrid()
        {
            _posts = _postManager.GetAllPosts();

            BindingList<PostDTO> blPosts = new BindingList<PostDTO>(_posts);
            bsPosts.DataSource = blPosts;

            bnPosts.BindingSource = bsPosts;
            dgvPosts.DataSource = bsPosts;
        }
 
        private void ShowCreateWindow(PostDTO post = null)
        {
            CreatePost createForm = new CreatePost(_postManager, _productManager, post);

            var result = createForm.ShowDialog();
            if (DialogResult.OK == result || DialogResult.Cancel == result)
                RefreshGrid();
        }

        private void ShowEditWindow(PostDTO post = null)
        {
            EditPost editForm = new EditPost(_postManager, _productManager, post);

            var result = editForm.ShowDialog();
            if (DialogResult.OK == result || DialogResult.Cancel == result)
                RefreshGrid();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ShowCreateWindow();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Are you sure you want to delete this post?", "Delete Post", MessageBoxButtons.OKCancel))
            {
                _postManager.DeletePost(((PostDTO)bsPosts.Current).PostID);
                RefreshGrid();
            }
        }

        private void dgvPosts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CheckUserEditPermission(_posts[e.RowIndex]))
                ShowEditWindow(_posts[e.RowIndex]);
            else
                MessageBox.Show("You have no permission to edit this post");
        }

        private bool CheckUserEditPermission(PostDTO post)
        {
            if (post.UserID == Program.currentUser.UserID)
                return true;

            return false;
        }

        private void SetComboboxValues()
        {
            string[] items = { "by title", "by content", "by date" };
            cbSearchBy.Items.AddRange(items);
            cbSearchBy.SelectedIndex = 0;
        }

        private void txtSearchInput_TextChanged(object sender, EventArgs e)
        {
            if ((string)cbSearchBy.SelectedItem == "by title")
                _posts = _postManager.FindPostsByTitle(txtSearchInput.Text);
            else if ((string)cbSearchBy.SelectedItem == "by content")
                _posts = _postManager.FindPostsByContent(txtSearchInput.Text);
            else if ((string)cbSearchBy.SelectedItem == "by date")
                _posts = _postManager.FindPostsByDate(txtSearchInput.Text);

            BindingList<PostDTO> blPosts = new BindingList<PostDTO>(_posts);
            bsPosts.DataSource = blPosts;

            bnPosts.BindingSource = bsPosts;
            dgvPosts.DataSource = bsPosts;
        }
    }
}

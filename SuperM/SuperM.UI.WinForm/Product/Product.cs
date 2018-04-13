using SuperM.Business.Services;
using SuperM.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperM.UI.WinForm
{
	public partial class ProductBak : Form
	{
		ProductServiceBak products = new ProductServiceBak();

		public ProductBak()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
			var productList = products.GetProductList();

			dgvProduct.DataSource = productList;
			dgvProduct.Columns[0].Visible = false;

			propertyGrid1.SelectedObject = new Data.Entities.Product();
		}

		private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = dgvProduct.CurrentRow.Index;
			int id = Convert.ToInt32(dgvProduct.Rows[index].Cells["ProductId"].Value);
			propertyGrid1.SelectedObject = products.GetProductById(id);
			dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvProduct.DefaultCellStyle.SelectionBackColor = Color.Purple;

		}
	}
}

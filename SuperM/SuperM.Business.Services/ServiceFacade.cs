using SuperM.Data.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperM.Business.Services
{
	public class ServiceFacade
	{
		//List<Company>
		public void FillCompanyComboBox(ComboBox cbo)
		{
			CompanyService CompanyService = new CompanyService();
			var listCompany = CompanyService.GetCompanyList();
			cbo.DataSource = listCompany;
			cbo.DisplayMember = "Name";
			cbo.ValueMember = "CompanyId";
		}

		public void FillDepartmentComboBox(ComboBox cbo)
		{
			DepartmentService departmentService = new DepartmentService();
			var listCompany = departmentService.GetDepartmentList();
			cbo.DataSource = listCompany;
			cbo.DisplayMember = "Name";
			cbo.ValueMember = "DepartmentId";
		}

		public void FillPositionComboBox(ComboBox cbo)
		{
			PositionService positionService = new PositionService();
			var listCompany = positionService.GetPositionList();
			cbo.DataSource = listCompany;
			cbo.DisplayMember = "Name";
			cbo.ValueMember = "PositionId";
		}

		public void FillCategoryComboBox(ComboBox cbo)
		{
			CategoryService employeeService = new CategoryService();
			var CategoryList = employeeService.GetCategoryList();
			cbo.DataSource = CategoryList;
			cbo.DisplayMember = "Name";
			cbo.ValueMember = "CategoryId";
		}

		public void FillGroupListBox(ListBox lsb)
		{
			GroupService groupService = new GroupService();
			var listCompany = groupService.GetGroupList();
			lsb.DataSource = listCompany;
			lsb.DisplayMember = "Name";
			lsb.ValueMember = "GroupId";
		}

		public void FillUserDataGridView(DataGridView dgv)
		{
			UserService userService = new UserService();
			var UserList = userService.GetUserList();
			dgv.DataSource = UserList;
			dgv.ReadOnly = true;
			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv.DefaultCellStyle.SelectionBackColor = Color.Gray;
			dgv.Columns["UserId"].Visible = false;
		}


		public void FillCompanyDataGridView(DataGridView dgv)
		{
			CompanyService companyService = new CompanyService();
			var CompanyList = companyService.GetCompanyList();
			dgv.DataSource = CompanyList;
			dgv.ReadOnly = true;
			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv.DefaultCellStyle.SelectionBackColor = Color.Gray;
			dgv.Columns["CompanyId"].Visible = false;

		}

		public void FillDepartmentDataGridView(DataGridView dgv)
		{
			DepartmentService departmentService = new DepartmentService();
			var DepartmentList = departmentService.GetDepartmentList();
			dgv.DataSource = DepartmentList;
			dgv.ReadOnly = true;
			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv.DefaultCellStyle.SelectionBackColor = Color.Gray;
			dgv.Columns["DepartmentId"].Visible = false;
			dgv.Columns["Name"].Width = 200;
			//dgv.Columns["CompanyName"].Width = 200;
		}

		public void FillGroupDataGridView(DataGridView dgv)
		{
			GroupService groupService = new GroupService();
			var groupList = groupService.GetGroupList();
			dgv.DataSource = groupList;
			dgv.ReadOnly = true;
			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv.DefaultCellStyle.SelectionBackColor = Color.Gray;
			dgv.Columns["GroupId"].Visible = false;
			dgv.Columns["Name"].Width = 200;
		}

		public void FillPositionDataGridView(DataGridView dgv)
		{
			PositionService positionService = new PositionService();
			var positionList = positionService.GetPositionList();
			dgv.DataSource = positionList;
			dgv.ReadOnly = true;
			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv.DefaultCellStyle.SelectionBackColor = Color.Gray;
			dgv.Columns["PositionId"].Visible = false;
		}

		public void FillEmployeeDataGridView(DataGridView dgv)
		{
			EmployeeService employeeService = new EmployeeService();
			var EmployeeList = employeeService.GetEmployeeList();
			dgv.DataSource = EmployeeList;
			dgv.ReadOnly = true;
			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv.DefaultCellStyle.SelectionBackColor = Color.Gray;
			dgv.Columns["EmployeeId"].Visible = false;
			dgv.Columns["DepartmentName"].Width = 200;
		}

		public void FillPermissionDataGridView(DataGridView dgv)
		{
			PermissionService employeeService = new PermissionService();
			var PermissionList = employeeService.GetPermissionList();
			dgv.DataSource = PermissionList;
			dgv.ReadOnly = true;
			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv.DefaultCellStyle.SelectionBackColor = Color.Gray;
		}

		public void FillProductDataGridView(DataGridView dgv)
		{
			ProductService productService = new ProductService();
			var ProductList = productService.GetProductList();
			dgv.DataSource = ProductList;
			dgv.ReadOnly = true;
			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv.DefaultCellStyle.SelectionBackColor = Color.Gray;
			dgv.Columns["ProductId"].Visible = false;
		}

		public void FillProductComboBox(ComboBox cbo)
		{
			ProductService productService = new ProductService();
			var ProductList = productService.GetProductList();
			cbo.DataSource = ProductList;
			cbo.DisplayMember = "Name";
			cbo.ValueMember = "ProductId";
		}

		public void FillSupplierDataGridView(DataGridView dgv)//To be moved to ServiceFacade
		{
			SupplierService employeeService = new SupplierService();
			var SupplierList = employeeService.GetSupplierList();
			dgv.DataSource = SupplierList;
			dgv.ReadOnly = true;
			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv.DefaultCellStyle.SelectionBackColor = Color.Gray;
			dgv.Columns["SupplierId"].Visible = false;
		}

		public void FillCategoryDataGridView(DataGridView dgv)
		{
			CategoryService employeeService = new CategoryService();
			var CategoryList = employeeService.GetCategoryList();
			dgv.DataSource = CategoryList;
			dgv.ReadOnly = true;
			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv.DefaultCellStyle.SelectionBackColor = Color.Gray;
			dgv.Columns["CategoryId"].Visible = false;
		}

		public void FillStockInDataGridView(DataGridView dgv)
		{
			StockInService inventoryService = new StockInService();
			var inventoryList = inventoryService.GetInventoryList();
			dgv.DataSource = inventoryList;
			dgv.ReadOnly = true;
			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv.DefaultCellStyle.SelectionBackColor = Color.Gray;
			dgv.Columns["StockInId"].Visible = false;
		}

		public void FillInventoryDataGridView(DataGridView dgv)
		{
			InventoryService inventoryService = new InventoryService();
			var InventoryList = inventoryService.GetInventoryList();
			dgv.DataSource = InventoryList;
			dgv.ReadOnly = true;
			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv.DefaultCellStyle.SelectionBackColor = Color.Gray;
		}

		public void FillOrderDataGridView(DataGridView dgv, int orderId)
		{
			OrdersService ordersService = new OrdersService();
			var orderList = ordersService.GetOrdersById(orderId);
			dgv.DataSource = new List<Order> { orderList };
			dgv.ReadOnly = true;
			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv.DefaultCellStyle.SelectionBackColor = Color.Gray;
			dgv.Refresh();
		}

		public void FillOrderDetailsDataGridView(DataGridView dgv, int orderId)
		{
			OrderDetailsService orderDetailsService = new OrderDetailsService();
			var orderdetailsList = orderDetailsService.GetOrderDetailsByOrderId(orderId);
			dgv.DataSource = orderdetailsList;
			dgv.ReadOnly = true;
			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgv.DefaultCellStyle.SelectionBackColor = Color.Gray;
		}
	}
}



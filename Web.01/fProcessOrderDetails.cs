using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QLBH.Models;

namespace QLBH
{
    public partial class fProcessOrderDetails : Form
    {
        private EFDbContext db = new EFDbContext();
        private List<OrderDetailsAndProduct> list
        = new List<OrderDetailsAndProduct>();
        private long mOrderID;
        private long mOrderDetailID;
        public fProcessOrderDetails()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fProcessOrderDetails_Load(object sender, EventArgs e)
        {
            cbProducts.DisplayMember = "Name";
            cbProducts.ValueMember = "ProductID";
            cbProducts.DataSource = db.Products.Select(p => new
            {
                p.ProductID,
                p.Name
            }).ToList();
            cbProducts.Text = null;
            cbOrders.DataSource = db.Orders.Select(o =>
           o.OrderID).ToList();
            cbOrders.Text = null;
        }
        private void loadOrderDetails()
        {
            var details = db.OrderDetails.Where(d => d.OrderID ==
           mOrderID).Select(d => new
           {
               d.OrderDetailID,
               d.OrderID,
               d.ProductID,
               d.Quantity,
               d.Price,
               d.Product.Name
           }).ToList();
            list = new List<OrderDetailsAndProduct>();
            foreach (var d in details)
            {
                OrderDetailsAndProduct detail = new OrderDetailsAndProduct();
                detail.OrderDetailID = d.OrderDetailID;
                detail.ProductID = d.ProductID;
                detail.OrderID = d.OrderID;
                detail.Quantity = d.Quantity;
                detail.Price = d.Price;
                detail.Name = d.Name;
                //detail.Amount = d.Amount; //nếu bảng có cột Amount
                list.Add(detail);
            }
            dataGridView1.DataSource = list;
            cbOrders.Focus();
        }

        private void cbOrders_SelectionChangeCommitted(object sender, EventArgs e)
        {
            mOrderID = Convert.ToInt64(cbOrders.SelectedValue);//có thể xét Text
            Order order = db.Orders.Include(o => o.Progress).Include(o =>
           o.Customer).Include(o => o.Employee).Single(o => o.OrderID == mOrderID);
            Text = "Xử lý chi tiết đơn hàng " + order.OrderID.ToString();
            txtOrderDate.Text = order.OrderDate.ToShortDateString();
            txtReceiveDate.Text = order.ReceiveDate.Value.ToShortDateString();
            txtOrderTime.Text = order.OrderTime.ToString();
            txtReceiveTime.Text = order.ReceiveTime.ToString();
            txtProgressName.Text = order.Progress.Name;
            txtCustomerName.Text = order.Customer.Name;
            txtEmployeeName.Text = order.Employee.Name;
            loadOrderDetails();
        }

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            long ProductID = Convert.ToInt32(cbProducts.SelectedValue);
            mPrice.Text = db.Products.Where(p => p.ProductID ==
           ProductID).Select(p => p.Price).SingleOrDefault().ToString();
            mQuantity.Focus();
        }

        private void btAddOrderDetail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbOrders.Text))
            {
                toolTip1.Show("Hãy nhập Order?", cbOrders, 0, 0, 1000);
                cbOrders.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbProducts.Text))
            {
                toolTip1.Show("Hãy nhập sản phẩm?", cbProducts, 0, 0, 1000);
                cbProducts.Focus();
                return;
            }
            else if (cbProducts.FindStringExact(cbProducts.Text) < 0)
            {
                toolTip1.Show("Nhập sai sản phẩm?", cbProducts, 0, 0, 1000);
                cbProducts.Focus();
                return;
            }
            else //Kiểm tra chọn trùng sản phẩm đã có trong đơn hàng
            {
                long ProductID = Convert.ToInt64(cbProducts.SelectedValue);
                if (list.SingleOrDefault(o => o.OrderID == mOrderID && o.ProductID
== ProductID) != null)
                {
                    toolTip1.Show("Hãy chọn sản phẩm khác. Đơn hàng đã có sản phẩm này ? ", cbProducts, 0, 0, 1000);

                    cbProducts.Focus();
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(mQuantity.Text))
            {
                toolTip1.Show("Hãy nhập số lượng?", mQuantity, 0, 0, 1000);
                mQuantity.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(mPrice.Text))
            {
                toolTip1.Show("Hãy nhập đơn giá?", mPrice, 0, 0, 1000);
                mPrice.Focus();
                return;
            }
            try
            {
                OrderDetail orderdetail = new OrderDetail();
                orderdetail.OrderID = mOrderID;
                orderdetail.ProductID = Convert.ToInt64(cbProducts.SelectedValue);
                orderdetail.Quantity = Convert.ToInt32(mQuantity.Text);
                orderdetail.Price = Convert.ToDecimal(mPrice.Text);
                db.OrderDetails.Add(orderdetail);
                db.SaveChanges();
                cbProducts.Text = null;
                mQuantity.Text = null;
                mPrice.Text = null;
                loadOrderDetails();
                toolTip1.Show("Thêm thành công.", btAddOrderDetail, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message,
               btAddOrderDetail, 0, 0, 1000);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long mOrderDetailID =
Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["OrderDetailID"].Value);
                    OrderDetail orderdetail = db.OrderDetails.Single(o =>
                   o.OrderDetailID == mOrderDetailID);
                    if (MessageBox.Show("Bạn muốn xóa " + mOrderDetailID, "Xóa",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.OrderDetails.Remove(orderdetail);
                        db.SaveChanges();
                        loadOrderDetails();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            mOrderDetailID =
           Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["OrderDetailID"].Value);
            cbProducts.Text =
           dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            mQuantity.Text =
           dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
            mPrice.Text =
           dataGridView1.Rows[e.RowIndex].Cells["Price"].Value.ToString();
        }

        private void btSaveOrderDetail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbOrders.Text))
            {
                toolTip1.Show("Hãy nhập Order?", cbOrders, 0, 0, 1000);
                cbOrders.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbProducts.Text))
            {
                toolTip1.Show("Hãy nhập sản phẩm?", cbProducts, 0, 0, 1000);
                cbProducts.Focus();
                return;
            }
            else if (cbProducts.FindStringExact(cbProducts.Text) < 0)
            {
                toolTip1.Show("Nhập sai sản phẩm?", cbProducts, 0, 0, 1000);
                cbProducts.Focus();
                return;
            }
            else //Kiểm tra chọn trùng sản phẩm đã có trong đơn hàng
            {
                long ProductID = Convert.ToInt64(cbProducts.SelectedValue);
                if (list.SingleOrDefault(o => o.ProductID == ProductID &&
               o.OrderDetailID != mOrderDetailID) != null)
                {
                    toolTip1.Show("Hãy chọn sản phẩm khác. Đơn hàng đã có sản phẩm này ? ", cbProducts, 0, 0, 1000);

                    cbProducts.Focus();
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(mQuantity.Text))
            {
                toolTip1.Show("Hãy nhập số lượng?", mQuantity, 0, 0, 1000);
                mQuantity.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(mPrice.Text))
            {
                toolTip1.Show("Hãy nhập đơn giá?", mPrice, 0, 0, 1000);
                mPrice.Focus();
                return;
            }
            try
            {
                OrderDetail orderdetail = db.OrderDetails.Single(o =>
               o.OrderDetailID == mOrderDetailID);
                orderdetail.ProductID = Convert.ToInt64(cbProducts.SelectedValue);
                orderdetail.Quantity = Convert.ToInt32(mQuantity.Text);
                orderdetail.Price = Convert.ToDecimal(mPrice.Text);
                db.SaveChanges();
                loadOrderDetails();
                toolTip1.Show("Lưu thành công.", btSaveOrderDetail, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message,
               btSaveOrderDetail, 0, 0, 1000);
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            cbProducts.Text = "";
            mQuantity.Text = null;
        }

        private void txtReceiveTime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiWinfrom
{
    public partial class Frm_DSSP : Form
    {
        public Frm_DSSP()
        {
            InitializeComponent();
        }
        public string err = string.Empty;
        BLL_QuanLySP bll;

        private void Frm_DSSP_Load(object sender, EventArgs e)
        {
            bll = new BLL_QuanLySP();
            DataTable dt = new DataTable();
            dt = bll.GetListCat(ref err);
            cbo_dm.Items.Add("Chọn tất cả");
            cbo_dm.SelectedIndex = 0;
            for (int i = 0; i < dt.Rows.Count - 1; i++)
            {
                cbo_dm.Items.Add(dt.Rows[i][1].ToString());
            }
        }

        private void cbo_dm_SelectedIndexChanged(object sender, EventArgs e)
        {
            bll = new BLL_QuanLySP();
            DataTable dt = new DataTable();
            if(cbo_dm.SelectedIndex == 0)
            {
                dt = bll.GetListPro(ref err);
            }
            else
            {
                int id = bll.GetCatIDWithCatName(ref err, cbo_dm.SelectedItem.ToString());
                dt = bll.GetListProWithCatID(ref err, id);
            }   
            dataGridView1.DataSource = dt;
            lbl_QuantityPro.Text = dt.Rows.Count.ToString();
        }
        public DTO_Pro setControlToDTO(ref DTO_Pro pro, BLL_QuanLySP bll){
           
                pro.CatID = Convert.ToInt32(bll.GetCatIDWithCatName(ref err, cbo_dm.SelectedItem.ToString()));
                pro.ProName = txt_name.Text;
                pro.proDescription = txt_des.Text;
                pro.ProID = Convert.ToInt32(lbl_ProID.Text);
            return pro;
        }
        public void SetDTOToControl(DTO_Pro pro)
        {
            lbl_ProID.Text = pro.ProID.ToString();
            txt_name.Text = pro.ProName;
            txt_des.Text = pro.proDescription;
            cbo_dm.SelectedItem = pro.CatName;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            bll = new BLL_QuanLySP();
            DTO_Pro pro = new DTO_Pro();
            setControlToDTO(ref pro, bll);
            if (bll.AddProduct(ref err, pro.ProName, pro.proDescription, pro.CatID)){
                MessageBox.Show("Đã thêm thành công");
                cbo_dm_SelectedIndexChanged(sender, e);
            }
            else
                MessageBox.Show("Không thêm đuọc");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DTO_Pro pro = new DTO_Pro();
            pro.ProID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["col_ProID"].Value);
            pro.ProName = dataGridView1.CurrentRow.Cells["col_ProName"].Value.ToString();
            pro.proDescription = dataGridView1.CurrentRow.Cells["col_ProDescription"].Value.ToString();
            pro.CatID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["col_CatID"].Value);
            pro.CatName = dataGridView1.CurrentRow.Cells["col_CatID"].Value.ToString();
            SetDTOToControl(pro);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            bll = new BLL_QuanLySP();
            DTO_Pro pro = new DTO_Pro();
            setControlToDTO(ref pro, bll);
            if (bll.EditProduct(ref err, pro.ProID,pro.ProName, pro.proDescription, pro.CatID)){
                MessageBox.Show("Đã sửa thành công");
                cbo_dm_SelectedIndexChanged(sender, e);
            }
                
            else
                MessageBox.Show("Không sửa đuọc");
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            bll = new BLL_QuanLySP();
            bool result = false;
            for (int i = dataGridView1.RowCount - 1; i > 0; i--)
            {
                if (dataGridView1.Rows[i].Cells["col_Check"].Selected)
                {
                    int proid = Convert.ToInt32(dataGridView1.Rows[i].Cells["col_ProID"].Value);
                    result = bll.DeletePro(ref err, proid);
                }
            }
            if (result){
                MessageBox.Show("Xóa hoàn tất");
                cbo_dm_SelectedIndexChanged(sender, e);
            }
            else
                MessageBox.Show("Xóa thất bại");
        }

        private void btn_ViewReport_Click(object sender, EventArgs e)
        {
            bll = new BLL_QuanLySP();
            Frm_Report frm_report = new Frm_Report();
            frm_report.CatID = bll.GetCatIDWithCatName(ref err, cbo_dm.SelectedItem.ToString()).ToString();
            frm_report.Show();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bai1
{
    public partial class dangkythongtin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                ddlTrinhDo.Items.Add(new ListItem("trung cấp"));
                ddlTrinhDo.Items.Add(new ListItem("cao cấp"));

                lstNgheNghiep.Items.Add(new ListItem("công nhân"));
                lstNgheNghiep.Items.Add(new ListItem("lập trình viên"));
                lstNgheNghiep.Items.Add(new ListItem("kỹ sư"));

                chkListSoThich.Items.Add(new ListItem("Mua sắm"));
                chkListSoThich.Items.Add(new ListItem("chơi game"));
                chkListSoThich.Items.Add(new ListItem("nghe nhạc"));
                chkListSoThich.Items.Add(new ListItem("đi ngủ"));
            }    




        }

        protected void btGui_Click(object sender, EventArgs e)
        {
            string kq = "";
            kq += "<h2>Thong tin dang ky cua ban</h2>";
            kq += "<ul>";
            //lay thong tin hoten
            kq += $"<li>Ho Ten: {txtHoTen.Text}</li>";
            kq += $"<li> Ngay Sinh: {txtNgaySinh.Text}</li>";
            if (rdNam.Checked)
            {
                kq += $"<li> Gioi Tinh: {rdNam.Text}</li>";
            }
            else
            {
                kq += $"<li> Gioi Tinh: {rdNu.Text}</li>";

            }
            kq += $"<li> Trinh Do: {ddlTrinhDo.SelectedItem.Text}</li>";
            kq += $"<li> Nghe nghiep: {lstNgheNghiep.SelectedItem.Text}</li>";

            //xu  ly ha
            if (FHinh.HasFile)
            {
                //lay duong dan tdoi
                string path = Server.MapPath("~/Uploads");
                FHinh.SaveAs(path + "/" + FHinh.FileName);
                kq += $"<li> Anh: <img src='Uploads/{ FHinh.FileName}'></li>";
            }
            kq += $"<li> So Thich: {chkListSoThich.SelectedItem.Text}</li>";

            kq += "<ul>";


            //b2: tra kq
            lbKetQua.Text = kq;
        }
    }
}
    
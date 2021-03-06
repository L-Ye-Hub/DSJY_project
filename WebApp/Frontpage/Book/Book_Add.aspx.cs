﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
namespace WebApp.Frontpage.Book
{
    public partial class Book_Add : System.Web.UI.Page
    {
        BookServices BookSvc = new BookServices();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Model.Book u = new Model.Book
            {
                Book_Title = this.txtTitle.Text,
                Book_Content = this.txtContent.Text,
                Book_Image = upFileName(this.FileUpload1, "../../upload/Book/"),
                Book_Price = float.Parse( this.txtPrice.Text),
                Book_publish = this.txtpublish.Text,
                Book_Author = this.txtAuthor.Text,
                Book_Intro = this.txtIntro.Text,
                Book_Catalog = this.txtCatalog.Text,
                Book_Read = this.txtRead.Text,
            };
            var res = BookSvc.Add(u);
            ReturnMsg rm = res > 0
                ? new ReturnMsg()
                {
                    Code = StatusCode.OK,
                    Message = "新增用户信息成功",
                    Data = null
                }
                : new ReturnMsg()
                {
                    Code = StatusCode.Error,
                    Message = "新增用户信息失败",
                    Data = null
                };

            Session["Msg"] = rm; //用于传递执行信息的
            Response.Redirect("Book_List.aspx");
        }
        protected void btnReset_Click(object sender, EventArgs e)
        {
            this.txtContent.Text = "";
        }
        public string upFileName(FileUpload f, string url)
        {
            string res = "";
            Random ran = new Random();
            string filePath = f.FileName;
            string fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + Convert.ToString(ran.Next(1, 1 + 9999));
            if (filePath != "")
            {
                string fileType = filePath.Substring(filePath.LastIndexOf(".") + 1);
                //string filePic = Server.MapPath(url + filePath);
                string filePic = Server.MapPath(url + fileName + "." + fileType);
                f.PostedFile.SaveAs(filePic);
                res = fileName + "." + fileType;
            }
            return res;
        }
    }
}
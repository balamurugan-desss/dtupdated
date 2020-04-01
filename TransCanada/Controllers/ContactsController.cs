using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TransCanada.Models;
using MvcBreadCrumbs;

namespace TransCanada.Controllers
{
    public class ContactsController : Controller
    {
        string TransCanadaConnection = ConfigurationManager.ConnectionStrings["TransCanadaConnection"].ConnectionString;
        // GET: Contacts
        [BreadCrumb(Clear = true, Label = "All Contacts List")]
        public ActionResult Index()
        {
            SqlConnection conn = new SqlConnection(TransCanadaConnection);
            SqlCommand cmd = new SqlCommand("getall_contacts", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<allcontact> clientList = new List<allcontact>();
            if (dt.Rows.Count > 0)
            {
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    allcontact allcontact = new allcontact();
                    allcontact.fname = dt.Rows[j]["firstname"].ToString();
                    allcontact.Type= dt.Rows[j]["Type"].ToString();
                    allcontact.curl = dt.Rows[j]["id"].ToString();
                    allcontact.lurl = dt.Rows[j]["lid"].ToString();
                    allcontact.location = dt.Rows[j]["lname"].ToString();
                    if (!string.IsNullOrEmpty(dt.Rows[j]["lastname"].ToString()))
                        allcontact.lname = dt.Rows[j]["lastname"].ToString();
                    else
                        allcontact.lname = string.Empty;
                    if (!string.IsNullOrEmpty(dt.Rows[j]["email"].ToString()))
                        allcontact.email = dt.Rows[j]["email"].ToString();
                    else
                        allcontact.email = string.Empty;
                    if (!string.IsNullOrEmpty(dt.Rows[j]["cell"].ToString()))
                        allcontact.phone = dt.Rows[j]["cell"].ToString();
                    else
                        allcontact.phone = string.Empty;
                    if (!string.IsNullOrEmpty(dt.Rows[j]["cell"].ToString()))
                        allcontact.phone = dt.Rows[j]["cell"].ToString();
                    else
                        allcontact.phone = string.Empty;
                    if (!string.IsNullOrEmpty(dt.Rows[j]["officephone"].ToString()))
                        allcontact.offphone = dt.Rows[j]["officephone"].ToString();
                    else
                        allcontact.offphone = string.Empty;
                    if (!string.IsNullOrEmpty(dt.Rows[j]["name"].ToString()))
                        allcontact.Name = dt.Rows[j]["name"].ToString();
                    else
                        allcontact.Name = string.Empty;
                    if (!string.IsNullOrEmpty(dt.Rows[j]["mainid"].ToString()))
                        allcontact.mainurl = dt.Rows[j]["mainid"].ToString();
                    else
                        allcontact.mainurl = string.Empty;
                    clientList.Add(allcontact);


                }
            }
            return View(clientList);
        }
    }
}
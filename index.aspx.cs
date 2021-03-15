using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace MedicalRecord
{
    public partial class index : System.Web.UI.Page
    {
        //实现导出Excel表格
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();
                TextBox12a.Text = DateTime.Now.Hour.ToString();//时
                TextBox12b.Text = DateTime.Now.Minute.ToString();//分
                TextBox12c.Text = DateTime.Now.Second.ToString();//秒

                TextBox13a.Text = DateTime.Now.Hour.ToString();//时
                TextBox13b.Text = DateTime.Now.Minute.ToString();//分
                TextBox13c.Text = DateTime.Now.Second.ToString();//秒

                TextBox41.Text = DateTime.Now.Hour.ToString();//时
                TextBox42.Text = DateTime.Now.Minute.ToString();//分
                TextBox43.Text = DateTime.Now.Second.ToString();//秒

                TextBox45.Text = DateTime.Now.Hour.ToString();//时
                TextBox46.Text = DateTime.Now.Minute.ToString();//分
                TextBox47.Text = DateTime.Now.Second.ToString();//秒

                TextBox49.Text = DateTime.Now.Hour.ToString();//时
                TextBox50.Text = DateTime.Now.Minute.ToString();//分
                TextBox51.Text = DateTime.Now.Second.ToString();//秒

                TextBox60.Text = DateTime.Now.Hour.ToString();//时
                TextBox61.Text = DateTime.Now.Minute.ToString();//分
                TextBox62.Text = DateTime.Now.Second.ToString();//秒

                TextBox64.Text = DateTime.Now.Hour.ToString();//时
                TextBox65.Text = DateTime.Now.Minute.ToString();//分
                TextBox66.Text = DateTime.Now.Second.ToString();//秒

                TextBox68.Text = DateTime.Now.Hour.ToString();//时
                TextBox69.Text = DateTime.Now.Minute.ToString();//分
                TextBox70.Text = DateTime.Now.Second.ToString();//秒 

            }

            if (TextBox184 != null)
            {
                Label389.Text = TextBox184.Text;
                Label392.Text = TextBox184.Text;
            }

            if (TextBox186 != null)
            {
                Label398.Text = TextBox186.Text;
            }

            if (TextBox185 != null)
            {
                Label416.Text = TextBox185.Text;
            }
        }
        protected void paging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindData();
        }
        private void BindData()
        {
            // make the query
            string query = "SELECT * FROM a入院概要";
            SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString());
            SqlDataAdapter ad = new SqlDataAdapter(query, myConnection);
            DataSet ds = new DataSet();
            ad.Fill(ds, "customers");
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindData();
        }

        //实现页面的层次分类
        //
        protected void Menu2_MenuItemClick(object sender, MenuEventArgs e)
        {
            switch (Menu2.SelectedValue)
            {
                case "基线采集"://这个值是在Menu中加入Item时设定的
                    {
                        MultiView2.ActiveViewIndex = 0;
                        break;
                    }
                case "前哨淋巴结":
                    {
                        MultiView2.ActiveViewIndex = 1;
                        break;
                    }
                case "化疗":
                    {
                        MultiView2.ActiveViewIndex = 2;
                        break;
                    }
                case "随访":
                    {
                        MultiView2.ActiveViewIndex = 3;
                        break;
                    }
                case "根治术":
                    {
                        MultiView2.ActiveViewIndex = 4;
                        break;
                    }
                case "保乳术":
                    {
                        MultiView2.ActiveViewIndex = 5;
                        break;
                    }
                default:
                    break;
            }
        }

        //下面是“基线采集”页面分层
        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            switch (Menu1.SelectedValue)
            {
                case "1"://这个值是在Menu中加入Item时设定的
                    {
                        MultiView1.ActiveViewIndex = 0;
                        break;
                    }
                case "2":
                    {
                        MultiView1.ActiveViewIndex = 1;
                        break;
                    }
                case "3":
                    {
                        MultiView1.ActiveViewIndex = 2;
                        break;
                    }
                case "4":
                    {
                        MultiView1.ActiveViewIndex = 3;
                        break;
                    }
                case "5":
                    {
                        MultiView1.ActiveViewIndex = 4;
                        break;
                    }
                case "6":
                    {
                        MultiView1.ActiveViewIndex = 5;
                        break;
                    }
                case "7":
                    {
                        MultiView1.ActiveViewIndex = 6;
                        break;
                    }

                default:
                    break;
            }
        }

        //下面是“前哨淋巴结”页面
        protected void Menu3_MenuItemClick(object sender, MenuEventArgs e)
        {
            switch (Menu3.SelectedValue)
            {
                case "1"://这个值是在Menu中加入Item时设定的
                    {
                        MultiView3.ActiveViewIndex = 0;
                        break;
                    }
                case "2":
                    {
                        MultiView3.ActiveViewIndex = 1;
                        break;
                    }
                case "3":
                    {
                        MultiView3.ActiveViewIndex = 2;
                        break;
                    }
                case "4":
                    {
                        MultiView3.ActiveViewIndex = 3;
                        break;
                    }
                default:
                    break;
            }
        }

        //下面是“化疗”页面
        protected void Menu7_MenuItemClick(object sender, MenuEventArgs e)
        {
            switch (Menu7.SelectedValue)
            {
                case "1"://这个值是在Menu中加入Item时设定的
                    {
                        MultiView7.ActiveViewIndex = 0;
                        break;
                    }
                case "2":
                    {
                        MultiView7.ActiveViewIndex = 1;
                        break;
                    }
                default:
                    break;
            }
        }

        //下面是“随访”页面
        protected void Menu4_MenuItemClick(object sender, MenuEventArgs e)
        {
            switch (Menu4.SelectedValue)
            {
                case "1"://这个值是在Menu中加入Item时设定的
                    {
                        MultiView4.ActiveViewIndex = 0;
                        break;
                    }
                case "2":
                    {
                        MultiView4.ActiveViewIndex = 1;
                        break;
                    }
                case "3":
                    {
                        MultiView4.ActiveViewIndex = 2;
                        break;
                    }
                default:
                    break;
            }
        }

        //下面是“根治术”下面的3个页面
        protected void Menu6_MenuItemClick(object sender, MenuEventArgs e)
        {
            switch (Menu6.SelectedValue)
            {
                case "1"://这个值是在Menu中加入Item时设定的
                    {
                        MultiView6.ActiveViewIndex = 0;
                        break;
                    }
                case "2":
                    {
                        MultiView6.ActiveViewIndex = 1;
                        break;
                    }
                case "3":
                    {
                        MultiView6.ActiveViewIndex = 2;
                        break;
                    }
                default:
                    break;
            }
        }

        //下面是“保乳术”下面的5个页面
        protected void Menu5_MenuItemClick(object sender, MenuEventArgs e)
        {
            switch (Menu5.SelectedValue)
            {
                case "1"://这个值是在Menu中加入Item时设定的
                    {
                        MultiView5.ActiveViewIndex = 0;
                        break;
                    }
                case "2":
                    {
                        MultiView5.ActiveViewIndex = 1;
                        break;
                    }
                case "3":
                    {
                        MultiView5.ActiveViewIndex = 2;
                        break;
                    }
                case "4":
                    {
                        MultiView5.ActiveViewIndex = 3;
                        break;
                    }
                case "5":
                    {
                        MultiView5.ActiveViewIndex = 4;
                        break;
                    }
                default:
                    break;
            }
        }

        //实现只有在选中特定单元格时才能出现特定内容
        //a3页面
        protected void DropDownList41_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList41.SelectedValue == "有")
            {
                TextBox244.Visible = true;
            }
            else TextBox244.Visible = false;
        }

        protected void DropDownList42_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList42.SelectedValue == "有")
            {
                TextBox245.Visible = true;
            }
            else TextBox245.Visible = false;
        }

        protected void DropDownList48_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList48.SelectedValue == "有")
            {
                Panel78.Visible = true;
            }
            else Panel78.Visible = false;
        }

        //a5
        protected void DropDownList51_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList51.SelectedValue == "已婚")
            {
                Panel79.Visible = true;
            }
            else Panel79.Visible = false;

        }

        protected void DropDownList54_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList54.SelectedValue != "体健")
            {
                Panel80.Visible = true;
            }
            else Panel80.Visible = false;
        }

        protected void DropDownList55_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList55.SelectedValue != "体健")
            {
                Panel81.Visible = true;
            }
            else Panel81.Visible = false;
        }

        protected void DropDownList75_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList75.SelectedValue == "有")
            {
                Panel82.Visible = true;
            }
            else Panel82.Visible = false;
        }

        //“基线采集-身体状况”页面
        protected void DropDownList7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList7.Text == "否")
            {
                Panel1.Visible = true;
                Panel2.Visible = true;
            }
            else
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
            }
        }
        protected void DropDownList8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList8.Text == "有")
            {
                Panel3.Visible = true;
            }
            else
            {
                Panel3.Visible = false;
            }
        }

        protected void DropDownList9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList9.Text == "有")
            {
                Panel73.Visible = true;
            }
            else
            {
                Panel73.Visible = false;
            }
        }

        protected void DropDownList10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList10.Text == "有")
            {
                Panel74.Visible = true;
            }
            else
            {
                Panel74.Visible = false;
            }
        }

        protected void DropDownList11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList11.Text == "有")
            {
                Panel75.Visible = true;
            }
            else
            {
                Panel75.Visible = false;
            }
        }

        protected void DropDownList97_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList97.Text == "有")
            {
                Panel76.Visible = true;
            }
            else
            {
                Panel76.Visible = false;
            }
        }

        protected void DropDownList98_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList98.Text == "有")
            {
                Panel77.Visible = true;
            }
            else
            {
                Panel77.Visible = false;
            }
        }

        //a6
        protected void DropDownList57_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList57.Text == "卫星结节")
            {
                TextBox314.Visible = true;
                Label386.Visible = true;
            }
            else
            {
                TextBox314.Visible = false;
                Label386.Visible = false;
            }
        }

        protected void DropDownList58_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList58.Text == "湿疹样")
            {
                Panel83.Visible = true;
            }
            else
            {
                Panel83.Visible = false;
            }
        }

        protected void DropDownList59_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList59.Text == "有")
            {
                Panel84.Visible = true;
            }
            else
            {
                Panel84.Visible = false;
            }
        }

        protected void DropDownList63_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList63.Text == "有")
            {
                Panel85.Visible = true;
                Panel86.Visible = true;
            }
            else
            {
                Panel85.Visible = false;
                Panel86.Visible = false;
            }
        }

        protected void DropDownList80_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList80.Text == "有")
            {
                Label361.Visible = true;
                TextBox294.Visible = true;
                Label362.Visible = true;
                TextBox295.Visible = true;
                DropDownList81.Visible = true;
                DropDownList82.Visible = true;
            }
            else
            {
                Label361.Visible = false;
                TextBox294.Visible = false;
                Label362.Visible = false;
                TextBox295.Visible = false;
                DropDownList81.Visible = false;
                DropDownList82.Visible = false;
            }
        }

        protected void DropDownList83_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList83.Text == "有")
            {
                Label364.Visible = true;
                TextBox296.Visible = true;
                Label365.Visible = true;
                TextBox297.Visible = true;
                DropDownList84.Visible = true;
                DropDownList85.Visible = true;
            }
            else
            {
                Label364.Visible = false;
                TextBox296.Visible = false;
                Label365.Visible = false;
                TextBox297.Visible = false;
                DropDownList84.Visible = false;
                DropDownList85.Visible = false;
            }
        }

        protected void DropDownList86_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList86.Text == "有")
            {
                Label367.Visible = true;
                TextBox298.Visible = true;
                Label368.Visible = true;
                TextBox299.Visible = true;
                DropDownList87.Visible = true;
                DropDownList88.Visible = true;
            }
            else
            {
                Label367.Visible = false;
                TextBox298.Visible = false;
                Label368.Visible = false;
                TextBox299.Visible = false;
                DropDownList87.Visible = false;
                DropDownList88.Visible = false;
            }
        }

        protected void DropDownList89_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList89.Text == "有")
            {
                Label370.Visible = true;
                TextBox300.Visible = true;
                Label371.Visible = true;
                TextBox301.Visible = true;
                DropDownList90.Visible = true;
                DropDownList91.Visible = true;
            }
            else
            {
                Label370.Visible = false;
                TextBox300.Visible = false;
                Label371.Visible = false;
                TextBox301.Visible = false;
                DropDownList90.Visible = false;
                DropDownList91.Visible = false;
            }
        }

        //a7
        protected void DropDownList65_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList65.Text == "有")
            {
                Panel87.Visible = true;
            }
            else
            {
                Panel87.Visible = false;
            }
        }

        protected void DropDownList66_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList66.Text == "有")
            {
                Panel88.Visible = true;
            }
            else
            {
                Panel88.Visible = false;
            }
        }

        //实现“只有在选择特定项时才能进行某些项的操作”
        //
        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedValue == "阴性")
            {
                Panel14.Enabled = false;
            }
            else Panel14.Enabled = true;
        }

        protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList2.SelectedValue == "无")
            {
                Panel15.Enabled = false;
            }
            else Panel15.Enabled = true;
        }

        protected void RadioButtonList4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList4.SelectedValue == "无")
            {
                Panel16.Enabled = false;
            }
            else Panel16.Enabled = true;
        }

        protected void RadioButtonList6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList6.SelectedValue == "无")
            {
                Panel17.Enabled = false;
            }
            else Panel17.Enabled = true;
        }

        protected void RadioButtonList8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList8.SelectedValue == "无")
            {
                Panel18.Enabled = false;
            }
            else Panel18.Enabled = true;
        }

        protected void DropDownList13_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList13.SelectedValue == "联合法")
            {
                TextBox164.Enabled = true;
            }
            else TextBox164.Enabled = false;
        }

        protected void RadioButtonList10_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (RadioButtonList10.SelectedValue)
            {
                case "乳晕":
                    {
                        TextBox38.Enabled = true;
                        TextBox39.Enabled = false;
                        break;
                    }
                case "肿瘤":
                    {
                        TextBox39.Enabled = true;
                        TextBox38.Enabled = false;
                        break;
                    }
                case "淋巴结内":
                    {
                        TextBox39.Enabled = false;
                        TextBox38.Enabled = false;
                        break;
                    }
                default:
                    break;
            }
        }

        protected void DropDownList21_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList21.SelectedValue == "其它")
            {
                TextBox165.Enabled = true;
            }
            else TextBox165.Enabled = false;
        }

        protected void DropDownList22_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList22.SelectedValue == "联合法")
            {
                TextBox166.Enabled = true;
            }
            else TextBox166.Enabled = false;
        }

        protected void RadioButtonList11_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (RadioButtonList11.SelectedValue)
            {
                case "肱二头肌、肱三头肌间沟":
                    {
                        TextBox57.Enabled = true;
                        TextBox58.Enabled = false;
                        break;
                    }
                case "其它":
                    {
                        TextBox58.Enabled = true;
                        TextBox57.Enabled = false;
                        break;
                    }
                default:
                    break;
            }
        }

        protected void RadioButtonList12_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (RadioButtonList12.SelectedValue)
            {
                case "SNL病理":
                    {
                        TextBox71.Enabled = true;
                        TextBox73.Enabled = true;

                        TextBox72.Enabled = false;
                        TextBox76.Enabled = false;
                        break;
                    }
                case "ARM病理":
                    {
                        TextBox71.Enabled = false;
                        TextBox73.Enabled = false;

                        TextBox72.Enabled = true;
                        TextBox76.Enabled = true;
                        break;
                    }
                default:
                    break;
            }
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                TextBox134.Enabled = true;
            }
            else TextBox134.Enabled = false;
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked)
            {
                TextBox135.Enabled = true;
            }
            else TextBox135.Enabled = false;
        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox3.Checked)
            {
                TextBox136.Enabled = true;
            }
            else TextBox136.Enabled = false;
        }

        protected void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox4.Checked)
            {
                TextBox137.Enabled = true;
            }
            else TextBox137.Enabled = false;
        }

        protected void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox5.Checked)
            {
                TextBox138.Enabled = true;
            }
            else TextBox138.Enabled = false;
        }

        protected void RadioButtonList17_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList17.SelectedValue == "异常")
            {
                TextBox140.Enabled = true;
            }
            else TextBox140.Enabled = false;
        }

        protected void RadioButtonList18_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList18.SelectedValue == "异常")
            {
                TextBox145.Enabled = true;
            }
            else TextBox145.Enabled = false;
        }

        protected void RadioButtonList15_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList15.SelectedValue == "异常")
            {
                TextBox142.Enabled = true;
            }
            else TextBox142.Enabled = false;
        }

        protected void RadioButtonList16_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList16.SelectedValue == "异常")
            {
                TextBox144.Enabled = true;
            }
            else TextBox144.Enabled = false;
        }

        protected void RadioButtonList13_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList13.SelectedValue == "异常")
            {
                TextBox141.Enabled = true;
            }
            else TextBox141.Enabled = false;
        }

        protected void RadioButtonList14_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList14.SelectedValue == "异常")
            {
                TextBox147.Enabled = true;
            }
            else TextBox147.Enabled = false;
        }

        protected void RadioButtonList19_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList19.SelectedValue == "异常")
            {
                TextBox150.Enabled = true;
            }
            else TextBox150.Enabled = false;
        }

        protected void RadioButtonList20_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList20.SelectedValue == "异常")
            {
                TextBox153.Enabled = true;
            }
            else TextBox153.Enabled = false;
        }

        protected void RadioButtonList21_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList21.SelectedValue == "异常")
            {
                TextBox156.Enabled = true;
            }
            else TextBox156.Enabled = false;
        }

        protected void RadioButtonList22_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList22.SelectedValue == "异常")
            {
                TextBox159.Enabled = true;
            }
            else TextBox159.Enabled = false;
        }

        protected void RadioButtonList23_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList23.SelectedValue == "正常")
            {
                TextBox162.Enabled = false;
            }
            else TextBox162.Enabled = true;
        }

        protected void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox6.Checked)
            {
                TextBox143.Enabled = true;
            }
            else TextBox143.Enabled = false;
        }

        protected void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox7.Checked)
            {
                TextBox146.Enabled = true;
            }
            else TextBox146.Enabled = false;
        }

        protected void CheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox8.Checked)
            {
                TextBox148.Enabled = true;
            }
            else TextBox148.Enabled = false;
        }

        protected void CheckBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox9.Checked)
            {
                TextBox149.Enabled = true;
            }
            else TextBox149.Enabled = false;
        }

        protected void CheckBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox10.Checked)
            {
                TextBox151.Enabled = true;
            }
            else TextBox151.Enabled = false;
        }

        protected void CheckBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox11.Checked)
            {
                TextBox152.Enabled = true;
            }
            else TextBox152.Enabled = false;
        }

        protected void CheckBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox12.Checked)
            {
                TextBox154.Enabled = true;
            }
            else TextBox154.Enabled = false;
        }

        protected void CheckBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox13.Checked)
            {
                TextBox155.Enabled = true;
            }
            else TextBox155.Enabled = false;
        }

        protected void CheckBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox14.Checked)
            {
                TextBox157.Enabled = true;
            }
            else TextBox157.Enabled = false;
        }

        protected void CheckBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox15.Checked)
            {
                TextBox158.Enabled = true;
            }
            else TextBox158.Enabled = false;
        }

        protected void CheckBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox16.Checked)
            {
                TextBox160.Enabled = true;
            }
            else TextBox160.Enabled = false;
        }

        protected void CheckBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox17.Checked)
            {
                TextBox161.Enabled = true;
            }
            else TextBox161.Enabled = false;
        }

        //术前化疗的选项内容
        protected void RadioButton150_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton150.Checked == true)
            {
                Panel66.Enabled = true;
            }
        }

        //术前化疗否选项内容
        protected void RadioButton151_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton151.Checked == true)
            {
                Panel66.Enabled = false;
            }
        }
        //术后化疗是选项内容
        protected void RadioButton152_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton152.Checked == true)
            {
                Panel68.Enabled = true;
            }
        }
        //术后化疗否选项内容
        protected void RadioButton153_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton153.Checked == true)
            {
                Panel68.Enabled = false;
            }
        }

        //f3页面
        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton3.Checked == true)
            {
                TextBox310.Enabled = true;
            }
        }

        protected void RadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton7.Checked == true)
            {
                RadioButton8.Enabled = true;
                RadioButton9.Enabled = true;
                TextBox196.Enabled = true;
            }
        }

        protected void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton6.Checked == true)
            {
                RadioButton8.Enabled = false;
                RadioButton9.Enabled = false;
                TextBox196.Enabled = false;
            }
        }

        protected void RadioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton14.Checked == true)
            {
                TextBox311.Enabled = false;
            }
        }

        protected void RadioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton15.Checked == true)
            {
                TextBox311.Enabled = true;
            }
        }

        //f4页面
        protected void RadioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (f4Rb1.Checked == true)
            {
                f4Tb3.Enabled = false;
            }
        }
        protected void RadioButton17_CheckedChanged(object sender, EventArgs e)
        {
            if (f4Rb2.Checked == true)
            {
                f4Tb3.Enabled = true;
            }
        }

        //点击“确定”时将页面中写的内容存入数据库
        //将“基线采集-入院概要”页面内容存进数据库
        protected void Button1_Click(object sender, EventArgs e)
        {
            //判断就诊卡号是否填写
            if (TextBox2.Text == "")
            {
                Response.Write("<script language='javascript'>alert('请填写就诊卡号！')</script>");
            }
            else
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString());
                string conStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

                //a1页面
                int intAddCount_a1 = new int();
                SqlConnection sqlconn_a1 = new SqlConnection(conStr);
                SqlCommand sqlcommand_a1 = new SqlCommand();
                sqlcommand_a1.Connection = sqlconn_a1;
                sqlcommand_a1.CommandText = "INSERT INTO a入院概要(姓名,就诊卡号,性别,年龄,婚姻,籍贯,民族,职业,工作单位,住院号,现住址,病史陈述者,与患者关系,联系电话,入院日期,记录日期) VALUES (@姓名,@就诊卡号,@性别,@年龄,@婚姻,@籍贯,@民族,@职业,@工作单位,@住院号,@现住址,@病史陈述者,@与患者关系,@联系电话,@入院日期,@记录日期)";
                sqlcommand_a1.Parameters.AddWithValue("@姓名", TextBox1.Text);
                sqlcommand_a1.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);
                sqlcommand_a1.Parameters.AddWithValue("@性别", TextBox3.Text);
                sqlcommand_a1.Parameters.AddWithValue("@年龄", TextBox4.Text);
                sqlcommand_a1.Parameters.AddWithValue("@婚姻", TextBox5.Text);
                sqlcommand_a1.Parameters.AddWithValue("@籍贯", TextBox6.Text);
                sqlcommand_a1.Parameters.AddWithValue("@民族", TextBox7.Text);
                sqlcommand_a1.Parameters.AddWithValue("@职业", TextBox8.Text);
                sqlcommand_a1.Parameters.AddWithValue("@工作单位", TextBox9.Text);
                sqlcommand_a1.Parameters.AddWithValue("@住院号", TextBox10.Text);
                sqlcommand_a1.Parameters.AddWithValue("@现住址", TextBox11.Text);
                sqlcommand_a1.Parameters.AddWithValue("@病史陈述者", TextBox14.Text);
                sqlcommand_a1.Parameters.AddWithValue("@与患者关系", TextBox15.Text);
                sqlcommand_a1.Parameters.AddWithValue("@联系电话", TextBox16.Text);

                sqlcommand_a1.Parameters.AddWithValue("@入院日期", TextBox12.Text + " " + TextBox12a.Text + ":" + TextBox12b.Text + ":" + TextBox12c.Text);
                sqlcommand_a1.Parameters.AddWithValue("@记录日期", TextBox13.Text + " " + TextBox13a.Text + ":" + TextBox13b.Text + ":" + TextBox13c.Text);
                try
                {
                    sqlconn_a1.Open();
                    intAddCount_a1 = sqlcommand_a1.ExecuteNonQuery();

                    if (sqlcommand_a1.ExecuteNonQuery() > 0)
                    {
                        Label43.Text = "添加成功！";
                    }
                    else
                    {
                        Label43.Text = "添加失败！";
                    }
                }
                catch (Exception ex) { Label43.Text = ex.Message; }
                finally
                {
                    sqlcommand_a1 = null;
                    sqlconn_a1.Close();
                    sqlconn_a1 = null;
                }

                //将“基线采集-主诉”页面值存入数据库
                int intAddCount_a2 = new int();
                SqlConnection sqlconn_a2 = new SqlConnection(conStr);
                SqlCommand sqlcommand_a2 = new SqlCommand();
                sqlcommand_a2.Connection = sqlconn_a2;
                sqlcommand_a2.CommandText = "INSERT INTO a主诉(就诊卡号,主要症状_侧别,主要症状_位置,主要症状,主要症状_时间,伴随症状_侧别,伴随症状_位置,伴随症状,伴随症状_时间,增大时长,转为血性时长)" +
                    "VALUES (@就诊卡号,@主要症状_侧别,@主要症状_位置,@主要症状,@主要症状_时间,@伴随症状_侧别,@伴随症状_位置,@伴随症状,@伴随症状_时间,@增大时长,@转为血性时长)";
                sqlcommand_a2.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);
                sqlcommand_a2.Parameters.AddWithValue("@主要症状_侧别", DropDownList31.Text);
                sqlcommand_a2.Parameters.AddWithValue("@主要症状_位置", DropDownList32.Text);
                string a1 = ""; string a2 = " "; string a3 = ""; string a4 = ""; string a5 = ""; string a6 = ""; string a7 = ""; string a8 = "";
                if (CheckBox33.Checked) { a1 = CheckBox33.Text; }
                if (CheckBox34.Checked) { a2 = CheckBox34.Text; }
                if (CheckBox35.Checked) { a3 = CheckBox35.Text; }
                if (CheckBox36.Checked) { a4 = CheckBox36.Text; }
                if (CheckBox37.Checked) { a5 = CheckBox37.Text; }
                if (CheckBox38.Checked) { a6 = CheckBox38.Text; }
                if (CheckBox39.Checked) { a7 = CheckBox39.Text; }
                if (CheckBox40.Checked) { a8 = CheckBox40.Text; }
                sqlcommand_a2.Parameters.AddWithValue("@主要症状", a1 + " " + a2 + " " + a3 + " " + a4 + " " + a5 + " " + a6 + " " + a7 + " " + a8);
                sqlcommand_a2.Parameters.AddWithValue("@主要症状_时间", TextBox239.Text + DropDownList33.Text);
                sqlcommand_a2.Parameters.AddWithValue("@伴随症状_侧别", DropDownList34.Text);
                sqlcommand_a2.Parameters.AddWithValue("@伴随症状_位置", DropDownList35.Text);

                string b1 = ""; string b2 = ""; string b3 = ""; string b4 = ""; string b5 = ""; string b6 = ""; string b7 = ""; string b8 = "";
                if (CheckBox41.Checked) { b1 = CheckBox41.Text; }
                if (CheckBox42.Checked) { b2 = CheckBox42.Text; }
                if (CheckBox43.Checked) { b3 = CheckBox43.Text; }
                if (CheckBox44.Checked) { b4 = CheckBox44.Text; }
                if (CheckBox45.Checked) { b5 = CheckBox45.Text; }
                if (CheckBox46.Checked) { b6 = CheckBox46.Text; }
                if (CheckBox47.Checked) { b7 = CheckBox47.Text; }
                if (CheckBox48.Checked) { b8 = CheckBox48.Text; }
                sqlcommand_a2.Parameters.AddWithValue("@伴随症状", b1 + " " + b2 + " " + b3 + " " + b4 + " " + b5 + " " + b6 + " " + b7 + " " + b8);

                sqlcommand_a2.Parameters.AddWithValue("@伴随症状_时间", TextBox240.Text + DropDownList36.Text);
                sqlcommand_a2.Parameters.AddWithValue("@增大时长", TextBox241.Text + DropDownList37.Text);
                sqlcommand_a2.Parameters.AddWithValue("@转为血性时长", TextBox242.Text + DropDownList38.Text);

                try
                {
                    sqlconn_a2.Open();
                    intAddCount_a2 = sqlcommand_a2.ExecuteNonQuery();

                    if (sqlcommand_a2.ExecuteNonQuery() > 0)
                    {
                        Label407.Text = "添加成功！";
                    }
                    else
                    {
                        Label407.Text = "添加失败！";
                    }
                }
                catch (Exception ex2) { Label407.Text = ex2.Message; }
                finally
                {
                    sqlcommand_a2 = null;
                    sqlconn_a2.Close();
                    sqlconn_a2 = null;
                }

                //将“基线采集-现病史”页面值存入数据库
                int intAddCount_a3 = new int();
                SqlConnection sqlconn_a3 = new SqlConnection(conStr);
                SqlCommand sqlcommand_a3 = new SqlCommand();
                sqlcommand_a3.Connection = sqlconn_a3;
                sqlcommand_a3.CommandText = "INSERT INTO a现病史(就诊卡号,发现时长,发现原因,诱因,病因,肿瘤大小,压痛情况,乳头溢液,溢液数量,溢液动能,溢液性状,就诊经历,就诊地点,就诊过程,诊疗疗效,诊疗转归,诱因详情,病因详情,诊疗转归_2)" +
                    "VALUES (@就诊卡号,@发现时长,@发现原因,@诱因,@病因,@肿瘤大小,@压痛情况,@乳头溢液,@溢液数量,@溢液动能,@溢液性状,@就诊经历,@就诊地点,@就诊过程,@诊疗疗效,@诊疗转归,@诱因详情,@病因详情,@诊疗转归_2)";
                sqlcommand_a3.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);
                sqlcommand_a3.Parameters.AddWithValue("@发现时长", TextBox243.Text + DropDownList39.Text);
                sqlcommand_a3.Parameters.AddWithValue("@发现原因", DropDownList40.Text);
                //完全改了
                sqlcommand_a3.Parameters.AddWithValue("@诱因", DropDownList41.Text);
                sqlcommand_a3.Parameters.AddWithValue("@诱因详情", TextBox244.Text);

                sqlcommand_a3.Parameters.AddWithValue("@病因", DropDownList42.Text);
                sqlcommand_a3.Parameters.AddWithValue("@病因详情", TextBox245.Text);
                //
                sqlcommand_a3.Parameters.AddWithValue("@肿瘤大小", TextBox283.Text + "*" + TextBox284.Text);
                sqlcommand_a3.Parameters.AddWithValue("@压痛情况", DropDownList43.Text);
                sqlcommand_a3.Parameters.AddWithValue("@乳头溢液", DropDownList44.Text);
                sqlcommand_a3.Parameters.AddWithValue("@溢液数量", DropDownList45.Text);
                sqlcommand_a3.Parameters.AddWithValue("@溢液动能", DropDownList46.Text);
                sqlcommand_a3.Parameters.AddWithValue("@溢液性状", DropDownList47.Text);
                sqlcommand_a3.Parameters.AddWithValue("@就诊经历", DropDownList48.Text);
                sqlcommand_a3.Parameters.AddWithValue("@就诊地点", TextBox285.Text);
                sqlcommand_a3.Parameters.AddWithValue("@就诊过程", TextBox286.Text);
                sqlcommand_a3.Parameters.AddWithValue("@诊疗疗效", DropDownList96.Text);
                //修改和增加
                sqlcommand_a3.Parameters.AddWithValue("@诊疗转归", DropDownList49.Text);
                sqlcommand_a3.Parameters.AddWithValue("@诊疗转归_2", DropDownList50.Text);
                //

                try
                {
                    sqlconn_a3.Open();
                    intAddCount_a3 = sqlcommand_a3.ExecuteNonQuery();

                    if (sqlcommand_a3.ExecuteNonQuery() > 0)
                    {
                        Label408.Text = "添加成功！";
                    }
                    else
                    {
                        Label408.Text = "添加失败！";
                    }
                }
                catch (Exception ex3) { Label408.Text = ex3.Message; }
                finally
                {
                    sqlcommand_a3 = null;
                    sqlconn_a3.Close();
                    sqlconn_a3 = null;
                }

                //将“基线采集-身体状况”页面值读入数据库
                int intAddCount_a4 = new int();
                SqlConnection sqlconn_a4 = new SqlConnection(conStr);
                SqlCommand sqlcommand_a4 = new SqlCommand();
                sqlcommand_a4.Connection = sqlconn_a4;
                sqlcommand_a4.CommandText = "INSERT INTO a身体状况(就诊卡号,一般状况,精神,食睡,二便,体重,体力,既往体健,疾病史冠心病,疾病史糖尿病,疾病史高血压,疾病史甲亢病,手术史,手术史_时间,手术史_于何处,进行何种手术,外伤史,输血史,过敏史,外伤史_时间,外伤史_于何处,受过何种外伤,输血史_时间,输血史_于何处,因何输血,食物有无,药物有无,食物详情,药物详情)" +
                    "VALUES (@就诊卡号,@一般状况,@精神,@食睡,@二便,@体重,@体力,@既往体健,@疾病史冠心病,@疾病史糖尿病,@疾病史高血压,@疾病史甲亢病,@手术史,@手术史_时间,@手术史_于何处,@进行何种手术,@外伤史,@输血史,@过敏史,@外伤史_时间,@外伤史_于何处,@受过何种外伤 ,@输血史_时间,@输血史_于何处,@因何输血,@食物有无,@药物有无,@食物详情,@药物详情)";

                sqlcommand_a4.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);
                sqlcommand_a4.Parameters.AddWithValue("@一般状况", DropDownList1.Text);
                sqlcommand_a4.Parameters.AddWithValue("@精神", DropDownList2.Text);
                sqlcommand_a4.Parameters.AddWithValue("@食睡", DropDownList3.Text);
                sqlcommand_a4.Parameters.AddWithValue("@二便", DropDownList4.Text);
                sqlcommand_a4.Parameters.AddWithValue("@体重", DropDownList5.Text);
                sqlcommand_a4.Parameters.AddWithValue("@体力", DropDownList6.Text);
                sqlcommand_a4.Parameters.AddWithValue("@既往体健", DropDownList7.Text);
                sqlcommand_a4.Parameters.AddWithValue("@疾病史冠心病", TextBox17.Text);
                sqlcommand_a4.Parameters.AddWithValue("@疾病史糖尿病", TextBox18.Text);
                sqlcommand_a4.Parameters.AddWithValue("@疾病史高血压", TextBox19.Text);
                sqlcommand_a4.Parameters.AddWithValue("@疾病史甲亢病", TextBox20.Text);
                sqlcommand_a4.Parameters.AddWithValue("@手术史", DropDownList8.Text);
                //更改的
                sqlcommand_a4.Parameters.AddWithValue("@手术史_时间", TextBox21.Text);
                sqlcommand_a4.Parameters.AddWithValue("@手术史_于何处", TextBox22.Text);
                //
                sqlcommand_a4.Parameters.AddWithValue("@进行何种手术", TextBox23.Text);
                sqlcommand_a4.Parameters.AddWithValue("@外伤史", DropDownList9.Text);
                //新增的
                sqlcommand_a4.Parameters.AddWithValue("@外伤史_时间", TextBox302.Text);
                sqlcommand_a4.Parameters.AddWithValue("@外伤史_于何处", TextBox303.Text);
                sqlcommand_a4.Parameters.AddWithValue("@受过何种外伤", TextBox304.Text);
                //
                sqlcommand_a4.Parameters.AddWithValue("@输血史", DropDownList10.Text);
                //新增的
                sqlcommand_a4.Parameters.AddWithValue("@输血史_时间", TextBox305.Text);
                sqlcommand_a4.Parameters.AddWithValue("@输血史_于何处", TextBox306.Text);
                sqlcommand_a4.Parameters.AddWithValue("@因何输血", TextBox307.Text);
                //
                sqlcommand_a4.Parameters.AddWithValue("@过敏史", DropDownList11.Text);
                //新增的
                sqlcommand_a4.Parameters.AddWithValue("@食物有无", DropDownList97.Text);
                sqlcommand_a4.Parameters.AddWithValue("@药物有无", DropDownList98.Text);
                sqlcommand_a4.Parameters.AddWithValue("@食物详情", TextBox308.Text);
                sqlcommand_a4.Parameters.AddWithValue("@药物详情", TextBox309.Text);
                //

                try
                {
                    sqlconn_a4.Open();
                    intAddCount_a4 = sqlcommand_a4.ExecuteNonQuery();

                    if (sqlcommand_a4.ExecuteNonQuery() > 0)
                    {
                        Label44.Text = "添加成功！";
                    }
                    else
                    {
                        Label44.Text = "添加失败！";
                    }
                }
                catch (Exception ex) { Label44.Text = ex.Message; }
                finally
                {
                    sqlcommand_a4 = null;
                    sqlconn_a4.Close();
                    sqlconn_a4 = null;
                }

                //将“基线采集-个人情况”页面值读入数据库
                int intAddCount_a5 = new int();
                SqlConnection sqlconn_a5 = new SqlConnection(conStr);
                SqlCommand sqlcommand_a5 = new SqlCommand();
                sqlcommand_a5.Connection = sqlconn_a5;
                sqlcommand_a5.CommandText = "INSERT INTO a个人情况(就诊卡号,身高,体重,T值,P值,R值,BP值,KPS值,BSA值,出生地,生长接触史,烟酒详情,初潮年龄,绝经年龄,末次月经,痛经情况,结婚情况,结婚年龄,配偶情况,P,A,G,哺乳情况,哺乳侧别,持续时间,子女情况,父亲情况,母亲情况,家族恶性肿瘤史,初潮年龄_分子,初潮年龄_分母,父亲详情,母亲详情,家族详情)" +
                    "VALUES (@就诊卡号,@身高,@体重,@T值,@P值,@R值,@BP值,@KPS值,@BSA值,@出生地,@生长接触史,@烟酒详情,@初潮年龄,@绝经年龄,@末次月经,@痛经情况,@结婚情况,@结婚年龄,@配偶情况,@P,@A,@G,@哺乳情况,@哺乳侧别,@持续时间,@子女情况,@父亲情况,@母亲情况,@家族恶性肿瘤史,@初潮年龄_分子,@初潮年龄_分母,@父亲详情,@母亲详情,@家族详情)";

                sqlcommand_a5.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);
                sqlcommand_a5.Parameters.AddWithValue("@身高", TextBox246.Text);
                sqlcommand_a5.Parameters.AddWithValue("@体重", TextBox247.Text);
                sqlcommand_a5.Parameters.AddWithValue("@T值", TextBox248.Text);
                sqlcommand_a5.Parameters.AddWithValue("@P值", TextBox249.Text);
                sqlcommand_a5.Parameters.AddWithValue("@R值", TextBox250.Text);
                sqlcommand_a5.Parameters.AddWithValue("@BP值", TextBox251.Text);
                sqlcommand_a5.Parameters.AddWithValue("@KPS值", TextBox252.Text);
                sqlcommand_a5.Parameters.AddWithValue("@BSA值", TextBox253.Text);
                sqlcommand_a5.Parameters.AddWithValue("@出生地", TextBox254.Text);

                string e1 = ""; string e2 = " "; string e3 = ""; string e4 = ""; string e5 = "";
                if (CheckBox49.Checked) { e1 = CheckBox49.Text; }
                if (CheckBox50.Checked) { e2 = CheckBox50.Text; }
                if (CheckBox51.Checked) { e3 = CheckBox51.Text; }
                if (CheckBox52.Checked) { e4 = CheckBox52.Text; }
                if (CheckBox53.Checked) { e5 = CheckBox53.Text; }
                //部分改
                sqlcommand_a5.Parameters.AddWithValue("@生长接触史", e1 + " " + e2 + " " + e3 + " " + e4 + " " + e5);
                sqlcommand_a5.Parameters.AddWithValue("@烟酒详情", TextBox255.Text);
                //
                sqlcommand_a5.Parameters.AddWithValue("@初潮年龄", TextBox256.Text);
                sqlcommand_a5.Parameters.AddWithValue("@绝经年龄", TextBox258.Text);
                sqlcommand_a5.Parameters.AddWithValue("@末次月经", TextBox259.Text);

                string f = "";
                if (CheckBox54.Checked) { f = "是"; } else { f = "否"; }
                sqlcommand_a5.Parameters.AddWithValue("@痛经情况", f);

                sqlcommand_a5.Parameters.AddWithValue("@结婚情况", DropDownList51.Text);
                sqlcommand_a5.Parameters.AddWithValue("@结婚年龄", TextBox261.Text);
                sqlcommand_a5.Parameters.AddWithValue("@配偶情况", DropDownList56.Text);
                sqlcommand_a5.Parameters.AddWithValue("@P", TextBox262.Text);
                sqlcommand_a5.Parameters.AddWithValue("@A", TextBox263.Text);
                sqlcommand_a5.Parameters.AddWithValue("@G", TextBox264.Text);
                sqlcommand_a5.Parameters.AddWithValue("@哺乳情况", DropDownList52.Text);
                sqlcommand_a5.Parameters.AddWithValue("@哺乳侧别", TextBox287.Text);
                sqlcommand_a5.Parameters.AddWithValue("@持续时间", TextBox288.Text);
                sqlcommand_a5.Parameters.AddWithValue("@子女情况", DropDownList53.Text);
                //完全改了
                sqlcommand_a5.Parameters.AddWithValue("@父亲情况", DropDownList54.Text);
                sqlcommand_a5.Parameters.AddWithValue("@父亲详情", TextBox289.Text);
                sqlcommand_a5.Parameters.AddWithValue("@母亲情况", DropDownList55.Text);
                sqlcommand_a5.Parameters.AddWithValue("@母亲详情", TextBox290.Text);
                //
                //修改的
                sqlcommand_a5.Parameters.AddWithValue("@初潮年龄_分子", TextBox257.Text);
                sqlcommand_a5.Parameters.AddWithValue("@初潮年龄_分母", TextBox260.Text);
                //
                //完全改了
                sqlcommand_a5.Parameters.AddWithValue("@家族恶性肿瘤史", DropDownList75.Text);
                sqlcommand_a5.Parameters.AddWithValue("@家族详情", TextBox291.Text);
                //

                try
                {
                    sqlconn_a5.Open();
                    intAddCount_a5 = sqlcommand_a5.ExecuteNonQuery();

                    if (sqlcommand_a5.ExecuteNonQuery() > 0)
                    {
                        Label409.Text = "添加成功！";
                    }
                    else
                    {
                        Label409.Text = "添加失败！";
                    }
                }
                catch (Exception ex5) { Label409.Text = ex5.Message; }
                finally
                {
                    sqlcommand_a5 = null;
                    sqlconn_a5.Close();
                    sqlconn_a5 = null;
                }

                //将“基线采集-专科查体”页面值读入数据库
                int intAddCount_a6 = new int();
                SqlConnection sqlconn_a6 = new SqlConnection(conStr);
                SqlCommand sqlcommand_a6 = new SqlCommand();
                sqlcommand_a6.Connection = sqlconn_a6;
                sqlcommand_a6.CommandText = "INSERT INTO a专科查体(就诊卡号,乳房皮肤,乳头,乳头溢液_有无,乳头溢液_主被动,乳头溢液_单多孔,乳头溢液_血性,乳腺肿块,距离乳头,肿块性质,边界情况,肿块活动,胸壁粘连,胸壁固定,同侧腋窝,同锁骨上,湿疹范围,同侧腋窝_数量,同侧腋窝_大小,同侧腋窝_散在,同侧腋窝_活动,同锁骨上_数量,同锁骨上_大小,同锁骨上_散在,同锁骨上_活动,对侧腋窝,对侧腋窝_数量,对侧腋窝_大小,对侧腋窝_散在,对侧腋窝_活动,对锁骨上,对锁骨上_数量,对锁骨上_大小,对锁骨上_散在,对锁骨上_活动,卫星结节个数)" +
                    "VALUES (@就诊卡号,@乳房皮肤,@乳头,@乳头溢液_有无,@乳头溢液_主被动,@乳头溢液_单多孔,@乳头溢液_血性,@乳腺肿块,@距离乳头,@肿块性质,@边界情况,@肿块活动,@胸壁粘连,@胸壁固定,@同侧腋窝,@同锁骨上,@湿疹范围 ,@同侧腋窝_数量,@同侧腋窝_大小,@同侧腋窝_散在,@同侧腋窝_活动,@同锁骨上_数量,@同锁骨上_大小,@同锁骨上_散在,@同锁骨上_活动,@对侧腋窝,@对侧腋窝_数量,@对侧腋窝_大小,@对侧腋窝_散在,@对侧腋窝_活动,@对锁骨上,@对锁骨上_数量,@对锁骨上_大小,@对锁骨上_散在,@对锁骨上_活动,@卫星结节个数)";

                sqlcommand_a6.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

                sqlcommand_a6.Parameters.AddWithValue("@乳房皮肤", DropDownList57.Text);
                //新增的
                sqlcommand_a6.Parameters.AddWithValue("@卫星结节个数", TextBox314.Text);
                //
                sqlcommand_a6.Parameters.AddWithValue("@乳头", DropDownList58.Text);
                //新增的
                string a61 = ""; string a62 = " "; string a63 = "";
                if (CheckBox70.Checked) { a61 = CheckBox70.Text; }
                if (CheckBox71.Checked) { a62 = CheckBox71.Text; }
                if (CheckBox72.Checked) { a63 = CheckBox72.Text; }
                sqlcommand_a6.Parameters.AddWithValue("@湿疹范围", a61 + " " + a62 + " " + a63);
                //
                sqlcommand_a6.Parameters.AddWithValue("@乳头溢液_有无", DropDownList59.Text);
                sqlcommand_a6.Parameters.AddWithValue("@乳头溢液_主被动", DropDownList60.Text);
                sqlcommand_a6.Parameters.AddWithValue("@乳头溢液_单多孔", DropDownList61.Text);
                sqlcommand_a6.Parameters.AddWithValue("@乳头溢液_血性", DropDownList62.Text);
                sqlcommand_a6.Parameters.AddWithValue("@乳腺肿块", DropDownList63.Text);
                //改了
                sqlcommand_a6.Parameters.AddWithValue("@距离乳头", TextBox292.Text + "+" + TextBox293.Text);
                //
                sqlcommand_a6.Parameters.AddWithValue("@肿块性质", DropDownList64.Text);
                sqlcommand_a6.Parameters.AddWithValue("@边界情况", DropDownList76.Text);
                sqlcommand_a6.Parameters.AddWithValue("@肿块活动", DropDownList77.Text);
                sqlcommand_a6.Parameters.AddWithValue("@胸壁粘连", DropDownList78.Text);
                sqlcommand_a6.Parameters.AddWithValue("@胸壁固定", DropDownList79.Text);

                //完全改了+添加了新内容
                sqlcommand_a6.Parameters.AddWithValue("@同侧腋窝", DropDownList80.Text);
                sqlcommand_a6.Parameters.AddWithValue("@同侧腋窝_数量", TextBox294.Text);
                sqlcommand_a6.Parameters.AddWithValue("@同侧腋窝_大小", TextBox295.Text);
                sqlcommand_a6.Parameters.AddWithValue("@同侧腋窝_散在", DropDownList81.Text);
                sqlcommand_a6.Parameters.AddWithValue("@同侧腋窝_活动", DropDownList82.Text);

                sqlcommand_a6.Parameters.AddWithValue("@同锁骨上", DropDownList83.Text);
                sqlcommand_a6.Parameters.AddWithValue("@同锁骨上_数量", TextBox296.Text);
                sqlcommand_a6.Parameters.AddWithValue("@同锁骨上_大小", TextBox297.Text);
                sqlcommand_a6.Parameters.AddWithValue("@同锁骨上_散在", DropDownList84.Text);
                sqlcommand_a6.Parameters.AddWithValue("@同锁骨上_活动", DropDownList85.Text);

                sqlcommand_a6.Parameters.AddWithValue("@对侧腋窝", DropDownList86.Text);
                sqlcommand_a6.Parameters.AddWithValue("@对侧腋窝_数量", TextBox298.Text);
                sqlcommand_a6.Parameters.AddWithValue("@对侧腋窝_大小", TextBox299.Text);
                sqlcommand_a6.Parameters.AddWithValue("@对侧腋窝_散在", DropDownList87.Text);
                sqlcommand_a6.Parameters.AddWithValue("@对侧腋窝_活动", DropDownList88.Text);

                sqlcommand_a6.Parameters.AddWithValue("@对锁骨上", DropDownList89.Text);
                sqlcommand_a6.Parameters.AddWithValue("@对锁骨上_数量", TextBox300.Text);
                sqlcommand_a6.Parameters.AddWithValue("@对锁骨上_大小", TextBox301.Text);
                sqlcommand_a6.Parameters.AddWithValue("@对锁骨上_散在", DropDownList90.Text);
                sqlcommand_a6.Parameters.AddWithValue("@对锁骨上_活动", DropDownList91.Text);
                //

                try
                {
                    sqlconn_a6.Open();
                    intAddCount_a6 = sqlcommand_a6.ExecuteNonQuery();

                    if (sqlcommand_a6.ExecuteNonQuery() > 0)
                    {
                        Label410.Text = "添加成功！";
                    }
                    else
                    {
                        Label410.Text = "添加失败！";
                    }
                }
                catch (Exception ex6) { Label410.Text = ex6.Message; }
                finally
                {
                    sqlcommand_a6 = null;
                    sqlconn_a6.Close();
                    sqlconn_a6 = null;
                }

                //将“基线采集-其他”页面值读入数据库
                int intAddCount_a7 = new int();
                SqlConnection sqlconn_a7 = new SqlConnection(conStr);
                SqlCommand sqlcommand_a7 = new SqlCommand();
                sqlcommand_a7.Connection = sqlconn_a7;
                sqlcommand_a7.CommandText = "INSERT INTO a其他(就诊卡号,远处转移_有无,远处转移_情况,T,N,M,辅助检查_有无,B超,钼靶,CT,MRI)" +
                    "VALUES (@就诊卡号,@远处转移_有无,@远处转移_情况,@T,@N,@M,@辅助检查_有无,@B超,@钼靶,@CT,@MRI)";

                sqlcommand_a7.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);
                sqlcommand_a7.Parameters.AddWithValue("@远处转移_有无", DropDownList65.Text);

                string l1 = ""; string l2 = ""; string l3 = ""; string l4 = ""; string l5 = ""; string l6 = ""; string l7 = ""; string l8 = "";
                if (CheckBox62.Checked) { l1 = CheckBox62.Text; }
                if (CheckBox63.Checked) { l2 = CheckBox63.Text; }
                if (CheckBox64.Checked) { l3 = CheckBox64.Text; }
                if (CheckBox65.Checked) { l4 = CheckBox65.Text; }
                if (CheckBox66.Checked) { l5 = CheckBox66.Text; }
                if (CheckBox67.Checked) { l6 = CheckBox67.Text; }
                if (CheckBox68.Checked) { l7 = CheckBox68.Text; }
                if (CheckBox69.Checked) { l8 = CheckBox69.Text; }
                sqlcommand_a7.Parameters.AddWithValue("@远处转移_情况", l1 + " " + l2 + " " + l3 + " " + l4 + " " + l5 + " " + l6 + " " + l7 + " " + l8);


                sqlcommand_a7.Parameters.AddWithValue("@T", TextBox265.Text);
                sqlcommand_a7.Parameters.AddWithValue("@N", TextBox266.Text);
                sqlcommand_a7.Parameters.AddWithValue("@M", TextBox267.Text);
                sqlcommand_a7.Parameters.AddWithValue("@辅助检查_有无", DropDownList66.Text);
                sqlcommand_a7.Parameters.AddWithValue("@B超", DropDownList92.Text);
                sqlcommand_a7.Parameters.AddWithValue("@钼靶", DropDownList93.Text);
                sqlcommand_a7.Parameters.AddWithValue("@CT", DropDownList94.Text);
                sqlcommand_a7.Parameters.AddWithValue("@MRI", DropDownList95.Text);


                try
                {
                    sqlconn_a7.Open();
                    intAddCount_a7 = sqlcommand_a7.ExecuteNonQuery();

                    if (sqlcommand_a7.ExecuteNonQuery() > 0)
                    {
                        Label411.Text = "添加成功！";
                    }
                    else
                    {
                        Label411.Text = "添加失败！";
                    }
                }
                catch (Exception ex7) { Label411.Text = ex7.Message; }
                finally
                {
                    sqlcommand_a7 = null;
                    sqlconn_a7.Close();
                    sqlconn_a7 = null;
                }

                //将“前哨淋巴结-术前检查”页面值读入数据库
                int intAddCount_b1 = new int();
                SqlConnection sqlconn_b1 = new SqlConnection(conStr);
                SqlCommand sqlcommand_b1 = new SqlCommand();
                sqlcommand_b1.Connection = sqlconn_b1;
                sqlcommand_b1.CommandText = "INSERT INTO b术前检查(阴阳性,触诊有无,触诊个数,触诊最大_cm,触诊性质,超声有无,超声个数,超声最大_cm,超声性质,钼靶有无,钼靶个数,钼靶最大_cm,钼靶性质,核磁有无,核磁个数,核磁最大_cm,核磁性质,临床腋窝分期,粗针,细针,针号,标本条数,病理,免疫,就诊卡号)" +
                    "VALUES (@阴阳性,@触诊有无,@触诊个数,@触诊最大_cm,@触诊性质,@超声有无,@超声个数,@超声最大_cm,@超声性质,@钼靶有无,@钼靶个数,@钼靶最大_cm,@钼靶性质,@核磁有无,@核磁个数,@核磁最大_cm,@核磁性质,@临床腋窝分期,@粗针,@细针,@针号,@标本条数,@病理,@免疫,@就诊卡号)";
                sqlcommand_b1.Parameters.AddWithValue("@阴阳性", RadioButtonList1.Text);
                sqlcommand_b1.Parameters.AddWithValue("@触诊有无", RadioButtonList2.Text);
                sqlcommand_b1.Parameters.AddWithValue("@触诊个数", TextBox24.Text);
                sqlcommand_b1.Parameters.AddWithValue("@触诊最大_cm", TextBox25.Text);
                sqlcommand_b1.Parameters.AddWithValue("@触诊性质", RadioButtonList3.Text);
                sqlcommand_b1.Parameters.AddWithValue("@超声有无", RadioButtonList4.Text);
                sqlcommand_b1.Parameters.AddWithValue("@超声个数", TextBox26.Text);
                sqlcommand_b1.Parameters.AddWithValue("@超声最大_cm", TextBox27.Text);
                sqlcommand_b1.Parameters.AddWithValue("@超声性质", RadioButtonList5.Text);
                sqlcommand_b1.Parameters.AddWithValue("@钼靶有无", RadioButtonList6.Text);
                sqlcommand_b1.Parameters.AddWithValue("@钼靶个数", TextBox28.Text);
                sqlcommand_b1.Parameters.AddWithValue("@钼靶最大_cm", TextBox29.Text);
                sqlcommand_b1.Parameters.AddWithValue("@钼靶性质", RadioButtonList7.Text);
                sqlcommand_b1.Parameters.AddWithValue("@核磁有无", RadioButtonList8.Text);
                sqlcommand_b1.Parameters.AddWithValue("@核磁个数", TextBox30.Text);
                sqlcommand_b1.Parameters.AddWithValue("@核磁最大_cm", TextBox31.Text);
                sqlcommand_b1.Parameters.AddWithValue("@核磁性质", RadioButtonList9.Text);
                sqlcommand_b1.Parameters.AddWithValue("@临床腋窝分期", DropDownList12.Text);
                sqlcommand_b1.Parameters.AddWithValue("@粗针", TextBox32.Text);
                sqlcommand_b1.Parameters.AddWithValue("@细针", TextBox33.Text);
                sqlcommand_b1.Parameters.AddWithValue("@针号", TextBox34.Text);
                sqlcommand_b1.Parameters.AddWithValue("@标本条数", TextBox35.Text);
                sqlcommand_b1.Parameters.AddWithValue("@病理", TextBox36.Text);
                sqlcommand_b1.Parameters.AddWithValue("@免疫", TextBox37.Text);
                sqlcommand_b1.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

                try
                {
                    sqlconn_b1.Open();
                    intAddCount_b1 = sqlcommand_b1.ExecuteNonQuery();

                    if (sqlcommand_b1.ExecuteNonQuery() > 0)
                    {
                        Label145.Text = "添加成功！";
                    }
                    else
                    {
                        Label145.Text = "添加失败！";
                    }
                }
                catch (Exception ex) { Label145.Text = ex.Message; }
                finally
                {
                    sqlcommand_b1 = null;
                    sqlconn_b1.Close();
                    sqlconn_b1 = null;
                }

                //将“前哨淋巴结-术中实施SLNB”页面值读入数据库
                int intAddCount_b2 = new int();
                SqlConnection sqlconn_b2 = new SqlConnection(conStr);
                SqlCommand sqlcommand_b2 = new SqlCommand();
                sqlcommand_b2.Connection = sqlconn_b2;
                sqlcommand_b2.CommandText = "INSERT INTO b术中实施SLNB(就诊卡号,示踪方法,示踪方法_联合法,示踪药,注射量,注射位置,乳晕周点数,肿瘤周点数,注射层次,注射时间,手术开始时间,摘除SLN时间,发现SLN位置,SLN数目,SLN类型,SLN最大直径_长轴,SLN最大直径_短轴,SLN最大直径_厚度,SLN处理方式,SLN病理_冰冻,SLN免疫组化,SLN免疫组化_其他,SLNB操作者)" +
                    "VALUES (@就诊卡号,@示踪方法,@示踪方法_联合法,@示踪药,@注射量,@注射位置,@乳晕周点数,@肿瘤周点数,@注射层次,@注射时间,@手术开始时间,@摘除SLN时间,@发现SLN位置,@SLN数目,@SLN类型,@SLN最大直径_长轴,@SLN最大直径_短轴,@SLN最大直径_厚度,@SLN处理方式,@SLN病理_冰冻,@SLN免疫组化,@SLN免疫组化_其他,@SLNB操作者)";

                sqlcommand_b2.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);
                sqlcommand_b2.Parameters.AddWithValue("@示踪方法", DropDownList13.Text);
                sqlcommand_b2.Parameters.AddWithValue("@示踪方法_联合法", TextBox164.Text);
                sqlcommand_b2.Parameters.AddWithValue("@示踪药", DropDownList14.Text);
                sqlcommand_b2.Parameters.AddWithValue("@注射量", DropDownList15.Text);
                sqlcommand_b2.Parameters.AddWithValue("@注射位置", RadioButtonList10.Text);
                sqlcommand_b2.Parameters.AddWithValue("@乳晕周点数", TextBox38.Text);
                sqlcommand_b2.Parameters.AddWithValue("@肿瘤周点数", TextBox39.Text);
                sqlcommand_b2.Parameters.AddWithValue("@注射层次", DropDownList16.Text);

                sqlcommand_b2.Parameters.AddWithValue("@注射时间", TextBox44.Text.ToString() + " " + TextBox45.Text + ":" + TextBox46.Text + ":" + TextBox47.Text);
                sqlcommand_b2.Parameters.AddWithValue("@手术开始时间", TextBox40.Text.ToString() + " " + TextBox41.Text + ":" + TextBox42.Text + ":" + TextBox43.Text);
                sqlcommand_b2.Parameters.AddWithValue("@摘除SLN时间", TextBox48.Text.ToString() + " " + TextBox49.Text + ":" + TextBox50.Text + ":" + TextBox51.Text);

                sqlcommand_b2.Parameters.AddWithValue("@发现SLN位置", DropDownList17.Text);
                sqlcommand_b2.Parameters.AddWithValue("@SLN数目", DropDownList18.Text);
                sqlcommand_b2.Parameters.AddWithValue("@SLN类型", DropDownList19.Text);
                sqlcommand_b2.Parameters.AddWithValue("@SLN最大直径_长轴", TextBox52.Text);
                sqlcommand_b2.Parameters.AddWithValue("@SLN最大直径_短轴", TextBox53.Text);
                sqlcommand_b2.Parameters.AddWithValue("@SLN最大直径_厚度", TextBox54.Text);
                sqlcommand_b2.Parameters.AddWithValue("@SLN处理方式", DropDownList20.Text);
                sqlcommand_b2.Parameters.AddWithValue("@SLN病理_冰冻", TextBox55.Text);
                sqlcommand_b2.Parameters.AddWithValue("@SLN免疫组化", DropDownList21.Text);
                sqlcommand_b2.Parameters.AddWithValue("@SLN免疫组化_其他", TextBox165.Text);
                sqlcommand_b2.Parameters.AddWithValue("@SLNB操作者", TextBox56.Text);

                try
                {
                    sqlconn_b2.Open();
                    intAddCount_b2 = sqlcommand_b2.ExecuteNonQuery();

                    if (sqlcommand_b2.ExecuteNonQuery() > 0)
                    {
                        Label146.Text = "添加成功！";
                    }
                    else
                    {
                        Label146.Text = "添加失败！";
                    }
                }
                catch (Exception ex) { Label146.Text = ex.Message; }
                finally
                {
                    sqlcommand_b2 = null;
                    sqlconn_b2.Close();
                    sqlconn_b2 = null;
                }

                //将“前哨淋巴结-术中行ARM”页面值读入数据库
                int intAddCount_b3 = new int();
                SqlConnection sqlconn_b3 = new SqlConnection(conStr);
                SqlCommand sqlcommand_b3 = new SqlCommand();
                sqlcommand_b3.Connection = sqlconn_b3;
                sqlcommand_b3.CommandText = "INSERT INTO b术中行ARM(就诊卡号,示踪方法,示踪方法_联合法,示踪药,注射量,注射位置,注射位置_距离腋窝皱襞,注射位置_其它,注射层次,注射时间,手术开始时间,摘除ARM时间,ARM位置,ARM数目,SLN类型,SLN病理_冰冻,操作者)" +
                    "VALUES (@就诊卡号,@示踪方法,@示踪方法_联合法,@示踪药,@注射量,@注射位置,@注射位置_距离腋窝皱襞,@注射位置_其它,@注射层次,@注射时间,@手术开始时间,@摘除ARM时间,@ARM位置,@ARM数目,@SLN类型,@SLN病理_冰冻,@操作者)";

                sqlcommand_b3.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);
                sqlcommand_b3.Parameters.AddWithValue("@示踪方法", DropDownList22.Text);
                sqlcommand_b3.Parameters.AddWithValue("@示踪方法_联合法", TextBox166.Text);
                sqlcommand_b3.Parameters.AddWithValue("@示踪药", DropDownList23.Text);
                sqlcommand_b3.Parameters.AddWithValue("@注射量", DropDownList24.Text);
                sqlcommand_b3.Parameters.AddWithValue("@注射位置", RadioButtonList11.Text);
                sqlcommand_b3.Parameters.AddWithValue("@注射位置_距离腋窝皱襞", TextBox57.Text);
                sqlcommand_b3.Parameters.AddWithValue("@注射位置_其它", TextBox58.Text);
                sqlcommand_b3.Parameters.AddWithValue("@注射层次", DropDownList25.Text);

                sqlcommand_b3.Parameters.AddWithValue("@注射时间", TextBox59.Text.ToString() + " " + TextBox60.Text + ":" + TextBox61.Text + ":" + TextBox62.Text);
                sqlcommand_b3.Parameters.AddWithValue("@手术开始时间", TextBox63.Text.ToString() + " " + TextBox64.Text + ":" + TextBox65.Text + ":" + TextBox66.Text);
                sqlcommand_b3.Parameters.AddWithValue("@摘除ARM时间", TextBox67.Text.ToString() + " " + TextBox68.Text + ":" + TextBox69.Text + ":" + TextBox70.Text);

                sqlcommand_b3.Parameters.AddWithValue("@ARM位置", DropDownList26.Text);
                sqlcommand_b3.Parameters.AddWithValue("@ARM数目", DropDownList27.Text);
                sqlcommand_b3.Parameters.AddWithValue("@SLN类型", DropDownList28.Text);
                sqlcommand_b3.Parameters.AddWithValue("@SLN病理_冰冻", TextBox74.Text);
                sqlcommand_b3.Parameters.AddWithValue("@操作者", TextBox75.Text);

                try
                {
                    sqlconn_b3.Open();
                    intAddCount_b3 = sqlcommand_b3.ExecuteNonQuery();

                    if (sqlcommand_b3.ExecuteNonQuery() > 0)
                    {
                        Label147.Text = "添加成功！";
                    }
                    else
                    {
                        Label147.Text = "添加失败！";
                    }
                }
                catch (Exception ex) { Label147.Text = ex.Message; }
                finally
                {
                    sqlcommand_b3 = null;
                    sqlconn_b3.Close();
                    sqlconn_b3 = null;
                }

                //将“前哨淋巴结-腋窝状况记录”页面值读入数据库
                int intAddCount_b4 = new int();
                SqlConnection sqlconn_b4 = new SqlConnection(conStr);
                SqlCommand sqlcommand_b4 = new SqlCommand();
                sqlcommand_b4.Connection = sqlconn_b4;
                sqlcommand_b4.CommandText = "INSERT INTO b腋窝状况记录(就诊卡号,SLN病理,SLN病理_免疫组化,ARM病理,ARM病理_免疫组化,患肢_肘上_术前,患肢_肘上_术后1月,患肢_肘上_术后3月,患肢_肘上_术后6月,患肢_肘上_术后1年,患肢_肘上_术后2年,对侧肢_肘上_术前,对侧肢_肘上_术后1月,对侧肢_肘上_术后3月,对侧肢_肘上_术后6月,对侧肢_肘上_术后1年,对侧肢_肘上_术后2年,患肢_肘下_术前,患肢_肘下_术后1月,患肢_肘下_术后3月,患肢_肘下_术后6月,患肢_肘下_术后1年,患肢_肘下_术后2年,对侧肢_肘下_术前,对侧肢_肘下_术后1月,对侧肢_肘下_术后3月,对侧肢_肘下_术后6月,对侧肢_肘下_术后1年,对侧肢_肘下_术后2年,患侧_手腕_术前,患侧_手腕_术后1月,患侧_手腕_术后3月,患侧_手腕_术后6月,患侧_手腕_术后1年,患侧_手腕_术后2年,对侧_手腕_术前,对侧_手腕_术后1月,对侧_手腕_术后3月,对侧_手腕_术后6月,对侧_手腕_术后1年,对侧_手腕_术后2年,肘上_体重_术前,肘上_体重_术后1月,肘上_体重_术后3月,肘上_体重_术后6月,肘上_体重_术后1年,肘上_体重_术后2年,肘下_体重_术前,肘下_体重_术后1月,肘下_体重_术后3月,肘下_体重_术后6月,肘下_体重_术后1年,肘下_体重_术后2年,手腕_体重_术前,手腕_体重_术后1月,手腕_体重_术后3月,手腕_体重_术后6月,手腕_体重_术后1年,手腕_体重_术后2年)" +
                    "VALUES (@就诊卡号,@SLN病理,@SLN病理_免疫组化,@ARM病理,@ARM病理_免疫组化,@患肢_肘上_术前,@患肢_肘上_术后1月,@患肢_肘上_术后3月,@患肢_肘上_术后6月,@患肢_肘上_术后1年,@患肢_肘上_术后2年,@对侧肢_肘上_术前,@对侧肢_肘上_术后1月,@对侧肢_肘上_术后3月	,@对侧肢_肘上_术后6月,@对侧肢_肘上_术后1年,@对侧肢_肘上_术后2年,@患肢_肘下_术前,@患肢_肘下_术后1月,@患肢_肘下_术后3月,@患肢_肘下_术后6月,@患肢_肘下_术后1年,@患肢_肘下_术后2年,@对侧肢_肘下_术前,@对侧肢_肘下_术后1月,@对侧肢_肘下_术后3月,@对侧肢_肘下_术后6月,@对侧肢_肘下_术后1年,@对侧肢_肘下_术后2年,@患侧_手腕_术前,@患侧_手腕_术后1月,@患侧_手腕_术后3月,@患侧_手腕_术后6月,@患侧_手腕_术后1年,@患侧_手腕_术后2年,@对侧_手腕_术前,@对侧_手腕_术后1月,@对侧_手腕_术后3月,@对侧_手腕_术后6月,@对侧_手腕_术后1年,@对侧_手腕_术后2年,@肘上_体重_术前,@肘上_体重_术后1月,@肘上_体重_术后3月,@肘上_体重_术后6月,@肘上_体重_术后1年,@肘上_体重_术后2年,@肘下_体重_术前,@肘下_体重_术后1月,@肘下_体重_术后3月,@肘下_体重_术后6月,@肘下_体重_术后1年,@肘下_体重_术后2年,@手腕_体重_术前,@手腕_体重_术后1月,@手腕_体重_术后3月,@手腕_体重_术后6月,@手腕_体重_术后1年,@手腕_体重_术后2年)";

                sqlcommand_b4.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);
                sqlcommand_b4.Parameters.AddWithValue("@SLN病理", TextBox71.Text);
                sqlcommand_b4.Parameters.AddWithValue("@SLN病理_免疫组化", TextBox73.Text);
                sqlcommand_b4.Parameters.AddWithValue("@ARM病理", TextBox72.Text);
                sqlcommand_b4.Parameters.AddWithValue("@ARM病理_免疫组化", TextBox76.Text);
                sqlcommand_b4.Parameters.AddWithValue("@患肢_肘上_术前", TextBox77.Text);
                sqlcommand_b4.Parameters.AddWithValue("@患肢_肘上_术后1月", TextBox78.Text);
                sqlcommand_b4.Parameters.AddWithValue("@患肢_肘上_术后3月", TextBox79.Text);
                sqlcommand_b4.Parameters.AddWithValue("@患肢_肘上_术后6月", TextBox80.Text);
                sqlcommand_b4.Parameters.AddWithValue("@患肢_肘上_术后1年", TextBox81.Text);
                sqlcommand_b4.Parameters.AddWithValue("@患肢_肘上_术后2年", TextBox82.Text);
                sqlcommand_b4.Parameters.AddWithValue("@对侧肢_肘上_术前", TextBox83.Text);
                sqlcommand_b4.Parameters.AddWithValue("@对侧肢_肘上_术后1月", TextBox84.Text);
                sqlcommand_b4.Parameters.AddWithValue("@对侧肢_肘上_术后3月", TextBox85.Text);
                sqlcommand_b4.Parameters.AddWithValue("@对侧肢_肘上_术后6月", TextBox86.Text);
                sqlcommand_b4.Parameters.AddWithValue("@对侧肢_肘上_术后1年", TextBox87.Text);
                sqlcommand_b4.Parameters.AddWithValue("@对侧肢_肘上_术后2年", TextBox88.Text);
                sqlcommand_b4.Parameters.AddWithValue("@患肢_肘下_术前", TextBox95.Text);
                sqlcommand_b4.Parameters.AddWithValue("@患肢_肘下_术后1月", TextBox96.Text);
                sqlcommand_b4.Parameters.AddWithValue("@患肢_肘下_术后3月", TextBox97.Text);
                sqlcommand_b4.Parameters.AddWithValue("@患肢_肘下_术后6月", TextBox98.Text);
                sqlcommand_b4.Parameters.AddWithValue("@患肢_肘下_术后1年", TextBox99.Text);
                sqlcommand_b4.Parameters.AddWithValue("@患肢_肘下_术后2年", TextBox100.Text);
                sqlcommand_b4.Parameters.AddWithValue("@对侧肢_肘下_术前", TextBox101.Text);
                sqlcommand_b4.Parameters.AddWithValue("@对侧肢_肘下_术后1月", TextBox102.Text);
                sqlcommand_b4.Parameters.AddWithValue("@对侧肢_肘下_术后3月", TextBox103.Text);
                sqlcommand_b4.Parameters.AddWithValue("@对侧肢_肘下_术后6月", TextBox104.Text);
                sqlcommand_b4.Parameters.AddWithValue("@对侧肢_肘下_术后1年", TextBox105.Text);
                sqlcommand_b4.Parameters.AddWithValue("@对侧肢_肘下_术后2年", TextBox106.Text);
                sqlcommand_b4.Parameters.AddWithValue("@患侧_手腕_术前", TextBox113.Text);
                sqlcommand_b4.Parameters.AddWithValue("@患侧_手腕_术后1月", TextBox114.Text);
                sqlcommand_b4.Parameters.AddWithValue("@患侧_手腕_术后3月", TextBox115.Text);
                sqlcommand_b4.Parameters.AddWithValue("@患侧_手腕_术后6月", TextBox116.Text);
                sqlcommand_b4.Parameters.AddWithValue("@患侧_手腕_术后1年", TextBox117.Text);
                sqlcommand_b4.Parameters.AddWithValue("@患侧_手腕_术后2年", TextBox118.Text);
                sqlcommand_b4.Parameters.AddWithValue("@对侧_手腕_术前", TextBox119.Text);
                sqlcommand_b4.Parameters.AddWithValue("@对侧_手腕_术后1月", TextBox120.Text);
                sqlcommand_b4.Parameters.AddWithValue("@对侧_手腕_术后3月", TextBox121.Text);
                sqlcommand_b4.Parameters.AddWithValue("@对侧_手腕_术后6月", TextBox122.Text);
                sqlcommand_b4.Parameters.AddWithValue("@对侧_手腕_术后1年", TextBox123.Text);
                sqlcommand_b4.Parameters.AddWithValue("@对侧_手腕_术后2年", TextBox124.Text);
                sqlcommand_b4.Parameters.AddWithValue("@肘上_体重_术前", TextBox89.Text);
                sqlcommand_b4.Parameters.AddWithValue("@肘上_体重_术后1月", TextBox90.Text);
                sqlcommand_b4.Parameters.AddWithValue("@肘上_体重_术后3月", TextBox91.Text);
                sqlcommand_b4.Parameters.AddWithValue("@肘上_体重_术后6月", TextBox92.Text);
                sqlcommand_b4.Parameters.AddWithValue("@肘上_体重_术后1年", TextBox93.Text);
                sqlcommand_b4.Parameters.AddWithValue("@肘上_体重_术后2年", TextBox94.Text);
                sqlcommand_b4.Parameters.AddWithValue("@肘下_体重_术前", TextBox107.Text);
                sqlcommand_b4.Parameters.AddWithValue("@肘下_体重_术后1月", TextBox108.Text);
                sqlcommand_b4.Parameters.AddWithValue("@肘下_体重_术后3月", TextBox109.Text);
                sqlcommand_b4.Parameters.AddWithValue("@肘下_体重_术后6月", TextBox110.Text);
                sqlcommand_b4.Parameters.AddWithValue("@肘下_体重_术后1年", TextBox111.Text);
                sqlcommand_b4.Parameters.AddWithValue("@肘下_体重_术后2年", TextBox112.Text);
                sqlcommand_b4.Parameters.AddWithValue("@手腕_体重_术前", TextBox125.Text);
                sqlcommand_b4.Parameters.AddWithValue("@手腕_体重_术后1月", TextBox126.Text);
                sqlcommand_b4.Parameters.AddWithValue("@手腕_体重_术后3月", TextBox127.Text);
                sqlcommand_b4.Parameters.AddWithValue("@手腕_体重_术后6月", TextBox128.Text);
                sqlcommand_b4.Parameters.AddWithValue("@手腕_体重_术后1年", TextBox129.Text);
                sqlcommand_b4.Parameters.AddWithValue("@手腕_体重_术后2年", TextBox130.Text);

                try
                {
                    sqlconn_b4.Open();
                    intAddCount_b4 = sqlcommand_b4.ExecuteNonQuery();

                    if (sqlcommand_b4.ExecuteNonQuery() > 0)
                    {
                        Label148.Text = "添加成功！";
                    }
                    else
                    {
                        Label148.Text = "添加失败！";
                    }
                }
                catch (Exception ex) { Label148.Text = ex.Message; }
                finally
                {
                    sqlcommand_b4 = null;
                    sqlconn_b4.Close();
                    sqlconn_b4 = null;
                }

                //将“化疗-术前化疗”页面值读入数据库
                int intAddCount_c1 = new int();
                SqlConnection sqlconn_c1 = new SqlConnection(conStr);
                SqlCommand sqlcommand_c1 = new SqlCommand();
                sqlcommand_c1.Connection = sqlconn_c1;
                sqlcommand_c1.CommandText = "INSERT INTO c术前化疗(就诊卡号,新辅助化疗,化疗周期,第1周方案_第1项,第1周方案_第1项_毫克数,第1周方案_第2项,第1周方案_第2项_毫克数,第1周方案_第3项,第1周方案_第3项_毫克数,第1周方案_日期,化疗后评估次数,第1次评估_日期,RECIST评估,备注)" +
                    "VALUES (@就诊卡号,@新辅助化疗,@化疗周期,@第1周方案_第1项,@第1周方案_第1项_毫克数,@第1周方案_第2项,@第1周方案_第2项_毫克数,@第1周方案_第3项,@第1周方案_第3项_毫克数,@第1周方案_日期,@化疗后评估次数,@第1次评估_日期,@RECIST评估,@备注)";

                sqlcommand_c1.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

                string c1_a = "";
                if (RadioButton150.Checked) { c1_a = RadioButton150.Text; }
                if (RadioButton151.Checked) { c1_a = RadioButton151.Text; }
                sqlcommand_c1.Parameters.AddWithValue("@新辅助化疗", c1_a);

                sqlcommand_c1.Parameters.AddWithValue("@化疗周期", TextBox268.Text);
                sqlcommand_c1.Parameters.AddWithValue("@第1周方案_第1项", DropDownList67.Text);
                sqlcommand_c1.Parameters.AddWithValue("@第1周方案_第1项_毫克数", TextBox269.Text);
                sqlcommand_c1.Parameters.AddWithValue("@第1周方案_第2项", DropDownList68.Text);
                sqlcommand_c1.Parameters.AddWithValue("@第1周方案_第2项_毫克数", TextBox270.Text);
                sqlcommand_c1.Parameters.AddWithValue("@第1周方案_第3项", DropDownList69.Text);
                sqlcommand_c1.Parameters.AddWithValue("@第1周方案_第3项_毫克数", TextBox271.Text);
                sqlcommand_c1.Parameters.AddWithValue("@第1周方案_日期", TextBox272.Text);
                sqlcommand_c1.Parameters.AddWithValue("@化疗后评估次数", TextBox273.Text);
                sqlcommand_c1.Parameters.AddWithValue("@第1次评估_日期", TextBox274.Text);
                sqlcommand_c1.Parameters.AddWithValue("@RECIST评估", DropDownList70.Text);
                sqlcommand_c1.Parameters.AddWithValue("@备注", TextBox275.Text);

                try
                {
                    sqlconn_c1.Open();
                    intAddCount_c1 = sqlcommand_c1.ExecuteNonQuery();

                    if (sqlcommand_c1.ExecuteNonQuery() > 0)
                    {
                        Label412.Text = "添加成功！";
                    }
                    else
                    {
                        Label412.Text = "添加失败！";
                    }
                }
                catch (Exception exc1) { Label412.Text = exc1.Message; }
                finally
                {
                    sqlcommand_c1 = null;
                    sqlconn_c1.Close();
                    sqlconn_c1 = null;
                }

                //将“化疗-术后化疗”页面值读入数据库
                int intAddCount_c2 = new int();
                SqlConnection sqlconn_c2 = new SqlConnection(conStr);
                SqlCommand sqlcommand_c2 = new SqlCommand();
                sqlcommand_c2.Connection = sqlconn_c2;
                sqlcommand_c2.CommandText = "INSERT INTO c术后化疗(就诊卡号,术后辅助化疗,化疗周期,第1周方案_第1项,第1周方案_第1项_毫克数,第1周方案_第2项,第1周方案_第2项_毫克数,第1周方案_第3项,第1周方案_第3项_毫克数,第1周方案_日期,不良反应,血液系统,表现,处理)" +
                    "VALUES (@就诊卡号,@术后辅助化疗,@化疗周期,@第1周方案_第1项,@第1周方案_第1项_毫克数,@第1周方案_第2项,@第1周方案_第2项_毫克数,@第1周方案_第3项,@第1周方案_第3项_毫克数,@第1周方案_日期,@不良反应,@血液系统,@表现,@处理)";

                sqlcommand_c2.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

                string c2_a = "";
                if (RadioButton152.Checked) { c2_a = RadioButton152.Text; }
                if (RadioButton153.Checked) { c2_a = RadioButton153.Text; }
                sqlcommand_c2.Parameters.AddWithValue("@术后辅助化疗", c2_a);

                sqlcommand_c2.Parameters.AddWithValue("@化疗周期", TextBox276.Text);
                sqlcommand_c2.Parameters.AddWithValue("@第1周方案_第1项", DropDownList71.Text);
                sqlcommand_c2.Parameters.AddWithValue("@第1周方案_第1项_毫克数", TextBox277.Text);
                sqlcommand_c2.Parameters.AddWithValue("@第1周方案_第2项", DropDownList72.Text);
                sqlcommand_c2.Parameters.AddWithValue("@第1周方案_第2项_毫克数", TextBox278.Text);
                sqlcommand_c2.Parameters.AddWithValue("@第1周方案_第3项", DropDownList73.Text);
                sqlcommand_c2.Parameters.AddWithValue("@第1周方案_第3项_毫克数", TextBox279.Text);
                sqlcommand_c2.Parameters.AddWithValue("@第1周方案_日期", TextBox280.Text);

                string c2_b1 = ""; string c2_b2 = ""; string c2_b3 = ""; string c2_b4 = ""; string c2_b5 = ""; string c2_b6 = ""; string c2_b7 = "";
                if (CheckBox55.Checked) { c2_b1 = CheckBox55.Text; }
                if (CheckBox56.Checked) { c2_b2 = CheckBox56.Text; }
                if (CheckBox57.Checked) { c2_b3 = CheckBox57.Text; }
                if (CheckBox58.Checked) { c2_b4 = CheckBox58.Text; }
                if (CheckBox59.Checked) { c2_b5 = CheckBox59.Text; }
                if (CheckBox60.Checked) { c2_b6 = CheckBox60.Text; }
                if (CheckBox61.Checked) { c2_b7 = CheckBox61.Text; }
                sqlcommand_c2.Parameters.AddWithValue("@不良反应", c2_b1 + " " + c2_b2 + " " + c2_b3 + " " + c2_b4 + " " + c2_b5 + " " + c2_b6 + " " + c2_b7);


                sqlcommand_c2.Parameters.AddWithValue("@血液系统", DropDownList74.Text);
                sqlcommand_c2.Parameters.AddWithValue("@表现", TextBox281.Text);
                sqlcommand_c2.Parameters.AddWithValue("@处理", TextBox282.Text);

                try
                {
                    sqlconn_c2.Open();
                    intAddCount_c2 = sqlcommand_c2.ExecuteNonQuery();

                    if (sqlcommand_c2.ExecuteNonQuery() > 0)
                    {
                        Label413.Text = "添加成功！";
                    }
                    else
                    {
                        Label413.Text = "添加失败！";
                    }
                }
                catch (Exception exc2) { Label413.Text = exc2.Message; }
                finally
                {
                    sqlcommand_c2 = null;
                    sqlconn_c2.Close();
                    sqlconn_c2 = null;
                }

                //将“随访-一般”页面值读入数据库
                int intAddCount_d1 = new int();
                SqlConnection sqlconn_d1 = new SqlConnection(conStr);
                SqlCommand sqlcommand_d1 = new SqlCommand();
                sqlcommand_d1.Connection = sqlconn_d1;
                sqlcommand_d1.CommandText = "INSERT INTO d一般(就诊卡号,病理,淋巴结,分子类型,是否化疗,化疗详情,是否放疗,放疗详情,是否内分泌,内分泌详情,是否靶向,靶向详情,是否生物治疗,生物治疗情况)" +
                    "VALUES (@就诊卡号,@病理,@淋巴结,@分子类型,@是否化疗,@化疗详情,@是否放疗,@放疗详情,@是否内分泌,@内分泌详情,@是否靶向,@靶向详情,@是否生物治疗,@生物治疗情况)";

                sqlcommand_d1.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);
                sqlcommand_d1.Parameters.AddWithValue("@病理", TextBox131.Text);
                sqlcommand_d1.Parameters.AddWithValue("@淋巴结", TextBox132.Text);
                sqlcommand_d1.Parameters.AddWithValue("@分子类型", TextBox133.Text);
                sqlcommand_d1.Parameters.AddWithValue("@是否化疗", CheckBox1.Checked);
                sqlcommand_d1.Parameters.AddWithValue("@化疗详情", TextBox134.Text);
                sqlcommand_d1.Parameters.AddWithValue("@是否放疗", CheckBox2.Checked);
                sqlcommand_d1.Parameters.AddWithValue("@放疗详情", TextBox135.Text);
                sqlcommand_d1.Parameters.AddWithValue("@是否内分泌", CheckBox3.Checked);
                sqlcommand_d1.Parameters.AddWithValue("@内分泌详情", TextBox136.Text);
                sqlcommand_d1.Parameters.AddWithValue("@是否靶向", CheckBox4.Checked);
                sqlcommand_d1.Parameters.AddWithValue("@靶向详情", TextBox137.Text);
                sqlcommand_d1.Parameters.AddWithValue("@是否生物治疗", CheckBox5.Checked);
                sqlcommand_d1.Parameters.AddWithValue("@生物治疗情况", TextBox138.Text);

                try
                {
                    sqlconn_d1.Open();
                    intAddCount_d1 = sqlcommand_d1.ExecuteNonQuery();

                    if (sqlcommand_d1.ExecuteNonQuery() > 0)
                    {
                        Label149.Text = "添加成功！";
                    }
                    else
                    {
                        Label149.Text = "添加失败！";
                    }
                }
                catch (Exception ex) { Label149.Text = ex.Message; }
                finally
                {
                    sqlcommand_d1 = null;
                    sqlconn_d1.Close();
                    sqlconn_d1 = null;
                }

                //将“随访-乳腺复发转移”页面值读入数据库
                int intAddCount_d2 = new int();
                SqlConnection sqlconn_d2 = new SqlConnection(conStr);
                SqlCommand sqlcommand_d2 = new SqlCommand();
                sqlcommand_d2.Connection = sqlconn_d2;
                sqlcommand_d2.CommandText = "INSERT INTO d乳腺复发转移(就诊卡号,术后时间,胸壁_是否正常,胸壁_异常详情,胸壁_对侧_是否正常,胸壁_对侧_异常详情,腋下_是否正常,腋下_异常详情,腋下_对侧_是否正常,腋下_对侧_异常详情,胸片_是否正常,胸片_异常详情,胸片_是否进一步检查,胸片_进一步检查详情,胸片_是否复查,胸片_复查月,BUS_是否正常,BUS_异常详情,BUS_是否进一步检查,BUS_进一步检查详情,BUS_是否复查,BUS_复查月,肿瘤标志物_是否正常,肿瘤标志物_异常详情,肿瘤标志物_是否进一步检查,肿瘤标志物_进一步检查详情,肿瘤标志物_是否复查,肿瘤标志物_复查月,CT_是否正常,CT_异常详情,CT_是否进一步检查,CT_进一步检查详情,CT_是否复查,CT_复查月,ECT_是否正常,ECT_异常详情,ECT_是否进一步检查,ECT_进一步检查详情,ECT_是否复查,ECT_复查月,PET_CT_是否正常,PET_CT_异常详情,PET_CT_是否进一步检查,PET_CT_进一步检查详情,PET_CT_是否复查,PET_CT_复查月,结论_是否正常,结论_是否复发或转移,复发或转移详情,治疗)" +
                    "VALUES (@就诊卡号,@术后时间,@胸壁_是否正常,@胸壁_异常详情,@胸壁_对侧_是否正常,@胸壁_对侧_异常详情,@腋下_是否正常,@腋下_异常详情,@腋下_对侧_是否正常,@腋下_对侧_异常详情,@胸片_是否正常,@胸片_异常详情,@胸片_是否进一步检查,@胸片_进一步检查详情,@胸片_是否复查,@胸片_复查月,@BUS_是否正常,@BUS_异常详情,@BUS_是否进一步检查,@BUS_进一步检查详情,@BUS_是否复查,@BUS_复查月,@肿瘤标志物_是否正常,@肿瘤标志物_异常详情,@肿瘤标志物_是否进一步检查,@肿瘤标志物_进一步检查详情,@肿瘤标志物_是否复查,@肿瘤标志物_复查月,@CT_是否正常,@CT_异常详情,@CT_是否进一步检查,@CT_进一步检查详情,@CT_是否复查,@CT_复查月,@ECT_是否正常,@ECT_异常详情,@ECT_是否进一步检查,@ECT_进一步检查详情,@ECT_是否复查,@ECT_复查月,@PET_CT_是否正常,@PET_CT_异常详情,@PET_CT_是否进一步检查,@PET_CT_进一步检查详情,@PET_CT_是否复查,@PET_CT_复查月,@结论_是否正常,@结论_是否复发或转移,@复发或转移详情,@治疗)";

                sqlcommand_d2.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);
                sqlcommand_d2.Parameters.AddWithValue("@术后时间", TextBox139.Text + DropDownList29.Text);
                sqlcommand_d2.Parameters.AddWithValue("@胸壁_是否正常", RadioButtonList17.Text);
                sqlcommand_d2.Parameters.AddWithValue("@胸壁_异常详情", TextBox140.Text);
                sqlcommand_d2.Parameters.AddWithValue("@胸壁_对侧_是否正常", RadioButtonList18.Text);
                sqlcommand_d2.Parameters.AddWithValue("@胸壁_对侧_异常详情", TextBox145.Text);
                sqlcommand_d2.Parameters.AddWithValue("@腋下_是否正常", RadioButtonList15.Text);
                sqlcommand_d2.Parameters.AddWithValue("@腋下_异常详情", TextBox142.Text);
                sqlcommand_d2.Parameters.AddWithValue("@腋下_对侧_是否正常", RadioButtonList16.Text);
                sqlcommand_d2.Parameters.AddWithValue("@腋下_对侧_异常详情", TextBox144.Text);
                sqlcommand_d2.Parameters.AddWithValue("@胸片_是否正常", RadioButtonList13.Text);
                sqlcommand_d2.Parameters.AddWithValue("@胸片_异常详情", TextBox141.Text);
                if (CheckBox6.Checked) { sqlcommand_d2.Parameters.AddWithValue("@胸片_是否进一步检查", "是"); } else { sqlcommand_d2.Parameters.AddWithValue("@胸片_是否进一步检查", "否"); }
                sqlcommand_d2.Parameters.AddWithValue("@胸片_进一步检查详情", TextBox143.Text);
                if (CheckBox7.Checked) { sqlcommand_d2.Parameters.AddWithValue("@胸片_是否复查", "是"); } else { sqlcommand_d2.Parameters.AddWithValue("@胸片_是否复查", "否"); }
                sqlcommand_d2.Parameters.AddWithValue("@胸片_复查月", TextBox146.Text);
                sqlcommand_d2.Parameters.AddWithValue("@BUS_是否正常", RadioButtonList14.Text);
                sqlcommand_d2.Parameters.AddWithValue("@BUS_异常详情", TextBox147.Text);
                if (CheckBox8.Checked) { sqlcommand_d2.Parameters.AddWithValue("@BUS_是否进一步检查", "是"); } else { sqlcommand_d2.Parameters.AddWithValue("@BUS_是否进一步检查", "否"); }
                sqlcommand_d2.Parameters.AddWithValue("@BUS_进一步检查详情", TextBox148.Text);
                if (CheckBox9.Checked) { sqlcommand_d2.Parameters.AddWithValue("@BUS_是否复查", "是"); } else { sqlcommand_d2.Parameters.AddWithValue("@BUS_是否复查", "否"); }
                sqlcommand_d2.Parameters.AddWithValue("@BUS_复查月", TextBox149.Text);
                sqlcommand_d2.Parameters.AddWithValue("@肿瘤标志物_是否正常", RadioButtonList19.Text);
                sqlcommand_d2.Parameters.AddWithValue("@肿瘤标志物_异常详情", TextBox150.Text);
                if (CheckBox10.Checked) { sqlcommand_d2.Parameters.AddWithValue("@肿瘤标志物_是否进一步检查", "是"); } else { sqlcommand_d2.Parameters.AddWithValue("@肿瘤标志物_是否进一步检查", "否"); }
                sqlcommand_d2.Parameters.AddWithValue("@肿瘤标志物_进一步检查详情", TextBox151.Text);
                if (CheckBox9.Checked) { sqlcommand_d2.Parameters.AddWithValue("@肿瘤标志物_是否复查", "是"); } else { sqlcommand_d2.Parameters.AddWithValue("@肿瘤标志物_是否复查", "否"); }
                sqlcommand_d2.Parameters.AddWithValue("@肿瘤标志物_复查月", TextBox152.Text);
                sqlcommand_d2.Parameters.AddWithValue("@CT_是否正常", RadioButtonList20.Text);
                sqlcommand_d2.Parameters.AddWithValue("@CT_异常详情", TextBox153.Text);
                if (CheckBox12.Checked) { sqlcommand_d2.Parameters.AddWithValue("@CT_是否进一步检查", "是"); } else { sqlcommand_d2.Parameters.AddWithValue("@CT_是否进一步检查", "否"); }
                sqlcommand_d2.Parameters.AddWithValue("@CT_进一步检查详情", TextBox154.Text);
                if (CheckBox13.Checked) { sqlcommand_d2.Parameters.AddWithValue("@CT_是否复查", "是"); } else { sqlcommand_d2.Parameters.AddWithValue("@CT_是否复查", "否"); }
                sqlcommand_d2.Parameters.AddWithValue("@CT_复查月", TextBox155.Text);
                sqlcommand_d2.Parameters.AddWithValue("@ECT_是否正常", RadioButtonList21.Text);
                sqlcommand_d2.Parameters.AddWithValue("@ECT_异常详情", TextBox2.Text);
                if (CheckBox14.Checked) { sqlcommand_d2.Parameters.AddWithValue("@ECT_是否进一步检查", "是"); } else { sqlcommand_d2.Parameters.AddWithValue("@ECT_是否进一步检查", "否"); }
                sqlcommand_d2.Parameters.AddWithValue("@ECT_进一步检查详情", TextBox157.Text);
                if (CheckBox15.Checked) { sqlcommand_d2.Parameters.AddWithValue("@ECT_是否复查", "是"); } else { sqlcommand_d2.Parameters.AddWithValue("@ECT_是否复查", "否"); }
                sqlcommand_d2.Parameters.AddWithValue("@ECT_复查月", TextBox158.Text);
                sqlcommand_d2.Parameters.AddWithValue("@PET_CT_是否正常", RadioButtonList22.Text);
                sqlcommand_d2.Parameters.AddWithValue("@PET_CT_异常详情", TextBox159.Text);
                if (CheckBox16.Checked) { sqlcommand_d2.Parameters.AddWithValue("@PET_CT_是否进一步检查", "是"); } else { sqlcommand_d2.Parameters.AddWithValue("@PET_CT_是否进一步检查", "否"); }
                sqlcommand_d2.Parameters.AddWithValue("@PET_CT_进一步检查详情", TextBox160.Text);
                if (CheckBox17.Checked) { sqlcommand_d2.Parameters.AddWithValue("@PET_CT_是否复查", "是"); } else { sqlcommand_d2.Parameters.AddWithValue("@PET_CT_是否复查", "否"); }
                sqlcommand_d2.Parameters.AddWithValue("@PET_CT_复查月", TextBox161.Text);
                sqlcommand_d2.Parameters.AddWithValue("@结论_是否正常", RadioButtonList23.Text);
                sqlcommand_d2.Parameters.AddWithValue("@结论_是否复发或转移", DropDownList30.Text);
                sqlcommand_d2.Parameters.AddWithValue("@复发或转移详情", TextBox162.Text);
                sqlcommand_d2.Parameters.AddWithValue("@治疗", TextBox163.Text);

                try
                {
                    sqlconn_d2.Open();
                    intAddCount_d2 = sqlcommand_d2.ExecuteNonQuery();

                    if (sqlcommand_d2.ExecuteNonQuery() > 0)
                    {
                        Label150.Text = "添加成功！";
                    }
                    else
                    {
                        Label150.Text = "添加失败！";
                    }
                }
                catch (Exception ex) { Label150.Text = ex.Message; }
                finally
                {
                    sqlcommand_d2 = null;
                    sqlconn_d2.Close();
                    sqlconn_d2 = null;
                }

                //将“随访-诊疗异常反应”页面读入数据库
                int intAddCount_d3 = new int();
                SqlConnection sqlconn_d3 = new SqlConnection(conStr);
                SqlCommand sqlcommand_d3 = new SqlCommand();
                sqlcommand_d3.Connection = sqlconn_d3;
                sqlcommand_d3.CommandText = "INSERT INTO d诊疗异常反应(UCG_正常,UCG_异常,UCG_异常内容,UCG_结论,UCG_建议,肝肾功_正常,肝肾功_异常,肝肾功_异常内容,肝肾功_结论,肝肾功_建议,血糖_正常,血糖_异常,血糖_异常内容,血糖_结论,血糖_建议,血脂_正常,血脂_异常,血脂_异常内容,血脂_结论,血脂_建议,骨密度_正常,骨密度_异常,骨密度_异常内容,骨密度_结论,骨密度_建议,激素水平_未绝经,激素水平_绝经,激素水平_更换内分泌药,就诊卡号)" +
                    "VALUES (@UCG_正常,@UCG_异常,@UCG_异常内容,@UCG_结论,@UCG_建议,@肝肾功_正常,@肝肾功_异常,@肝肾功_异常内容,@肝肾功_结论,@肝肾功_建议,@血糖_正常,@血糖_异常,@血糖_异常内容,@血糖_结论,@血糖_建议,@血脂_正常,@血脂_异常,@血脂_异常内容,@血脂_结论,@血脂_建议,@骨密度_正常,@骨密度_异常,@骨密度_异常内容,@骨密度_结论,@骨密度_建议,@激素水平_未绝经,@激素水平_绝经,@激素水平_更换内分泌药,@就诊卡号)";

                if (RadioButton26.Checked)
                { sqlcommand_d3.Parameters.AddWithValue("@UCG_正常", "正常"); }
                else { sqlcommand_d3.Parameters.AddWithValue("@UCG_正常", ""); }

                if (RadioButton27.Checked)
                { sqlcommand_d3.Parameters.AddWithValue("@UCG_异常", "异常"); }
                else { sqlcommand_d3.Parameters.AddWithValue("@UCG_异常", ""); }

                sqlcommand_d3.Parameters.AddWithValue("@UCG_异常内容", TextBox203.Text);
                sqlcommand_d3.Parameters.AddWithValue("@UCG_结论", TextBox204.Text);
                sqlcommand_d3.Parameters.AddWithValue("@UCG_建议", TextBox205.Text);

                if (RadioButton28.Checked)
                { sqlcommand_d3.Parameters.AddWithValue("@肝肾功_正常", "正常"); }
                else { sqlcommand_d3.Parameters.AddWithValue("@肝肾功_正常", ""); }
                if (RadioButton29.Checked)
                { sqlcommand_d3.Parameters.AddWithValue("@肝肾功_异常", "异常"); }
                else { sqlcommand_d3.Parameters.AddWithValue("@肝肾功_异常", ""); }

                sqlcommand_d3.Parameters.AddWithValue("@肝肾功_异常内容", TextBox206.Text);
                sqlcommand_d3.Parameters.AddWithValue("@肝肾功_结论", TextBox207.Text);
                sqlcommand_d3.Parameters.AddWithValue("@肝肾功_建议", TextBox208.Text);

                if (RadioButton30.Checked)
                { sqlcommand_d3.Parameters.AddWithValue("@血糖_正常", "正常"); }
                else { sqlcommand_d3.Parameters.AddWithValue("@血糖_正常", ""); }
                if (RadioButton31.Checked)
                { sqlcommand_d3.Parameters.AddWithValue("@血糖_异常", "异常"); }
                else { sqlcommand_d3.Parameters.AddWithValue("@血糖_异常", ""); }

                sqlcommand_d3.Parameters.AddWithValue("@血糖_异常内容", TextBox209.Text);
                sqlcommand_d3.Parameters.AddWithValue("@血糖_结论", TextBox210.Text);
                sqlcommand_d3.Parameters.AddWithValue("@血糖_建议", TextBox211.Text);

                if (RadioButton32.Checked)
                { sqlcommand_d3.Parameters.AddWithValue("@血脂_正常", "正常"); }
                else { sqlcommand_d3.Parameters.AddWithValue("@血脂_正常", ""); }
                if (RadioButton33.Checked)
                { sqlcommand_d3.Parameters.AddWithValue("@血脂_异常", "异常"); }
                else { sqlcommand_d3.Parameters.AddWithValue("@血脂_异常", ""); }

                sqlcommand_d3.Parameters.AddWithValue("@血脂_异常内容", TextBox212.Text);
                sqlcommand_d3.Parameters.AddWithValue("@血脂_结论", TextBox213.Text);
                sqlcommand_d3.Parameters.AddWithValue("@血脂_建议", TextBox214.Text);

                if (RadioButton34.Checked)
                { sqlcommand_d3.Parameters.AddWithValue("@骨密度_正常", "正常"); }
                else { sqlcommand_d3.Parameters.AddWithValue("@骨密度_正常", ""); }
                if (RadioButton35.Checked)
                { sqlcommand_d3.Parameters.AddWithValue("@骨密度_异常", "异常"); }
                else { sqlcommand_d3.Parameters.AddWithValue("@骨密度_异常", ""); }

                sqlcommand_d3.Parameters.AddWithValue("@骨密度_异常内容", TextBox215.Text);
                sqlcommand_d3.Parameters.AddWithValue("@骨密度_结论", TextBox216.Text);
                sqlcommand_d3.Parameters.AddWithValue("@骨密度_建议", TextBox217.Text);

                if (RadioButton36.Checked)
                { sqlcommand_d3.Parameters.AddWithValue("@激素水平_未绝经", "未绝经"); }
                else { sqlcommand_d3.Parameters.AddWithValue("@激素水平_未绝经", ""); }
                if (RadioButton37.Checked)
                { sqlcommand_d3.Parameters.AddWithValue("@激素水平_绝经", "绝经"); }
                else { sqlcommand_d3.Parameters.AddWithValue("@激素水平_绝经", ""); }

                sqlcommand_d3.Parameters.AddWithValue("@激素水平_更换内分泌药", TextBox218.Text);
                sqlcommand_d3.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

                try
                {
                    sqlconn_d3.Open();
                    intAddCount_d3 = sqlcommand_d3.ExecuteNonQuery();

                    if (sqlcommand_d3.ExecuteNonQuery() > 0)
                    {
                        Label403.Text = "添加成功！";
                    }
                    else
                    {
                        Label403.Text = "添加失败！";
                    }
                }
                catch (Exception ex) { Label403.Text = ex.Message; }
                finally
                {
                    sqlcommand_d3 = null;
                    sqlconn_d3.Close();
                    sqlconn_d3 = null;
                }

                //将“根治术-根治信息”页面读入数据库
                int intAddCount_e1 = new int();
                SqlConnection sqlconn_e1 = new SqlConnection(conStr);
                SqlCommand sqlcommand_e1 = new SqlCommand();
                sqlcommand_e1.Connection = sqlconn_e1;
                sqlcommand_e1.CommandText = "INSERT INTO e根治信息(手术方式,术前诊断,切口设计,切口设计_cm,皮下打水,分离皮瓣范围_上至,分离皮瓣范围_下至,分离皮瓣范围_内至,分离皮瓣范围_外至,厚度,全乳切除,胸肌受累,胸大肌部分切,就诊卡号)" +
                    "VALUES (@手术方式,@术前诊断,@切口设计,@切口设计_cm,@皮下打水,@分离皮瓣范围_上至,@分离皮瓣范围_下至,@分离皮瓣范围_内至,@分离皮瓣范围_外至,@厚度,@全乳切除,@胸肌受累,@胸大肌部分切,@就诊卡号)";
                sqlcommand_e1.Parameters.AddWithValue("@手术方式", RadioButtonList24.Text);
                sqlcommand_e1.Parameters.AddWithValue("@术前诊断", RadioButtonList25.Text);
                sqlcommand_e1.Parameters.AddWithValue("@切口设计", RadioButtonList26.Text);
                sqlcommand_e1.Parameters.AddWithValue("@切口设计_cm", TextBox219.Text);
                sqlcommand_e1.Parameters.AddWithValue("@皮下打水", RadioButtonList27.Text);
                sqlcommand_e1.Parameters.AddWithValue("@分离皮瓣范围_上至", TextBox220.Text);
                sqlcommand_e1.Parameters.AddWithValue("@分离皮瓣范围_下至", TextBox221.Text);
                sqlcommand_e1.Parameters.AddWithValue("@分离皮瓣范围_内至", TextBox222.Text);
                sqlcommand_e1.Parameters.AddWithValue("@分离皮瓣范围_外至", TextBox223.Text);
                sqlcommand_e1.Parameters.AddWithValue("@厚度", RadioButtonList28.Text);
                sqlcommand_e1.Parameters.AddWithValue("@全乳切除", RadioButtonList29.Text);
                sqlcommand_e1.Parameters.AddWithValue("@胸肌受累", RadioButtonList30.Text);
                sqlcommand_e1.Parameters.AddWithValue("@胸大肌部分切", RadioButtonList31.Text);
                sqlcommand_e1.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

                try
                {
                    sqlconn_e1.Open();
                    intAddCount_e1 = sqlcommand_e1.ExecuteNonQuery();

                    if (sqlcommand_e1.ExecuteNonQuery() > 0)
                    {
                        Label404.Text = "添加成功！";
                    }
                    else
                    {
                        Label404.Text = "添加失败！";
                    }
                }
                catch (Exception ex) { Label404.Text = ex.Message; }
                finally
                {
                    sqlcommand_e1 = null;
                    sqlconn_e1.Close();
                    sqlconn_e1 = null;
                }

                //将“根治术-根治术相关”页面读入数据库
                int intAddCount_e2 = new int();
                SqlConnection sqlconn_e2 = new SqlConnection(conStr);
                SqlCommand sqlcommand_e2 = new SqlCommand();
                sqlcommand_e2.Connection = sqlconn_e2;
                sqlcommand_e2.CommandText = "INSERT INTO e根治术相关(保留胸大小肌_胸肌间脂肪,保留胸大小肌_胸肌间脂肪_切除,保留胸大小肌_可见肿大淋巴结,保留胸大小肌_可见肿大淋巴结数量,保留胸大小肌_胸前神经,保留胸大小肌_解剖过程,保留胸大肌_胸肌间脂肪,保留胸大肌_胸肌间脂肪_切除,保留胸大肌_可见肿大淋巴结,保留胸大肌_可见肿大淋巴结数量,保留胸大肌_胸前神经,保留胸大肌_切断胸小肌喙突端,保留胸大肌_解剖过程,胸大肌保留,胸大肌宽,根治术_切断胸大肌肱骨端,根治术_切断胸小肌喙突端,根治术_解剖过程,就诊卡号)" +
                    "VALUES (@保留胸大小肌_胸肌间脂肪,@保留胸大小肌_胸肌间脂肪_切除,@保留胸大小肌_可见肿大淋巴结,@保留胸大小肌_可见肿大淋巴结数量,@保留胸大小肌_胸前神经,@保留胸大小肌_解剖过程,@保留胸大肌_胸肌间脂肪,@保留胸大肌_胸肌间脂肪_切除,@保留胸大肌_可见肿大淋巴结,@保留胸大肌_可见肿大淋巴结数量,@保留胸大肌_胸前神经,@保留胸大肌_切断胸小肌喙突端,@保留胸大肌_解剖过程,@胸大肌保留,@胸大肌宽,@根治术_切断胸大肌肱骨端,@根治术_切断胸小肌喙突端,@根治术_解剖过程,@就诊卡号)";
                sqlcommand_e2.Parameters.AddWithValue("@保留胸大小肌_胸肌间脂肪", RadioButtonList45.Text);
                sqlcommand_e2.Parameters.AddWithValue("@保留胸大小肌_胸肌间脂肪_切除", RadioButtonList46.Text);

                if (RadioButton22.Checked)
                {
                    sqlcommand_e2.Parameters.AddWithValue("@保留胸大小肌_可见肿大淋巴结", TextBox232.Text);
                }
                else
                {
                    if (RadioButton22.Checked)
                    {
                        sqlcommand_e2.Parameters.AddWithValue("@保留胸大小肌_可见肿大淋巴结", "无");
                    }
                    else
                    {
                        sqlcommand_e2.Parameters.AddWithValue("@保留胸大小肌_可见肿大淋巴结", "");
                    }
                }

                sqlcommand_e2.Parameters.AddWithValue("@保留胸大小肌_可见肿大淋巴结数量", TextBox232.Text);
                sqlcommand_e2.Parameters.AddWithValue("@保留胸大小肌_胸前神经", RadioButtonList47.Text);
                sqlcommand_e2.Parameters.AddWithValue("@保留胸大小肌_解剖过程", TextBox233.Text);
                sqlcommand_e2.Parameters.AddWithValue("@保留胸大肌_胸肌间脂肪", RadioButtonList48.Text);
                sqlcommand_e2.Parameters.AddWithValue("@保留胸大肌_胸肌间脂肪_切除", RadioButtonList49.Text);
                sqlcommand_e2.Parameters.AddWithValue("@保留胸大肌_可见肿大淋巴结", RadioButton24.Text);
                sqlcommand_e2.Parameters.AddWithValue("@保留胸大肌_可见肿大淋巴结数量", TextBox234.Text);
                sqlcommand_e2.Parameters.AddWithValue("@保留胸大肌_胸前神经", RadioButtonList50.Text);
                sqlcommand_e2.Parameters.AddWithValue("@保留胸大肌_切断胸小肌喙突端", CheckBox30.Checked);
                sqlcommand_e2.Parameters.AddWithValue("@保留胸大肌_解剖过程", TextBox235.Text);
                sqlcommand_e2.Parameters.AddWithValue("@胸大肌保留", TextBox236.Text);
                sqlcommand_e2.Parameters.AddWithValue("@胸大肌宽", TextBox237.Text);
                sqlcommand_e2.Parameters.AddWithValue("@根治术_切断胸大肌肱骨端", CheckBox31.Checked);
                sqlcommand_e2.Parameters.AddWithValue("@根治术_切断胸小肌喙突端", CheckBox32.Checked);
                sqlcommand_e2.Parameters.AddWithValue("@根治术_解剖过程", TextBox238.Text);
                sqlcommand_e2.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

                try
                {
                    sqlconn_e2.Open();
                    intAddCount_e2 = sqlcommand_e2.ExecuteNonQuery();

                    if (sqlcommand_e2.ExecuteNonQuery() > 0)
                    {
                        Label405.Text = "添加成功！";
                    }
                    else
                    {
                        Label405.Text = "添加失败！";
                    }
                }
                catch (Exception ex) { Label405.Text = ex.Message; }
                finally
                {
                    sqlcommand_e2 = null;
                    sqlconn_e2.Close();
                    sqlconn_e2 = null;
                }


                //将“根治术-手术相关”页面读入数据库
                int intAddCount_e3 = new int();
                SqlConnection sqlconn_e3 = new SqlConnection(conStr);
                SqlCommand sqlcommand_e3 = new SqlCommand();
                sqlcommand_e3.Connection = sqlconn_e3;
                sqlcommand_e3.CommandText = "INSERT INTO e手术相关(腋脉管带周围肿大淋巴结,肿大淋巴结个数,肿大淋巴结大小,肿大淋巴结硬度,和腋静脉管或鞘膜粘粒,切除,缝合切断,腋尖肿大淋巴结个数,腋尖肿大淋巴结大小,腋尖肿大淋巴结硬度,和锁下静脉鞘粘粒,胸背神经,胸长神经,肩胛下脉管,负压引流,缝合皮肤张力,缝合皮肤植皮,缝合皮肤面积,出血量,手术时间_小时,手术时间_分,就诊卡号)" +
                    "VALUES (@腋脉管带周围肿大淋巴结,@肿大淋巴结个数,@肿大淋巴结大小,@肿大淋巴结硬度,@和腋静脉管或鞘膜粘粒,@切除,@缝合切断,@腋尖肿大淋巴结个数,@腋尖肿大淋巴结大小,@腋尖肿大淋巴结硬度,@和锁下静脉鞘粘粒,@胸背神经,@胸长神经,@肩胛下脉管,@负压引流,@缝合皮肤张力,@缝合皮肤植皮,@缝合皮肤面积,@出血量,@手术时间_小时,@手术时间_分,@就诊卡号)";
                sqlcommand_e3.Parameters.AddWithValue("@腋脉管带周围肿大淋巴结", RadioButtonList32.Text);
                sqlcommand_e3.Parameters.AddWithValue("@肿大淋巴结个数", TextBox224.Text);
                sqlcommand_e3.Parameters.AddWithValue("@肿大淋巴结大小", TextBox225.Text);
                sqlcommand_e3.Parameters.AddWithValue("@肿大淋巴结硬度", RadioButtonList33.Text);
                sqlcommand_e3.Parameters.AddWithValue("@和腋静脉管或鞘膜粘粒", RadioButtonList34.Text);
                sqlcommand_e3.Parameters.AddWithValue("@切除", RadioButtonList35.Text);
                sqlcommand_e3.Parameters.AddWithValue("@缝合切断", RadioButtonList36.Text);
                sqlcommand_e3.Parameters.AddWithValue("@腋尖肿大淋巴结个数", TextBox226.Text);
                sqlcommand_e3.Parameters.AddWithValue("@腋尖肿大淋巴结大小", TextBox227.Text);
                sqlcommand_e3.Parameters.AddWithValue("@腋尖肿大淋巴结硬度", RadioButtonList37.Text);//@,@,@,@,@,@,@,@,
                sqlcommand_e3.Parameters.AddWithValue("@和锁下静脉鞘粘粒", RadioButtonList38.Text);
                sqlcommand_e3.Parameters.AddWithValue("@胸背神经", RadioButtonList39.Text);
                sqlcommand_e3.Parameters.AddWithValue("@胸长神经", RadioButtonList40.Text);
                sqlcommand_e3.Parameters.AddWithValue("@肩胛下脉管", RadioButtonList41.Text);
                sqlcommand_e3.Parameters.AddWithValue("@负压引流", TextBox228.Text);
                sqlcommand_e3.Parameters.AddWithValue("@缝合皮肤张力", RadioButtonList42.Text);
                sqlcommand_e3.Parameters.AddWithValue("@缝合皮肤植皮", RadioButtonList43.Text);
                sqlcommand_e3.Parameters.AddWithValue("@缝合皮肤面积", TextBox229.Text);
                sqlcommand_e3.Parameters.AddWithValue("@出血量", RadioButtonList44.Text);
                sqlcommand_e3.Parameters.AddWithValue("@手术时间_小时", TextBox230.Text);
                sqlcommand_e3.Parameters.AddWithValue("@手术时间_分", TextBox231.Text);
                sqlcommand_e3.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

                try
                {
                    sqlconn_e3.Open();
                    intAddCount_e3 = sqlcommand_e3.ExecuteNonQuery();

                    if (sqlcommand_e3.ExecuteNonQuery() > 0)
                    {
                        Label406.Text = "添加成功！";
                    }
                    else
                    {
                        Label406.Text = "添加失败！";
                    }
                }
                catch (Exception ex) { Label406.Text = ex.Message; }
                finally
                {
                    sqlcommand_e3 = null;
                    sqlconn_e3.Close();
                    sqlconn_e3 = null;
                }

                //将“保乳术-术前信息1”页面值读入数据库
                int intAddCount_f1 = new int();
                SqlConnection sqlconn_f1 = new SqlConnection(conStr);
                SqlCommand sqlcommand_f1 = new SqlCommand();
                sqlcommand_f1.Connection = sqlconn_f1;

                sqlcommand_f1.CommandText = "INSERT INTO f术前信息1(肿瘤部位_侧,肿瘤部位_点,肿瘤大小_横 ,肿瘤大小_纵,肿瘤与乳头距离,胸乳距,乳胸距,锁胸距,胸骨正中距,乳头间距 ,乳房基底横径 ,乳房内侧半径,乳房外侧半径,乳房下侧半径 ,乳头至下皱襞体表距离,乳晕直径 ,乳头直径 ,乳房高度,胸围Ⅰ,胸围Ⅱ,胸围Ⅲ,乳房半径 ,乳房体积计算1 ,超重体重 ,乳房体积计算2,就诊卡号)" +
                    "VALUES (@肿瘤部位_侧,@肿瘤部位_点,@肿瘤大小_横 ,@肿瘤大小_纵,@肿瘤与乳头距离,@胸乳距,@乳胸距,@锁胸距,@胸骨正中距,@乳头间距 ,@乳房基底横径 ,@乳房内侧半径,@乳房外侧半径,@乳房下侧半径 ,@乳头至下皱襞体表距离,@乳晕直径 ,@乳头直径 ,@乳房高度,@胸围Ⅰ,@胸围Ⅱ,@胸围Ⅲ,@乳房半径 ,@乳房体积计算1 ,@超重体重 ,@乳房体积计算2,@就诊卡号)";
                sqlcommand_f1.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);
                sqlcommand_f1.Parameters.AddWithValue("@肿瘤部位_侧", TextBox167.Text);
                sqlcommand_f1.Parameters.AddWithValue("@肿瘤部位_点", TextBox168.Text);
                sqlcommand_f1.Parameters.AddWithValue("@肿瘤大小_横", TextBox169.Text);
                sqlcommand_f1.Parameters.AddWithValue("@肿瘤大小_纵", TextBox170.Text);
                sqlcommand_f1.Parameters.AddWithValue("@肿瘤与乳头距离", TextBox171.Text);
                sqlcommand_f1.Parameters.AddWithValue("@胸乳距", TextBox172.Text);
                sqlcommand_f1.Parameters.AddWithValue("@乳胸距", TextBox173.Text);
                sqlcommand_f1.Parameters.AddWithValue("@锁胸距", TextBox174.Text);
                sqlcommand_f1.Parameters.AddWithValue("@胸骨正中距", TextBox175.Text);
                sqlcommand_f1.Parameters.AddWithValue("@乳头间距", TextBox176.Text);
                sqlcommand_f1.Parameters.AddWithValue("@乳房基底横径", TextBox177.Text);
                sqlcommand_f1.Parameters.AddWithValue("@乳房内侧半径", TextBox178.Text);
                sqlcommand_f1.Parameters.AddWithValue("@乳房外侧半径", TextBox179.Text);
                sqlcommand_f1.Parameters.AddWithValue("@乳房下侧半径", TextBox180.Text);
                sqlcommand_f1.Parameters.AddWithValue("@乳头至下皱襞体表距离", TextBox181.Text);
                sqlcommand_f1.Parameters.AddWithValue("@乳晕直径", TextBox182.Text);
                sqlcommand_f1.Parameters.AddWithValue("@乳头直径", TextBox183.Text);
                sqlcommand_f1.Parameters.AddWithValue("@乳房高度", TextBox184.Text);
                sqlcommand_f1.Parameters.AddWithValue("@胸围Ⅰ", TextBox185.Text);
                sqlcommand_f1.Parameters.AddWithValue("@胸围Ⅱ", TextBox186.Text);
                sqlcommand_f1.Parameters.AddWithValue("@胸围Ⅲ", TextBox187.Text);
                sqlcommand_f1.Parameters.AddWithValue("@乳房半径", TextBox188.Text);
                sqlcommand_f1.Parameters.AddWithValue("@乳房体积计算1", TextBox189.Text);
                sqlcommand_f1.Parameters.AddWithValue("@超重体重", TextBox190.Text);
                sqlcommand_f1.Parameters.AddWithValue("@乳房体积计算2", TextBox191.Text);

                try
                {
                    sqlconn_f1.Open();
                    intAddCount_f1 = sqlcommand_f1.ExecuteNonQuery();

                    if (sqlcommand_f1.ExecuteNonQuery() > 0)
                    {
                        Label399.Text = "添加成功！";
                    }
                    else
                    {
                        Label399.Text = "添加失败！";
                    }
                }
                catch (Exception ex) { Label399.Text = ex.Message; }
                finally
                {
                    sqlcommand_f1 = null;
                    sqlconn_f1.Close();
                    sqlconn_f1 = null;
                }

                //将f2页面值读入数据库
                int intAddCount_f2 = new int();
                SqlConnection sqlconn_f2 = new SqlConnection(conStr);
                SqlCommand sqlcommand_f2 = new SqlCommand();
                sqlcommand_f2.Connection = sqlconn_f2;

                sqlcommand_f2.CommandText = " INSERT INTO f术前信息2(影像信息,诊断信息,治疗信息,就诊卡号)" +
                    "VALUES (@影像信息,@诊断信息,@治疗信息,@就诊卡号)";

                sqlcommand_f2.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);
                sqlcommand_f2.Parameters.AddWithValue("@影像信息", f2Tb1.Text);
                sqlcommand_f2.Parameters.AddWithValue("@诊断信息", f2Tb2.Text);
                sqlcommand_f2.Parameters.AddWithValue("@治疗信息", f2Tb3.Text);

                try
                {
                    sqlconn_f2.Open();
                    intAddCount_f2 = sqlcommand_f2.ExecuteNonQuery();

                    if (sqlcommand_f2.ExecuteNonQuery() > 0)
                    {
                        f2LbInsert.Text = "添加成功！";
                    }
                    else
                    {
                        f2LbInsert.Text = "添加失败！";
                    }
                }
                catch (Exception ex) { f2LbInsert.Text = ex.Message; }
                finally
                {
                    sqlcommand_f2 = null;
                    sqlconn_f2.Close();
                    sqlconn_f2 = null;
                }

                //将“保乳术-手术信息”页面值读入数据库
                int intAddCount_f3 = new int();
                SqlConnection sqlconn_f3 = new SqlConnection(conStr);
                SqlCommand sqlcommand_f3 = new SqlCommand();
                sqlcommand_f3.Connection = sqlconn_f3;

                sqlcommand_f3.CommandText = "INSERT INTO f手术信息(切口类型,切口类型_其他,横径,纵径,体积_排水法,切缘病理阴阳性,切缘病理位置,是否二次扩切,二次切缘病理阴阳性,二次切缘病理位置,保乳术是否成功,是否前哨淋巴结活检,是否保乳整形,整形方式,就诊卡号)" +
                    "VALUES (@切口类型,@切口类型_其他,@横径,@纵径,@体积_排水法,@切缘病理阴阳性,@切缘病理位置,@是否二次扩切,@二次切缘病理阴阳性,@二次切缘病理位置,@保乳术是否成功,@是否前哨淋巴结活检,@是否保乳整形,@整形方式,@就诊卡号)";

                sqlcommand_f3.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);
                string f3_a = "";
                if (RadioButton1.Checked) { f3_a = RadioButton1.Text; }
                if (RadioButton2.Checked) { f3_a = RadioButton2.Text; }
                if (RadioButton3.Checked) { f3_a = RadioButton3.Text; }
                sqlcommand_f3.Parameters.AddWithValue("@切口类型", f3_a);
                sqlcommand_f3.Parameters.AddWithValue("@切口类型_其他", TextBox310.Text);
                sqlcommand_f3.Parameters.AddWithValue("@横径", TextBox192.Text);
                sqlcommand_f3.Parameters.AddWithValue("@纵径", TextBox193.Text);
                sqlcommand_f3.Parameters.AddWithValue("@体积_排水法", TextBox194.Text);
                string f3_b = "";
                if (RadioButton4.Checked) { f3_b = RadioButton4.Text; }
                if (RadioButton5.Checked) { f3_b = RadioButton5.Text; }
                sqlcommand_f3.Parameters.AddWithValue("@切缘病理阴阳性", f3_b);
                sqlcommand_f3.Parameters.AddWithValue("@切缘病理位置", TextBox195.Text);
                string f3_c = "";
                if (RadioButton6.Checked) { f3_c = RadioButton6.Text; }
                if (RadioButton7.Checked) { f3_c = RadioButton7.Text; }
                sqlcommand_f3.Parameters.AddWithValue("@是否二次扩切", f3_c);
                string f3_d = "";
                if (RadioButton8.Checked) { f3_d = RadioButton8.Text; }
                if (RadioButton9.Checked) { f3_d = RadioButton9.Text; }
                sqlcommand_f3.Parameters.AddWithValue("@二次切缘病理阴阳性", f3_d);
                sqlcommand_f3.Parameters.AddWithValue("@二次切缘病理位置", TextBox196.Text);
                string f3_e = "";
                if (RadioButton10.Checked) { f3_e = RadioButton10.Text; }
                if (RadioButton11.Checked) { f3_e = RadioButton11.Text; }
                sqlcommand_f3.Parameters.AddWithValue("@保乳术是否成功", f3_e);
                string f3_f = "";
                if (RadioButton12.Checked) { f3_f = RadioButton12.Text; }
                if (RadioButton13.Checked) { f3_f = RadioButton13.Text; }
                sqlcommand_f3.Parameters.AddWithValue("@是否前哨淋巴结活检", f3_f);
                string f3_g = "";
                if (RadioButton14.Checked) { f3_g = RadioButton14.Text; }
                if (RadioButton15.Checked) { f3_g = RadioButton15.Text; }
                sqlcommand_f3.Parameters.AddWithValue("@是否保乳整形", f3_g);
                sqlcommand_f3.Parameters.AddWithValue("@整形方式", TextBox311.Text);

                try
                {
                    sqlconn_f3.Open();
                    intAddCount_f3 = sqlcommand_f3.ExecuteNonQuery();

                    if (sqlcommand_f3.ExecuteNonQuery() > 0)
                    {
                        Label400.Text = "添加成功！";
                    }
                    else
                    {
                        Label400.Text = "添加失败！";
                    }
                }
                catch (Exception ex) { Label400.Text = ex.Message; }
                finally
                {
                    sqlcommand_f3 = null;
                    sqlconn_f3.Close();
                    sqlconn_f3 = null;
                }

                //将“保乳术-术后信息”页面值读入数据库
                int intAddCount_f4 = new int();
                SqlConnection sqlconn_f4 = new SqlConnection(conStr);
                SqlCommand sqlcommand_f4 = new SqlCommand();
                sqlcommand_f4.Connection = sqlconn_f4;

                sqlcommand_f4.CommandText = " INSERT INTO f术后信息(引流时间_天,引流总量_ml,是否术后感染,术后感染_处理方式,就诊卡号,术后放疗)" +
                    "VALUES (@引流时间_天,@引流总量_ml,@是否术后感染,@术后感染_处理方式,@就诊卡号,@术后放疗)";
                sqlcommand_f4.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);
                sqlcommand_f4.Parameters.AddWithValue("@引流时间_天", f4Tb1.Text);
                sqlcommand_f4.Parameters.AddWithValue("@引流总量_ml", f4Tb2.Text);
                string f4_a = "";
                if (f4Rb1.Checked) { f4_a = f4Rb1.Text; }
                if (f4Rb2.Checked) { f4_a = f4Rb2.Text; }
                sqlcommand_f4.Parameters.AddWithValue("@是否术后感染", f4_a);
                sqlcommand_f4.Parameters.AddWithValue("@术后感染_处理方式", f4Tb3.Text);
                sqlcommand_f4.Parameters.AddWithValue("@术后放疗", f4Tb4.Text);

                try
                {
                    sqlconn_f4.Open();
                    intAddCount_f4 = sqlcommand_f4.ExecuteNonQuery();

                    if (sqlcommand_f4.ExecuteNonQuery() > 0)
                    {
                        Label401.Text = "添加成功！";
                    }
                    else
                    {
                        Label401.Text = "添加失败！";
                    }
                }
                catch (Exception ex) { Label401.Text = ex.Message; }
                finally
                {
                    sqlcommand_f4 = null;
                    sqlconn_f4.Close();
                    sqlconn_f4 = null;
                }

                //将“保乳术-生活质量及美学指标”页面值读入数据库
                int intAddCount_f5 = new int();
                SqlConnection sqlconn_f5 = new SqlConnection(conStr);
                SqlCommand sqlcommand_f5 = new SqlCommand();
                sqlcommand_f5.Connection = sqlconn_f5;

                sqlcommand_f5.CommandText = " INSERT INTO f生活质量及美学指标 (Harris分级标准,乳房大小,乳房质地_有无硬化,乳房形状,乳房挺度_高度,乳房皮肤颜色,乳房敏感度_感觉,乳房外观,瘢痕组织,乳房肿胀,乳房疼痛,乳房触感_有无触痛,肩部疼痛,肩部僵硬,肩部活动,上肢疼痛,上肢僵硬,上肢活动,上肢肿胀,提举重物的能力,肋部疼痛,乳罩的合适度,衣服的合适度,问题1,问题2,问题3,问题4,问题5,问题6,问题7,问题8,问题9,问题10,客观美容及功能评估1,客观美容及功能评估2,客观美容及功能评估3,客观美容及功能评估4,就诊卡号)" +
                    "VALUES (@Harris分级标准,@乳房大小,@乳房质地_有无硬化,@乳房形状,@乳房挺度_高度,@乳房皮肤颜色,@乳房敏感度_感觉,@乳房外观,@瘢痕组织,@乳房肿胀,@乳房疼痛,@乳房触感_有无触痛,@肩部疼痛,@肩部僵硬,@肩部活动,@上肢疼痛,@上肢僵硬,@上肢活动,@上肢肿胀,@提举重物的能力,@肋部疼痛,@乳罩的合适度,@衣服的合适度,@问题1,@问题2,@问题3,@问题4,@问题5,@问题6,@问题7,@问题8,@问题9,@问题10,@客观美容及功能评估1,@客观美容及功能评估2,@客观美容及功能评估3,@客观美容及功能评估4,@就诊卡号)";

                string f5_a = "";
                if (RadioButton18.Checked) { f5_a = RadioButton18.Text; }
                if (RadioButton19.Checked) { f5_a = RadioButton19.Text; }
                if (RadioButton20.Checked) { f5_a = RadioButton20.Text; }
                if (RadioButton21.Checked) { f5_a = RadioButton21.Text; }
                sqlcommand_f5.Parameters.AddWithValue("@Harris分级标准", f5_a);
                sqlcommand_f5.Parameters.AddWithValue("@乳房大小", RadioButtonList51.Text);
                sqlcommand_f5.Parameters.AddWithValue("@乳房质地_有无硬化", RadioButtonList82.Text);
                sqlcommand_f5.Parameters.AddWithValue("@乳房形状", RadioButtonList52.Text);
                sqlcommand_f5.Parameters.AddWithValue("@乳房挺度_高度", RadioButtonList53.Text);
                sqlcommand_f5.Parameters.AddWithValue("@乳房皮肤颜色", RadioButtonList54.Text);
                sqlcommand_f5.Parameters.AddWithValue("@乳房敏感度_感觉", RadioButtonList55.Text);
                sqlcommand_f5.Parameters.AddWithValue("@乳房外观", RadioButtonList56.Text);
                sqlcommand_f5.Parameters.AddWithValue("@瘢痕组织", RadioButtonList57.Text);
                sqlcommand_f5.Parameters.AddWithValue("@乳房肿胀", RadioButtonList58.Text);
                sqlcommand_f5.Parameters.AddWithValue("@乳房疼痛", RadioButtonList59.Text);
                sqlcommand_f5.Parameters.AddWithValue("@乳房触感_有无触痛", RadioButtonList60.Text);
                sqlcommand_f5.Parameters.AddWithValue("@肩部疼痛", RadioButtonList61.Text);
                sqlcommand_f5.Parameters.AddWithValue("@肩部僵硬", RadioButtonList62.Text);
                sqlcommand_f5.Parameters.AddWithValue("@肩部活动", RadioButtonList63.Text);
                sqlcommand_f5.Parameters.AddWithValue("@上肢疼痛", RadioButtonList64.Text);
                sqlcommand_f5.Parameters.AddWithValue("@上肢僵硬", RadioButtonList65.Text);
                sqlcommand_f5.Parameters.AddWithValue("@上肢活动", RadioButtonList66.Text);
                sqlcommand_f5.Parameters.AddWithValue("@上肢肿胀", RadioButtonList67.Text);
                sqlcommand_f5.Parameters.AddWithValue("@提举重物的能力", RadioButtonList68.Text);
                sqlcommand_f5.Parameters.AddWithValue("@肋部疼痛", RadioButtonList69.Text);
                sqlcommand_f5.Parameters.AddWithValue("@乳罩的合适度", RadioButtonList70.Text);
                sqlcommand_f5.Parameters.AddWithValue("@衣服的合适度", RadioButtonList71.Text);
                sqlcommand_f5.Parameters.AddWithValue("@问题1", RadioButtonList72.Text);
                sqlcommand_f5.Parameters.AddWithValue("@问题2", RadioButtonList73.Text);
                sqlcommand_f5.Parameters.AddWithValue("@问题3", RadioButtonList74.Text);
                sqlcommand_f5.Parameters.AddWithValue("@问题4", RadioButtonList75.Text);
                sqlcommand_f5.Parameters.AddWithValue("@问题5", RadioButtonList76.Text);
                sqlcommand_f5.Parameters.AddWithValue("@问题6", RadioButtonList77.Text);
                sqlcommand_f5.Parameters.AddWithValue("@问题7", RadioButtonList78.Text);
                sqlcommand_f5.Parameters.AddWithValue("@问题8", RadioButtonList79.Text);
                sqlcommand_f5.Parameters.AddWithValue("@问题9", RadioButtonList80.Text);
                sqlcommand_f5.Parameters.AddWithValue("@问题10", RadioButtonList81.Text);
                sqlcommand_f5.Parameters.AddWithValue("@客观美容及功能评估1", TextBox199.Text);
                sqlcommand_f5.Parameters.AddWithValue("@客观美容及功能评估2", TextBox200.Text);
                sqlcommand_f5.Parameters.AddWithValue("@客观美容及功能评估3", TextBox201.Text);
                sqlcommand_f5.Parameters.AddWithValue("@客观美容及功能评估4", TextBox202.Text);
                sqlcommand_f5.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

                try
                {
                    sqlconn_f5.Open();
                    intAddCount_f5 = sqlcommand_f5.ExecuteNonQuery();

                    if (sqlcommand_f5.ExecuteNonQuery() > 0)
                    {
                        Label402.Text = "添加成功！";
                    }
                    else
                    {
                        Label402.Text = "添加失败！";
                    }
                }
                catch (Exception ex) { Label402.Text = ex.Message; }
                finally
                {
                    sqlcommand_f5 = null;
                    sqlconn_f5.Close();
                    sqlconn_f5 = null;
                }
                Response.Redirect("index.aspx");

                Panel89.Enabled = false;
            }
        }

        //实现点击“编辑”按钮后的读值操作
        //
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (Label500.Text == "")
            {
                Response.Write("<script language='javascript'>alert('请选择数据！')</script>");
            }
            else
            {
                Panel89.Enabled = true;
                TextBox2.Enabled = false;

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString());
                string sqlconnstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

                //a1
                SqlConnection sqlconn_a1 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_a1 = new SqlCommand();
                sqlcommand_a1.Connection = sqlconn_a1;

                sqlconn_a1.Open();//attention
                sqlcommand_a1.CommandText = "select * from a入院概要 where 就诊卡号=@就诊卡号";
                sqlcommand_a1.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader = sqlcommand_a1.ExecuteReader();
                if (sqldatareader.Read())
                {
                    TextBox2.Text = sqldatareader.GetString(0);
                    TextBox1.Text = sqldatareader.GetString(1);
                    TextBox10.Text = sqldatareader.GetString(2);
                    TextBox3.Text = sqldatareader.GetString(3);
                    TextBox4.Text = sqldatareader.GetString(4);
                    TextBox5.Text = sqldatareader.GetString(5);
                    TextBox6.Text = sqldatareader.GetString(6);
                    TextBox7.Text = sqldatareader.GetString(7);
                    TextBox8.Text = sqldatareader.GetString(8);
                    TextBox9.Text = sqldatareader.GetString(9);
                    TextBox11.Text = sqldatareader.GetString(10);

                    //入院日期
                    string a11 = sqldatareader.GetString(11);
                    string[] a12;
                    a12 = a11.Split(':');
                    string[] a12_1;
                    a12_1 = a12[0].Split(' ');
                    TextBox12.Text = a12_1[0];
                    TextBox12a.Text = a12_1[1];
                    TextBox12b.Text = a12[1];
                    TextBox12c.Text = a12[2];

                    TextBox14.Text = sqldatareader.GetString(12);
                    TextBox15.Text = sqldatareader.GetString(13);
                    TextBox16.Text = sqldatareader.GetString(14);

                    //记录日期
                    string a13 = sqldatareader.GetString(15);
                    string[] a14;
                    a14 = a13.Split(':');
                    string[] a14_1;
                    a14_1 = a14[0].Split(' ');
                    TextBox13.Text = a14_1[0];
                    TextBox13a.Text = a14_1[1];
                    TextBox13b.Text = a14[1];
                    TextBox13c.Text = a14[2];
                }
                sqlcommand_a1 = null;
                sqlconn_a1.Close();
                sqlconn_a1 = null;

                //a2已完
                SqlConnection sqlconn_a2 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_a2 = new SqlCommand();
                sqlcommand_a2.Connection = sqlconn_a2;

                sqlconn_a2.Open();
                sqlcommand_a2.CommandText = "select * from a主诉 where 就诊卡号=@就诊卡号";
                sqlcommand_a2.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_a2 = sqlcommand_a2.ExecuteReader();
                if (sqldatareader_a2.Read())
                {
                    //主要症状_侧别
                    DropDownList31.SelectedValue = sqldatareader_a2.GetString(0).Trim();
                    //主要症状_位置
                    DropDownList32.SelectedValue = sqldatareader_a2.GetString(1).Trim();
                    //主要症状
                    string a2_5 = sqldatareader_a2.GetString(2).Trim();
                    if (a2_5.Contains("肿物")) { CheckBox33.Checked = true; }
                    if (a2_5.Contains("溢液")) { CheckBox34.Checked = true; }
                    if (a2_5.Contains("疼痛")) { CheckBox35.Checked = true; }
                    if (a2_5.Contains("湿疹")) { CheckBox36.Checked = true; }
                    if (a2_5.Contains("凹陷")) { CheckBox37.Checked = true; }
                    if (a2_5.Contains("水肿")) { CheckBox38.Checked = true; }
                    if (a2_5.Contains("卫星结节")) { CheckBox39.Checked = true; }
                    if (a2_5.Contains("破溃")) { CheckBox40.Checked = true; }
                    //主要症状时间
                    string a2_1 = sqldatareader_a2.GetString(3).Trim();
                    char[] result_a2_1 = a2_1.ToCharArray();
                    string str_a2_1 = "";
                    for (int i = 0; i < a2_1.Length; i++)
                    {
                        if (result_a2_1[i] >= '0' && result_a2_1[i] <= '9')
                        {
                            str_a2_1 += result_a2_1[i];
                        }
                    }
                    TextBox239.Text = str_a2_1;
                    DropDownList33.SelectedValue = a2_1.Substring(a2_1.Length - 1, 1);
                    //伴随症状_侧别
                    DropDownList34.SelectedValue = sqldatareader_a2.GetString(4).Trim();
                    //伴随症状_位置
                    DropDownList35.SelectedValue = sqldatareader_a2.GetString(5).Trim();
                    //伴随症状
                    string a2_6 = sqldatareader_a2.GetString(6).Trim();
                    if (a2_6.Contains("肿物")) { CheckBox41.Checked = true; }
                    if (a2_6.Contains("溢液")) { CheckBox42.Checked = true; }
                    if (a2_6.Contains("疼痛")) { CheckBox43.Checked = true; }
                    if (a2_6.Contains("湿疹")) { CheckBox44.Checked = true; }
                    if (a2_6.Contains("凹陷")) { CheckBox45.Checked = true; }
                    if (a2_6.Contains("水肿")) { CheckBox46.Checked = true; }
                    if (a2_6.Contains("卫星结节")) { CheckBox47.Checked = true; }
                    if (a2_5.Contains("破溃")) { CheckBox48.Checked = true; }
                    //伴随症状时间
                    string a2_2 = sqldatareader_a2.GetString(7).Trim();
                    char[] result_a2_2 = a2_2.ToCharArray();
                    string str_a2_2 = "";
                    for (int i = 0; i < a2_2.Length; i++)
                    {
                        if (result_a2_2[i] >= '0' && result_a2_2[i] <= '9')
                        {
                            str_a2_2 += result_a2_2[i];
                        }
                    }
                    TextBox240.Text = str_a2_2;
                    DropDownList36.SelectedValue = a2_2.Substring(a2_2.Length - 1, 1);
                    //增大时间
                    string a2_3 = sqldatareader_a2.GetString(8).Trim();
                    char[] result_a2_3 = a2_3.ToCharArray();
                    string str_a2_3 = "";
                    for (int i = 0; i < a2_3.Length; i++)
                    {
                        if (result_a2_3[i] >= '0' && result_a2_3[i] <= '9')
                        {
                            str_a2_3 += result_a2_3[i];
                        }
                    }
                    TextBox241.Text = str_a2_3;
                    DropDownList37.SelectedValue = a2_3.Substring(a2_3.Length - 1, 1);
                    //转为血性时间
                    string a2_4 = sqldatareader_a2.GetString(9).Trim();
                    char[] result_a2_4 = a2_4.ToCharArray();
                    string str_a2_4 = "";
                    for (int i = 0; i < a2_4.Length; i++)
                    {
                        if (result_a2_4[i] >= '0' && result_a2_4[i] <= '9')
                        {
                            str_a2_4 += result_a2_4[i];
                        }
                    }
                    TextBox242.Text = str_a2_4;
                    DropDownList38.SelectedValue = a2_4.Substring(a2_4.Length - 1, 1);
                }
                sqlcommand_a2 = null;
                sqlconn_a2.Close();
                sqlconn_a2 = null;

                //a3已完
                SqlConnection sqlconn_a3 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_a3 = new SqlCommand();
                sqlcommand_a3.Connection = sqlconn_a3;

                sqlconn_a3.Open();//attention
                sqlcommand_a3.CommandText = "select * from a现病史 where 就诊卡号=@就诊卡号";
                sqlcommand_a3.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_a3 = sqlcommand_a3.ExecuteReader();
                if (sqldatareader_a3.Read())
                {
                    //发现时长
                    string a3_1 = sqldatareader_a3.GetString(0).Trim();
                    char[] result_a3_1 = a3_1.ToCharArray();
                    string str_a3_1 = "";
                    for (int i = 0; i < a3_1.Length; i++)
                    {
                        if (result_a3_1[i] >= '0' && result_a3_1[i] <= '9')
                        {
                            str_a3_1 += result_a3_1[i];
                        }
                    }
                    TextBox243.Text = str_a3_1;
                    DropDownList39.SelectedValue = a3_1.Substring(a3_1.Length - 1, 1);
                    //发现原因
                    DropDownList40.SelectedValue = sqldatareader_a3.GetString(1).Trim();
                    //诱因
                    DropDownList41.SelectedValue = sqldatareader_a3.GetString(2).Trim();
                    TextBox244.Text = sqldatareader_a3.GetString(16);
                    //病因
                    DropDownList42.SelectedValue = sqldatareader_a3.GetString(3).Trim();
                    TextBox245.Text = sqldatareader_a3.GetString(17);
                    //肿瘤大小
                    //select substr(肿瘤大小,1,instr(肿瘤大小, '*', -1) - 1) from a现病史;
                    string a3_2 = sqldatareader_a3.GetString(4).Trim();
                    string ab3_2 = a3_2.Split('*')[0];//*左
                    string aa3_2 = a3_2.Split('*')[1];//*右
                    TextBox283.Text = ab3_2;
                    TextBox284.Text = aa3_2;
                    //压痛情况
                    DropDownList43.SelectedValue = sqldatareader_a3.GetString(5).Trim();
                    //乳头溢液
                    DropDownList44.SelectedValue = sqldatareader_a3.GetString(6).Trim();
                    //溢液数量
                    DropDownList45.SelectedValue = sqldatareader_a3.GetString(7).Trim();
                    //溢液性状
                    DropDownList46.SelectedValue = sqldatareader_a3.GetString(8).Trim();
                    //溢液动能
                    DropDownList47.SelectedValue = sqldatareader_a3.GetString(9).Trim();
                    //就诊经历
                    DropDownList48.SelectedValue = sqldatareader_a3.GetString(10).Trim();
                    //于何处诊疗
                    TextBox285.Text = sqldatareader_a3.GetString(11);
                    //诊疗过程
                    TextBox286.Text = sqldatareader_a3.GetString(12);
                    //诊疗疗效
                    DropDownList96.SelectedValue = sqldatareader_a3.GetString(13).Trim();
                    //诊疗转归
                    DropDownList49.SelectedValue = sqldatareader_a3.GetString(14).Trim();
                    DropDownList50.SelectedValue = sqldatareader_a3.GetString(18).Trim();
                }
                sqlcommand_a3 = null;
                sqlconn_a3.Close();
                sqlconn_a3 = null;

                //a4已完
                SqlConnection sqlconn_a4 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_a4 = new SqlCommand();
                sqlcommand_a4.Connection = sqlconn_a4;

                sqlconn_a4.Open();//attention
                sqlcommand_a4.CommandText = "select * from a身体状况 where 就诊卡号=@就诊卡号";
                sqlcommand_a4.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_a4 = sqlcommand_a4.ExecuteReader();
                if (sqldatareader_a4.Read())
                {
                    //一般状况
                    DropDownList1.SelectedValue = sqldatareader_a4.GetString(0).Trim();
                    //精神
                    DropDownList2.SelectedValue = sqldatareader_a4.GetString(1).Trim();
                    //食睡
                    DropDownList3.SelectedValue = sqldatareader_a4.GetString(2).Trim();
                    //二便
                    DropDownList4.SelectedValue = sqldatareader_a4.GetString(3).Trim();
                    //体重
                    DropDownList5.SelectedValue = sqldatareader_a4.GetString(4).Trim();
                    //体力
                    DropDownList6.SelectedValue = sqldatareader_a4.GetString(5).Trim();
                    //既往体健
                    DropDownList7.SelectedValue = sqldatareader_a4.GetString(6).Trim();
                    //疾病史冠心病7
                    if (sqldatareader_a4.IsDBNull(7)) { TextBox17.Text = ""; } else { TextBox17.Text = sqldatareader_a4.GetString(7); }
                    //疾病史糖尿病8
                    if (sqldatareader_a4.IsDBNull(8)) { TextBox18.Text = ""; } else { TextBox18.Text = sqldatareader_a4.GetString(8); }
                    //疾病史高血压9
                    if (sqldatareader_a4.IsDBNull(9)) { TextBox19.Text = ""; } else { TextBox19.Text = sqldatareader_a4.GetString(9); }
                    //疾病史甲亢病10
                    if (sqldatareader_a4.IsDBNull(10)) { TextBox20.Text = ""; } else { TextBox20.Text = sqldatareader_a4.GetString(10); }
                    //手术史
                    DropDownList8.SelectedValue = sqldatareader_a4.GetString(11).Trim();
                    //外伤史
                    DropDownList9.SelectedValue = sqldatareader_a4.GetString(12).Trim();
                    //输血史
                    DropDownList10.SelectedValue = sqldatareader_a4.GetString(13).Trim();
                    //过敏史
                    DropDownList11.SelectedValue = sqldatareader_a4.GetString(14).Trim();
                    //手术史_时间17
                    if (sqldatareader_a4.IsDBNull(17)) { TextBox21.Text = ""; } else { TextBox21.Text = sqldatareader_a4.GetString(17); }
                    //手术史_于何处18
                    if (sqldatareader_a4.IsDBNull(18)) { TextBox22.Text = ""; } else { TextBox22.Text = sqldatareader_a4.GetString(18); }
                    //进行何种手术19
                    if (sqldatareader_a4.IsDBNull(19)) { TextBox23.Text = ""; } else { TextBox23.Text = sqldatareader_a4.GetString(19); }
                    //外伤史_时间20
                    if (sqldatareader_a4.IsDBNull(20)) { TextBox302.Text = ""; } else { TextBox302.Text = sqldatareader_a4.GetString(20); }
                    //外伤史_于何处21
                    if (sqldatareader_a4.IsDBNull(21)) { TextBox303.Text = ""; } else { TextBox303.Text = sqldatareader_a4.GetString(21); }
                    //受过何种外伤22
                    if (sqldatareader_a4.IsDBNull(22)) { TextBox304.Text = ""; } else { TextBox304.Text = sqldatareader_a4.GetString(22); }
                    //输血史_时间23
                    if (sqldatareader_a4.IsDBNull(23)) { TextBox305.Text = ""; } else { TextBox305.Text = sqldatareader_a4.GetString(23); }
                    //输血史_于何处24
                    if (sqldatareader_a4.IsDBNull(24)) { TextBox306.Text = ""; } else { TextBox306.Text = sqldatareader_a4.GetString(24); }
                    //因何输血25
                    if (sqldatareader_a4.IsDBNull(25)) { TextBox307.Text = ""; } else { TextBox307.Text = sqldatareader_a4.GetString(25); }
                    //食物详情26
                    if (sqldatareader_a4.IsDBNull(26)) { TextBox308.Text = ""; } else { TextBox308.Text = sqldatareader_a4.GetString(26); }
                    //药物详情27
                    if (sqldatareader_a4.IsDBNull(27)) { TextBox309.Text = ""; } else { TextBox309.Text = sqldatareader_a4.GetString(27); }
                    //食物
                    if (sqldatareader_a4.IsDBNull(28)) { } else { DropDownList97.SelectedValue = sqldatareader_a4.GetString(28).Trim(); }
                    //药物
                    if (sqldatareader_a4.IsDBNull(29)) { } else { DropDownList98.SelectedValue = sqldatareader_a4.GetString(29).Trim(); }
                }
                sqlcommand_a4 = null;
                sqlconn_a4.Close();
                sqlconn_a4 = null;

                //a5已完
                SqlConnection sqlconn_a5 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_a5 = new SqlCommand();
                sqlcommand_a5.Connection = sqlconn_a5;

                sqlconn_a5.Open();//attention
                sqlcommand_a5.CommandText = "select * from a个人情况 where 就诊卡号=@就诊卡号";
                sqlcommand_a5.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_a5 = sqlcommand_a5.ExecuteReader();
                if (sqldatareader_a5.Read())
                {
                    //身高
                    if (sqldatareader_a5.IsDBNull(0)) { TextBox246.Text = ""; } else { TextBox246.Text = sqldatareader_a5.GetString(0); }
                    //体重
                    if (sqldatareader_a5.IsDBNull(1)) { TextBox247.Text = ""; } else { TextBox247.Text = sqldatareader_a5.GetString(1); }
                    //T°
                    if (sqldatareader_a5.IsDBNull(2)) { TextBox248.Text = ""; } else { TextBox248.Text = sqldatareader_a5.GetString(2); }
                    //P
                    if (sqldatareader_a5.IsDBNull(3)) { TextBox249.Text = ""; } else { TextBox249.Text = sqldatareader_a5.GetString(3); }
                    //R
                    if (sqldatareader_a5.IsDBNull(4)) { TextBox250.Text = ""; } else { TextBox250.Text = sqldatareader_a5.GetString(4); }
                    //BP
                    if (sqldatareader_a5.IsDBNull(5)) { TextBox251.Text = ""; } else { TextBox251.Text = sqldatareader_a5.GetString(5); }
                    //KPS
                    if (sqldatareader_a5.IsDBNull(6)) { TextBox252.Text = ""; } else { TextBox252.Text = sqldatareader_a5.GetString(6); }
                    //BSA
                    if (sqldatareader_a5.IsDBNull(7)) { TextBox253.Text = ""; } else { TextBox253.Text = sqldatareader_a5.GetString(7); }
                    //出生地
                    if (sqldatareader_a5.IsDBNull(8)) { TextBox254.Text = ""; } else { TextBox254.Text = sqldatareader_a5.GetString(8); }
                    //生长接触史
                    string a5_1 = sqldatareader_a5.GetString(9).Trim();
                    if (a5_1.Contains("毒物")) { CheckBox49.Checked = true; }
                    if (a5_1.Contains("粉尘")) { CheckBox50.Checked = true; }
                    if (a5_1.Contains("放射")) { CheckBox51.Checked = true; }
                    if (a5_1.Contains("疫区")) { CheckBox52.Checked = true; }
                    if (a5_1.Contains("烟酒嗜好")) { CheckBox53.Checked = true; }
                    //烟酒详情
                    if (sqldatareader_a5.IsDBNull(33)) { TextBox255.Text = ""; } else { TextBox255.Text = sqldatareader_a5.GetString(33); }
                    //初潮年龄
                    if (sqldatareader_a5.IsDBNull(10)) { TextBox256.Text = ""; } else { TextBox256.Text = sqldatareader_a5.GetString(10); }
                    //初潮年龄_分子
                    if (sqldatareader_a5.IsDBNull(28)) { TextBox257.Text = ""; } else { TextBox257.Text = sqldatareader_a5.GetString(28); }
                    //初潮年龄_分母
                    if (sqldatareader_a5.IsDBNull(29)) { TextBox260.Text = ""; } else { TextBox260.Text = sqldatareader_a5.GetString(29); }
                    //绝经年龄
                    if (sqldatareader_a5.IsDBNull(11)) { TextBox258.Text = ""; } else { TextBox258.Text = sqldatareader_a5.GetString(11); }
                    //末次月经
                    if (sqldatareader_a5.IsDBNull(12)) { TextBox259.Text = ""; } else { TextBox259.Text = sqldatareader_a5.GetString(12); }
                    //痛经情况13
                    if (sqldatareader_a5.GetString(13) == "是") { CheckBox54.Checked = true; }
                    //结婚情况14
                    DropDownList51.SelectedValue = sqldatareader_a5.GetString(14).Trim();
                    //结婚年龄
                    if (sqldatareader_a5.IsDBNull(15)) { TextBox261.Text = ""; } else { TextBox261.Text = sqldatareader_a5.GetString(15); }
                    //配偶情况16
                    DropDownList56.SelectedValue = sqldatareader_a5.GetString(16).Trim();
                    //P
                    if (sqldatareader_a5.IsDBNull(17)) { TextBox262.Text = ""; } else { TextBox262.Text = sqldatareader_a5.GetString(17); }
                    //A
                    if (sqldatareader_a5.IsDBNull(18)) { TextBox263.Text = ""; } else { TextBox263.Text = sqldatareader_a5.GetString(18); }
                    //G
                    if (sqldatareader_a5.IsDBNull(19)) { TextBox264.Text = ""; } else { TextBox264.Text = sqldatareader_a5.GetString(19); }
                    //哺乳情况20
                    DropDownList52.SelectedValue = sqldatareader_a5.GetString(20).Trim();
                    //哺乳侧别
                    if (sqldatareader_a5.IsDBNull(21)) { TextBox287.Text = ""; } else { TextBox287.Text = sqldatareader_a5.GetString(21); }
                    //持续时间
                    if (sqldatareader_a5.IsDBNull(22)) { TextBox288.Text = ""; } else { TextBox288.Text = sqldatareader_a5.GetString(22); }
                    //子女情况23
                    DropDownList53.SelectedValue = sqldatareader_a5.GetString(23).Trim();
                    //父亲情况
                    DropDownList54.SelectedValue = sqldatareader_a5.GetString(24).Trim();
                    //父亲详情
                    if (sqldatareader_a5.IsDBNull(30)) { TextBox289.Text = ""; } else { TextBox289.Text = sqldatareader_a5.GetString(30); }
                    //母亲情况
                    DropDownList55.SelectedValue = sqldatareader_a5.GetString(25).Trim();
                    //母亲详情
                    if (sqldatareader_a5.IsDBNull(31)) { TextBox290.Text = ""; } else { TextBox290.Text = sqldatareader_a5.GetString(31); }
                    //家族恶性肿瘤史
                    DropDownList75.SelectedValue = sqldatareader_a5.GetString(26).Trim();
                    //家族详情
                    if (sqldatareader_a5.IsDBNull(32)) { TextBox291.Text = ""; } else { TextBox291.Text = sqldatareader_a5.GetString(32); }
                }
                sqlcommand_a5 = null;
                sqlconn_a5.Close();
                sqlconn_a5 = null;

                //a6
                SqlConnection sqlconn_a6 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_a6 = new SqlCommand();
                sqlcommand_a6.Connection = sqlconn_a6;

                sqlconn_a6.Open();//attention
                sqlcommand_a6.CommandText = "select * from a专科查体 where 就诊卡号=@就诊卡号";
                sqlcommand_a6.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_a6 = sqlcommand_a6.ExecuteReader();
                if (sqldatareader_a6.Read())
                {
                    //乳房皮肤
                    DropDownList57.SelectedValue = sqldatareader_a6.GetString(0).Trim();
                    //卫星结节个数
                    if (sqldatareader_a6.IsDBNull(18)) { TextBox314.Text = ""; } else { TextBox314.Text = sqldatareader_a6.GetString(18); }
                    //乳头1
                    DropDownList58.SelectedValue = sqldatareader_a6.GetString(1).Trim();
                    //湿疹范围19
                    string a6_1 = sqldatareader_a6.GetString(19).Trim();
                    if (a6_1.Contains("乳头")) { CheckBox70.Checked = true; }
                    if (a6_1.Contains("乳晕")) { CheckBox71.Checked = true; }
                    if (a6_1.Contains("皮肤")) { CheckBox72.Checked = true; }


                    //乳头溢液_有无2
                    DropDownList59.SelectedValue = sqldatareader_a6.GetString(2).Trim();
                    //乳头溢液_主被动3
                    DropDownList60.SelectedValue = sqldatareader_a6.GetString(3).Trim();
                    //乳头溢液_单多孔4
                    DropDownList61.SelectedValue = sqldatareader_a6.GetString(4).Trim();
                    //乳头溢液_血性5
                    DropDownList62.SelectedValue = sqldatareader_a6.GetString(5).Trim();
                    //乳腺肿块6
                    DropDownList63.SelectedValue = sqldatareader_a6.GetString(6).Trim();
                    //距离乳头7
                    string a6_2 = sqldatareader_a6.GetString(7).Trim();
                    string aa6_1 = a6_2.Split('+')[1];//*右
                    string ab6_1 = a6_2.Split('+')[0];//*左
                    if (a6_2 == "") { TextBox292.Text = ""; } else { TextBox292.Text = aa6_1; }
                    if (a6_2 == "") { TextBox293.Text = ""; } else { TextBox293.Text = ab6_1; }
                    //肿块性质8
                    DropDownList64.SelectedValue = sqldatareader_a6.GetString(8).Trim();
                    //边界情况9
                    DropDownList76.SelectedValue = sqldatareader_a6.GetString(9).Trim();
                    //肿块活动10
                    DropDownList77.SelectedValue = sqldatareader_a6.GetString(10).Trim();
                    //胸壁粘连11
                    DropDownList78.SelectedValue = sqldatareader_a6.GetString(11).Trim();
                    //胸壁固定12
                    DropDownList79.SelectedValue = sqldatareader_a6.GetString(12).Trim();
                    //同侧腋窝13
                    DropDownList80.SelectedValue = sqldatareader_a6.GetString(13).Trim();
                    //同侧腋窝_数量
                    if (sqldatareader_a6.IsDBNull(20)) { TextBox294.Text = ""; } else { TextBox294.Text = sqldatareader_a6.GetString(20); }
                    //同侧腋窝_大小
                    if (sqldatareader_a6.IsDBNull(21)) { TextBox295.Text = ""; } else { TextBox295.Text = sqldatareader_a6.GetString(21); }
                    //同侧腋窝_散在
                    DropDownList81.SelectedValue = sqldatareader_a6.GetString(22).Trim();
                    //同侧腋窝_活动
                    DropDownList82.SelectedValue = sqldatareader_a6.GetString(23).Trim();
                    //同锁骨上14
                    DropDownList83.SelectedValue = sqldatareader_a6.GetString(14).Trim();
                    //同锁骨上_数量
                    if (sqldatareader_a6.IsDBNull(24)) { TextBox296.Text = ""; } else { TextBox296.Text = sqldatareader_a6.GetString(24); }
                    //同锁骨上_大小
                    if (sqldatareader_a6.IsDBNull(25)) { TextBox297.Text = ""; } else { TextBox297.Text = sqldatareader_a6.GetString(25); }
                    //同锁骨上_散在
                    DropDownList84.SelectedValue = sqldatareader_a6.GetString(26).Trim();
                    //同锁骨上_活动
                    DropDownList85.SelectedValue = sqldatareader_a6.GetString(27).Trim();
                    //对侧腋窝15
                    DropDownList86.SelectedValue = sqldatareader_a6.GetString(15).Trim();
                    //对侧腋窝_数量
                    if (sqldatareader_a6.IsDBNull(28)) { TextBox298.Text = ""; } else { TextBox298.Text = sqldatareader_a6.GetString(28); }
                    //对侧腋窝_大小
                    if (sqldatareader_a6.IsDBNull(29)) { TextBox299.Text = ""; } else { TextBox299.Text = sqldatareader_a6.GetString(29); }
                    //对侧腋窝_散在
                    DropDownList87.SelectedValue = sqldatareader_a6.GetString(30).Trim();
                    //对侧腋窝_活动
                    DropDownList88.SelectedValue = sqldatareader_a6.GetString(31).Trim();
                    //对锁骨上16
                    DropDownList89.SelectedValue = sqldatareader_a6.GetString(16).Trim();
                    //对锁骨上_数量
                    if (sqldatareader_a6.IsDBNull(32)) { TextBox300.Text = ""; } else { TextBox300.Text = sqldatareader_a6.GetString(32); }
                    //对锁骨上_大小
                    if (sqldatareader_a6.IsDBNull(33)) { TextBox301.Text = ""; } else { TextBox301.Text = sqldatareader_a6.GetString(33); }
                    //对锁骨上_散在
                    DropDownList90.SelectedValue = sqldatareader_a6.GetString(34).Trim();
                    //对锁骨上_活动
                    DropDownList91.SelectedValue = sqldatareader_a6.GetString(35).Trim();
                }
                sqlcommand_a6 = null;
                sqlconn_a6.Close();
                sqlconn_a6 = null;

                //a7已完
                SqlConnection sqlconn_a7 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_a7 = new SqlCommand();
                sqlcommand_a7.Connection = sqlconn_a7;

                sqlconn_a7.Open();//attention
                sqlcommand_a7.CommandText = "select * from a其他 where 就诊卡号=@就诊卡号";
                sqlcommand_a7.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_a7 = sqlcommand_a7.ExecuteReader();
                if (sqldatareader_a7.Read())
                {
                    //远处转移_有无
                    DropDownList65.SelectedValue = sqldatareader_a7.GetString(0).Trim();
                    //远处转移_情况
                    string a7_1 = sqldatareader_a7.GetString(1).Trim();
                    if (a7_1.Contains("对乳")) { CheckBox62.Checked = true; }
                    if (a7_1.Contains("对腋窝")) { CheckBox63.Checked = true; }
                    if (a7_1.Contains("对锁骨上")) { CheckBox64.Checked = true; }
                    if (a7_1.Contains("肺")) { CheckBox65.Checked = true; }
                    if (a7_1.Contains("肝")) { CheckBox66.Checked = true; }
                    if (a7_1.Contains("骨")) { CheckBox67.Checked = true; }
                    if (a7_1.Contains("脑")) { CheckBox68.Checked = true; }
                    if (a7_1.Contains("其他")) { CheckBox69.Checked = true; }
                    //T
                    if (sqldatareader_a7.IsDBNull(2)) { TextBox265.Text = ""; } else { TextBox265.Text = sqldatareader_a7.GetString(2); }
                    //N
                    if (sqldatareader_a7.IsDBNull(3)) { TextBox266.Text = ""; } else { TextBox266.Text = sqldatareader_a7.GetString(3); }
                    //M
                    if (sqldatareader_a7.IsDBNull(4)) { TextBox267.Text = ""; } else { TextBox267.Text = sqldatareader_a7.GetString(4); }
                    //辅助检查_有无
                    DropDownList66.SelectedValue = sqldatareader_a7.GetString(5).Trim();
                    //B超
                    DropDownList92.SelectedValue = sqldatareader_a7.GetString(6).Trim();
                    //钼靶
                    DropDownList93.SelectedValue = sqldatareader_a7.GetString(7).Trim();
                    //CT
                    DropDownList94.SelectedValue = sqldatareader_a7.GetString(8).Trim();
                    //MRI
                    DropDownList95.SelectedValue = sqldatareader_a7.GetString(9).Trim();
                }
                sqlcommand_a7 = null;
                sqlconn_a7.Close();
                sqlconn_a7 = null;

                //b1已完
                SqlConnection sqlconn_b1 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_b1 = new SqlCommand();
                sqlcommand_b1.Connection = sqlconn_b1;

                sqlconn_b1.Open();//attention
                sqlcommand_b1.CommandText = "select * from b术前检查 where 就诊卡号=@就诊卡号";
                sqlcommand_b1.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_b1 = sqlcommand_b1.ExecuteReader();
                if (sqldatareader_b1.Read())
                {
                    //阴阳性
                    if (sqldatareader_b1.GetString(0) == "") { }
                    else { RadioButtonList1.SelectedValue = sqldatareader_b1.GetString(0).Trim(); }
                    //触诊有无
                    if (sqldatareader_b1.GetString(1) == "") { }
                    else { RadioButtonList2.SelectedValue = sqldatareader_b1.GetString(1).Trim(); }
                    //触诊个数
                    if (sqldatareader_b1.IsDBNull(2)) { TextBox24.Text = ""; } else { TextBox24.Text = sqldatareader_b1.GetString(2); }
                    //触诊最大_cm
                    if (sqldatareader_b1.IsDBNull(3)) { TextBox25.Text = ""; } else { TextBox25.Text = sqldatareader_b1.GetString(3); }
                    //触诊性质
                    if (sqldatareader_b1.GetString(4) == "") { }
                    else { RadioButtonList3.SelectedValue = sqldatareader_b1.GetString(4).Trim(); }
                    //超声有无
                    if (sqldatareader_b1.GetString(5) == "") { }
                    else { RadioButtonList4.SelectedValue = sqldatareader_b1.GetString(5).Trim(); }
                    //超声个数
                    if (sqldatareader_b1.GetString(6) == "") { TextBox26.Text = ""; } else { TextBox26.Text = sqldatareader_b1.GetString(6); }
                    //超声最大_cm
                    if (sqldatareader_b1.GetString(7) == "") { TextBox27.Text = ""; } else { TextBox27.Text = sqldatareader_b1.GetString(7); }
                    //超声性质
                    if (sqldatareader_b1.GetString(8) == "") { }
                    else { RadioButtonList5.SelectedValue = sqldatareader_b1.GetString(8).Trim(); }
                    //钼靶有无
                    if (sqldatareader_b1.GetString(9) == "") { }
                    else { RadioButtonList6.SelectedValue = sqldatareader_b1.GetString(9).Trim(); }
                    //钼靶个数10
                    if (sqldatareader_b1.GetString(10) == "") { TextBox28.Text = ""; } else { TextBox28.Text = sqldatareader_b1.GetString(10); }
                    //钼靶最大_cm11
                    if (sqldatareader_b1.GetString(11) == "") { TextBox29.Text = ""; } else { TextBox29.Text = sqldatareader_b1.GetString(11); }
                    //钼靶性质12
                    if (sqldatareader_b1.GetString(12) == "") { }
                    else { RadioButtonList7.SelectedValue = sqldatareader_b1.GetString(12).Trim(); }
                    //核磁有无
                    if (sqldatareader_b1.GetString(13) == "") { }
                    else { RadioButtonList8.SelectedValue = sqldatareader_b1.GetString(13).Trim(); }
                    //核磁个数
                    if (sqldatareader_b1.GetString(14) == "") { TextBox30.Text = ""; } else { TextBox30.Text = sqldatareader_b1.GetString(14); }
                    //核磁最大_cm
                    if (sqldatareader_b1.GetString(15) == "") { TextBox31.Text = ""; } else { TextBox31.Text = sqldatareader_b1.GetString(15); }
                    //核磁性质
                    if (sqldatareader_b1.GetString(16) == "") { }
                    else { RadioButtonList9.SelectedValue = sqldatareader_b1.GetString(16).Trim(); }
                    //临床腋窝分期
                    if (sqldatareader_b1.GetString(17) == "") { }
                    else
                    {
                        DropDownList12.SelectedValue = sqldatareader_b1.GetString(17).Trim();
                    }
                    //粗针
                    if (sqldatareader_b1.GetString(18) == "") { TextBox32.Text = ""; } else { TextBox32.Text = sqldatareader_b1.GetString(18); }
                    //细针
                    if (sqldatareader_b1.GetString(19) == "") { TextBox33.Text = ""; } else { TextBox33.Text = sqldatareader_b1.GetString(19); }
                    //针号
                    if (sqldatareader_b1.GetString(20) == "") { TextBox34.Text = ""; } else { TextBox34.Text = sqldatareader_b1.GetString(20); }
                    //标本条数
                    if (sqldatareader_b1.GetString(21) == "") { TextBox35.Text = ""; } else { TextBox35.Text = sqldatareader_b1.GetString(21); }
                    //病理
                    if (sqldatareader_b1.GetString(22) == "") { TextBox36.Text = ""; } else { TextBox36.Text = sqldatareader_b1.GetString(22); }
                    //免疫
                    if (sqldatareader_b1.GetString(23) == "") { TextBox37.Text = ""; } else { TextBox37.Text = sqldatareader_b1.GetString(23); }
                }
                sqlcommand_b1 = null;
                sqlconn_b1.Close();
                sqlconn_b1 = null;

                //b2术中实施SLNB
                SqlConnection sqlconn_b2 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_b2 = new SqlCommand();
                sqlcommand_b2.Connection = sqlconn_b2;

                sqlconn_b2.Open();//attention
                sqlcommand_b2.CommandText = "select * from b术中实施SLNB where 就诊卡号=@就诊卡号";
                sqlcommand_b2.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_b2 = sqlcommand_b2.ExecuteReader();
                if (sqldatareader_b2.Read())
                {

                    if (sqldatareader_b2.IsDBNull(1)) { } else { DropDownList13.SelectedValue = sqldatareader_b2.GetString(1).Trim(); }
                    if (sqldatareader_b2.IsDBNull(2)) { TextBox164.Text = ""; } else { TextBox164.Text = sqldatareader_b2.GetString(2); }
                    if (sqldatareader_b2.IsDBNull(3)) { } else { DropDownList14.SelectedValue = sqldatareader_b2.GetString(3).Trim(); }
                    if (sqldatareader_b2.IsDBNull(4)) { TextBox164.Text = ""; } else { DropDownList15.SelectedValue = sqldatareader_b2.GetString(4).Trim(); }
                    if (sqldatareader_b2.GetString(5) == "") { } else { RadioButtonList10.SelectedValue = sqldatareader_b2.GetString(5).Trim(); }
                    if (sqldatareader_b2.IsDBNull(6)) { TextBox38.Text = ""; } else { TextBox38.Text = sqldatareader_b2.GetString(6); }
                    if (sqldatareader_b2.IsDBNull(7)) { TextBox38.Text = ""; } else { TextBox39.Text = sqldatareader_b2.GetString(7); }
                    if (sqldatareader_b2.IsDBNull(8)) { } else { DropDownList16.SelectedValue = sqldatareader_b2.GetString(8).Trim(); }

                    //注射时间
                    string b21 = sqldatareader_b2.GetString(9);
                    string[] b22;
                    b22 = b21.Split(':');
                    string[] b22_1;
                    b22_1 = b22[0].Split(' ');
                    TextBox44.Text = b22_1[0];
                    TextBox45.Text = b22_1[1];
                    TextBox46.Text = b22[1];
                    TextBox47.Text = b22[2];

                    //手术开始时间
                    string b2a1 = sqldatareader_b2.GetString(10);
                    string[] b2a2;
                    b2a2 = b2a1.Split(':');
                    string[] b2a2_1;
                    b2a2_1 = b2a2[0].Split(' ');
                    TextBox40.Text = b2a2_1[0];
                    TextBox41.Text = b2a2_1[1];
                    TextBox42.Text = b2a2[1];
                    TextBox43.Text = b2a2[2];

                    //摘除SLN时间
                    string b2b1 = sqldatareader_b2.GetString(11);
                    string[] b2b2;
                    b2b2 = b2b1.Split(':');
                    string[] b2b2_1;
                    b2b2_1 = b2b2[0].Split(' ');
                    TextBox48.Text = b2b2_1[0];
                    TextBox49.Text = b2b2_1[1];
                    TextBox50.Text = b2b2[1];
                    TextBox51.Text = b2b2[2];

                    if (sqldatareader_b2.IsDBNull(12)) { } else { DropDownList17.SelectedValue = sqldatareader_b2.GetString(12).Trim(); }
                    if (sqldatareader_b2.IsDBNull(13)) { } else { DropDownList18.SelectedValue = sqldatareader_b2.GetString(13).Trim(); }
                    if (sqldatareader_b2.IsDBNull(14)) { } else { DropDownList19.SelectedValue = sqldatareader_b2.GetString(14).Trim(); }
                    if (sqldatareader_b2.IsDBNull(15)) { TextBox52.Text = ""; } else { TextBox52.Text = sqldatareader_b2.GetString(15); }
                    if (sqldatareader_b2.IsDBNull(16)) { TextBox53.Text = ""; } else { TextBox53.Text = sqldatareader_b2.GetString(16); }
                    if (sqldatareader_b2.IsDBNull(17)) { TextBox54.Text = ""; } else { TextBox54.Text = sqldatareader_b2.GetString(17); }
                    if (sqldatareader_b2.IsDBNull(18)) { } else { DropDownList20.SelectedValue = sqldatareader_b2.GetString(18).Trim(); }
                    if (sqldatareader_b2.IsDBNull(19)) { TextBox55.Text = ""; } else { TextBox55.Text = sqldatareader_b2.GetString(19); }
                    if (sqldatareader_b2.IsDBNull(20)) { } else { DropDownList21.SelectedValue = sqldatareader_b2.GetString(20).Trim(); }
                    if (sqldatareader_b2.IsDBNull(21)) { TextBox165.Text = ""; } else { TextBox165.Text = sqldatareader_b2.GetString(21); }
                    if (sqldatareader_b2.IsDBNull(22)) { TextBox56.Text = ""; } else { TextBox56.Text = sqldatareader_b2.GetString(22); }
                }
                sqlcommand_b2 = null;
                sqlconn_b2.Close();
                sqlconn_b2 = null;


                //b3术中行ARM
                SqlConnection sqlconn_b3 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_b3 = new SqlCommand();
                sqlcommand_b3.Connection = sqlconn_b3;

                sqlconn_b3.Open();//attention
                sqlcommand_b3.CommandText = "select * from b术中行ARM where 就诊卡号=@就诊卡号";
                sqlcommand_b3.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_b3 = sqlcommand_b3.ExecuteReader();
                if (sqldatareader_b3.Read())
                {
                    if (sqldatareader_b3.IsDBNull(1)) { } else { DropDownList22.SelectedValue = sqldatareader_b3.GetString(1).Trim(); }
                    if (sqldatareader_b3.IsDBNull(2)) { TextBox166.Text = ""; } else { TextBox166.Text = sqldatareader_b3.GetString(2); }
                    if (sqldatareader_b3.IsDBNull(3)) { } else { DropDownList23.SelectedValue = sqldatareader_b3.GetString(3).Trim(); }
                    if (sqldatareader_b3.IsDBNull(4)) { } else { DropDownList24.SelectedValue = sqldatareader_b3.GetString(4).Trim(); }
                    if (sqldatareader_b3.GetString(5) == "") { } else { RadioButtonList11.SelectedValue = sqldatareader_b3.GetString(5).Trim(); }
                    if (sqldatareader_b3.IsDBNull(6)) { TextBox57.Text = ""; } else { TextBox57.Text = sqldatareader_b3.GetString(6); }
                    if (sqldatareader_b3.IsDBNull(7)) { TextBox58.Text = ""; } else { TextBox58.Text = sqldatareader_b3.GetString(7); }
                    if (sqldatareader_b3.IsDBNull(8)) { } else { DropDownList25.SelectedValue = sqldatareader_b3.GetString(8).Trim(); }

                    //注射时间
                    string b31 = sqldatareader_b3.GetString(9);
                    string[] b32;
                    b32 = b31.Split(':');
                    string[] b32_1;
                    b32_1 = b32[0].Split(' ');
                    TextBox44.Text = b32_1[0];
                    TextBox45.Text = b32_1[1];
                    TextBox46.Text = b32[1];
                    TextBox47.Text = b32[2];

                    //手术开始时间
                    string b3a1 = sqldatareader_b3.GetString(10);
                    string[] b3a2;
                    b3a2 = b3a1.Split(':');
                    string[] b3a2_1;
                    b3a2_1 = b3a2[0].Split(' ');
                    TextBox40.Text = b3a2_1[0];
                    TextBox41.Text = b3a2_1[1];
                    TextBox42.Text = b3a2[1];
                    TextBox43.Text = b3a2[2];

                    //摘除ARM时间
                    string b3b1 = sqldatareader_b3.GetString(11);
                    string[] b3b2;
                    b3b2 = b3b1.Split(':');
                    string[] b3b2_1;
                    b3b2_1 = b3b2[0].Split(' ');
                    TextBox48.Text = b3b2_1[0];
                    TextBox49.Text = b3b2_1[1];
                    TextBox50.Text = b3b2[1];
                    TextBox51.Text = b3b2[2];


                    if (sqldatareader_b3.IsDBNull(12)) { } else { DropDownList26.SelectedValue = sqldatareader_b3.GetString(12).Trim(); }
                    if (sqldatareader_b3.IsDBNull(13)) { } else { DropDownList27.SelectedValue = sqldatareader_b3.GetString(13).Trim(); }
                    if (sqldatareader_b3.IsDBNull(14)) { } else { DropDownList28.SelectedValue = sqldatareader_b3.GetString(14).Trim(); }
                    if (sqldatareader_b3.IsDBNull(15)) { TextBox74.Text = ""; } else { TextBox74.Text = sqldatareader_b3.GetString(15); }
                    if (sqldatareader_b3.IsDBNull(16)) { TextBox75.Text = ""; } else { TextBox75.Text = sqldatareader_b3.GetString(16); }
                }
                sqlcommand_b3 = null;
                sqlconn_b3.Close();
                sqlconn_b3 = null;


                //b4腋窝状况记录
                SqlConnection sqlconn_b4 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_b4 = new SqlCommand();
                sqlcommand_b4.Connection = sqlconn_b4;

                sqlconn_b4.Open();//attention
                sqlcommand_b4.CommandText = "select * from b腋窝状况记录 where 就诊卡号=@就诊卡号";
                sqlcommand_b4.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_b4 = sqlcommand_b4.ExecuteReader();
                if (sqldatareader_b4.Read())
                {
                    string b4_1 = sqldatareader_b4.GetString(1);
                    string b4_2 = sqldatareader_b4.GetString(2);
                    if (b4_1 != "" || b4_2 != "")
                    {
                        RadioButtonList12.SelectedValue = "SNL病理";
                        TextBox71.Text = b4_1; TextBox73.Text = b4_2;
                    }

                    string b4_3 = sqldatareader_b4.GetString(3);
                    string b4_4 = sqldatareader_b4.GetString(4);
                    if (b4_3 != "" || b4_4 != "")
                    {
                        RadioButtonList12.SelectedValue = "ARM病理";
                        TextBox72.Text = b4_3; TextBox76.Text = b4_4;
                    }
                    if (sqldatareader_b4.IsDBNull(5)) { TextBox77.Text = ""; } else { TextBox77.Text = sqldatareader_b4.GetString(5); }
                    if (sqldatareader_b4.IsDBNull(6)) { TextBox78.Text = ""; } else { TextBox78.Text = sqldatareader_b4.GetString(6); }
                    if (sqldatareader_b4.IsDBNull(7)) { TextBox79.Text = ""; } else { TextBox79.Text = sqldatareader_b4.GetString(7); }
                    if (sqldatareader_b4.IsDBNull(8)) { TextBox80.Text = ""; } else { TextBox80.Text = sqldatareader_b4.GetString(8); }
                    if (sqldatareader_b4.IsDBNull(9)) { TextBox81.Text = ""; } else { TextBox81.Text = sqldatareader_b4.GetString(9); }
                    if (sqldatareader_b4.IsDBNull(10)) { TextBox82.Text = ""; } else { TextBox82.Text = sqldatareader_b4.GetString(10); }//患肢(肘上10cm)/ml
                    if (sqldatareader_b4.IsDBNull(11)) { TextBox83.Text = ""; } else { TextBox83.Text = sqldatareader_b4.GetString(11); }
                    if (sqldatareader_b4.IsDBNull(12)) { TextBox84.Text = ""; } else { TextBox84.Text = sqldatareader_b4.GetString(12); }
                    if (sqldatareader_b4.IsDBNull(13)) { TextBox85.Text = ""; } else { TextBox85.Text = sqldatareader_b4.GetString(13); }
                    if (sqldatareader_b4.IsDBNull(14)) { TextBox86.Text = ""; } else { TextBox86.Text = sqldatareader_b4.GetString(14); }
                    if (sqldatareader_b4.IsDBNull(15)) { TextBox87.Text = ""; } else { TextBox87.Text = sqldatareader_b4.GetString(15); }
                    if (sqldatareader_b4.IsDBNull(16)) { TextBox88.Text = ""; } else { TextBox88.Text = sqldatareader_b4.GetString(16); }//对侧肢(肘上10cm)/ml
                    if (sqldatareader_b4.IsDBNull(17)) { TextBox95.Text = ""; } else { TextBox95.Text = sqldatareader_b4.GetString(17); }
                    if (sqldatareader_b4.IsDBNull(18)) { TextBox96.Text = ""; } else { TextBox96.Text = sqldatareader_b4.GetString(18); }
                    if (sqldatareader_b4.IsDBNull(19)) { TextBox97.Text = ""; } else { TextBox97.Text = sqldatareader_b4.GetString(19); }
                    if (sqldatareader_b4.IsDBNull(20)) { TextBox98.Text = ""; } else { TextBox98.Text = sqldatareader_b4.GetString(20); }
                    if (sqldatareader_b4.IsDBNull(21)) { TextBox99.Text = ""; } else { TextBox99.Text = sqldatareader_b4.GetString(21); }
                    if (sqldatareader_b4.IsDBNull(22)) { TextBox100.Text = ""; } else { TextBox100.Text = sqldatareader_b4.GetString(22); }//患肢_肘下
                    if (sqldatareader_b4.IsDBNull(23)) { TextBox101.Text = ""; } else { TextBox101.Text = sqldatareader_b4.GetString(23); }
                    if (sqldatareader_b4.IsDBNull(24)) { TextBox102.Text = ""; } else { TextBox102.Text = sqldatareader_b4.GetString(24); }
                    if (sqldatareader_b4.IsDBNull(25)) { TextBox103.Text = ""; } else { TextBox103.Text = sqldatareader_b4.GetString(25); }
                    if (sqldatareader_b4.IsDBNull(26)) { TextBox104.Text = ""; } else { TextBox104.Text = sqldatareader_b4.GetString(26); }
                    if (sqldatareader_b4.IsDBNull(27)) { TextBox105.Text = ""; } else { TextBox105.Text = sqldatareader_b4.GetString(27); }
                    if (sqldatareader_b4.IsDBNull(28)) { TextBox106.Text = ""; } else { TextBox106.Text = sqldatareader_b4.GetString(28); }//对侧肢_肘下
                    if (sqldatareader_b4.IsDBNull(29)) { TextBox113.Text = ""; } else { TextBox113.Text = sqldatareader_b4.GetString(29); }
                    if (sqldatareader_b4.IsDBNull(30)) { TextBox114.Text = ""; } else { TextBox114.Text = sqldatareader_b4.GetString(30); }
                    if (sqldatareader_b4.IsDBNull(31)) { TextBox115.Text = ""; } else { TextBox115.Text = sqldatareader_b4.GetString(31); }
                    if (sqldatareader_b4.IsDBNull(32)) { TextBox116.Text = ""; } else { TextBox116.Text = sqldatareader_b4.GetString(32); }
                    if (sqldatareader_b4.IsDBNull(33)) { TextBox117.Text = ""; } else { TextBox117.Text = sqldatareader_b4.GetString(33); }
                    if (sqldatareader_b4.IsDBNull(34)) { TextBox118.Text = ""; } else { TextBox118.Text = sqldatareader_b4.GetString(34); }//患侧_手腕
                    if (sqldatareader_b4.IsDBNull(35)) { TextBox119.Text = ""; } else { TextBox119.Text = sqldatareader_b4.GetString(35); }
                    if (sqldatareader_b4.IsDBNull(36)) { TextBox120.Text = ""; } else { TextBox120.Text = sqldatareader_b4.GetString(36); }
                    if (sqldatareader_b4.IsDBNull(37)) { TextBox121.Text = ""; } else { TextBox121.Text = sqldatareader_b4.GetString(37); }
                    if (sqldatareader_b4.IsDBNull(38)) { TextBox122.Text = ""; } else { TextBox122.Text = sqldatareader_b4.GetString(38); }
                    if (sqldatareader_b4.IsDBNull(39)) { TextBox123.Text = ""; } else { TextBox123.Text = sqldatareader_b4.GetString(39); }
                    if (sqldatareader_b4.IsDBNull(40)) { TextBox124.Text = ""; } else { TextBox124.Text = sqldatareader_b4.GetString(40); }//对侧_手腕
                    if (sqldatareader_b4.IsDBNull(41)) { TextBox89.Text = ""; } else { TextBox89.Text = sqldatareader_b4.GetString(41); }
                    if (sqldatareader_b4.IsDBNull(42)) { TextBox90.Text = ""; } else { TextBox90.Text = sqldatareader_b4.GetString(42); }
                    if (sqldatareader_b4.IsDBNull(43)) { TextBox91.Text = ""; } else { TextBox91.Text = sqldatareader_b4.GetString(43); }
                    if (sqldatareader_b4.IsDBNull(44)) { TextBox92.Text = ""; } else { TextBox92.Text = sqldatareader_b4.GetString(44); }
                    if (sqldatareader_b4.IsDBNull(45)) { TextBox93.Text = ""; } else { TextBox93.Text = sqldatareader_b4.GetString(45); }
                    if (sqldatareader_b4.IsDBNull(46)) { TextBox94.Text = ""; } else { TextBox94.Text = sqldatareader_b4.GetString(46); }//肘上_体重
                    if (sqldatareader_b4.IsDBNull(47)) { TextBox107.Text = ""; } else { TextBox107.Text = sqldatareader_b4.GetString(47); }
                    if (sqldatareader_b4.IsDBNull(48)) { TextBox108.Text = ""; } else { TextBox108.Text = sqldatareader_b4.GetString(48); }
                    if (sqldatareader_b4.IsDBNull(49)) { TextBox109.Text = ""; } else { TextBox109.Text = sqldatareader_b4.GetString(49); }
                    if (sqldatareader_b4.IsDBNull(50)) { TextBox110.Text = ""; } else { TextBox110.Text = sqldatareader_b4.GetString(50); }
                    if (sqldatareader_b4.IsDBNull(51)) { TextBox111.Text = ""; } else { TextBox111.Text = sqldatareader_b4.GetString(51); }
                    if (sqldatareader_b4.IsDBNull(52)) { TextBox112.Text = ""; } else { TextBox112.Text = sqldatareader_b4.GetString(52); }//肘下_体重
                    if (sqldatareader_b4.IsDBNull(53)) { TextBox125.Text = ""; } else { TextBox125.Text = sqldatareader_b4.GetString(53); }
                    if (sqldatareader_b4.IsDBNull(54)) { TextBox126.Text = ""; } else { TextBox126.Text = sqldatareader_b4.GetString(54); }
                    if (sqldatareader_b4.IsDBNull(55)) { TextBox127.Text = ""; } else { TextBox127.Text = sqldatareader_b4.GetString(55); }
                    if (sqldatareader_b4.IsDBNull(56)) { TextBox128.Text = ""; } else { TextBox128.Text = sqldatareader_b4.GetString(56); }
                    if (sqldatareader_b4.IsDBNull(57)) { TextBox129.Text = ""; } else { TextBox129.Text = sqldatareader_b4.GetString(57); }
                    if (sqldatareader_b4.IsDBNull(58)) { TextBox130.Text = ""; } else { TextBox130.Text = sqldatareader_b4.GetString(58); }//手腕_体重_

                }
                sqlcommand_b4 = null;
                sqlconn_b4.Close();
                sqlconn_b4 = null;


                //c1术前化疗
                SqlConnection sqlconn_c1 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_c1 = new SqlCommand();
                sqlcommand_c1.Connection = sqlconn_c1;

                sqlconn_c1.Open();//attention
                sqlcommand_c1.CommandText = "select * from c术前化疗 where 就诊卡号=@就诊卡号";
                sqlcommand_c1.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_c1 = sqlcommand_c1.ExecuteReader();
                if (sqldatareader_c1.Read())
                {
                    if (sqldatareader_c1.GetString(0).Trim() == "是")
                    {
                        RadioButton150.Checked = true;
                        RadioButton151.Checked = false;
                    }
                    else
                    {
                        RadioButton150.Checked = false;
                        RadioButton151.Checked = true;
                    }
                    if (sqldatareader_c1.IsDBNull(1)) { TextBox268.Text = ""; } else { TextBox268.Text = sqldatareader_c1.GetString(1); }
                    if (sqldatareader_c1.IsDBNull(2)) { } else { DropDownList67.SelectedValue = sqldatareader_c1.GetString(2).Trim(); }
                    if (sqldatareader_c1.IsDBNull(3)) { TextBox269.Text = ""; } else { TextBox269.Text = sqldatareader_c1.GetString(3); }
                    if (sqldatareader_c1.IsDBNull(4)) { } else { DropDownList68.SelectedValue = sqldatareader_c1.GetString(4).Trim(); }
                    if (sqldatareader_c1.IsDBNull(5)) { TextBox270.Text = ""; } else { TextBox270.Text = sqldatareader_c1.GetString(5); }
                    if (sqldatareader_c1.IsDBNull(6)) { } else { DropDownList69.SelectedValue = sqldatareader_c1.GetString(6).Trim(); }
                    if (sqldatareader_c1.IsDBNull(7)) { TextBox271.Text = ""; } else { TextBox271.Text = sqldatareader_c1.GetString(7); }
                    //日期
                    TextBox272.Text = sqldatareader_c1.GetString(8);

                    if (sqldatareader_c1.IsDBNull(9)) { TextBox273.Text = ""; } else { TextBox273.Text = sqldatareader_c1.GetString(9); }
                    //日期
                    TextBox274.Text = sqldatareader_c1.GetString(10);

                    if (sqldatareader_c1.IsDBNull(11)) { } else { DropDownList70.SelectedValue = sqldatareader_c1.GetString(11).Trim(); }
                    if (sqldatareader_c1.IsDBNull(12)) { TextBox275.Text = ""; } else { TextBox275.Text = sqldatareader_c1.GetString(12); }

                }
                sqlcommand_c1 = null;
                sqlconn_c1.Close();
                sqlconn_c1 = null;

                //c2术后化疗
                SqlConnection sqlconn_c2 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_c2 = new SqlCommand();
                sqlcommand_c2.Connection = sqlconn_c2;

                sqlconn_c2.Open();//attention
                sqlcommand_c2.CommandText = "select * from c术后化疗 where 就诊卡号=@就诊卡号";
                sqlcommand_c2.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_c2 = sqlcommand_c2.ExecuteReader();
                if (sqldatareader_c2.Read())
                {
                    if (sqldatareader_c2.GetString(0).Trim() == "是")
                    {
                        RadioButton152.Checked = true;
                        RadioButton153.Checked = false;
                    }
                    else
                    {
                        RadioButton152.Checked = false;
                        RadioButton153.Checked = true;
                    }
                    if (sqldatareader_c2.IsDBNull(1)) { TextBox276.Text = ""; } else { TextBox276.Text = sqldatareader_c2.GetString(1); }
                    if (sqldatareader_c2.IsDBNull(2)) { } else { DropDownList71.SelectedValue = sqldatareader_c2.GetString(2).Trim(); }
                    if (sqldatareader_c2.IsDBNull(3)) { TextBox277.Text = ""; } else { TextBox277.Text = sqldatareader_c2.GetString(3); }
                    if (sqldatareader_c2.IsDBNull(4)) { } else { DropDownList72.SelectedValue = sqldatareader_c2.GetString(4).Trim(); }
                    if (sqldatareader_c2.IsDBNull(5)) { TextBox278.Text = ""; } else { TextBox278.Text = sqldatareader_c2.GetString(5); }
                    if (sqldatareader_c2.IsDBNull(6)) { } else { DropDownList73.SelectedValue = sqldatareader_c2.GetString(6).Trim(); }
                    if (sqldatareader_c2.IsDBNull(7)) { TextBox279.Text = ""; } else { TextBox279.Text = sqldatareader_c2.GetString(7); }
                    //日期
                    TextBox280.Text = sqldatareader_c2.GetString(8);

                    string c2_2 = sqldatareader_c2.GetString(9).Trim();
                    if (c2_2.Contains("血液系统")) { CheckBox55.Checked = true; }
                    if (c2_2.Contains("胃肠道系统")) { CheckBox56.Checked = true; }
                    if (c2_2.Contains("肝功能")) { CheckBox57.Checked = true; }
                    if (c2_2.Contains("肾功能")) { CheckBox58.Checked = true; }
                    if (c2_2.Contains("心功能")) { CheckBox59.Checked = true; }
                    if (c2_2.Contains("糖代谢异常")) { CheckBox60.Checked = true; }
                    if (c2_2.Contains("脂代谢异常")) { CheckBox61.Checked = true; }
                    if (sqldatareader_c2.IsDBNull(10)) { } else { DropDownList74.SelectedValue = sqldatareader_c2.GetString(10).Trim(); }
                    if (sqldatareader_c2.IsDBNull(11)) { TextBox281.Text = ""; } else { TextBox281.Text = sqldatareader_c2.GetString(11); }
                    if (sqldatareader_c2.IsDBNull(12)) { TextBox282.Text = ""; } else { TextBox282.Text = sqldatareader_c2.GetString(12); }
                }
                sqlcommand_c2 = null;
                sqlconn_c2.Close();
                sqlconn_c2 = null;

                //d1一般
                SqlConnection sqlconn_d1 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_d1 = new SqlCommand();
                sqlcommand_d1.Connection = sqlconn_d1;

                sqlconn_d1.Open();//attention
                sqlcommand_d1.CommandText = "select * from d一般 where 就诊卡号=@就诊卡号";
                sqlcommand_d1.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_d1 = sqlcommand_d1.ExecuteReader();
                if (sqldatareader_d1.Read())
                {
                    if (sqldatareader_d1.IsDBNull(1)) { TextBox131.Text = ""; } else { TextBox131.Text = sqldatareader_d1.GetString(1); }
                    if (sqldatareader_d1.IsDBNull(2)) { TextBox132.Text = ""; } else { TextBox132.Text = sqldatareader_d1.GetString(2); }
                    if (sqldatareader_d1.IsDBNull(3)) { TextBox133.Text = ""; } else { TextBox133.Text = sqldatareader_d1.GetString(3); }
                    if (sqldatareader_d1.GetString(4).Trim() == "1") { CheckBox1.Checked = true; } else { CheckBox1.Checked = false; }
                    if (sqldatareader_d1.IsDBNull(5)) { TextBox134.Text = ""; } else { TextBox134.Text = sqldatareader_d1.GetString(5); }
                    if (sqldatareader_d1.GetString(6).Trim() == "1") { CheckBox2.Checked = true; } else { CheckBox2.Checked = false; }
                    if (sqldatareader_d1.IsDBNull(7)) { TextBox135.Text = ""; } else { TextBox135.Text = sqldatareader_d1.GetString(7); }
                    if (sqldatareader_d1.IsDBNull(8)) { } else { if (sqldatareader_d1.GetString(8).Trim() == "1") { CheckBox3.Checked = true; } else { CheckBox3.Checked = false; } }
                    if (sqldatareader_d1.IsDBNull(9)) { TextBox136.Text = ""; } else { TextBox136.Text = sqldatareader_d1.GetString(9); }
                    if (sqldatareader_d1.GetString(10).Trim() == "1") { CheckBox4.Checked = true; } else { CheckBox4.Checked = false; }
                    if (sqldatareader_d1.IsDBNull(11)) { TextBox137.Text = ""; } else { TextBox137.Text = sqldatareader_d1.GetString(11); }
                    if (sqldatareader_d1.GetString(12).Trim() == "1") { CheckBox5.Checked = true; } else { CheckBox5.Checked = false; }
                    if (sqldatareader_d1.IsDBNull(13)) { TextBox138.Text = ""; } else { TextBox138.Text = sqldatareader_d1.GetString(13); }

                }
                sqlcommand_d1 = null;
                sqlconn_d1.Close();
                sqlconn_d1 = null;

                //d2乳腺复发转移
                SqlConnection sqlconn_d2 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_d2 = new SqlCommand();
                sqlcommand_d2.Connection = sqlconn_d2;

                sqlconn_d2.Open();//attention
                sqlcommand_d2.CommandText = "select * from d乳腺复发转移 where 就诊卡号=@就诊卡号";
                sqlcommand_d2.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_d2 = sqlcommand_d2.ExecuteReader();
                if (sqldatareader_d2.Read())
                {
                    string d2_1 = sqldatareader_d2.GetString(1).Trim();
                    //读数字
                    char[] result = d2_1.ToCharArray();
                    string str = "";
                    for (int i = 0; i < d2_1.Length; i++)
                    {
                        if (result[i] >= '0' && result[i] <= '9')
                        {
                            str += result[i];
                        }
                    }
                    TextBox139.Text = str;
                    //读单位
                    if (sqldatareader_d2.GetString(1) == "") { } else { DropDownList29.SelectedValue = d2_1.Substring(d2_1.Length - 1, 1); }
                    if (sqldatareader_d2.GetString(2) == "") { } else { RadioButtonList17.SelectedValue = sqldatareader_d2.GetString(2).Trim(); }
                    if (sqldatareader_d2.IsDBNull(3)) { TextBox140.Text = ""; } else { TextBox140.Text = sqldatareader_d2.GetString(3); }
                    if (sqldatareader_d2.GetString(4) == "") { } else { RadioButtonList18.SelectedValue = sqldatareader_d2.GetString(4).Trim(); }
                    if (sqldatareader_d2.IsDBNull(5)) { TextBox145.Text = ""; } else { TextBox145.Text = sqldatareader_d2.GetString(5); }
                    if (sqldatareader_d2.GetString(6) == "") { } else { RadioButtonList15.SelectedValue = sqldatareader_d2.GetString(6).Trim(); }
                    if (sqldatareader_d2.IsDBNull(7)) { TextBox142.Text = ""; } else { TextBox142.Text = sqldatareader_d2.GetString(7); }
                    if (sqldatareader_d2.GetString(8) == "") { } else { RadioButtonList16.SelectedValue = sqldatareader_d2.GetString(8).Trim(); }
                    if (sqldatareader_d2.IsDBNull(9)) { TextBox144.Text = ""; } else { TextBox144.Text = sqldatareader_d2.GetString(9); }
                    if (sqldatareader_d2.GetString(10) == "") { } else { RadioButtonList13.SelectedValue = sqldatareader_d2.GetString(10).Trim(); }
                    if (sqldatareader_d2.IsDBNull(11)) { TextBox141.Text = ""; } else { TextBox141.Text = sqldatareader_d2.GetString(11); }
                    if (sqldatareader_d2.GetString(12).Trim() == "是") { CheckBox6.Checked = true; } else { CheckBox6.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(13)) { TextBox143.Text = ""; } else { TextBox143.Text = sqldatareader_d2.GetString(13); }
                    if (sqldatareader_d2.GetString(14).Trim() == "是") { CheckBox7.Checked = true; } else { CheckBox7.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(15)) { TextBox146.Text = ""; } else { TextBox146.Text = sqldatareader_d2.GetString(15); }//胸片
                    if (sqldatareader_d2.GetString(16) == "") { } else { RadioButtonList14.SelectedValue = sqldatareader_d2.GetString(16).Trim(); }
                    if (sqldatareader_d2.IsDBNull(17)) { TextBox147.Text = ""; } else { TextBox147.Text = sqldatareader_d2.GetString(17); }
                    if (sqldatareader_d2.GetString(18).Trim() == "是") { CheckBox8.Checked = true; } else { CheckBox8.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(19)) { TextBox148.Text = ""; } else { TextBox148.Text = sqldatareader_d2.GetString(19); }
                    if (sqldatareader_d2.GetString(20).Trim() == "是") { CheckBox9.Checked = true; } else { CheckBox9.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(21)) { TextBox149.Text = ""; } else { TextBox149.Text = sqldatareader_d2.GetString(21); }//BUS
                    if (sqldatareader_d2.GetString(22) == "") { } else { RadioButtonList19.SelectedValue = sqldatareader_d2.GetString(22).Trim(); }
                    if (sqldatareader_d2.IsDBNull(23)) { TextBox150.Text = ""; } else { TextBox150.Text = sqldatareader_d2.GetString(23); }
                    if (sqldatareader_d2.GetString(24).Trim() == "是") { CheckBox10.Checked = true; } else { CheckBox10.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(25)) { TextBox151.Text = ""; } else { TextBox151.Text = sqldatareader_d2.GetString(25); }
                    if (sqldatareader_d2.GetString(26).Trim() == "是") { CheckBox11.Checked = true; } else { CheckBox11.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(27)) { TextBox152.Text = ""; } else { TextBox152.Text = sqldatareader_d2.GetString(27); }//肿瘤标志物
                    if (sqldatareader_d2.GetString(28) == "") { } else { RadioButtonList20.SelectedValue = sqldatareader_d2.GetString(28).Trim(); }
                    if (sqldatareader_d2.IsDBNull(29)) { TextBox153.Text = ""; } else { TextBox153.Text = sqldatareader_d2.GetString(29); }
                    if (sqldatareader_d2.GetString(30).Trim() == "是") { CheckBox12.Checked = true; } else { CheckBox12.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(31)) { TextBox154.Text = ""; } else { TextBox154.Text = sqldatareader_d2.GetString(31); }
                    if (sqldatareader_d2.GetString(32).Trim() == "是") { CheckBox13.Checked = true; } else { CheckBox13.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(33)) { TextBox155.Text = ""; } else { TextBox155.Text = sqldatareader_d2.GetString(33); }//CT
                    if (sqldatareader_d2.GetString(34) == "") { } else { RadioButtonList21.SelectedValue = sqldatareader_d2.GetString(34).Trim(); }
                    if (sqldatareader_d2.IsDBNull(35)) { TextBox156.Text = ""; } else { TextBox156.Text = sqldatareader_d2.GetString(35); }
                    if (sqldatareader_d2.GetString(36).Trim() == "是") { CheckBox14.Checked = true; } else { CheckBox14.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(37)) { TextBox157.Text = ""; } else { TextBox157.Text = sqldatareader_d2.GetString(37); }
                    if (sqldatareader_d2.GetString(38).Trim() == "是") { CheckBox15.Checked = true; } else { CheckBox15.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(39)) { TextBox158.Text = ""; } else { TextBox158.Text = sqldatareader_d2.GetString(39); }//ECT
                    if (sqldatareader_d2.GetString(40) == "") { } else { RadioButtonList22.SelectedValue = sqldatareader_d2.GetString(40).Trim(); }
                    if (sqldatareader_d2.IsDBNull(41)) { TextBox159.Text = ""; } else { TextBox159.Text = sqldatareader_d2.GetString(41); }
                    if (sqldatareader_d2.GetString(42).Trim() == "是") { CheckBox16.Checked = true; } else { CheckBox16.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(43)) { TextBox160.Text = ""; } else { TextBox160.Text = sqldatareader_d2.GetString(43); }
                    if (sqldatareader_d2.GetString(44).Trim() == "是") { CheckBox17.Checked = true; } else { CheckBox17.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(45)) { TextBox161.Text = ""; } else { TextBox161.Text = sqldatareader_d2.GetString(45); }//PET-CT
                    if (sqldatareader_d2.GetString(46) == "") { } else { RadioButtonList23.SelectedValue = sqldatareader_d2.GetString(46).Trim(); }
                    if (sqldatareader_d2.IsDBNull(47)) { } else { DropDownList30.SelectedValue = sqldatareader_d2.GetString(47).Trim(); }
                    if (sqldatareader_d2.IsDBNull(48)) { TextBox162.Text = ""; } else { TextBox162.Text = sqldatareader_d2.GetString(48); }
                    if (sqldatareader_d2.IsDBNull(49)) { TextBox163.Text = ""; } else { TextBox163.Text = sqldatareader_d2.GetString(49); }

                }
                sqlcommand_d2 = null;
                sqlconn_d2.Close();
                sqlconn_d2 = null;

                //d3
                SqlConnection sqlconn_d3 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_d3 = new SqlCommand();
                sqlcommand_d3.Connection = sqlconn_d3;

                sqlconn_d3.Open();//attention
                sqlcommand_d3.CommandText = "select * from d诊疗异常反应 where 就诊卡号=@就诊卡号";
                sqlcommand_d3.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_d3 = sqlcommand_d3.ExecuteReader();
                if (sqldatareader_d3.Read())
                {
                    //UCG_正常
                    if (sqldatareader_d3.GetString(0).Trim() == "正常") { RadioButton26.Checked = true; }
                    //UCG_异常
                    if (sqldatareader_d3.GetString(1).Trim() == "异常") { RadioButton27.Checked = true; }
                    //UCG_异常内容
                    if (sqldatareader_d3.IsDBNull(2)) { TextBox203.Text = ""; } else { TextBox203.Text = sqldatareader_d3.GetString(2); }
                    //UCG_结论
                    if (sqldatareader_d3.IsDBNull(3)) { TextBox204.Text = ""; } else { TextBox204.Text = sqldatareader_d3.GetString(3); }
                    //UCG_建议
                    if (sqldatareader_d3.IsDBNull(4)) { TextBox205.Text = ""; } else { TextBox205.Text = sqldatareader_d3.GetString(4); }
                    //肝肾功_正常
                    if (sqldatareader_d3.GetString(5).Trim() == "正常") { RadioButton28.Checked = true; }
                    //肝肾功_异常
                    if (sqldatareader_d3.GetString(6).Trim() == "异常") { RadioButton29.Checked = true; }
                    //肝肾功_异常内容
                    if (sqldatareader_d3.IsDBNull(7)) { TextBox206.Text = ""; } else { TextBox206.Text = sqldatareader_d3.GetString(7); }
                    //肝肾功_结论
                    if (sqldatareader_d3.IsDBNull(8)) { TextBox207.Text = ""; } else { TextBox207.Text = sqldatareader_d3.GetString(8); }
                    //肝肾功_建议
                    if (sqldatareader_d3.IsDBNull(9)) { TextBox208.Text = ""; } else { TextBox208.Text = sqldatareader_d3.GetString(9); }
                    //血糖_正常
                    if (sqldatareader_d3.GetString(10).Trim() == "正常") { RadioButton30.Checked = true; }
                    //血糖_异常
                    if (sqldatareader_d3.GetString(11).Trim() == "异常") { RadioButton31.Checked = true; }
                    //血糖_异常内容
                    if (sqldatareader_d3.IsDBNull(12)) { TextBox209.Text = ""; } else { TextBox209.Text = sqldatareader_d3.GetString(12); }
                    //血糖_结论
                    if (sqldatareader_d3.IsDBNull(13)) { TextBox210.Text = ""; } else { TextBox210.Text = sqldatareader_d3.GetString(13); }
                    //血糖_建议
                    if (sqldatareader_d3.IsDBNull(14)) { TextBox211.Text = ""; } else { TextBox211.Text = sqldatareader_d3.GetString(14); }
                    //血脂_正常
                    if (sqldatareader_d3.GetString(15).Trim() == "正常") { RadioButton32.Checked = true; }
                    //血脂_异常
                    if (sqldatareader_d3.GetString(16).Trim() == "异常") { RadioButton33.Checked = true; }
                    //血脂_异常内容
                    if (sqldatareader_d3.IsDBNull(17)) { TextBox212.Text = ""; } else { TextBox212.Text = sqldatareader_d3.GetString(17); }
                    //血脂_结论
                    if (sqldatareader_d3.IsDBNull(18)) { TextBox213.Text = ""; } else { TextBox213.Text = sqldatareader_d3.GetString(18); }
                    //血脂_建议
                    if (sqldatareader_d3.IsDBNull(19)) { TextBox214.Text = ""; } else { TextBox214.Text = sqldatareader_d3.GetString(19); }
                    //骨密度_正常
                    if (sqldatareader_d3.GetString(20).Trim() == "正常") { RadioButton34.Checked = true; }
                    //骨密度_异常
                    if (sqldatareader_d3.GetString(21).Trim() == "异常") { RadioButton35.Checked = true; }
                    //骨密度_异常内容
                    if (sqldatareader_d3.IsDBNull(22)) { TextBox215.Text = ""; } else { TextBox215.Text = sqldatareader_d3.GetString(22); }
                    //骨密度_结论
                    if (sqldatareader_d3.IsDBNull(23)) { TextBox216.Text = ""; } else { TextBox216.Text = sqldatareader_d3.GetString(23); }
                    //骨密度_建议
                    if (sqldatareader_d3.IsDBNull(24)) { TextBox217.Text = ""; } else { TextBox217.Text = sqldatareader_d3.GetString(24); }
                    //激素水平_未绝经
                    if (sqldatareader_d3.GetString(25).Trim() == "未绝经") { RadioButton36.Checked = true; }
                    //激素水平_绝经
                    if (sqldatareader_d3.GetString(26).Trim() == "绝经") { RadioButton37.Checked = true; }
                    //激素水平_更换内分泌药
                    if (sqldatareader_d3.IsDBNull(27)) { TextBox218.Text = ""; } else { TextBox218.Text = sqldatareader_d3.GetString(27); }
                }
                sqlcommand_d3 = null;
                sqlconn_d3.Close();
                sqlconn_d3 = null;

                //e1
                SqlConnection sqlconn_e1 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_e1 = new SqlCommand();
                sqlcommand_e1.Connection = sqlconn_e1;

                sqlconn_e1.Open();//attention
                sqlcommand_e1.CommandText = "select * from e根治信息 where 就诊卡号=@就诊卡号";
                sqlcommand_e1.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_e1 = sqlcommand_e1.ExecuteReader();
                if (sqldatareader_e1.Read())
                {
                    //手术方式
                    if (sqldatareader_e1.GetString(0) == "") { } else { RadioButtonList24.SelectedValue = sqldatareader_e1.GetString(0).Trim(); }
                    //术前诊断
                    if (sqldatareader_e1.GetString(1) == "") { } else { RadioButtonList25.SelectedValue = sqldatareader_e1.GetString(1).Trim(); }
                    //切口设计
                    if (sqldatareader_e1.GetString(2) == "") { } else { RadioButtonList26.SelectedValue = sqldatareader_e1.GetString(2).Trim(); }
                    //切口设计_cm"
                    if (sqldatareader_e1.IsDBNull(3)) { TextBox219.Text = ""; } else { TextBox219.Text = sqldatareader_e1.GetString(3); }
                    //皮下打水
                    if (sqldatareader_e1.GetString(4) == "") { } else { RadioButtonList27.SelectedValue = sqldatareader_e1.GetString(4).Trim(); }
                    //分离皮瓣范围_上至
                    if (sqldatareader_e1.IsDBNull(5)) { TextBox220.Text = ""; } else { TextBox220.Text = sqldatareader_e1.GetString(5); }
                    //分离皮瓣范围_下至
                    if (sqldatareader_e1.IsDBNull(6)) { TextBox221.Text = ""; } else { TextBox221.Text = sqldatareader_e1.GetString(6); }
                    //分离皮瓣范围_内至
                    if (sqldatareader_e1.IsDBNull(7)) { TextBox222.Text = ""; } else { TextBox222.Text = sqldatareader_e1.GetString(7); }
                    //分离皮瓣范围_外至
                    if (sqldatareader_e1.IsDBNull(8)) { TextBox223.Text = ""; } else { TextBox223.Text = sqldatareader_e1.GetString(8); }
                    //厚度
                    if (sqldatareader_e1.GetString(9) == "") { } else { RadioButtonList28.SelectedValue = sqldatareader_e1.GetString(9).Trim(); }
                    //全乳切除
                    if (sqldatareader_e1.GetString(10) == "") { } else { RadioButtonList29.SelectedValue = sqldatareader_e1.GetString(10).Trim(); }
                    //胸肌受累
                    if (sqldatareader_e1.GetString(11) == "") { } else { RadioButtonList30.SelectedValue = sqldatareader_e1.GetString(11).Trim(); }
                    //胸大肌部分切
                    if (sqldatareader_e1.GetString(12) == "") { } else { RadioButtonList31.SelectedValue = sqldatareader_e1.GetString(12).Trim(); }

                }
                sqlcommand_e1 = null;
                sqlconn_e1.Close();
                sqlconn_e1 = null;

                //e2
                SqlConnection sqlconn_e2 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_e2 = new SqlCommand();
                sqlcommand_e2.Connection = sqlconn_e2;

                sqlconn_e2.Open();//attention
                sqlcommand_e2.CommandText = "select * from e根治术相关 where 就诊卡号=@就诊卡号";
                sqlcommand_e2.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_e2 = sqlcommand_e2.ExecuteReader();
                if (sqldatareader_e2.Read())
                {
                    //保留胸大小肌_胸肌间脂肪
                    if (sqldatareader_e2.GetString(0) == "") { } else { RadioButtonList45.SelectedValue = sqldatareader_e2.GetString(0).Trim(); }
                    //保留胸大小肌_胸肌间脂肪_切除
                    if (sqldatareader_e2.GetString(1) == "") { } else { RadioButtonList46.SelectedValue = sqldatareader_e2.GetString(1).Trim(); }
                    //保留胸大小肌_可见肿大淋巴结
                    if (sqldatareader_e2.GetString(2) == "") { } else { RadioButton22.Text = sqldatareader_e2.GetString(2).Trim(); }
                    //保留胸大小肌_可见肿大淋巴结数量
                    if (sqldatareader_e2.IsDBNull(3)) { TextBox232.Text = ""; } else { TextBox232.Text = sqldatareader_e2.GetString(3); }
                    //保留胸大小肌_胸前神经
                    if (sqldatareader_e2.GetString(4) == "") { } else { RadioButtonList47.SelectedValue = sqldatareader_e2.GetString(4).Trim(); }
                    //保留胸大小肌_解剖过程
                    if (sqldatareader_e2.IsDBNull(5)) { TextBox233.Text = ""; } else { TextBox233.Text = sqldatareader_e2.GetString(5); }
                    //保留胸大肌_胸肌间脂肪
                    if (sqldatareader_e2.GetString(6) == "") { } else { RadioButtonList48.SelectedValue = sqldatareader_e2.GetString(6).Trim(); }
                    //保留胸大肌_胸肌间脂肪_切除
                    if (sqldatareader_e2.GetString(7) == "") { } else { RadioButtonList49.SelectedValue = sqldatareader_e2.GetString(7).Trim(); }
                    //保留胸大肌_可见肿大淋巴结
                    if (sqldatareader_e2.GetString(8) == "") { } else { RadioButton24.Text = sqldatareader_e2.GetString(8).Trim(); }
                    //保留胸大肌_可见肿大淋巴结数量
                    if (sqldatareader_e2.IsDBNull(9)) { TextBox234.Text = ""; } else { TextBox234.Text = sqldatareader_e2.GetString(9); }
                    //保留胸大肌_胸前神经
                    if (sqldatareader_e2.GetString(10) == "") { } else { RadioButtonList50.SelectedValue = sqldatareader_e2.GetString(10).Trim(); }
                    //保留胸大肌_切断胸小肌喙突端
                    //string e2_1 = sqldatareader_e2.GetString(11).Trim();
                    //if (e2_1.Contains("切断胸小肌喙突端")) { CheckBox30.Checked = true; }
                    if (sqldatareader_e2.GetString(11).Trim() == "1") { CheckBox30.Checked = true; } else { CheckBox30.Checked = false; }
                    //保留胸大肌_解剖过程
                    if (sqldatareader_e2.IsDBNull(12)) { TextBox235.Text = ""; } else { TextBox235.Text = sqldatareader_e2.GetString(12); }
                    //胸大肌保留
                    if (sqldatareader_e2.IsDBNull(13)) { TextBox236.Text = ""; } else { TextBox236.Text = sqldatareader_e2.GetString(13); }
                    //胸大肌宽
                    if (sqldatareader_e2.IsDBNull(14)) { TextBox237.Text = ""; } else { TextBox237.Text = sqldatareader_e2.GetString(14); }
                    //根治术_切断胸大肌肱骨端
                    //if (sqldatareader_e2.IsDBNull(15)) { CheckBox31.Text = ""; } else { CheckBox31.Text = sqldatareader_e2.GetString(15); }
                    if (sqldatareader_e2.GetString(15).Trim() == "1") { CheckBox31.Checked = true; } else { CheckBox31.Checked = false; }
                    //根治术_切断胸小肌喙突端
                    //if (sqldatareader_e2.IsDBNull(16)) { CheckBox32.Text = ""; } else { CheckBox32.Text = sqldatareader_e2.GetString(16); }
                    if (sqldatareader_e2.GetString(16).Trim() == "1") { CheckBox32.Checked = true; } else { CheckBox32.Checked = false; }
                    //根治术_解剖过程
                    if (sqldatareader_e2.IsDBNull(17)) { TextBox238.Text = ""; } else { TextBox238.Text = sqldatareader_e2.GetString(17); }


                }
                sqlcommand_e2 = null;
                sqlconn_e2.Close();
                sqlconn_e2 = null;

                //e3
                SqlConnection sqlconn_e3 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_e3 = new SqlCommand();
                sqlcommand_e3.Connection = sqlconn_e3;

                sqlconn_e3.Open();//attention
                sqlcommand_e3.CommandText = "select * from e手术相关 where 就诊卡号=@就诊卡号";
                sqlcommand_e3.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_e3 = sqlcommand_e3.ExecuteReader();
                if (sqldatareader_e3.Read())
                {
                    //腋脉管带周围肿大淋巴结
                    if (sqldatareader_e3.GetString(0) == "") { } else { RadioButtonList32.SelectedValue = sqldatareader_e3.GetString(0).Trim(); }
                    //肿大淋巴结个数
                    if (sqldatareader_e3.IsDBNull(1)) { TextBox224.Text = ""; } else { TextBox224.Text = sqldatareader_e3.GetString(1); }
                    //肿大淋巴结大小
                    if (sqldatareader_e3.IsDBNull(2)) { TextBox225.Text = ""; } else { TextBox225.Text = sqldatareader_e3.GetString(2); }
                    //肿大淋巴结硬度
                    if (sqldatareader_e3.GetString(3) == "") { } else { RadioButtonList33.SelectedValue = sqldatareader_e3.GetString(3).Trim(); }
                    //和腋静脉管或鞘膜粘粒
                    if (sqldatareader_e3.GetString(4) == "") { } else { RadioButtonList34.SelectedValue = sqldatareader_e3.GetString(4).Trim(); }
                    //切除
                    if (sqldatareader_e3.GetString(5) == "") { } else { RadioButtonList35.SelectedValue = sqldatareader_e3.GetString(5).Trim(); }
                    //缝合切断
                    if (sqldatareader_e3.GetString(6) == "") { } else { RadioButtonList36.SelectedValue = sqldatareader_e3.GetString(6).Trim(); }
                    //腋尖肿大淋巴结个数
                    if (sqldatareader_e3.IsDBNull(7)) { TextBox226.Text = ""; } else { TextBox226.Text = sqldatareader_e3.GetString(7); }
                    //腋尖肿大淋巴结大小
                    if (sqldatareader_e3.IsDBNull(8)) { TextBox227.Text = ""; } else { TextBox227.Text = sqldatareader_e3.GetString(8); }
                    //腋尖肿大淋巴结硬度
                    if (sqldatareader_e3.GetString(9) == "") { } else { RadioButtonList37.SelectedValue = sqldatareader_e3.GetString(9).Trim(); }
                    //和锁下静脉鞘粘粒
                    if (sqldatareader_e3.GetString(10) == "") { } else { RadioButtonList38.SelectedValue = sqldatareader_e3.GetString(10).Trim(); }
                    //胸背神经
                    if (sqldatareader_e3.GetString(11) == "") { } else { RadioButtonList39.SelectedValue = sqldatareader_e3.GetString(11).Trim(); }
                    //胸长神经
                    if (sqldatareader_e3.GetString(12) == "") { } else { RadioButtonList40.SelectedValue = sqldatareader_e3.GetString(12).Trim(); }
                    //肩胛下脉管
                    if (sqldatareader_e3.GetString(13) == "") { } else { RadioButtonList41.SelectedValue = sqldatareader_e3.GetString(13).Trim(); }
                    //负压引流
                    if (sqldatareader_e3.IsDBNull(14)) { TextBox228.Text = ""; } else { TextBox228.Text = sqldatareader_e3.GetString(14); }
                    //缝合皮肤张力
                    if (sqldatareader_e3.GetString(15) == "") { } else { RadioButtonList42.SelectedValue = sqldatareader_e3.GetString(15).Trim(); }
                    //缝合皮肤植皮
                    if (sqldatareader_e3.GetString(16) == "") { } else { RadioButtonList43.SelectedValue = sqldatareader_e3.GetString(16).Trim(); }
                    //缝合皮肤面积
                    if (sqldatareader_e3.IsDBNull(17)) { TextBox229.Text = ""; } else { TextBox229.Text = sqldatareader_e3.GetString(17); }
                    //出血量
                    if (sqldatareader_e3.GetString(18) == "") { } else { RadioButtonList44.SelectedValue = sqldatareader_e3.GetString(18).Trim(); }
                    //手术时间_小时
                    if (sqldatareader_e3.IsDBNull(19)) { TextBox230.Text = ""; } else { TextBox230.Text = sqldatareader_e3.GetString(19); }
                    //手术时间_分
                    if (sqldatareader_e3.IsDBNull(20)) { TextBox231.Text = ""; } else { TextBox231.Text = sqldatareader_e3.GetString(20); }

                }
                sqlcommand_e3 = null;
                sqlconn_e3.Close();
                sqlconn_e3 = null;

                //f1
                SqlConnection sqlconn_f1 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_f1 = new SqlCommand();
                sqlcommand_f1.Connection = sqlconn_f1;

                sqlconn_f1.Open();//attention
                sqlcommand_f1.CommandText = "select * from f术前信息1 where 就诊卡号=@就诊卡号";
                sqlcommand_f1.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_f1 = sqlcommand_f1.ExecuteReader();
                if (sqldatareader_f1.Read())
                {
                    //肿瘤部位_侧
                    if (sqldatareader_f1.IsDBNull(0)) { TextBox167.Text = ""; } else { TextBox167.Text = sqldatareader_f1.GetString(0); }
                    //肿瘤部位_点
                    if (sqldatareader_f1.IsDBNull(1)) { TextBox168.Text = ""; } else { TextBox168.Text = sqldatareader_f1.GetString(1); }
                    //肿瘤大小_横
                    if (sqldatareader_f1.IsDBNull(2)) { TextBox169.Text = ""; } else { TextBox169.Text = sqldatareader_f1.GetString(2); }
                    //肿瘤大小_纵
                    if (sqldatareader_f1.IsDBNull(3)) { TextBox170.Text = ""; } else { TextBox170.Text = sqldatareader_f1.GetString(3); }
                    //肿瘤与乳头距离
                    if (sqldatareader_f1.IsDBNull(4)) { TextBox171.Text = ""; } else { TextBox171.Text = sqldatareader_f1.GetString(4); }
                    //胸乳距
                    if (sqldatareader_f1.IsDBNull(5)) { TextBox172.Text = ""; } else { TextBox172.Text = sqldatareader_f1.GetString(5); }
                    //乳胸距
                    if (sqldatareader_f1.IsDBNull(6)) { TextBox173.Text = ""; } else { TextBox173.Text = sqldatareader_f1.GetString(6); }
                    //锁胸距
                    if (sqldatareader_f1.IsDBNull(7)) { TextBox174.Text = ""; } else { TextBox174.Text = sqldatareader_f1.GetString(7); }
                    //胸骨正中距
                    if (sqldatareader_f1.IsDBNull(8)) { TextBox175.Text = ""; } else { TextBox175.Text = sqldatareader_f1.GetString(8); }
                    //乳头间距
                    if (sqldatareader_f1.IsDBNull(9)) { TextBox176.Text = ""; } else { TextBox176.Text = sqldatareader_f1.GetString(9); }
                    //乳房基底横径
                    if (sqldatareader_f1.IsDBNull(10)) { TextBox177.Text = ""; } else { TextBox177.Text = sqldatareader_f1.GetString(10); }
                    //乳房内侧半径
                    if (sqldatareader_f1.IsDBNull(11)) { TextBox178.Text = ""; } else { TextBox178.Text = sqldatareader_f1.GetString(11); }
                    //乳房外侧半径
                    if (sqldatareader_f1.IsDBNull(12)) { TextBox179.Text = ""; } else { TextBox179.Text = sqldatareader_f1.GetString(12); }
                    //乳房下侧半径
                    if (sqldatareader_f1.IsDBNull(13)) { TextBox180.Text = ""; } else { TextBox180.Text = sqldatareader_f1.GetString(13); }
                    //乳头至下皱襞体表距离
                    if (sqldatareader_f1.IsDBNull(14)) { TextBox181.Text = ""; } else { TextBox181.Text = sqldatareader_f1.GetString(14); }
                    //乳晕直径
                    if (sqldatareader_f1.IsDBNull(15)) { TextBox182.Text = ""; } else { TextBox182.Text = sqldatareader_f1.GetString(15); }
                    //乳头直径
                    if (sqldatareader_f1.IsDBNull(16)) { TextBox183.Text = ""; } else { TextBox183.Text = sqldatareader_f1.GetString(16); }
                    //乳房高度
                    if (sqldatareader_f1.IsDBNull(17)) { TextBox184.Text = ""; } else { TextBox184.Text = sqldatareader_f1.GetString(17); }
                    //胸围Ⅰ
                    if (sqldatareader_f1.IsDBNull(18)) { TextBox185.Text = ""; } else { TextBox185.Text = sqldatareader_f1.GetString(18); }
                    //胸围Ⅱ
                    if (sqldatareader_f1.IsDBNull(19)) { TextBox186.Text = ""; } else { TextBox186.Text = sqldatareader_f1.GetString(19); }
                    //胸围Ⅲ
                    if (sqldatareader_f1.IsDBNull(20)) { TextBox187.Text = ""; } else { TextBox187.Text = sqldatareader_f1.GetString(20); }
                    //乳房半径
                    if (sqldatareader_f1.IsDBNull(21)) { TextBox188.Text = ""; } else { TextBox188.Text = sqldatareader_f1.GetString(21); }
                    //乳房体积计算1
                    if (sqldatareader_f1.IsDBNull(22)) { TextBox189.Text = ""; } else { TextBox189.Text = sqldatareader_f1.GetString(22); }
                    //超重体重
                    if (sqldatareader_f1.IsDBNull(23)) { TextBox190.Text = ""; } else { TextBox190.Text = sqldatareader_f1.GetString(23); }
                    //乳房体积计算2
                    if (sqldatareader_f1.IsDBNull(24)) { TextBox191.Text = ""; } else { TextBox191.Text = sqldatareader_f1.GetString(24); }

                }
                sqlcommand_f1 = null;
                sqlconn_f1.Close();
                sqlconn_f1 = null;

                //f2
                SqlConnection sqlconn_f2 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_f2 = new SqlCommand();
                sqlcommand_f2.Connection = sqlconn_f2;

                sqlconn_f2.Open();//attention
                sqlcommand_f2.CommandText = "select * from f术前信息2 where 就诊卡号=@就诊卡号";
                sqlcommand_f2.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_f2 = sqlcommand_f2.ExecuteReader();
                if (sqldatareader_f2.Read())
                {
                    f2Tb1.Text = sqldatareader_f2.GetString(0);
                    f2Tb2.Text = sqldatareader_f2.GetString(1);
                    f2Tb3.Text = sqldatareader_f2.GetString(2);

                }
                sqlcommand_f2 = null;
                sqlconn_f2.Close();
                sqlconn_f2 = null;


                //f3
                SqlConnection sqlconn_f3 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_f3 = new SqlCommand();
                sqlcommand_f3.Connection = sqlconn_f3;

                sqlconn_f3.Open();//attention
                sqlcommand_f3.CommandText = "select * from f手术信息 where 就诊卡号=@就诊卡号";
                sqlcommand_f3.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_f3 = sqlcommand_f3.ExecuteReader();
                if (sqldatareader_f3.Read())
                {
                    //@切口类型
                    string f3_1 = sqldatareader_f3.GetString(0).Trim();
                    if (f3_1.Contains("放射型")) { RadioButton1.Checked = true; }
                    if (f3_1.Contains("弧形（垂直于放射型）")) { RadioButton2.Checked = true; }
                    if (f3_1.Contains("其他")) { RadioButton3.Checked = true; }
                    //切口类型_其他
                    if (sqldatareader_f3.IsDBNull(1)) { TextBox310.Text = ""; } else { TextBox310.Text = sqldatareader_f3.GetString(1); }
                    //横径
                    if (sqldatareader_f3.IsDBNull(2)) { TextBox192.Text = ""; } else { TextBox192.Text = sqldatareader_f3.GetString(2); }
                    //纵径
                    if (sqldatareader_f3.IsDBNull(3)) { TextBox193.Text = ""; } else { TextBox193.Text = sqldatareader_f3.GetString(3); }
                    //体积_排水法
                    if (sqldatareader_f3.IsDBNull(4)) { TextBox194.Text = ""; } else { TextBox194.Text = sqldatareader_f3.GetString(4); }
                    //切缘病理阴阳性
                    string f3_2 = sqldatareader_f3.GetString(5).Trim();
                    if (f3_2.Contains("阴性")) { RadioButton4.Checked = true; }
                    if (f3_2.Contains("阳性")) { RadioButton5.Checked = true; }
                    //切缘病理位置
                    if (sqldatareader_f3.IsDBNull(6)) { TextBox195.Text = ""; } else { TextBox195.Text = sqldatareader_f3.GetString(6); }
                    //是否二次扩切
                    string f3_3 = sqldatareader_f3.GetString(7).Trim();
                    if (f3_3.Contains("否")) { RadioButton6.Checked = true; }
                    if (f3_3.Contains("是")) { RadioButton7.Checked = true; }
                    //二次切缘病理阴阳性
                    string f3_4 = sqldatareader_f3.GetString(8).Trim();
                    if (f3_4.Contains("阴性")) { RadioButton8.Checked = true; }
                    if (f3_4.Contains("阳性")) { RadioButton9.Checked = true; }
                    //二次切缘病理位置
                    if (sqldatareader_f3.IsDBNull(9)) { TextBox196.Text = ""; } else { TextBox196.Text = sqldatareader_f3.GetString(9); }
                    //保乳术是否成功
                    string f3_5 = sqldatareader_f3.GetString(10).Trim();
                    if (f3_5.Contains("是")) { RadioButton10.Checked = true; }
                    if (f3_5.Contains("否")) { RadioButton11.Checked = true; }
                    //是否前哨淋巴结活检
                    string f3_6 = sqldatareader_f3.GetString(11).Trim();
                    if (f3_6.Contains("是")) { RadioButton12.Checked = true; }
                    if (f3_6.Contains("否")) { RadioButton13.Checked = true; }
                    //是否保乳整形
                    string f3_7 = sqldatareader_f3.GetString(12).Trim();
                    if (f3_7.Contains("否")) { RadioButton14.Checked = true; }
                    if (f3_7.Contains("是")) { RadioButton15.Checked = true; }
                    //整形方式
                    if (sqldatareader_f3.IsDBNull(13)) { TextBox311.Text = ""; } else { TextBox311.Text = sqldatareader_f3.GetString(13); }

                }
                sqlcommand_f3 = null;
                sqlconn_f3.Close();
                sqlconn_f3 = null;

                //f4
                SqlConnection sqlconn_f4 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_f4 = new SqlCommand();
                sqlcommand_f4.Connection = sqlconn_f4;

                sqlconn_f4.Open();//attention
                sqlcommand_f4.CommandText = "select * from f术后信息 where 就诊卡号=@就诊卡号";
                sqlcommand_f4.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_f4 = sqlcommand_f4.ExecuteReader();
                if (sqldatareader_f4.Read())
                {

                    f4Tb1.Text = sqldatareader_f4.GetString(0);
                    f4Tb2.Text = sqldatareader_f4.GetString(1);
                    if (sqldatareader_f4.GetString(2) == f4Rb1.Text) { f4Rb1.Checked = true; }
                    if (sqldatareader_f4.GetString(2) == f4Rb2.Text) { f4Rb2.Checked = true; }
                    f4Tb3.Text = sqldatareader_f4.GetString(3);
                    f4Tb4.Text = sqldatareader_f4.GetString(4);

                }
                sqlcommand_f4 = null;
                sqlconn_f4.Close();
                sqlconn_f4 = null;

                //f5
                SqlConnection sqlconn_f5 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_f5 = new SqlCommand();
                sqlcommand_f5.Connection = sqlconn_f5;

                sqlconn_f5.Open();//attention
                sqlcommand_f5.CommandText = "select * from f生活质量及美学指标 where 就诊卡号=@就诊卡号";
                sqlcommand_f5.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_f5 = sqlcommand_f5.ExecuteReader();
                if (sqldatareader_f5.Read())
                {
                    if (sqldatareader_f5.GetString(0) == RadioButton18.Text) { RadioButton18.Checked = true; }
                    if (sqldatareader_f5.GetString(0) == RadioButton19.Text) { RadioButton19.Checked = true; }
                    if (sqldatareader_f5.GetString(0) == RadioButton20.Text) { RadioButton20.Checked = true; }
                    if (sqldatareader_f5.GetString(0) == RadioButton21.Text) { RadioButton21.Checked = true; }

                    if (sqldatareader_f5.GetString(1) == "") { }
                    else { RadioButtonList51.SelectedValue = sqldatareader_f5.GetString(1).Trim(); }
                    if (sqldatareader_f5.GetString(2) == "") { }
                    else { RadioButtonList52.SelectedValue = sqldatareader_f5.GetString(2).Trim(); }
                    if (sqldatareader_f5.GetString(3) == "") { }
                    else { RadioButtonList53.SelectedValue = sqldatareader_f5.GetString(3).Trim(); }
                    if (sqldatareader_f5.GetString(4) == "") { }
                    else { RadioButtonList54.SelectedValue = sqldatareader_f5.GetString(4).Trim(); }
                    if (sqldatareader_f5.GetString(5) == "") { }
                    else { RadioButtonList55.SelectedValue = sqldatareader_f5.GetString(5).Trim(); }
                    if (sqldatareader_f5.GetString(6) == "") { }
                    else { RadioButtonList56.SelectedValue = sqldatareader_f5.GetString(6).Trim(); }
                    if (sqldatareader_f5.GetString(7) == "") { }
                    else { RadioButtonList57.SelectedValue = sqldatareader_f5.GetString(7).Trim(); }
                    if (sqldatareader_f5.GetString(8) == "") { }
                    else { RadioButtonList58.SelectedValue = sqldatareader_f5.GetString(8).Trim(); }
                    if (sqldatareader_f5.GetString(9) == "") { }
                    else { RadioButtonList59.SelectedValue = sqldatareader_f5.GetString(9).Trim(); }
                    if (sqldatareader_f5.GetString(10) == "") { }
                    else { RadioButtonList60.SelectedValue = sqldatareader_f5.GetString(10).Trim(); }

                    if (sqldatareader_f5.GetString(11) == "") { }
                    else { RadioButtonList61.SelectedValue = sqldatareader_f5.GetString(11).Trim(); }
                    if (sqldatareader_f5.GetString(12) == "") { }
                    else { RadioButtonList62.SelectedValue = sqldatareader_f5.GetString(12).Trim(); }
                    if (sqldatareader_f5.GetString(13) == "") { }
                    else { RadioButtonList63.SelectedValue = sqldatareader_f5.GetString(13).Trim(); }
                    if (sqldatareader_f5.GetString(14) == "") { }
                    else { RadioButtonList64.SelectedValue = sqldatareader_f5.GetString(14).Trim(); }
                    if (sqldatareader_f5.GetString(15) == "") { }
                    else { RadioButtonList65.SelectedValue = sqldatareader_f5.GetString(15).Trim(); }
                    if (sqldatareader_f5.GetString(16) == "") { }
                    else { RadioButtonList66.SelectedValue = sqldatareader_f5.GetString(16).Trim(); }
                    if (sqldatareader_f5.GetString(17) == "") { }
                    else { RadioButtonList67.SelectedValue = sqldatareader_f5.GetString(17).Trim(); }
                    if (sqldatareader_f5.GetString(18) == "") { }
                    else { RadioButtonList68.SelectedValue = sqldatareader_f5.GetString(18).Trim(); }
                    if (sqldatareader_f5.GetString(19) == "") { }
                    else { RadioButtonList69.SelectedValue = sqldatareader_f5.GetString(19).Trim(); }
                    if (sqldatareader_f5.GetString(20) == "") { }
                    else { RadioButtonList70.SelectedValue = sqldatareader_f5.GetString(20).Trim(); }

                    if (sqldatareader_f5.GetString(21) == "") { }
                    else { RadioButtonList71.SelectedValue = sqldatareader_f5.GetString(21).Trim(); }
                    if (sqldatareader_f5.GetString(22) == "") { }
                    else { RadioButtonList72.SelectedValue = sqldatareader_f5.GetString(22).Trim(); }
                    if (sqldatareader_f5.GetString(23) == "") { }
                    else { RadioButtonList73.SelectedValue = sqldatareader_f5.GetString(23).Trim(); }
                    if (sqldatareader_f5.GetString(24) == "") { }
                    else { RadioButtonList74.SelectedValue = sqldatareader_f5.GetString(24).Trim(); }
                    if (sqldatareader_f5.GetString(25) == "") { }
                    else { RadioButtonList75.SelectedValue = sqldatareader_f5.GetString(25).Trim(); }
                    if (sqldatareader_f5.GetString(26) == "") { }
                    else { RadioButtonList76.SelectedValue = sqldatareader_f5.GetString(26).Trim(); }
                    if (sqldatareader_f5.GetString(27) == "") { }
                    else { RadioButtonList77.SelectedValue = sqldatareader_f5.GetString(27).Trim(); }
                    if (sqldatareader_f5.GetString(28) == "") { }
                    else { RadioButtonList78.SelectedValue = sqldatareader_f5.GetString(28).Trim(); }
                    if (sqldatareader_f5.GetString(29) == "") { }
                    else { RadioButtonList79.SelectedValue = sqldatareader_f5.GetString(29).Trim(); }
                    if (sqldatareader_f5.GetString(30) == "") { }
                    else { RadioButtonList80.SelectedValue = sqldatareader_f5.GetString(30).Trim(); }
                    if (sqldatareader_f5.GetString(31) == "") { }
                    else { RadioButtonList81.SelectedValue = sqldatareader_f5.GetString(31).Trim(); }

                    TextBox199.Text = sqldatareader_f5.GetString(32);
                    TextBox200.Text = sqldatareader_f5.GetString(33);
                    TextBox201.Text = sqldatareader_f5.GetString(34);
                    TextBox202.Text = sqldatareader_f5.GetString(35);
                    //就诊卡号索引sqldatareader_f1.GetString(36);

                    if (sqldatareader_f5.GetString(37) == "") { }
                    else { RadioButtonList82.SelectedValue = sqldatareader_f5.GetString(37).Trim(); }

                }
                sqlcommand_f5 = null;
                sqlconn_f5.Close();
                sqlconn_f5 = null;

                //最后读值完成后“更新”键显示，“确定”键隐藏
                Button7.Visible = true;
                Button1.Visible = false;
            }
        }
        //实现当鼠标点击某一行时，页面上方显示此被点击的值
        //
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow curgvr = (GridViewRow)((LinkButton)e.CommandSource).Parent.Parent;
            Label lbl = (Label)curgvr.FindControl("biaoqian1");

            Label500.Text = lbl.Text;
        }

        //实现当鼠标在某一行上时的表格效果
        //
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton lbtn = (LinkButton)e.Row.FindControl("a");
                e.Row.Attributes.Add("onclick", ClientScript.GetPostBackClientHyperlink(lbtn, ""));

                e.Row.Attributes.Add("style", "cursor:pointer");
                e.Row.Attributes.Add("onmouseover", "if(this!=prevselitem){this.style.backgroundColor='#Efefef'}");//当鼠标停留时更改背景色 
                e.Row.Attributes.Add("onmouseout", "if(this!=prevselitem){this.style.backgroundColor='#ffffff'}");//当鼠标移开时还原背景色 
            }
        }

        //点击删除按钮后实现删除所有表中的相关信息
        //
        protected void Button5_Click(object sender, EventArgs e)
        {
            if (Label500.Text == "")
            {
                Response.Write("<script language='javascript'>alert('请选择数据！')</script>");
            }
            else
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString());
                string sqlconnstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

                //a1页面
                SqlConnection sqlconn_a1 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_a1 = new SqlCommand();
                sqlcommand_a1.Connection = sqlconn_a1;

                int intDeleteCount_a1;
                sqlcommand_a1.CommandText = "delete from a入院概要 where 就诊卡号=@就诊卡号";
                sqlcommand_a1.Parameters.AddWithValue("@就诊卡号", Label500.Text);
                try
                {
                    sqlconn_a1.Open();
                    intDeleteCount_a1 = sqlcommand_a1.ExecuteNonQuery();

                    if (sqlcommand_a1.ExecuteNonQuery() > 0)
                    {
                        Label450.Text = "删除成功";
                    }
                    else
                    {
                        Label450.Text = "未删除成功";
                    }
                }
                catch (Exception ex) { Label450.Text = "错误原因：" + ex.Message; }

                finally
                {
                    sqlcommand_a1 = null;
                    sqlconn_a1.Close();
                    sqlconn_a1 = null;
                }

                //a2页面
                SqlConnection sqlconn_a2 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_a2 = new SqlCommand();
                sqlcommand_a2.Connection = sqlconn_a2;

                int intDeleteCount_a2;
                sqlcommand_a2.CommandText = "delete from a主诉  where 就诊卡号=@就诊卡号";
                sqlcommand_a2.Parameters.AddWithValue("@就诊卡号", Label500.Text);
                try
                {
                    sqlconn_a2.Open();
                    intDeleteCount_a2 = sqlcommand_a2.ExecuteNonQuery();

                    if (sqlcommand_a2.ExecuteNonQuery() > 0)
                    {
                        Label451.Text = "删除成功";
                    }
                    else
                    {
                        Label451.Text = "未删除成功";
                    }
                }
                catch (Exception ex) { Label451.Text = "错误原因：" + ex.Message; }


                finally
                {
                    sqlcommand_a2 = null;
                    sqlconn_a2.Close();
                    sqlconn_a2 = null;
                }

                //a3页面
                SqlConnection sqlconn_a3 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_a3 = new SqlCommand();
                sqlcommand_a3.Connection = sqlconn_a3;

                int intDeleteCount_a3;
                sqlcommand_a3.CommandText = "delete from a现病史  where 就诊卡号=@就诊卡号";
                sqlcommand_a3.Parameters.AddWithValue("@就诊卡号", Label500.Text);
                try
                {
                    sqlconn_a3.Open();
                    intDeleteCount_a3 = sqlcommand_a3.ExecuteNonQuery();

                    if (sqlcommand_a3.ExecuteNonQuery() > 0)
                    {
                        Label452.Text = "删除成功";
                    }
                    else
                    {
                        Label452.Text = "未删除成功";
                    }
                }
                catch (Exception ex) { Label452.Text = "错误原因：" + ex.Message; }


                finally
                {
                    sqlcommand_a3 = null;
                    sqlconn_a3.Close();
                    sqlconn_a3 = null;
                }

                //a4页面
                SqlConnection sqlconn_a4 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_a4 = new SqlCommand();
                sqlcommand_a4.Connection = sqlconn_a4;

                int intDeleteCount_a4;
                sqlcommand_a4.CommandText = "delete from a身体状况  where 就诊卡号=@就诊卡号";
                sqlcommand_a4.Parameters.AddWithValue("@就诊卡号", Label500.Text);
                try
                {
                    sqlconn_a4.Open();
                    intDeleteCount_a4 = sqlcommand_a4.ExecuteNonQuery();

                    if (sqlcommand_a4.ExecuteNonQuery() > 0)
                    {
                        Label453.Text = "删除成功";
                    }
                    else
                    {
                        Label453.Text = "未删除成功";
                    }
                }
                catch (Exception ex) { Label453.Text = "错误原因：" + ex.Message; }

                finally
                {
                    sqlcommand_a4 = null;
                    sqlconn_a4.Close();
                    sqlconn_a4 = null;
                }

                //a5页面
                SqlConnection sqlconn_a5 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_a5 = new SqlCommand();
                sqlcommand_a5.Connection = sqlconn_a5;

                int intDeleteCount_a5;
                sqlcommand_a5.CommandText = "delete from a个人情况  where 就诊卡号=@就诊卡号";
                sqlcommand_a5.Parameters.AddWithValue("@就诊卡号", Label500.Text);
                try
                {
                    sqlconn_a5.Open();
                    intDeleteCount_a5 = sqlcommand_a5.ExecuteNonQuery();

                    if (sqlcommand_a5.ExecuteNonQuery() > 0)
                    {
                        Label454.Text = "删除成功";
                    }
                    else
                    {
                        Label454.Text = "未删除成功";
                    }
                }
                catch (Exception ex) { Label454.Text = "错误原因：" + ex.Message; }

                finally
                {
                    sqlcommand_a5 = null;
                    sqlconn_a5.Close();
                    sqlconn_a5 = null;
                }

                //a6页面
                SqlConnection sqlconn_a6 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_a6 = new SqlCommand();
                sqlcommand_a6.Connection = sqlconn_a6;

                int intDeleteCount_a6;
                sqlcommand_a6.CommandText = "delete from a专科查体  where 就诊卡号=@就诊卡号";
                sqlcommand_a6.Parameters.AddWithValue("@就诊卡号", Label500.Text);
                try
                {
                    sqlconn_a6.Open();
                    intDeleteCount_a6 = sqlcommand_a6.ExecuteNonQuery();

                    if (sqlcommand_a6.ExecuteNonQuery() > 0)
                    {
                        Label455.Text = "删除成功";
                    }
                    else
                    {
                        Label455.Text = "未删除成功";
                    }
                }
                catch (Exception ex) { Label455.Text = "错误原因：" + ex.Message; }

                finally
                {
                    sqlcommand_a6 = null;
                    sqlconn_a6.Close();
                    sqlconn_a6 = null;
                }

                //a7页面
                SqlConnection sqlconn_a7 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_a7 = new SqlCommand();
                sqlcommand_a7.Connection = sqlconn_a7;

                int intDeleteCount_a7;
                sqlcommand_a7.CommandText = "delete from a其他  where 就诊卡号=@就诊卡号";
                sqlcommand_a7.Parameters.AddWithValue("@就诊卡号", Label500.Text);
                try
                {
                    sqlconn_a7.Open();
                    intDeleteCount_a7 = sqlcommand_a7.ExecuteNonQuery();

                    if (sqlcommand_a7.ExecuteNonQuery() > 0)
                    {
                        Label456.Text = "删除成功";
                    }
                    else
                    {
                        Label456.Text = "未删除成功";
                    }
                }
                catch (Exception ex) { Label456.Text = "错误原因：" + ex.Message; }

                finally
                {
                    sqlcommand_a7 = null;
                    sqlconn_a7.Close();
                    sqlconn_a7 = null;
                }


                //b1页面
                SqlConnection sqlconn_b1 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_b1 = new SqlCommand();
                sqlcommand_b1.Connection = sqlconn_b1;

                int intDeleteCount_b1;
                sqlcommand_b1.CommandText = "delete from b术前检查  where 就诊卡号=@就诊卡号";
                sqlcommand_b1.Parameters.AddWithValue("@就诊卡号", Label500.Text);
                try
                {
                    sqlconn_b1.Open();
                    intDeleteCount_b1 = sqlcommand_b1.ExecuteNonQuery();

                    if (sqlcommand_b1.ExecuteNonQuery() > 0)
                    {
                        Label457.Text = "删除成功";
                    }
                    else
                    {
                        Label457.Text = "未删除成功";
                    }
                }
                catch (Exception ex) { Label457.Text = "错误原因：" + ex.Message; }

                finally
                {
                    sqlcommand_b1 = null;
                    sqlconn_b1.Close();
                    sqlconn_b1 = null;
                }

                //b2页面
                SqlConnection sqlconn_b2 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_b2 = new SqlCommand();
                sqlcommand_b2.Connection = sqlconn_b2;

                int intDeleteCount_b2;
                sqlcommand_b2.CommandText = "delete from b术中实施SLNB  where 就诊卡号=@就诊卡号";
                sqlcommand_b2.Parameters.AddWithValue("@就诊卡号", Label500.Text);
                try
                {
                    sqlconn_b2.Open();
                    intDeleteCount_b2 = sqlcommand_b2.ExecuteNonQuery();

                    if (sqlcommand_b2.ExecuteNonQuery() > 0)
                    {
                        Label458.Text = "删除成功";
                    }
                    else
                    {
                        Label458.Text = "未删除成功";
                    }
                }
                catch (Exception ex) { Label458.Text = "错误原因：" + ex.Message; }

                finally
                {
                    sqlcommand_b2 = null;
                    sqlconn_b2.Close();
                    sqlconn_b2 = null;
                }


                //b3页面
                SqlConnection sqlconn_b3 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_b3 = new SqlCommand();
                sqlcommand_b3.Connection = sqlconn_b3;

                int intDeleteCount_b3;
                sqlcommand_b3.CommandText = "delete from b术中行ARM  where 就诊卡号=@就诊卡号";
                sqlcommand_b3.Parameters.AddWithValue("@就诊卡号", Label500.Text);
                try
                {
                    sqlconn_b3.Open();
                    intDeleteCount_b3 = sqlcommand_b3.ExecuteNonQuery();

                    if (sqlcommand_b3.ExecuteNonQuery() > 0)
                    {
                        Label459.Text = "删除成功";
                    }
                    else
                    {
                        Label459.Text = "未删除成功";
                    }
                }
                catch (Exception ex) { Label459.Text = "错误原因：" + ex.Message; }

                finally
                {
                    sqlcommand_b3 = null;
                    sqlconn_b3.Close();
                    sqlconn_b3 = null;
                }


                //b4页面
                SqlConnection sqlconn_b4 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_b4 = new SqlCommand();
                sqlcommand_b4.Connection = sqlconn_b4;

                int intDeleteCount_b4;
                sqlcommand_b4.CommandText = "delete from b腋窝状况记录 where 就诊卡号=@就诊卡号";
                sqlcommand_b4.Parameters.AddWithValue("@就诊卡号", Label500.Text);
                try
                {
                    sqlconn_b4.Open();
                    intDeleteCount_b4 = sqlcommand_b4.ExecuteNonQuery();

                    if (sqlcommand_b4.ExecuteNonQuery() > 0)
                    {
                        Label460.Text = "删除成功";
                    }
                    else
                    {
                        Label460.Text = "未删除成功";
                    }
                }
                catch (Exception ex) { Label460.Text = "错误原因：" + ex.Message; }

                finally
                {
                    sqlcommand_b4 = null;
                    sqlconn_b4.Close();
                    sqlconn_b4 = null;
                }

                //c1页面
                SqlConnection sqlconn_c1 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_c1 = new SqlCommand();
                sqlcommand_c1.Connection = sqlconn_c1;

                int intDeleteCount_c1;
                sqlcommand_c1.CommandText = "delete from c术前化疗 where 就诊卡号=@就诊卡号";
                sqlcommand_c1.Parameters.AddWithValue("@就诊卡号", Label500.Text);
                try
                {
                    sqlconn_c1.Open();
                    intDeleteCount_c1 = sqlcommand_c1.ExecuteNonQuery();

                    if (sqlcommand_c1.ExecuteNonQuery() > 0)
                    {
                        Label461.Text = "删除成功";
                    }
                    else
                    {
                        Label461.Text = "未删除成功";
                    }
                }
                catch (Exception ex) { Label461.Text = "错误原因：" + ex.Message; }

                finally
                {
                    sqlcommand_c1 = null;
                    sqlconn_c1.Close();
                    sqlconn_c1 = null;
                }


                //c2页面
                SqlConnection sqlconn_c2 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_c2 = new SqlCommand();
                sqlcommand_c2.Connection = sqlconn_c2;

                int intDeleteCount_c2;
                sqlcommand_c2.CommandText = "delete from c术后化疗 where 就诊卡号=@就诊卡号";
                sqlcommand_c2.Parameters.AddWithValue("@就诊卡号", Label500.Text);
                try
                {
                    sqlconn_c2.Open();
                    intDeleteCount_c2 = sqlcommand_c2.ExecuteNonQuery();

                    if (sqlcommand_c2.ExecuteNonQuery() > 0)
                    {
                        Label462.Text = "删除成功";
                    }
                    else
                    {
                        Label462.Text = "未删除成功";
                    }
                }
                catch (Exception ex) { Label462.Text = "错误原因：" + ex.Message; }

                finally
                {
                    sqlcommand_c2 = null;
                    sqlconn_c2.Close();
                    sqlconn_c2 = null;
                }

                //d1页面
                SqlConnection sqlconn_d1 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_d1 = new SqlCommand();
                sqlcommand_d1.Connection = sqlconn_d1;

                int intDeleteCount_d1;
                sqlcommand_d1.CommandText = "delete from d一般  where 就诊卡号=@就诊卡号";
                sqlcommand_d1.Parameters.AddWithValue("@就诊卡号", Label500.Text);
                try
                {
                    sqlconn_d1.Open();
                    intDeleteCount_d1 = sqlcommand_d1.ExecuteNonQuery();

                    if (sqlcommand_d1.ExecuteNonQuery() > 0)
                    {
                        Label463.Text = "删除成功";
                    }
                    else
                    {
                        Label463.Text = "未删除成功";
                    }
                }
                catch (Exception ex) { Label463.Text = "错误原因：" + ex.Message; }

                finally
                {
                    sqlcommand_d1 = null;
                    sqlconn_d1.Close();
                    sqlconn_d1 = null;
                }

                //d2页面
                SqlConnection sqlconn_d2 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_d2 = new SqlCommand();
                sqlcommand_d2.Connection = sqlconn_d2;

                int intDeleteCount_d2;
                sqlcommand_d2.CommandText = "delete from d乳腺复发转移  where 就诊卡号=@就诊卡号";
                sqlcommand_d2.Parameters.AddWithValue("@就诊卡号", Label500.Text);
                try
                {
                    sqlconn_d2.Open();
                    intDeleteCount_d2 = sqlcommand_d2.ExecuteNonQuery();

                    if (sqlcommand_d2.ExecuteNonQuery() > 0)
                    {
                        Label464.Text = "删除成功";
                    }
                    else
                    {
                        Label464.Text = "未删除成功";
                    }
                }
                catch (Exception ex) { Label464.Text = "错误原因：" + ex.Message; }

                finally
                {
                    sqlcommand_d2 = null;
                    sqlconn_d2.Close();
                    sqlconn_d2 = null;
                }

                //d3页面
                SqlConnection sqlconn_d3 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_d3 = new SqlCommand();
                sqlcommand_d3.Connection = sqlconn_d3;

                int intDeleteCount_d3;
                sqlcommand_d3.CommandText = "delete from d诊疗异常反应  where 就诊卡号=@就诊卡号";
                sqlcommand_d3.Parameters.AddWithValue("@就诊卡号", Label500.Text);
                try
                {
                    sqlconn_d3.Open();
                    intDeleteCount_d3 = sqlcommand_d3.ExecuteNonQuery();

                    if (sqlcommand_d3.ExecuteNonQuery() > 0)
                    {
                        Label465.Text = "删除成功";
                    }
                    else
                    {
                        Label465.Text = "未删除成功";
                    }
                }
                catch (Exception ex) { Label465.Text = "错误原因：" + ex.Message; }

                finally
                {
                    sqlcommand_d3 = null;
                    sqlconn_d3.Close();
                    sqlconn_d3 = null;
                }

                //e1页面
                SqlConnection sqlconn_e1 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_e1 = new SqlCommand();
                sqlcommand_e1.Connection = sqlconn_e1;

                int intDeleteCount_e1;
                sqlcommand_e1.CommandText = "delete from e根治信息  where 就诊卡号=@就诊卡号";
                sqlcommand_e1.Parameters.AddWithValue("@就诊卡号", Label500.Text);
                try
                {
                    sqlconn_e1.Open();
                    intDeleteCount_e1 = sqlcommand_e1.ExecuteNonQuery();

                    if (sqlcommand_e1.ExecuteNonQuery() > 0)
                    {
                        Label466.Text = "删除成功";
                    }
                    else
                    {
                        Label466.Text = "未删除成功";
                    }
                }
                catch (Exception ex) { Label466.Text = "错误原因：" + ex.Message; }

                finally
                {
                    sqlcommand_e1 = null;
                    sqlconn_e1.Close();
                    sqlconn_e1 = null;
                }

                //e2页面
                SqlConnection sqlconn_e2 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_e2 = new SqlCommand();
                sqlcommand_e2.Connection = sqlconn_e2;

                int intDeleteCount_e2;
                sqlcommand_e2.CommandText = "delete from e根治术相关  where 就诊卡号=@就诊卡号";
                sqlcommand_e2.Parameters.AddWithValue("@就诊卡号", Label500.Text);
                try
                {
                    sqlconn_e2.Open();
                    intDeleteCount_e2 = sqlcommand_e2.ExecuteNonQuery();

                    if (sqlcommand_e2.ExecuteNonQuery() > 0)
                    {
                        Label467.Text = "删除成功";
                    }
                    else
                    {
                        Label467.Text = "未删除成功";
                    }
                }
                catch (Exception ex) { Label467.Text = "错误原因：" + ex.Message; }

                finally
                {
                    sqlcommand_e2 = null;
                    sqlconn_e2.Close();
                    sqlconn_e2 = null;
                }


                //e3页面
                SqlConnection sqlconn_e3 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_e3 = new SqlCommand();
                sqlcommand_e3.Connection = sqlconn_e3;

                int intDeleteCount_e3;
                sqlcommand_e3.CommandText = "delete from e手术相关  where 就诊卡号=@就诊卡号";
                sqlcommand_e3.Parameters.AddWithValue("@就诊卡号", Label500.Text);
                try
                {
                    sqlconn_e3.Open();
                    intDeleteCount_e3 = sqlcommand_e3.ExecuteNonQuery();

                    if (sqlcommand_e3.ExecuteNonQuery() > 0)
                    {
                        Label468.Text = "删除成功";
                    }
                    else
                    {
                        Label468.Text = "未删除成功";
                    }
                }
                catch (Exception ex) { Label468.Text = "错误原因：" + ex.Message; }

                finally
                {
                    sqlcommand_e3 = null;
                    sqlconn_e3.Close();
                    sqlconn_e3 = null;
                }

                //f1页面
                SqlConnection sqlconn_f1 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_f1 = new SqlCommand();
                sqlcommand_f1.Connection = sqlconn_f1;

                int intDeleteCount_f1;
                sqlcommand_f1.CommandText = "delete from f术前信息1  where 就诊卡号=@就诊卡号";
                sqlcommand_f1.Parameters.AddWithValue("@就诊卡号", Label500.Text);
                try
                {
                    sqlconn_f1.Open();
                    intDeleteCount_f1 = sqlcommand_f1.ExecuteNonQuery();

                    if (sqlcommand_f1.ExecuteNonQuery() > 0)
                    {
                        Label469.Text = "删除成功";
                    }
                    else
                    {
                        Label469.Text = "未删除成功";
                    }
                }
                catch (Exception ex) { Label469.Text = "错误原因：" + ex.Message; }

                finally
                {
                    sqlcommand_f1 = null;
                    sqlconn_f1.Close();
                    sqlconn_f1 = null;
                }

                //f2页面
                SqlConnection sqlconn_f2 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_f2 = new SqlCommand();
                sqlcommand_f2.Connection = sqlconn_f2;

                int intDeleteCount_f2;
                sqlcommand_f2.CommandText = "delete from f术前信息2  where 就诊卡号=@就诊卡号";
                sqlcommand_f2.Parameters.AddWithValue("@就诊卡号", Label500.Text);
                try
                {
                    sqlconn_f2.Open();
                    intDeleteCount_f2 = sqlcommand_f2.ExecuteNonQuery();

                    if (sqlcommand_f2.ExecuteNonQuery() > 0)
                    {
                        Label469.Text = "删除成功";
                    }
                    else
                    {
                        Label469.Text = "未删除成功";
                    }
                }
                catch (Exception ex) { Label469.Text = "错误原因：" + ex.Message; }

                finally
                {
                    sqlcommand_f2 = null;
                    sqlconn_f2.Close();
                    sqlconn_f2 = null;
                }


                //f3页面
                SqlConnection sqlconn_f3 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_f3 = new SqlCommand();
                sqlcommand_f3.Connection = sqlconn_f3;

                int intDeleteCount_f3;
                sqlcommand_f3.CommandText = "delete from f手术信息  where 就诊卡号=@就诊卡号";
                sqlcommand_f3.Parameters.AddWithValue("@就诊卡号", Label500.Text);
                try
                {
                    sqlconn_f3.Open();
                    intDeleteCount_f3 = sqlcommand_f3.ExecuteNonQuery();

                    if (sqlcommand_f3.ExecuteNonQuery() > 0)
                    {
                        Label470.Text = "删除成功";
                    }
                    else
                    {
                        Label470.Text = "未删除成功";
                    }
                }
                catch (Exception ex) { Label470.Text = "错误原因：" + ex.Message; }

                finally
                {
                    sqlcommand_f3 = null;
                    sqlconn_f3.Close();
                    sqlconn_f3 = null;
                }

                //f4页面
                SqlConnection sqlconn_f4 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_f4 = new SqlCommand();
                sqlcommand_f4.Connection = sqlconn_f4;

                int intDeleteCount_f4;
                sqlcommand_f4.CommandText = "delete from f术后信息  where 就诊卡号=@就诊卡号";
                sqlcommand_f4.Parameters.AddWithValue("@就诊卡号", Label500.Text);
                try
                {
                    sqlconn_f4.Open();
                    intDeleteCount_f4 = sqlcommand_f4.ExecuteNonQuery();

                    if (sqlcommand_f4.ExecuteNonQuery() > 0)
                    {
                        Label471.Text = "删除成功";
                    }
                    else
                    {
                        Label471.Text = "未删除成功";
                    }
                }
                catch (Exception ex) { Label471.Text = "错误原因：" + ex.Message; }

                finally
                {
                    sqlcommand_f4 = null;
                    sqlconn_f4.Close();
                    sqlconn_f4 = null;
                }

                //f5页面
                SqlConnection sqlconn_f5 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_f5 = new SqlCommand();
                sqlcommand_f5.Connection = sqlconn_f5;

                int intDeleteCount_f5;
                sqlcommand_f5.CommandText = "delete from f生活质量及美学指标  where 就诊卡号=@就诊卡号";
                sqlcommand_f5.Parameters.AddWithValue("@就诊卡号", Label500.Text);
                try
                {
                    sqlconn_f5.Open();
                    intDeleteCount_f5 = sqlcommand_f5.ExecuteNonQuery();

                    if (sqlcommand_f5.ExecuteNonQuery() > 0)
                    {
                        Label472.Text = "删除成功";
                    }
                    else
                    {
                        Label472.Text = "未删除成功";
                    }
                }
                catch (Exception ex) { Label472.Text = "错误原因：" + ex.Message; }

                finally
                {
                    sqlcommand_f5 = null;
                    sqlconn_f5.Close();
                    sqlconn_f5 = null;
                }
                Response.Redirect("index.aspx");
            }
        }

        //更新键与确定键的转换
        //
        protected void Button3_Click(object sender, EventArgs e)
        {

            Panel89.Enabled = true;
            //“确定”键显示，“更新”键隐藏
            Button7.Visible = false;
            Button1.Visible = true;

            //就诊卡号键可进行编辑
            TextBox2.Enabled = true;
            //清空文本框中的数据
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";
            TextBox13.Text = "";
            TextBox14.Text = "";
            TextBox15.Text = "";
            TextBox16.Text = "";
            TextBox17.Text = "";
            TextBox18.Text = "";
            TextBox19.Text = "";
            TextBox20.Text = "";
            TextBox21.Text = "";
            TextBox22.Text = "";
            TextBox23.Text = "";
            TextBox24.Text = "";
            TextBox25.Text = "";
            TextBox26.Text = "";
            TextBox27.Text = "";
            TextBox28.Text = "";
            TextBox29.Text = "";
            TextBox30.Text = "";
            TextBox31.Text = "";
            TextBox32.Text = "";
            TextBox33.Text = "";
            TextBox34.Text = "";
            TextBox35.Text = "";
            TextBox36.Text = "";
            TextBox37.Text = "";
            TextBox38.Text = "";
            TextBox39.Text = "";
            TextBox40.Text = "";
            TextBox41.Text = "";
            TextBox42.Text = "";
            TextBox43.Text = "";
            TextBox44.Text = "";
            TextBox45.Text = "";
            TextBox46.Text = "";
            TextBox47.Text = "";
            TextBox48.Text = "";
            TextBox49.Text = "";
            TextBox50.Text = "";
            TextBox51.Text = "";
            TextBox52.Text = "";
            TextBox53.Text = "";
            TextBox54.Text = "";
            TextBox55.Text = "";
            TextBox56.Text = "";
            TextBox57.Text = "";
            TextBox58.Text = "";
            TextBox59.Text = "";
            TextBox60.Text = "";
            TextBox61.Text = "";
            TextBox62.Text = "";
            TextBox63.Text = "";
            TextBox64.Text = "";
            TextBox65.Text = "";
            TextBox66.Text = "";
            TextBox67.Text = "";
            TextBox68.Text = "";
            TextBox69.Text = "";
            TextBox70.Text = "";
            TextBox71.Text = "";
            TextBox72.Text = "";
            TextBox73.Text = "";
            TextBox74.Text = "";
            TextBox75.Text = "";
            TextBox76.Text = "";
            TextBox77.Text = "";
            TextBox78.Text = "";
            TextBox79.Text = "";
            TextBox80.Text = "";
            TextBox81.Text = "";
            TextBox82.Text = "";
            TextBox83.Text = "";
            TextBox84.Text = "";
            TextBox85.Text = "";
            TextBox86.Text = "";
            TextBox87.Text = "";
            TextBox88.Text = "";
            TextBox89.Text = "";
            TextBox90.Text = "";
            TextBox91.Text = "";
            TextBox92.Text = "";
            TextBox93.Text = "";
            TextBox94.Text = "";
            TextBox95.Text = "";
            TextBox96.Text = "";
            TextBox97.Text = "";
            TextBox98.Text = "";
            TextBox99.Text = "";
            TextBox100.Text = "";
            TextBox101.Text = "";
            TextBox102.Text = "";
            TextBox103.Text = "";
            TextBox104.Text = "";
            TextBox105.Text = "";
            TextBox106.Text = "";
            TextBox107.Text = "";
            TextBox108.Text = "";
            TextBox109.Text = "";
            TextBox110.Text = "";
            TextBox111.Text = "";
            TextBox112.Text = "";
            TextBox113.Text = "";
            TextBox114.Text = "";
            TextBox115.Text = "";
            TextBox116.Text = "";
            TextBox117.Text = "";
            TextBox118.Text = "";
            TextBox119.Text = "";
            TextBox120.Text = "";
            TextBox121.Text = "";
            TextBox122.Text = "";
            TextBox123.Text = "";
            TextBox124.Text = "";
            TextBox125.Text = "";
            TextBox126.Text = "";
            TextBox127.Text = "";
            TextBox128.Text = "";
            TextBox129.Text = "";
            TextBox130.Text = "";
            TextBox131.Text = "";
            TextBox132.Text = "";
            TextBox133.Text = "";
            TextBox134.Text = "";
            TextBox135.Text = "";
            TextBox136.Text = "";
            TextBox137.Text = "";
            TextBox138.Text = "";
            TextBox139.Text = "";
            TextBox140.Text = "";
            TextBox141.Text = "";
            TextBox142.Text = "";
            TextBox143.Text = "";
            TextBox144.Text = "";
            TextBox145.Text = "";
            TextBox146.Text = "";
            TextBox147.Text = "";
            TextBox148.Text = "";
            TextBox149.Text = "";
            TextBox150.Text = "";
            TextBox151.Text = "";
            TextBox152.Text = "";
            TextBox153.Text = "";
            TextBox154.Text = "";
            TextBox155.Text = "";
            TextBox156.Text = "";
            TextBox157.Text = "";
            TextBox158.Text = "";
            TextBox159.Text = "";
            TextBox160.Text = "";
            TextBox161.Text = "";
            TextBox162.Text = "";
            TextBox163.Text = "";
            TextBox164.Text = "";
            TextBox165.Text = "";
            TextBox166.Text = "";
            TextBox167.Text = "";
            TextBox168.Text = "";
            TextBox169.Text = "";
            TextBox170.Text = "";
            TextBox171.Text = "";
            TextBox172.Text = "";
            TextBox173.Text = "";
            TextBox174.Text = "";
            TextBox175.Text = "";
            TextBox176.Text = "";
            TextBox177.Text = "";
            TextBox178.Text = "";
            TextBox179.Text = "";
            TextBox180.Text = "";
            TextBox181.Text = "";
            TextBox182.Text = "";
            TextBox183.Text = "";
            TextBox184.Text = "";
            TextBox185.Text = "";
            TextBox186.Text = "";
            TextBox187.Text = "";
            TextBox188.Text = "";
        }

        //点击取消，清空值，并设置不可操作
        //
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");

            Panel89.Enabled = false;
        }

        //点击“更新"键后实现更新数据库中的值的操作
        //
        protected void Button7_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString());
            string sqlconnstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            //a1页面
            int intUpdateCount_a1;
            SqlConnection sqlconn_a1 = new SqlConnection(sqlconnstr);
            SqlCommand sqlcommand_a1 = new SqlCommand();
            sqlcommand_a1.Connection = sqlconn_a1;
            sqlcommand_a1.CommandText = "update a入院概要 set 姓名=@姓名,性别=@性别,年龄=@年龄,婚姻=@婚姻,籍贯=@籍贯,民族=@民族,职业=@职业,工作单位=@工作单位,住院号=@住院号,现住址=@现住址,病史陈述者=@病史陈述者,与患者关系=@与患者关系,联系电话=@联系电话,入院日期=@入院日期,记录日期=@记录日期 where 就诊卡号=@就诊卡号";
            sqlcommand_a1.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

            sqlcommand_a1.Parameters.AddWithValue("@姓名", TextBox1.Text);
            sqlcommand_a1.Parameters.AddWithValue("@性别", TextBox3.Text);
            sqlcommand_a1.Parameters.AddWithValue("@年龄", TextBox4.Text);
            sqlcommand_a1.Parameters.AddWithValue("@婚姻", TextBox5.Text);
            sqlcommand_a1.Parameters.AddWithValue("@籍贯", TextBox6.Text);
            sqlcommand_a1.Parameters.AddWithValue("@民族", TextBox7.Text);
            sqlcommand_a1.Parameters.AddWithValue("@职业", TextBox8.Text);
            sqlcommand_a1.Parameters.AddWithValue("@工作单位", TextBox9.Text);
            sqlcommand_a1.Parameters.AddWithValue("@住院号", TextBox10.Text);
            sqlcommand_a1.Parameters.AddWithValue("@现住址", TextBox11.Text);
            sqlcommand_a1.Parameters.AddWithValue("@病史陈述者", TextBox14.Text);
            sqlcommand_a1.Parameters.AddWithValue("@与患者关系", TextBox15.Text);
            sqlcommand_a1.Parameters.AddWithValue("@联系电话", TextBox16.Text);

            sqlcommand_a1.Parameters.AddWithValue("@入院日期", TextBox12.Text + " " + TextBox12a.Text + ":" + TextBox12b.Text + ":" + TextBox12c.Text);
            sqlcommand_a1.Parameters.AddWithValue("@记录日期", TextBox13.Text + " " + TextBox13a.Text + ":" + TextBox13b.Text + ":" + TextBox13c.Text);

            try
            {
                sqlconn_a1.Open();
                intUpdateCount_a1 = sqlcommand_a1.ExecuteNonQuery();

                if (sqlcommand_a1.ExecuteNonQuery() > 0)
                {
                    a1LbUpdate.Text = "更新成功";
                }
                else
                {
                    a1LbUpdate.Text = "未更新成功";
                }
            }
            catch (Exception ex) { a1LbUpdate.Text = "错误原因：" + ex.Message; }
            finally
            {
                sqlcommand_a1 = null;
                sqlconn_a1.Close();
                sqlconn_a1 = null;
            }

            //a2-b1
            //a2页面
            int intUpdateCount_a2;
            SqlConnection sqlconn_a2 = new SqlConnection(sqlconnstr);
            SqlCommand sqlcommand_a2 = new SqlCommand();
            sqlcommand_a2.Connection = sqlconn_a2;
            sqlcommand_a2.CommandText = "update a主诉 set 主要症状_侧别=@主要症状_侧别,主要症状_位置=@主要症状_位置,主要症状=@主要症状,主要症状_时间=@主要症状_时间,伴随症状_侧别=@伴随症状_侧别,伴随症状_位置=@伴随症状_位置,伴随症状=@伴随症状,伴随症状_时间=@伴随症状_时间,增大时长=@增大时长,转为血性时长=@转为血性时长 where 就诊卡号=@就诊卡号";
            sqlcommand_a2.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

            sqlcommand_a2.Parameters.AddWithValue("@主要症状_侧别", DropDownList31.Text);
            sqlcommand_a2.Parameters.AddWithValue("@主要症状_位置", DropDownList32.Text);
            string a1 = ""; string a2 = " "; string a3 = ""; string a4 = ""; string a5 = ""; string a6 = ""; string a7 = ""; string a8 = "";
            if (CheckBox33.Checked) { a1 = CheckBox33.Text; }
            if (CheckBox34.Checked) { a2 = CheckBox34.Text; }
            if (CheckBox35.Checked) { a3 = CheckBox35.Text; }
            if (CheckBox36.Checked) { a4 = CheckBox36.Text; }
            if (CheckBox37.Checked) { a5 = CheckBox37.Text; }
            if (CheckBox38.Checked) { a6 = CheckBox38.Text; }
            if (CheckBox39.Checked) { a7 = CheckBox39.Text; }
            if (CheckBox40.Checked) { a8 = CheckBox40.Text; }
            sqlcommand_a2.Parameters.AddWithValue("@主要症状", a1 + " " + a2 + " " + a3 + " " + a4 + " " + a5 + " " + a6 + " " + a7 + " " + a8);
            sqlcommand_a2.Parameters.AddWithValue("@主要症状_时间", TextBox239.Text + DropDownList33.Text);
            sqlcommand_a2.Parameters.AddWithValue("@伴随症状_侧别", DropDownList34.Text);
            sqlcommand_a2.Parameters.AddWithValue("@伴随症状_位置", DropDownList35.Text);

            string b1 = ""; string b2 = ""; string b3 = ""; string b4 = ""; string b5 = ""; string b6 = ""; string b7 = ""; string b8 = "";
            if (CheckBox41.Checked) { b1 = CheckBox41.Text; }
            if (CheckBox42.Checked) { b2 = CheckBox42.Text; }
            if (CheckBox43.Checked) { b3 = CheckBox43.Text; }
            if (CheckBox44.Checked) { b4 = CheckBox44.Text; }
            if (CheckBox45.Checked) { b5 = CheckBox45.Text; }
            if (CheckBox46.Checked) { b6 = CheckBox46.Text; }
            if (CheckBox47.Checked) { b7 = CheckBox47.Text; }
            if (CheckBox48.Checked) { b8 = CheckBox48.Text; }
            sqlcommand_a2.Parameters.AddWithValue("@伴随症状", b1 + " " + b2 + " " + b3 + " " + b4 + " " + b5 + " " + b6 + " " + b7 + " " + b8);

            sqlcommand_a2.Parameters.AddWithValue("@伴随症状_时间", TextBox240.Text + DropDownList36.Text);
            sqlcommand_a2.Parameters.AddWithValue("@增大时长", TextBox241.Text + DropDownList37.Text);
            sqlcommand_a2.Parameters.AddWithValue("@转为血性时长", TextBox242.Text + DropDownList38.Text);

            try
            {
                sqlconn_a2.Open();
                intUpdateCount_a2 = sqlcommand_a2.ExecuteNonQuery();

                if (sqlcommand_a2.ExecuteNonQuery() > 0)
                {
                    a2LbUpdate.Text = "更新成功";
                }
                else
                {
                    a2LbUpdate.Text = "未更新成功";
                }
            }
            catch (Exception ex) { a2LbUpdate.Text = "错误原因：" + ex.Message; }
            finally
            {
                sqlcommand_a2 = null;
                sqlconn_a2.Close();
                sqlconn_a2 = null;
            }

            //a3页面
            int intUpdateCount_a3;
            SqlConnection sqlconn_a3 = new SqlConnection(sqlconnstr);
            SqlCommand sqlcommand_a3 = new SqlCommand();
            sqlcommand_a3.Connection = sqlconn_a3;
            sqlcommand_a3.CommandText = "update a现病史 set 发现时长=@发现时长,发现原因=@发现原因,诱因=@诱因,病因=@病因,肿瘤大小=@肿瘤大小,压痛情况=@压痛情况,乳头溢液=@乳头溢液,溢液数量=@溢液数量,溢液动能=@溢液动能,溢液性状=@溢液性状,就诊经历=@就诊经历,就诊地点=@就诊地点,就诊过程=@就诊过程,诊疗疗效=@诊疗疗效,诊疗转归=@诊疗转归,诱因详情=@诱因详情,病因详情=@病因详情,诊疗转归_2=@诊疗转归_2 where 就诊卡号=@就诊卡号";
            sqlcommand_a3.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

            sqlcommand_a3.Parameters.AddWithValue("@发现时长", TextBox243.Text + DropDownList39.Text);
            sqlcommand_a3.Parameters.AddWithValue("@发现原因", DropDownList40.Text);
            sqlcommand_a3.Parameters.AddWithValue("@诱因", DropDownList41.Text);
            sqlcommand_a3.Parameters.AddWithValue("@诱因详情", TextBox244.Text);
            sqlcommand_a3.Parameters.AddWithValue("@病因", DropDownList42.Text);
            sqlcommand_a3.Parameters.AddWithValue("@病因详情", TextBox245.Text);
            sqlcommand_a3.Parameters.AddWithValue("@肿瘤大小", TextBox283.Text + "*" + TextBox284.Text);
            sqlcommand_a3.Parameters.AddWithValue("@压痛情况", DropDownList43.Text);
            sqlcommand_a3.Parameters.AddWithValue("@乳头溢液", DropDownList44.Text);
            sqlcommand_a3.Parameters.AddWithValue("@溢液数量", DropDownList45.Text);
            sqlcommand_a3.Parameters.AddWithValue("@溢液动能", DropDownList46.Text);
            sqlcommand_a3.Parameters.AddWithValue("@溢液性状", DropDownList47.Text);
            sqlcommand_a3.Parameters.AddWithValue("@就诊经历", DropDownList48.Text);
            sqlcommand_a3.Parameters.AddWithValue("@就诊地点", TextBox285.Text);
            sqlcommand_a3.Parameters.AddWithValue("@就诊过程", TextBox286.Text);
            sqlcommand_a3.Parameters.AddWithValue("@诊疗疗效", DropDownList96.Text);
            sqlcommand_a3.Parameters.AddWithValue("@诊疗转归", DropDownList49.Text);
            sqlcommand_a3.Parameters.AddWithValue("@诊疗转归_2", DropDownList50.Text);

            try
            {
                sqlconn_a3.Open();
                intUpdateCount_a3 = sqlcommand_a3.ExecuteNonQuery();

                if (sqlcommand_a3.ExecuteNonQuery() > 0)
                {
                    a3LbUpdate.Text = "更新成功";
                }
                else
                {
                    a3LbUpdate.Text = "未更新成功";
                }
            }
            catch (Exception ex) { a3LbUpdate.Text = "错误原因：" + ex.Message; }
            finally
            {
                sqlcommand_a3 = null;
                sqlconn_a3.Close();
                sqlconn_a3 = null;
            }

            //a4页面
            int intUpdateCount_a4;
            SqlConnection sqlconn_a4 = new SqlConnection(sqlconnstr);
            SqlCommand sqlcommand_a4 = new SqlCommand();
            sqlcommand_a4.Connection = sqlconn_a4;
            sqlcommand_a4.CommandText = "update a身体状况 set 一般状况=@一般状况,精神=@精神,食睡=@食睡,二便=@二便,体重=@体重,体力=@体力,既往体健=@既往体健,疾病史冠心病=@疾病史冠心病,疾病史糖尿病=@疾病史糖尿病,疾病史高血压=@疾病史高血压,疾病史甲亢病=@疾病史甲亢病,手术史=@手术史,手术史_时间=@手术史_时间,手术史_于何处=@手术史_于何处,进行何种手术=@进行何种手术,外伤史=@外伤史,输血史=@输血史,过敏史=@过敏史,外伤史_时间=@外伤史_时间,外伤史_于何处=@外伤史_于何处,受过何种外伤=@受过何种外伤,输血史_时间=@输血史_时间,输血史_于何处=@输血史_于何处,因何输血=@因何输血,食物有无=@食物有无,药物有无=@药物有无,食物详情=@食物详情,药物详情=@药物详情 where 就诊卡号=@就诊卡号";
            sqlcommand_a4.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

            sqlcommand_a4.Parameters.AddWithValue("@一般状况", DropDownList1.Text);
            sqlcommand_a4.Parameters.AddWithValue("@精神", DropDownList2.Text);
            sqlcommand_a4.Parameters.AddWithValue("@食睡", DropDownList3.Text);
            sqlcommand_a4.Parameters.AddWithValue("@二便", DropDownList4.Text);
            sqlcommand_a4.Parameters.AddWithValue("@体重", DropDownList5.Text);
            sqlcommand_a4.Parameters.AddWithValue("@体力", DropDownList6.Text);
            sqlcommand_a4.Parameters.AddWithValue("@既往体健", DropDownList7.Text);
            sqlcommand_a4.Parameters.AddWithValue("@疾病史冠心病", TextBox17.Text);
            sqlcommand_a4.Parameters.AddWithValue("@疾病史糖尿病", TextBox18.Text);
            sqlcommand_a4.Parameters.AddWithValue("@疾病史高血压", TextBox19.Text);
            sqlcommand_a4.Parameters.AddWithValue("@疾病史甲亢病", TextBox20.Text);
            sqlcommand_a4.Parameters.AddWithValue("@手术史", DropDownList8.Text);
            sqlcommand_a4.Parameters.AddWithValue("@手术史_时间", TextBox21.Text);
            sqlcommand_a4.Parameters.AddWithValue("@手术史_于何处", TextBox22.Text);
            sqlcommand_a4.Parameters.AddWithValue("@进行何种手术", TextBox23.Text);
            sqlcommand_a4.Parameters.AddWithValue("@外伤史", DropDownList9.Text);
            sqlcommand_a4.Parameters.AddWithValue("@外伤史_时间", TextBox302.Text);
            sqlcommand_a4.Parameters.AddWithValue("@外伤史_于何处", TextBox303.Text);
            sqlcommand_a4.Parameters.AddWithValue("@受过何种外伤", TextBox304.Text);
            sqlcommand_a4.Parameters.AddWithValue("@输血史", DropDownList10.Text);
            sqlcommand_a4.Parameters.AddWithValue("@输血史_时间", TextBox305.Text);
            sqlcommand_a4.Parameters.AddWithValue("@输血史_于何处", TextBox306.Text);
            sqlcommand_a4.Parameters.AddWithValue("@因何输血", TextBox307.Text);
            sqlcommand_a4.Parameters.AddWithValue("@过敏史", DropDownList11.Text);
            sqlcommand_a4.Parameters.AddWithValue("@食物有无", DropDownList97.Text);
            sqlcommand_a4.Parameters.AddWithValue("@药物有无", DropDownList98.Text);
            sqlcommand_a4.Parameters.AddWithValue("@食物详情", TextBox308.Text);
            sqlcommand_a4.Parameters.AddWithValue("@药物详情", TextBox309.Text);

            try
            {
                sqlconn_a4.Open();
                intUpdateCount_a4 = sqlcommand_a4.ExecuteNonQuery();

                if (sqlcommand_a4.ExecuteNonQuery() > 0)
                {
                    a4LbUpdate.Text = "更新成功";
                }
                else
                {
                    a4LbUpdate.Text = "未更新成功";
                }
            }
            catch (Exception ex) { a4LbUpdate.Text = "错误原因：" + ex.Message; }
            finally
            {
                sqlcommand_a4 = null;
                sqlconn_a4.Close();
                sqlconn_a4 = null;
            }

            //a5页面
            int intUpdateCount_a5;
            SqlConnection sqlconn_a5 = new SqlConnection(sqlconnstr);
            SqlCommand sqlcommand_a5 = new SqlCommand();
            sqlcommand_a5.Connection = sqlconn_a5;
            sqlcommand_a5.CommandText = "update a个人情况 set 身高=@身高,体重=@体重,T值=@体重,P值=@P值,R值=@R值,BP值=@BP值,KPS值=@KPS值,BSA值=@BSA值,出生地=@出生地,生长接触史=@生长接触史,烟酒详情=@烟酒详情,初潮年龄=@初潮年龄,绝经年龄=@绝经年龄,末次月经=@末次月经,痛经情况=@痛经情况,结婚情况=@结婚情况,结婚年龄=@结婚年龄,配偶情况=@配偶情况,P=@P,A=@A,G=@G,哺乳情况=@哺乳情况,哺乳侧别=@哺乳侧别,持续时间=@持续时间,子女情况=@子女情况,父亲情况=@父亲情况,母亲情况=@母亲情况,家族恶性肿瘤史=@家族恶性肿瘤史,初潮年龄_分子=@初潮年龄_分子,初潮年龄_分母=@初潮年龄_分母,父亲详情=@父亲详情,母亲详情=@母亲详情,家族详情=@家族详情 where 就诊卡号=@就诊卡号";
            sqlcommand_a5.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

            sqlcommand_a5.Parameters.AddWithValue("@身高", TextBox246.Text);
            sqlcommand_a5.Parameters.AddWithValue("@体重", TextBox247.Text);
            sqlcommand_a5.Parameters.AddWithValue("@T值", TextBox248.Text);
            sqlcommand_a5.Parameters.AddWithValue("@P值", TextBox249.Text);
            sqlcommand_a5.Parameters.AddWithValue("@R值", TextBox250.Text);
            sqlcommand_a5.Parameters.AddWithValue("@BP值", TextBox251.Text);
            sqlcommand_a5.Parameters.AddWithValue("@KPS值", TextBox252.Text);
            sqlcommand_a5.Parameters.AddWithValue("@BSA值", TextBox253.Text);
            sqlcommand_a5.Parameters.AddWithValue("@出生地", TextBox254.Text);

            string e1 = ""; string e2 = " "; string e3 = ""; string e4 = ""; string e5 = "";
            if (CheckBox49.Checked) { e1 = CheckBox49.Text; }
            if (CheckBox50.Checked) { e2 = CheckBox50.Text; }
            if (CheckBox51.Checked) { e3 = CheckBox51.Text; }
            if (CheckBox52.Checked) { e4 = CheckBox52.Text; }
            if (CheckBox53.Checked) { e5 = CheckBox53.Text; }
            sqlcommand_a5.Parameters.AddWithValue("@生长接触史", e1 + " " + e2 + " " + e3 + " " + e4 + " " + e5);
            sqlcommand_a5.Parameters.AddWithValue("@烟酒详情", TextBox255.Text);
            sqlcommand_a5.Parameters.AddWithValue("@初潮年龄", TextBox256.Text);
            sqlcommand_a5.Parameters.AddWithValue("@绝经年龄", TextBox258.Text);
            sqlcommand_a5.Parameters.AddWithValue("@末次月经", TextBox259.Text);

            string f = "";
            if (CheckBox54.Checked) { f = "是"; } else { f = "否"; }
            sqlcommand_a5.Parameters.AddWithValue("@痛经情况", f);

            sqlcommand_a5.Parameters.AddWithValue("@结婚情况", DropDownList51.Text);
            sqlcommand_a5.Parameters.AddWithValue("@结婚年龄", TextBox261.Text);
            sqlcommand_a5.Parameters.AddWithValue("@配偶情况", DropDownList56.Text);
            sqlcommand_a5.Parameters.AddWithValue("@P", TextBox262.Text);
            sqlcommand_a5.Parameters.AddWithValue("@A", TextBox263.Text);
            sqlcommand_a5.Parameters.AddWithValue("@G", TextBox264.Text);
            sqlcommand_a5.Parameters.AddWithValue("@哺乳情况", DropDownList52.Text);
            sqlcommand_a5.Parameters.AddWithValue("@哺乳侧别", TextBox287.Text);
            sqlcommand_a5.Parameters.AddWithValue("@持续时间", TextBox288.Text);
            sqlcommand_a5.Parameters.AddWithValue("@子女情况", DropDownList53.Text);
            sqlcommand_a5.Parameters.AddWithValue("@父亲情况", DropDownList54.Text);
            sqlcommand_a5.Parameters.AddWithValue("@父亲详情", TextBox289.Text);
            sqlcommand_a5.Parameters.AddWithValue("@母亲情况", DropDownList55.Text);
            sqlcommand_a5.Parameters.AddWithValue("@母亲详情", TextBox290.Text);
            sqlcommand_a5.Parameters.AddWithValue("@初潮年龄_分子", TextBox257.Text);
            sqlcommand_a5.Parameters.AddWithValue("@初潮年龄_分母", TextBox260.Text);
            sqlcommand_a5.Parameters.AddWithValue("@家族恶性肿瘤史", DropDownList75.Text);
            sqlcommand_a5.Parameters.AddWithValue("@家族详情", TextBox291.Text);

            try
            {
                sqlconn_a5.Open();
                intUpdateCount_a5 = sqlcommand_a5.ExecuteNonQuery();

                if (sqlcommand_a5.ExecuteNonQuery() > 0)
                {
                    a5LbUpdate.Text = "更新成功";
                }
                else
                {
                    a5LbUpdate.Text = "未更新成功";
                }
            }
            catch (Exception ex) { a5LbUpdate.Text = "错误原因：" + ex.Message; }
            finally
            {
                sqlcommand_a5 = null;
                sqlconn_a5.Close();
                sqlconn_a5 = null;
            }

            //a6页面
            int intUpdateCount_a6;
            SqlConnection sqlconn_a6 = new SqlConnection(sqlconnstr);
            SqlCommand sqlcommand_a6 = new SqlCommand();
            sqlcommand_a6.Connection = sqlconn_a6;
            sqlcommand_a6.CommandText = "update a专科查体 set 乳房皮肤=@乳房皮肤,乳头=@乳头,乳头溢液_有无=@乳头溢液_有无,乳头溢液_主被动=@乳头溢液_主被动,乳头溢液_单多孔=@乳头溢液_单多孔,乳头溢液_血性=@乳头溢液_血性,乳腺肿块=@乳腺肿块,距离乳头=@距离乳头,肿块性质=@肿块性质,边界情况=@边界情况,肿块活动=@肿块活动,胸壁粘连=@胸壁粘连,胸壁固定=@胸壁固定,同侧腋窝=@同侧腋窝,同锁骨上=@同锁骨上,湿疹范围=@湿疹范围,同侧腋窝_数量=@同侧腋窝_数量,同侧腋窝_大小=@同侧腋窝_大小,同侧腋窝_散在=@同侧腋窝_散在,同侧腋窝_活动=@同侧腋窝_活动,同锁骨上_数量=@同锁骨上_数量,同锁骨上_大小=@同锁骨上_大小,同锁骨上_散在=@同锁骨上_散在,同锁骨上_活动=@同锁骨上_活动,对侧腋窝=@对侧腋窝,对侧腋窝_数量=@对侧腋窝_数量,对侧腋窝_大小=@对侧腋窝_大小,对侧腋窝_散在=@对侧腋窝_散在,对侧腋窝_活动=@对侧腋窝_活动,对锁骨上=@对锁骨上,对锁骨上_数量=@对锁骨上_数量,对锁骨上_大小=@对锁骨上_大小,对锁骨上_散在=@对锁骨上_散在,对锁骨上_活动=@对锁骨上_活动,卫星结节个数=@卫星结节个数 where 就诊卡号=@就诊卡号";
            sqlcommand_a6.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

            sqlcommand_a6.Parameters.AddWithValue("@乳房皮肤", DropDownList57.Text);
            sqlcommand_a6.Parameters.AddWithValue("@卫星结节个数", TextBox314.Text);
            sqlcommand_a6.Parameters.AddWithValue("@乳头", DropDownList58.Text);
            string a61 = ""; string a62 = " "; string a63 = "";
            if (CheckBox70.Checked) { a61 = CheckBox70.Text; }
            if (CheckBox71.Checked) { a62 = CheckBox71.Text; }
            if (CheckBox72.Checked) { a63 = CheckBox72.Text; }
            sqlcommand_a6.Parameters.AddWithValue("@湿疹范围", a61 + " " + a62 + " " + a63);
            sqlcommand_a6.Parameters.AddWithValue("@乳头溢液_有无", DropDownList59.Text);
            sqlcommand_a6.Parameters.AddWithValue("@乳头溢液_主被动", DropDownList60.Text);
            sqlcommand_a6.Parameters.AddWithValue("@乳头溢液_单多孔", DropDownList61.Text);
            sqlcommand_a6.Parameters.AddWithValue("@乳头溢液_血性", DropDownList62.Text);
            sqlcommand_a6.Parameters.AddWithValue("@乳腺肿块", DropDownList63.Text);
            sqlcommand_a6.Parameters.AddWithValue("@距离乳头", TextBox292.Text + "+" + TextBox293.Text);
            sqlcommand_a6.Parameters.AddWithValue("@肿块性质", DropDownList64.Text);
            sqlcommand_a6.Parameters.AddWithValue("@边界情况", DropDownList76.Text);
            sqlcommand_a6.Parameters.AddWithValue("@肿块活动", DropDownList77.Text);
            sqlcommand_a6.Parameters.AddWithValue("@胸壁粘连", DropDownList78.Text);
            sqlcommand_a6.Parameters.AddWithValue("@胸壁固定", DropDownList79.Text);

            sqlcommand_a6.Parameters.AddWithValue("@同侧腋窝", DropDownList80.Text);
            sqlcommand_a6.Parameters.AddWithValue("@同侧腋窝_数量", TextBox294.Text);
            sqlcommand_a6.Parameters.AddWithValue("@同侧腋窝_大小", TextBox295.Text);
            sqlcommand_a6.Parameters.AddWithValue("@同侧腋窝_散在", DropDownList81.Text);
            sqlcommand_a6.Parameters.AddWithValue("@同侧腋窝_活动", DropDownList82.Text);

            sqlcommand_a6.Parameters.AddWithValue("@同锁骨上", DropDownList83.Text);
            sqlcommand_a6.Parameters.AddWithValue("@同锁骨上_数量", TextBox296.Text);
            sqlcommand_a6.Parameters.AddWithValue("@同锁骨上_大小", TextBox297.Text);
            sqlcommand_a6.Parameters.AddWithValue("@同锁骨上_散在", DropDownList84.Text);
            sqlcommand_a6.Parameters.AddWithValue("@同锁骨上_活动", DropDownList85.Text);

            sqlcommand_a6.Parameters.AddWithValue("@对侧腋窝", DropDownList86.Text);
            sqlcommand_a6.Parameters.AddWithValue("@对侧腋窝_数量", TextBox298.Text);
            sqlcommand_a6.Parameters.AddWithValue("@对侧腋窝_大小", TextBox299.Text);
            sqlcommand_a6.Parameters.AddWithValue("@对侧腋窝_散在", DropDownList87.Text);
            sqlcommand_a6.Parameters.AddWithValue("@对侧腋窝_活动", DropDownList88.Text);

            sqlcommand_a6.Parameters.AddWithValue("@对锁骨上", DropDownList89.Text);
            sqlcommand_a6.Parameters.AddWithValue("@对锁骨上_数量", TextBox300.Text);
            sqlcommand_a6.Parameters.AddWithValue("@对锁骨上_大小", TextBox301.Text);
            sqlcommand_a6.Parameters.AddWithValue("@对锁骨上_散在", DropDownList90.Text);
            sqlcommand_a6.Parameters.AddWithValue("@对锁骨上_活动", DropDownList91.Text);

            try
            {
                sqlconn_a6.Open();
                intUpdateCount_a6 = sqlcommand_a6.ExecuteNonQuery();

                if (sqlcommand_a6.ExecuteNonQuery() > 0)
                {
                    a6LbUpdate.Text = "更新成功";
                }
                else
                {
                    a6LbUpdate.Text = "未更新成功";
                }
            }
            catch (Exception ex) { a6LbUpdate.Text = "错误原因：" + ex.Message; }
            finally
            {
                sqlcommand_a6 = null;
                sqlconn_a6.Close();
                sqlconn_a6 = null;
            }

            //a7页面
            int intUpdateCount_a7;
            SqlConnection sqlconn_a7 = new SqlConnection(sqlconnstr);
            SqlCommand sqlcommand_a7 = new SqlCommand();
            sqlcommand_a7.Connection = sqlconn_a7;
            sqlcommand_a7.CommandText = "update a其他 set 远处转移_有无=@远处转移_有无,远处转移_情况=@远处转移_情况,T=@T,N=@N,M=@M,辅助检查_有无=@辅助检查_有无,B超=@B超,钼靶=@钼靶,CT=@CT,MRI=@MRI where 就诊卡号=@就诊卡号";
            sqlcommand_a7.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

            sqlcommand_a7.Parameters.AddWithValue("@远处转移_有无", DropDownList65.Text);

            string l1 = ""; string l2 = ""; string l3 = ""; string l4 = ""; string l5 = ""; string l6 = ""; string l7 = ""; string l8 = "";
            if (CheckBox62.Checked) { l1 = CheckBox62.Text; }
            if (CheckBox63.Checked) { l2 = CheckBox63.Text; }
            if (CheckBox64.Checked) { l3 = CheckBox64.Text; }
            if (CheckBox65.Checked) { l4 = CheckBox65.Text; }
            if (CheckBox66.Checked) { l5 = CheckBox66.Text; }
            if (CheckBox67.Checked) { l6 = CheckBox67.Text; }
            if (CheckBox68.Checked) { l7 = CheckBox68.Text; }
            if (CheckBox69.Checked) { l8 = CheckBox69.Text; }
            sqlcommand_a7.Parameters.AddWithValue("@远处转移_情况", l1 + " " + l2 + " " + l3 + " " + l4 + " " + l5 + " " + l6 + " " + l7 + " " + l8);


            sqlcommand_a7.Parameters.AddWithValue("@T", TextBox265.Text);
            sqlcommand_a7.Parameters.AddWithValue("@N", TextBox266.Text);
            sqlcommand_a7.Parameters.AddWithValue("@M", TextBox267.Text);
            sqlcommand_a7.Parameters.AddWithValue("@辅助检查_有无", DropDownList66.Text);
            sqlcommand_a7.Parameters.AddWithValue("@B超", DropDownList92.Text);
            sqlcommand_a7.Parameters.AddWithValue("@钼靶", DropDownList93.Text);
            sqlcommand_a7.Parameters.AddWithValue("@CT", DropDownList94.Text);
            sqlcommand_a7.Parameters.AddWithValue("@MRI", DropDownList95.Text);


            try
            {
                sqlconn_a7.Open();
                intUpdateCount_a7 = sqlcommand_a7.ExecuteNonQuery();

                if (sqlcommand_a7.ExecuteNonQuery() > 0)
                {
                    a7LbUpdate.Text = "更新成功";
                }
                else
                {
                    a7LbUpdate.Text = "未更新成功";
                }
            }
            catch (Exception ex) { a7LbUpdate.Text = "错误原因：" + ex.Message; }
            finally
            {
                sqlcommand_a7 = null;
                sqlconn_a7.Close();
                sqlconn_a7 = null;
            }

            //b1页面
            int intUpdateCount_b1;
            SqlConnection sqlconn_b1 = new SqlConnection(sqlconnstr);
            SqlCommand sqlcommand_b1 = new SqlCommand();
            sqlcommand_b1.Connection = sqlconn_b1;
            sqlcommand_b1.CommandText = "update b术前检查 set 阴阳性=@阴阳性,触诊有无=@触诊有无,触诊个数=@触诊个数,触诊最大_cm=@触诊最大_cm,触诊性质=@触诊性质,超声有无=@超声有无,超声个数=@超声个数,超声最大_cm=@超声最大_cm,超声性质=@超声性质,钼靶有无=@钼靶有无,钼靶个数=@钼靶个数,钼靶最大_cm=@钼靶最大_cm,钼靶性质=@钼靶性质,核磁有无=@核磁有无,核磁个数=@核磁个数,核磁最大_cm=@核磁最大_cm,核磁性质=@核磁性质,临床腋窝分期=@临床腋窝分期,粗针=@粗针,细针=@细针,针号=@针号,标本条数=@标本条数,病理=@病理,免疫=@免疫 where 就诊卡号=@就诊卡号";
            sqlcommand_b1.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

            sqlcommand_b1.Parameters.AddWithValue("@阴阳性", RadioButtonList1.Text);
            sqlcommand_b1.Parameters.AddWithValue("@触诊有无", RadioButtonList2.Text);
            sqlcommand_b1.Parameters.AddWithValue("@触诊个数", TextBox24.Text);
            sqlcommand_b1.Parameters.AddWithValue("@触诊最大_cm", TextBox25.Text);
            sqlcommand_b1.Parameters.AddWithValue("@触诊性质", RadioButtonList3.Text);
            sqlcommand_b1.Parameters.AddWithValue("@超声有无", RadioButtonList4.Text);
            sqlcommand_b1.Parameters.AddWithValue("@超声个数", TextBox26.Text);
            sqlcommand_b1.Parameters.AddWithValue("@超声最大_cm", TextBox27.Text);
            sqlcommand_b1.Parameters.AddWithValue("@超声性质", RadioButtonList5.Text);
            sqlcommand_b1.Parameters.AddWithValue("@钼靶有无", RadioButtonList6.Text);
            sqlcommand_b1.Parameters.AddWithValue("@钼靶个数", TextBox28.Text);
            sqlcommand_b1.Parameters.AddWithValue("@钼靶最大_cm", TextBox29.Text);
            sqlcommand_b1.Parameters.AddWithValue("@钼靶性质", RadioButtonList7.Text);
            sqlcommand_b1.Parameters.AddWithValue("@核磁有无", RadioButtonList8.Text);
            sqlcommand_b1.Parameters.AddWithValue("@核磁个数", TextBox30.Text);
            sqlcommand_b1.Parameters.AddWithValue("@核磁最大_cm", TextBox31.Text);
            sqlcommand_b1.Parameters.AddWithValue("@核磁性质", RadioButtonList9.Text);
            sqlcommand_b1.Parameters.AddWithValue("@临床腋窝分期", DropDownList12.Text);
            sqlcommand_b1.Parameters.AddWithValue("@粗针", TextBox32.Text);
            sqlcommand_b1.Parameters.AddWithValue("@细针", TextBox33.Text);
            sqlcommand_b1.Parameters.AddWithValue("@针号", TextBox34.Text);
            sqlcommand_b1.Parameters.AddWithValue("@标本条数", TextBox35.Text);
            sqlcommand_b1.Parameters.AddWithValue("@病理", TextBox36.Text);
            sqlcommand_b1.Parameters.AddWithValue("@免疫", TextBox37.Text);

            try
            {
                sqlconn_b1.Open();
                intUpdateCount_b1 = sqlcommand_b1.ExecuteNonQuery();

                if (sqlcommand_b1.ExecuteNonQuery() > 0)
                {
                    b1LbUpdate.Text = "更新成功";
                }
                else
                {
                    b1LbUpdate.Text = "未更新成功";
                }
            }
            catch (Exception ex) { b1LbUpdate.Text = "错误原因：" + ex.Message; }
            finally
            {
                sqlcommand_b1 = null;
                sqlconn_b1.Close();
                sqlconn_b1 = null;
            }

            //b2到d2更新
            //b2页面
            int intUpdateCount_b2;
            SqlConnection sqlconn_b2 = new SqlConnection(sqlconnstr);
            SqlCommand sqlcommand_b2 = new SqlCommand();
            sqlcommand_b2.Connection = sqlconn_b2;
            sqlcommand_b2.CommandText = "update b术中实施SLNB set 示踪方法=@示踪方法,示踪方法_联合法=@示踪方法_联合法,示踪药=@示踪药,注射量=@注射量,注射位置=@注射位置,乳晕周点数=@乳晕周点数,肿瘤周点数=@肿瘤周点数,注射层次=@注射层次,注射时间=@注射时间,手术开始时间=@手术开始时间,摘除SLN时间=@摘除SLN时间,发现SLN位置=@发现SLN位置,SLN数目=@SLN数目,SLN类型=@SLN类型,SLN最大直径_长轴=@SLN最大直径_长轴,SLN最大直径_短轴=@SLN最大直径_短轴,SLN最大直径_厚度=@SLN最大直径_厚度,SLN处理方式=@SLN处理方式,SLN病理_冰冻=@SLN病理_冰冻,SLN免疫组化=@SLN免疫组化,SLN免疫组化_其他=@SLN免疫组化_其他,SLNB操作者=@SLNB操作者 where 就诊卡号=@就诊卡号";
            sqlcommand_b2.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

            sqlcommand_b2.Parameters.AddWithValue("@示踪方法", DropDownList13.Text);
            sqlcommand_b2.Parameters.AddWithValue("@示踪方法_联合法", TextBox164.Text);
            sqlcommand_b2.Parameters.AddWithValue("@示踪药", DropDownList14.Text);
            sqlcommand_b2.Parameters.AddWithValue("@注射量", DropDownList15.Text);
            sqlcommand_b2.Parameters.AddWithValue("@注射位置", RadioButtonList10.Text);
            sqlcommand_b2.Parameters.AddWithValue("@乳晕周点数", TextBox38.Text);
            sqlcommand_b2.Parameters.AddWithValue("@肿瘤周点数", TextBox39.Text);
            sqlcommand_b2.Parameters.AddWithValue("@注射层次", DropDownList16.Text);

            sqlcommand_b2.Parameters.AddWithValue("@注射时间", TextBox44.Text.ToString() + " " + TextBox45.Text + ":" + TextBox46.Text + ":" + TextBox47.Text);
            sqlcommand_b2.Parameters.AddWithValue("@手术开始时间", TextBox40.Text.ToString() + " " + TextBox41.Text + ":" + TextBox42.Text + ":" + TextBox43.Text);
            sqlcommand_b2.Parameters.AddWithValue("@摘除SLN时间", TextBox48.Text.ToString() + " " + TextBox49.Text + ":" + TextBox50.Text + ":" + TextBox51.Text);

            sqlcommand_b2.Parameters.AddWithValue("@发现SLN位置", DropDownList17.Text);
            sqlcommand_b2.Parameters.AddWithValue("@SLN数目", DropDownList18.Text);
            sqlcommand_b2.Parameters.AddWithValue("@SLN类型", DropDownList19.Text);
            sqlcommand_b2.Parameters.AddWithValue("@SLN最大直径_长轴", TextBox52.Text);
            sqlcommand_b2.Parameters.AddWithValue("@SLN最大直径_短轴", TextBox53.Text);
            sqlcommand_b2.Parameters.AddWithValue("@SLN最大直径_厚度", TextBox54.Text);
            sqlcommand_b2.Parameters.AddWithValue("@SLN处理方式", DropDownList20.Text);
            sqlcommand_b2.Parameters.AddWithValue("@SLN病理_冰冻", TextBox55.Text);
            sqlcommand_b2.Parameters.AddWithValue("@SLN免疫组化", DropDownList21.Text);
            sqlcommand_b2.Parameters.AddWithValue("@SLN免疫组化_其他", TextBox165.Text);
            sqlcommand_b2.Parameters.AddWithValue("@SLNB操作者", TextBox56.Text);

            try
            {
                sqlconn_b2.Open();
                intUpdateCount_b2 = sqlcommand_b2.ExecuteNonQuery();

                if (sqlcommand_b2.ExecuteNonQuery() > 0)
                {
                    b2LbUpdate.Text = "更新成功";
                }
                else
                {
                    b2LbUpdate.Text = "未更新成功";
                }
            }
            catch (Exception ex) { b2LbUpdate.Text = "错误原因：" + ex.Message; }
            finally
            {
                sqlcommand_b2 = null;
                sqlconn_b2.Close();
                sqlconn_b2 = null;
            }

            //b3页面
            int intUpdateCount_b3;
            SqlConnection sqlconn_b3 = new SqlConnection(sqlconnstr);
            SqlCommand sqlcommand_b3 = new SqlCommand();
            sqlcommand_b3.Connection = sqlconn_b3;
            sqlcommand_b3.CommandText = "update b术中行ARM set 示踪方法=@示踪方法,示踪方法_联合法=@示踪方法_联合法,示踪药=@示踪药,注射量=@注射量,注射位置=@注射位置,注射位置_距离腋窝皱襞=@注射位置_距离腋窝皱襞,注射位置_其它=@注射位置_其它,注射层次=@注射层次,注射时间=@注射时间,手术开始时间=@手术开始时间,摘除ARM时间=@摘除ARM时间,ARM位置=@ARM位置,ARM数目=@ARM数目,SLN类型=@SLN类型,SLN病理_冰冻=@SLN病理_冰冻,操作者=@操作者 where 就诊卡号=@就诊卡号";
            sqlcommand_b3.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

            sqlcommand_b3.Parameters.AddWithValue("@示踪方法", DropDownList22.Text);
            sqlcommand_b3.Parameters.AddWithValue("@示踪方法_联合法", TextBox166.Text);
            sqlcommand_b3.Parameters.AddWithValue("@示踪药", DropDownList23.Text);
            sqlcommand_b3.Parameters.AddWithValue("@注射量", DropDownList24.Text);
            sqlcommand_b3.Parameters.AddWithValue("@注射位置", RadioButtonList11.Text);
            sqlcommand_b3.Parameters.AddWithValue("@注射位置_距离腋窝皱襞", TextBox57.Text);
            sqlcommand_b3.Parameters.AddWithValue("@注射位置_其它", TextBox58.Text);
            sqlcommand_b3.Parameters.AddWithValue("@注射层次", DropDownList25.Text);

            sqlcommand_b3.Parameters.AddWithValue("@注射时间", TextBox59.Text.ToString() + " " + TextBox60.Text + ":" + TextBox61.Text + ":" + TextBox62.Text);
            sqlcommand_b3.Parameters.AddWithValue("@手术开始时间", TextBox63.Text.ToString() + " " + TextBox64.Text + ":" + TextBox65.Text + ":" + TextBox66.Text);
            sqlcommand_b3.Parameters.AddWithValue("@摘除ARM时间", TextBox67.Text.ToString() + " " + TextBox68.Text + ":" + TextBox69.Text + ":" + TextBox70.Text);

            sqlcommand_b3.Parameters.AddWithValue("@ARM位置", DropDownList26.Text);
            sqlcommand_b3.Parameters.AddWithValue("@ARM数目", DropDownList27.Text);
            sqlcommand_b3.Parameters.AddWithValue("@SLN类型", DropDownList28.Text);
            sqlcommand_b3.Parameters.AddWithValue("@SLN病理_冰冻", TextBox74.Text);
            sqlcommand_b3.Parameters.AddWithValue("@操作者", TextBox75.Text);


            try
            {
                sqlconn_b3.Open();
                intUpdateCount_b3 = sqlcommand_b3.ExecuteNonQuery();

                if (sqlcommand_b3.ExecuteNonQuery() > 0)
                {
                    b3LbUpdate.Text = "更新成功";
                }
                else
                {
                    b3LbUpdate.Text = "未更新成功";
                }
            }
            catch (Exception ex) { b3LbUpdate.Text = "错误原因：" + ex.Message; }
            finally
            {
                sqlcommand_b3 = null;
                sqlconn_b3.Close();
                sqlconn_b3 = null;
            }


            //b4页面
            int intUpdateCount_b4;
            SqlConnection sqlconn_b4 = new SqlConnection(sqlconnstr);
            SqlCommand sqlcommand_b4 = new SqlCommand();
            sqlcommand_b4.Connection = sqlconn_b4;
            sqlcommand_b4.CommandText = "update b腋窝状况记录 set SLN病理=@SLN病理,SLN病理_免疫组化=@SLN病理_免疫组化,ARM病理=@ARM病理,ARM病理_免疫组化=@ARM病理_免疫组化,患肢_肘上_术前=@患肢_肘上_术前,患肢_肘上_术后1月=@患肢_肘上_术后1月,患肢_肘上_术后3月=@患肢_肘上_术后3月,患肢_肘上_术后6月=@患肢_肘上_术后6月,患肢_肘上_术后1年=@患肢_肘上_术后1年,患肢_肘上_术后2年=@患肢_肘上_术后2年,对侧肢_肘上_术前=@对侧肢_肘上_术前,对侧肢_肘上_术后1月=@对侧肢_肘上_术后1月,对侧肢_肘上_术后3月=@对侧肢_肘上_术后3月,对侧肢_肘上_术后6月=@对侧肢_肘上_术后6月,对侧肢_肘上_术后1年=@对侧肢_肘上_术后1年,对侧肢_肘上_术后2年=@对侧肢_肘上_术后2年,患肢_肘下_术前=@患肢_肘下_术前,患肢_肘下_术后1月=@患肢_肘下_术后1月,患肢_肘下_术后3月=@患肢_肘下_术后3月,患肢_肘下_术后6月=@患肢_肘下_术后6月,患肢_肘下_术后1年=@患肢_肘下_术后1年,患肢_肘下_术后2年=@患肢_肘下_术后2年,对侧肢_肘下_术前=@对侧肢_肘下_术前,对侧肢_肘下_术后1月=@对侧肢_肘下_术后1月,对侧肢_肘下_术后3月=@对侧肢_肘下_术后3月,对侧肢_肘下_术后6月=@对侧肢_肘下_术后6月,对侧肢_肘下_术后1年=@对侧肢_肘下_术后1年,对侧肢_肘下_术后2年=@对侧肢_肘下_术后2年,患侧_手腕_术前=@患侧_手腕_术前,患侧_手腕_术后1月=@患侧_手腕_术后1月,患侧_手腕_术后3月=@患侧_手腕_术后3月,患侧_手腕_术后6月=@患侧_手腕_术后6月,患侧_手腕_术后1年=@患侧_手腕_术后1年,患侧_手腕_术后2年=@患侧_手腕_术后2年,对侧_手腕_术前=@对侧_手腕_术前,对侧_手腕_术后1月=@对侧_手腕_术后1月,对侧_手腕_术后3月=@对侧_手腕_术后3月,对侧_手腕_术后6月=@对侧_手腕_术后6月,对侧_手腕_术后1年=@对侧_手腕_术后1年,对侧_手腕_术后2年=@对侧_手腕_术后2年,肘上_体重_术前=@肘上_体重_术前,肘上_体重_术后1月=@肘上_体重_术后1月,肘上_体重_术后3月=@肘上_体重_术后3月,肘上_体重_术后6月=@肘上_体重_术后6月,肘上_体重_术后1年=@肘上_体重_术后1年,肘上_体重_术后2年=@肘上_体重_术后2年,肘下_体重_术前=@肘下_体重_术前,肘下_体重_术后1月=@肘下_体重_术后1月,肘下_体重_术后3月=@肘下_体重_术后3月,肘下_体重_术后6月=@肘下_体重_术后6月,肘下_体重_术后1年=@肘下_体重_术后1年,肘下_体重_术后2年=@肘下_体重_术后2年,手腕_体重_术前=@手腕_体重_术前,手腕_体重_术后1月=@手腕_体重_术后1月,手腕_体重_术后3月=@手腕_体重_术后3月,手腕_体重_术后6月=@手腕_体重_术后6月,手腕_体重_术后1年=@手腕_体重_术后1年,手腕_体重_术后2年=@手腕_体重_术后2年 where 就诊卡号=@就诊卡号";
            sqlcommand_b4.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

            sqlcommand_b4.Parameters.AddWithValue("@SLN病理", TextBox71.Text);
            sqlcommand_b4.Parameters.AddWithValue("@SLN病理_免疫组化", TextBox73.Text);
            sqlcommand_b4.Parameters.AddWithValue("@ARM病理", TextBox72.Text);
            sqlcommand_b4.Parameters.AddWithValue("@ARM病理_免疫组化", TextBox76.Text);
            sqlcommand_b4.Parameters.AddWithValue("@患肢_肘上_术前", TextBox77.Text);
            sqlcommand_b4.Parameters.AddWithValue("@患肢_肘上_术后1月", TextBox78.Text);
            sqlcommand_b4.Parameters.AddWithValue("@患肢_肘上_术后3月", TextBox79.Text);
            sqlcommand_b4.Parameters.AddWithValue("@患肢_肘上_术后6月", TextBox80.Text);
            sqlcommand_b4.Parameters.AddWithValue("@患肢_肘上_术后1年", TextBox81.Text);
            sqlcommand_b4.Parameters.AddWithValue("@患肢_肘上_术后2年", TextBox82.Text);
            sqlcommand_b4.Parameters.AddWithValue("@对侧肢_肘上_术前", TextBox83.Text);
            sqlcommand_b4.Parameters.AddWithValue("@对侧肢_肘上_术后1月", TextBox84.Text);
            sqlcommand_b4.Parameters.AddWithValue("@对侧肢_肘上_术后3月", TextBox85.Text);
            sqlcommand_b4.Parameters.AddWithValue("@对侧肢_肘上_术后6月", TextBox86.Text);
            sqlcommand_b4.Parameters.AddWithValue("@对侧肢_肘上_术后1年", TextBox87.Text);
            sqlcommand_b4.Parameters.AddWithValue("@对侧肢_肘上_术后2年", TextBox88.Text);
            sqlcommand_b4.Parameters.AddWithValue("@患肢_肘下_术前", TextBox95.Text);
            sqlcommand_b4.Parameters.AddWithValue("@患肢_肘下_术后1月", TextBox96.Text);
            sqlcommand_b4.Parameters.AddWithValue("@患肢_肘下_术后3月", TextBox97.Text);
            sqlcommand_b4.Parameters.AddWithValue("@患肢_肘下_术后6月", TextBox98.Text);
            sqlcommand_b4.Parameters.AddWithValue("@患肢_肘下_术后1年", TextBox99.Text);
            sqlcommand_b4.Parameters.AddWithValue("@患肢_肘下_术后2年", TextBox100.Text);
            sqlcommand_b4.Parameters.AddWithValue("@对侧肢_肘下_术前", TextBox101.Text);
            sqlcommand_b4.Parameters.AddWithValue("@对侧肢_肘下_术后1月", TextBox102.Text);
            sqlcommand_b4.Parameters.AddWithValue("@对侧肢_肘下_术后3月", TextBox103.Text);
            sqlcommand_b4.Parameters.AddWithValue("@对侧肢_肘下_术后6月", TextBox104.Text);
            sqlcommand_b4.Parameters.AddWithValue("@对侧肢_肘下_术后1年", TextBox105.Text);
            sqlcommand_b4.Parameters.AddWithValue("@对侧肢_肘下_术后2年", TextBox106.Text);
            sqlcommand_b4.Parameters.AddWithValue("@患侧_手腕_术前", TextBox113.Text);
            sqlcommand_b4.Parameters.AddWithValue("@患侧_手腕_术后1月", TextBox114.Text);
            sqlcommand_b4.Parameters.AddWithValue("@患侧_手腕_术后3月", TextBox115.Text);
            sqlcommand_b4.Parameters.AddWithValue("@患侧_手腕_术后6月", TextBox116.Text);
            sqlcommand_b4.Parameters.AddWithValue("@患侧_手腕_术后1年", TextBox117.Text);
            sqlcommand_b4.Parameters.AddWithValue("@患侧_手腕_术后2年", TextBox118.Text);
            sqlcommand_b4.Parameters.AddWithValue("@对侧_手腕_术前", TextBox119.Text);
            sqlcommand_b4.Parameters.AddWithValue("@对侧_手腕_术后1月", TextBox120.Text);
            sqlcommand_b4.Parameters.AddWithValue("@对侧_手腕_术后3月", TextBox121.Text);
            sqlcommand_b4.Parameters.AddWithValue("@对侧_手腕_术后6月", TextBox122.Text);
            sqlcommand_b4.Parameters.AddWithValue("@对侧_手腕_术后1年", TextBox123.Text);
            sqlcommand_b4.Parameters.AddWithValue("@对侧_手腕_术后2年", TextBox124.Text);
            sqlcommand_b4.Parameters.AddWithValue("@肘上_体重_术前", TextBox89.Text);
            sqlcommand_b4.Parameters.AddWithValue("@肘上_体重_术后1月", TextBox90.Text);
            sqlcommand_b4.Parameters.AddWithValue("@肘上_体重_术后3月", TextBox91.Text);
            sqlcommand_b4.Parameters.AddWithValue("@肘上_体重_术后6月", TextBox92.Text);
            sqlcommand_b4.Parameters.AddWithValue("@肘上_体重_术后1年", TextBox93.Text);
            sqlcommand_b4.Parameters.AddWithValue("@肘上_体重_术后2年", TextBox94.Text);
            sqlcommand_b4.Parameters.AddWithValue("@肘下_体重_术前", TextBox107.Text);
            sqlcommand_b4.Parameters.AddWithValue("@肘下_体重_术后1月", TextBox108.Text);
            sqlcommand_b4.Parameters.AddWithValue("@肘下_体重_术后3月", TextBox109.Text);
            sqlcommand_b4.Parameters.AddWithValue("@肘下_体重_术后6月", TextBox110.Text);
            sqlcommand_b4.Parameters.AddWithValue("@肘下_体重_术后1年", TextBox111.Text);
            sqlcommand_b4.Parameters.AddWithValue("@肘下_体重_术后2年", TextBox112.Text);
            sqlcommand_b4.Parameters.AddWithValue("@手腕_体重_术前", TextBox125.Text);
            sqlcommand_b4.Parameters.AddWithValue("@手腕_体重_术后1月", TextBox126.Text);
            sqlcommand_b4.Parameters.AddWithValue("@手腕_体重_术后3月", TextBox127.Text);
            sqlcommand_b4.Parameters.AddWithValue("@手腕_体重_术后6月", TextBox128.Text);
            sqlcommand_b4.Parameters.AddWithValue("@手腕_体重_术后1年", TextBox129.Text);
            sqlcommand_b4.Parameters.AddWithValue("@手腕_体重_术后2年", TextBox130.Text);

            try
            {
                sqlconn_b4.Open();
                intUpdateCount_b4 = sqlcommand_b4.ExecuteNonQuery();

                if (sqlcommand_b4.ExecuteNonQuery() > 0)
                {
                    b4LbUpdate.Text = "更新成功";
                }
                else
                {
                    b4LbUpdate.Text = "未更新成功";
                }
            }
            catch (Exception ex) { b4LbUpdate.Text = "错误原因：" + ex.Message; }
            finally
            {
                sqlcommand_b4 = null;
                sqlconn_b4.Close();
                sqlconn_b4 = null;
            }

            //c1页面
            int intUpdateCount_c1;
            SqlConnection sqlconn_c1 = new SqlConnection(sqlconnstr);
            SqlCommand sqlcommand_c1 = new SqlCommand();
            sqlcommand_c1.Connection = sqlconn_c1;
            sqlcommand_c1.CommandText = "update c术前化疗 set 新辅助化疗=@新辅助化疗,化疗周期=@化疗周期,第1周方案_第1项=@第1周方案_第1项,第1周方案_第1项_毫克数=@第1周方案_第1项_毫克数,第1周方案_第2项=@第1周方案_第2项,第1周方案_第2项_毫克数=@第1周方案_第2项_毫克数,第1周方案_第3项=@第1周方案_第3项,第1周方案_第3项_毫克数=@第1周方案_第3项_毫克数,第1周方案_日期=@第1周方案_日期,化疗后评估次数=@化疗后评估次数,第1次评估_日期=@第1次评估_日期,RECIST评估=@RECIST评估,备注=@备注 where 就诊卡号=@就诊卡号";
            sqlcommand_c1.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

            string c1_a = "";
            if (RadioButton150.Checked) { c1_a = RadioButton150.Text; }
            if (RadioButton151.Checked) { c1_a = RadioButton151.Text; }
            sqlcommand_c1.Parameters.AddWithValue("@新辅助化疗", c1_a);

            sqlcommand_c1.Parameters.AddWithValue("@化疗周期", TextBox68.Text);
            sqlcommand_c1.Parameters.AddWithValue("@第1周方案_第1项", DropDownList67.Text);
            sqlcommand_c1.Parameters.AddWithValue("@第1周方案_第1项_毫克数", TextBox269.Text);
            sqlcommand_c1.Parameters.AddWithValue("@第1周方案_第2项", DropDownList68.Text);
            sqlcommand_c1.Parameters.AddWithValue("@第1周方案_第2项_毫克数", TextBox270.Text);
            sqlcommand_c1.Parameters.AddWithValue("@第1周方案_第3项", DropDownList69.Text);
            sqlcommand_c1.Parameters.AddWithValue("@第1周方案_第3项_毫克数", TextBox271.Text);
            sqlcommand_c1.Parameters.AddWithValue("@第1周方案_日期", TextBox272.Text);
            sqlcommand_c1.Parameters.AddWithValue("@化疗后评估次数", TextBox273.Text);
            sqlcommand_c1.Parameters.AddWithValue("@第1次评估_日期", TextBox274.Text);
            sqlcommand_c1.Parameters.AddWithValue("@RECIST评估", DropDownList70.Text);
            sqlcommand_c1.Parameters.AddWithValue("@备注", TextBox275.Text);

            try
            {
                sqlconn_c1.Open();
                intUpdateCount_c1 = sqlcommand_c1.ExecuteNonQuery();

                if (sqlcommand_c1.ExecuteNonQuery() > 0)
                {
                    c1LbUpdate.Text = "更新成功";
                }
                else
                {
                    c1LbUpdate.Text = "未更新成功";
                }
            }
            catch (Exception ex) { c1LbUpdate.Text = "错误原因：" + ex.Message; }
            finally
            {
                sqlcommand_c1 = null;
                sqlconn_c1.Close();
                sqlconn_c1 = null;
            }

            //c2页面
            int intUpdateCount_c2;
            SqlConnection sqlconn_c2 = new SqlConnection(sqlconnstr);
            SqlCommand sqlcommand_c2 = new SqlCommand();
            sqlcommand_c2.Connection = sqlconn_c2;
            sqlcommand_c2.CommandText = "update c术后化疗 set 术后辅助化疗=@术后辅助化疗,化疗周期=@化疗周期,第1周方案_第1项=@第1周方案_第1项,第1周方案_第1项_毫克数=@第1周方案_第1项_毫克数,第1周方案_第2项=@第1周方案_第2项,第1周方案_第2项_毫克数=@第1周方案_第2项_毫克数,第1周方案_第3项=@第1周方案_第3项,第1周方案_第3项_毫克数=@第1周方案_第3项_毫克数,第1周方案_日期=@第1周方案_日期,不良反应=@不良反应,血液系统=@血液系统,表现=@表现,处理=@处理 where 就诊卡号=@就诊卡号";
            sqlcommand_c2.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

            string c2_a = "";
            if (RadioButton152.Checked) { c2_a = RadioButton152.Text; }
            if (RadioButton153.Checked) { c2_a = RadioButton153.Text; }
            sqlcommand_c2.Parameters.AddWithValue("@术后辅助化疗", c2_a);

            sqlcommand_c2.Parameters.AddWithValue("@化疗周期", TextBox276.Text);
            sqlcommand_c2.Parameters.AddWithValue("@第1周方案_第1项", DropDownList71.Text);
            sqlcommand_c2.Parameters.AddWithValue("@第1周方案_第1项_毫克数", TextBox277.Text);
            sqlcommand_c2.Parameters.AddWithValue("@第1周方案_第2项", DropDownList72.Text);
            sqlcommand_c2.Parameters.AddWithValue("@第1周方案_第2项_毫克数", TextBox278.Text);
            sqlcommand_c2.Parameters.AddWithValue("@第1周方案_第3项", DropDownList73.Text);
            sqlcommand_c2.Parameters.AddWithValue("@第1周方案_第3项_毫克数", TextBox279.Text);
            sqlcommand_c2.Parameters.AddWithValue("@第1周方案_日期", TextBox280.Text);

            string c2_b1 = ""; string c2_b2 = ""; string c2_b3 = ""; string c2_b4 = ""; string c2_b5 = ""; string c2_b6 = ""; string c2_b7 = "";
            if (CheckBox55.Checked) { c2_b1 = CheckBox55.Text; }
            if (CheckBox56.Checked) { c2_b2 = CheckBox56.Text; }
            if (CheckBox57.Checked) { c2_b3 = CheckBox57.Text; }
            if (CheckBox58.Checked) { c2_b4 = CheckBox58.Text; }
            if (CheckBox59.Checked) { c2_b5 = CheckBox59.Text; }
            if (CheckBox60.Checked) { c2_b6 = CheckBox60.Text; }
            if (CheckBox61.Checked) { c2_b7 = CheckBox61.Text; }
            sqlcommand_c2.Parameters.AddWithValue("@不良反应", c2_b1 + " " + c2_b2 + " " + c2_b3 + " " + c2_b4 + " " + c2_b5 + " " + c2_b6 + " " + c2_b7);
            sqlcommand_c2.Parameters.AddWithValue("@血液系统", DropDownList74.Text);
            sqlcommand_c2.Parameters.AddWithValue("@表现", TextBox281.Text);
            sqlcommand_c2.Parameters.AddWithValue("@处理", TextBox282.Text);
            try
            {
                sqlconn_c2.Open();
                intUpdateCount_c2 = sqlcommand_c2.ExecuteNonQuery();

                if (sqlcommand_c2.ExecuteNonQuery() > 0)
                {
                    c2LbUpdate.Text = "更新成功";
                }
                else
                {
                    c2LbUpdate.Text = "未更新成功";
                }
            }
            catch (Exception ex) { c2LbUpdate.Text = "错误原因：" + ex.Message; }
            finally
            {
                sqlcommand_c2 = null;
                sqlconn_c2.Close();
                sqlconn_c2 = null;
            }


            //d1页面
            int intUpdateCount_d1;
            SqlConnection sqlconn_d1 = new SqlConnection(sqlconnstr);
            SqlCommand sqlcommand_d1 = new SqlCommand();
            sqlcommand_d1.Connection = sqlconn_d1;
            sqlcommand_d1.CommandText = "update d一般 set 病理=@病理,淋巴结=@淋巴结,分子类型=@分子类型,是否化疗=@是否化疗,化疗详情=@化疗详情,是否放疗=@是否放疗,放疗详情=@放疗详情,是否内分泌=@是否内分泌,内分泌详情=@内分泌详情,是否靶向=@是否靶向,靶向详情=@靶向详情,是否生物治疗=@是否生物治疗,生物治疗情况=@生物治疗情况 where 就诊卡号=@就诊卡号";
            sqlcommand_d1.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

            sqlcommand_d1.Parameters.AddWithValue("@病理", TextBox131.Text);
            sqlcommand_d1.Parameters.AddWithValue("@淋巴结", TextBox132.Text);
            sqlcommand_d1.Parameters.AddWithValue("@分子类型", TextBox133.Text);
            sqlcommand_d1.Parameters.AddWithValue("@是否化疗", CheckBox1.Checked);
            sqlcommand_d1.Parameters.AddWithValue("@化疗详情", TextBox134.Text);
            sqlcommand_d1.Parameters.AddWithValue("@是否放疗", CheckBox2.Checked);
            sqlcommand_d1.Parameters.AddWithValue("@放疗详情", TextBox135.Text);
            sqlcommand_d1.Parameters.AddWithValue("@是否内分泌", CheckBox3.Checked);
            sqlcommand_d1.Parameters.AddWithValue("@内分泌详情", TextBox136.Text);
            sqlcommand_d1.Parameters.AddWithValue("@是否靶向", CheckBox4.Checked);
            sqlcommand_d1.Parameters.AddWithValue("@靶向详情", TextBox137.Text);
            sqlcommand_d1.Parameters.AddWithValue("@是否生物治疗", CheckBox5.Checked);
            sqlcommand_d1.Parameters.AddWithValue("@生物治疗情况", TextBox138.Text); try
            {
                sqlconn_d1.Open();
                intUpdateCount_d1 = sqlcommand_d1.ExecuteNonQuery();

                if (sqlcommand_d1.ExecuteNonQuery() > 0)
                {
                    d1LbUpdate.Text = "更新成功";
                }
                else
                {
                    d1LbUpdate.Text = "未更新成功";
                }
            }
            catch (Exception ex) { d1LbUpdate.Text = "错误原因：" + ex.Message; }
            finally
            {
                sqlcommand_d1 = null;
                sqlconn_d1.Close();
                sqlconn_d1 = null;
            }

            //d2页面
            int intUpdateCount_d2;
            SqlConnection sqlconn_d2 = new SqlConnection(sqlconnstr);
            SqlCommand sqlcommand_d2 = new SqlCommand();
            sqlcommand_d2.Connection = sqlconn_d2;
            sqlcommand_d2.CommandText = "update d乳腺复发转移 set 术后时间=@术后时间,胸壁_是否正常=@胸壁_是否正常,胸壁_异常详情=@胸壁_异常详情,胸壁_对侧_是否正常=@胸壁_对侧_是否正常,胸壁_对侧_异常详情=@胸壁_对侧_异常详情,腋下_是否正常=@腋下_是否正常,腋下_异常详情=@腋下_异常详情,腋下_对侧_是否正常=@腋下_对侧_是否正常,腋下_对侧_异常详情=@腋下_对侧_异常详情,胸片_是否正常=@胸片_是否正常,胸片_异常详情=@胸片_异常详情,胸片_是否进一步检查=@胸片_是否进一步检查,胸片_进一步检查详情=@胸片_进一步检查详情,胸片_是否复查=@胸片_是否复查,胸片_复查月=@胸片_复查月,BUS_是否正常=@BUS_是否正常,BUS_异常详情=@BUS_异常详情,BUS_是否进一步检查=@BUS_是否进一步检查,BUS_进一步检查详情=@BUS_进一步检查详情,BUS_是否复查=@BUS_是否复查,BUS_复查月=@BUS_复查月,肿瘤标志物_是否正常=@肿瘤标志物_是否正常,肿瘤标志物_异常详情=@肿瘤标志物_异常详情,肿瘤标志物_是否进一步检查=@肿瘤标志物_是否进一步检查,肿瘤标志物_进一步检查详情=@肿瘤标志物_进一步检查详情,肿瘤标志物_是否复查=@肿瘤标志物_是否复查,肿瘤标志物_复查月=@肿瘤标志物_复查月,CT_是否正常=@CT_是否正常,CT_异常详情=@CT_异常详情,CT_是否进一步检查=@CT_是否进一步检查,CT_进一步检查详情=@CT_进一步检查详情,CT_是否复查=@CT_是否复查,CT_复查月=@CT_复查月,ECT_是否正常=@ECT_是否正常,ECT_异常详情=@ECT_异常详情,ECT_是否进一步检查=@ECT_是否进一步检查,ECT_进一步检查详情=@ECT_进一步检查详情,ECT_是否复查=@ECT_是否复查,ECT_复查月=@ECT_复查月,PET_CT_是否正常=@PET_CT_是否正常,PET_CT_异常详情=@PET_CT_异常详情,PET_CT_是否进一步检查=@PET_CT_是否进一步检查,PET_CT_进一步检查详情=@PET_CT_进一步检查详情,PET_CT_是否复查=@PET_CT_是否复查,PET_CT_复查月=@PET_CT_复查月,结论_是否正常=@结论_是否正常,结论_是否复发或转移=@结论_是否复发或转移,复发或转移详情=@复发或转移详情,治疗=@治疗 where 就诊卡号=@就诊卡号";
            sqlcommand_d2.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

            sqlcommand_d2.Parameters.AddWithValue("@术后时间", TextBox139.Text + DropDownList29.Text);
            sqlcommand_d2.Parameters.AddWithValue("@胸壁_是否正常", RadioButtonList17.Text);
            sqlcommand_d2.Parameters.AddWithValue("@胸壁_异常详情", TextBox140.Text);
            sqlcommand_d2.Parameters.AddWithValue("@胸壁_对侧_是否正常", RadioButtonList18.Text);
            sqlcommand_d2.Parameters.AddWithValue("@胸壁_对侧_异常详情", TextBox145.Text);
            sqlcommand_d2.Parameters.AddWithValue("@腋下_是否正常", RadioButtonList15.Text);
            sqlcommand_d2.Parameters.AddWithValue("@腋下_异常详情", TextBox142.Text);
            sqlcommand_d2.Parameters.AddWithValue("@腋下_对侧_是否正常", RadioButtonList16.Text);
            sqlcommand_d2.Parameters.AddWithValue("@腋下_对侧_异常详情", TextBox144.Text);
            sqlcommand_d2.Parameters.AddWithValue("@胸片_是否正常", RadioButtonList13.Text);
            sqlcommand_d2.Parameters.AddWithValue("@胸片_异常详情", TextBox141.Text);
            if (CheckBox6.Checked) { sqlcommand_d2.Parameters.AddWithValue("@胸片_是否进一步检查", "是"); } else { sqlcommand_d2.Parameters.AddWithValue("@胸片_是否进一步检查", "否"); }
            sqlcommand_d2.Parameters.AddWithValue("@胸片_进一步检查详情", TextBox143.Text);
            if (CheckBox7.Checked) { sqlcommand_d2.Parameters.AddWithValue("@胸片_是否复查", "是"); } else { sqlcommand_d2.Parameters.AddWithValue("@胸片_是否复查", "否"); }
            sqlcommand_d2.Parameters.AddWithValue("@胸片_复查月", TextBox146.Text);
            sqlcommand_d2.Parameters.AddWithValue("@BUS_是否正常", RadioButtonList14.Text);
            sqlcommand_d2.Parameters.AddWithValue("@BUS_异常详情", TextBox147.Text);
            if (CheckBox8.Checked) { sqlcommand_d2.Parameters.AddWithValue("@BUS_是否进一步检查", "是"); } else { sqlcommand_d2.Parameters.AddWithValue("@BUS_是否进一步检查", "否"); }
            sqlcommand_d2.Parameters.AddWithValue("@BUS_进一步检查详情", TextBox148.Text);
            if (CheckBox9.Checked) { sqlcommand_d2.Parameters.AddWithValue("@BUS_是否复查", "是"); } else { sqlcommand_d2.Parameters.AddWithValue("@BUS_是否复查", "否"); }
            sqlcommand_d2.Parameters.AddWithValue("@BUS_复查月", TextBox149.Text);
            sqlcommand_d2.Parameters.AddWithValue("@肿瘤标志物_是否正常", RadioButtonList19.Text);
            sqlcommand_d2.Parameters.AddWithValue("@肿瘤标志物_异常详情", TextBox150.Text);
            if (CheckBox10.Checked) { sqlcommand_d2.Parameters.AddWithValue("@肿瘤标志物_是否进一步检查", "是"); } else { sqlcommand_d2.Parameters.AddWithValue("@肿瘤标志物_是否进一步检查", "否"); }
            sqlcommand_d2.Parameters.AddWithValue("@肿瘤标志物_进一步检查详情", TextBox151.Text);
            if (CheckBox9.Checked) { sqlcommand_d2.Parameters.AddWithValue("@肿瘤标志物_是否复查", "是"); } else { sqlcommand_d2.Parameters.AddWithValue("@肿瘤标志物_是否复查", "否"); }
            sqlcommand_d2.Parameters.AddWithValue("@肿瘤标志物_复查月", TextBox152.Text);
            sqlcommand_d2.Parameters.AddWithValue("@CT_是否正常", RadioButtonList20.Text);
            sqlcommand_d2.Parameters.AddWithValue("@CT_异常详情", TextBox153.Text);
            if (CheckBox12.Checked) { sqlcommand_d2.Parameters.AddWithValue("@CT_是否进一步检查", "是"); } else { sqlcommand_d2.Parameters.AddWithValue("@CT_是否进一步检查", "否"); }
            sqlcommand_d2.Parameters.AddWithValue("@CT_进一步检查详情", TextBox154.Text);
            if (CheckBox13.Checked) { sqlcommand_d2.Parameters.AddWithValue("@CT_是否复查", "是"); } else { sqlcommand_d2.Parameters.AddWithValue("@CT_是否复查", "否"); }
            sqlcommand_d2.Parameters.AddWithValue("@CT_复查月", TextBox155.Text);
            sqlcommand_d2.Parameters.AddWithValue("@ECT_是否正常", RadioButtonList21.Text);
            sqlcommand_d2.Parameters.AddWithValue("@ECT_异常详情", TextBox2.Text);
            if (CheckBox14.Checked) { sqlcommand_d2.Parameters.AddWithValue("@ECT_是否进一步检查", "是"); } else { sqlcommand_d2.Parameters.AddWithValue("@ECT_是否进一步检查", "否"); }
            sqlcommand_d2.Parameters.AddWithValue("@ECT_进一步检查详情", TextBox157.Text);
            if (CheckBox15.Checked) { sqlcommand_d2.Parameters.AddWithValue("@ECT_是否复查", "是"); } else { sqlcommand_d2.Parameters.AddWithValue("@ECT_是否复查", "否"); }
            sqlcommand_d2.Parameters.AddWithValue("@ECT_复查月", TextBox158.Text);
            sqlcommand_d2.Parameters.AddWithValue("@PET_CT_是否正常", RadioButtonList22.Text);
            sqlcommand_d2.Parameters.AddWithValue("@PET_CT_异常详情", TextBox159.Text);
            if (CheckBox16.Checked) { sqlcommand_d2.Parameters.AddWithValue("@PET_CT_是否进一步检查", "是"); } else { sqlcommand_d2.Parameters.AddWithValue("@PET_CT_是否进一步检查", "否"); }
            sqlcommand_d2.Parameters.AddWithValue("@PET_CT_进一步检查详情", TextBox160.Text);
            if (CheckBox17.Checked) { sqlcommand_d2.Parameters.AddWithValue("@PET_CT_是否复查", "是"); } else { sqlcommand_d2.Parameters.AddWithValue("@PET_CT_是否复查", "否"); }
            sqlcommand_d2.Parameters.AddWithValue("@PET_CT_复查月", TextBox161.Text);
            sqlcommand_d2.Parameters.AddWithValue("@结论_是否正常", RadioButtonList23.Text);
            sqlcommand_d2.Parameters.AddWithValue("@结论_是否复发或转移", DropDownList30.Text);
            sqlcommand_d2.Parameters.AddWithValue("@复发或转移详情", TextBox162.Text);
            sqlcommand_d2.Parameters.AddWithValue("@治疗", TextBox163.Text); try
            {
                sqlconn_d2.Open();
                intUpdateCount_d2 = sqlcommand_d2.ExecuteNonQuery();

                if (sqlcommand_d2.ExecuteNonQuery() > 0)
                {
                    d2LbUpdate.Text = "更新成功";
                }
                else
                {
                    d2LbUpdate.Text = "未更新成功";
                }
            }
            catch (Exception ex) { d2LbUpdate.Text = "错误原因：" + ex.Message; }
            finally
            {
                sqlcommand_d2 = null;
                sqlconn_d2.Close();
                sqlconn_d2 = null;
            }

            //d3到f3更新
            //
            //d3页面
            //
            int intUpdateCount_d3;
            SqlConnection sqlconn_d3 = new SqlConnection(sqlconnstr);
            SqlCommand sqlcommand_d3 = new SqlCommand();
            sqlcommand_d3.Connection = sqlconn_d3;
            sqlcommand_d3.CommandText = "update d诊疗异常反应 set UCG_正常=@UCG_正常,UCG_异常=@UCG_异常,UCG_异常内容=@UCG_异常内容,UCG_结论=@UCG_结论,UCG_建议=@UCG_建议,肝肾功_正常=@肝肾功_正常,肝肾功_异常=@肝肾功_异常,肝肾功_异常内容=@肝肾功_异常内容,肝肾功_结论=@肝肾功_结论,肝肾功_建议=@肝肾功_建议,血糖_正常=@血糖_正常,血糖_异常=@血糖_异常,血糖_异常内容=@血糖_异常内容,血糖_结论=@血糖_结论,血糖_建议=@血糖_建议,血脂_正常=@血脂_正常,血脂_异常=@血脂_异常,血脂_异常内容=@血脂_异常内容,血脂_结论=@血脂_结论,血脂_建议=@血脂_建议,骨密度_正常=@骨密度_正常,骨密度_异常=@骨密度_异常,骨密度_异常内容=@骨密度_异常内容,骨密度_结论=@骨密度_结论,骨密度_建议=@骨密度_建议,激素水平_未绝经=@激素水平_未绝经,激素水平_绝经=@激素水平_绝经,激素水平_更换内分泌药=@激素水平_更换内分泌药 where 就诊卡号=@就诊卡号";
            sqlcommand_d3.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

            sqlcommand_d3.Parameters.AddWithValue("@UCG_正常", RadioButton26.Text);
            sqlcommand_d3.Parameters.AddWithValue("@UCG_异常", RadioButton27.Text);
            sqlcommand_d3.Parameters.AddWithValue("@UCG_异常内容", TextBox203.Text);
            sqlcommand_d3.Parameters.AddWithValue("@UCG_结论", TextBox204.Text);
            sqlcommand_d3.Parameters.AddWithValue("@UCG_建议", TextBox205.Text);
            sqlcommand_d3.Parameters.AddWithValue("@肝肾功_正常", RadioButton28.Text);
            sqlcommand_d3.Parameters.AddWithValue("@肝肾功_异常", RadioButton29.Text);
            sqlcommand_d3.Parameters.AddWithValue("@肝肾功_异常内容", TextBox206.Text);
            sqlcommand_d3.Parameters.AddWithValue("@肝肾功_结论", TextBox207.Text);
            sqlcommand_d3.Parameters.AddWithValue("@肝肾功_建议", TextBox208.Text);
            sqlcommand_d3.Parameters.AddWithValue("@血糖_正常", RadioButton30.Text);
            sqlcommand_d3.Parameters.AddWithValue("@血糖_异常", RadioButton31.Text);
            sqlcommand_d3.Parameters.AddWithValue("@血糖_异常内容", TextBox209.Text);
            sqlcommand_d3.Parameters.AddWithValue("@血糖_结论", TextBox210.Text);
            sqlcommand_d3.Parameters.AddWithValue("@血糖_建议", TextBox211.Text);
            sqlcommand_d3.Parameters.AddWithValue("@血脂_正常", RadioButton32.Text);
            sqlcommand_d3.Parameters.AddWithValue("@血脂_异常", RadioButton33.Text);
            sqlcommand_d3.Parameters.AddWithValue("@血脂_异常内容", TextBox212.Text);
            sqlcommand_d3.Parameters.AddWithValue("@血脂_结论", TextBox213.Text);
            sqlcommand_d3.Parameters.AddWithValue("@血脂_建议", TextBox214.Text);
            sqlcommand_d3.Parameters.AddWithValue("@骨密度_正常", RadioButton34.Text);
            sqlcommand_d3.Parameters.AddWithValue("@骨密度_异常", RadioButton35.Text);
            sqlcommand_d3.Parameters.AddWithValue("@骨密度_异常内容", TextBox215.Text);
            sqlcommand_d3.Parameters.AddWithValue("@骨密度_结论", TextBox216.Text);
            sqlcommand_d3.Parameters.AddWithValue("@骨密度_建议", TextBox217.Text);
            sqlcommand_d3.Parameters.AddWithValue("@激素水平_未绝经", RadioButton36.Text);
            sqlcommand_d3.Parameters.AddWithValue("@激素水平_绝经", RadioButton37.Text);
            sqlcommand_d3.Parameters.AddWithValue("@激素水平_更换内分泌药", TextBox218.Text);


            try
            {
                sqlconn_d3.Open();
                intUpdateCount_d3 = sqlcommand_d3.ExecuteNonQuery();

                if (sqlcommand_d3.ExecuteNonQuery() > 0)
                {
                    d3LbUpdate.Text = "更新成功";
                }
                else
                {
                    d3LbUpdate.Text = "未更新成功";
                }
            }
            catch (Exception ex) { d3LbUpdate.Text = ex.Message; }
            finally
            {
                sqlcommand_d3 = null;
                sqlconn_d3.Close();
                sqlconn_d3 = null;
            }
            //
            //e1页面
            //
            int intUpdateCount_e1;
            SqlConnection sqlconn_e1 = new SqlConnection(sqlconnstr);
            SqlCommand sqlcommand_e1 = new SqlCommand();
            sqlcommand_e1.Connection = sqlconn_e1;
            sqlcommand_e1.CommandText = "update e根治信息 set 手术方式=@手术方式,术前诊断=@术前诊断,切口设计=@切口设计,切口设计_cm=@切口设计_cm,皮下打水=@皮下打水,分离皮瓣范围_上至=@分离皮瓣范围_上至,分离皮瓣范围_下至=@分离皮瓣范围_下至,分离皮瓣范围_内至=@分离皮瓣范围_内至,分离皮瓣范围_外至=@分离皮瓣范围_外至,厚度=@厚度,全乳切除=@全乳切除,胸肌受累=@胸肌受累,胸大肌部分切=@胸大肌部分切 where 就诊卡号=@就诊卡号";

            sqlcommand_e1.Parameters.AddWithValue("@手术方式", RadioButtonList24.Text);
            sqlcommand_e1.Parameters.AddWithValue("@术前诊断", RadioButtonList25.Text);
            sqlcommand_e1.Parameters.AddWithValue("@切口设计", RadioButtonList26.Text);
            sqlcommand_e1.Parameters.AddWithValue("@切口设计_cm", TextBox219.Text);
            sqlcommand_e1.Parameters.AddWithValue("@皮下打水", RadioButtonList27.Text);
            sqlcommand_e1.Parameters.AddWithValue("@分离皮瓣范围_上至", TextBox220.Text);
            sqlcommand_e1.Parameters.AddWithValue("@分离皮瓣范围_下至", TextBox221.Text);
            sqlcommand_e1.Parameters.AddWithValue("@分离皮瓣范围_内至", TextBox222.Text);
            sqlcommand_e1.Parameters.AddWithValue("@分离皮瓣范围_外至", TextBox223.Text);
            sqlcommand_e1.Parameters.AddWithValue("@厚度", RadioButtonList28.Text);
            sqlcommand_e1.Parameters.AddWithValue("@全乳切除", RadioButtonList29.Text);
            sqlcommand_e1.Parameters.AddWithValue("@胸肌受累", RadioButtonList30.Text);
            sqlcommand_e1.Parameters.AddWithValue("@胸大肌部分切", RadioButtonList31.Text);
            sqlcommand_e1.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

            try
            {
                sqlconn_e1.Open();
                intUpdateCount_e1 = sqlcommand_e1.ExecuteNonQuery();

                if (sqlcommand_e1.ExecuteNonQuery() > 0)
                {
                    e1LbUpdate.Text = "更新成功";
                }
                else
                {
                    e1LbUpdate.Text = "未更新成功";
                }
            }
            catch (Exception ex) { e1LbUpdate.Text = "错误原因：" + ex.Message; }
            finally
            {
                sqlcommand_e1 = null;
                sqlconn_e1.Close();
                sqlconn_e1 = null;

            }
            //
            //e2页面
            //
            int intUpdateCount_e2;
            SqlConnection sqlconn_e2 = new SqlConnection(sqlconnstr);
            SqlCommand sqlcommand_e2 = new SqlCommand();
            sqlcommand_e2.Connection = sqlconn_e2;
            sqlcommand_e2.CommandText = "update e根治术相关  set 保留胸大小肌_胸肌间脂肪=@保留胸大小肌_胸肌间脂肪,保留胸大小肌_胸肌间脂肪_切除=@保留胸大小肌_胸肌间脂肪_切除,保留胸大小肌_可见肿大淋巴结=@保留胸大小肌_可见肿大淋巴结,保留胸大小肌_可见肿大淋巴结数量=@保留胸大小肌_可见肿大淋巴结数量,保留胸大小肌_胸前神经=@保留胸大小肌_胸前神经,保留胸大小肌_解剖过程=@保留胸大小肌_解剖过程,保留胸大肌_胸肌间脂肪=@保留胸大肌_胸肌间脂肪,保留胸大肌_胸肌间脂肪_切除=@保留胸大肌_胸肌间脂肪_切除,保留胸大肌_可见肿大淋巴结=@保留胸大肌_可见肿大淋巴结,保留胸大肌_可见肿大淋巴结数量=@保留胸大肌_可见肿大淋巴结数量,保留胸大肌_胸前神经=@保留胸大肌_胸前神经,保留胸大肌_切断胸小肌喙突端=@保留胸大肌_切断胸小肌喙突端,保留胸大肌_解剖过程=@保留胸大肌_解剖过程,胸大肌保留=@胸大肌保留,胸大肌宽=@胸大肌宽,根治术_切断胸大肌肱骨端=@根治术_切断胸大肌肱骨端,根治术_切断胸小肌喙突端=@根治术_切断胸小肌喙突端,根治术_解剖过程=@根治术_解剖过程 where 就诊卡号=@就诊卡号";
            sqlcommand_e2.Parameters.AddWithValue("@保留胸大小肌_胸肌间脂肪", RadioButtonList45.Text);
            sqlcommand_e2.Parameters.AddWithValue("@保留胸大小肌_胸肌间脂肪_切除", RadioButtonList46.Text);
            sqlcommand_e2.Parameters.AddWithValue("@保留胸大小肌_可见肿大淋巴结", RadioButton22.Text);
            sqlcommand_e2.Parameters.AddWithValue("@保留胸大小肌_可见肿大淋巴结数量", TextBox232.Text);
            sqlcommand_e2.Parameters.AddWithValue("@保留胸大小肌_胸前神经", RadioButtonList47.Text);
            sqlcommand_e2.Parameters.AddWithValue("@保留胸大小肌_解剖过程", TextBox233.Text);
            sqlcommand_e2.Parameters.AddWithValue("@保留胸大肌_胸肌间脂肪", RadioButtonList48.Text);
            sqlcommand_e2.Parameters.AddWithValue("@保留胸大肌_胸肌间脂肪_切除", RadioButtonList49.Text);
            sqlcommand_e2.Parameters.AddWithValue("@保留胸大肌_可见肿大淋巴结", RadioButton24.Text);
            sqlcommand_e2.Parameters.AddWithValue("@保留胸大肌_可见肿大淋巴结数量", TextBox234.Text);
            sqlcommand_e2.Parameters.AddWithValue("@保留胸大肌_胸前神经", RadioButtonList50.Text);
            sqlcommand_e2.Parameters.AddWithValue("@保留胸大肌_切断胸小肌喙突端", CheckBox30.Checked);
            sqlcommand_e2.Parameters.AddWithValue("@保留胸大肌_解剖过程", TextBox235.Text);
            sqlcommand_e2.Parameters.AddWithValue("@胸大肌保留", TextBox236.Text);
            sqlcommand_e2.Parameters.AddWithValue("@胸大肌宽", TextBox237.Text);
            sqlcommand_e2.Parameters.AddWithValue("@根治术_切断胸大肌肱骨端", CheckBox31.Checked);
            sqlcommand_e2.Parameters.AddWithValue("@根治术_切断胸小肌喙突端", CheckBox32.Checked);
            sqlcommand_e2.Parameters.AddWithValue("@根治术_解剖过程", TextBox238.Text);
            sqlcommand_e2.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

            try
            {
                sqlconn_e2.Open();
                intUpdateCount_e2 = sqlcommand_e2.ExecuteNonQuery();

                if (sqlcommand_e2.ExecuteNonQuery() > 0)
                {
                    e2LbUpdate.Text = "更新成功";
                }
                else
                {
                    e2LbUpdate.Text = "未更新成功";
                }
            }
            catch (Exception ex) { e2LbUpdate.Text = ex.Message; }
            finally
            {
                sqlcommand_e2 = null;
                sqlconn_e2.Close();
                sqlconn_e2 = null;
            }
            //
            //e3页面
            int intUpdateCount_e3;
            SqlConnection sqlconn_e3 = new SqlConnection(sqlconnstr);
            SqlCommand sqlcommand_e3 = new SqlCommand();
            sqlcommand_e3.Connection = sqlconn_e3;
            sqlcommand_e3.CommandText = "update e手术相关  set 腋脉管带周围肿大淋巴结=@腋脉管带周围肿大淋巴结,肿大淋巴结个数=@肿大淋巴结个数,肿大淋巴结大小=@肿大淋巴结大小,肿大淋巴结硬度=@肿大淋巴结硬度," +
                "和腋静脉管或鞘膜粘粒=@和腋静脉管或鞘膜粘粒,切除=@切除,缝合切断=@缝合切断,腋尖肿大淋巴结个数=@腋尖肿大淋巴结个数,腋尖肿大淋巴结大小=@腋尖肿大淋巴结大小,腋尖肿大淋巴结硬度=@腋尖肿大淋巴结硬度,和锁下静脉鞘粘粒=@和锁下静脉鞘粘粒," +
                "胸背神经=@胸背神经,胸长神经=@胸长神经,肩胛下脉管=@肩胛下脉管,负压引流=@负压引流,缝合皮肤张力=@缝合皮肤张力,缝合皮肤植皮=@缝合皮肤植皮,缝合皮肤面积=@缝合皮肤面积,出血量=@出血量,手术时间_小时=@手术时间_小时,手术时间_分=@手术时间_分 where 就诊卡号=@就诊卡号";
            sqlcommand_e3.Parameters.AddWithValue("@腋脉管带周围肿大淋巴结", RadioButtonList32.Text);
            sqlcommand_e3.Parameters.AddWithValue("@肿大淋巴结个数", TextBox224.Text);
            sqlcommand_e3.Parameters.AddWithValue("@肿大淋巴结大小", TextBox225.Text);
            sqlcommand_e3.Parameters.AddWithValue("@肿大淋巴结硬度", RadioButtonList33.Text);
            sqlcommand_e3.Parameters.AddWithValue("@和腋静脉管或鞘膜粘粒", RadioButtonList34.Text);
            sqlcommand_e3.Parameters.AddWithValue("@切除", RadioButtonList35.Text);
            sqlcommand_e3.Parameters.AddWithValue("@缝合切断", RadioButtonList36.Text);
            sqlcommand_e3.Parameters.AddWithValue("@腋尖肿大淋巴结个数", TextBox226.Text);
            sqlcommand_e3.Parameters.AddWithValue("@腋尖肿大淋巴结大小", TextBox227.Text);
            sqlcommand_e3.Parameters.AddWithValue("@腋尖肿大淋巴结硬度", RadioButtonList37.Text);//@,@,@,@,@,@,@,@,
            sqlcommand_e3.Parameters.AddWithValue("@和锁下静脉鞘粘粒", RadioButtonList38.Text);
            sqlcommand_e3.Parameters.AddWithValue("@胸背神经", RadioButtonList39.Text);
            sqlcommand_e3.Parameters.AddWithValue("@胸长神经", RadioButtonList40.Text);
            sqlcommand_e3.Parameters.AddWithValue("@肩胛下脉管", RadioButtonList41.Text);
            sqlcommand_e3.Parameters.AddWithValue("@负压引流", TextBox228.Text);
            sqlcommand_e3.Parameters.AddWithValue("@缝合皮肤张力", RadioButtonList42.Text);
            sqlcommand_e3.Parameters.AddWithValue("@缝合皮肤植皮", RadioButtonList43.Text);
            sqlcommand_e3.Parameters.AddWithValue("@缝合皮肤面积", TextBox229.Text);
            sqlcommand_e3.Parameters.AddWithValue("@出血量", RadioButtonList44.Text);
            sqlcommand_e3.Parameters.AddWithValue("@手术时间_小时", TextBox230.Text);
            sqlcommand_e3.Parameters.AddWithValue("@手术时间_分", TextBox231.Text);
            sqlcommand_e3.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

            try
            {
                sqlconn_e3.Open();
                intUpdateCount_e3 = sqlcommand_e3.ExecuteNonQuery();

                if (sqlcommand_e3.ExecuteNonQuery() > 0)
                {
                    e3LbUpdate.Text = "更新成功";
                }
                else
                {
                    e3LbUpdate.Text = "未更新成功";
                }
            }
            catch (Exception ex) { e3LbUpdate.Text = ex.Message; }
            finally
            {
                sqlcommand_e3 = null;
                sqlconn_e3.Close();
                sqlconn_e3 = null;
            }

            //
            //f1页面
            int intUpdateCount_f1;
            SqlConnection sqlconn_f1 = new SqlConnection(sqlconnstr);
            SqlCommand sqlcommand_f1 = new SqlCommand();
            sqlcommand_f1.Connection = sqlconn_f1;

            sqlcommand_f1.CommandText = "update f术前信息1 set 肿瘤部位_侧=@肿瘤部位_侧,肿瘤部位_点=@肿瘤部位_点,肿瘤大小_横=@肿瘤大小_横 ,肿瘤大小_纵=@肿瘤大小_纵,肿瘤与乳头距离=@肿瘤与乳头距离,胸乳距=@胸乳距,乳胸距=@乳胸距,锁胸距=@锁胸距," +
                "胸骨正中距=@胸骨正中距,乳头间距=@乳头间距 ,乳房基底横径=@乳房基底横径 ,乳房内侧半径=@乳房内侧半径,乳房外侧半径=@乳房外侧半径,乳房下侧半径=@乳房下侧半径 ,乳头至下皱襞体表距离=@乳头至下皱襞体表距离,乳晕直径=@乳晕直径 ,乳头直径=@乳头直径 ,乳房高度=@乳房高度," +
                "胸围Ⅰ=@胸围Ⅰ,胸围Ⅱ=@胸围Ⅱ,胸围Ⅲ=@胸围Ⅲ,乳房半径=@乳房半径 ,乳房体积计算1=@乳房体积计算1 ,超重体重=@超重体重 ,乳房体积计算2=@乳房体积计算2 where 就诊卡号=@就诊卡号";
            sqlcommand_f1.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);
            sqlcommand_f1.Parameters.AddWithValue("@肿瘤部位_侧", TextBox167.Text);
            sqlcommand_f1.Parameters.AddWithValue("@肿瘤部位_点", TextBox168.Text);
            sqlcommand_f1.Parameters.AddWithValue("@肿瘤大小_横", TextBox169.Text);
            sqlcommand_f1.Parameters.AddWithValue("@肿瘤大小_纵", TextBox170.Text);
            sqlcommand_f1.Parameters.AddWithValue("@肿瘤与乳头距离", TextBox171.Text);
            sqlcommand_f1.Parameters.AddWithValue("@胸乳距", TextBox172.Text);
            sqlcommand_f1.Parameters.AddWithValue("@乳胸距", TextBox173.Text);
            sqlcommand_f1.Parameters.AddWithValue("@锁胸距", TextBox174.Text);
            sqlcommand_f1.Parameters.AddWithValue("@胸骨正中距", TextBox175.Text);
            sqlcommand_f1.Parameters.AddWithValue("@乳头间距", TextBox176.Text);
            sqlcommand_f1.Parameters.AddWithValue("@乳房基底横径", TextBox177.Text);
            sqlcommand_f1.Parameters.AddWithValue("@乳房内侧半径", TextBox178.Text);
            sqlcommand_f1.Parameters.AddWithValue("@乳房外侧半径", TextBox179.Text);
            sqlcommand_f1.Parameters.AddWithValue("@乳房下侧半径", TextBox180.Text);
            sqlcommand_f1.Parameters.AddWithValue("@乳头至下皱襞体表距离", TextBox181.Text);
            sqlcommand_f1.Parameters.AddWithValue("@乳晕直径", TextBox182.Text);
            sqlcommand_f1.Parameters.AddWithValue("@乳头直径", TextBox183.Text);
            sqlcommand_f1.Parameters.AddWithValue("@乳房高度", TextBox184.Text);
            sqlcommand_f1.Parameters.AddWithValue("@胸围Ⅰ", TextBox185.Text);
            sqlcommand_f1.Parameters.AddWithValue("@胸围Ⅱ", TextBox186.Text);
            sqlcommand_f1.Parameters.AddWithValue("@胸围Ⅲ", TextBox187.Text);
            sqlcommand_f1.Parameters.AddWithValue("@乳房半径", TextBox188.Text);
            sqlcommand_f1.Parameters.AddWithValue("@乳房体积计算1", TextBox189.Text);
            sqlcommand_f1.Parameters.AddWithValue("@超重体重", TextBox190.Text);
            sqlcommand_f1.Parameters.AddWithValue("@乳房体积计算2", TextBox191.Text);

            try
            {
                sqlconn_f1.Open();
                intUpdateCount_f1 = sqlcommand_f1.ExecuteNonQuery();

                if (sqlcommand_f1.ExecuteNonQuery() > 0)
                {
                    f1LbUpdate.Text = "更新成功";
                }
                else
                {
                    f1LbUpdate.Text = "未更新成功";
                }
            }
            catch (Exception ex) { f1LbUpdate.Text = ex.Message; }
            finally
            {
                sqlcommand_f1 = null;
                sqlconn_f1.Close();
                sqlconn_f1 = null;
            }

            //f2页面
            int intUpdateCount_f2;
            SqlConnection sqlconn_f2 = new SqlConnection(sqlconnstr);
            SqlCommand sqlcommand_f2 = new SqlCommand();
            sqlcommand_f2.Connection = sqlconn_f2;
            sqlcommand_f2.CommandText = "update f术前信息2 set 影像信息=@影像信息,诊断信息=@诊断信息,治疗信息=@治疗信息,就诊卡号=@就诊卡号 where 就诊卡号=@就诊卡号";
            sqlcommand_f2.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

            sqlcommand_f2.Parameters.AddWithValue("@影像信息", f2Tb1.Text);
            sqlcommand_f2.Parameters.AddWithValue("@诊断信息", f2Tb2.Text);
            sqlcommand_f2.Parameters.AddWithValue("@治疗信息", f2Tb3.Text);

            try
            {
                sqlconn_f2.Open();
                intUpdateCount_f2 = sqlcommand_f2.ExecuteNonQuery();

                if (sqlcommand_f2.ExecuteNonQuery() > 0)
                {
                    f2LbUpdate.Text = "更新成功";
                }
                else
                {
                    f2LbUpdate.Text = "未更新成功";
                }
            }
            catch (Exception ex) { f2LbUpdate.Text = "错误原因：" + ex.Message; }
            finally
            {
                sqlcommand_f2 = null;
                sqlconn_f2.Close();
                sqlconn_f2 = null;
            }

            //f3页面
            int intUpdateCount_f3;
            SqlConnection sqlconn_f3 = new SqlConnection(sqlconnstr);
            SqlCommand sqlcommand_f3 = new SqlCommand();
            sqlcommand_f3.Connection = sqlconn_f3;

            sqlcommand_f3.CommandText = "update f手术信息  set 切口类型=@切口类型,切口类型_其他=@切口类型_其他,横径=@横径,纵径=@纵径,体积_排水法=@体积_排水法,切缘病理阴阳性=@切缘病理阴阳性,切缘病理位置=@切缘病理位置,是否二次扩切=@是否二次扩切," +
                "二次切缘病理阴阳性=@二次切缘病理阴阳性,二次切缘病理位置=@二次切缘病理位置,保乳术是否成功=@保乳术是否成功,是否前哨淋巴结活检=@是否前哨淋巴结活检,是否保乳整形=@是否保乳整形,整形方式=@整形方式 where 就诊卡号=@就诊卡号";

            sqlcommand_f3.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);
            string f3_a = "";
            if (RadioButton1.Checked) { f3_a = RadioButton1.Text; }
            if (RadioButton2.Checked) { f3_a = RadioButton2.Text; }
            if (RadioButton3.Checked) { f3_a = RadioButton3.Text; }
            sqlcommand_f3.Parameters.AddWithValue("@切口类型", f3_a);
            sqlcommand_f3.Parameters.AddWithValue("@切口类型_其他", TextBox310.Text);
            sqlcommand_f3.Parameters.AddWithValue("@横径", TextBox192.Text);
            sqlcommand_f3.Parameters.AddWithValue("@纵径", TextBox193.Text);
            sqlcommand_f3.Parameters.AddWithValue("@体积_排水法", TextBox194.Text);
            string f3_b = "";
            if (RadioButton4.Checked) { f3_b = RadioButton4.Text; }
            if (RadioButton5.Checked) { f3_b = RadioButton5.Text; }
            sqlcommand_f3.Parameters.AddWithValue("@切缘病理阴阳性", f3_b);
            sqlcommand_f3.Parameters.AddWithValue("@切缘病理位置", TextBox195.Text);
            string f3_c = "";
            if (RadioButton6.Checked) { f3_c = RadioButton6.Text; }
            if (RadioButton7.Checked) { f3_c = RadioButton7.Text; }
            sqlcommand_f3.Parameters.AddWithValue("@是否二次扩切", f3_c);
            string f3_d = "";
            if (RadioButton8.Checked) { f3_d = RadioButton8.Text; }
            if (RadioButton9.Checked) { f3_d = RadioButton9.Text; }
            sqlcommand_f3.Parameters.AddWithValue("@二次切缘病理阴阳性", f3_d);
            sqlcommand_f3.Parameters.AddWithValue("@二次切缘病理位置", TextBox196.Text);
            string f3_e = "";
            if (RadioButton10.Checked) { f3_e = RadioButton10.Text; }
            if (RadioButton11.Checked) { f3_e = RadioButton11.Text; }
            sqlcommand_f3.Parameters.AddWithValue("@保乳术是否成功", f3_e);
            string f3_f = "";
            if (RadioButton12.Checked) { f3_f = RadioButton12.Text; }
            if (RadioButton13.Checked) { f3_f = RadioButton13.Text; }
            sqlcommand_f3.Parameters.AddWithValue("@是否前哨淋巴结活检", f3_f);
            string f3_g = "";
            if (RadioButton14.Checked) { f3_g = RadioButton14.Text; }
            if (RadioButton15.Checked) { f3_g = RadioButton15.Text; }
            sqlcommand_f3.Parameters.AddWithValue("@是否保乳整形", f3_g);
            sqlcommand_f3.Parameters.AddWithValue("@整形方式", TextBox311.Text);

            try
            {
                sqlconn_f3.Open();
                intUpdateCount_f3 = sqlcommand_f3.ExecuteNonQuery();

                if (sqlcommand_f3.ExecuteNonQuery() > 0)
                {
                    f3LbUpdate.Text = "更新成功";
                }
                else
                {
                    f3LbUpdate.Text = "未更新成功";
                }
            }
            catch (Exception ex) { f3LbUpdate.Text = ex.Message; }
            finally
            {
                sqlcommand_f3 = null;
                sqlconn_f3.Close();
                sqlconn_f3 = null;
            }




            //f4页面
            int intUpdateCount_f4;
            SqlConnection sqlconn_f4 = new SqlConnection(sqlconnstr);
            SqlCommand sqlcommand_f4 = new SqlCommand();
            sqlcommand_f4.Connection = sqlconn_f4;
            sqlcommand_f4.CommandText = "update f术后信息 set 引流时间_天=@引流时间_天,引流总量_ml=@引流总量_ml,是否术后感染=@是否术后感染,术后感染_处理方式=@术后感染_处理方式,就诊卡号=@就诊卡号,术后放疗=@术后放疗 where 就诊卡号=@就诊卡号";
            sqlcommand_f4.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

            sqlcommand_f4.Parameters.AddWithValue("@引流时间_天", f4Tb1.Text);
            sqlcommand_f4.Parameters.AddWithValue("@引流总量_ml", f4Tb2.Text);
            string f4_a = "";
            if (f4Rb1.Checked) { f4_a = f4Rb1.Text; }
            if (f4Rb2.Checked) { f4_a = f4Rb2.Text; }
            sqlcommand_f4.Parameters.AddWithValue("@是否术后感染", f4_a);
            sqlcommand_f4.Parameters.AddWithValue("@术后感染_处理方式", f4Tb3.Text);
            sqlcommand_f4.Parameters.AddWithValue("@术后放疗", f4Tb4.Text);

            try
            {
                sqlconn_f4.Open();
                intUpdateCount_f4 = sqlcommand_f4.ExecuteNonQuery();

                if (sqlcommand_f4.ExecuteNonQuery() > 0)
                {
                    f4LbUpdate.Text = "更新成功";
                }
                else
                {
                    f4LbUpdate.Text = "未更新成功";
                }
            }
            catch (Exception ex) { f4LbUpdate.Text = "错误原因：" + ex.Message; }
            finally
            {
                sqlcommand_f4 = null;
                sqlconn_f4.Close();
                sqlconn_f4 = null;
            }

            //f5页面
            int intUpdateCount_f5;
            SqlConnection sqlconn_f5 = new SqlConnection(sqlconnstr);
            SqlCommand sqlcommand_f5 = new SqlCommand();
            sqlcommand_f5.Connection = sqlconn_f5;
            sqlcommand_f5.CommandText = "update f生活质量及美学指标 set Harris分级标准=@Harris分级标准,乳房大小=@乳房大小,乳房质地_有无硬化=@乳房质地_有无硬化,乳房形状=@乳房形状,乳房挺度_高度=@乳房挺度_高度,乳房皮肤颜色=@乳房皮肤颜色,乳房敏感度_感觉=@乳房敏感度_感觉,乳房外观=@乳房外观,瘢痕组织=@瘢痕组织,乳房肿胀=@乳房肿胀,乳房疼痛=@乳房疼痛,乳房触感_有无触痛=@乳房触感_有无触痛,肩部疼痛=@肩部疼痛,肩部僵硬=@肩部僵硬,肩部活动=@肩部活动,上肢疼痛=@上肢疼痛,上肢僵硬=@上肢僵硬,上肢活动=@上肢活动,上肢肿胀=@上肢肿胀,提举重物的能力=@提举重物的能力,肋部疼痛=@肋部疼痛,乳罩的合适度=@乳罩的合适度,衣服的合适度=@衣服的合适度,问题1=@问题1,问题2=@问题2,问题3=@问题3,问题4=@问题4,问题5=@问题5,问题6=@问题6,问题7=@问题7,问题8=@问题8,问题9=@问题9,问题10=@问题10,客观美容及功能评估1=@客观美容及功能评估1,客观美容及功能评估2=@客观美容及功能评估2,客观美容及功能评估3=@客观美容及功能评估3,客观美容及功能评估4=@客观美容及功能评估4 where 就诊卡号=@就诊卡号";
            sqlcommand_f5.Parameters.AddWithValue("@就诊卡号", TextBox2.Text);

            string f5_a = "";
            if (RadioButton18.Checked) { f5_a = RadioButton18.Text; }
            if (RadioButton19.Checked) { f5_a = RadioButton19.Text; }
            if (RadioButton20.Checked) { f5_a = RadioButton20.Text; }
            if (RadioButton21.Checked) { f5_a = RadioButton21.Text; }
            sqlcommand_f5.Parameters.AddWithValue("@Harris分级标准", f5_a);
            sqlcommand_f5.Parameters.AddWithValue("@乳房大小", RadioButtonList51.Text);
            sqlcommand_f5.Parameters.AddWithValue("@乳房质地_有无硬化", RadioButtonList82.Text);
            sqlcommand_f5.Parameters.AddWithValue("@乳房形状", RadioButtonList52.Text);
            sqlcommand_f5.Parameters.AddWithValue("@乳房挺度_高度", RadioButtonList53.Text);
            sqlcommand_f5.Parameters.AddWithValue("@乳房皮肤颜色", RadioButtonList54.Text);
            sqlcommand_f5.Parameters.AddWithValue("@乳房敏感度_感觉", RadioButtonList55.Text);
            sqlcommand_f5.Parameters.AddWithValue("@乳房外观", RadioButtonList56.Text);
            sqlcommand_f5.Parameters.AddWithValue("@瘢痕组织", RadioButtonList57.Text);
            sqlcommand_f5.Parameters.AddWithValue("@乳房肿胀", RadioButtonList58.Text);
            sqlcommand_f5.Parameters.AddWithValue("@乳房疼痛", RadioButtonList59.Text);
            sqlcommand_f5.Parameters.AddWithValue("@乳房触感_有无触痛", RadioButtonList60.Text);
            sqlcommand_f5.Parameters.AddWithValue("@肩部疼痛", RadioButtonList61.Text);
            sqlcommand_f5.Parameters.AddWithValue("@肩部僵硬", RadioButtonList62.Text);
            sqlcommand_f5.Parameters.AddWithValue("@肩部活动", RadioButtonList63.Text);
            sqlcommand_f5.Parameters.AddWithValue("@上肢疼痛", RadioButtonList64.Text);
            sqlcommand_f5.Parameters.AddWithValue("@上肢僵硬", RadioButtonList65.Text);
            sqlcommand_f5.Parameters.AddWithValue("@上肢活动", RadioButtonList66.Text);
            sqlcommand_f5.Parameters.AddWithValue("@上肢肿胀", RadioButtonList67.Text);
            sqlcommand_f5.Parameters.AddWithValue("@提举重物的能力", RadioButtonList68.Text);
            sqlcommand_f5.Parameters.AddWithValue("@肋部疼痛", RadioButtonList69.Text);
            sqlcommand_f5.Parameters.AddWithValue("@乳罩的合适度", RadioButtonList70.Text);
            sqlcommand_f5.Parameters.AddWithValue("@衣服的合适度", RadioButtonList71.Text);
            sqlcommand_f5.Parameters.AddWithValue("@问题1", RadioButtonList72.Text);
            sqlcommand_f5.Parameters.AddWithValue("@问题2", RadioButtonList73.Text);
            sqlcommand_f5.Parameters.AddWithValue("@问题3", RadioButtonList74.Text);
            sqlcommand_f5.Parameters.AddWithValue("@问题4", RadioButtonList75.Text);
            sqlcommand_f5.Parameters.AddWithValue("@问题5", RadioButtonList76.Text);
            sqlcommand_f5.Parameters.AddWithValue("@问题6", RadioButtonList77.Text);
            sqlcommand_f5.Parameters.AddWithValue("@问题7", RadioButtonList78.Text);
            sqlcommand_f5.Parameters.AddWithValue("@问题8", RadioButtonList79.Text);
            sqlcommand_f5.Parameters.AddWithValue("@问题9", RadioButtonList80.Text);
            sqlcommand_f5.Parameters.AddWithValue("@问题10", RadioButtonList81.Text);
            sqlcommand_f5.Parameters.AddWithValue("@客观美容及功能评估1", TextBox199.Text);
            sqlcommand_f5.Parameters.AddWithValue("@客观美容及功能评估2", TextBox200.Text);
            sqlcommand_f5.Parameters.AddWithValue("@客观美容及功能评估3", TextBox201.Text);
            sqlcommand_f5.Parameters.AddWithValue("@客观美容及功能评估4", TextBox202.Text);

            try
            {
                sqlconn_f5.Open();
                intUpdateCount_f5 = sqlcommand_f5.ExecuteNonQuery();

                if (sqlcommand_f5.ExecuteNonQuery() > 0)
                {
                    f5LbUpdate.Text = "更新成功";
                }
                else
                {
                    f5LbUpdate.Text = "未更新成功";
                }
            }
            catch (Exception ex) { f5LbUpdate.Text = "错误原因：" + ex.Message; }
            finally
            {
                sqlcommand_f5 = null;
                sqlconn_f5.Close();
                sqlconn_f5 = null;
            }
            Response.Redirect("index.aspx");
            Panel89.Enabled = false;


        }


        //第一个公式计算
        protected void Button9_Click(object sender, EventArgs e)
        {
            if (TextBox184.Text == "" || TextBox188.Text == "")
            {
                this.Response.Write("<script language='javascript'>alert('参数未填写！')</script>");
            }
            else
            {
                Double h; Double r, volume1;
                h = Convert.ToDouble(TextBox184.Text.ToString());
                r = Convert.ToDouble(TextBox188.Text.ToString());
                volume1 = 1.0 / 3.0 * 3.14 * h * h * (3 * r - h);
                TextBox189.Text = Math.Round(volume1, 2).ToString();
            }
        }

        //第二个公式计算
        protected void Button10_Click(object sender, EventArgs e)
        {
            if (TextBox186.Text == "" || TextBox185.Text == "" || TextBox190.Text == "")
            {
                this.Response.Write("<script language='javascript'>alert('参数未填写！')</script>");
            }
            else
            {
                Double a; Double b, c, volume2;
                a = Convert.ToDouble(TextBox186.Text.ToString());
                b = Convert.ToDouble(TextBox185.Text.ToString());
                c = Convert.ToDouble(TextBox190.Text.ToString());
                volume2 = 250 + 50 * (a - b) + 20 * c;
                TextBox191.Text = Math.Round(volume2, 2).ToString();
            }
        }

        //需要鸿鸿添加  生成病历内容
        //
        protected void Button6_Click(object sender, EventArgs e)
        {
            if (Label500.Text == "")
            {
                Response.Write("<script language='javascript'>alert('请选择数据！')</script>");
            }
            else
            {
                Random rd = new Random();
                string fileName = DateTime.Now.ToString("yyyyMMddhhmm") + rd.Next() + ".doc";
                //存储路径
                string path = Server.MapPath(fileName);
                //创建字符输出流
                StreamWriter sw = new StreamWriter(path, true, System.Text.UnicodeEncoding.UTF8);

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString());
                string sqlconnstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

                //a1导出
                SqlConnection sqlconn_a1 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_a1 = new SqlCommand();
                sqlcommand_a1.Connection = sqlconn_a1;

                sqlconn_a1.Open();//attention
                sqlcommand_a1.CommandText = "select * from a入院概要 where 就诊卡号=@就诊卡号";
                sqlcommand_a1.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader = sqlcommand_a1.ExecuteReader();

                if (sqldatareader.Read())
                {

                    TextBox2.Text = sqldatareader.GetString(0);
                    TextBox1.Text = sqldatareader.GetString(1);
                    TextBox10.Text = sqldatareader.GetString(2);
                    TextBox3.Text = sqldatareader.GetString(3);
                    TextBox4.Text = sqldatareader.GetString(4);
                    TextBox5.Text = sqldatareader.GetString(5);
                    TextBox6.Text = sqldatareader.GetString(6);
                    TextBox7.Text = sqldatareader.GetString(7);
                    TextBox8.Text = sqldatareader.GetString(8);
                    TextBox9.Text = sqldatareader.GetString(9);
                    TextBox11.Text = sqldatareader.GetString(10);
                    //入院日期
                    string a11 = sqldatareader.GetString(11);
                    string[] a12;
                    a12 = a11.Split(':');
                    string[] a12_1;
                    a12_1 = a12[0].Split(' ');
                    TextBox12.Text = a12_1[0];
                    TextBox12a.Text = a12_1[1];
                    TextBox12b.Text = a12[1];
                    TextBox12c.Text = a12[2];

                    TextBox14.Text = sqldatareader.GetString(12);
                    TextBox15.Text = sqldatareader.GetString(13);
                    TextBox16.Text = sqldatareader.GetString(14);

                    //记录日期
                    string a13 = sqldatareader.GetString(15);
                    string[] a14;
                    a14 = a13.Split(':');
                    string[] a14_1;
                    a14_1 = a14[0].Split(' ');
                    TextBox13.Text = a14_1[0];
                    TextBox13a.Text = a14_1[1];
                    TextBox13b.Text = a14[1];
                    TextBox13c.Text = a14[2];

                }
                sqlcommand_a1 = null;
                sqlconn_a1.Close();
                sqlconn_a1 = null;

                //a2导出
                SqlConnection sqlconn_a2 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_a2 = new SqlCommand();
                sqlcommand_a2.Connection = sqlconn_a2;

                sqlconn_a2.Open();//attention
                sqlcommand_a2.CommandText = "select * from a主诉 where 就诊卡号=@就诊卡号";
                sqlcommand_a2.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_a2 = sqlcommand_a2.ExecuteReader();
                if (sqldatareader_a2.Read())
                {
                    //主要症状_侧别
                    DropDownList31.SelectedValue = sqldatareader_a2.GetString(0).Trim();
                    //主要症状_位置
                    DropDownList32.SelectedValue = sqldatareader_a2.GetString(1).Trim();
                    //主要症状
                    string a2_5 = sqldatareader_a2.GetString(2).Trim();
                    if (a2_5.Contains("肿物")) { CheckBox33.Checked = true; }
                    if (a2_5.Contains("溢液")) { CheckBox34.Checked = true; }
                    if (a2_5.Contains("疼痛")) { CheckBox35.Checked = true; }
                    if (a2_5.Contains("湿疹")) { CheckBox36.Checked = true; }
                    if (a2_5.Contains("凹陷")) { CheckBox37.Checked = true; }
                    if (a2_5.Contains("水肿")) { CheckBox38.Checked = true; }
                    if (a2_5.Contains("卫星结节")) { CheckBox39.Checked = true; }
                    if (a2_5.Contains("破溃")) { CheckBox40.Checked = true; }
                    //主要症状时间
                    string a2_1 = sqldatareader_a2.GetString(3).Trim();
                    char[] result_a2_1 = a2_1.ToCharArray();
                    string str_a2_1 = "";
                    for (int i = 0; i < a2_1.Length; i++)
                    {
                        if (result_a2_1[i] >= '0' && result_a2_1[i] <= '9')
                        {
                            str_a2_1 += result_a2_1[i];
                        }
                    }
                    TextBox239.Text = str_a2_1;
                    DropDownList33.SelectedValue = a2_1.Substring(a2_1.Length - 1, 1);
                    //伴随症状_侧别
                    DropDownList34.SelectedValue = sqldatareader_a2.GetString(4).Trim();
                    //伴随症状_位置
                    DropDownList35.SelectedValue = sqldatareader_a2.GetString(5).Trim();
                    //伴随症状
                    string a2_6 = sqldatareader_a2.GetString(6).Trim();
                    if (a2_6.Contains("肿物")) { CheckBox41.Checked = true; }
                    if (a2_6.Contains("溢液")) { CheckBox42.Checked = true; }
                    if (a2_6.Contains("疼痛")) { CheckBox43.Checked = true; }
                    if (a2_6.Contains("湿疹")) { CheckBox44.Checked = true; }
                    if (a2_6.Contains("凹陷")) { CheckBox45.Checked = true; }
                    if (a2_6.Contains("水肿")) { CheckBox46.Checked = true; }
                    if (a2_6.Contains("卫星结节")) { CheckBox47.Checked = true; }
                    if (a2_5.Contains("破溃")) { CheckBox48.Checked = true; }
                    //伴随症状时间
                    string a2_2 = sqldatareader_a2.GetString(7).Trim();
                    char[] result_a2_2 = a2_2.ToCharArray();
                    string str_a2_2 = "";
                    for (int i = 0; i < a2_2.Length; i++)
                    {
                        if (result_a2_2[i] >= '0' && result_a2_2[i] <= '9')
                        {
                            str_a2_2 += result_a2_2[i];
                        }
                    }
                    TextBox240.Text = str_a2_2;
                    DropDownList36.SelectedValue = a2_2.Substring(a2_2.Length - 1, 1);
                    //增大时间
                    string a2_3 = sqldatareader_a2.GetString(8).Trim();
                    char[] result_a2_3 = a2_3.ToCharArray();
                    string str_a2_3 = "";
                    for (int i = 0; i < a2_3.Length; i++)
                    {
                        if (result_a2_3[i] >= '0' && result_a2_3[i] <= '9')
                        {
                            str_a2_3 += result_a2_3[i];
                        }
                    }
                    TextBox241.Text = str_a2_3;
                    DropDownList37.SelectedValue = a2_3.Substring(a2_3.Length - 1, 1);
                    //转为血性时间
                    string a2_4 = sqldatareader_a2.GetString(9).Trim();
                    char[] result_a2_4 = a2_4.ToCharArray();
                    string str_a2_4 = "";
                    for (int i = 0; i < a2_4.Length; i++)
                    {
                        if (result_a2_4[i] >= '0' && result_a2_4[i] <= '9')
                        {
                            str_a2_4 += result_a2_4[i];
                        }
                    }
                    TextBox242.Text = str_a2_4;
                    DropDownList38.SelectedValue = a2_4.Substring(a2_4.Length - 1, 1);
                }


                //需要导出的内容
                // string str = "<html><head><title>无标题文档</title></head><body>这里放从数据库导出的word文档内容</body></html>";
                string str = "";
                str += "<html><head><title>无标题文档</title></head><body>";
                str += "<div>入院概要</div>";
                str += "<div><table border-collapse='0'>" + "<tr><td>姓名：" + TextBox1.Text + "</td><td>工作单位：" + TextBox9.Text + "</td></tr>";
                str += "<tr><td>" + "就诊卡号：" + TextBox2.Text + "</td><td>住院号：" + TextBox10.Text + "</td></tr>";
                str += "<tr><td>" + "性别：" + TextBox3.Text + "</td><td>现住址：" + TextBox11.Text + "</td></tr>";
                str += "<tr><td>" + "年龄：" + TextBox4.Text + "</td><td>入院日期：" + TextBox12.Text + "</td></tr>";
                str += "<tr><td>" + "婚姻：" + TextBox5.Text + "</td><td>记录日期：" + TextBox13.Text + "</td></tr>";
                str += "<tr><td>" + "籍贯：" + TextBox6.Text + "</td><td>病史陈述者：" + TextBox14.Text + "</td></tr>";
                str += "<tr><td>" + "民族：" + TextBox7.Text + "</td><td>与患者关系：" + TextBox15.Text + "</td></tr>";
                str += "<tr><td>" + "职业：" + TextBox8.Text + "</td><td>联系电话：" + TextBox16.Text + "</td></tr></div></table>";
                str += "<br />";
                str += "<div>主诉</div>";
                str += "<div>主要症状</div>";
                str += "<div><table border-collapse='0'><tr><td>侧别：" + DropDownList31.SelectedValue + " &nbsp;&nbsp;</td><td>位置：" + DropDownList32.SelectedValue + "</td></tr>";
                str += "<tr><td>" + "症状：" + sqldatareader_a2.GetString(2).Trim() + "&nbsp;&nbsp;</td><td>时间：" + sqldatareader_a2.GetString(3).Trim() + "</td></tr></table></div>";
                str += "<div>伴随</div>";
                str += "<div><table border-collapse='0'><tr><td>侧别：" + DropDownList34.SelectedValue + " &nbsp;&nbsp;</td><td>位置：" + DropDownList35.SelectedValue + "</td></tr>";
                str += "<tr><td>" + "症状：" + sqldatareader_a2.GetString(6).Trim() + "&nbsp;&nbsp;</td><td>时间：" + sqldatareader_a2.GetString(7).Trim() + "</td></tr></table></div>";
                str += "<div>发展</div>";
                str += "<div><table border-collapse='0'><tr><td>增大：" + sqldatareader_a2.GetString(8).Trim() + "&nbsp;&nbsp;&nbsp;&nbsp;</td><td>转为血性：" + sqldatareader_a2.GetString(9).Trim() + "</td></tr></table></div>";
                sqlcommand_a2 = null;
                sqlconn_a2.Close();
                sqlconn_a2 = null;

                //a3导出
                SqlConnection sqlconn_a3 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_a3 = new SqlCommand();
                sqlcommand_a3.Connection = sqlconn_a3;

                sqlconn_a3.Open();//attention
                sqlcommand_a3.CommandText = "select * from a现病史 where 就诊卡号=@就诊卡号";
                sqlcommand_a3.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_a3 = sqlcommand_a3.ExecuteReader();
                if (sqldatareader_a3.Read())
                {
                    //发现时长
                    string a3_1 = sqldatareader_a3.GetString(0).Trim();
                    char[] result_a3_1 = a3_1.ToCharArray();
                    string str_a3_1 = "";
                    for (int i = 0; i < a3_1.Length; i++)
                    {
                        if (result_a3_1[i] >= '0' && result_a3_1[i] <= '9')
                        {
                            str_a3_1 += result_a3_1[i];
                        }
                    }
                    TextBox243.Text = str_a3_1;
                    DropDownList39.SelectedValue = a3_1.Substring(a3_1.Length - 1, 1);
                    //发现原因
                    DropDownList40.SelectedValue = sqldatareader_a3.GetString(1).Trim();
                    //诱因
                    DropDownList41.SelectedValue = sqldatareader_a3.GetString(2).Trim();
                    if (sqldatareader_a3.IsDBNull(16)) { TextBox244.Text = ""; } else { TextBox244.Text = sqldatareader_a3.GetString(16); }
                    //病因
                    DropDownList42.SelectedValue = sqldatareader_a3.GetString(3).Trim();
                    if (sqldatareader_a3.IsDBNull(17)) { TextBox245.Text = ""; } else { TextBox245.Text = sqldatareader_a3.GetString(17); }
                    //肿瘤大小
                    //select substr(肿瘤大小,1,instr(肿瘤大小, '*', -1) - 1) from a现病史;
                    string a3_2 = sqldatareader_a3.GetString(4).Trim();
                    string aa3_2 = a3_2.Split('*')[1];//*右
                    string ab3_2 = a3_2.Split('*')[0];//*左
                    if (sqldatareader_a3.IsDBNull(4)) { TextBox283.Text = ""; } else { TextBox283.Text = ab3_2; }
                    if (sqldatareader_a3.IsDBNull(4)) { TextBox284.Text = ""; } else { TextBox284.Text = aa3_2; }
                    //压痛情况
                    DropDownList43.SelectedValue = sqldatareader_a3.GetString(5).Trim();
                    //乳头溢液
                    DropDownList44.SelectedValue = sqldatareader_a3.GetString(6).Trim();
                    //溢液数量
                    DropDownList45.SelectedValue = sqldatareader_a3.GetString(7).Trim();
                    //溢液性状
                    DropDownList46.SelectedValue = sqldatareader_a3.GetString(8).Trim();
                    //溢液动能
                    DropDownList47.SelectedValue = sqldatareader_a3.GetString(9).Trim();
                    //就诊经历
                    DropDownList48.SelectedValue = sqldatareader_a3.GetString(10).Trim();
                    //于何处诊疗
                    if (sqldatareader_a3.IsDBNull(11)) { TextBox285.Text = ""; } else { TextBox285.Text = sqldatareader_a3.GetString(11); }
                    //诊疗过程
                    if (sqldatareader_a3.IsDBNull(12)) { TextBox286.Text = ""; } else { TextBox286.Text = sqldatareader_a3.GetString(12); }
                    //诊疗疗效
                    DropDownList96.SelectedValue = sqldatareader_a3.GetString(13).Trim();
                    //诊疗转归
                    DropDownList49.SelectedValue = sqldatareader_a3.GetString(14).Trim();
                    DropDownList50.SelectedValue = sqldatareader_a3.GetString(18).Trim();
                }
                str += "<br />";
                str += "<div>现病史</div>";
                str += "<div>一般</div>";
                str += "<div>于入院前" + "&nbsp;" + sqldatareader_a3.GetString(0).Trim() + DropDownList40.SelectedValue + "发现。</div>";
                if (DropDownList41.SelectedValue == "有") { str += "<div>诱因：" + sqldatareader_a3.GetString(16); } else { str += "<div>诱因：无"; }
                if (DropDownList42.SelectedValue == "有") { str += "&nbsp;&nbsp;&nbsp;&nbsp;" + "病因：" + sqldatareader_a3.GetString(17) + "</div>"; } else { str += "&nbsp;&nbsp;&nbsp;&nbsp;" + "病因：无"; }
                str += "<div>病症描述</div>";
                str += "<div>肿瘤大小(cm)：" + TextBox283.Text + "*" + TextBox284.Text + "&nbsp;&nbsp;&nbsp;&nbsp;" + DropDownList43.SelectedValue + "压痛，" + DropDownList43.SelectedValue + "乳头溢液" + "</div>";
                str += "<div>溢液数量：" + DropDownList45.SelectedValue + "&nbsp;&nbsp;&nbsp;&nbsp;" + "溢液动能：" + DropDownList47.SelectedValue + "&nbsp;&nbsp;&nbsp;&nbsp;" + "溢液性状：" + DropDownList46.SelectedValue + "</div>";
                str += "<div>诊疗过程</div>";
                if (DropDownList48.SelectedValue == "有") { str += "<div>有无就诊经历：有</div>" + "<div>于" + TextBox285.Text + "就诊" + "&nbsp;&nbsp;&nbsp;&nbsp;" + "诊疗过程：" + TextBox286.Text + "</div>" + "<div>诊疗疗效：" + DropDownList96.SelectedValue + "</div>" + "<div>诊疗转归：" + DropDownList49.SelectedValue + DropDownList50.SelectedValue + "</div><div>为求进一步治疗来我院就诊</div>"; }
                else { str += "<div>有无就诊经历：自发病以来未进行任何治疗</div>" + "<div>诊疗转归：" + DropDownList49.SelectedValue + DropDownList50.SelectedValue + "</div><div>为求进一步治疗来我院就诊</div>"; }

                sqlcommand_a3 = null;
                sqlconn_a3.Close();
                sqlconn_a3 = null;

                //a4导出
                SqlConnection sqlconn_a4 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_a4 = new SqlCommand();
                sqlcommand_a4.Connection = sqlconn_a4;

                sqlconn_a4.Open();//attention
                sqlcommand_a4.CommandText = "select * from a身体状况 where 就诊卡号=@就诊卡号";
                sqlcommand_a4.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_a4 = sqlcommand_a4.ExecuteReader();
                if (sqldatareader_a4.Read())
                {
                    //一般状况
                    DropDownList1.SelectedValue = sqldatareader_a4.GetString(0).Trim();
                    //精神
                    DropDownList2.SelectedValue = sqldatareader_a4.GetString(1).Trim();
                    //食睡
                    DropDownList3.SelectedValue = sqldatareader_a4.GetString(2).Trim();
                    //二便
                    DropDownList4.SelectedValue = sqldatareader_a4.GetString(3).Trim();
                    //体重
                    DropDownList5.SelectedValue = sqldatareader_a4.GetString(4).Trim();
                    //体力
                    DropDownList6.SelectedValue = sqldatareader_a4.GetString(5).Trim();
                    //既往体健
                    DropDownList7.SelectedValue = sqldatareader_a4.GetString(6).Trim();
                    //疾病史冠心病7
                    if (sqldatareader_a4.IsDBNull(7)) { TextBox17.Text = ""; } else { TextBox17.Text = sqldatareader_a4.GetString(7); }
                    //疾病史糖尿病8
                    if (sqldatareader_a4.IsDBNull(8)) { TextBox18.Text = ""; } else { TextBox18.Text = sqldatareader_a4.GetString(8); }
                    //疾病史高血压9
                    if (sqldatareader_a4.IsDBNull(9)) { TextBox19.Text = ""; } else { TextBox19.Text = sqldatareader_a4.GetString(9); }
                    //疾病史甲亢病10
                    if (sqldatareader_a4.IsDBNull(10)) { TextBox20.Text = ""; } else { TextBox20.Text = sqldatareader_a4.GetString(10); }
                    //手术史
                    DropDownList8.SelectedValue = sqldatareader_a4.GetString(11).Trim();
                    //外伤史
                    DropDownList9.SelectedValue = sqldatareader_a4.GetString(12).Trim();
                    //输血史
                    DropDownList10.SelectedValue = sqldatareader_a4.GetString(13).Trim();
                    //过敏史
                    DropDownList11.SelectedValue = sqldatareader_a4.GetString(14).Trim();
                    //手术史_时间17
                    if (sqldatareader_a4.IsDBNull(17)) { TextBox21.Text = ""; } else { TextBox21.Text = sqldatareader_a4.GetString(17); }
                    //手术史_于何处18
                    if (sqldatareader_a4.IsDBNull(18)) { TextBox22.Text = ""; } else { TextBox22.Text = sqldatareader_a4.GetString(18); }
                    //进行何种手术19
                    if (sqldatareader_a4.IsDBNull(19)) { TextBox23.Text = ""; } else { TextBox23.Text = sqldatareader_a4.GetString(19); }
                    //外伤史_时间20
                    if (sqldatareader_a4.IsDBNull(20)) { TextBox302.Text = ""; } else { TextBox302.Text = sqldatareader_a4.GetString(20); }
                    //外伤史_于何处21
                    if (sqldatareader_a4.IsDBNull(21)) { TextBox303.Text = ""; } else { TextBox303.Text = sqldatareader_a4.GetString(21); }
                    //受过何种外伤22
                    if (sqldatareader_a4.IsDBNull(22)) { TextBox304.Text = ""; } else { TextBox304.Text = sqldatareader_a4.GetString(22); }
                    //输血史_时间23
                    if (sqldatareader_a4.IsDBNull(23)) { TextBox305.Text = ""; } else { TextBox305.Text = sqldatareader_a4.GetString(23); }
                    //输血史_于何处24
                    if (sqldatareader_a4.IsDBNull(24)) { TextBox306.Text = ""; } else { TextBox306.Text = sqldatareader_a4.GetString(24); }
                    //因何输血25
                    if (sqldatareader_a4.IsDBNull(25)) { TextBox307.Text = ""; } else { TextBox307.Text = sqldatareader_a4.GetString(25); }
                    //食物详情26
                    if (sqldatareader_a4.IsDBNull(26)) { TextBox308.Text = ""; } else { TextBox308.Text = sqldatareader_a4.GetString(26); }
                    //药物详情27
                    if (sqldatareader_a4.IsDBNull(27)) { TextBox309.Text = ""; } else { TextBox309.Text = sqldatareader_a4.GetString(27); }
                    //食物
                    if (sqldatareader_a4.IsDBNull(28)) { } else { DropDownList97.SelectedValue = sqldatareader_a4.GetString(28).Trim(); }
                    //药物
                    if (sqldatareader_a4.IsDBNull(29)) { } else { DropDownList98.SelectedValue = sqldatareader_a4.GetString(29).Trim(); }
                }
                sqlcommand_a4 = null;
                sqlconn_a4.Close();
                sqlconn_a4 = null;

                str += "<br />";
                str += "<div>身体状况</div>";
                str += "<div>一般</div><div>自患者入院以来</div>";
                str += "<div><table border-collapse='0'><tr><td>一般状况：" + DropDownList1.SelectedValue + "&nbsp;&nbsp;</td>" + "<td>精神：" + DropDownList2.SelectedValue + "&nbsp;&nbsp;</td>" + "<td>食睡：" + DropDownList3.SelectedValue + "&nbsp;&nbsp;</td></tr>";
                str += "<tr><td>二便：" + DropDownList4.SelectedValue + "&nbsp;&nbsp;</td>" + " <td>体重：" + DropDownList5.SelectedValue + "&nbsp;&nbsp;</td>" + "<td>体力：" + DropDownList6.SelectedValue + "&nbsp;&nbsp;</td>" + "</tr></table></div>";
                str += "<div>既往史</div>";
                if (DropDownList7.SelectedValue == "否")
                {
                    str += "<div>既往体健：否</div>";
                    if (TextBox17.Text != "") { str += "疾病史：&nbsp;&nbsp;冠心病：" + TextBox17.Text + "年&nbsp;&nbsp;"; }
                    else { str += "疾病史：&nbsp;&nbsp;"; }
                    if (TextBox18.Text != "") { str += "糖尿病：" + TextBox18.Text + "年&nbsp;&nbsp;"; }
                    else { str += ""; }
                    if (TextBox19.Text != "") { str += "高血压：" + TextBox19.Text + "年&nbsp;&nbsp;"; }
                    else { str += ""; }
                    if (TextBox20.Text != "") { str += "甲亢病：" + TextBox20.Text + "年"; }
                    else { str += ""; }
                }
                else { str += "<div>既往体健：是 </div>"; }
                if (DropDownList8.SelectedValue == "有")
                {
                    str += "<div>手术史：有" + "&nbsp;&nbsp;" + "时间：" + TextBox21.Text + "&nbsp;&nbsp;" + "于何处：" + TextBox22.Text + "&nbsp;&nbsp;" + "进行何种手术：" + TextBox23.Text + "</div>";
                }
                else { str += "<div>手术史：无</div>"; }
                if (DropDownList9.SelectedValue == "有")
                {
                    str += "<div>外伤史：有" + "&nbsp;&nbsp;" + "时间：" + TextBox302.Text + "&nbsp;&nbsp;" + "于何处：" + TextBox303.Text + "&nbsp;&nbsp;" + "受过何种外伤：" + TextBox304.Text + "</div>";
                }
                else { str += "<div>外伤史：无</div>"; }
                if (DropDownList10.SelectedValue == "有")
                {
                    str += "<div>输血史：有" + "&nbsp;&nbsp;" + "时间：" + TextBox305.Text + "&nbsp;&nbsp;" + "于何处：" + TextBox306.Text + "&nbsp;&nbsp;" + "因何输血：" + TextBox307.Text + "</div>";
                }
                else { str += "<div>输血史：无</div>"; }
                if (DropDownList11.SelectedValue == "有")
                {
                    str += "<div>过敏史：有</div>";
                    if (DropDownList97.SelectedValue == "有") { str += "<div>食物【详情】：" + TextBox308.Text + "</div>"; } else { str += ""; }
                    if (DropDownList98.SelectedValue == "有") { str += "<div>药物【详情】：" + TextBox309.Text + "</div>"; } else { str += ""; }
                }
                else { str += "<div>过敏史：无</div>"; }

                //a5导出
                SqlConnection sqlconn_a5 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_a5 = new SqlCommand();
                sqlcommand_a5.Connection = sqlconn_a5;

                sqlconn_a5.Open();//attention
                sqlcommand_a5.CommandText = "select * from a个人情况 where 就诊卡号=@就诊卡号";
                sqlcommand_a5.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_a5 = sqlcommand_a5.ExecuteReader();
                if (sqldatareader_a5.Read())
                {
                    //身高
                    if (sqldatareader_a5.IsDBNull(0)) { TextBox246.Text = ""; } else { TextBox246.Text = sqldatareader_a5.GetString(0); }
                    //体重
                    if (sqldatareader_a5.IsDBNull(1)) { TextBox247.Text = ""; } else { TextBox247.Text = sqldatareader_a5.GetString(1); }
                    //T°
                    if (sqldatareader_a5.IsDBNull(2)) { TextBox248.Text = ""; } else { TextBox248.Text = sqldatareader_a5.GetString(2); }
                    //P
                    if (sqldatareader_a5.IsDBNull(3)) { TextBox249.Text = ""; } else { TextBox249.Text = sqldatareader_a5.GetString(3); }
                    //R
                    if (sqldatareader_a5.IsDBNull(4)) { TextBox250.Text = ""; } else { TextBox250.Text = sqldatareader_a5.GetString(4); }
                    //BP
                    if (sqldatareader_a5.IsDBNull(5)) { TextBox251.Text = ""; } else { TextBox251.Text = sqldatareader_a5.GetString(5); }
                    //KPS
                    if (sqldatareader_a5.IsDBNull(6)) { TextBox252.Text = ""; } else { TextBox252.Text = sqldatareader_a5.GetString(6); }
                    //BSA
                    if (sqldatareader_a5.IsDBNull(7)) { TextBox253.Text = ""; } else { TextBox253.Text = sqldatareader_a5.GetString(7); }
                    //出生地
                    if (sqldatareader_a5.IsDBNull(8)) { TextBox254.Text = ""; } else { TextBox254.Text = sqldatareader_a5.GetString(8); }
                    //生长接触史
                    string a5_1 = sqldatareader_a5.GetString(9).Trim();
                    if (a5_1.Contains("毒物")) { CheckBox49.Checked = true; }
                    if (a5_1.Contains("粉尘")) { CheckBox50.Checked = true; }
                    if (a5_1.Contains("放射")) { CheckBox51.Checked = true; }
                    if (a5_1.Contains("疫区")) { CheckBox52.Checked = true; }
                    if (a5_1.Contains("烟酒嗜好")) { CheckBox53.Checked = true; }
                    //烟酒详情
                    if (sqldatareader_a5.IsDBNull(33)) { TextBox255.Text = ""; } else { TextBox255.Text = sqldatareader_a5.GetString(33); }
                    //初潮年龄
                    if (sqldatareader_a5.IsDBNull(10)) { TextBox256.Text = ""; } else { TextBox256.Text = sqldatareader_a5.GetString(10); }
                    //初潮年龄_分子
                    if (sqldatareader_a5.IsDBNull(28)) { TextBox257.Text = ""; } else { TextBox257.Text = sqldatareader_a5.GetString(28); }
                    //初潮年龄_分母
                    if (sqldatareader_a5.IsDBNull(29)) { TextBox260.Text = ""; } else { TextBox260.Text = sqldatareader_a5.GetString(29); }
                    //绝经年龄
                    if (sqldatareader_a5.IsDBNull(11)) { TextBox258.Text = ""; } else { TextBox258.Text = sqldatareader_a5.GetString(11); }
                    //末次月经
                    if (sqldatareader_a5.IsDBNull(12)) { TextBox259.Text = ""; } else { TextBox259.Text = sqldatareader_a5.GetString(12); }
                    //痛经情况13
                    if (sqldatareader_a5.GetString(13) == "是") { CheckBox54.Checked = true; }
                    //结婚情况14
                    DropDownList51.SelectedValue = sqldatareader_a5.GetString(14).Trim();
                    //结婚年龄
                    if (sqldatareader_a5.IsDBNull(15)) { TextBox261.Text = ""; } else { TextBox261.Text = sqldatareader_a5.GetString(15); }
                    //配偶情况16
                    DropDownList56.SelectedValue = sqldatareader_a5.GetString(16).Trim();
                    //P
                    if (sqldatareader_a5.IsDBNull(17)) { TextBox262.Text = ""; } else { TextBox262.Text = sqldatareader_a5.GetString(17); }
                    //A
                    if (sqldatareader_a5.IsDBNull(18)) { TextBox263.Text = ""; } else { TextBox263.Text = sqldatareader_a5.GetString(18); }
                    //G
                    if (sqldatareader_a5.IsDBNull(19)) { TextBox264.Text = ""; } else { TextBox264.Text = sqldatareader_a5.GetString(19); }
                    //哺乳情况20
                    DropDownList52.SelectedValue = sqldatareader_a5.GetString(20).Trim();
                    //哺乳侧别
                    if (sqldatareader_a5.IsDBNull(21)) { TextBox287.Text = ""; } else { TextBox287.Text = sqldatareader_a5.GetString(21); }
                    //持续时间
                    if (sqldatareader_a5.IsDBNull(22)) { TextBox288.Text = ""; } else { TextBox288.Text = sqldatareader_a5.GetString(22); }
                    //子女情况23
                    DropDownList53.SelectedValue = sqldatareader_a5.GetString(23).Trim();
                    //父亲情况
                    DropDownList54.SelectedValue = sqldatareader_a5.GetString(24).Trim();
                    //父亲详情
                    if (sqldatareader_a5.IsDBNull(30)) { TextBox289.Text = ""; } else { TextBox289.Text = sqldatareader_a5.GetString(30); }
                    //母亲情况
                    DropDownList55.SelectedValue = sqldatareader_a5.GetString(25).Trim();
                    //母亲详情
                    if (sqldatareader_a5.IsDBNull(31)) { TextBox290.Text = ""; } else { TextBox290.Text = sqldatareader_a5.GetString(31); }
                    //家族恶性肿瘤史
                    DropDownList75.SelectedValue = sqldatareader_a5.GetString(26).Trim();
                    //家族详情
                    if (sqldatareader_a5.IsDBNull(32)) { TextBox291.Text = ""; } else { TextBox291.Text = sqldatareader_a5.GetString(32); }
                }
                str += "<br />";
                str += "<div>个人情况</div>";
                str += "<div>体格检查</div>";
                str += "<div><table border-collapse='0'>" + "<tr><td>身高(cm)：" + TextBox246.Text + "&nbsp;&nbsp;</td>" + "<td>体重(kg)：" + TextBox247.Text + "&nbsp;&nbsp;</td>" + "<td>T(℃)：" + TextBox248.Text + "&nbsp;&nbsp;</td>" + "<td>P(次/分)：" + TextBox249.Text + "</td></tr>";
                str += "<tr><td>R(次/分)：" + TextBox250.Text + "&nbsp;&nbsp;</td>" + "<td>BP(mmHG)：" + TextBox251.Text + "&nbsp;&nbsp;</td>" + "<td>KPS(分)：" + TextBox252.Text + "&nbsp;&nbsp;</td>" + "<td>BSA(m²)：" + TextBox253.Text + "</td></tr></table></div>";
                str += "<div>个人史</div>";
                str += "<div>出生地：" + TextBox254.Text + "</div>";
                str += "<div>生长接触史：" + sqldatareader_a5.GetString(9).Trim() + "&nbsp;&nbsp;";
                if (TextBox255.Text != null) { str += "烟酒详情：" + TextBox255.Text + "</div>"; } else { str += "</div>"; }
                str += "<div>月经史</div>";
                str += "<div>初潮(岁)：" + TextBox256.Text + "&nbsp;&nbsp;" + "(" + TextBox257.Text + "/" + TextBox260.Text + ")" + "&nbsp;&nbsp;" + "绝经(岁)：" + TextBox258.Text + "&nbsp;&nbsp;" + "末次月经：" + TextBox259.Text + "&nbsp;&nbsp;&nbsp;";
                if (sqldatareader_a5.GetString(13) == "是") { str += "痛经</div>"; } else { str += "不痛经</div>"; }
                str += "<div>婚育史</div>";
                if (DropDownList51.SelectedValue == "已婚")
                {
                    str += "<div>结婚：已婚" + "&nbsp;&nbsp;" + "结婚年龄(岁)：" + TextBox261.Text + "&nbsp;&nbsp;" + "配偶情况：" + DropDownList56.SelectedValue + "</div>";
                    str += "<div>P" + TextBox262.Text + "&nbsp;&nbsp;" + "G" + TextBox264.Text + "&nbsp;&nbsp;" + "A" + TextBox263.Text + "&nbsp;&nbsp;" + "是否哺乳：" + DropDownList52.SelectedValue + "&nbsp;&nbsp;" + "侧别：" + TextBox287.Text + "&nbsp;&nbsp;" + "持续时间：" + TextBox288.Text + "&nbsp;&nbsp;" + "子女情况：" + DropDownList53.SelectedValue;
                }
                else
                {
                    str += "<div>结婚：未婚</div>";
                    str += "<div>P" + TextBox262.Text + "&nbsp;&nbsp;" + "G" + TextBox264.Text + "&nbsp;&nbsp;" + "A" + TextBox263.Text + "&nbsp;&nbsp;" + "是否哺乳：" + DropDownList52.SelectedValue + "&nbsp;&nbsp;" + "侧别：" + TextBox287.Text + "&nbsp;&nbsp;" + "持续时间：" + TextBox288.Text + "&nbsp;&nbsp;" + "子女情况：" + DropDownList53.SelectedValue + "</div>";
                }
                str += "<div>家族史</div>";
                if (DropDownList54.SelectedValue == "体健") { str += "<div>父：体健</div>"; }
                else { str += "<div>父：" + DropDownList54.SelectedValue + "&nbsp;&nbsp;" + "详情：" + TextBox289.Text + "</div>"; }
                if (DropDownList55.SelectedValue == "体健") { str += "<div>母：体健</div>"; }
                else { str += "<div>母：" + DropDownList55.SelectedValue + "&nbsp;&nbsp;" + "详情：" + TextBox290.Text + "</div>"; }
                if (DropDownList75.SelectedValue == "无") { str += "<div>家族恶性肿瘤史：无</div>"; }
                else { str += "<div>家族恶性肿瘤史：" + DropDownList75.SelectedValue + "&nbsp;&nbsp;" + "详情：" + TextBox291.Text + "</div>"; }
                sqlcommand_a5 = null;
                sqlconn_a5.Close();
                sqlconn_a5 = null;

                //a6导出
                SqlConnection sqlconn_a6 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_a6 = new SqlCommand();
                sqlcommand_a6.Connection = sqlconn_a6;

                sqlconn_a6.Open();//attention
                sqlcommand_a6.CommandText = "select * from a专科查体 where 就诊卡号=@就诊卡号";
                sqlcommand_a6.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_a6 = sqlcommand_a6.ExecuteReader();
                if (sqldatareader_a6.Read())
                {
                    //乳房皮肤
                    DropDownList57.SelectedValue = sqldatareader_a6.GetString(0).Trim();
                    //卫星结节个数
                    if (sqldatareader_a6.IsDBNull(18)) { TextBox314.Text = ""; } else { TextBox314.Text = sqldatareader_a6.GetString(18); }
                    //乳头1
                    DropDownList58.SelectedValue = sqldatareader_a6.GetString(1).Trim();
                    //湿疹范围19
                    string a6_1 = sqldatareader_a6.GetString(19).Trim();
                    if (a6_1.Contains("乳头")) { CheckBox70.Checked = true; }
                    if (a6_1.Contains("乳晕")) { CheckBox71.Checked = true; }
                    if (a6_1.Contains("皮肤")) { CheckBox72.Checked = true; }


                    //乳头溢液_有无2
                    DropDownList59.SelectedValue = sqldatareader_a6.GetString(2).Trim();
                    //乳头溢液_主被动3
                    DropDownList60.SelectedValue = sqldatareader_a6.GetString(3).Trim();
                    //乳头溢液_单多孔4
                    DropDownList61.SelectedValue = sqldatareader_a6.GetString(4).Trim();
                    //乳头溢液_血性5
                    DropDownList62.SelectedValue = sqldatareader_a6.GetString(5).Trim();
                    //乳腺肿块6
                    DropDownList63.SelectedValue = sqldatareader_a6.GetString(6).Trim();
                    //距离乳头7
                    string a6_2 = sqldatareader_a6.GetString(7).Trim();
                    string aa6_1 = a6_2.Split('+')[1];//*右
                    string ab6_1 = a6_2.Split('+')[0];//*左
                    if (a6_2 == "") { TextBox292.Text = ""; } else { TextBox292.Text = aa6_1; }
                    if (a6_2 == "") { TextBox293.Text = ""; } else { TextBox293.Text = ab6_1; }
                    //肿块性质8
                    DropDownList64.SelectedValue = sqldatareader_a6.GetString(8).Trim();
                    //边界情况9
                    DropDownList76.SelectedValue = sqldatareader_a6.GetString(9).Trim();
                    //肿块活动10
                    DropDownList77.SelectedValue = sqldatareader_a6.GetString(10).Trim();
                    //胸壁粘连11
                    DropDownList78.SelectedValue = sqldatareader_a6.GetString(11).Trim();
                    //胸壁固定12
                    DropDownList79.SelectedValue = sqldatareader_a6.GetString(12).Trim();
                    //同侧腋窝13
                    DropDownList80.SelectedValue = sqldatareader_a6.GetString(13).Trim();
                    //同侧腋窝_数量
                    if (sqldatareader_a6.IsDBNull(20)) { TextBox294.Text = ""; } else { TextBox294.Text = sqldatareader_a6.GetString(20); }
                    //同侧腋窝_大小
                    if (sqldatareader_a6.IsDBNull(21)) { TextBox295.Text = ""; } else { TextBox295.Text = sqldatareader_a6.GetString(21); }
                    //同侧腋窝_散在
                    DropDownList81.SelectedValue = sqldatareader_a6.GetString(22).Trim();
                    //同侧腋窝_活动
                    DropDownList82.SelectedValue = sqldatareader_a6.GetString(23).Trim();
                    //同锁骨上14
                    DropDownList83.SelectedValue = sqldatareader_a6.GetString(14).Trim();
                    //同锁骨上_数量
                    if (sqldatareader_a6.IsDBNull(24)) { TextBox296.Text = ""; } else { TextBox296.Text = sqldatareader_a6.GetString(24); }
                    //同锁骨上_大小
                    if (sqldatareader_a6.IsDBNull(25)) { TextBox297.Text = ""; } else { TextBox297.Text = sqldatareader_a6.GetString(25); }
                    //同锁骨上_散在
                    DropDownList84.SelectedValue = sqldatareader_a6.GetString(26).Trim();
                    //同锁骨上_活动
                    DropDownList85.SelectedValue = sqldatareader_a6.GetString(27).Trim();
                    //对侧腋窝15
                    DropDownList86.SelectedValue = sqldatareader_a6.GetString(15).Trim();
                    //对侧腋窝_数量
                    if (sqldatareader_a6.IsDBNull(28)) { TextBox298.Text = ""; } else { TextBox298.Text = sqldatareader_a6.GetString(28); }
                    //对侧腋窝_大小
                    if (sqldatareader_a6.IsDBNull(29)) { TextBox299.Text = ""; } else { TextBox299.Text = sqldatareader_a6.GetString(29); }
                    //对侧腋窝_散在
                    DropDownList87.SelectedValue = sqldatareader_a6.GetString(30).Trim();
                    //对侧腋窝_活动
                    DropDownList88.SelectedValue = sqldatareader_a6.GetString(31).Trim();
                    //对锁骨上16
                    DropDownList89.SelectedValue = sqldatareader_a6.GetString(16).Trim();
                    //对锁骨上_数量
                    if (sqldatareader_a6.IsDBNull(32)) { TextBox300.Text = ""; } else { TextBox300.Text = sqldatareader_a6.GetString(32); }
                    //对锁骨上_大小
                    if (sqldatareader_a6.IsDBNull(33)) { TextBox301.Text = ""; } else { TextBox301.Text = sqldatareader_a6.GetString(33); }
                    //对锁骨上_散在
                    DropDownList90.SelectedValue = sqldatareader_a6.GetString(34).Trim();
                    //对锁骨上_活动
                    DropDownList91.SelectedValue = sqldatareader_a6.GetString(35).Trim();
                }

                str += "<br />";
                str += "<div>专科查体</div>";
                if (DropDownList57.SelectedValue == "卫星结节") { str += "<div>乳房皮肤：卫星结节&nbsp;&nbsp;&nbsp;个数：" + TextBox314.Text + "</div>"; }
                else { str += "<div>乳房皮肤：" + DropDownList57.SelectedValue + "</div>"; }
                if (DropDownList58.SelectedValue == "湿疹样") { str += "<div>乳头：湿疹样&nbsp;&nbsp;&nbsp;湿疹范围：" + sqldatareader_a6.GetString(19).Trim() + "</div>"; }
                else { str += "乳头：" + DropDownList58.SelectedValue; }
                if (DropDownList59.SelectedValue == "有") { str += "<div>乳头溢液：有" + "&nbsp;&nbsp;&nbsp;" + DropDownList60.SelectedValue + DropDownList61.SelectedValue + DropDownList62.SelectedValue; }
                else { str += "<div>乳头溢液：无</div>"; }
                str += "<div><table border-collapse='0'><tr><td rowspan='2'>乳腺肿块：" + DropDownList63.SelectedValue + "&nbsp;</td>";
                str += "<td colspan='3'>位置：" + TextBox292.Text + "&nbsp;点，距离乳头&nbsp;" + TextBox293.Text + "cm" + "&nbsp;&nbsp;性质：" + DropDownList64.SelectedValue + "&nbsp;&nbsp;边界：" + DropDownList76.SelectedValue + "</td></tr>";
                str += "<tr><td>活动：" + DropDownList77.SelectedValue + "&nbsp;</td>" + "<td> 胸壁黏连：" + DropDownList78.SelectedValue + "&nbsp;</td>" + "<td>胸壁固定：" + DropDownList79.SelectedValue + "&nbsp;</td></tr></table></div>";
                str += "<div><table border-collapse='0'><tr><td>淋巴结：</td>";
                if (DropDownList80.SelectedValue == "有") { str += "<td>同侧腋窝：有&nbsp;&nbsp;数量(个)：" + TextBox294.Text + "&nbsp;&nbsp;大小(cm)：" + TextBox295.Text + "&nbsp;&nbsp;" + DropDownList81.SelectedValue + DropDownList82.SelectedValue + "</td></tr>"; }
                else { str += "<td>同侧腋窝：无</td></tr>"; }
                str += "<tr><td rowspan='3'></td>";
                if (DropDownList83.SelectedValue == "有") { str += "<td>同侧骨上：有&nbsp;&nbsp;数量(个)：" + TextBox296.Text + "&nbsp;&nbsp;大小(cm)：" + TextBox297.Text + "&nbsp;&nbsp;" + DropDownList84.SelectedValue + DropDownList85.SelectedValue + "</td></tr>"; }
                else { str += "<td>同侧骨上：无</td></tr>"; }
                if (DropDownList86.SelectedValue == "有") { str += "<tr><td>对侧腋窝：有&nbsp;&nbsp;数量(个)：" + TextBox298.Text + "&nbsp;&nbsp;大小(cm)：" + TextBox299.Text + "&nbsp;&nbsp;" + DropDownList87.SelectedValue + DropDownList88.SelectedValue + "</td></tr>"; }
                else { str += "<tr><td>对侧腋窝：无</td></tr>"; }
                if (DropDownList89.SelectedValue == "有") { str += "<tr><td>对锁骨上：有&nbsp;&nbsp;数量(个)：" + TextBox300.Text + "&nbsp;&nbsp;大小(cm)：" + TextBox301.Text + "&nbsp;&nbsp;" + DropDownList90.SelectedValue + DropDownList91.SelectedValue + "</td></tr></table></div>"; }
                else { str += "<tr><td>对锁骨上：无</td></tr></table></div>"; }

                sqlcommand_a6 = null;
                sqlconn_a6.Close();
                sqlconn_a6 = null;

                //a7导出
                SqlConnection sqlconn_a7 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_a7 = new SqlCommand();
                sqlcommand_a7.Connection = sqlconn_a7;

                sqlconn_a7.Open();//attention
                sqlcommand_a7.CommandText = "select * from a其他 where 就诊卡号=@就诊卡号";
                sqlcommand_a7.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_a7 = sqlcommand_a7.ExecuteReader();
                if (sqldatareader_a7.Read())
                {
                    //远处转移_有无
                    DropDownList65.SelectedValue = sqldatareader_a7.GetString(0).Trim();
                    //远处转移_情况
                    string a7_1 = sqldatareader_a7.GetString(1).Trim();
                    if (a7_1.Contains("对乳")) { CheckBox62.Checked = true; }
                    if (a7_1.Contains("对腋窝")) { CheckBox63.Checked = true; }
                    if (a7_1.Contains("对锁骨上")) { CheckBox64.Checked = true; }
                    if (a7_1.Contains("肺")) { CheckBox65.Checked = true; }
                    if (a7_1.Contains("肝")) { CheckBox66.Checked = true; }
                    if (a7_1.Contains("骨")) { CheckBox67.Checked = true; }
                    if (a7_1.Contains("脑")) { CheckBox68.Checked = true; }
                    if (a7_1.Contains("其他")) { CheckBox69.Checked = true; }
                    //T
                    if (sqldatareader_a7.IsDBNull(2)) { TextBox265.Text = ""; } else { TextBox265.Text = sqldatareader_a7.GetString(2); }
                    //N
                    if (sqldatareader_a7.IsDBNull(3)) { TextBox266.Text = ""; } else { TextBox266.Text = sqldatareader_a7.GetString(3); }
                    //M
                    if (sqldatareader_a7.IsDBNull(4)) { TextBox267.Text = ""; } else { TextBox267.Text = sqldatareader_a7.GetString(4); }
                    //辅助检查_有无
                    DropDownList66.SelectedValue = sqldatareader_a7.GetString(5).Trim();
                    //B超
                    DropDownList92.SelectedValue = sqldatareader_a7.GetString(6).Trim();
                    //钼靶
                    DropDownList93.SelectedValue = sqldatareader_a7.GetString(7).Trim();
                    //CT
                    DropDownList94.SelectedValue = sqldatareader_a7.GetString(8).Trim();
                    //MRI
                    DropDownList95.SelectedValue = sqldatareader_a7.GetString(9).Trim();
                }

                str += "<br />";
                str += "<div>其他</div>";
                str += "<div>远处转移：";
                if (DropDownList65.SelectedValue == "有") { str += "有&nbsp;&nbsp;" + sqldatareader_a7.GetString(1).Trim() + "</div>"; }
                else { str += "无</div>"; }
                str += "<div>TNM分期：";
                str += "T" + TextBox265.Text + "&nbsp;&nbsp;N" + TextBox266.Text + "&nbsp;&nbsp;M" + TextBox267.Text + "</div>";
                str += "<div>辅助检查";
                if (DropDownList66.SelectedValue == "有") { str += "有</div>" + "<div>B超：" + DropDownList92.SelectedValue + "&nbsp;&nbsp;钼靶：" + DropDownList93.SelectedValue + "&nbsp;&nbsp;CT：" + DropDownList94.SelectedValue + "&nbsp;&nbsp;MRI：" + DropDownList95.SelectedValue + "</div>"; }
                else { str += "无</div>"; }

                sqlcommand_a7 = null;
                sqlconn_a7.Close();
                sqlconn_a7 = null;

                SqlConnection sqlconn_b1 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_b1 = new SqlCommand();
                sqlcommand_b1.Connection = sqlconn_b1;

                //b1导出
                sqlconn_b1.Open();//attention
                sqlcommand_b1.CommandText = "select * from b术前检查 where 就诊卡号=@就诊卡号";
                sqlcommand_b1.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_b1 = sqlcommand_b1.ExecuteReader();
                if (sqldatareader_b1.Read())
                {
                    //阴阳性
                    if (sqldatareader_b1.GetString(0) == "") { }
                    else { RadioButtonList1.SelectedValue = sqldatareader_b1.GetString(0).Trim(); }
                    //触诊有无
                    if (sqldatareader_b1.GetString(1) == "") { }
                    else { RadioButtonList2.SelectedValue = sqldatareader_b1.GetString(1).Trim(); }
                    //触诊个数
                    if (sqldatareader_b1.IsDBNull(2)) { TextBox24.Text = ""; } else { TextBox24.Text = sqldatareader_b1.GetString(2); }
                    //触诊最大_cm
                    if (sqldatareader_b1.IsDBNull(3)) { TextBox25.Text = ""; } else { TextBox25.Text = sqldatareader_b1.GetString(3); }
                    //触诊性质
                    if (sqldatareader_b1.GetString(4) == "") { }
                    else { RadioButtonList3.SelectedValue = sqldatareader_b1.GetString(4).Trim(); }
                    //超声有无
                    if (sqldatareader_b1.GetString(5) == "") { }
                    else { RadioButtonList4.SelectedValue = sqldatareader_b1.GetString(5).Trim(); }
                    //超声个数
                    if (sqldatareader_b1.GetString(6) == "") { TextBox26.Text = ""; } else { TextBox26.Text = sqldatareader_b1.GetString(6); }
                    //超声最大_cm
                    if (sqldatareader_b1.GetString(7) == "") { TextBox27.Text = ""; } else { TextBox27.Text = sqldatareader_b1.GetString(7); }
                    //超声性质
                    if (sqldatareader_b1.GetString(8) == "") { }
                    else { RadioButtonList5.SelectedValue = sqldatareader_b1.GetString(8).Trim(); }
                    //钼靶有无
                    if (sqldatareader_b1.GetString(9) == "") { }
                    else { RadioButtonList6.SelectedValue = sqldatareader_b1.GetString(9).Trim(); }
                    //钼靶个数10
                    if (sqldatareader_b1.GetString(10) == "") { TextBox28.Text = ""; } else { TextBox28.Text = sqldatareader_b1.GetString(10); }
                    //钼靶最大_cm11
                    if (sqldatareader_b1.GetString(11) == "") { TextBox29.Text = ""; } else { TextBox29.Text = sqldatareader_b1.GetString(11); }
                    //钼靶性质12
                    if (sqldatareader_b1.GetString(12) == "") { }
                    else { RadioButtonList7.SelectedValue = sqldatareader_b1.GetString(12).Trim(); }
                    //核磁有无
                    if (sqldatareader_b1.GetString(13) == "") { }
                    else { RadioButtonList8.SelectedValue = sqldatareader_b1.GetString(13).Trim(); }
                    //核磁个数
                    if (sqldatareader_b1.GetString(14) == "") { TextBox30.Text = ""; } else { TextBox30.Text = sqldatareader_b1.GetString(14); }
                    //核磁最大_cm
                    if (sqldatareader_b1.GetString(15) == "") { TextBox31.Text = ""; } else { TextBox31.Text = sqldatareader_b1.GetString(15); }
                    //核磁性质
                    if (sqldatareader_b1.GetString(16) == "") { }
                    else { RadioButtonList9.SelectedValue = sqldatareader_b1.GetString(16).Trim(); }
                    //临床腋窝分期
                    if (sqldatareader_b1.GetString(17) == "") { }
                    else
                    {
                        DropDownList12.SelectedValue = sqldatareader_b1.GetString(17).Trim();
                    }
                    //粗针
                    if (sqldatareader_b1.GetString(18) == "") { TextBox32.Text = ""; } else { TextBox32.Text = sqldatareader_b1.GetString(18); }
                    //细针
                    if (sqldatareader_b1.GetString(19) == "") { TextBox33.Text = ""; } else { TextBox33.Text = sqldatareader_b1.GetString(19); }
                    //针号
                    if (sqldatareader_b1.GetString(20) == "") { TextBox34.Text = ""; } else { TextBox34.Text = sqldatareader_b1.GetString(20); }
                    //标本条数
                    if (sqldatareader_b1.GetString(21) == "") { TextBox35.Text = ""; } else { TextBox35.Text = sqldatareader_b1.GetString(21); }
                    //病理
                    if (sqldatareader_b1.GetString(22) == "") { TextBox36.Text = ""; } else { TextBox36.Text = sqldatareader_b1.GetString(22); }
                    //免疫
                    if (sqldatareader_b1.GetString(23) == "") { TextBox37.Text = ""; } else { TextBox37.Text = sqldatareader_b1.GetString(23); }
                }
                sqlcommand_b1 = null;
                sqlconn_b1.Close();
                sqlconn_b1 = null;
                str += "<br />";
                str += "<div>术前检查</div>";
                str += "<div>SLN检查";
                if (RadioButtonList1.SelectedValue == "阳性")
                {
                    str += "阳性</div>";
                    if (RadioButtonList2.SelectedValue == "有") { str += "<div>触诊：有&nbsp;" + TextBox24.Text + "个，最大&nbsp;" + TextBox25.Text + "cm" + RadioButtonList3.SelectedValue + "</div>"; }
                    else { str += "<div>触诊：无</div>"; }
                    if (RadioButtonList4.SelectedValue == "有") { str += "<div>超声：有&nbsp;" + TextBox26.Text + "个，最大&nbsp;" + TextBox27.Text + "cm" + RadioButtonList5.SelectedValue + "</div>"; }
                    else { str += "<div>超声：无</div>"; }
                    if (RadioButtonList6.SelectedValue == "有") { str += "<div>钼靶：有&nbsp;" + TextBox28.Text + "个，最大&nbsp;" + TextBox29.Text + "cm" + RadioButtonList7.SelectedValue + "</div>"; }
                    else { str += "<div>钼靶：无</div>"; }
                    if (RadioButtonList8.SelectedValue == "有") { str += "<div>核磁：有&nbsp;" + TextBox30.Text + "个，最大&nbsp;" + TextBox31.Text + "cm" + RadioButtonList9.SelectedValue + "</div>"; }
                    else { str += "<div>核磁：无</div>"; }
                    str += "<div>临床腋窝分期：" + DropDownList12.SelectedValue + "</div>";
                }
                else { str += "阴性</div>"; }
                str += "<div>术前穿刺活检</div>";
                str += "<div>粗针:" + TextBox32.Text + "&nbsp;&nbsp;细针:" + TextBox33.Text + "&nbsp;&nbsp;针号:" + TextBox34.Text + "</div>";
                str += "<div>标本:" + TextBox35.Text + "&nbsp;条" + "&nbsp;&nbsp;病理:" + TextBox36.Text + "</div>";
                str += "<div>免疫:" + TextBox37.Text + "</div>";

                //b2导出
                SqlConnection sqlconn_b2 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_b2 = new SqlCommand();
                sqlcommand_b2.Connection = sqlconn_b2;

                sqlconn_b2.Open();//attention
                sqlcommand_b2.CommandText = "select * from b术中实施SLNB where 就诊卡号=@就诊卡号";
                sqlcommand_b2.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_b2 = sqlcommand_b2.ExecuteReader();
                if (sqldatareader_b2.Read())
                {

                    if (sqldatareader_b2.IsDBNull(1)) { } else { DropDownList13.SelectedValue = sqldatareader_b2.GetString(1).Trim(); }
                    if (sqldatareader_b2.IsDBNull(2)) { TextBox164.Text = ""; } else { TextBox164.Text = sqldatareader_b2.GetString(2); }
                    if (sqldatareader_b2.IsDBNull(3)) { } else { DropDownList14.SelectedValue = sqldatareader_b2.GetString(3).Trim(); }
                    if (sqldatareader_b2.IsDBNull(4)) { TextBox164.Text = ""; } else { DropDownList15.SelectedValue = sqldatareader_b2.GetString(4).Trim(); }
                    if (sqldatareader_b2.GetString(5) == "") { } else { RadioButtonList10.SelectedValue = sqldatareader_b2.GetString(5).Trim(); }
                    if (sqldatareader_b2.IsDBNull(6)) { TextBox38.Text = ""; } else { TextBox38.Text = sqldatareader_b2.GetString(6); }
                    if (sqldatareader_b2.IsDBNull(7)) { TextBox38.Text = ""; } else { TextBox39.Text = sqldatareader_b2.GetString(7); }
                    if (sqldatareader_b2.IsDBNull(8)) { } else { DropDownList16.SelectedValue = sqldatareader_b2.GetString(8).Trim(); }

                    //注射时间
                    string b21 = sqldatareader_b2.GetString(9);
                    string[] b22;
                    b22 = b21.Split(':');
                    string[] b22_1;
                    b22_1 = b22[0].Split(' ');
                    TextBox44.Text = b22_1[0];
                    TextBox45.Text = b22_1[1];
                    TextBox46.Text = b22[1];
                    TextBox47.Text = b22[2];

                    //手术开始时间
                    string b2a1 = sqldatareader_b2.GetString(10);
                    string[] b2a2;
                    b2a2 = b2a1.Split(':');
                    string[] b2a2_1;
                    b2a2_1 = b2a2[0].Split(' ');
                    TextBox40.Text = b2a2_1[0];
                    TextBox41.Text = b2a2_1[1];
                    TextBox42.Text = b2a2[1];
                    TextBox43.Text = b2a2[2];

                    //摘除SLN时间
                    string b2b1 = sqldatareader_b2.GetString(11);
                    string[] b2b2;
                    b2b2 = b2b1.Split(':');
                    string[] b2b2_1;
                    b2b2_1 = b2b2[0].Split(' ');
                    TextBox48.Text = b2b2_1[0];
                    TextBox49.Text = b2b2_1[1];
                    TextBox50.Text = b2b2[1];
                    TextBox51.Text = b2b2[2];

                    if (sqldatareader_b2.IsDBNull(12)) { } else { DropDownList17.SelectedValue = sqldatareader_b2.GetString(12).Trim(); }
                    if (sqldatareader_b2.IsDBNull(13)) { } else { DropDownList18.SelectedValue = sqldatareader_b2.GetString(13).Trim(); }
                    if (sqldatareader_b2.IsDBNull(14)) { } else { DropDownList19.SelectedValue = sqldatareader_b2.GetString(14).Trim(); }
                    if (sqldatareader_b2.IsDBNull(15)) { TextBox52.Text = ""; } else { TextBox52.Text = sqldatareader_b2.GetString(15); }
                    if (sqldatareader_b2.IsDBNull(16)) { TextBox53.Text = ""; } else { TextBox53.Text = sqldatareader_b2.GetString(16); }
                    if (sqldatareader_b2.IsDBNull(17)) { TextBox54.Text = ""; } else { TextBox54.Text = sqldatareader_b2.GetString(17); }
                    if (sqldatareader_b2.IsDBNull(18)) { } else { DropDownList20.SelectedValue = sqldatareader_b2.GetString(18).Trim(); }
                    if (sqldatareader_b2.IsDBNull(19)) { TextBox55.Text = ""; } else { TextBox55.Text = sqldatareader_b2.GetString(19); }
                    if (sqldatareader_b2.IsDBNull(20)) { } else { DropDownList21.SelectedValue = sqldatareader_b2.GetString(20).Trim(); }
                    if (sqldatareader_b2.IsDBNull(21)) { TextBox165.Text = ""; } else { TextBox165.Text = sqldatareader_b2.GetString(21); }
                    if (sqldatareader_b2.IsDBNull(22)) { TextBox56.Text = ""; } else { TextBox56.Text = sqldatareader_b2.GetString(22); }
                }

                str += "<br />";
                str += "<div>术中实施SLNB</div>";
                str += "<div>示踪信息</div>";
                if (DropDownList13.SelectedValue == "联合法") { str += "<div>示踪方法：联合法&nbsp;" + TextBox164.Text + "</div>"; }
                else { str += "<div>示踪方法：" + DropDownList13.SelectedValue + "</div>"; }
                str += "<div>示踪药：" + DropDownList14.SelectedValue + "</div>";
                str += "<div>注射量：" + DropDownList15.SelectedValue + "</div>";
                if (RadioButtonList10.SelectedValue == "淋巴结内") { str += "<div>注射位置：淋巴结内</div>"; }
                else
                {
                    if (RadioButtonList10.SelectedValue == "乳晕") { str += "<div>注射位置：乳晕&nbsp;&nbsp;" + "乳晕周&nbsp;" + TextBox38.Text + "点</div>"; }
                    else { str += "<div>注射位置：肿瘤&nbsp;&nbsp;" + "肿瘤周&nbsp;" + TextBox39.Text + "点</div>"; }
                }
                str += "<div>注射层次：" + DropDownList16.SelectedValue + "</div>";
                str += "<div>注射时间：" + sqldatareader_b2.GetString(9) + "</div>";
                str += "<div>手术开始时间：" + sqldatareader_b2.GetString(10) + "</div>";
                str += "<div>SLN信息</div>";
                str += "<div>摘除SLN时间：" + sqldatareader_b2.GetString(11) + "</div>";
                str += "<div>发现SLN位置：" + DropDownList17.SelectedValue + "</div>";
                str += "<div>SLN数目：" + DropDownList18.SelectedValue + "</div>";
                str += "<div>SLN类型：" + DropDownList19.SelectedValue + "</div>";
                str += "<div>SLN最大直径：长轴&nbsp;" + TextBox52.Text + "cm&nbsp;&nbsp;短轴&nbsp;" + TextBox53.Text + "cm&nbsp;&nbsp;厚度&nbsp;" + TextBox54.Text + "cm" + "</div>";
                str += "<div>SLN处理方式：" + DropDownList20.SelectedValue + "</div>";
                str += "<div>SLN病理(冰冻)：" + TextBox55.Text + "</div>";
                if (DropDownList21.SelectedValue == "其它") { str += "<div>SLN免疫组化：其它&nbsp;" + TextBox165.Text + "</div>"; }
                else { str += "<div>SLN免疫组化：" + DropDownList21.SelectedValue + "</div>"; }
                str += "<div>SLNB操作者：" + TextBox56.Text + "</div>";
                sqlcommand_b2 = null;
                sqlconn_b2.Close();
                sqlconn_b2 = null;

                //b3术中行ARM
                SqlConnection sqlconn_b3 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_b3 = new SqlCommand();
                sqlcommand_b3.Connection = sqlconn_b3;

                sqlconn_b3.Open();//attention
                sqlcommand_b3.CommandText = "select * from b术中行ARM where 就诊卡号=@就诊卡号";
                sqlcommand_b3.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_b3 = sqlcommand_b3.ExecuteReader();
                if (sqldatareader_b3.Read())
                {
                    if (sqldatareader_b3.IsDBNull(1)) { } else { DropDownList22.SelectedValue = sqldatareader_b3.GetString(1).Trim(); }
                    if (sqldatareader_b3.IsDBNull(2)) { TextBox166.Text = ""; } else { TextBox166.Text = sqldatareader_b3.GetString(2); }
                    if (sqldatareader_b3.IsDBNull(3)) { } else { DropDownList23.SelectedValue = sqldatareader_b3.GetString(3).Trim(); }
                    if (sqldatareader_b3.IsDBNull(4)) { } else { DropDownList24.SelectedValue = sqldatareader_b3.GetString(4).Trim(); }
                    if (sqldatareader_b3.GetString(5) == "") { } else { RadioButtonList11.SelectedValue = sqldatareader_b3.GetString(5).Trim(); }
                    if (sqldatareader_b3.IsDBNull(6)) { TextBox57.Text = ""; } else { TextBox57.Text = sqldatareader_b3.GetString(6); }
                    if (sqldatareader_b3.IsDBNull(7)) { TextBox58.Text = ""; } else { TextBox58.Text = sqldatareader_b3.GetString(7); }
                    if (sqldatareader_b3.IsDBNull(8)) { } else { DropDownList25.SelectedValue = sqldatareader_b3.GetString(8).Trim(); }

                    //注射时间
                    string b31 = sqldatareader_b3.GetString(9);
                    string[] b32;
                    b32 = b31.Split(':');
                    string[] b32_1;
                    b32_1 = b32[0].Split(' ');
                    TextBox44.Text = b32_1[0];
                    TextBox45.Text = b32_1[1];
                    TextBox46.Text = b32[1];
                    TextBox47.Text = b32[2];

                    //手术开始时间
                    string b3a1 = sqldatareader_b3.GetString(10);
                    string[] b3a2;
                    b3a2 = b3a1.Split(':');
                    string[] b3a2_1;
                    b3a2_1 = b3a2[0].Split(' ');
                    TextBox40.Text = b3a2_1[0];
                    TextBox41.Text = b3a2_1[1];
                    TextBox42.Text = b3a2[1];
                    TextBox43.Text = b3a2[2];

                    //摘除ARM时间
                    string b3b1 = sqldatareader_b3.GetString(11);
                    string[] b3b2;
                    b3b2 = b3b1.Split(':');
                    string[] b3b2_1;
                    b3b2_1 = b3b2[0].Split(' ');
                    TextBox48.Text = b3b2_1[0];
                    TextBox49.Text = b3b2_1[1];
                    TextBox50.Text = b3b2[1];
                    TextBox51.Text = b3b2[2];


                    if (sqldatareader_b3.IsDBNull(12)) { } else { DropDownList26.SelectedValue = sqldatareader_b3.GetString(12).Trim(); }
                    if (sqldatareader_b3.IsDBNull(13)) { } else { DropDownList27.SelectedValue = sqldatareader_b3.GetString(13).Trim(); }
                    if (sqldatareader_b3.IsDBNull(14)) { } else { DropDownList28.SelectedValue = sqldatareader_b3.GetString(14).Trim(); }
                    if (sqldatareader_b3.IsDBNull(15)) { TextBox74.Text = ""; } else { TextBox74.Text = sqldatareader_b3.GetString(15); }
                    if (sqldatareader_b3.IsDBNull(16)) { TextBox75.Text = ""; } else { TextBox75.Text = sqldatareader_b3.GetString(16); }
                }
                str += "<br />";
                str += "<div>术中行ARM</div>";
                str += "<div>示踪信息</div>";
                if (DropDownList22.SelectedValue == "联合法") { str += "<div>示踪方法：联合法&nbsp;" + TextBox166.Text + "</div>"; }
                else { str += "<div>示踪方法：" + DropDownList22.SelectedValue + "</div>"; }
                str += "<div>示踪药：" + DropDownList23.SelectedValue + "</div>";
                str += "<div>注射量：" + DropDownList24.SelectedValue + "</div>";
                if (RadioButtonList11.SelectedValue == "肱二头肌、肱三头肌间沟") { str += "<div>注射位置：肱二头肌、肱三头肌间沟&nbsp;&nbsp;距离腋窝皱襞&nbsp;" + TextBox57.Text + "cm </div>"; }
                else { str += "<div>注射位置：其他&nbsp;&nbsp;" + "肿瘤周&nbsp;" + TextBox58.Text + "点</div>"; }
                str += "<div>注射层次：" + DropDownList25.SelectedValue + "</div>";
                str += "<div>注射时间：" + sqldatareader_b3.GetString(9) + "</div>";
                str += "<div>手术开始时间：" + sqldatareader_b3.GetString(10) + "</div>";
                str += "<div>ARM信息</div>";
                str += "<div>摘除ARM时间：" + sqldatareader_b3.GetString(11) + "</div>";
                str += "<div>ARM位置：" + DropDownList26.SelectedValue + "</div>";
                str += "<div>ARM数目：" + DropDownList27.SelectedValue + "</div>";
                str += "<div>SLN类型：" + DropDownList28.SelectedValue + "</div>";
                str += "<div>SLN病理(冰冻)：" + TextBox74.Text + "</div>";
                str += "<div>操作者：" + TextBox75.Text + "</div>";
                sqlcommand_b3 = null;
                sqlconn_b3.Close();
                sqlconn_b3 = null;

                //b4导出
                SqlConnection sqlconn_b4 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_b4 = new SqlCommand();
                sqlcommand_b4.Connection = sqlconn_b4;

                sqlconn_b4.Open();//attention
                sqlcommand_b4.CommandText = "select * from b腋窝状况记录 where 就诊卡号=@就诊卡号";
                sqlcommand_b4.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_b4 = sqlcommand_b4.ExecuteReader();
                if (sqldatareader_b4.Read())
                {
                    string b4_1 = sqldatareader_b4.GetString(1);
                    string b4_2 = sqldatareader_b4.GetString(2);
                    if (b4_1 != "" || b4_2 != "")
                    {
                        RadioButtonList12.SelectedValue = "SNL病理";
                        TextBox71.Text = b4_1; TextBox73.Text = b4_2;
                    }

                    string b4_3 = sqldatareader_b4.GetString(3);
                    string b4_4 = sqldatareader_b4.GetString(4);
                    if (b4_3 != "" || b4_4 != "")
                    {
                        RadioButtonList12.SelectedValue = "ARM病理";
                        TextBox72.Text = b4_3; TextBox76.Text = b4_4;
                    }
                    if (sqldatareader_b4.IsDBNull(5)) { TextBox77.Text = ""; } else { TextBox77.Text = sqldatareader_b4.GetString(5); }
                    if (sqldatareader_b4.IsDBNull(6)) { TextBox78.Text = ""; } else { TextBox78.Text = sqldatareader_b4.GetString(6); }
                    if (sqldatareader_b4.IsDBNull(7)) { TextBox79.Text = ""; } else { TextBox79.Text = sqldatareader_b4.GetString(7); }
                    if (sqldatareader_b4.IsDBNull(8)) { TextBox80.Text = ""; } else { TextBox80.Text = sqldatareader_b4.GetString(8); }
                    if (sqldatareader_b4.IsDBNull(9)) { TextBox81.Text = ""; } else { TextBox81.Text = sqldatareader_b4.GetString(9); }
                    if (sqldatareader_b4.IsDBNull(10)) { TextBox82.Text = ""; } else { TextBox82.Text = sqldatareader_b4.GetString(10); }//患肢(肘上10cm)/ml
                    if (sqldatareader_b4.IsDBNull(11)) { TextBox83.Text = ""; } else { TextBox83.Text = sqldatareader_b4.GetString(11); }
                    if (sqldatareader_b4.IsDBNull(12)) { TextBox84.Text = ""; } else { TextBox84.Text = sqldatareader_b4.GetString(12); }
                    if (sqldatareader_b4.IsDBNull(13)) { TextBox85.Text = ""; } else { TextBox85.Text = sqldatareader_b4.GetString(13); }
                    if (sqldatareader_b4.IsDBNull(14)) { TextBox86.Text = ""; } else { TextBox86.Text = sqldatareader_b4.GetString(14); }
                    if (sqldatareader_b4.IsDBNull(15)) { TextBox87.Text = ""; } else { TextBox87.Text = sqldatareader_b4.GetString(15); }
                    if (sqldatareader_b4.IsDBNull(16)) { TextBox88.Text = ""; } else { TextBox88.Text = sqldatareader_b4.GetString(16); }//对侧肢(肘上10cm)/ml
                    if (sqldatareader_b4.IsDBNull(17)) { TextBox95.Text = ""; } else { TextBox95.Text = sqldatareader_b4.GetString(17); }
                    if (sqldatareader_b4.IsDBNull(18)) { TextBox96.Text = ""; } else { TextBox96.Text = sqldatareader_b4.GetString(18); }
                    if (sqldatareader_b4.IsDBNull(19)) { TextBox97.Text = ""; } else { TextBox97.Text = sqldatareader_b4.GetString(19); }
                    if (sqldatareader_b4.IsDBNull(20)) { TextBox98.Text = ""; } else { TextBox98.Text = sqldatareader_b4.GetString(20); }
                    if (sqldatareader_b4.IsDBNull(21)) { TextBox99.Text = ""; } else { TextBox99.Text = sqldatareader_b4.GetString(21); }
                    if (sqldatareader_b4.IsDBNull(22)) { TextBox100.Text = ""; } else { TextBox100.Text = sqldatareader_b4.GetString(22); }//患肢_肘下
                    if (sqldatareader_b4.IsDBNull(23)) { TextBox101.Text = ""; } else { TextBox101.Text = sqldatareader_b4.GetString(23); }
                    if (sqldatareader_b4.IsDBNull(24)) { TextBox102.Text = ""; } else { TextBox102.Text = sqldatareader_b4.GetString(24); }
                    if (sqldatareader_b4.IsDBNull(25)) { TextBox103.Text = ""; } else { TextBox103.Text = sqldatareader_b4.GetString(25); }
                    if (sqldatareader_b4.IsDBNull(26)) { TextBox104.Text = ""; } else { TextBox104.Text = sqldatareader_b4.GetString(26); }
                    if (sqldatareader_b4.IsDBNull(27)) { TextBox105.Text = ""; } else { TextBox105.Text = sqldatareader_b4.GetString(27); }
                    if (sqldatareader_b4.IsDBNull(28)) { TextBox106.Text = ""; } else { TextBox106.Text = sqldatareader_b4.GetString(28); }//对侧肢_肘下
                    if (sqldatareader_b4.IsDBNull(29)) { TextBox113.Text = ""; } else { TextBox113.Text = sqldatareader_b4.GetString(29); }
                    if (sqldatareader_b4.IsDBNull(30)) { TextBox114.Text = ""; } else { TextBox114.Text = sqldatareader_b4.GetString(30); }
                    if (sqldatareader_b4.IsDBNull(31)) { TextBox115.Text = ""; } else { TextBox115.Text = sqldatareader_b4.GetString(31); }
                    if (sqldatareader_b4.IsDBNull(32)) { TextBox116.Text = ""; } else { TextBox116.Text = sqldatareader_b4.GetString(32); }
                    if (sqldatareader_b4.IsDBNull(33)) { TextBox117.Text = ""; } else { TextBox117.Text = sqldatareader_b4.GetString(33); }
                    if (sqldatareader_b4.IsDBNull(34)) { TextBox118.Text = ""; } else { TextBox118.Text = sqldatareader_b4.GetString(34); }//患侧_手腕
                    if (sqldatareader_b4.IsDBNull(35)) { TextBox119.Text = ""; } else { TextBox119.Text = sqldatareader_b4.GetString(35); }
                    if (sqldatareader_b4.IsDBNull(36)) { TextBox120.Text = ""; } else { TextBox120.Text = sqldatareader_b4.GetString(36); }
                    if (sqldatareader_b4.IsDBNull(37)) { TextBox121.Text = ""; } else { TextBox121.Text = sqldatareader_b4.GetString(37); }
                    if (sqldatareader_b4.IsDBNull(38)) { TextBox122.Text = ""; } else { TextBox122.Text = sqldatareader_b4.GetString(38); }
                    if (sqldatareader_b4.IsDBNull(39)) { TextBox123.Text = ""; } else { TextBox123.Text = sqldatareader_b4.GetString(39); }
                    if (sqldatareader_b4.IsDBNull(40)) { TextBox124.Text = ""; } else { TextBox124.Text = sqldatareader_b4.GetString(40); }//对侧_手腕
                    if (sqldatareader_b4.IsDBNull(41)) { TextBox89.Text = ""; } else { TextBox89.Text = sqldatareader_b4.GetString(41); }
                    if (sqldatareader_b4.IsDBNull(42)) { TextBox90.Text = ""; } else { TextBox90.Text = sqldatareader_b4.GetString(42); }
                    if (sqldatareader_b4.IsDBNull(43)) { TextBox91.Text = ""; } else { TextBox91.Text = sqldatareader_b4.GetString(43); }
                    if (sqldatareader_b4.IsDBNull(44)) { TextBox92.Text = ""; } else { TextBox92.Text = sqldatareader_b4.GetString(44); }
                    if (sqldatareader_b4.IsDBNull(45)) { TextBox93.Text = ""; } else { TextBox93.Text = sqldatareader_b4.GetString(45); }
                    if (sqldatareader_b4.IsDBNull(46)) { TextBox94.Text = ""; } else { TextBox94.Text = sqldatareader_b4.GetString(46); }//肘上_体重
                    if (sqldatareader_b4.IsDBNull(47)) { TextBox107.Text = ""; } else { TextBox107.Text = sqldatareader_b4.GetString(47); }
                    if (sqldatareader_b4.IsDBNull(48)) { TextBox108.Text = ""; } else { TextBox108.Text = sqldatareader_b4.GetString(48); }
                    if (sqldatareader_b4.IsDBNull(49)) { TextBox109.Text = ""; } else { TextBox109.Text = sqldatareader_b4.GetString(49); }
                    if (sqldatareader_b4.IsDBNull(50)) { TextBox110.Text = ""; } else { TextBox110.Text = sqldatareader_b4.GetString(50); }
                    if (sqldatareader_b4.IsDBNull(51)) { TextBox111.Text = ""; } else { TextBox111.Text = sqldatareader_b4.GetString(51); }
                    if (sqldatareader_b4.IsDBNull(52)) { TextBox112.Text = ""; } else { TextBox112.Text = sqldatareader_b4.GetString(52); }//肘下_体重
                    if (sqldatareader_b4.IsDBNull(53)) { TextBox125.Text = ""; } else { TextBox125.Text = sqldatareader_b4.GetString(53); }
                    if (sqldatareader_b4.IsDBNull(54)) { TextBox126.Text = ""; } else { TextBox126.Text = sqldatareader_b4.GetString(54); }
                    if (sqldatareader_b4.IsDBNull(55)) { TextBox127.Text = ""; } else { TextBox127.Text = sqldatareader_b4.GetString(55); }
                    if (sqldatareader_b4.IsDBNull(56)) { TextBox128.Text = ""; } else { TextBox128.Text = sqldatareader_b4.GetString(56); }
                    if (sqldatareader_b4.IsDBNull(57)) { TextBox129.Text = ""; } else { TextBox129.Text = sqldatareader_b4.GetString(57); }
                    if (sqldatareader_b4.IsDBNull(58)) { TextBox130.Text = ""; } else { TextBox130.Text = sqldatareader_b4.GetString(58); }//手腕_体重_

                }
                sqlcommand_b4 = null;
                sqlconn_b4.Close();
                sqlconn_b4 = null;
                str += "<br />";
                str += "<div>腋窝状况记录</div>";
                str += "<div>术后病理</div>";
                if (RadioButtonList12.SelectedValue == "SNL病理") { str += "<div>SNL病理&nbsp;" + TextBox71.Text + "&nbsp;&nbsp;免疫组化&nbsp;" + TextBox73.Text + "</div>"; }
                else { str += "<div>ARM病理&nbsp;" + TextBox72.Text + "&nbsp;&nbsp;免疫组化&nbsp;" + TextBox76.Text + "</div>"; }
                str += "<div>患肢情况随访</div>";
                str += "<div><table border-collapse='0'><tr><td>&nbsp;&nbsp;</td><td>术前</td><td>术后1月</td><td>术后3月</td><td>术后6月</td><td>术后1年</td><td>术后2年</td></tr>";
                str += "<tr><td>患肢(肘上10cm)/ml</td>" + "<td>" + TextBox77.Text + "</td>" + "<td>" + TextBox78.Text + "</td>" + "<td>" + TextBox79.Text + "</td>" + "<td>" + TextBox80.Text + "</td>" + "<td>" + TextBox81.Text + "</td>" + "<td>" + TextBox82.Text + "</td></tr>";
                str += "<tr><td>对侧肢(肘上10cm)/ml</td>" + "<td>" + TextBox83.Text + "</td>" + "<td>" + TextBox84.Text + "</td>" + "<td>" + TextBox85.Text + "</td>" + "<td>" + TextBox86.Text + "</td>" + "<td>" + TextBox87.Text + "</td>" + "<td>" + TextBox88.Text + "</td></tr>";
                str += "<tr><td>体重/kg</td>" + "<td>" + TextBox89.Text + "</td>" + "<td>" + TextBox90.Text + "</td>" + "<td>" + TextBox91.Text + "</td>" + "<td>" + TextBox92.Text + "</td>" + "<td>" + TextBox93.Text + "</td>" + "<td>" + TextBox94.Text + "</td></tr>";
                str += "<tr><td>患肢(肘下10cm)/ml</td>" + "<td>" + TextBox95.Text + "</td>" + "<td>" + TextBox96.Text + "</td>" + "<td>" + TextBox97.Text + "</td>" + "<td>" + TextBox98.Text + "</td>" + "<td>" + TextBox99.Text + "</td>" + "<td>" + TextBox100.Text + "</td></tr>";
                str += "<tr><td>对侧肢(肘下10cm)/ml</td>" + "<td>" + TextBox101.Text + "</td>" + "<td>" + TextBox102.Text + "</td>" + "<td>" + TextBox103.Text + "</td>" + "<td>" + TextBox104.Text + "</td>" + "<td>" + TextBox105.Text + "</td>" + "<td>" + TextBox106.Text + "</td></tr>";
                str += "<tr><td>体重/kg</td>" + "<td>" + TextBox107.Text + "</td>" + "<td>" + TextBox108.Text + "</td>" + "<td>" + TextBox109.Text + "</td>" + "<td>" + TextBox110.Text + "</td>" + "<td>" + TextBox111.Text + "</td>" + "<td>" + TextBox112.Text + "</td></tr>";
                str += "<tr><td>患侧手腕/ml</td>" + "<td>" + TextBox113.Text + "</td>" + "<td>" + TextBox114.Text + "</td>" + "<td>" + TextBox115.Text + "</td>" + "<td>" + TextBox116.Text + "</td>" + "<td>" + TextBox117.Text + "</td>" + "<td>" + TextBox118.Text + "</td></tr>";
                str += "<tr><td>对侧手腕/ml</td>" + "<td>" + TextBox119.Text + "</td>" + "<td>" + TextBox120.Text + "</td>" + "<td>" + TextBox121.Text + "</td>" + "<td>" + TextBox122.Text + "</td>" + "<td>" + TextBox123.Text + "</td>" + "<td>" + TextBox124.Text + "</td></tr>";
                str += "<tr><td>体重/kg</td>" + "<td>" + TextBox125.Text + "</td>" + "<td>" + TextBox126.Text + "</td>" + "<td>" + TextBox127.Text + "</td>" + "<td>" + TextBox128.Text + "</td>" + "<td>" + TextBox129.Text + "</td>" + "<td>" + TextBox130.Text + "</td></tr></table></div>";

                //c1导出
                SqlConnection sqlconn_c1 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_c1 = new SqlCommand();
                sqlcommand_c1.Connection = sqlconn_c1;

                sqlconn_c1.Open();//attention
                sqlcommand_c1.CommandText = "select * from c术前化疗 where 就诊卡号=@就诊卡号";
                sqlcommand_c1.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_c1 = sqlcommand_c1.ExecuteReader();
                if (sqldatareader_c1.Read())
                {
                    if (sqldatareader_c1.GetString(0).Trim() == "是")
                    {
                        RadioButton150.Checked = true;
                        RadioButton151.Checked = false;
                    }
                    else
                    {
                        RadioButton150.Checked = false;
                        RadioButton151.Checked = true;
                    }
                    if (sqldatareader_c1.IsDBNull(1)) { TextBox268.Text = ""; } else { TextBox268.Text = sqldatareader_c1.GetString(1); }
                    if (sqldatareader_c1.IsDBNull(2)) { } else { DropDownList67.SelectedValue = sqldatareader_c1.GetString(2).Trim(); }
                    if (sqldatareader_c1.IsDBNull(3)) { TextBox269.Text = ""; } else { TextBox269.Text = sqldatareader_c1.GetString(3); }
                    if (sqldatareader_c1.IsDBNull(4)) { } else { DropDownList68.SelectedValue = sqldatareader_c1.GetString(4).Trim(); }
                    if (sqldatareader_c1.IsDBNull(5)) { TextBox270.Text = ""; } else { TextBox270.Text = sqldatareader_c1.GetString(5); }
                    if (sqldatareader_c1.IsDBNull(6)) { } else { DropDownList69.SelectedValue = sqldatareader_c1.GetString(6).Trim(); }
                    if (sqldatareader_c1.IsDBNull(7)) { TextBox271.Text = ""; } else { TextBox271.Text = sqldatareader_c1.GetString(7); }
                    //日期
                    TextBox272.Text = sqldatareader_c1.GetString(8);

                    if (sqldatareader_c1.IsDBNull(9)) { TextBox273.Text = ""; } else { TextBox273.Text = sqldatareader_c1.GetString(9); }
                    //日期
                    TextBox274.Text = sqldatareader_c1.GetString(10);

                    if (sqldatareader_c1.IsDBNull(11)) { } else { DropDownList70.SelectedValue = sqldatareader_c1.GetString(11).Trim(); }
                    if (sqldatareader_c1.IsDBNull(12)) { TextBox275.Text = ""; } else { TextBox275.Text = sqldatareader_c1.GetString(12); }

                }
                str += "<br />";
                str += "<div>术前化疗</div>";
                if (sqldatareader_c1.GetString(0).Trim() == "是")
                {
                    str += "<div>是否接受新辅助化疗：是</div>";
                    str += "<div>共化疗&nbsp;" + TextBox268.Text + "周期 </div>";
                    str += "<div>化疗方案</div>";
                    str += "<div>第1周期方案&nbsp;" + DropDownList67.SelectedValue + TextBox269.Text + "mg，" + DropDownList68.SelectedValue + TextBox270.Text + "mg，" + DropDownList69.SelectedValue + TextBox271.Text + "mg。&nbsp;日期：" + TextBox272.Text + "</div>";
                    str += "<div>化疗后评估：&nbsp;" + TextBox273.Text + "次</div>";
                    str += "<div>第一次评估，日期&nbsp;" + TextBox274.Text + "，RECIST评估" + DropDownList70.SelectedValue + "&nbsp;备注：" + TextBox275.Text + "</div>";
                }
                else { str += "<div>是否接受新辅助化疗：否</div>"; }
                sqlcommand_c1 = null;
                sqlconn_c1.Close();
                sqlconn_c1 = null;

                //c2术后化疗
                SqlConnection sqlconn_c2 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_c2 = new SqlCommand();
                sqlcommand_c2.Connection = sqlconn_c2;

                sqlconn_c2.Open();//attention
                sqlcommand_c2.CommandText = "select * from c术后化疗 where 就诊卡号=@就诊卡号";
                sqlcommand_c2.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_c2 = sqlcommand_c2.ExecuteReader();
                if (sqldatareader_c2.Read())
                {
                    if (sqldatareader_c2.GetString(0).Trim() == "是")
                    {
                        RadioButton152.Checked = true;
                        RadioButton153.Checked = false;
                    }
                    else
                    {
                        RadioButton152.Checked = false;
                        RadioButton153.Checked = true;
                    }
                    if (sqldatareader_c2.IsDBNull(1)) { TextBox276.Text = ""; } else { TextBox276.Text = sqldatareader_c2.GetString(1); }
                    if (sqldatareader_c2.IsDBNull(2)) { } else { DropDownList71.SelectedValue = sqldatareader_c2.GetString(2).Trim(); }
                    if (sqldatareader_c2.IsDBNull(3)) { TextBox277.Text = ""; } else { TextBox277.Text = sqldatareader_c2.GetString(3); }
                    if (sqldatareader_c2.IsDBNull(4)) { } else { DropDownList72.SelectedValue = sqldatareader_c2.GetString(4).Trim(); }
                    if (sqldatareader_c2.IsDBNull(5)) { TextBox278.Text = ""; } else { TextBox278.Text = sqldatareader_c2.GetString(5); }
                    if (sqldatareader_c2.IsDBNull(6)) { } else { DropDownList73.SelectedValue = sqldatareader_c2.GetString(6).Trim(); }
                    if (sqldatareader_c2.IsDBNull(7)) { TextBox279.Text = ""; } else { TextBox279.Text = sqldatareader_c2.GetString(7); }
                    //日期
                    TextBox280.Text = sqldatareader_c2.GetString(8);

                    string c2_2 = sqldatareader_c2.GetString(9).Trim();
                    if (c2_2.Contains("血液系统")) { CheckBox55.Checked = true; }
                    if (c2_2.Contains("胃肠道系统")) { CheckBox56.Checked = true; }
                    if (c2_2.Contains("肝功能")) { CheckBox57.Checked = true; }
                    if (c2_2.Contains("肾功能")) { CheckBox58.Checked = true; }
                    if (c2_2.Contains("心功能")) { CheckBox59.Checked = true; }
                    if (c2_2.Contains("糖代谢异常")) { CheckBox60.Checked = true; }
                    if (c2_2.Contains("脂代谢异常")) { CheckBox61.Checked = true; }
                    if (sqldatareader_c2.IsDBNull(10)) { } else { DropDownList74.SelectedValue = sqldatareader_c2.GetString(10).Trim(); }
                    if (sqldatareader_c2.IsDBNull(11)) { TextBox281.Text = ""; } else { TextBox281.Text = sqldatareader_c2.GetString(11); }
                    if (sqldatareader_c2.IsDBNull(12)) { TextBox282.Text = ""; } else { TextBox282.Text = sqldatareader_c2.GetString(12); }
                }
                str += "<br />";
                str += "<div>术后化疗</div>";
                if (sqldatareader_c2.GetString(0).Trim() == "是")
                {
                    str += "<div>是否接受术后辅助化疗：是</div>";
                    str += "<div>共化疗&nbsp;" + TextBox276.Text + "周期 </div>";
                    str += "<div>化疗方案</div>";
                    str += "<div>第1周期方案&nbsp;" + DropDownList71.SelectedValue + TextBox277.Text + "mg，" + DropDownList72.SelectedValue + TextBox278.Text + "mg，" + DropDownList73.SelectedValue + TextBox279.Text + "mg。&nbsp;日期：" + TextBox280.Text + "</div>";
                    str += "<div>化疗不良反应：&nbsp;" + sqldatareader_c2.GetString(9).Trim() + "</div>";
                    str += "<div> 血液系统：" + DropDownList74.SelectedValue + "&nbsp;&nbsp;表现：" + TextBox281.Text + "&nbsp;&nbsp;处理：" + TextBox282.Text + "</div>";
                }
                else { str += "<div>是否接受术后辅助化疗：否</div>"; }

                sqlcommand_c2 = null;
                sqlconn_c2.Close();
                sqlconn_c2 = null;

                //d1导出
                SqlConnection sqlconn_d1 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_d1 = new SqlCommand();
                sqlcommand_d1.Connection = sqlconn_d1;

                sqlconn_d1.Open();//attention
                sqlcommand_d1.CommandText = "select * from d一般 where 就诊卡号=@就诊卡号";
                sqlcommand_d1.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_d1 = sqlcommand_d1.ExecuteReader();
                if (sqldatareader_d1.Read())
                {
                    if (sqldatareader_d1.IsDBNull(1)) { TextBox131.Text = ""; } else { TextBox131.Text = sqldatareader_d1.GetString(1); }
                    if (sqldatareader_d1.IsDBNull(2)) { TextBox132.Text = ""; } else { TextBox132.Text = sqldatareader_d1.GetString(2); }
                    if (sqldatareader_d1.IsDBNull(3)) { TextBox133.Text = ""; } else { TextBox133.Text = sqldatareader_d1.GetString(3); }
                    if (sqldatareader_d1.GetString(4).Trim() == "1") { CheckBox1.Checked = true; } else { CheckBox1.Checked = false; }
                    if (sqldatareader_d1.IsDBNull(5)) { TextBox134.Text = ""; } else { TextBox134.Text = sqldatareader_d1.GetString(5); }
                    if (sqldatareader_d1.GetString(6).Trim() == "1") { CheckBox2.Checked = true; } else { CheckBox2.Checked = false; }
                    if (sqldatareader_d1.IsDBNull(7)) { TextBox135.Text = ""; } else { TextBox135.Text = sqldatareader_d1.GetString(7); }
                    if (sqldatareader_d1.IsDBNull(8)) { } else { if (sqldatareader_d1.GetString(8).Trim() == "1") { CheckBox3.Checked = true; } else { CheckBox3.Checked = false; } }
                    if (sqldatareader_d1.IsDBNull(9)) { TextBox136.Text = ""; } else { TextBox136.Text = sqldatareader_d1.GetString(9); }
                    if (sqldatareader_d1.GetString(10).Trim() == "1") { CheckBox4.Checked = true; } else { CheckBox4.Checked = false; }
                    if (sqldatareader_d1.IsDBNull(11)) { TextBox137.Text = ""; } else { TextBox137.Text = sqldatareader_d1.GetString(11); }
                    if (sqldatareader_d1.GetString(12).Trim() == "1") { CheckBox5.Checked = true; } else { CheckBox5.Checked = false; }
                    if (sqldatareader_d1.IsDBNull(13)) { TextBox138.Text = ""; } else { TextBox138.Text = sqldatareader_d1.GetString(13); }

                }
                sqlcommand_d1 = null;
                sqlconn_d1.Close();
                sqlconn_d1 = null;
                str += "<br />";
                str += "<div>随访</div>";
                str += "<div>一般</div>";
                str += "<div>病理&nbsp;" + TextBox131.Text + "，淋巴结&nbsp;" + TextBox132.Text + "，分子类型&nbsp;" + TextBox133.Text + "</div>";
                str += "<div>术后治疗：&nbsp;";
                if (CheckBox1.Checked == true) { str += "化疗" + TextBox134.Text + "</div>"; } else { str += "</div>"; }
                if (CheckBox2.Checked == true) { str += "放疗" + TextBox135.Text + "</div>"; } else { str += "</div>"; }
                if (CheckBox3.Checked == true) { str += "内分泌" + TextBox136.Text + "</div>"; } else { str += "</div>"; }
                if (CheckBox4.Checked == true) { str += "靶向" + TextBox137.Text + "</div>"; } else { str += "</div>"; }
                if (CheckBox5.Checked == true) { str += "生物治疗" + TextBox138.Text + "</div>"; } else { str += "</div>"; }

                //d2导出
                SqlConnection sqlconn_d2 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_d2 = new SqlCommand();
                sqlcommand_d2.Connection = sqlconn_d2;

                sqlconn_d2.Open();//attention
                sqlcommand_d2.CommandText = "select * from d乳腺复发转移 where 就诊卡号=@就诊卡号";
                sqlcommand_d2.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_d2 = sqlcommand_d2.ExecuteReader();
                if (sqldatareader_d2.Read())
                {
                    string d2_1 = sqldatareader_d2.GetString(1).Trim();
                    //读数字
                    char[] result = d2_1.ToCharArray();
                    string str_d2 = "";
                    for (int i = 0; i < d2_1.Length; i++)
                    {
                        if (result[i] >= '0' && result[i] <= '9')
                        {
                            str_d2 += result[i];
                        }
                    }
                    TextBox139.Text = str_d2;
                    //读单位
                    if (sqldatareader_d2.GetString(1) == "") { } else { DropDownList29.SelectedValue = d2_1.Substring(d2_1.Length - 1, 1); }
                    if (sqldatareader_d2.GetString(2) == "") { } else { RadioButtonList17.SelectedValue = sqldatareader_d2.GetString(2).Trim(); }
                    if (sqldatareader_d2.IsDBNull(3)) { TextBox140.Text = ""; } else { TextBox140.Text = sqldatareader_d2.GetString(3); }
                    if (sqldatareader_d2.GetString(4) == "") { } else { RadioButtonList18.SelectedValue = sqldatareader_d2.GetString(4).Trim(); }
                    if (sqldatareader_d2.IsDBNull(5)) { TextBox145.Text = ""; } else { TextBox145.Text = sqldatareader_d2.GetString(5); }
                    if (sqldatareader_d2.GetString(6) == "") { } else { RadioButtonList15.SelectedValue = sqldatareader_d2.GetString(6).Trim(); }
                    if (sqldatareader_d2.IsDBNull(7)) { TextBox142.Text = ""; } else { TextBox142.Text = sqldatareader_d2.GetString(7); }
                    if (sqldatareader_d2.GetString(8) == "") { } else { RadioButtonList16.SelectedValue = sqldatareader_d2.GetString(8).Trim(); }
                    if (sqldatareader_d2.IsDBNull(9)) { TextBox144.Text = ""; } else { TextBox144.Text = sqldatareader_d2.GetString(9); }
                    if (sqldatareader_d2.GetString(10) == "") { } else { RadioButtonList13.SelectedValue = sqldatareader_d2.GetString(10).Trim(); }
                    if (sqldatareader_d2.IsDBNull(11)) { TextBox141.Text = ""; } else { TextBox141.Text = sqldatareader_d2.GetString(11); }
                    if (sqldatareader_d2.GetString(12).Trim() == "是") { CheckBox6.Checked = true; } else { CheckBox6.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(13)) { TextBox143.Text = ""; } else { TextBox143.Text = sqldatareader_d2.GetString(13); }
                    if (sqldatareader_d2.GetString(14).Trim() == "是") { CheckBox7.Checked = true; } else { CheckBox7.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(15)) { TextBox146.Text = ""; } else { TextBox146.Text = sqldatareader_d2.GetString(15); }//胸片
                    if (sqldatareader_d2.GetString(16) == "") { } else { RadioButtonList14.SelectedValue = sqldatareader_d2.GetString(16).Trim(); }
                    if (sqldatareader_d2.IsDBNull(17)) { TextBox147.Text = ""; } else { TextBox147.Text = sqldatareader_d2.GetString(17); }
                    if (sqldatareader_d2.GetString(18).Trim() == "是") { CheckBox8.Checked = true; } else { CheckBox8.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(19)) { TextBox148.Text = ""; } else { TextBox148.Text = sqldatareader_d2.GetString(19); }
                    if (sqldatareader_d2.GetString(20).Trim() == "是") { CheckBox9.Checked = true; } else { CheckBox9.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(21)) { TextBox149.Text = ""; } else { TextBox149.Text = sqldatareader_d2.GetString(21); }//BUS
                    if (sqldatareader_d2.GetString(22) == "") { } else { RadioButtonList19.SelectedValue = sqldatareader_d2.GetString(22).Trim(); }
                    if (sqldatareader_d2.IsDBNull(23)) { TextBox150.Text = ""; } else { TextBox150.Text = sqldatareader_d2.GetString(23); }
                    if (sqldatareader_d2.GetString(24).Trim() == "是") { CheckBox10.Checked = true; } else { CheckBox10.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(25)) { TextBox151.Text = ""; } else { TextBox151.Text = sqldatareader_d2.GetString(25); }
                    if (sqldatareader_d2.GetString(26).Trim() == "是") { CheckBox11.Checked = true; } else { CheckBox11.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(27)) { TextBox152.Text = ""; } else { TextBox152.Text = sqldatareader_d2.GetString(27); }//肿瘤标志物
                    if (sqldatareader_d2.GetString(28) == "") { } else { RadioButtonList20.SelectedValue = sqldatareader_d2.GetString(28).Trim(); }
                    if (sqldatareader_d2.IsDBNull(29)) { TextBox153.Text = ""; } else { TextBox153.Text = sqldatareader_d2.GetString(29); }
                    if (sqldatareader_d2.GetString(30).Trim() == "是") { CheckBox12.Checked = true; } else { CheckBox12.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(31)) { TextBox154.Text = ""; } else { TextBox154.Text = sqldatareader_d2.GetString(31); }
                    if (sqldatareader_d2.GetString(32).Trim() == "是") { CheckBox13.Checked = true; } else { CheckBox13.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(33)) { TextBox155.Text = ""; } else { TextBox155.Text = sqldatareader_d2.GetString(33); }//CT
                    if (sqldatareader_d2.GetString(34) == "") { } else { RadioButtonList21.SelectedValue = sqldatareader_d2.GetString(34).Trim(); }
                    if (sqldatareader_d2.IsDBNull(35)) { TextBox156.Text = ""; } else { TextBox156.Text = sqldatareader_d2.GetString(35); }
                    if (sqldatareader_d2.GetString(36).Trim() == "是") { CheckBox14.Checked = true; } else { CheckBox14.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(37)) { TextBox157.Text = ""; } else { TextBox157.Text = sqldatareader_d2.GetString(37); }
                    if (sqldatareader_d2.GetString(38).Trim() == "是") { CheckBox15.Checked = true; } else { CheckBox15.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(39)) { TextBox158.Text = ""; } else { TextBox158.Text = sqldatareader_d2.GetString(39); }//ECT
                    if (sqldatareader_d2.GetString(40) == "") { } else { RadioButtonList22.SelectedValue = sqldatareader_d2.GetString(40).Trim(); }
                    if (sqldatareader_d2.IsDBNull(41)) { TextBox159.Text = ""; } else { TextBox159.Text = sqldatareader_d2.GetString(41); }
                    if (sqldatareader_d2.GetString(42).Trim() == "是") { CheckBox16.Checked = true; } else { CheckBox16.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(43)) { TextBox160.Text = ""; } else { TextBox160.Text = sqldatareader_d2.GetString(43); }
                    if (sqldatareader_d2.GetString(44).Trim() == "是") { CheckBox17.Checked = true; } else { CheckBox17.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(45)) { TextBox161.Text = ""; } else { TextBox161.Text = sqldatareader_d2.GetString(45); }//PET-CT
                    if (sqldatareader_d2.GetString(46) == "") { } else { RadioButtonList23.SelectedValue = sqldatareader_d2.GetString(46).Trim(); }
                    if (sqldatareader_d2.IsDBNull(47)) { } else { DropDownList30.SelectedValue = sqldatareader_d2.GetString(47).Trim(); }
                    if (sqldatareader_d2.IsDBNull(48)) { TextBox162.Text = ""; } else { TextBox162.Text = sqldatareader_d2.GetString(48); }
                    if (sqldatareader_d2.IsDBNull(49)) { TextBox163.Text = ""; } else { TextBox163.Text = sqldatareader_d2.GetString(49); }

                }

                str += "<br />";
                str += "<div>乳腺复发转移</div>";
                str += "<div>术后&nbsp;" + sqldatareader_d2.GetString(1).Trim() + "复查：</div>";
                str += "<div>查体：胸腔：";
                if (RadioButtonList17.SelectedValue == "异常") { str += "异常&nbsp;" + TextBox140.Text + "，对侧："; } else { str += "正常，对侧："; }
                if (RadioButtonList18.SelectedValue == "异常") { str += "异常&nbsp;" + TextBox145.Text + "</div>"; } else { str += "正常</div>"; }
                str += "<div>查体：腋下：";
                if (RadioButtonList15.SelectedValue == "异常") { str += "异常&nbsp;" + TextBox142.Text + "，对侧："; } else { str += "正常，对侧："; }
                if (RadioButtonList16.SelectedValue == "异常") { str += "异常&nbsp;" + TextBox144.Text + "</div>"; } else { str += "正常</div>"; }
                str += "<div>胸片：";
                if (RadioButtonList13.SelectedValue == "异常") { str += "异常&nbsp;" + TextBox141.Text; } else { str += "正常"; }
                if (CheckBox6.Checked == true) { str += "，进一步检查：" + TextBox143.Text; } else { str += ""; }
                if (CheckBox7.Checked == true) { str += "&nbsp;复查:" + TextBox146.Text + "月</div>"; } else { str += "</div>"; }
                str += "<div>BUS：";
                if (RadioButtonList14.SelectedValue == "异常") { str += "异常&nbsp;" + TextBox147.Text; } else { str += "正常"; }
                if (CheckBox8.Checked == true) { str += "，进一步检查：" + TextBox148.Text; } else { str += ""; }
                if (CheckBox9.Checked == true) { str += "&nbsp;复查:" + TextBox149.Text + "月</div>"; } else { str += "</div>"; }
                str += "<div>肿瘤标志物：";
                if (RadioButtonList19.SelectedValue == "异常") { str += "异常&nbsp;" + TextBox150.Text; } else { str += "正常"; }
                if (CheckBox10.Checked == true) { str += "，进一步检查：" + TextBox151.Text; } else { str += ""; }
                if (CheckBox11.Checked == true) { str += "&nbsp;复查:" + TextBox152.Text + "月</div>"; } else { str += "</div>"; }
                str += "<div>CT：";
                if (RadioButtonList20.SelectedValue == "异常") { str += "异常&nbsp;" + TextBox153.Text; } else { str += "正常"; }
                if (CheckBox12.Checked == true) { str += "，进一步检查：" + TextBox154.Text; } else { str += ""; }
                if (CheckBox13.Checked == true) { str += "&nbsp;复查:" + TextBox155.Text + "月</div>"; } else { str += "</div>"; }
                str += "<div>ECT：";
                if (RadioButtonList21.SelectedValue == "异常") { str += "异常&nbsp;" + TextBox156.Text; } else { str += "正常"; }
                if (CheckBox14.Checked == true) { str += "，进一步检查：" + TextBox157.Text; } else { str += ""; }
                if (CheckBox15.Checked == true) { str += "&nbsp;复查:" + TextBox158.Text + "月</div>"; } else { str += "</div>"; }
                str += "<div>PET-CT：";
                if (RadioButtonList22.SelectedValue == "异常") { str += "异常&nbsp;" + TextBox159.Text; } else { str += "正常"; }
                if (CheckBox16.Checked == true) { str += "，进一步检查：" + TextBox160.Text; } else { str += ""; }
                if (CheckBox17.Checked == true) { str += "&nbsp;复查:" + TextBox161.Text + "月</div>"; } else { str += "</div>"; }
                str += "<div>结论：";
                if (RadioButtonList22.SelectedValue == "否") { str += DropDownList30.SelectedValue + TextBox162.Text + "</div>"; } else { str += "正常</div> "; }
                str += "<div>治疗：" + TextBox163.Text + "</div>";
                sqlcommand_d2 = null;
                sqlconn_d2.Close();
                sqlconn_d2 = null;

                //d3
                SqlConnection sqlconn_d3 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_d3 = new SqlCommand();
                sqlcommand_d3.Connection = sqlconn_d3;

                sqlconn_d3.Open();//attention
                sqlcommand_d3.CommandText = "select * from d诊疗异常反应 where 就诊卡号=@就诊卡号";
                sqlcommand_d3.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_d3 = sqlcommand_d3.ExecuteReader();
                if (sqldatareader_d3.Read())
                {
                    //UCG_正常
                    if (sqldatareader_d3.GetString(0).Trim() == "正常") { RadioButton26.Checked = true; }
                    //UCG_异常
                    if (sqldatareader_d3.GetString(1).Trim() == "异常") { RadioButton27.Checked = true; }
                    //UCG_异常内容
                    if (sqldatareader_d3.IsDBNull(2)) { TextBox203.Text = ""; } else { TextBox203.Text = sqldatareader_d3.GetString(2); }
                    //UCG_结论
                    if (sqldatareader_d3.IsDBNull(3)) { TextBox204.Text = ""; } else { TextBox204.Text = sqldatareader_d3.GetString(3); }
                    //UCG_建议
                    if (sqldatareader_d3.IsDBNull(4)) { TextBox205.Text = ""; } else { TextBox205.Text = sqldatareader_d3.GetString(4); }
                    //肝肾功_正常
                    if (sqldatareader_d3.GetString(5).Trim() == "正常") { RadioButton28.Checked = true; }
                    //肝肾功_异常
                    if (sqldatareader_d3.GetString(6).Trim() == "异常") { RadioButton29.Checked = true; }
                    //肝肾功_异常内容
                    if (sqldatareader_d3.IsDBNull(7)) { TextBox206.Text = ""; } else { TextBox206.Text = sqldatareader_d3.GetString(7); }
                    //肝肾功_结论
                    if (sqldatareader_d3.IsDBNull(8)) { TextBox207.Text = ""; } else { TextBox207.Text = sqldatareader_d3.GetString(8); }
                    //肝肾功_建议
                    if (sqldatareader_d3.IsDBNull(9)) { TextBox208.Text = ""; } else { TextBox208.Text = sqldatareader_d3.GetString(9); }
                    //血糖_正常
                    if (sqldatareader_d3.GetString(10).Trim() == "正常") { RadioButton30.Checked = true; }
                    //血糖_异常
                    if (sqldatareader_d3.GetString(11).Trim() == "异常") { RadioButton31.Checked = true; }
                    //血糖_异常内容
                    if (sqldatareader_d3.IsDBNull(12)) { TextBox209.Text = ""; } else { TextBox209.Text = sqldatareader_d3.GetString(12); }
                    //血糖_结论
                    if (sqldatareader_d3.IsDBNull(13)) { TextBox210.Text = ""; } else { TextBox210.Text = sqldatareader_d3.GetString(13); }
                    //血糖_建议
                    if (sqldatareader_d3.IsDBNull(14)) { TextBox211.Text = ""; } else { TextBox211.Text = sqldatareader_d3.GetString(14); }
                    //血脂_正常
                    if (sqldatareader_d3.GetString(15).Trim() == "正常") { RadioButton32.Checked = true; }
                    //血脂_异常
                    if (sqldatareader_d3.GetString(16).Trim() == "异常") { RadioButton33.Checked = true; }
                    //血脂_异常内容
                    if (sqldatareader_d3.IsDBNull(17)) { TextBox212.Text = ""; } else { TextBox212.Text = sqldatareader_d3.GetString(17); }
                    //血脂_结论
                    if (sqldatareader_d3.IsDBNull(18)) { TextBox213.Text = ""; } else { TextBox213.Text = sqldatareader_d3.GetString(18); }
                    //血脂_建议
                    if (sqldatareader_d3.IsDBNull(19)) { TextBox214.Text = ""; } else { TextBox214.Text = sqldatareader_d3.GetString(19); }
                    //骨密度_正常
                    if (sqldatareader_d3.GetString(20).Trim() == "正常") { RadioButton34.Checked = true; }
                    //骨密度_异常
                    if (sqldatareader_d3.GetString(21).Trim() == "异常") { RadioButton35.Checked = true; }
                    //骨密度_异常内容
                    if (sqldatareader_d3.IsDBNull(22)) { TextBox215.Text = ""; } else { TextBox215.Text = sqldatareader_d3.GetString(22); }
                    //骨密度_结论
                    if (sqldatareader_d3.IsDBNull(23)) { TextBox216.Text = ""; } else { TextBox216.Text = sqldatareader_d3.GetString(23); }
                    //骨密度_建议
                    if (sqldatareader_d3.IsDBNull(24)) { TextBox217.Text = ""; } else { TextBox217.Text = sqldatareader_d3.GetString(24); }
                    //激素水平_未绝经
                    if (sqldatareader_d3.GetString(25).Trim() == "未绝经") { RadioButton36.Checked = true; }
                    //激素水平_绝经
                    if (sqldatareader_d3.GetString(26).Trim() == "绝经") { RadioButton37.Checked = true; }
                    //激素水平_更换内分泌药
                    if (sqldatareader_d3.IsDBNull(27)) { TextBox218.Text = ""; } else { TextBox218.Text = sqldatareader_d3.GetString(27); }
                }
                str += "<br />";
                str += "<div>诊疗异常反应</div>";
                str += "<div>UCG：" + sqldatareader_d3.GetString(0).Trim() + sqldatareader_d3.GetString(1).Trim();
                if (RadioButton27.Checked == true) { str += "&nbsp;" + TextBox203.Text + "，结论：" + TextBox204.Text + "，建议：" + TextBox205.Text + "</div>"; }
                else { str += "正常</div>"; }
                str += "<div>肝肾功：" + sqldatareader_d3.GetString(5).Trim() + sqldatareader_d3.GetString(6).Trim();
                if (RadioButton29.Checked == true) { str += "&nbsp;" + TextBox206.Text + "，结论：" + TextBox207.Text + "，建议：" + TextBox208.Text + "</div>"; }
                else { str += "正常</div>"; }
                str += "<div>血糖：" + sqldatareader_d3.GetString(10).Trim() + sqldatareader_d3.GetString(11).Trim();
                if (RadioButton31.Checked == true) { str += "&nbsp;" + TextBox209.Text + "，结论：" + TextBox210.Text + "，建议：" + TextBox211.Text + "</div>"; }
                else { str += "正常</div>"; }
                str += "<div>血脂：" + sqldatareader_d3.GetString(15).Trim() + sqldatareader_d3.GetString(16).Trim();
                if (RadioButton33.Checked == true) { str += "&nbsp;" + TextBox212.Text + "，结论：" + TextBox213.Text + "，建议：" + TextBox214.Text + "</div>"; }
                else { str += "正常</div>"; }
                str += "<div>骨密度：" + sqldatareader_d3.GetString(20).Trim() + sqldatareader_d3.GetString(21).Trim();
                if (RadioButton35.Checked == true) { str += "&nbsp;" + TextBox215.Text + "，结论：" + TextBox216.Text + "，建议：" + TextBox217.Text + "</div>"; }
                else { str += "正常</div>"; }
                if (RadioButton37.Checked == true) { str += "<div>激素水平：绝经</div>"; } else { str += "<div>激素水平：未绝经</div>"; }
                str += "<div>更换内分泌药：" + TextBox218.Text + "</div>";
                sqlcommand_d3 = null;
                sqlconn_d3.Close();
                sqlconn_d3 = null;

                //e1导出
                SqlConnection sqlconn_e1 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_e1 = new SqlCommand();
                sqlcommand_e1.Connection = sqlconn_e1;

                sqlconn_e1.Open();//attention
                sqlcommand_e1.CommandText = "select * from e根治信息 where 就诊卡号=@就诊卡号";
                sqlcommand_e1.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_e1 = sqlcommand_e1.ExecuteReader();
                if (sqldatareader_e1.Read())
                {
                    //手术方式
                    if (sqldatareader_e1.GetString(0) == "") { } else { RadioButtonList24.SelectedValue = sqldatareader_e1.GetString(0).Trim(); }
                    //术前诊断
                    if (sqldatareader_e1.GetString(1) == "") { } else { RadioButtonList25.SelectedValue = sqldatareader_e1.GetString(1).Trim(); }
                    //切口设计
                    if (sqldatareader_e1.GetString(2) == "") { } else { RadioButtonList26.SelectedValue = sqldatareader_e1.GetString(2).Trim(); }
                    //切口设计_cm"
                    if (sqldatareader_e1.IsDBNull(3)) { TextBox219.Text = ""; } else { TextBox219.Text = sqldatareader_e1.GetString(3); }
                    //皮下打水
                    if (sqldatareader_e1.GetString(4) == "") { } else { RadioButtonList27.SelectedValue = sqldatareader_e1.GetString(4).Trim(); }
                    //分离皮瓣范围_上至
                    if (sqldatareader_e1.IsDBNull(5)) { TextBox220.Text = ""; } else { TextBox220.Text = sqldatareader_e1.GetString(5); }
                    //分离皮瓣范围_下至
                    if (sqldatareader_e1.IsDBNull(6)) { TextBox221.Text = ""; } else { TextBox221.Text = sqldatareader_e1.GetString(6); }
                    //分离皮瓣范围_内至
                    if (sqldatareader_e1.IsDBNull(7)) { TextBox222.Text = ""; } else { TextBox222.Text = sqldatareader_e1.GetString(7); }
                    //分离皮瓣范围_外至
                    if (sqldatareader_e1.IsDBNull(8)) { TextBox223.Text = ""; } else { TextBox223.Text = sqldatareader_e1.GetString(8); }
                    //厚度
                    if (sqldatareader_e1.GetString(9) == "") { } else { RadioButtonList28.SelectedValue = sqldatareader_e1.GetString(9).Trim(); }
                    //全乳切除
                    if (sqldatareader_e1.GetString(10) == "") { } else { RadioButtonList29.SelectedValue = sqldatareader_e1.GetString(10).Trim(); }
                    //胸肌受累
                    if (sqldatareader_e1.GetString(11) == "") { } else { RadioButtonList30.SelectedValue = sqldatareader_e1.GetString(11).Trim(); }
                    //胸大肌部分切
                    if (sqldatareader_e1.GetString(12) == "") { } else { RadioButtonList31.SelectedValue = sqldatareader_e1.GetString(12).Trim(); }

                }
                sqlcommand_e1 = null;
                sqlconn_e1.Close();
                sqlconn_e1 = null;
                str += "<br />";
                str += "<div>根治术</div>";
                str += "<div>根治信息</div>";
                str += "<div>&nbsp;基本信息</div>";
                str += "<div>&nbsp;&nbsp;手术方式：" + RadioButtonList24.SelectedValue + "</div>";
                str += "<div>&nbsp;&nbsp;术前诊断：" + RadioButtonList25.SelectedValue + "</div>";
                str += "<div>&nbsp;&nbsp;切口设计：" + RadioButtonList26.SelectedValue + "&nbsp;距肿瘤边缘或切检瘢痕&nbsp;" + TextBox219.Text + "cm" + "</div>";
                str += "<div>&nbsp;&nbsp;皮下打水：" + RadioButtonList27.SelectedValue + "</div>";
                str += "<div>&nbsp;分离皮瓣</div>";
                str += "<div>&nbsp;&nbsp;范围：上至" + TextBox220.Text + "&nbsp;下至" + TextBox221.Text + "</div>";
                str += "<div>&nbsp;&nbsp;范围：内至" + TextBox222.Text + "&nbsp;外至" + TextBox223.Text + "</div>";
                str += "<div>&nbsp;&nbsp;厚度：" + RadioButtonList28.SelectedValue + "</div>";
                str += "<div>&nbsp;全乳切除</div>";
                str += "<div>&nbsp;&nbsp;切除：" + RadioButtonList29.SelectedValue + "</div>";
                str += "<div>&nbsp;&nbsp;胸肌受累：" + RadioButtonList30.SelectedValue + "</div>";
                str += "<div>&nbsp;&nbsp;胸大肌部分切：" + RadioButtonList31.SelectedValue + "</div>";

                //e2导出
                SqlConnection sqlconn_e2 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_e2 = new SqlCommand();
                sqlcommand_e2.Connection = sqlconn_e2;

                sqlconn_e2.Open();//attention
                sqlcommand_e2.CommandText = "select * from e根治术相关 where 就诊卡号=@就诊卡号";
                sqlcommand_e2.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_e2 = sqlcommand_e2.ExecuteReader();
                if (sqldatareader_e2.Read())
                {
                    //保留胸大小肌_胸肌间脂肪
                    if (sqldatareader_e2.GetString(0) == "") { } else { RadioButtonList45.SelectedValue = sqldatareader_e2.GetString(0).Trim(); }
                    //保留胸大小肌_胸肌间脂肪_切除
                    if (sqldatareader_e2.GetString(1) == "") { } else { RadioButtonList46.SelectedValue = sqldatareader_e2.GetString(1).Trim(); }
                    //保留胸大小肌_可见肿大淋巴结
                    if (sqldatareader_e2.GetString(2) == "") { } else { RadioButton22.Text = sqldatareader_e2.GetString(2).Trim(); }
                    //保留胸大小肌_可见肿大淋巴结数量
                    if (sqldatareader_e2.IsDBNull(3)) { TextBox232.Text = ""; } else { TextBox232.Text = sqldatareader_e2.GetString(3); }
                    //保留胸大小肌_胸前神经
                    if (sqldatareader_e2.GetString(4) == "") { } else { RadioButtonList47.SelectedValue = sqldatareader_e2.GetString(4).Trim(); }
                    //保留胸大小肌_解剖过程
                    if (sqldatareader_e2.IsDBNull(5)) { TextBox233.Text = ""; } else { TextBox233.Text = sqldatareader_e2.GetString(5); }
                    //保留胸大肌_胸肌间脂肪
                    if (sqldatareader_e2.GetString(6) == "") { } else { RadioButtonList48.SelectedValue = sqldatareader_e2.GetString(6).Trim(); }
                    //保留胸大肌_胸肌间脂肪_切除
                    if (sqldatareader_e2.GetString(7) == "") { } else { RadioButtonList49.SelectedValue = sqldatareader_e2.GetString(7).Trim(); }
                    //保留胸大肌_可见肿大淋巴结
                    if (sqldatareader_e2.GetString(8) == "") { } else { RadioButton24.Text = sqldatareader_e2.GetString(8).Trim(); }
                    //保留胸大肌_可见肿大淋巴结数量
                    if (sqldatareader_e2.IsDBNull(9)) { TextBox234.Text = ""; } else { TextBox234.Text = sqldatareader_e2.GetString(9); }
                    //保留胸大肌_胸前神经
                    if (sqldatareader_e2.GetString(10) == "") { } else { RadioButtonList50.SelectedValue = sqldatareader_e2.GetString(10).Trim(); }
                    //保留胸大肌_切断胸小肌喙突端
                    //string e2_1 = sqldatareader_e2.GetString(11).Trim();
                    //if (e2_1.Contains("切断胸小肌喙突端")) { CheckBox30.Checked = true; }
                    if (sqldatareader_e2.GetString(11).Trim() == "1") { CheckBox30.Checked = true; } else { CheckBox30.Checked = false; }
                    //保留胸大肌_解剖过程
                    if (sqldatareader_e2.IsDBNull(12)) { TextBox235.Text = ""; } else { TextBox235.Text = sqldatareader_e2.GetString(12); }
                    //胸大肌保留
                    if (sqldatareader_e2.IsDBNull(13)) { TextBox236.Text = ""; } else { TextBox236.Text = sqldatareader_e2.GetString(13); }
                    //胸大肌宽
                    if (sqldatareader_e2.IsDBNull(14)) { TextBox237.Text = ""; } else { TextBox237.Text = sqldatareader_e2.GetString(14); }
                    //根治术_切断胸大肌肱骨端
                    //if (sqldatareader_e2.IsDBNull(15)) { CheckBox31.Text = ""; } else { CheckBox31.Text = sqldatareader_e2.GetString(15); }
                    if (sqldatareader_e2.GetString(15).Trim() == "1") { CheckBox31.Checked = true; } else { CheckBox31.Checked = false; }
                    //根治术_切断胸小肌喙突端
                    //if (sqldatareader_e2.IsDBNull(16)) { CheckBox32.Text = ""; } else { CheckBox32.Text = sqldatareader_e2.GetString(16); }
                    if (sqldatareader_e2.GetString(16).Trim() == "1") { CheckBox32.Checked = true; } else { CheckBox32.Checked = false; }
                    //根治术_解剖过程
                    if (sqldatareader_e2.IsDBNull(17)) { TextBox238.Text = ""; } else { TextBox238.Text = sqldatareader_e2.GetString(17); }


                }
                sqlcommand_e2 = null;
                sqlconn_e2.Close();
                sqlconn_e2 = null;
                str += "<br />";
                str += "<div>根治术相关</div>";
                str += "<div>&nbsp;保留胸大小肌</div>";
                str += "<div>&nbsp;&nbsp;胸肌间脂肪：" + RadioButtonList45.SelectedValue + "</div>";
                str += "<div>&nbsp;&nbsp;切除：" + RadioButtonList46.SelectedValue + "</div>";
                //小问题
                str += "<div>&nbsp;&nbsp;可见肿大淋巴结" + RadioButton22.Text + TextBox232.Text + "&nbsp;个" + "</div>";
                str += "<div>&nbsp;&nbsp;胸前神经：" + RadioButtonList47.SelectedValue + "</div>";
                str += "<div>&nbsp;&nbsp;解剖过程：" + TextBox233.Text + "</div>";

                str += "<div>&nbsp;保留胸大肌</div>";
                str += "<div>&nbsp;&nbsp;胸肌间脂肪：" + RadioButtonList48.SelectedValue + "</div>";
                str += "<div>&nbsp;&nbsp;切除：" + RadioButtonList49.SelectedValue + "</div>";
                //小问题
                str += "<div>&nbsp;&nbsp;可见肿大淋巴结" + RadioButton24.Text + TextBox234.Text + "&nbsp;个" + "</div>";
                str += "<div>&nbsp;&nbsp;将胸大肌掀起，胸前神经：" + RadioButtonList50.SelectedValue;
                if (CheckBox30.Checked == true) { str += "&nbsp;" + CheckBox30.Text + "</div>"; } else { str += "</div>"; }
                str += "<div>&nbsp;&nbsp;解剖过程：" + TextBox235.Text + "</div>";

                str += "<div>&nbsp;根治术</div>";
                str += "<div>&nbsp;&nbsp;胸大肌保留" + TextBox236.Text + "&nbsp;条，宽约" + TextBox237.Text + "&nbsp;cm" + "</div>";
                if (CheckBox31.Checked == true) { str += "&nbsp;<div>" + CheckBox31.Text + "</div>"; } else { str += ""; }
                if (CheckBox32.Checked == true) { str += "&nbsp;<div>" + CheckBox32.Text + "</div>"; } else { str += ""; }
                str += "<div>&nbsp;&nbsp;解剖过程：" + TextBox238.Text + "</div>";

                //e3导出
                SqlConnection sqlconn_e3 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_e3 = new SqlCommand();
                sqlcommand_e3.Connection = sqlconn_e3;

                sqlconn_e3.Open();//attention
                sqlcommand_e3.CommandText = "select * from e手术相关 where 就诊卡号=@就诊卡号";
                sqlcommand_e3.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_e3 = sqlcommand_e3.ExecuteReader();
                if (sqldatareader_e3.Read())
                {
                    //腋脉管带周围肿大淋巴结
                    if (sqldatareader_e3.GetString(0) == "") { } else { RadioButtonList32.SelectedValue = sqldatareader_e3.GetString(0).Trim(); }
                    //肿大淋巴结个数
                    if (sqldatareader_e3.IsDBNull(1)) { TextBox224.Text = ""; } else { TextBox224.Text = sqldatareader_e3.GetString(1); }
                    //肿大淋巴结大小
                    if (sqldatareader_e3.IsDBNull(2)) { TextBox225.Text = ""; } else { TextBox225.Text = sqldatareader_e3.GetString(2); }
                    //肿大淋巴结硬度
                    if (sqldatareader_e3.GetString(3) == "") { } else { RadioButtonList33.SelectedValue = sqldatareader_e3.GetString(3).Trim(); }
                    //和腋静脉管或鞘膜粘粒
                    if (sqldatareader_e3.GetString(4) == "") { } else { RadioButtonList34.SelectedValue = sqldatareader_e3.GetString(4).Trim(); }
                    //切除
                    if (sqldatareader_e3.GetString(5) == "") { } else { RadioButtonList35.SelectedValue = sqldatareader_e3.GetString(5).Trim(); }
                    //缝合切断
                    if (sqldatareader_e3.GetString(6) == "") { } else { RadioButtonList36.SelectedValue = sqldatareader_e3.GetString(6).Trim(); }
                    //腋尖肿大淋巴结个数
                    if (sqldatareader_e3.IsDBNull(7)) { TextBox226.Text = ""; } else { TextBox226.Text = sqldatareader_e3.GetString(7); }
                    //腋尖肿大淋巴结大小
                    if (sqldatareader_e3.IsDBNull(8)) { TextBox227.Text = ""; } else { TextBox227.Text = sqldatareader_e3.GetString(8); }
                    //腋尖肿大淋巴结硬度
                    if (sqldatareader_e3.GetString(9) == "") { } else { RadioButtonList37.SelectedValue = sqldatareader_e3.GetString(9).Trim(); }
                    //和锁下静脉鞘粘粒
                    if (sqldatareader_e3.GetString(10) == "") { } else { RadioButtonList38.SelectedValue = sqldatareader_e3.GetString(10).Trim(); }
                    //胸背神经
                    if (sqldatareader_e3.GetString(11) == "") { } else { RadioButtonList39.SelectedValue = sqldatareader_e3.GetString(11).Trim(); }
                    //胸长神经
                    if (sqldatareader_e3.GetString(12) == "") { } else { RadioButtonList40.SelectedValue = sqldatareader_e3.GetString(12).Trim(); }
                    //肩胛下脉管
                    if (sqldatareader_e3.GetString(13) == "") { } else { RadioButtonList41.SelectedValue = sqldatareader_e3.GetString(13).Trim(); }
                    //负压引流
                    if (sqldatareader_e3.IsDBNull(14)) { TextBox228.Text = ""; } else { TextBox228.Text = sqldatareader_e3.GetString(14); }
                    //缝合皮肤张力
                    if (sqldatareader_e3.GetString(15) == "") { } else { RadioButtonList42.SelectedValue = sqldatareader_e3.GetString(15).Trim(); }
                    //缝合皮肤植皮
                    if (sqldatareader_e3.GetString(16) == "") { } else { RadioButtonList43.SelectedValue = sqldatareader_e3.GetString(16).Trim(); }
                    //缝合皮肤面积
                    if (sqldatareader_e3.IsDBNull(17)) { TextBox229.Text = ""; } else { TextBox229.Text = sqldatareader_e3.GetString(17); }
                    //出血量
                    if (sqldatareader_e3.GetString(18) == "") { } else { RadioButtonList44.SelectedValue = sqldatareader_e3.GetString(18).Trim(); }
                    //手术时间_小时
                    if (sqldatareader_e3.IsDBNull(19)) { TextBox230.Text = ""; } else { TextBox230.Text = sqldatareader_e3.GetString(19); }
                    //手术时间_分
                    if (sqldatareader_e3.IsDBNull(20)) { TextBox231.Text = ""; } else { TextBox231.Text = sqldatareader_e3.GetString(20); }

                }
                sqlcommand_e3 = null;
                sqlconn_e3.Close();
                sqlconn_e3 = null;
                str += "<br />";
                str += "<div>手术相关</div>";
                str += "<div>&nbsp;腋下情况</div>";
                str += "<div>&nbsp;&nbsp;腋脉管带周围肿大淋巴结&nbsp;" + RadioButtonList32.SelectedValue + "</div>";
                if (RadioButtonList32.SelectedValue == "有") { str += "<div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;肿大淋巴结" + TextBox224.Text + "个" + TextBox225.Text + "cm" + RadioButtonList33.SelectedValue + "</div>"; }
                else { str += ""; }
                str += "<div>&nbsp;&nbsp;和腋静脉管或鞘膜粘粒&nbsp;" + RadioButtonList34.SelectedValue;
                if (RadioButtonList34.SelectedValue == "有") { str += "&nbsp;&nbsp;切除" + RadioButtonList35.SelectedValue + "</div>"; } else { str += "</div>"; }
                str += "<div>&nbsp;&nbsp;腋静脉损伤，缝合切断&nbsp;" + RadioButtonList36.SelectedValue + "</div>";
                str += "<div>&nbsp;&nbsp;腋尖有无可见肿大淋巴结" + TextBox226.Text + "个" + TextBox227.Text + "cm" + RadioButtonList37.SelectedValue + "</div>";
                str += "<div>&nbsp;&nbsp;和锁下静脉鞘粘粒&nbsp;" + RadioButtonList38.SelectedValue + "</div>";
                str += "<div>&nbsp;&nbsp;胸背神经&nbsp;" + RadioButtonList39.SelectedValue + "</div>";
                str += "<div>&nbsp;&nbsp;胸长神经&nbsp;" + RadioButtonList40.SelectedValue + "</div>";
                str += "<div>&nbsp;&nbsp;肩胛下脉管&nbsp;" + RadioButtonList41.SelectedValue + "</div>";
                str += "<div>&nbsp;手术信息</div>";
                str += "<div>&nbsp;&nbsp;负压引流：&nbsp;" + TextBox228.Text + "条" + "</div>";
                str += "<div>&nbsp;&nbsp;缝合皮肤：&nbsp;张力" + RadioButtonList42.SelectedValue + "&nbsp;&nbsp;植皮" + RadioButtonList43.SelectedValue + "&nbsp;&nbsp;面积" + TextBox229.Text + "&nbsp;cm<sup>2</sup>" + "</div>";
                str += "<div>&nbsp;&nbsp;出血量：" + RadioButtonList44.SelectedValue + "</div>";
                str += "<div>&nbsp;&nbsp;手术时间：" + TextBox230.Text + "&nbsp;小时" + TextBox231.Text + "&nbsp;分" + "</div>";

                //f1
                SqlConnection sqlconn_f1 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_f1 = new SqlCommand();
                sqlcommand_f1.Connection = sqlconn_f1;

                sqlconn_f1.Open();//attention
                sqlcommand_f1.CommandText = "select * from f术前信息1 where 就诊卡号=@就诊卡号";
                sqlcommand_f1.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_f1 = sqlcommand_f1.ExecuteReader();
                if (sqldatareader_f1.Read())
                {
                    //肿瘤部位_侧
                    if (sqldatareader_f1.IsDBNull(0)) { TextBox167.Text = ""; } else { TextBox167.Text = sqldatareader_f1.GetString(0); }
                    //肿瘤部位_点
                    if (sqldatareader_f1.IsDBNull(1)) { TextBox168.Text = ""; } else { TextBox168.Text = sqldatareader_f1.GetString(1); }
                    //肿瘤大小_横
                    if (sqldatareader_f1.IsDBNull(2)) { TextBox169.Text = ""; } else { TextBox169.Text = sqldatareader_f1.GetString(2); }
                    //肿瘤大小_纵
                    if (sqldatareader_f1.IsDBNull(3)) { TextBox170.Text = ""; } else { TextBox170.Text = sqldatareader_f1.GetString(3); }
                    //肿瘤与乳头距离
                    if (sqldatareader_f1.IsDBNull(4)) { TextBox171.Text = ""; } else { TextBox171.Text = sqldatareader_f1.GetString(4); }
                    //胸乳距
                    if (sqldatareader_f1.IsDBNull(5)) { TextBox172.Text = ""; } else { TextBox172.Text = sqldatareader_f1.GetString(5); }
                    //乳胸距
                    if (sqldatareader_f1.IsDBNull(6)) { TextBox173.Text = ""; } else { TextBox173.Text = sqldatareader_f1.GetString(6); }
                    //锁胸距
                    if (sqldatareader_f1.IsDBNull(7)) { TextBox174.Text = ""; } else { TextBox174.Text = sqldatareader_f1.GetString(7); }
                    //胸骨正中距
                    if (sqldatareader_f1.IsDBNull(8)) { TextBox175.Text = ""; } else { TextBox175.Text = sqldatareader_f1.GetString(8); }
                    //乳头间距
                    if (sqldatareader_f1.IsDBNull(9)) { TextBox176.Text = ""; } else { TextBox176.Text = sqldatareader_f1.GetString(9); }
                    //乳房基底横径
                    if (sqldatareader_f1.IsDBNull(10)) { TextBox177.Text = ""; } else { TextBox177.Text = sqldatareader_f1.GetString(10); }
                    //乳房内侧半径
                    if (sqldatareader_f1.IsDBNull(11)) { TextBox178.Text = ""; } else { TextBox178.Text = sqldatareader_f1.GetString(11); }
                    //乳房外侧半径
                    if (sqldatareader_f1.IsDBNull(12)) { TextBox179.Text = ""; } else { TextBox179.Text = sqldatareader_f1.GetString(12); }
                    //乳房下侧半径
                    if (sqldatareader_f1.IsDBNull(13)) { TextBox180.Text = ""; } else { TextBox180.Text = sqldatareader_f1.GetString(13); }
                    //乳头至下皱襞体表距离
                    if (sqldatareader_f1.IsDBNull(14)) { TextBox181.Text = ""; } else { TextBox181.Text = sqldatareader_f1.GetString(14); }
                    //乳晕直径
                    if (sqldatareader_f1.IsDBNull(15)) { TextBox182.Text = ""; } else { TextBox182.Text = sqldatareader_f1.GetString(15); }
                    //乳头直径
                    if (sqldatareader_f1.IsDBNull(16)) { TextBox183.Text = ""; } else { TextBox183.Text = sqldatareader_f1.GetString(16); }
                    //乳房高度
                    if (sqldatareader_f1.IsDBNull(17)) { TextBox184.Text = ""; } else { TextBox184.Text = sqldatareader_f1.GetString(17); }
                    //胸围Ⅰ
                    if (sqldatareader_f1.IsDBNull(18)) { TextBox185.Text = ""; } else { TextBox185.Text = sqldatareader_f1.GetString(18); }
                    //胸围Ⅱ
                    if (sqldatareader_f1.IsDBNull(19)) { TextBox186.Text = ""; } else { TextBox186.Text = sqldatareader_f1.GetString(19); }
                    //胸围Ⅲ
                    if (sqldatareader_f1.IsDBNull(20)) { TextBox187.Text = ""; } else { TextBox187.Text = sqldatareader_f1.GetString(20); }
                    //乳房半径
                    if (sqldatareader_f1.IsDBNull(21)) { TextBox188.Text = ""; } else { TextBox188.Text = sqldatareader_f1.GetString(21); }
                    //乳房体积计算1
                    if (sqldatareader_f1.IsDBNull(22)) { TextBox189.Text = ""; } else { TextBox189.Text = sqldatareader_f1.GetString(22); }
                    //超重体重
                    if (sqldatareader_f1.IsDBNull(23)) { TextBox190.Text = ""; } else { TextBox190.Text = sqldatareader_f1.GetString(23); }
                    //乳房体积计算2
                    if (sqldatareader_f1.IsDBNull(24)) { TextBox191.Text = ""; } else { TextBox191.Text = sqldatareader_f1.GetString(24); }

                }
                sqlcommand_f1 = null;
                sqlconn_f1.Close();
                sqlconn_f1 = null;
                str += "<br />";
                str += "<div>保乳术</div>";
                str += "<div>&nbsp;术前信息1</div>";
                str += "<div>&nbsp;&nbsp;体检信息</div>";
                str += "<div>&nbsp;&nbsp;肿瘤部位（钟表法）：" + TextBox167.Text + "&nbsp;侧" + TextBox168.Text + "&nbsp;点&nbsp;&nbsp;肿瘤大小：" + TextBox169.Text + "×" + TextBox170.Text + "cm&nbsp;&nbsp;肿瘤与乳头距离：" + TextBox171.Text + "cm" + "</div>";
                str += "<div>&nbsp;&nbsp;乳房形态学基线测量</div>";
                str += "<div>&nbsp;&nbsp;乳房位置测量</div>";
                str += "<div>&nbsp;&nbsp;胸乳距：" + TextBox172.Text + "cm&nbsp;&nbsp;乳胸距：" + TextBox173.Text + "cm&nbsp;&nbsp;锁胸距：" + TextBox174.Text + "cm" + "</div>";
                str += "<div>&nbsp;&nbsp;胸骨正中距：" + TextBox175.Text + "cm&nbsp;&nbsp;乳头间距：" + TextBox176.Text + "cm" + "</div>";
                str += "<div>&nbsp;&nbsp;乳房形态测量</div>";
                str += "<div>&nbsp;&nbsp;乳房基底横径：" + TextBox177.Text + "cm&nbsp;&nbsp;乳房内侧半径：" + TextBox178.Text + "cm&nbsp;&nbsp;乳房外侧半径：" + TextBox179.Text + "cm&nbsp;&nbsp;乳房下侧半径：" + TextBox180.Text + "cm" + "</div>";
                str += "<div>&nbsp;&nbsp;乳头至下皱襞体表距离：" + TextBox181.Text + "cm&nbsp;&nbsp;乳晕直径：" + TextBox182.Text + "cm&nbsp;&nbsp;乳头直径：" + TextBox183.Text + "cm&nbsp;&nbsp;乳房高度：" + TextBox184.Text + "cm" + "</div>";
                str += "<div>&nbsp;&nbsp;其他</div>";
                str += "<div>&nbsp;&nbsp;胸围Ⅰ(经腋下)：" + TextBox185.Text + "cm&nbsp;&nbsp;胸围Ⅱ(经乳头)：" + TextBox186.Text + "cm&nbsp;&nbsp;胸围Ⅲ(经下皱襞)：" + TextBox187.Text + "cm" + "</div>";
                str += "<div>&nbsp;&nbsp;乳房体积</div>";
                str += "<div>&nbsp;&nbsp;乳房体积=1/3Π× 乳房高度 ²×(3×乳房半径" + TextBox188.Text + "&nbsp;-乳房高度）= " + TextBox189.Text + "&nbsp;ml</div>";
                str += "<div>&nbsp;&nbsp;乳房体积=250+50×胸围差×（ - ）+20×超重体重" + TextBox190.Text + "&nbsp=" + TextBox191.Text + "&nbsp;ml</div>";

                //f2
                SqlConnection sqlconn_f2 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_f2 = new SqlCommand();
                sqlcommand_f2.Connection = sqlconn_f2;

                sqlconn_f2.Open();//attention
                sqlcommand_f2.CommandText = "select * from f术前信息2 where 就诊卡号=@就诊卡号";
                sqlcommand_f2.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_f2 = sqlcommand_f2.ExecuteReader();
                if (sqldatareader_f2.Read())
                {
                    f2Tb1.Text = sqldatareader_f2.GetString(0);
                    f2Tb2.Text = sqldatareader_f2.GetString(1);
                    f2Tb3.Text = sqldatareader_f2.GetString(2);

                }
                sqlcommand_f2 = null;
                sqlconn_f2.Close();
                sqlconn_f2 = null;
                str += "<br />";
                str += "<div>&nbsp;术前信息2</div>";
                str += "<div>&nbsp;&nbsp;影像信息</div>";
                str += "<div>&nbsp;&nbsp;" + f2Tb1.Text + "</div>";
                str += "<div>&nbsp;&nbsp;诊断信息</div>";
                str += "<div>&nbsp;&nbsp;" + f2Tb2.Text + "</div>";
                str += "<div>&nbsp;&nbsp;治疗信息</div>";
                str += "<div>&nbsp;&nbsp;" + f2Tb3.Text + "</div>";

                //f3
                SqlConnection sqlconn_f3 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_f3 = new SqlCommand();
                sqlcommand_f3.Connection = sqlconn_f3;

                sqlconn_f3.Open();//attention
                sqlcommand_f3.CommandText = "select * from f手术信息 where 就诊卡号=@就诊卡号";
                sqlcommand_f3.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_f3 = sqlcommand_f3.ExecuteReader();
                if (sqldatareader_f3.Read())
                {
                    //@切口类型
                    string f3_1 = sqldatareader_f3.GetString(0).Trim();
                    if (f3_1.Contains("放射型")) { RadioButton1.Checked = true; }
                    if (f3_1.Contains("弧形（垂直于放射型）")) { RadioButton2.Checked = true; }
                    if (f3_1.Contains("其他")) { RadioButton3.Checked = true; }
                    //切口类型_其他
                    if (sqldatareader_f3.IsDBNull(1)) { TextBox310.Text = ""; } else { TextBox310.Text = sqldatareader_f3.GetString(1); }
                    //横径
                    if (sqldatareader_f3.IsDBNull(2)) { TextBox192.Text = ""; } else { TextBox192.Text = sqldatareader_f3.GetString(2); }
                    //纵径
                    if (sqldatareader_f3.IsDBNull(3)) { TextBox193.Text = ""; } else { TextBox193.Text = sqldatareader_f3.GetString(3); }
                    //体积_排水法
                    if (sqldatareader_f3.IsDBNull(4)) { TextBox194.Text = ""; } else { TextBox194.Text = sqldatareader_f3.GetString(4); }
                    //切缘病理阴阳性
                    string f3_2 = sqldatareader_f3.GetString(5).Trim();
                    if (f3_2.Contains("阴性")) { RadioButton4.Checked = true; }
                    if (f3_2.Contains("阳性")) { RadioButton5.Checked = true; }
                    //切缘病理位置
                    if (sqldatareader_f3.IsDBNull(6)) { TextBox195.Text = ""; } else { TextBox195.Text = sqldatareader_f3.GetString(6); }
                    //是否二次扩切
                    string f3_3 = sqldatareader_f3.GetString(7).Trim();
                    if (f3_3.Contains("否")) { RadioButton6.Checked = true; }
                    if (f3_3.Contains("是")) { RadioButton7.Checked = true; }
                    //二次切缘病理阴阳性
                    string f3_4 = sqldatareader_f3.GetString(8).Trim();
                    if (f3_4.Contains("阴性")) { RadioButton8.Checked = true; }
                    if (f3_4.Contains("阳性")) { RadioButton9.Checked = true; }
                    //二次切缘病理位置
                    if (sqldatareader_f3.IsDBNull(9)) { TextBox196.Text = ""; } else { TextBox196.Text = sqldatareader_f3.GetString(9); }
                    //保乳术是否成功
                    string f3_5 = sqldatareader_f3.GetString(10).Trim();
                    if (f3_5.Contains("是")) { RadioButton10.Checked = true; }
                    if (f3_5.Contains("否")) { RadioButton11.Checked = true; }
                    //是否前哨淋巴结活检
                    string f3_6 = sqldatareader_f3.GetString(11).Trim();
                    if (f3_6.Contains("是")) { RadioButton12.Checked = true; }
                    if (f3_6.Contains("否")) { RadioButton13.Checked = true; }
                    //是否保乳整形
                    string f3_7 = sqldatareader_f3.GetString(12).Trim();
                    if (f3_7.Contains("否")) { RadioButton14.Checked = true; }
                    if (f3_7.Contains("是")) { RadioButton15.Checked = true; }
                    //整形方式
                    if (sqldatareader_f3.IsDBNull(13)) { TextBox311.Text = ""; } else { TextBox311.Text = sqldatareader_f3.GetString(13); }

                }
                str += "<br />";
                str += "<div>&nbsp;手术信息</div>";
                str += "<div>&nbsp;&nbsp;切口类型：" + sqldatareader_f3.GetString(0).Trim();
                if (sqldatareader_f3.GetString(0).Trim() == "其他") { str += TextBox310.Text + "</div>"; } else { str += "</div>"; }
                str += "<div>&nbsp;&nbsp;标本大小：横径：" + TextBox192.Text + "cm&nbsp;&nbsp;纵径：" + TextBox193.Text + "cm&nbsp;&nbsp;体积(排水法)：" + TextBox194.Text + "ml" + "</div>";
                str += "<div>&nbsp;&nbsp;切缘病理：" + sqldatareader_f3.GetString(5).Trim() + "位置(按照钟表标准化)&nbsp;" + TextBox195.Text + "点</div>";
                if (RadioButton7.Checked == true)
                {
                    str += "<div>&nbsp;&nbsp;是否二次扩切：是</div>";
                    str += "<div>&nbsp;&nbsp;二次切缘病理：" + sqldatareader_f3.GetString(8).Trim() + "位置(按照钟表标准化)&nbsp;" + TextBox196.Text + "点</div>";
                }
                else { str += "<div>&nbsp;&nbsp;是否二次扩切：否</div>"; }
                str += "<div>&nbsp;&nbsp;保乳术是否成功：" + sqldatareader_f3.GetString(10).Trim() + "</div>";
                str += "<div>&nbsp;&nbsp;前哨淋巴结活检：" + sqldatareader_f3.GetString(11).Trim() + "</div>";
                str += "<div>&nbsp;&nbsp;是否保乳整形：" + sqldatareader_f3.GetString(12).Trim();
                if (RadioButton15.Checked == true) { str += "&nbsp;&nbsp;整形方式" + TextBox311.Text + "</div>"; } else { str += "</div>"; }
                sqlcommand_f3 = null;
                sqlconn_f3.Close();
                sqlconn_f3 = null;

                //f4
                SqlConnection sqlconn_f4 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_f4 = new SqlCommand();
                sqlcommand_f4.Connection = sqlconn_f4;

                sqlconn_f4.Open();//attention
                sqlcommand_f4.CommandText = "select * from f术后信息 where 就诊卡号=@就诊卡号";
                sqlcommand_f4.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_f4 = sqlcommand_f4.ExecuteReader();
                if (sqldatareader_f4.Read())
                {

                    f4Tb1.Text = sqldatareader_f4.GetString(0);
                    f4Tb2.Text = sqldatareader_f4.GetString(1);
                    if (sqldatareader_f4.GetString(2) == f4Rb1.Text) { f4Rb1.Checked = true; }
                    if (sqldatareader_f4.GetString(2) == f4Rb2.Text) { f4Rb2.Checked = true; }
                    f4Tb3.Text = sqldatareader_f4.GetString(3);//处理方式
                    f4Tb4.Text = sqldatareader_f4.GetString(4);//术后放疗

                }
                str += "<br />";
                str += "<div>&nbsp;术后信息</div>";
                str += "<div>&nbsp;&nbsp;术后信息</div>";
                str += "<div>&nbsp;&nbsp;引流时间(天):" + f4Tb1.Text + "&nbsp;&nbsp;&nbsp;引流总量(ml):" + f4Tb2.Text + "</div>";
                str += "<div>&nbsp;&nbsp; 是否术后感染：" + sqldatareader_f4.GetString(2).Trim();
                if (f4Rb2.Checked == true) { str += "&nbsp;&nbsp;处理方式" + f4Tb3.Text + "</div>"; } else { str += "</div>"; }
                str += "<div>&nbsp;&nbsp;术后放疗</div>";
                str += "<div>&nbsp;&nbsp;" + f4Tb4.Text + "</div>";
                sqlcommand_f4 = null;
                sqlconn_f4.Close();
                sqlconn_f4 = null;

                //f5
                SqlConnection sqlconn_f5 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_f5 = new SqlCommand();
                sqlcommand_f5.Connection = sqlconn_f5;

                sqlconn_f5.Open();//attention
                sqlcommand_f5.CommandText = "select * from f生活质量及美学指标 where 就诊卡号=@就诊卡号";
                sqlcommand_f5.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_f5 = sqlcommand_f5.ExecuteReader();
                if (sqldatareader_f5.Read())
                {
                    if (sqldatareader_f5.GetString(0) == RadioButton18.Text) { RadioButton18.Checked = true; }
                    if (sqldatareader_f5.GetString(0) == RadioButton19.Text) { RadioButton19.Checked = true; }
                    if (sqldatareader_f5.GetString(0) == RadioButton20.Text) { RadioButton20.Checked = true; }
                    if (sqldatareader_f5.GetString(0) == RadioButton21.Text) { RadioButton21.Checked = true; }

                    if (sqldatareader_f5.GetString(1) == "") { }
                    else { RadioButtonList51.SelectedValue = sqldatareader_f5.GetString(1).Trim(); }
                    if (sqldatareader_f5.GetString(2) == "") { }
                    else { RadioButtonList52.SelectedValue = sqldatareader_f5.GetString(2).Trim(); }
                    if (sqldatareader_f5.GetString(3) == "") { }
                    else { RadioButtonList53.SelectedValue = sqldatareader_f5.GetString(3).Trim(); }
                    if (sqldatareader_f5.GetString(4) == "") { }
                    else { RadioButtonList54.SelectedValue = sqldatareader_f5.GetString(4).Trim(); }
                    if (sqldatareader_f5.GetString(5) == "") { }
                    else { RadioButtonList55.SelectedValue = sqldatareader_f5.GetString(5).Trim(); }
                    if (sqldatareader_f5.GetString(6) == "") { }
                    else { RadioButtonList56.SelectedValue = sqldatareader_f5.GetString(6).Trim(); }
                    if (sqldatareader_f5.GetString(7) == "") { }
                    else { RadioButtonList57.SelectedValue = sqldatareader_f5.GetString(7).Trim(); }
                    if (sqldatareader_f5.GetString(8) == "") { }
                    else { RadioButtonList58.SelectedValue = sqldatareader_f5.GetString(8).Trim(); }
                    if (sqldatareader_f5.GetString(9) == "") { }
                    else { RadioButtonList59.SelectedValue = sqldatareader_f5.GetString(9).Trim(); }
                    if (sqldatareader_f5.GetString(10) == "") { }
                    else { RadioButtonList60.SelectedValue = sqldatareader_f5.GetString(10).Trim(); }

                    if (sqldatareader_f5.GetString(11) == "") { }
                    else { RadioButtonList61.SelectedValue = sqldatareader_f5.GetString(11).Trim(); }
                    if (sqldatareader_f5.GetString(12) == "") { }
                    else { RadioButtonList62.SelectedValue = sqldatareader_f5.GetString(12).Trim(); }
                    if (sqldatareader_f5.GetString(13) == "") { }
                    else { RadioButtonList63.SelectedValue = sqldatareader_f5.GetString(13).Trim(); }
                    if (sqldatareader_f5.GetString(14) == "") { }
                    else { RadioButtonList64.SelectedValue = sqldatareader_f5.GetString(14).Trim(); }
                    if (sqldatareader_f5.GetString(15) == "") { }
                    else { RadioButtonList65.SelectedValue = sqldatareader_f5.GetString(15).Trim(); }
                    if (sqldatareader_f5.GetString(16) == "") { }
                    else { RadioButtonList66.SelectedValue = sqldatareader_f5.GetString(16).Trim(); }
                    if (sqldatareader_f5.GetString(17) == "") { }
                    else { RadioButtonList67.SelectedValue = sqldatareader_f5.GetString(17).Trim(); }
                    if (sqldatareader_f5.GetString(18) == "") { }
                    else { RadioButtonList68.SelectedValue = sqldatareader_f5.GetString(18).Trim(); }
                    if (sqldatareader_f5.GetString(19) == "") { }
                    else { RadioButtonList69.SelectedValue = sqldatareader_f5.GetString(19).Trim(); }
                    if (sqldatareader_f5.GetString(20) == "") { }
                    else { RadioButtonList70.SelectedValue = sqldatareader_f5.GetString(20).Trim(); }

                    if (sqldatareader_f5.GetString(21) == "") { }
                    else { RadioButtonList71.SelectedValue = sqldatareader_f5.GetString(21).Trim(); }
                    if (sqldatareader_f5.GetString(22) == "") { }
                    else { RadioButtonList72.SelectedValue = sqldatareader_f5.GetString(22).Trim(); }
                    if (sqldatareader_f5.GetString(23) == "") { }
                    else { RadioButtonList73.SelectedValue = sqldatareader_f5.GetString(23).Trim(); }
                    if (sqldatareader_f5.GetString(24) == "") { }
                    else { RadioButtonList74.SelectedValue = sqldatareader_f5.GetString(24).Trim(); }
                    if (sqldatareader_f5.GetString(25) == "") { }
                    else { RadioButtonList75.SelectedValue = sqldatareader_f5.GetString(25).Trim(); }
                    if (sqldatareader_f5.GetString(26) == "") { }
                    else { RadioButtonList76.SelectedValue = sqldatareader_f5.GetString(26).Trim(); }
                    if (sqldatareader_f5.GetString(27) == "") { }
                    else { RadioButtonList77.SelectedValue = sqldatareader_f5.GetString(27).Trim(); }
                    if (sqldatareader_f5.GetString(28) == "") { }
                    else { RadioButtonList78.SelectedValue = sqldatareader_f5.GetString(28).Trim(); }
                    if (sqldatareader_f5.GetString(29) == "") { }
                    else { RadioButtonList79.SelectedValue = sqldatareader_f5.GetString(29).Trim(); }
                    if (sqldatareader_f5.GetString(30) == "") { }
                    else { RadioButtonList80.SelectedValue = sqldatareader_f5.GetString(30).Trim(); }
                    if (sqldatareader_f5.GetString(31) == "") { }
                    else { RadioButtonList81.SelectedValue = sqldatareader_f5.GetString(31).Trim(); }

                    TextBox199.Text = sqldatareader_f5.GetString(32);
                    TextBox200.Text = sqldatareader_f5.GetString(33);
                    TextBox201.Text = sqldatareader_f5.GetString(34);
                    TextBox202.Text = sqldatareader_f5.GetString(35);
                    //就诊卡号索引sqldatareader_f1.GetString(36);

                    if (sqldatareader_f5.GetString(37) == "") { }
                    else { RadioButtonList82.SelectedValue = sqldatareader_f5.GetString(37).Trim(); }

                }

                str += "<br />";
                str += "<div>&nbsp;生活质量及美学指标</div>";
                str += "<div>&nbsp;&nbsp;主观美容及功能评估</div>";
                str += "<div>&nbsp;&nbsp;Harris分级标准评估</div>";
                str += "<div><table border-collapse='0'><tr><td>分级</td><td>标准</td></tr>";
                str += "<tr><td>" + sqldatareader_f5.GetString(0) + "</td>";
                if (sqldatareader_f5.GetString(0) == "非常好") { str += "<td>非常好的对称性，无可见的畸变和皮肤改变。</td></tr></table></div>"; }
                else
                {
                    if (sqldatareader_f5.GetString(0) == "很好") { str += "<td>轻微的皮肤改变、退缩或水肿；轻微的毛细血管扩张，轻微的色素沉着，或乳头乳晕复合体缺失。</td></tr></table></div>"; }
                    else
                    {
                        if (sqldatareader_f5.GetString(0) == "一般") { str += "<td>中度的乳头或乳房对称性畸变，中度的色素沉着，明显的皮肤退缩、水肿或毛细血管扩张。</td></tr></table></div>"; }
                        else { str += "<td>明显的畸变、水肿或纤维化，或者严重的色素沉着。</td></tr></table></div>"; }
                    }
                }
                str += "<div>&nbsp;&nbsp;BCTOS美容及功能评分</div>";
                str += "<div><table border-collapse='0'><tr><td>项目</td><td>评分</td></tr>";
                str += "<tr><td>乳房大小</td><td>" + sqldatareader_f5.GetString(1).Trim() + "</td></tr>";
                str += "<tr><td>乳房质地(有无硬化)</td><td>" + sqldatareader_f5.GetString(37).Trim() + "</td></tr>";
                str += "<tr><td>乳房形状</td><td>" + sqldatareader_f5.GetString(2).Trim() + "</td></tr>";
                str += "<tr><td>乳房挺度(高度)</td><td>" + sqldatareader_f5.GetString(3).Trim() + "</td></tr>";
                str += "<tr><td>乳房皮肤颜色</td><td>" + sqldatareader_f5.GetString(4).Trim() + "</td></tr>";
                str += "<tr><td>乳房敏感度（感觉）</td><td>" + sqldatareader_f5.GetString(5).Trim() + "</td></tr>";
                str += "<tr><td>乳房外观</td><td>" + sqldatareader_f5.GetString(6).Trim() + "</td></tr>";
                str += "<tr><td>瘢痕组织</td><td>" + sqldatareader_f5.GetString(7).Trim() + "</td></tr>";
                str += "<tr><td>乳房肿胀</td><td>" + sqldatareader_f5.GetString(8).Trim() + "</td></tr>";
                str += "<tr><td>乳房疼痛</td><td>" + sqldatareader_f5.GetString(9).Trim() + "</td></tr>";
                str += "<tr><td>乳房触感（有无触痛）</td><td>" + sqldatareader_f5.GetString(10).Trim() + "</td></tr>";
                str += "<tr><td>肩部疼痛</td><td>" + sqldatareader_f5.GetString(11).Trim() + "</td></tr>";
                str += "<tr><td>肩部僵硬</td><td>" + sqldatareader_f5.GetString(12).Trim() + "</td></tr>";
                str += "<tr><td>肩部活动</td><td>" + sqldatareader_f5.GetString(13).Trim() + "</td></tr>";
                str += "<tr><td>上肢疼痛</td><td>" + sqldatareader_f5.GetString(14).Trim() + "</td></tr>";
                str += "<tr><td>上肢僵硬</td><td>" + sqldatareader_f5.GetString(15).Trim() + "</td></tr>";
                str += "<tr><td>上肢活动</td><td>" + sqldatareader_f5.GetString(16).Trim() + "</td></tr>";
                str += "<tr><td>上肢肿胀</td><td>" + sqldatareader_f5.GetString(17).Trim() + "</td></tr>";
                str += "<tr><td>提举重物的能力</td><td>" + sqldatareader_f5.GetString(18).Trim() + "</td></tr>";
                str += "<tr><td>肋部疼痛</td><td>" + sqldatareader_f5.GetString(19).Trim() + "</td></tr>";
                str += "<tr><td>乳罩的合适度</td><td>" + sqldatareader_f5.GetString(20).Trim() + "</td></tr>";
                str += "<tr><td>衣服的合适度</td><td>" + sqldatareader_f5.GetString(21).Trim() + "</td></tr></table></div>";
                str += "<div>注：0:与对侧相比无区别；1:与对侧相比有轻微区别；2:与对侧相比有中度区别；3:与对侧相比有很大区别。</div>";
                str += "<div>&nbsp;&nbsp;BIS身体形象评分</div>";
                str += "<div><table border-collapse='0'><tr><td>项目</td><td>评分</td></tr>";
                str += "<tr><td>您经常对您的形象很在意吗？</td><td>" + sqldatareader_f5.GetString(22).Trim() + "</td></tr>";
                str += "<tr><td>您感到因为您的疾病或治疗，导致您在身体上的吸引力不如从前了吗？</td><td>" + sqldatareader_f5.GetString(23).Trim() + "</td></tr>";
                str += "<tr><td>在您着装后，您对您的形象有不满意吗？</td><td>" + sqldatareader_f5.GetString(24).Trim() + "</td></tr>";
                str += "<tr><td>您感到因为您的疾病或治疗，导致您的女性气质降低吗？</td><td>" + sqldatareader_f5.GetString(25).Trim() + "</td></tr>";
                str += "<tr><td>您感到很难面对您的裸体吗？</td><td>" + sqldatareader_f5.GetString(26).Trim() + "</td></tr>";
                str += "<tr><td>您感到因为您的疾病或治疗，导致您的吸引力降低吗？</td><td>" + sqldatareader_f5.GetString(27).Trim() + "</td></tr>";
                str += "<tr><td>您有因为您的形象而躲避人群吗？</td><td>" + sqldatareader_f5.GetString(28).Trim() + "</td></tr>";
                str += "<tr><td>您感到因为您的治疗而导致您的身体不完整吗？</td><td>" + sqldatareader_f5.GetString(29).Trim() + "</td></tr>";
                str += "<tr><td>您对您的身体有不满意吗？</td><td>" + sqldatareader_f5.GetString(30).Trim() + "</td></tr>";
                str += "<tr><td>您对您的伤疤的外观有不满意吗？</td><td>" + sqldatareader_f5.GetString(31).Trim() + "</td></tr></table></div>";
                str += "<div>注：一点也不=0；有一点=1；相当多=2；非常=3</div>";
                str += "<div>客观美容及功能评估</div>";
                str += "<div>对患侧及健侧乳房体积的评估-体积变化VD(%)=" + TextBox199.Text + "</div>";
                str += "<div>乳房对称性的评估-乳头对称性的变化ND(%)=" + TextBox200.Text + "</div>";
                str += "<div>纤维化的评估-增厚或硬化的组织占乳房的体积比F(%)=" + TextBox201.Text + "</div>";
                str += "<div>毛细血管扩张的评估-毛细血管扩张占乳房皮肤的比例T(%)" + TextBox202.Text + "</div>";
                sqlcommand_f5 = null;
                sqlconn_f5.Close();
                sqlconn_f5 = null;

                //写入
                sw.Write(str);
                sw.Close();
                Response.Clear();
                Response.Buffer = true;
                this.EnableViewState = false;
                Response.Charset = "utf-8";
                Response.AppendHeader("Content-Disposition", "attachment;filename=" + HttpUtility.UrlEncode(fileName, System.Text.Encoding.UTF8));
                Response.ContentType = "application/octet-stream";
                Response.WriteFile(path);
                Response.Flush();
                Response.Close();
                Response.End();
            }
        }
        //生成随访问卷
        protected void Button8_Click(object sender, EventArgs e)
        {
            if (Label500.Text == "")
            {
                Response.Write("<script language='javascript'>alert('请选择数据！')</script>");
            }
            else
            {
                Random rd = new Random();
                string fileName = TextBox2.Text.ToString() + "_随访问卷"+rd.Next() + ".xls";
                //存储路径
                string path = Server.MapPath(fileName);
                //创建字符输出流
                StreamWriter sw = new StreamWriter(path, true, System.Text.UnicodeEncoding.UTF8);

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString());
                string sqlconnstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

                SqlConnection sqlconn_d1 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_d1 = new SqlCommand();
                sqlcommand_d1.Connection = sqlconn_d1;

                sqlconn_d1.Open();//attention
                sqlcommand_d1.CommandText = "select * from d一般 where 就诊卡号=@就诊卡号";
                sqlcommand_d1.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_d1 = sqlcommand_d1.ExecuteReader();
                if (sqldatareader_d1.Read())
                {
                    if (sqldatareader_d1.IsDBNull(1)) { TextBox131.Text = ""; } else { TextBox131.Text = sqldatareader_d1.GetString(1); }
                    if (sqldatareader_d1.IsDBNull(2)) { TextBox132.Text = ""; } else { TextBox132.Text = sqldatareader_d1.GetString(2); }
                    if (sqldatareader_d1.IsDBNull(3)) { TextBox133.Text = ""; } else { TextBox133.Text = sqldatareader_d1.GetString(3); }
                    if (sqldatareader_d1.GetString(4).Trim() == "1") { CheckBox1.Checked = true; } else { CheckBox1.Checked = false; }
                    if (sqldatareader_d1.IsDBNull(5)) { TextBox134.Text = ""; } else { TextBox134.Text = sqldatareader_d1.GetString(5); }
                    if (sqldatareader_d1.GetString(6).Trim() == "1") { CheckBox2.Checked = true; } else { CheckBox2.Checked = false; }
                    if (sqldatareader_d1.IsDBNull(7)) { TextBox135.Text = ""; } else { TextBox135.Text = sqldatareader_d1.GetString(7); }
                    if (sqldatareader_d1.IsDBNull(8)) { } else { if (sqldatareader_d1.GetString(8).Trim() == "1") { CheckBox3.Checked = true; } else { CheckBox3.Checked = false; } }
                    if (sqldatareader_d1.IsDBNull(9)) { TextBox136.Text = ""; } else { TextBox136.Text = sqldatareader_d1.GetString(9); }
                    if (sqldatareader_d1.GetString(10).Trim() == "1") { CheckBox4.Checked = true; } else { CheckBox4.Checked = false; }
                    if (sqldatareader_d1.IsDBNull(11)) { TextBox137.Text = ""; } else { TextBox137.Text = sqldatareader_d1.GetString(11); }
                    if (sqldatareader_d1.GetString(12).Trim() == "1") { CheckBox5.Checked = true; } else { CheckBox5.Checked = false; }
                    if (sqldatareader_d1.IsDBNull(13)) { TextBox138.Text = ""; } else { TextBox138.Text = sqldatareader_d1.GetString(13); }

                }
                sqlcommand_d1 = null;
                sqlconn_d1.Close();
                sqlconn_d1 = null;

                string str = "";
                str += "<html><head><title></title></head><body>";
                str += "<br />";
                str += "<div>随访</div>";
                str += "<div>&nbsp;&nbsp;一般</div>";
                str += "<div>&nbsp;&nbsp;&nbsp;&nbsp;病理：&nbsp;" + TextBox131.Text + "<br/>&nbsp;&nbsp;&nbsp;&nbsp;淋巴结:&nbsp;" + TextBox132.Text + "<br/>&nbsp;&nbsp;&nbsp;&nbsp;分子类型:&nbsp;" + TextBox133.Text + "</div>";
                str += "<div>&nbsp;&nbsp;术后治疗&nbsp;</div>";
                if (CheckBox1.Checked == true) { str += "&nbsp;&nbsp;&nbsp;&nbsp;化疗；&nbsp;&nbsp;" + TextBox134.Text; }
                if (CheckBox2.Checked == true) { str += "&nbsp;&nbsp;&nbsp;&nbsp;放疗：&nbsp;&nbsp;" + TextBox135.Text; }
                if (CheckBox3.Checked == true) { str += "&nbsp;&nbsp;&nbsp;&nbsp;内分泌：&nbsp;&nbsp;" + TextBox136.Text; }
                if (CheckBox4.Checked == true) { str += "&nbsp;&nbsp;&nbsp;&nbsp;靶向：&nbsp;&nbsp;" + TextBox137.Text; }
                if (CheckBox5.Checked == true) { str += "&nbsp;&nbsp;&nbsp;&nbsp;生物治疗：&nbsp;&nbsp;" + TextBox138.Text; }
                if (CheckBox1.Checked == false && CheckBox2.Checked == false && CheckBox1.Checked == false && CheckBox3.Checked == false && CheckBox4.Checked == false && CheckBox5.Checked == false)
                {
                    str += "&nbsp;&nbsp;&nbsp;&nbsp;无";
                }

                //d2导出
                SqlConnection sqlconn_d2 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_d2 = new SqlCommand();
                sqlcommand_d2.Connection = sqlconn_d2;

                sqlconn_d2.Open();//attention
                sqlcommand_d2.CommandText = "select * from d乳腺复发转移 where 就诊卡号=@就诊卡号";
                sqlcommand_d2.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_d2 = sqlcommand_d2.ExecuteReader();
                if (sqldatareader_d2.Read())
                {
                    string d2_1 = sqldatareader_d2.GetString(1).Trim();
                    //读数字
                    char[] result = d2_1.ToCharArray();
                    string str_d2 = "";
                    for (int i = 0; i < d2_1.Length; i++)
                    {
                        if (result[i] >= '0' && result[i] <= '9')
                        {
                            str_d2 += result[i];
                        }
                    }
                    TextBox139.Text = str_d2;
                    //读单位
                    if (sqldatareader_d2.GetString(1) == "") { } else { DropDownList29.SelectedValue = d2_1.Substring(d2_1.Length - 1, 1); }
                    if (sqldatareader_d2.GetString(2) == "") { } else { RadioButtonList17.SelectedValue = sqldatareader_d2.GetString(2).Trim(); }
                    if (sqldatareader_d2.IsDBNull(3)) { TextBox140.Text = ""; } else { TextBox140.Text = sqldatareader_d2.GetString(3); }
                    if (sqldatareader_d2.GetString(4) == "") { } else { RadioButtonList18.SelectedValue = sqldatareader_d2.GetString(4).Trim(); }
                    if (sqldatareader_d2.IsDBNull(5)) { TextBox145.Text = ""; } else { TextBox145.Text = sqldatareader_d2.GetString(5); }
                    if (sqldatareader_d2.GetString(6) == "") { } else { RadioButtonList15.SelectedValue = sqldatareader_d2.GetString(6).Trim(); }
                    if (sqldatareader_d2.IsDBNull(7)) { TextBox142.Text = ""; } else { TextBox142.Text = sqldatareader_d2.GetString(7); }
                    if (sqldatareader_d2.GetString(8) == "") { } else { RadioButtonList16.SelectedValue = sqldatareader_d2.GetString(8).Trim(); }
                    if (sqldatareader_d2.IsDBNull(9)) { TextBox144.Text = ""; } else { TextBox144.Text = sqldatareader_d2.GetString(9); }
                    if (sqldatareader_d2.GetString(10) == "") { } else { RadioButtonList13.SelectedValue = sqldatareader_d2.GetString(10).Trim(); }
                    if (sqldatareader_d2.IsDBNull(11)) { TextBox141.Text = ""; } else { TextBox141.Text = sqldatareader_d2.GetString(11); }
                    if (sqldatareader_d2.GetString(12).Trim() == "是") { CheckBox6.Checked = true; } else { CheckBox6.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(13)) { TextBox143.Text = ""; } else { TextBox143.Text = sqldatareader_d2.GetString(13); }
                    if (sqldatareader_d2.GetString(14).Trim() == "是") { CheckBox7.Checked = true; } else { CheckBox7.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(15)) { TextBox146.Text = ""; } else { TextBox146.Text = sqldatareader_d2.GetString(15); }//胸片
                    if (sqldatareader_d2.GetString(16) == "") { } else { RadioButtonList14.SelectedValue = sqldatareader_d2.GetString(16).Trim(); }
                    if (sqldatareader_d2.IsDBNull(17)) { TextBox147.Text = ""; } else { TextBox147.Text = sqldatareader_d2.GetString(17); }
                    if (sqldatareader_d2.GetString(18).Trim() == "是") { CheckBox8.Checked = true; } else { CheckBox8.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(19)) { TextBox148.Text = ""; } else { TextBox148.Text = sqldatareader_d2.GetString(19); }
                    if (sqldatareader_d2.GetString(20).Trim() == "是") { CheckBox9.Checked = true; } else { CheckBox9.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(21)) { TextBox149.Text = ""; } else { TextBox149.Text = sqldatareader_d2.GetString(21); }//BUS
                    if (sqldatareader_d2.GetString(22) == "") { } else { RadioButtonList19.SelectedValue = sqldatareader_d2.GetString(22).Trim(); }
                    if (sqldatareader_d2.IsDBNull(23)) { TextBox150.Text = ""; } else { TextBox150.Text = sqldatareader_d2.GetString(23); }
                    if (sqldatareader_d2.GetString(24).Trim() == "是") { CheckBox10.Checked = true; } else { CheckBox10.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(25)) { TextBox151.Text = ""; } else { TextBox151.Text = sqldatareader_d2.GetString(25); }
                    if (sqldatareader_d2.GetString(26).Trim() == "是") { CheckBox11.Checked = true; } else { CheckBox11.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(27)) { TextBox152.Text = ""; } else { TextBox152.Text = sqldatareader_d2.GetString(27); }//肿瘤标志物
                    if (sqldatareader_d2.GetString(28) == "") { } else { RadioButtonList20.SelectedValue = sqldatareader_d2.GetString(28).Trim(); }
                    if (sqldatareader_d2.IsDBNull(29)) { TextBox153.Text = ""; } else { TextBox153.Text = sqldatareader_d2.GetString(29); }
                    if (sqldatareader_d2.GetString(30).Trim() == "是") { CheckBox12.Checked = true; } else { CheckBox12.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(31)) { TextBox154.Text = ""; } else { TextBox154.Text = sqldatareader_d2.GetString(31); }
                    if (sqldatareader_d2.GetString(32).Trim() == "是") { CheckBox13.Checked = true; } else { CheckBox13.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(33)) { TextBox155.Text = ""; } else { TextBox155.Text = sqldatareader_d2.GetString(33); }//CT
                    if (sqldatareader_d2.GetString(34) == "") { } else { RadioButtonList21.SelectedValue = sqldatareader_d2.GetString(34).Trim(); }
                    if (sqldatareader_d2.IsDBNull(35)) { TextBox156.Text = ""; } else { TextBox156.Text = sqldatareader_d2.GetString(35); }
                    if (sqldatareader_d2.GetString(36).Trim() == "是") { CheckBox14.Checked = true; } else { CheckBox14.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(37)) { TextBox157.Text = ""; } else { TextBox157.Text = sqldatareader_d2.GetString(37); }
                    if (sqldatareader_d2.GetString(38).Trim() == "是") { CheckBox15.Checked = true; } else { CheckBox15.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(39)) { TextBox158.Text = ""; } else { TextBox158.Text = sqldatareader_d2.GetString(39); }//ECT
                    if (sqldatareader_d2.GetString(40) == "") { } else { RadioButtonList22.SelectedValue = sqldatareader_d2.GetString(40).Trim(); }
                    if (sqldatareader_d2.IsDBNull(41)) { TextBox159.Text = ""; } else { TextBox159.Text = sqldatareader_d2.GetString(41); }
                    if (sqldatareader_d2.GetString(42).Trim() == "是") { CheckBox16.Checked = true; } else { CheckBox16.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(43)) { TextBox160.Text = ""; } else { TextBox160.Text = sqldatareader_d2.GetString(43); }
                    if (sqldatareader_d2.GetString(44).Trim() == "是") { CheckBox17.Checked = true; } else { CheckBox17.Checked = false; }
                    if (sqldatareader_d2.IsDBNull(45)) { TextBox161.Text = ""; } else { TextBox161.Text = sqldatareader_d2.GetString(45); }//PET-CT
                    if (sqldatareader_d2.GetString(46) == "") { } else { RadioButtonList23.SelectedValue = sqldatareader_d2.GetString(46).Trim(); }
                    if (sqldatareader_d2.IsDBNull(47)) { } else { DropDownList30.SelectedValue = sqldatareader_d2.GetString(47).Trim(); }
                    if (sqldatareader_d2.IsDBNull(48)) { TextBox162.Text = ""; } else { TextBox162.Text = sqldatareader_d2.GetString(48); }
                    if (sqldatareader_d2.IsDBNull(49)) { TextBox163.Text = ""; } else { TextBox163.Text = sqldatareader_d2.GetString(49); }

                }

                str += "<br /><br />";
                str += "<div>乳腺复发转移</div>";
                str += "<div>&nbsp;&nbsp;术后复查时间：&nbsp;&nbsp;" + sqldatareader_d2.GetString(1).Trim() + "</div>";
                str += "<div>&nbsp;&nbsp;查体：胸腔：";
                if (RadioButtonList17.SelectedValue == "异常") { str += "异常&nbsp;" + TextBox140.Text + "，对侧："; } else { str += "正常，对侧："; }
                if (RadioButtonList18.SelectedValue == "异常") { str += "异常&nbsp;" + TextBox145.Text + "</div>"; } else { str += "正常</div>"; }
                str += "<div>&nbsp;&nbsp;查体：腋下：";
                if (RadioButtonList15.SelectedValue == "异常") { str += "异常&nbsp;" + TextBox142.Text + "，对侧："; } else { str += "正常，对侧："; }
                if (RadioButtonList16.SelectedValue == "异常") { str += "异常&nbsp;" + TextBox144.Text + "</div>"; } else { str += "正常</div>"; }
                str += "<div>&nbsp;&nbsp;胸片：";
                if (RadioButtonList13.SelectedValue == "异常") { str += "异常&nbsp;" + TextBox141.Text; } else { str += "正常"; }
                if (CheckBox6.Checked == true) { str += "，进一步检查：" + TextBox143.Text; } else { str += ""; }
                if (CheckBox7.Checked == true) { str += "&nbsp;复查:" + TextBox146.Text + "月</div>"; } else { str += "</div>"; }
                str += "<div>&nbsp;&nbsp;BUS：";
                if (RadioButtonList14.SelectedValue == "异常") { str += "异常&nbsp;" + TextBox147.Text; } else { str += "正常"; }
                if (CheckBox8.Checked == true) { str += "，进一步检查：" + TextBox148.Text; } else { str += ""; }
                if (CheckBox9.Checked == true) { str += "&nbsp;复查:" + TextBox149.Text + "月</div>"; } else { str += "</div>"; }
                str += "<div>&nbsp;&nbsp;肿瘤标志物：";
                if (RadioButtonList19.SelectedValue == "异常") { str += "异常&nbsp;" + TextBox150.Text; } else { str += "正常"; }
                if (CheckBox10.Checked == true) { str += "，进一步检查：" + TextBox151.Text; } else { str += ""; }
                if (CheckBox11.Checked == true) { str += "&nbsp;复查:" + TextBox152.Text + "月</div>"; } else { str += "</div>"; }
                str += "<div>&nbsp;&nbsp;CT：";
                if (RadioButtonList20.SelectedValue == "异常") { str += "异常&nbsp;" + TextBox153.Text; } else { str += "正常"; }
                if (CheckBox12.Checked == true) { str += "，进一步检查：" + TextBox154.Text; } else { str += ""; }
                if (CheckBox13.Checked == true) { str += "&nbsp;复查:" + TextBox155.Text + "月</div>"; } else { str += "</div>"; }
                str += "<div>&nbsp;&nbsp;ECT：";
                if (RadioButtonList21.SelectedValue == "异常") { str += "异常&nbsp;" + TextBox156.Text; } else { str += "正常"; }
                if (CheckBox14.Checked == true) { str += "，进一步检查：" + TextBox157.Text; } else { str += ""; }
                if (CheckBox15.Checked == true) { str += "&nbsp;复查:" + TextBox158.Text + "月</div>"; } else { str += "</div>"; }
                str += "<div>&nbsp;&nbsp;PET-CT：";
                if (RadioButtonList22.SelectedValue == "异常") { str += "异常&nbsp;" + TextBox159.Text; } else { str += "正常"; }
                if (CheckBox16.Checked == true) { str += "，进一步检查：" + TextBox160.Text; } else { str += ""; }
                if (CheckBox17.Checked == true) { str += "&nbsp;复查:" + TextBox161.Text + "月</div>"; } else { str += "</div>"; }
                str += "<div>&nbsp;&nbsp;结论：";
                if (RadioButtonList22.SelectedValue == "否") { str += DropDownList30.SelectedValue + TextBox162.Text + "</div>"; } else { str += "正常</div> "; }
                str += "<div>&nbsp;&nbsp;治疗：" + TextBox163.Text + "</div>";
                sqlcommand_d2 = null;
                sqlconn_d2.Close();
                sqlconn_d2 = null;

                //d3
                SqlConnection sqlconn_d3 = new SqlConnection(sqlconnstr);
                SqlCommand sqlcommand_d3 = new SqlCommand();
                sqlcommand_d3.Connection = sqlconn_d3;

                sqlconn_d3.Open();//attention
                sqlcommand_d3.CommandText = "select * from d诊疗异常反应 where 就诊卡号=@就诊卡号";
                sqlcommand_d3.Parameters.AddWithValue("@就诊卡号", Label500.Text);

                SqlDataReader sqldatareader_d3 = sqlcommand_d3.ExecuteReader();
                if (sqldatareader_d3.Read())
                {
                    //UCG_正常
                    if (sqldatareader_d3.GetString(0).Trim() == "正常") { RadioButton26.Checked = true; }
                    //UCG_异常
                    if (sqldatareader_d3.GetString(1).Trim() == "异常") { RadioButton27.Checked = true; }
                    //UCG_异常内容
                    if (sqldatareader_d3.IsDBNull(2)) { TextBox203.Text = ""; } else { TextBox203.Text = sqldatareader_d3.GetString(2); }
                    //UCG_结论
                    if (sqldatareader_d3.IsDBNull(3)) { TextBox204.Text = ""; } else { TextBox204.Text = sqldatareader_d3.GetString(3); }
                    //UCG_建议
                    if (sqldatareader_d3.IsDBNull(4)) { TextBox205.Text = ""; } else { TextBox205.Text = sqldatareader_d3.GetString(4); }
                    //肝肾功_正常
                    if (sqldatareader_d3.GetString(5).Trim() == "正常") { RadioButton28.Checked = true; }
                    //肝肾功_异常
                    if (sqldatareader_d3.GetString(6).Trim() == "异常") { RadioButton29.Checked = true; }
                    //肝肾功_异常内容
                    if (sqldatareader_d3.IsDBNull(7)) { TextBox206.Text = ""; } else { TextBox206.Text = sqldatareader_d3.GetString(7); }
                    //肝肾功_结论
                    if (sqldatareader_d3.IsDBNull(8)) { TextBox207.Text = ""; } else { TextBox207.Text = sqldatareader_d3.GetString(8); }
                    //肝肾功_建议
                    if (sqldatareader_d3.IsDBNull(9)) { TextBox208.Text = ""; } else { TextBox208.Text = sqldatareader_d3.GetString(9); }
                    //血糖_正常
                    if (sqldatareader_d3.GetString(10).Trim() == "正常") { RadioButton30.Checked = true; }
                    //血糖_异常
                    if (sqldatareader_d3.GetString(11).Trim() == "异常") { RadioButton31.Checked = true; }
                    //血糖_异常内容
                    if (sqldatareader_d3.IsDBNull(12)) { TextBox209.Text = ""; } else { TextBox209.Text = sqldatareader_d3.GetString(12); }
                    //血糖_结论
                    if (sqldatareader_d3.IsDBNull(13)) { TextBox210.Text = ""; } else { TextBox210.Text = sqldatareader_d3.GetString(13); }
                    //血糖_建议
                    if (sqldatareader_d3.IsDBNull(14)) { TextBox211.Text = ""; } else { TextBox211.Text = sqldatareader_d3.GetString(14); }
                    //血脂_正常
                    if (sqldatareader_d3.GetString(15).Trim() == "正常") { RadioButton32.Checked = true; }
                    //血脂_异常
                    if (sqldatareader_d3.GetString(16).Trim() == "异常") { RadioButton33.Checked = true; }
                    //血脂_异常内容
                    if (sqldatareader_d3.IsDBNull(17)) { TextBox212.Text = ""; } else { TextBox212.Text = sqldatareader_d3.GetString(17); }
                    //血脂_结论
                    if (sqldatareader_d3.IsDBNull(18)) { TextBox213.Text = ""; } else { TextBox213.Text = sqldatareader_d3.GetString(18); }
                    //血脂_建议
                    if (sqldatareader_d3.IsDBNull(19)) { TextBox214.Text = ""; } else { TextBox214.Text = sqldatareader_d3.GetString(19); }
                    //骨密度_正常
                    if (sqldatareader_d3.GetString(20).Trim() == "正常") { RadioButton34.Checked = true; }
                    //骨密度_异常
                    if (sqldatareader_d3.GetString(21).Trim() == "异常") { RadioButton35.Checked = true; }
                    //骨密度_异常内容
                    if (sqldatareader_d3.IsDBNull(22)) { TextBox215.Text = ""; } else { TextBox215.Text = sqldatareader_d3.GetString(22); }
                    //骨密度_结论
                    if (sqldatareader_d3.IsDBNull(23)) { TextBox216.Text = ""; } else { TextBox216.Text = sqldatareader_d3.GetString(23); }
                    //骨密度_建议
                    if (sqldatareader_d3.IsDBNull(24)) { TextBox217.Text = ""; } else { TextBox217.Text = sqldatareader_d3.GetString(24); }
                    //激素水平_未绝经
                    if (sqldatareader_d3.GetString(25).Trim() == "未绝经") { RadioButton36.Checked = true; }
                    //激素水平_绝经
                    if (sqldatareader_d3.GetString(26).Trim() == "绝经") { RadioButton37.Checked = true; }
                    //激素水平_更换内分泌药
                    if (sqldatareader_d3.IsDBNull(27)) { TextBox218.Text = ""; } else { TextBox218.Text = sqldatareader_d3.GetString(27); }
                }
                str += "<br />";
                str += "<div>诊疗异常反应</div>";
                str += "<div>&nbsp;&nbsp;UCG：" + sqldatareader_d3.GetString(0).Trim() + sqldatareader_d3.GetString(1).Trim();
                if (RadioButton27.Checked == true) { str += "&nbsp;" + TextBox203.Text + "，结论：" + TextBox204.Text + "，建议：" + TextBox205.Text + "</div>"; }
                else { str += "正常</div>"; }
                str += "<div>&nbsp;&nbsp;肝肾功：" + sqldatareader_d3.GetString(5).Trim() + sqldatareader_d3.GetString(6).Trim();
                if (RadioButton29.Checked == true) { str += "&nbsp;" + TextBox206.Text + "，结论：" + TextBox207.Text + "，建议：" + TextBox208.Text + "</div>"; }
                else { str += "正常</div>"; }
                str += "<div>&nbsp;&nbsp;血糖：" + sqldatareader_d3.GetString(10).Trim() + sqldatareader_d3.GetString(11).Trim();
                if (RadioButton31.Checked == true) { str += "&nbsp;" + TextBox209.Text + "，结论：" + TextBox210.Text + "，建议：" + TextBox211.Text + "</div>"; }
                else { str += "正常</div>"; }
                str += "<div>&nbsp;&nbsp;血脂：" + sqldatareader_d3.GetString(15).Trim() + sqldatareader_d3.GetString(16).Trim();
                if (RadioButton33.Checked == true) { str += "&nbsp;" + TextBox212.Text + "，结论：" + TextBox213.Text + "，建议：" + TextBox214.Text + "</div>"; }
                else { str += "正常</div>"; }
                str += "<div>&nbsp;&nbsp;骨密度：" + sqldatareader_d3.GetString(20).Trim() + sqldatareader_d3.GetString(21).Trim();
                if (RadioButton35.Checked == true) { str += "&nbsp;" + TextBox215.Text + "，结论：" + TextBox216.Text + "，建议：" + TextBox217.Text + "</div>"; }
                else { str += "正常</div>"; }
                if (RadioButton37.Checked == true) { str += "<div>&nbsp;&nbsp;激素水平：绝经</div>"; } else { str += "<div>激素水平：未绝经</div>"; }
                str += "<div>&nbsp;&nbsp;更换内分泌药：" + TextBox218.Text + "</div>";
                sqlcommand_d3 = null;
                sqlconn_d3.Close();
                sqlconn_d3 = null;


                //写入
                sw.Write(str);
                sw.Close();
                Response.Clear();
                Response.Buffer = true;
                this.EnableViewState = false;
                Response.Charset = "utf-8";
                Response.AppendHeader("Content-Disposition", "attachment;filename=" + HttpUtility.UrlEncode(fileName, System.Text.Encoding.UTF8));
                Response.ContentType = "application/octet-stream";
                Response.WriteFile(path);
                Response.Flush();
                Response.Close();
                Response.End();
            }
        }
        //导入随访问卷
        protected void Button12_Click(object sender, EventArgs e)
        {

        }
    }
}
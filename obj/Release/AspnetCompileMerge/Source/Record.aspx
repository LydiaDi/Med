<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Record.aspx.cs" Inherits="MedicalRecord.Record" EnableEventValidation="false" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="record.css" type="text/css" rel="Stylesheet" />
    <script type="text/javascript">
        var prevselitem = null;
        function selectx(row) {
            if (prevselitem != null) {
                prevselitem.style.backgroundColor = '#ffffff';
            }
            row.style.backgroundColor = 'PeachPuff';
            prevselitem = row;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container"><%--涵盖整个页面中的内容的容器--%>
        
    <%--页面顶端显示被选择的行--%>
    <div style="height:20px; margin-left:25px; margin-bottom:15px;" >
        <asp:Label ID="Label396" runat="server" Text="您选择的就诊卡号是："></asp:Label>
        <asp:Label ID="Label500" runat="server" Text=""></asp:Label>
    </div>

    <%--页面左侧部分--%>
    <div class="a"> <%--页面的左侧部分，包括表格、上边的按钮和下边的按钮--%>
            <div class="a2"><%--表格上方的三个按钮--%>
                <asp:Button ID="Button3" runat="server" Text="添加" Height="30" Width="50" OnClick="Button3_Click" />
                <asp:Button ID="Button4" runat="server" Text="编辑" Height="30" Width="50" OnClick="Button4_Click" />
                <asp:Button ID="Button5" runat="server" Text="删除" Height="30" Width="50" OnClick="Button5_Click"  />
            </div>

            <div class="a1"><%--表格--%>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="就诊卡号" PageSize="11" OnPageIndexChanging="GridView1_PageIndexChanging" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="4" OnRowCommand="GridView1_RowCommand" OnRowDataBound="GridView1_RowDataBound" Width="100%">
                <Columns>
                    <asp:TemplateField HeaderText="组名称" Visible="false">
                        <ItemTemplate>
                            <asp:Label ID="biaoqian1" runat="server" Text='<%# Bind("就诊卡号") %>' ></asp:Label>
                            <asp:LinkButton ID="a" runat="server" CommandName="b"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="姓名" SortExpression="姓名">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("姓名") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Height="25px" Text='<%# Bind("姓名") %>' Width="100px"></asp:Label>
                        </ItemTemplate>
                        <HeaderStyle BackColor="#F5F6F8" Font-Bold="False" Height="30px" />
                        <ItemStyle Height="19px" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="就诊卡号" SortExpression="就诊卡号">
                        <EditItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("就诊卡号") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Height="25px" Text='<%# Bind("就诊卡号") %>' Width="100px"></asp:Label>
                        </ItemTemplate>
                        <HeaderStyle BackColor="#F5F6F8" Font-Bold="False" />
                        <ItemStyle Font-Bold="False" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="住院号" SortExpression="住院号">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("住院号") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Height="25px" Text='<%# Bind("住院号") %>' Width="100px"></asp:Label>
                        </ItemTemplate>
                        <HeaderStyle BackColor="#F5F6F8" Font-Bold="False" />
                    </asp:TemplateField>
                </Columns>
                    <RowStyle HorizontalAlign="Center" />
                </asp:GridView>
            </div>

            <div class="btn2"><%--表格下面的按钮--%>
                <asp:Button ID="Button6" runat="server" Text="生成病历" Height="30px" Width="90px" OnClick="Button6_Click"  />
            </div>

            <asp:Label ID="Label45" runat="server"></asp:Label>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:pinforConnectionString %>" SelectCommand="SELECT [就诊卡号], [姓名], [住院号] FROM [patientInfo]"></asp:SqlDataSource>
        </div>

    <%--包含整个页面右面内容的Panel容器--%>
    <asp:Panel ID="Panel89" runat="server" Enabled="False" >

    <%--一级菜单--%><%--包含整个页面右面内容的div容器--%>
    <div class="Menu2">
    <asp:Menu ID="Menu2" runat="server" OnMenuItemClick="Menu2_MenuItemClick" Orientation="Horizontal" ForeColor="#ff6699"  >
        
        <Items>
            <asp:MenuItem Text="基线采集" Value="基线采集"></asp:MenuItem>
            <asp:MenuItem Text="前哨淋巴结" Value="前哨淋巴结"></asp:MenuItem>
            <asp:MenuItem Text="化疗" Value="化疗"></asp:MenuItem>
            <asp:MenuItem Text="随访" Value="随访"></asp:MenuItem>
            <asp:MenuItem Text="根治术" Value="根治术"></asp:MenuItem>
            <asp:MenuItem Text="保乳术" Value="保乳术"></asp:MenuItem>
        </Items>
        <LevelMenuItemStyles>
            <asp:MenuItemStyle  Font-Underline="False" Font-Size="Larger"  CssClass="item" Width="110px" BorderStyle="Solid" ItemSpacing="10px" VerticalPadding="5" />
        </LevelMenuItemStyles>
        <LevelSelectedStyles>
            <%--关于下一行中出现的CssClass="title"的解释：用于对导航栏中的样式进行统一设计，每一个导航栏中均写有此代码，只是目前在css样式表中的此“title”样式中并没有填充任何内容--%>
            <asp:MenuItemStyle BackColor="#fff4f4" Font-Underline="False" CssClass="title"  BorderColor="#999999" BorderWidth="1px" BorderStyle="Solid"/>
        </LevelSelectedStyles>
    </asp:Menu>

    <%--除了第一层导航，包含页面右面内容的div容器--%>
    <%--<div style="height: 747px; width: 815px;">--%>
        <div style="height: 747px; width: 100%;">
    <%--除了第一层导航，包含页面右面内容的panel容器--%>
    <asp:Panel ID="Panel69" runat="server" BorderColor="#999999" BorderStyle="Solid" Width="100%" Height="100%" BorderWidth="1px">
    <asp:MultiView ID="MultiView2" runat="server" ActiveViewIndex="0">

    <%--二级菜单a--%>
    <asp:View ID="View3" runat="server">
    <%--包含整个二级菜单a页面的div容器--%>
    <%--<div class="b">--%>
        <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" OnMenuItemClick="Menu1_MenuItemClick"  BackColor="#fff4f4" >
                
                <Items>
                    <asp:MenuItem Text="入院概要 " Value="1" Selected="True"></asp:MenuItem>
                    <asp:MenuItem Text="主诉 " Value="2"></asp:MenuItem>
                    <asp:MenuItem Text="现病史 " Value="3"></asp:MenuItem>
                    <asp:MenuItem Text="身体状况 " Value="4"></asp:MenuItem>
                    <asp:MenuItem Text="个人情况 " Value="5"></asp:MenuItem>
                    <asp:MenuItem Text="专科查体 " Value="6"></asp:MenuItem>
                    <asp:MenuItem Text="其他" Value="7"></asp:MenuItem>
                </Items>
                
                <LevelMenuItemStyles>
                    <asp:MenuItemStyle Font-Underline="False"  ForeColor="#cc0066"  CssClass="item2" />
                </LevelMenuItemStyles>
                <LevelSelectedStyles>
                    <asp:MenuItemStyle BackColor="White" Font-Underline="False" CssClass="title" ForeColor="Black" BorderStyle="Solid" BorderColor="#ff99ff" BorderWidth="1px" Font-Size="Large" />
                </LevelSelectedStyles>
                
            </asp:Menu>
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">

        <%--a1--%>
        <asp:View ID="View1" runat="server">
                <div class="e"><%--包含整个a1页面的div容器--%>
                <%--<asp:Panel ID="Panel70" runat="server" GroupingText="入院概要" Font-Size="Small" Width="800px">--%>
                    <asp:Panel ID="Panel70" runat="server" GroupingText="入院概要" Font-Size="Medium" >
                    <div class="c"><%--包含a1页面左半部分的div容器--%>
                    <asp:Label ID="Label1" runat="server" Text="姓名：" Height="20px" Width="80px" ></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="150px"></asp:TextBox>
                        <%--汉字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox1" ValidationExpression="^[\u4e00-\u9fa5]+$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                    <br />
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="就诊卡号：" BorderColor="White" Height="20px" Width="80px" ></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server" Height="20px" Width="150px" MaxLength="8"></asp:TextBox>
                        <%--字母和数字^[A-Za-z0-9]+$--%>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox2" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                    <br /><br />
                    <asp:Label ID="Label3" runat="server" Text="性别：" Height="20px" Width="80px"></asp:Label>
                    <asp:TextBox ID="TextBox3" runat="server" Height="20px" Width="150px"></asp:TextBox>
                        <%--只能填男女--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox3" ValidationExpression="^([男|女]){1}$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                    <br /><br />
                    <asp:Label ID="Label4" runat="server" Text="年龄：" Height="20px" Width="80px"></asp:Label>
                    <asp:TextBox ID="TextBox4" runat="server" Height="20px" Width="150px" MaxLength="3"></asp:TextBox>
                        <%--一到三位数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox4" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                    <br /><br />
                    <asp:Label ID="Label5" runat="server" Text="婚姻：" Height="20px" Width="80px"></asp:Label>
                    <asp:TextBox ID="TextBox5" runat="server" Height="20px" Width="150px"></asp:TextBox>
                        <%--汉字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox5" ValidationExpression="^[\u4e00-\u9fa5]+$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                    <br /><br />
                    <asp:Label ID="Label6" runat="server" Text="籍贯：" Height="20px" Width="80px"></asp:Label>
                    <asp:TextBox ID="TextBox6" runat="server" Height="20px" Width="150px"></asp:TextBox>
                        <%--汉字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox6" ValidationExpression="^[\u4e00-\u9fa5]+$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                    <br /><br />
                    <asp:Label ID="Label7" runat="server" Text="民族：" Height="20px" Width="80px"></asp:Label>
                    <asp:TextBox ID="TextBox7" runat="server" Height="20px" Width="150px"></asp:TextBox>
                        <%--汉字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox7" ValidationExpression="^[\u4e00-\u9fa5]+$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                    <br /><br />
                    <asp:Label ID="Label8" runat="server" Text="职业：" Height="30px" Width="80px"></asp:Label>
                    <asp:TextBox ID="TextBox8" runat="server" Height="20px" Width="150px"></asp:TextBox>
                        <%--汉字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox8" ValidationExpression="^[\u4e00-\u9fa5]+$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                    <br /><br />
                    </div>
                    
                    <div class="d"><%--包含a1页面右半部分的div容器--%>
                    <asp:Label ID="Label9" runat="server" Text="工作单位：" Height="20px" Width="96px" ></asp:Label>
                    <asp:TextBox ID="TextBox9" runat="server" Height="20px" Width="200px"></asp:TextBox><br /><br />

                    <asp:Label ID="Label10" runat="server" Text="住院号：" Height="20px" Width="96px" ></asp:Label>
                    <asp:TextBox ID="TextBox10" runat="server" Height="20px" Width="200px" MaxLength="8"></asp:TextBox>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox10" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                    <br /><br />

                    <asp:Label ID="Label11" runat="server" Text="现住址：" Height="20px" Width="96px"></asp:Label>
                    <asp:TextBox ID="TextBox11" runat="server" Height="20px" Width="200px"></asp:TextBox><br /><br />

                    <asp:Label ID="Label12" runat="server" Text="入院日期：" Height="20px" Width="96px"></asp:Label>
                    
                    <%--日历修正--%>
                    <asp:TextBox ID="TextBox12" runat="server" Height="20px" Width="60px"></asp:TextBox>

                    <asp:Image ID="Image1" runat="server" Width="20px" Height="20px" ImageUrl="images_logo/Calendar_logo.png" />
                    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                    
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="TextBox12" PopupButtonID="Image1" Format="yyyy-MM-dd" FirstDayOfWeek="Monday"/>
                    <asp:TextBox ID="TextBox12a" runat="server" Height="20px" Width="26px"></asp:TextBox>
                    

                        <asp:Label ID="Label12a" runat="server" Text=":"></asp:Label>
                    <asp:TextBox ID="TextBox12b" runat="server" Height="20px" Width="26px"></asp:TextBox>
                        <asp:Label ID="Label12b" runat="server" Text=":"></asp:Label>
                    <asp:TextBox ID="TextBox12c" runat="server" Height="20px" Width="25px"></asp:TextBox>
                    <br />
                        <br />

                    <asp:Label ID="Label13" runat="server" Text="记录日期：" Height="20px" Width="96px"></asp:Label>
                    <%--日历修正--%>
                    <asp:TextBox ID="TextBox13" runat="server" Height="20px" Width="60px"></asp:TextBox>
                    <asp:Image ID="Image2" runat="server" Width="20px" Height="20px" ImageUrl="images_logo/Calendar_logo.png" />
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="TextBox13" PopupButtonID="Image2" Format="yyyy-MM-dd" FirstDayOfWeek="Monday"/>

                    <asp:TextBox ID="TextBox13a" runat="server" Height="20px" Width="26px"></asp:TextBox>
                        <asp:Label ID="Label13a" runat="server" Text=":"></asp:Label>
                    <asp:TextBox ID="TextBox13b" runat="server" Height="20px" Width="26px"></asp:TextBox>
                        <asp:Label ID="Label13b" runat="server" Text=":"></asp:Label>
                    <asp:TextBox ID="TextBox13c" runat="server" Height="20px" Width="25px"></asp:TextBox>
                    <br /><br />
                    <%--实现时分秒的读入--%>
                    <%--<asp:Timer ID="Timer2" runat="server" Interval="600000" OnTick="Timer2_Tick" ></asp:Timer>--%>

                    <asp:Label ID="Label14" runat="server" Text="病逝陈述者：" Height="20px" Width="96px"></asp:Label>
                    <asp:TextBox ID="TextBox14" runat="server" Height="20px" Width="200px"></asp:TextBox>
                        <%--汉字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox14" ValidationExpression="^[\u4e00-\u9fa5]+$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                    <br /><br />

                    <asp:Label ID="Label15" runat="server" Text="与患者关系：" Height="20px" Width="96px"></asp:Label>
                    <asp:TextBox ID="TextBox15" runat="server" Height="20px" Width="200px"></asp:TextBox>
                        <%--汉字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator11" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox15" ValidationExpression="^[\u4e00-\u9fa5]+$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                    <br /><br />

                    <asp:Label ID="Label16" runat="server" Text="联系电话：" Height="20px" Width="96px"></asp:Label>
                    <asp:TextBox ID="TextBox16" runat="server" Height="20px" Width="200px" MaxLength="11"></asp:TextBox>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator12" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox16" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                    <br /><br />
                    </div>
                </asp:Panel>
                </div>
                </asp:View>

        <%--a2--%>
        <asp:View ID="View24" runat="server">
                <div class="e">
                     <asp:Panel ID="Panel49" runat="server" GroupingText="主要症状" Font-Size="Medium"> 
                         <br />
                         &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label262" runat="server" Text="侧别："></asp:Label>
                         <asp:DropDownList ID="DropDownList31" runat="server" Height="20px" BackColor="#E6E6E6">
                             <asp:ListItem Selected="True">左侧</asp:ListItem>
                             <asp:ListItem>右侧</asp:ListItem>
                         </asp:DropDownList>

                         &nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:Label ID="Label263" runat="server" Text="位置："></asp:Label>
                         <asp:DropDownList ID="DropDownList32" runat="server" Height="20px" BackColor="#E6E6E6">
                             <asp:ListItem Selected="True">乳腺</asp:ListItem>
                             <asp:ListItem>腋窝</asp:ListItem>
                         </asp:DropDownList>
                        <br /><br />
                         &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label264" runat="server" Text="症状："></asp:Label>
                         <asp:CheckBox ID="CheckBox33" runat="server" Text="肿物" ValidationGroup="zz1" />
                         <asp:CheckBox ID="CheckBox34" runat="server" Text="溢液" ValidationGroup="zz1" />
                         <asp:CheckBox ID="CheckBox35" runat="server" Text="疼痛" ValidationGroup="zz1" />
                         <asp:CheckBox ID="CheckBox36" runat="server" Text="湿疹" ValidationGroup="zz1" />
                         <asp:CheckBox ID="CheckBox37" runat="server" Text="凹陷" ValidationGroup="zz1" />
                         <asp:CheckBox ID="CheckBox38" runat="server" Text="水肿" ValidationGroup="zz1" />
                         <asp:CheckBox ID="CheckBox39" runat="server" Text="卫星结节" ValidationGroup="zz1" />
                         <asp:CheckBox ID="CheckBox40" runat="server" Text="破溃" ValidationGroup="zz1" />

                         &nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:Label ID="Label265" runat="server" Text="时间：" ></asp:Label>
                         <asp:TextBox ID="TextBox239" runat="server" Height="20px" Width="50px"></asp:TextBox><asp:DropDownList ID="DropDownList33" runat="server" Height="20px" BackColor="#E6E6E6">
                             <asp:ListItem>年</asp:ListItem>
                             <asp:ListItem>月</asp:ListItem>
                             <asp:ListItem Selected="True">日</asp:ListItem>
                         </asp:DropDownList>
                         <%--数字--%>
                         <asp:RegularExpressionValidator ID="RegularExpressionValidator13" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox239" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                         <br /><br />
                    </asp:Panel>

                         <div class="jiange"></div><%--用来实现间隔效果--%>

                         <asp:Panel ID="Panel50" runat="server" GroupingText="伴随" Font-Size="Medium" >
                             <br />
                             &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label266" runat="server" Text="侧别："></asp:Label>
                         <asp:DropDownList ID="DropDownList34" runat="server" Height="20px" BackColor="#E6E6E6">
                             <asp:ListItem Selected="True">左侧</asp:ListItem>
                             <asp:ListItem>右侧</asp:ListItem>
                         </asp:DropDownList>

                         &nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:Label ID="Label267" runat="server" Text="位置："></asp:Label>
                         <asp:DropDownList ID="DropDownList35" runat="server" Height="20px" BackColor="#E6E6E6">
                             <asp:ListItem Selected="True">乳腺</asp:ListItem>
                             <asp:ListItem>腋窝</asp:ListItem>
                         </asp:DropDownList>
                         <br /><br />
                         &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label268" runat="server" Text="症状："></asp:Label>
                         <asp:CheckBox ID="CheckBox41" runat="server" Text="肿物" ValidationGroup="zz2" />
                         <asp:CheckBox ID="CheckBox42" runat="server" Text="溢液" ValidationGroup="zz2" />
                         <asp:CheckBox ID="CheckBox43" runat="server" Text="疼痛" ValidationGroup="zz2" />
                         <asp:CheckBox ID="CheckBox44" runat="server" Text="湿疹" ValidationGroup="zz2" />
                         <asp:CheckBox ID="CheckBox45" runat="server" Text="凹陷" ValidationGroup="zz2" />
                         <asp:CheckBox ID="CheckBox46" runat="server" Text="水肿" ValidationGroup="zz2" />
                         <asp:CheckBox ID="CheckBox47" runat="server" Text="卫星结节" ValidationGroup="zz2" />
                         <asp:CheckBox ID="CheckBox48" runat="server" Text="破溃" ValidationGroup="zz2" />

                         &nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:Label ID="Label269" runat="server" Text="时间："></asp:Label>
                         <asp:TextBox ID="TextBox240" runat="server" Height="20px" Width="50px"></asp:TextBox><asp:DropDownList ID="DropDownList36" runat="server" Height="20px" BackColor="#E6E6E6">
                             <asp:ListItem>年</asp:ListItem>
                             <asp:ListItem>月</asp:ListItem>
                             <asp:ListItem Selected="True">日</asp:ListItem>
                         </asp:DropDownList>
                         <%--数字--%>
                             <asp:RegularExpressionValidator ID="RegularExpressionValidator14" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox240" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                             <br /><br />
                         </asp:Panel>

                          <div class="jiange"></div>

                         <asp:Panel ID="Panel51" runat="server" GroupingText="发展" Font-Size="Medium" >
                             <br />
                             &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label270" runat="server" Text="增大："></asp:Label>
                             <asp:TextBox ID="TextBox241" runat="server" Height="20px" Width="50px"></asp:TextBox><asp:DropDownList ID="DropDownList37" runat="server" Height="20px" BackColor="#E6E6E6">
                                 <asp:ListItem>年</asp:ListItem>
                                 <asp:ListItem>月</asp:ListItem>
                                 <asp:ListItem Selected="True">日</asp:ListItem>
                             </asp:DropDownList>
                             <%--数字--%>
                             <asp:RegularExpressionValidator ID="RegularExpressionValidator15" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox241" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>

                              &nbsp;&nbsp;&nbsp;&nbsp;
                             <asp:Label ID="Label271" runat="server" Text="转为血性："></asp:Label>
                             <asp:TextBox ID="TextBox242" runat="server" Height="20px" Width="50px"></asp:TextBox><asp:DropDownList ID="DropDownList38" runat="server" Height="20px" BackColor="#E6E6E6">
                                 <asp:ListItem>年</asp:ListItem>
                                 <asp:ListItem>月</asp:ListItem>
                                 <asp:ListItem Selected="True">日</asp:ListItem>
                             </asp:DropDownList>
                             <%--数字--%>
                             <asp:RegularExpressionValidator ID="RegularExpressionValidator16" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox242" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                             <br /><br />
                         </asp:Panel>
                     </div>
                </asp:View>

        <%--a3--%>
        <asp:View ID="View25" runat="server">
                <div class="e"><%--引用之前包含整个a1页面的div容器，实现相同的效果--%>
                    <asp:Panel ID="Panel52" runat="server" GroupingText="一般" Font-Size="Medium" >
                        <br />
                        <table>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                                    </td>
                                <td>
                                    <asp:Label ID="Label17" runat="server" Text="于入院前"></asp:Label>
                                    </td>
                                <td>
                        <asp:TextBox ID="TextBox243" runat="server" Height="20px" Width="70px"></asp:TextBox><asp:DropDownList ID="DropDownList39" runat="server" Height="20px" BackColor="#E6E6E6">
                            <asp:ListItem Selected="True">天</asp:ListItem>
                            <asp:ListItem>月</asp:ListItem>
                            <asp:ListItem>年</asp:ListItem>
                        </asp:DropDownList>
                                    </td>
                                <td>
                        <asp:DropDownList ID="DropDownList40" runat="server" Height="20px" BackColor="#E6E6E6">
                            <asp:ListItem Selected="True">无意间</asp:ListItem>
                            <asp:ListItem>经由体检</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Label ID="Label18" runat="server" Text="发现。"></asp:Label>
                                    </td>
                        </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                                    </td>
                                <td></td>
                                <td>
                       <%-- 数字--%>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator17" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox243" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td></td>
                                    </tr>
                        </table>
                        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label272" runat="server" Text="诱因："></asp:Label>
                        <asp:DropDownList ID="DropDownList41" runat="server" Height="20px" BackColor="#E6E6E6" OnSelectedIndexChanged="DropDownList41_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem Selected="True">无</asp:ListItem>
                            <asp:ListItem>有</asp:ListItem>
                        </asp:DropDownList>

                        <asp:TextBox ID="TextBox244" runat="server" Height="20px" Width="80px" Visible="False"></asp:TextBox>
                        <asp:Label ID="Label273" runat="server" Text="病因："></asp:Label>
                        <asp:DropDownList ID="DropDownList42" runat="server" Height="20px" BackColor="#E6E6E6" OnSelectedIndexChanged="DropDownList42_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem Selected="True">无</asp:ListItem>
                            <asp:ListItem>有</asp:ListItem>
                        </asp:DropDownList>
                        <asp:TextBox ID="TextBox245" runat="server" Height="20px" Width="80px" Visible="False"></asp:TextBox>
                        <br /><br />
                    </asp:Panel>

                         <div class="jiange"></div>

                    <asp:Panel ID="Panel53" runat="server" GroupingText="病症描述" Font-Size="Medium" >
                        <br />
                        <table>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                                    </td>
                                <td><asp:Label ID="Label274" runat="server" Text="肿瘤大小(cm)："></asp:Label>
                                    </td>
                                <td>
                        <asp:TextBox ID="TextBox283" runat="server" Height="20px" Width="40px"></asp:TextBox>
                                    </td>
                                <td>
                        <asp:Label ID="Label275" runat="server" Text="*"></asp:Label>
                                    </td>
                                <td>
                        <asp:TextBox ID="TextBox284" runat="server" Height="20px" Width="40px"></asp:TextBox>
                                    </td>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label276" runat="server" Text="压痛："></asp:Label>
                        <asp:DropDownList ID="DropDownList43" runat="server"  Height="20px" BackColor="#E6E6E6">
                            <asp:ListItem Selected="True">伴有</asp:ListItem>
                            <asp:ListItem>无</asp:ListItem>
                        </asp:DropDownList>
                                    </td>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label277" runat="server" Text="乳头溢液："></asp:Label>
                        <asp:DropDownList ID="DropDownList44" runat="server"  Height="20px" BackColor="#E6E6E6">
                            <asp:ListItem Selected="True">伴有</asp:ListItem>
                            <asp:ListItem>无</asp:ListItem>
                        </asp:DropDownList>
                                    </td>
                        </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                                    </td>
                                <td></td>
                                <td>
                            <%--保留一位小数--%>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator18" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox283" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td></td>
                                <td>
                                    &nbsp;
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator19" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox284" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                            </td>
                                <td></td>
                                <td></td>
                                    </tr>
                        </table>
                        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label278" runat="server" Text="溢液数量："></asp:Label>
                        <asp:DropDownList ID="DropDownList45" runat="server" Height="20px" BackColor="#E6E6E6">
                            <asp:ListItem Selected="True">单孔</asp:ListItem>
                            <asp:ListItem>多孔</asp:ListItem>
                        </asp:DropDownList>

                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label279" runat="server" Text="溢液动能："></asp:Label>
                        <asp:DropDownList ID="DropDownList46" runat="server" Height="20px" BackColor="#E6E6E6">
                            <asp:ListItem Selected="True">主动</asp:ListItem>
                            <asp:ListItem>被动</asp:ListItem>
                        </asp:DropDownList>

                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label280" runat="server" Text="溢液性状："></asp:Label>
                        <asp:DropDownList ID="DropDownList47" runat="server" Height="20px" BackColor="#E6E6E6">
                            <asp:ListItem Selected="True">清亮</asp:ListItem>
                            <asp:ListItem>淡黄色浆液性</asp:ListItem>
                            <asp:ListItem>咖啡色陈旧血性</asp:ListItem>
                            <asp:ListItem>血性</asp:ListItem>
                        </asp:DropDownList>
                        <br /><br />
                    </asp:Panel>

                         <div class="jiange"></div>

                    <asp:Panel ID="Panel54" runat="server" GroupingText="诊疗过程" Font-Size="Medium" >
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label281" runat="server" Text="有无就诊经历："></asp:Label>
                        <asp:DropDownList ID="DropDownList48" runat="server" Height="20px" BackColor="#E6E6E6" OnSelectedIndexChanged="DropDownList48_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem Selected="True">自发病以来未进行任何治疗</asp:ListItem>
                            <asp:ListItem>有</asp:ListItem>
                        </asp:DropDownList>
                        <br /><br />

                        <asp:Panel ID="Panel78" runat="server" Visible="False">
                         &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label282" runat="server" Text="于何处就诊"></asp:Label>
                        <asp:TextBox ID="TextBox285" runat="server" Height="20px"></asp:TextBox>
                        <asp:Label ID="Label283" runat="server" Text="诊疗过程"></asp:Label>
                        <asp:TextBox ID="TextBox286" runat="server" Height="20px"></asp:TextBox>
                            <br /><br />
                             &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label395" runat="server" Text="诊疗疗效"></asp:Label>
                        <asp:DropDownList ID="DropDownList96" runat="server" AutoPostBack="True" Height="20px" BackColor="#E6E6E6">
                            <asp:ListItem>症状较前缓解</asp:ListItem>
                            <asp:ListItem>症状较前无变化</asp:ListItem>
                            <asp:ListItem>症状较前加重</asp:ListItem>
                        </asp:DropDownList><br /><br />
                        </asp:Panel>

                        
                        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label284" runat="server" Text="诊疗转归："></asp:Label>
                        <asp:DropDownList ID="DropDownList49" runat="server" Height="20px" BackColor="#E6E6E6">
                            <asp:ListItem Selected="True">自觉</asp:ListItem>
                            <asp:ListItem>复查</asp:ListItem>
                        </asp:DropDownList>
                        <asp:DropDownList ID="DropDownList50" runat="server" Height="20px" BackColor="#E6E6E6">
                            <asp:ListItem Selected="True">肿瘤较前增大</asp:ListItem>
                            <asp:ListItem>溢液较前加重</asp:ListItem>
                        </asp:DropDownList>
                        <br /><br />
                        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label285" runat="server" Text="为求进一步治疗来我院就诊"></asp:Label>
                        <br /><br />
                    </asp:Panel>
                    </div>
                </asp:View>

        <%--a4--%>
        <asp:View ID="View2" runat="server">
                <div class="e">
                    <asp:Panel ID="Panel71" runat="server" GroupingText="一般"  Font-Size="Medium">

                    <div class="e">
                    <asp:Label ID="Label19" runat="server" Text="自患者入院以来"></asp:Label><br /><br />

                    <asp:Label ID="Label20" runat="server" Text="一般状况：" Height="20px" Width="80px"></asp:Label>
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="20px" Width="80px" BackColor="#E6E6E6">
                        <asp:ListItem>较差</asp:ListItem>
                        <asp:ListItem>正常</asp:ListItem>
                    </asp:DropDownList>

                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label21" runat="server" Text="精神：" Height="20px" Width="80px"></asp:Label>
                    <asp:DropDownList ID="DropDownList2" runat="server" Height="20px" Width="80px" BackColor="#E6E6E6">
                        <asp:ListItem>较差</asp:ListItem>
                        <asp:ListItem>正常</asp:ListItem>
                    </asp:DropDownList>

                     &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label22" runat="server" Text="食睡：" Height="20px" Width="80px"></asp:Label>
                    <asp:DropDownList ID="DropDownList3" runat="server" Height="20px" Width="80px" BackColor="#E6E6E6">
                        <asp:ListItem>较差</asp:ListItem>
                        <asp:ListItem>正常</asp:ListItem>
                    </asp:DropDownList>
                    <br /><br />
                    <asp:Label ID="Label23" runat="server" Text="二便：" Height="20px" Width="80px"></asp:Label>
                    <asp:DropDownList ID="DropDownList4" runat="server" Height="20px" Width="80px" BackColor="#E6E6E6">
                        <asp:ListItem>较差</asp:ListItem>
                        <asp:ListItem>正常</asp:ListItem>
                    </asp:DropDownList>

                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label24" runat="server" Text="体重：" Height="20px" Width="80px"></asp:Label>
                    <asp:DropDownList ID="DropDownList5" runat="server" Height="20px" Width="80px" BackColor="#E6E6E6">
                        <asp:ListItem>较差</asp:ListItem>
                        <asp:ListItem>正常</asp:ListItem>
                    </asp:DropDownList>

                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label25" runat="server" Text="体力:" Height="20px" Width="80px"></asp:Label>
                    <asp:DropDownList ID="DropDownList6" runat="server" Height="20px" Width="80px" BackColor="#E6E6E6">
                        <asp:ListItem>较差</asp:ListItem>
                        <asp:ListItem>正常</asp:ListItem>
                    </asp:DropDownList>
                    </div>
                    </asp:Panel>

                    <asp:Panel ID="Panel72" runat="server" GroupingText="既往史" Font-Size="Medium" >
                    <br />

                     &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label26" runat="server" Text="既往体健：" Height="20px" Width="80px"></asp:Label>
                    <asp:DropDownList ID="DropDownList7" runat="server" Height="20px" Width="80px" BackColor="#E6E6E6" AutoPostBack="True" OnSelectedIndexChanged="DropDownList7_SelectedIndexChanged">
                        <asp:ListItem>是</asp:ListItem>
                        <asp:ListItem>否</asp:ListItem>
                    </asp:DropDownList>

                    <asp:Panel ID="Panel1" runat="server" Visible="False"><br />
                         &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label27" runat="server" Text="疾病史："></asp:Label>
                        <asp:Label ID="Label28" runat="server" Text="冠心病：" Height="20px" Width="70px" ></asp:Label>
                        <asp:TextBox ID="TextBox17" runat="server" Height="20px" Width="40px"></asp:TextBox>
                        <asp:Label ID="Label29" runat="server" Text="年"></asp:Label>
                        <%--纯数字--%><br />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator20" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox17" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                        <br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label30" runat="server" Text="糖尿病：" Height="20px" Width="72px" ></asp:Label>
                        <asp:TextBox ID="TextBox18" runat="server" Height="20px" Width="40px"></asp:TextBox>
                        <asp:Label ID="Label31" runat="server" Text="年"></asp:Label>
                        <%--纯数字--%><br />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator21" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox18" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                        <br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label32" runat="server" Text="高血压：" Height="20px" Width="72px" ></asp:Label>
                        <asp:TextBox ID="TextBox19" runat="server" Height="20px" Width="40px"></asp:TextBox>
                        <asp:Label ID="Label33" runat="server" Text="年"></asp:Label>
                        <%--纯数字--%><br />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator22" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox19" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                        <br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label34" runat="server" Text="甲亢病：" Height="20px" Width="72px" ></asp:Label>
                        <asp:TextBox ID="TextBox20" runat="server" Height="20px" Width="40px"></asp:TextBox>
                        <asp:Label ID="Label35" runat="server" Text="年"></asp:Label>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator23" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox20" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>

                    </asp:Panel>
                        <br /><br />
                    <asp:Panel ID="Panel2" runat="server">
                         &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label36" runat="server" Text="手术史：" Height="20px" Width="80px"></asp:Label>
                        <asp:DropDownList ID="DropDownList8" runat="server" Height="20px" Width="80px" BackColor="#E6E6E6" AutoPostBack="True" OnSelectedIndexChanged="DropDownList8_SelectedIndexChanged">
                        <asp:ListItem>无</asp:ListItem>
                        <asp:ListItem>有</asp:ListItem>
                        </asp:DropDownList>

                        <div class="inline"><%--为了实现此div容器中的内容可以在一行中显示--%>
                        <asp:Panel ID="Panel3" runat="server" Visible="False">
                            <asp:Label ID="Label40" runat="server" Text="时间：" Height="20px" Width="48px" ></asp:Label>
                            <asp:TextBox ID="TextBox21" runat="server" Height="20px" Width="70px"></asp:TextBox>

                            <asp:Label ID="Label41" runat="server" Text="于何处：" Height="20px" Width="65px" ></asp:Label>
                            <asp:TextBox ID="TextBox22" runat="server" Height="20px" Width="70px"></asp:TextBox>

                            <asp:Label ID="Label42" runat="server" Text="进行何种手术：" Height="20px" Width="120px" ></asp:Label>
                            <asp:TextBox ID="TextBox23" runat="server" Height="20px" Width="70px"></asp:TextBox>
                        </asp:Panel>
                        </div>

                        <br /><br />
                         &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label37" runat="server" Text="外伤史：" Height="20px" Width="80px"></asp:Label>
                        <asp:DropDownList ID="DropDownList9" runat="server" Height="20px" Width="80px" BackColor="#E6E6E6" OnSelectedIndexChanged="DropDownList9_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem>无</asp:ListItem>
                        <asp:ListItem>有</asp:ListItem>
                        </asp:DropDownList>

                        <div class="inline"><%--为了实现此div容器中的内容可以在一行中显示--%>
                        <asp:Panel ID="Panel73" runat="server" Visible="False">
                            <asp:Label ID="Label376" runat="server" Text="时间：" Height="20px" Width="48px" ></asp:Label>
                            <asp:TextBox ID="TextBox302" runat="server" Height="20px" Width="70px"></asp:TextBox>

                            <asp:Label ID="Label377" runat="server" Text="于何处：" Height="20px" Width="65px" ></asp:Label>
                            <asp:TextBox ID="TextBox303" runat="server" Height="20px" Width="70px"></asp:TextBox>

                            <asp:Label ID="Label378" runat="server" Text="受过何种外伤：" Height="20px" Width="120px" ></asp:Label>
                            <asp:TextBox ID="TextBox304" runat="server" Height="20px" Width="70px"></asp:TextBox>
                        </asp:Panel>
                        </div>

                        <br /><br />
                         &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label38" runat="server" Text="输血史：" Height="20px" Width="80px"></asp:Label>
                        <asp:DropDownList ID="DropDownList10" runat="server" Height="20px" Width="80px" BackColor="#E6E6E6" OnSelectedIndexChanged="DropDownList10_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem>无</asp:ListItem>
                        <asp:ListItem>有</asp:ListItem>
                        </asp:DropDownList>

                        <div class="inline"><%--为了实现此div容器中的内容可以在一行中显示--%>
                        <asp:Panel ID="Panel74" runat="server" Visible="False">
                            <asp:Label ID="Label379" runat="server" Text="时间：" Height="20px" Width="48px" ></asp:Label>
                            <asp:TextBox ID="TextBox305" runat="server" Height="20px" Width="70px"></asp:TextBox>

                            <asp:Label ID="Label380" runat="server" Text="于何处：" Height="20px" Width="65px" ></asp:Label>
                            <asp:TextBox ID="TextBox306" runat="server" Height="20px" Width="70px"></asp:TextBox>

                            <asp:Label ID="Label381" runat="server" Text="因何输血：" Height="20px" Width="120px" ></asp:Label>
                            <asp:TextBox ID="TextBox307" runat="server" Height="20px" Width="70px"></asp:TextBox>
                        </asp:Panel>
                        </div>

                        <br /><br />
                        <table>
                            <tr>
                                <td rowspan="2">
                                    &nbsp;&nbsp;&nbsp;&nbsp;
                                </td>
                                <td rowspan="2">
                                     <asp:Label ID="Label39" runat="server" Text="过敏史：" Height="20px" Width="80px"></asp:Label>
                                </td>
                                <td rowspan="2">
                                    <asp:DropDownList ID="DropDownList11" runat="server" Height="20px" Width="80px" BackColor="#E6E6E6" AutoPostBack="True" OnSelectedIndexChanged="DropDownList11_SelectedIndexChanged">
                        <asp:ListItem>无</asp:ListItem>
                        <asp:ListItem>有</asp:ListItem>
                        </asp:DropDownList>
                                </td>
                            </tr>
                        </table>
                                            <br />  
                        <div class="inline"><%--为了实现此div容器中的内容可以在一行中显示--%>
                        <asp:Panel ID="Panel75" runat="server" Visible="False">
                            <table>
                                <tr>
                                    <td rowspan="2">
                                        &nbsp;&nbsp;&nbsp;&nbsp;
                                    </td>
                                    <td>
                                        <asp:Label ID="Label382" runat="server" Text="食物"></asp:Label>
                                        </td>
                                    <td>
                                        <asp:DropDownList ID="DropDownList97" runat="server" Height="20px" Width="80px" BackColor="#E6E6E6" AutoPostBack="True" OnSelectedIndexChanged="DropDownList97_SelectedIndexChanged">
                                <asp:ListItem>无</asp:ListItem>
                                <asp:ListItem>有</asp:ListItem>
                            </asp:DropDownList>
                                    </td>
                                </tr>
                            </table>
                            <div class="inline"><%--为了实现此div容器中的内容可以在一行中显示--%>
                            <asp:Panel ID="Panel76" runat="server" Visible="False">
                                <table>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label384" runat="server" Text="&nbsp;&nbsp;&nbsp;&nbsp;【详情】:" Height="20px" Width="120px" ></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox308" runat="server" Height="20px" Width="70px"></asp:TextBox>
                                    </td>
                                </tr>                               
                            </table>                            
                            </asp:Panel>
                            </div>
                            <br />
                            <table>
                                <tr>
                                    <td rowspan="2">
                                        &nbsp;&nbsp;&nbsp;&nbsp;
                                    </td>
                                    <td>
                                        <asp:Label ID="Label383" runat="server" Text="药物"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="DropDownList98" runat="server" Height="20px" Width="80px" BackColor="#E6E6E6" AutoPostBack="True" OnSelectedIndexChanged="DropDownList98_SelectedIndexChanged">
                                <asp:ListItem>无</asp:ListItem>
                                <asp:ListItem>有</asp:ListItem>
                            </asp:DropDownList>
                                    </td>
                                </tr>
                            </table>                       
                            <div class="inline"><%--为了实现此div容器中的内容可以在一行中显示--%>
                            <asp:Panel ID="Panel77" runat="server" Visible="False">
                                <table>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label385" runat="server" Text=" &nbsp;&nbsp;&nbsp;&nbsp;【详情】:" Height="20px" Width="120px" ></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TextBox309" runat="server" Height="20px" Width="70px"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>                                                       
                            </asp:Panel>
                            </div>
                        </asp:Panel>
                        </div>

                    </asp:Panel>
                    </asp:Panel>
                    
                </div>
                </asp:View>

        <%--a5--%>
        <asp:View ID="View26" runat="server">
                    <div class="e">
                    <asp:Panel ID="Panel55" runat="server" GroupingText="体格检查" Font-Size="Small" >
                        <br />
                        <table>
                            <tr>
                                <td>
                                    &nbsp;&nbsp;&nbsp;&nbsp;
                                </td>
                                <td>
                                    <asp:Label ID="Label286" runat="server" Text="身高(cm)："></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox246" runat="server" Height="20" Width="50"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="Label287" runat="server" Text="体重(kg)："></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox247" runat="server" Height="20" Width="50"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="Label288" runat="server" Text="T(℃)："></asp:Label>
                                </td>
                                <td>
                                     <asp:TextBox ID="TextBox248" runat="server" Height="20" Width="50"></asp:TextBox>
                                </td>
                                <td>
                                     <asp:Label ID="Label289" runat="server" Text="P(次/分)："></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox249" runat="server" Height="20" Width="50"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;&nbsp;&nbsp;&nbsp;
                                </td>
                                <td></td>
                                <td>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator24" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox246" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td></td>
                                <td>
                        <%--一位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator25" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox247" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td></td>
                                <td>
                        <%--一位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator26" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox248" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td></td>
                                <td>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator27" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox249" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;&nbsp;&nbsp;&nbsp;
                                </td>
                                <td>
                                    <asp:Label ID="Label290" runat="server" Text="R(次/分)："></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox250" runat="server" Height="20" Width="50"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="Label291" runat="server" Text="BP(mmHG)："></asp:Label>
                                </td>
                                <td>
                                     <asp:TextBox ID="TextBox251" runat="server" Height="20" Width="50"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="Label292" runat="server" Text="KPS(分)："></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox252" runat="server" Height="20" Width="50"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="Label293" runat="server" Text="BSA(m²)："></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox253" runat="server" Height="20" Width="50"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;&nbsp;&nbsp;&nbsp;
                                </td>
                                <td></td>
                                <td>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator28" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox250" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td></td>
                                <td>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator29" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox251" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td></td>
                                <td>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator30" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox252" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td></td>
                                <td>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator31" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox253" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            </table>
                        <br />
                    </asp:Panel>

                          <div class="jiange"></div>

                    <asp:Panel ID="Panel56" runat="server" GroupingText="个人史" Font-Size="Small" >
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label294" runat="server" Text="出生地："></asp:Label>
                        <asp:TextBox ID="TextBox254" runat="server" Height="20px" Width="120px"></asp:TextBox>
                        <br /><br />
                        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label295" runat="server" Text="生长接触史："></asp:Label>
                        <asp:CheckBox ID="CheckBox49" runat="server" Text="毒物" />
                        <asp:CheckBox ID="CheckBox50" runat="server" Text="粉尘" />
                        <asp:CheckBox ID="CheckBox51" runat="server" Text="放射" />
                        <asp:CheckBox ID="CheckBox52" runat="server" Text="疫区" />
                        <asp:CheckBox ID="CheckBox53" runat="server" Text="烟酒嗜好" />
                        <asp:Label ID="Label296" runat="server" Text="烟酒详情："></asp:Label>
                        <asp:TextBox ID="TextBox255" runat="server" Height="20px"></asp:TextBox>
                        <br /><br />
                    </asp:Panel>

                          <div class="jiange"></div>

                    <asp:Panel ID="Panel57" runat="server" GroupingText="月经史" Font-Size="Small" >
                        <table>
                            <tr>
                                <td rowspan="2">
                                    &nbsp;&nbsp;&nbsp;&nbsp;
                                </td>
                                <td rowspan="2">
                                    <asp:Label ID="Label297" runat="server" Text="初潮(岁)："></asp:Label>
                                </td>
                                <td rowspan="2">
                                    <asp:TextBox ID="TextBox256" runat="server" Height="20" Width="50"></asp:TextBox>
                                </td>
                                 <td style="border-style: none none groove none; border-bottom-color: #000000; text-align: center; width:90px;">
                                    <asp:TextBox ID="TextBox257" runat="server" Height="20" Width="50"></asp:TextBox>
                                </td>
                                <td rowspan="2">
                                     &nbsp;&nbsp;
                                    <asp:Label ID="Label298" runat="server" Text="绝经(岁)："></asp:Label>
                                </td>
                                <td rowspan="2">
                                    <asp:TextBox ID="TextBox258" runat="server"  Height="20" Width="50"></asp:TextBox>
                                </td>
                                <td rowspan="2">
                                     &nbsp;&nbsp;
                                    <asp:Label ID="Label299" runat="server" Text="末次月经："></asp:Label>
                                </td>
                                <td rowspan="2">
                                    <asp:TextBox ID="TextBox259" runat="server" Height="20" Width="120" TextMode="Date"></asp:TextBox>
                                </td>
                                <td rowspan="2">
                                    <asp:CheckBox ID="CheckBox54" runat="server" Text="痛经" />
                                </td>
                            </tr> 
                           <tr>
                               <td style="text-align: center">
                                   <asp:TextBox ID="TextBox260" runat="server" Height="20" Width="50"></asp:TextBox>
                               </td>
                           </tr> 
                            <tr>
                                <td>
                                    &nbsp;&nbsp;&nbsp;&nbsp;
                                </td>
                                <td></td>
                                <td>
                                    <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator32" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox256" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td>
                                    <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator33" runat="server" ErrorMessage="*分子输入有误" ControlToValidate="TextBox257" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                    <br />
                                    <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator35" runat="server" ErrorMessage="*分母输入有误" ControlToValidate="TextBox260" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td></td>
                                <td>
                                    <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator34" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox258" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td></td>
                                <td></td>
                                <td></td>
                            </tr>
                            </table>
                        <br />
                    </asp:Panel>

                          <div class="jiange"></div>

                    <asp:Panel ID="Panel58" runat="server" GroupingText="婚育史" Font-Size="Small" >
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label300" runat="server" Text="结婚："></asp:Label>
                        <asp:DropDownList ID="DropDownList51" runat="server" Height="20" Width="60" BackColor="#E6E6E6" AutoPostBack="True" OnSelectedIndexChanged="DropDownList51_SelectedIndexChanged">
                            <asp:ListItem Selected="True">未婚</asp:ListItem>
                            <asp:ListItem>已婚</asp:ListItem>
                        </asp:DropDownList>
                        <br /><br />
                        <asp:Panel ID="Panel79" runat="server" Visible="False">
                         &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label301" runat="server" Text="结婚年龄(岁)："></asp:Label>
                        <asp:TextBox ID="TextBox261" runat="server" Height="20px" Width="40px"></asp:TextBox>
                        <asp:Label ID="Label302" runat="server" Text="配偶情况"></asp:Label>
                        <asp:DropDownList ID="DropDownList56" runat="server" Height="20" Width="80" BackColor="#E6E6E6">
                            <asp:ListItem>体健</asp:ListItem>
                            <asp:ListItem>患有疾病</asp:ListItem>
                            <asp:ListItem>已故</asp:ListItem>
                        </asp:DropDownList>
                        </asp:Panel>

                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label303" runat="server" Text="P"></asp:Label>
                        <asp:TextBox ID="TextBox262" runat="server" Height="20" Width="30"></asp:TextBox>
                        <asp:Label ID="Label304" runat="server" Text="G"></asp:Label>
                        <asp:TextBox ID="TextBox263" runat="server" Height="20" Width="30"></asp:TextBox>
                        <asp:Label ID="Label305" runat="server" Text="A"></asp:Label>
                        <asp:TextBox ID="TextBox264" runat="server" Height="20" Width="30"></asp:TextBox>

                         &nbsp;
                        <asp:Label ID="Label306" runat="server" Text="是否哺乳:"></asp:Label>
                        <asp:DropDownList ID="DropDownList52" runat="server"  Height="20" Width="40" BackColor="#E6E6E6">
                            <asp:ListItem Selected="True">是</asp:ListItem>
                            <asp:ListItem>否</asp:ListItem>
                        </asp:DropDownList>

                         &nbsp;
                        <asp:Label ID="Label307" runat="server" Text="侧别:"></asp:Label>
                        <asp:TextBox ID="TextBox287" runat="server" Height="20" Width="40"></asp:TextBox>

                         &nbsp;
                        <asp:Label ID="Label308" runat="server" Text="持续时间:"></asp:Label>
                        <asp:TextBox ID="TextBox288" runat="server" Height="20" Width="40"></asp:TextBox>

                         &nbsp;
                        <asp:Label ID="Label309" runat="server" Text="子女情况:"></asp:Label>
                        <asp:DropDownList ID="DropDownList53" runat="server" Height="20" Width="80" BackColor="#E6E6E6">
                            <asp:ListItem Selected="True">体健</asp:ListItem>
                            <asp:ListItem>患有疾病</asp:ListItem>
                            <asp:ListItem>已故</asp:ListItem>
                        </asp:DropDownList>
                        <br /><br />
                    </asp:Panel>

                         <div class="jiange"></div>

                    <asp:Panel ID="Panel59" runat="server" GroupingText="家族史" Font-Size="Small" >
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label350" runat="server" Text="父亲："></asp:Label>
                        <asp:DropDownList ID="DropDownList54" runat="server" Height="20px" Width="80px" BackColor="#E6E6E6"  AutoPostBack="True" OnSelectedIndexChanged="DropDownList54_SelectedIndexChanged">
                            <asp:ListItem Selected="True">体健</asp:ListItem>
                            <asp:ListItem>患有疾病</asp:ListItem>
                            <asp:ListItem>已故</asp:ListItem>
                        </asp:DropDownList>

                        <div class="inline">
                        <asp:Panel ID="Panel80" runat="server" Visible="False">
                        <asp:Label ID="Label351" runat="server" Text="详情："></asp:Label>
                        <asp:TextBox ID="TextBox289" runat="server" Height="20" Width="150"></asp:TextBox>
                        </asp:Panel>
                        </div>

                        <br /><br />
                        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label352" runat="server" Text="母亲："></asp:Label>
                        <asp:DropDownList ID="DropDownList55" runat="server" Height="20px" Width="80px" BackColor="#E6E6E6" OnSelectedIndexChanged="DropDownList55_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem Selected="True">体健</asp:ListItem>
                            <asp:ListItem>患有疾病</asp:ListItem>
                            <asp:ListItem>已故</asp:ListItem>
                        </asp:DropDownList>

                        <div class="inline">
                        <asp:Panel ID="Panel81" runat="server" Visible="False">
                        <asp:Label ID="Label353" runat="server" Text="详情："></asp:Label>
                        <asp:TextBox ID="TextBox290" runat="server" Height="20" Width="150"></asp:TextBox>
                        </asp:Panel>
                        </div>

                        <br /><br />
                       &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label354" runat="server" Text="家族恶性肿瘤史：" ></asp:Label>
                        <asp:DropDownList ID="DropDownList75" runat="server" Height="20px" Width="80px" BackColor="#E6E6E6" OnSelectedIndexChanged="DropDownList75_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem Selected="True">无</asp:ListItem>
                            <asp:ListItem>有</asp:ListItem>
                        </asp:DropDownList>

                        <div class="inline">
                        <asp:Panel ID="Panel82" runat="server" Visible="False">
                        <asp:Label ID="Label355" runat="server" Text="详情："></asp:Label>
                        <asp:TextBox ID="TextBox291" runat="server" Height="20" Width="150"></asp:TextBox>
                        </asp:Panel>
                        </div>
<br /><br />
                    </asp:Panel>
                    </div>
                </asp:View>

        <%--a6--%>
        <asp:View ID="View27" runat="server">
                         <div class="e">
                         <asp:Panel ID="Panel60" runat="server" GroupingText="专科查体" Font-Size="Medium" >
                             <br />
                             &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label310" runat="server" Text="乳房皮肤："></asp:Label>
                             <asp:DropDownList ID="DropDownList57" runat="server" Height="20" Width="120" BackColor="#E6E6E6" OnSelectedIndexChanged="DropDownList57_SelectedIndexChanged" AutoPostBack="True">
                                 <asp:ListItem Selected="True">正常</asp:ListItem>
                                 <asp:ListItem>局部凹陷</asp:ListItem>
                                 <asp:ListItem>水肿</asp:ListItem>
                                 <asp:ListItem>橘皮样</asp:ListItem>
                                 <asp:ListItem>卫星结节</asp:ListItem>
                                 <asp:ListItem>破溃</asp:ListItem>
                             </asp:DropDownList>
                             <asp:Label ID="Label386" runat="server" Text="个数：" Visible="False"></asp:Label>
                             <asp:TextBox ID="TextBox314" runat="server" Visible="False"></asp:TextBox>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator36" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox314" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                             <br /><br />
                             &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label311" runat="server" Text="乳&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;头："></asp:Label>
                             <asp:DropDownList ID="DropDownList58" runat="server" Height="20" Width="120" BackColor="#E6E6E6" AutoPostBack="True" OnSelectedIndexChanged="DropDownList58_SelectedIndexChanged">
                                 <asp:ListItem Selected="True">正常</asp:ListItem>
                                 <asp:ListItem>湿疹样</asp:ListItem>
                                 <asp:ListItem>凹陷</asp:ListItem>
                                 <asp:ListItem>半固定</asp:ListItem>
                                 <asp:ListItem>全固定</asp:ListItem>
                                 <asp:ListItem>缺损</asp:ListItem>
                             </asp:DropDownList>

                             <div class="inline">
                             <asp:Panel ID="Panel83" runat="server" Visible="False">
                                 <asp:Label ID="Label387" runat="server" Text="湿疹范围："></asp:Label>
                                 <asp:CheckBox ID="CheckBox70" runat="server" Text="乳头" ValidationGroup="a6_1"/>
                                 <asp:CheckBox ID="CheckBox71" runat="server" Text="乳晕" ValidationGroup="a6_1"/>
                                 <asp:CheckBox ID="CheckBox72" runat="server" Text="皮肤" ValidationGroup="a6_1"/>
                             </asp:Panel>
                             </div>

                             <br /><br />
                             &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label312" runat="server" Text="乳头溢液："></asp:Label>
                             <asp:DropDownList ID="DropDownList59" runat="server" Height="20" Width="60" BackColor="#E6E6E6" AutoPostBack="True" OnSelectedIndexChanged="DropDownList59_SelectedIndexChanged">
                                 <asp:ListItem Selected="True">无</asp:ListItem>
                                 <asp:ListItem>有</asp:ListItem>
                             </asp:DropDownList>

                             <div class="inline">
                             <asp:Panel ID="Panel84" runat="server" Visible="False">
                             <asp:DropDownList ID="DropDownList60" runat="server" Height="20" Width="60" BackColor="#E6E6E6">
                                 <asp:ListItem Selected="True">主动</asp:ListItem>
                                 <asp:ListItem>被动</asp:ListItem>
                             </asp:DropDownList>

                             <asp:DropDownList ID="DropDownList61" runat="server" Height="20" Width="60" BackColor="#E6E6E6">
                                 <asp:ListItem Selected="True">单孔</asp:ListItem>
                                 <asp:ListItem>多孔</asp:ListItem>
                             </asp:DropDownList>

                             <asp:DropDownList ID="DropDownList62" runat="server" Height="20" Width="60" BackColor="#E6E6E6">
                                 <asp:ListItem Selected="True">血性</asp:ListItem>
                                 <asp:ListItem>淡黄</asp:ListItem>
                                 <asp:ListItem>乳样</asp:ListItem>
                                 <asp:ListItem>无色</asp:ListItem>
                                 <asp:ListItem>其他</asp:ListItem>
                             </asp:DropDownList>
                             </asp:Panel>
                             </div>
                             <br /><br />
                             
                             <table>

                                 <tr>
                                     <td rowspan="3">
                                         &nbsp;&nbsp;&nbsp;&nbsp;
                                     </td>
                                     <td rowspan="3">
                                         <asp:Label ID="Label313" runat="server" Text="乳腺肿块："></asp:Label>
                             <asp:DropDownList ID="DropDownList63" runat="server" Height="20" Width="60" BackColor="#E6E6E6" AutoPostBack="True" OnSelectedIndexChanged="DropDownList63_SelectedIndexChanged">
                                 <asp:ListItem Selected="True">无</asp:ListItem>
                                 <asp:ListItem>有</asp:ListItem>
                             </asp:DropDownList>
                                     </td>

                                     <td>
                                     <asp:Panel ID="Panel85" runat="server" Visible="False">
                                         <asp:Label ID="Label314" runat="server" Text="位置："></asp:Label>
                                         <asp:TextBox ID="TextBox292" runat="server" Height="20" Width="60"></asp:TextBox>
                                         <asp:Label ID="Label315" runat="server" Text="点,距离乳头"></asp:Label>
                                         <asp:TextBox ID="TextBox293" runat="server" Height="20" Width="60"></asp:TextBox>
                                         <asp:Label ID="Label316" runat="server" Text="cm"></asp:Label>
                                          &nbsp;&nbsp;
                                         <asp:Label ID="Label317" runat="server" Text="性质："></asp:Label>
                                         <asp:DropDownList ID="DropDownList64" runat="server" Height="20" Width="60" BackColor="#E6E6E6">
                                             <asp:ListItem Selected="True">硬</asp:ListItem>
                                             <asp:ListItem>韧</asp:ListItem>
                                             <asp:ListItem>囊性</asp:ListItem>
                                             <asp:ListItem>软</asp:ListItem>
                                         </asp:DropDownList>
                                         &nbsp;
                                         <asp:Label ID="Label318" runat="server" Text="边界："></asp:Label>
                                         <asp:DropDownList ID="DropDownList76" runat="server" Height="20" Width="60" BackColor="#E6E6E6">
                                             <asp:ListItem Selected="True">清楚</asp:ListItem>
                                             <asp:ListItem>不清楚</asp:ListItem>
                                         </asp:DropDownList>
                                     </asp:Panel>
                                     </td>
                                 </tr>

                                 <tr>
                                     <td>
                                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <%--保留一位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator37" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox293" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                     </td>
                                 </tr>

                                 <tr>
                                     <td>
                                     <asp:Panel ID="Panel86" runat="server" Visible="False">
                                         <asp:Label ID="Label356" runat="server" Text="活动："></asp:Label>
                                         <asp:DropDownList ID="DropDownList77" runat="server" Height="20" Width="60" BackColor="#E6E6E6">
                                             <asp:ListItem Selected="True">佳</asp:ListItem>
                                             <asp:ListItem>差</asp:ListItem>
                                         </asp:DropDownList>
                                         &nbsp;
                                         <asp:Label ID="Label357" runat="server" Text="胸壁黏连："></asp:Label>
                                         <asp:DropDownList ID="DropDownList78" runat="server" Height="20" Width="60" BackColor="#E6E6E6">
                                             <asp:ListItem Selected="True">有</asp:ListItem>
                                             <asp:ListItem>无</asp:ListItem>
                                         </asp:DropDownList>
                                         &nbsp;
                                         <asp:Label ID="Label358" runat="server" Text="胸壁固定："></asp:Label>
                                         <asp:DropDownList ID="DropDownList79" runat="server" Height="20" Width="60" BackColor="#E6E6E6">
                                             <asp:ListItem Selected="True">有</asp:ListItem>
                                             <asp:ListItem>无</asp:ListItem>
                                         </asp:DropDownList>
                                     </asp:Panel>
                                     </td>
                                 </tr>
                             </table>
                             <br />
                             <table>
                                 <tr>
                                     <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                     <td>
                                         <asp:Label ID="Label359" runat="server" Text="淋巴结："></asp:Label>
                                     </td>
                                     <td>
                                         <asp:Label ID="Label360" runat="server" Text="同侧腋窝："></asp:Label>
                                     </td>
                                     <td>
                                         <asp:DropDownList ID="DropDownList80" runat="server" Height="20" Width="60" BackColor="#E6E6E6" AutoPostBack="True" OnSelectedIndexChanged="DropDownList80_SelectedIndexChanged">
                                             <asp:ListItem Selected="True">无</asp:ListItem>
                                             <asp:ListItem>有</asp:ListItem>
                                         </asp:DropDownList>
                                     </td>
                                     <td>
                                         <asp:Label ID="Label361" runat="server" Text="数量(个)：" Visible="False"></asp:Label>
                                     </td>
                                     <td>
                                         <asp:TextBox ID="TextBox294" runat="server" Height="20" Width="60" Visible="False"></asp:TextBox>
                                     </td>
                                     <td>
                                         <asp:Label ID="Label362" runat="server" Text="大小(cm)：" Visible="False"></asp:Label>
                                     </td>
                                     <td>
                                         <asp:TextBox ID="TextBox295" runat="server" Height="20" Width="60" Visible="False"></asp:TextBox>
                                     </td>
                                     <td>
                                         <asp:DropDownList ID="DropDownList81" runat="server" Height="20" Width="60" BackColor="#E6E6E6" Visible="False">
                                             <asp:ListItem Selected="True">散在</asp:ListItem>
                                             <asp:ListItem>融合</asp:ListItem>
                                             <asp:ListItem>串珠</asp:ListItem>
                                         </asp:DropDownList>
                                     </td>
                                     <td>
                                         <asp:DropDownList ID="DropDownList82" runat="server" Height="20" Width="60" BackColor="#E6E6E6" Visible="False">
                                             <asp:ListItem Selected="True">活动</asp:ListItem>
                                             <asp:ListItem>粘连</asp:ListItem>
                                             <asp:ListItem>固定</asp:ListItem>
                                         </asp:DropDownList>
                                     </td>
                                 </tr>

                                 <tr>
                                     <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                     <td></td>
                                     <td></td>
                                     <td></td>
                                     <td></td>
                                     <td>
                                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator38" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox294" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                     </td>
                                     <td></td>
                                     <td>
                                        <%--一位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator39" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox295" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>

                                     </td>
                                     <td></td>
                                     <td></td>
                                 </tr>

                                 <tr>
                                     <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                     <td></td>
                                     <td>
                                         <asp:Label ID="Label363" runat="server" Text="同锁骨上："></asp:Label>
                                     </td>
                                     <td>
                                         <asp:DropDownList ID="DropDownList83" runat="server" Height="20" Width="60" BackColor="#E6E6E6" AutoPostBack="True" OnSelectedIndexChanged="DropDownList83_SelectedIndexChanged">
                                             <asp:ListItem Selected="True">无</asp:ListItem>
                                             <asp:ListItem>有</asp:ListItem>
                                         </asp:DropDownList>
                                     </td>
                                     <td>
                                         <asp:Label ID="Label364" runat="server" Text="数量(个)：" Visible="False"></asp:Label>
                                     </td>
                                     <td>
                                         <asp:TextBox ID="TextBox296" runat="server" Height="20" Width="60" Visible="False"></asp:TextBox>
                                     </td>
                                     <td>
                                         <asp:Label ID="Label365" runat="server" Text="大小(cm)：" Visible="False"></asp:Label>
                                     </td>
                                     <td>
                                         <asp:TextBox ID="TextBox297" runat="server" Height="20" Width="60" Visible="False"></asp:TextBox>
                                     </td>
                                     <td>
                                         <asp:DropDownList ID="DropDownList84" runat="server" Height="20" Width="60" BackColor="#E6E6E6" Visible="False">
                                             <asp:ListItem Selected="True">散在</asp:ListItem>
                                             <asp:ListItem>融合</asp:ListItem>
                                             <asp:ListItem>串珠</asp:ListItem>
                                         </asp:DropDownList>
                                     </td>
                                     <td>
                                         <asp:DropDownList ID="DropDownList85" runat="server" Height="20" Width="60" BackColor="#E6E6E6" Visible="False">
                                             <asp:ListItem Selected="True">活动</asp:ListItem>
                                             <asp:ListItem>粘连</asp:ListItem>
                                             <asp:ListItem>固定</asp:ListItem>
                                         </asp:DropDownList>
                                     </td>
                                 </tr>

                                 <tr>
                                     <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                     <td></td>
                                     <td></td>
                                     <td></td>
                                     <td></td>
                                     <td>
                                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator40" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox296" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                     </td>
                                     <td></td>
                                     <td>
                                        <%--一位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator41" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox297" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>

                                     </td>
                                     <td></td>
                                     <td></td>
                                 </tr>

                                 <tr>
                                     <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                     <td></td>
                                     <td>
                                         <asp:Label ID="Label366" runat="server" Text="对侧腋窝："></asp:Label>
                                     </td>
                                     <td>
                                         <asp:DropDownList ID="DropDownList86" runat="server" Height="20" Width="60" BackColor="#E6E6E6" AutoPostBack="True" OnSelectedIndexChanged="DropDownList86_SelectedIndexChanged">
                                             <asp:ListItem Selected="True">无</asp:ListItem>
                                             <asp:ListItem>有</asp:ListItem>
                                         </asp:DropDownList>
                                     </td>
                                     <td>
                                         <asp:Label ID="Label367" runat="server" Text="数量(个)：" Visible="False"></asp:Label>
                                     </td>
                                     <td>
                                         <asp:TextBox ID="TextBox298" runat="server" Height="20" Width="60" Visible="False"></asp:TextBox>
                                     </td>
                                     <td>
                                         <asp:Label ID="Label368" runat="server" Text="大小(cm)：" Visible="False"></asp:Label>
                                     </td>
                                     <td>
                                         <asp:TextBox ID="TextBox299" runat="server" Height="20" Width="60" Visible="False"></asp:TextBox>
                                     </td>
                                     <td>
                                         <asp:DropDownList ID="DropDownList87" runat="server" Height="20" Width="60" BackColor="#E6E6E6" Visible="False">
                                             <asp:ListItem Selected="True">散在</asp:ListItem>
                                             <asp:ListItem>融合</asp:ListItem>
                                             <asp:ListItem>串珠</asp:ListItem>
                                         </asp:DropDownList>
                                     </td>
                                     <td>
                                         <asp:DropDownList ID="DropDownList88" runat="server" Height="20" Width="60" BackColor="#E6E6E6" Visible="False">
                                             <asp:ListItem Selected="True">活动</asp:ListItem>
                                             <asp:ListItem>粘连</asp:ListItem>
                                             <asp:ListItem>固定</asp:ListItem>
                                         </asp:DropDownList>
                                     </td>
                                 </tr>

                                 <tr>
                                     <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                     <td></td>
                                     <td></td>
                                     <td></td>
                                     <td></td>
                                     <td>
                                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator42" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox298" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                     </td>
                                     <td></td>
                                     <td>
                                        <%--一位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator43" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox299" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>

                                     </td>
                                     <td></td>
                                     <td></td>
                                 </tr>

                                 <tr>
                                     <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                     <td></td>
                                     <td>
                                         <asp:Label ID="Label369" runat="server" Text="对锁骨上："></asp:Label>
                                     </td>
                                     <td>
                                         <asp:DropDownList ID="DropDownList89" runat="server" Height="20" Width="60" BackColor="#E6E6E6" AutoPostBack="True" OnSelectedIndexChanged="DropDownList89_SelectedIndexChanged">
                                             <asp:ListItem Selected="True">无</asp:ListItem>
                                             <asp:ListItem>有</asp:ListItem>
                                         </asp:DropDownList>
                                     </td>
                                     <td>
                                         <asp:Label ID="Label370" runat="server" Text="数量(个)：" Visible="False"></asp:Label>
                                     </td>
                                     <td>
                                         <asp:TextBox ID="TextBox300" runat="server" Height="20" Width="60" Visible="False"></asp:TextBox>
                                     </td>
                                     <td>
                                         <asp:Label ID="Label371" runat="server" Text="大小(cm)：" Visible="False"></asp:Label>
                                     </td>
                                     <td>
                                         <asp:TextBox ID="TextBox301" runat="server" Height="20" Width="60" Visible="False"></asp:TextBox>
                                     </td>
                                     <td>
                                         <asp:DropDownList ID="DropDownList90" runat="server" Height="20" Width="60" BackColor="#E6E6E6" Visible="False">
                                             <asp:ListItem Selected="True">散在</asp:ListItem>
                                             <asp:ListItem>融合</asp:ListItem>
                                             <asp:ListItem>串珠</asp:ListItem>
                                         </asp:DropDownList>
                                     </td>
                                     <td>
                                         <asp:DropDownList ID="DropDownList91" runat="server" Height="20" Width="60" BackColor="#E6E6E6" Visible="False">
                                             <asp:ListItem Selected="True">活动</asp:ListItem>
                                             <asp:ListItem>粘连</asp:ListItem>
                                             <asp:ListItem>固定</asp:ListItem>
                                         </asp:DropDownList>
                                     </td>
                                 </tr>

                                 <tr>
                                     <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                     <td></td>
                                     <td></td>
                                     <td></td>
                                     <td></td>
                                     <td>
                                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator44" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox300" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                     </td>
                                     <td></td>
                                     <td>
                                        <%--一位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator45" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox301" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>

                                     </td>
                                     <td></td>
                                     <td></td>
                                 </tr>
                             </table>
                             <br />
                         </asp:Panel>
                         </div>
                </asp:View>

        <%--a7--%>
        <asp:View ID="View28" runat="server">
                    <div class="e">
                        <asp:Panel ID="Panel61" runat="server" Font-Size="Medium" GroupingText="远处转移" >
                            <br />
                             &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:DropDownList ID="DropDownList65" runat="server" Height="20" Width="60" BackColor="#E6E6E6" AutoPostBack="True"  OnSelectedIndexChanged="DropDownList65_SelectedIndexChanged">
                                <asp:ListItem Selected="True">无</asp:ListItem>
                                <asp:ListItem>有</asp:ListItem>
                            </asp:DropDownList>
                            <br /><br />

                            <asp:Panel ID="Panel87" runat="server" Visible="False">
                             &nbsp;&nbsp;&nbsp;&nbsp;<asp:CheckBox ID="CheckBox62" runat="server" Text="对乳" />
                            <asp:CheckBox ID="CheckBox63" runat="server" Text="对腋窝" />
                            <asp:CheckBox ID="CheckBox64" runat="server" Text="对锁骨上" />
                            <asp:CheckBox ID="CheckBox65" runat="server" Text="肺" />
                            <asp:CheckBox ID="CheckBox66" runat="server" Text="肝" />
                            <asp:CheckBox ID="CheckBox67" runat="server" Text="骨" />
                            <asp:CheckBox ID="CheckBox68" runat="server" Text="脑" />
                            <asp:CheckBox ID="CheckBox69" runat="server" Text="其他" />
                            <br /><br />
                            </asp:Panel>

                        </asp:Panel>

                        <div class="jiange"></div>

                        <asp:Panel ID="Panel62" runat="server" Font-Size="Medium" GroupingText="TNM分期" >
                            <br />
                             &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label319" runat="server" Text="T"></asp:Label>
                        <asp:TextBox ID="TextBox265" runat="server" Height="20" Width="40"></asp:TextBox>
                        <asp:Label ID="Label320" runat="server" Text="N"></asp:Label>
                        <asp:TextBox ID="TextBox266" runat="server" Height="20" Width="40"></asp:TextBox>
                        <asp:Label ID="Label321" runat="server" Text="M"></asp:Label>
                        <asp:TextBox ID="TextBox267" runat="server" Height="20" Width="40"></asp:TextBox>
                            <br /><br />
                        </asp:Panel>

                        <asp:Panel ID="Panel63" runat="server" Font-Size="Medium" GroupingText="辅助检查" >
                            <br />
                             &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:DropDownList ID="DropDownList66" runat="server" Height="20" Width="60" BackColor="#E6E6E6" AutoPostBack="True"  OnSelectedIndexChanged="DropDownList66_SelectedIndexChanged">
                                <asp:ListItem Selected="True">无</asp:ListItem>
                                <asp:ListItem>有</asp:ListItem>
                            </asp:DropDownList>

                            <br /><br />

                            <asp:Panel ID="Panel88" runat="server" Visible="False">
                             &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label372" runat="server" Text="B超："></asp:Label>
                            <asp:DropDownList ID="DropDownList92" runat="server" Height="20" Width="60" BackColor="#E6E6E6">
                                <asp:ListItem Selected="True">良性</asp:ListItem>
                                <asp:ListItem>恶性</asp:ListItem>
                                <asp:ListItem>疑似</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label373" runat="server" Text="钼靶："></asp:Label>
                            <asp:DropDownList ID="DropDownList93" runat="server" Height="20" Width="60" BackColor="#E6E6E6">
                                <asp:ListItem Selected="True">良性</asp:ListItem>
                                <asp:ListItem>恶性</asp:ListItem>
                                <asp:ListItem>疑似</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label374" runat="server" Text="CT："></asp:Label>
                            <asp:DropDownList ID="DropDownList94" runat="server" Height="20" Width="60" BackColor="#E6E6E6">
                                <asp:ListItem Selected="True">良性</asp:ListItem>
                                <asp:ListItem>恶性</asp:ListItem>
                                <asp:ListItem>疑似</asp:ListItem>
                            </asp:DropDownList>
                            <asp:Label ID="Label375" runat="server" Text="MRI"></asp:Label>
                            <asp:DropDownList ID="DropDownList95" runat="server" Height="20" Width="60" BackColor="#E6E6E6">
                                <asp:ListItem Selected="True">良性</asp:ListItem>
                                <asp:ListItem>恶性</asp:ListItem>
                                <asp:ListItem>疑似</asp:ListItem>
                            </asp:DropDownList>
                            </asp:Panel>

                            <br /><br />
                        </asp:Panel>
                    </div>
                </asp:View>

        </asp:MultiView>
   <%-- </div>--%>
    </asp:View>
    
    <%--二级菜单b--%>
    <asp:View ID="View4" runat="server">
        
    <asp:Menu ID="Menu3" runat="server" Orientation="Horizontal"  OnMenuItemClick="Menu3_MenuItemClick" BackColor="#fff4f4">
                <Items>
                    <asp:MenuItem Text="术前检查" Value="1" Selected="True"></asp:MenuItem>
                    <asp:MenuItem Text="术中实施SLNB" Value="2"></asp:MenuItem>
                    <asp:MenuItem Text="术中行ARM" Value="3"></asp:MenuItem>
                    <asp:MenuItem Text="腋窝状况记录" Value="4"></asp:MenuItem>
                </Items>

                <LevelMenuItemStyles>
                    <asp:MenuItemStyle Font-Underline="False"  ForeColor="#cc0066"  CssClass="item2" />
                </LevelMenuItemStyles>
                <LevelSelectedStyles>
                    <asp:MenuItemStyle BackColor="White" Font-Underline="False" CssClass="title" ForeColor="Black" BorderStyle="Solid" BorderColor="#ff99ff" BorderWidth="1px" Font-Size="Large" />
                </LevelSelectedStyles>

            </asp:Menu>
        <asp:MultiView ID="MultiView3" runat="server" ActiveViewIndex="0">
        <%--b1--%>
        <asp:View ID="View9" runat="server">
                <div class="e">
                    
                    <asp:Panel ID="Panel4" runat="server" GroupingText="SLN检查" HorizontalAlign="Left" Font-Size="Medium"><div class="kuang">
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" RepeatDirection="Horizontal" Width="300px" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                            <asp:ListItem>阴性</asp:ListItem>
                            <asp:ListItem>阳性</asp:ListItem>
                        </asp:RadioButtonList>
                        <br />

                        <asp:Panel ID="Panel14" runat="server" Visible="True" Enabled="False" EnableTheming="True">
                        <div class="chuzhen"><%--b1页面中的触诊模块--%>
                            <div class="chuzhen_1"><%--b1页面中的触诊模块左侧单选“有无”部分--%>
                            <asp:Label ID="Label46" runat="server" Text="触诊"></asp:Label>
                            <asp:RadioButtonList ID="RadioButtonList2" runat="server" Height="60px" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList2_SelectedIndexChanged">
                                <asp:ListItem>无</asp:ListItem>
                                <asp:ListItem>有</asp:ListItem>
                            </asp:RadioButtonList>
                            </div>

                            <asp:Panel ID="Panel15" runat="server">
                            <div class="chuzhen_2"><%--b1页面中的触诊模块右侧部分--%>
                                 <table>
                                    <tr>
                                        <td>
                                <asp:TextBox ID="TextBox24" runat="server" Width="40px" Height="20" AutoPostBack="True"></asp:TextBox>
                                            </td>
                                        <td>
                                <asp:Label ID="Label47" runat="server" Text="个，最大"></asp:Label>
                                            </td>
                                        <td>
                                <asp:TextBox ID="TextBox25" runat="server" Width="40px" Height="20" AutoPostBack="True"></asp:TextBox>
                                <asp:Label ID="Label48" runat="server" Text="cm"></asp:Label>
                                            </td>
                                </tr>
                                    <tr>
                                        <td>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator46" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox24" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                        </td>
                                        <td></td>
                                        <td>
                        <%--一位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator47" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox25" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                            </td>
                                </tr>
                                </table>

                                <asp:RadioButtonList ID="RadioButtonList3" runat="server" RepeatDirection="Horizontal" Height="80px" RepeatColumns="3" Width="240px" CellSpacing="3" AutoPostBack="True" CellPadding="3">
                                    <asp:ListItem>散在</asp:ListItem>
                                    <asp:ListItem>融合</asp:ListItem>
                                    <asp:ListItem>串珠</asp:ListItem>
                                    <asp:ListItem>活动</asp:ListItem>
                                    <asp:ListItem>固定</asp:ListItem>
                                </asp:RadioButtonList>
                            </div>
                            </asp:Panel>
                        </div>

                        <div class="chaosheng"><%--b1页面中的超声模块--%>
                            <div class="chaosheng_1"><%--b1页面中的超声模块左侧单选部分--%>
                            <asp:Label ID="Label49" runat="server" Text="超声"></asp:Label>
                            <asp:RadioButtonList ID="RadioButtonList4" runat="server" Height="60px" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList4_SelectedIndexChanged">
                                <asp:ListItem>无</asp:ListItem>
                                <asp:ListItem>有</asp:ListItem>
                            </asp:RadioButtonList>
                            </div>

                            <asp:Panel ID="Panel16" runat="server">
                            <div class="chaosheng_2"><%--b1页面中的超声模块右侧部分--%>
                                <table>
                                    <tr>
                                        <td>
                                <asp:TextBox ID="TextBox26" runat="server" Width="40px" Height="20" AutoPostBack="True"></asp:TextBox>
                                            </td>
                                        <td>
                                <asp:Label ID="Label50" runat="server" Text="个，最大"></asp:Label>
                                            </td>
                                        <td>
                                <asp:TextBox ID="TextBox27" runat="server" Width="40px" Height="20" AutoPostBack="True"></asp:TextBox>
                                <asp:Label ID="Label51" runat="server" Text="cm"></asp:Label>
                                            </td>
                                </tr>
                                    <tr>
                                        <td>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator48" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox26" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                        </td>
                                        <td></td>
                                        <td>
                        <%--一位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator49" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox27" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                            </td>
                                </tr>
                                </table>

                                <asp:RadioButtonList ID="RadioButtonList5" runat="server" RepeatDirection="Horizontal" Height="80px" RepeatColumns="3" Width="240px" CellSpacing="3" AutoPostBack="True" CellPadding="3">
                                    <asp:ListItem>散在</asp:ListItem>
                                    <asp:ListItem>融合</asp:ListItem>
                                    <asp:ListItem>串珠</asp:ListItem>
                                    <asp:ListItem>活动</asp:ListItem>
                                    <asp:ListItem>固定</asp:ListItem>
                                </asp:RadioButtonList>
                            </div>
                            </asp:Panel>
                        </div>
                            
                        <div class="chuzhen"><%--因为此模块与“chuzhen”容器的样式相同，因此引用此“chuzhen”样式--%>
                            <div class="chuzhen_1">
                            <asp:Label ID="Label52" runat="server" Text="钼靶"></asp:Label>
                            <asp:RadioButtonList ID="RadioButtonList6" runat="server" Height="60px" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList6_SelectedIndexChanged">
                                <asp:ListItem>无</asp:ListItem>
                                <asp:ListItem>有</asp:ListItem>
                            </asp:RadioButtonList>
                            </div>

                            <asp:Panel ID="Panel17" runat="server">
                            <div class="chuzhen_2">
                               <table>
                                    <tr>
                                        <td>
                                <asp:TextBox ID="TextBox28" runat="server" Width="40px" Height="20" AutoPostBack="True"></asp:TextBox>
                                            </td>
                                        <td>
                                <asp:Label ID="Label53" runat="server" Text="个，最大"></asp:Label>
                                            </td>
                                        <td>
                                <asp:TextBox ID="TextBox29" runat="server" Width="40px" Height="20" AutoPostBack="True"></asp:TextBox>
                                <asp:Label ID="Label54" runat="server" Text="cm"></asp:Label>
                                            </td>
                                        </tr>
                                    <tr>
                                        <td>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator50" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox28" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                        </td>
                                        <td></td>
                                        <td>
                        <%--一位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator51" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox29" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                            </td>
                                </tr>
                                </table>

                                <asp:RadioButtonList ID="RadioButtonList7" runat="server" RepeatDirection="Horizontal" Height="80px" RepeatColumns="3" Width="240px" CellSpacing="3" AutoPostBack="True" CellPadding="3">
                                    <asp:ListItem>散在</asp:ListItem>
                                    <asp:ListItem>融合</asp:ListItem>
                                    <asp:ListItem>串珠</asp:ListItem>
                                    <asp:ListItem>活动</asp:ListItem>
                                    <asp:ListItem>固定</asp:ListItem>
                                </asp:RadioButtonList>
                            </div>
                            </asp:Panel>
                        </div>

                        <div class="chaosheng">
                            <div class="chaosheng_1">
                            <asp:Label ID="Label55" runat="server" Text="核磁"></asp:Label>
                            <asp:RadioButtonList ID="RadioButtonList8" runat="server" Height="60px" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList8_SelectedIndexChanged">
                                <asp:ListItem>无</asp:ListItem>
                                <asp:ListItem>有</asp:ListItem>
                            </asp:RadioButtonList>
                            </div>

                            <asp:Panel ID="Panel18" runat="server">
                            <div class="chaosheng_2">
                                 <table>
                                    <tr>
                                        <td>
                                <asp:TextBox ID="TextBox30" runat="server" Width="40px" Height="20" AutoPostBack="True"></asp:TextBox>
                                            </td>
                                        <td>
                                <asp:Label ID="Label56" runat="server" Text="个，最大"></asp:Label>
                                            </td>
                                        <td>
                                <asp:TextBox ID="TextBox31" runat="server" Width="40px" Height="20" AutoPostBack="True"></asp:TextBox>
                                <asp:Label ID="Label57" runat="server" Text="cm"></asp:Label>
                                            </td>
                                        </tr>
                                    <tr>
                                        <td>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator52" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox30" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                        </td>
                                        <td></td>
                                        <td>
                        <%--一位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator53" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox31" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                            </td>
                                </tr>
                                </table>

                                <asp:RadioButtonList ID="RadioButtonList9" runat="server" RepeatDirection="Horizontal" Height="80px" RepeatColumns="3" Width="240px" CellSpacing="3" AutoPostBack="True" CellPadding="3">
                                    <asp:ListItem>散在</asp:ListItem>
                                    <asp:ListItem>融合</asp:ListItem>
                                    <asp:ListItem>串珠</asp:ListItem>
                                    <asp:ListItem>活动</asp:ListItem>
                                    <asp:ListItem>固定</asp:ListItem>
                                </asp:RadioButtonList>
                            </div>
                            </asp:Panel>
                        </div>
                        </asp:Panel>

                        <div class="b_1_1_bottom"><%--b1页面第一版块“SLN检查”部分的底部--%>
                        <asp:Label ID="Label58" runat="server" Text="临床腋窝分期："></asp:Label>
                        <asp:DropDownList ID="DropDownList12" runat="server" Height="20px" Width="80px" BackColor="#E6E6E6">
                            <asp:ListItem>cN0</asp:ListItem>
                            <asp:ListItem>cN1</asp:ListItem>
                            <asp:ListItem>cN1a</asp:ListItem>
                            <asp:ListItem>cN1b</asp:ListItem>
                            <asp:ListItem>cN2</asp:ListItem>
                        </asp:DropDownList>
                        </div></div>
                    </asp:Panel>

                    <asp:Panel ID="Panel5" runat="server" GroupingText="术前穿刺活检" Font-Size="Medium">
                        <div class="b_1_2"><%--b1页面第二版块“术前穿刺活检”部分--%>
                            <asp:Label ID="Label59" runat="server" Text="粗针"></asp:Label>
                            <asp:TextBox ID="TextBox32" runat="server" Width="80px" Height="20"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label60" runat="server" Text="细针"></asp:Label>
                            <asp:TextBox ID="TextBox33" runat="server" Width="80px" Height="20"></asp:TextBox>&nbsp;&nbsp;
                            <asp:Label ID="Label61" runat="server" Text="针号"></asp:Label>
                            <asp:TextBox ID="TextBox34" runat="server" Width="80px" Height="20"></asp:TextBox>
                            <br />
                            <br />
                            <asp:Label ID="Label62" runat="server" Text="标本"></asp:Label>
                            <asp:TextBox ID="TextBox35" runat="server" Width="80px" Height="20"></asp:TextBox>
                            <asp:Label ID="Label63" runat="server" Text="条"></asp:Label>&nbsp;&nbsp;
                            <asp:Label ID="Label65" runat="server" Text="病理"></asp:Label>
                            <asp:TextBox ID="TextBox36" runat="server" Width="80px" Height="20"></asp:TextBox>
                            <br />
                            <br />
                            <asp:Label ID="Label64" runat="server" Text="免疫"></asp:Label>
                            <asp:TextBox ID="TextBox37" runat="server" Width="80px" Height="20"></asp:TextBox><br />
                        </div>
                    </asp:Panel></div>
                
                </asp:View>

        <%--b2--%>
        <asp:View ID="View10" runat="server">
                <div class="e">
                    <asp:Panel ID="Panel6" runat="server" GroupingText="示踪信息" Font-Size="Medium">
                        <div class="b_2_1"><%--b2页面第一版块“示踪信息”部分--%>
                            <div style="height: 30px; width:500px;">
                            <asp:Label ID="Label66" runat="server" Text="示踪方法："></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:DropDownList ID="DropDownList13" runat="server" Height="20px" Width="110px" BackColor="#E6E6E6" ViewStateMode="Inherit" AutoPostBack="True" OnSelectedIndexChanged="DropDownList13_SelectedIndexChanged">
                                <asp:ListItem>核素法</asp:ListItem>
                                <asp:ListItem>染料</asp:ListItem>
                                <asp:ListItem>荧光染料</asp:ListItem>
                                <asp:ListItem>磁性染料</asp:ListItem>
                                <asp:ListItem>联合法</asp:ListItem>
                            </asp:DropDownList>
                            <asp:TextBox ID="TextBox164" runat="server" Height="20px" Width="90px" AutoPostBack="True" Enabled="False"></asp:TextBox>

                            </div>

                            <div style="height: 30px; width: 400px;">
                            <asp:Label ID="Label67" runat="server" Text="示踪药： "></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:DropDownList ID="DropDownList14" runat="server" Height="20px" Width="110px" BackColor="#E6E6E6">
                                <asp:ListItem>99mTc</asp:ListItem>
                                <asp:ListItem>美兰</asp:ListItem>
                                <asp:ListItem>纳米素</asp:ListItem>
                                <asp:ListItem>专利兰</asp:ListItem>
                                <asp:ListItem>吲哚氢氯</asp:ListItem>
                                <asp:ListItem>超磁性氧化铁</asp:ListItem>
                            </asp:DropDownList><br />
                            </div>

                            <div style="height: 30px; width: 400px;">
                            <asp:Label ID="Label68" runat="server" Text="注射量： "></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:DropDownList ID="DropDownList15" runat="server" Height="20px" Width="110px" BackColor="#E6E6E6">
                                <asp:ListItem>0.5ml</asp:ListItem>
                                <asp:ListItem>1.0ml</asp:ListItem>
                                <asp:ListItem>1.5ml</asp:ListItem>
                                <asp:ListItem>2.0ml</asp:ListItem>
                            </asp:DropDownList><br />
                            </div>
                            
                            <asp:Label ID="Label69" runat="server" Text="注射位置： "></asp:Label><br />

                            <div style="height: 80px; width: 90px;margin-left:10px;float:left;">
                            <asp:RadioButtonList ID="RadioButtonList10" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList10_SelectedIndexChanged">
                                <asp:ListItem>乳晕</asp:ListItem>
                                <asp:ListItem>肿瘤</asp:ListItem>
                                <asp:ListItem>淋巴结内</asp:ListItem>
                            </asp:RadioButtonList>
                            </div>

                            <div style="height: 60px; width: 250px;margin-left:10px;">
                            <asp:Label ID="Label70" runat="server" Text="乳晕周"></asp:Label>
                            <asp:TextBox ID="TextBox38" runat="server" Width="40px" Height="20px" Enabled="False" AutoPostBack="True"></asp:TextBox>
                            <asp:Label ID="Label71" runat="server" Text="点"></asp:Label>
                            <br />
                            <asp:Label ID="Label72" runat="server" Text="肿瘤周"></asp:Label>
                            <asp:TextBox ID="TextBox39" runat="server" Width="40px" Height="20px" Enabled="False" AutoPostBack="True"></asp:TextBox>
                            <asp:Label ID="Label73" runat="server" Text="点"></asp:Label>
                            </div>

                            <div style="height: 30px; width: 400px;clear:both;">
                            <asp:Label ID="Label74" runat="server" Text="注射层次："></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:DropDownList ID="DropDownList16" runat="server" Height="20px" Width="110px" BackColor="#E6E6E6" ViewStateMode="Inherit">
                                <asp:ListItem>皮内</asp:ListItem>
                                <asp:ListItem>皮下</asp:ListItem>
                                <asp:ListItem>肿瘤表面</asp:ListItem>
                                <asp:ListItem>淋巴结内</asp:ListItem>
                            </asp:DropDownList><br />
                            </div>

                            <div style="height: 30px; width: 400px;">
                            <asp:Label ID="Label75" runat="server" Text="注射时间："></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <%--日期修正--%>
                	        <asp:TextBox ID="TextBox44" runat="server" Height="20px" Width="60px"></asp:TextBox>
                            <asp:Image ID="Image3" runat="server" Width="20px" Height="20px" ImageUrl="images_logo/Calendar_logo.png" />
                            <ajaxToolkit:CalendarExtender ID="CalendarExtender3" runat="server" TargetControlID="TextBox44" PopupButtonID="Image3" Format="yyyy-MM-dd" FirstDayOfWeek="Monday"/>

                            <asp:TextBox ID="TextBox45" runat="server" Height="20px" Width="40px"></asp:TextBox>
                            <asp:Label ID="Label77" runat="server" Text=":"></asp:Label>
                            <asp:TextBox ID="TextBox46" runat="server" Height="20px" Width="40px"></asp:TextBox>
                            <asp:Label ID="Label80" runat="server" Text=":"></asp:Label>
                            <asp:TextBox ID="TextBox47" runat="server" Height="20px" Width="40px"></asp:TextBox>
                            <br />
                            </div>

                            <div style="height: 30px; width: 400px;">
                            <asp:Label ID="Label76" runat="server" Text="手术开始时间："></asp:Label>&nbsp;
                            <%--日期修正--%>
                            <asp:TextBox ID="TextBox40" runat="server" Height="20px" Width="60px"></asp:TextBox>
                            <asp:Image ID="Image4" runat="server" Width="20px" Height="20px" ImageUrl="images_logo/Calendar_logo.png" />
                            <ajaxToolkit:CalendarExtender ID="CalendarExtender4" runat="server" TargetControlID="TextBox40" PopupButtonID="Image4" Format="yyyy-MM-dd" FirstDayOfWeek="Monday"/>
                                
                            <asp:TextBox ID="TextBox41" runat="server" Height="20px" Width="40px"></asp:TextBox>
                            <asp:Label ID="Label78" runat="server" Text=":"></asp:Label>
                            <asp:TextBox ID="TextBox42" runat="server" Height="20px" Width="40px"></asp:TextBox>
                            <asp:Label ID="Label79" runat="server" Text=":"></asp:Label>
                            <asp:TextBox ID="TextBox43" runat="server" Height="20px" Width="40px"></asp:TextBox>
                            <br />
                            </div>
                        </div>
                    </asp:Panel>

                    <asp:Panel ID="Panel7" runat="server" GroupingText="SLN信息" Font-Size="Medium">
                    <div class="b_2_2"><%--b2页面第二版块“SLN信息”部分--%>
                        <div style="height: 30px; width: 400px;">
                            <asp:Label ID="Label81" runat="server" Text="摘除SLN时间："></asp:Label>&nbsp;
                            <%--日期修正--%>
                            <asp:TextBox ID="TextBox48" runat="server" Height="20px" Width="60px"></asp:TextBox>
                            <asp:Image ID="Image5" runat="server" Width="20px" Height="20px" ImageUrl="images_logo/Calendar_logo.png" />
                            <ajaxToolkit:CalendarExtender ID="CalendarExtender5" runat="server" TargetControlID="TextBox48" PopupButtonID="Image5" Format="yyyy-MM-dd" FirstDayOfWeek="Monday"/>
                            
                            <asp:TextBox ID="TextBox49" runat="server" Height="20px" Width="40px"></asp:TextBox>
                            <asp:Label ID="Label82" runat="server" Text=":"></asp:Label>
                            <asp:TextBox ID="TextBox50" runat="server" Height="20px" Width="40px"></asp:TextBox>
                            <asp:Label ID="Label83" runat="server" Text=":"></asp:Label>
                            <asp:TextBox ID="TextBox51" runat="server" Height="20px" Width="40px"></asp:TextBox>
                            <br />
                        </div>

                        <div style="height: 30px; width: 400px;clear:both;">
                            <asp:Label ID="Label84" runat="server" Text="发现SLN位置："></asp:Label>&nbsp;
                            <asp:DropDownList ID="DropDownList17" runat="server" Height="20px" Width="150px" BackColor="#E6E6E6" ViewStateMode="Inherit">
                                <asp:ListItem>标准点(肋间臂与第2肋交点)</asp:ListItem>
                                <asp:ListItem>Ⅰ水平：胸小肌外侧</asp:ListItem>
                                <asp:ListItem>Ⅱ水平：胸小肌上方</asp:ListItem>
                                <asp:ListItem>Ⅲ水平：胸小肌内侧</asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <div style="height: 30px; width: 400px;clear:both;">
                            <asp:Label ID="Label85" runat="server" Text="SLN数目："></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:DropDownList ID="DropDownList18" runat="server" Height="20px" Width="150px" BackColor="#E6E6E6" ViewStateMode="Inherit">
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                                <asp:ListItem>＞4</asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <div style="height: 30px; width: 400px;clear:both;">
                            <asp:Label ID="Label86" runat="server" Text="SLN类型："></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:DropDownList ID="DropDownList19" runat="server" Height="20px" Width="150px" BackColor="#E6E6E6" ViewStateMode="Inherit">
                                <asp:ListItem>A</asp:ListItem>
                                <asp:ListItem>B</asp:ListItem>
                                <asp:ListItem>C</asp:ListItem>
                                <asp:ListItem>D</asp:ListItem>
                                <asp:ListItem>E</asp:ListItem>
                                <asp:ListItem>F</asp:ListItem>
                                <asp:ListItem>G</asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <div style="height: 60px;clear:both;"> <%--width: 440px;--%>
                            <table>
                                <tr>
                                    <td>
                            <asp:Label ID="Label87" runat="server" Text="SLN最大直径："></asp:Label>&nbsp;
                            <asp:Label ID="Label90" runat="server" Text="长轴"></asp:Label>
                                        </td>
                                    <td>
                            <asp:TextBox ID="TextBox52" runat="server" Height="20px" Width="40px"></asp:TextBox>
                            <asp:Label ID="Label88" runat="server" Text="cm  "></asp:Label>
                                        </td>
                                    <td>
                            <asp:Label ID="Label89" runat="server" Text="短轴"></asp:Label>
                            <asp:TextBox ID="TextBox53" runat="server" Height="20px" Width="40px"></asp:TextBox>
                            <asp:Label ID="Label91" runat="server" Text="cm  "></asp:Label>
                                        </td>
                                    <td>
                            <asp:Label ID="Label92" runat="server" Text="厚度"></asp:Label>
                            <asp:TextBox ID="TextBox54" runat="server" Height="20px" Width="40px"></asp:TextBox>
                            <asp:Label ID="Label93" runat="server" Text="cm  "></asp:Label>
                                        </td>
                                </tr>
                                <tr >
                                    <td></td>
                                    <td>
                                                                <%--一位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator54" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox52" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                    </td>
                                    <td>
                                                                <%--一位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator55" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox53" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                    </td>
                                    <td>
                                                                <%--一位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator56" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox54" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                            </table>
                        </div>

                        <div style="height: 30px; width: 400px;clear:both;">
                            <asp:Label ID="Label94" runat="server" Text="SLN处理方式："></asp:Label>&nbsp;&nbsp;
                            <asp:DropDownList ID="DropDownList20" runat="server" Height="20px" Width="150px" BackColor="#E6E6E6" ViewStateMode="Inherit">
                                <asp:ListItem>穿刺病理学检查</asp:ListItem>
                                <asp:ListItem>切检病理学检查</asp:ListItem>
                                <asp:ListItem>切检细胞学检查</asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <div style="height: 30px; width: 400px;clear:both;">
                            <asp:Label ID="Label95" runat="server" Text="SLN病理(冰冻)："></asp:Label>
                            <asp:TextBox ID="TextBox55" runat="server" Height="20px" Width="150px"></asp:TextBox>
                        </div>

                        <div style="height: 30px; width: 500px;clear:both;">
                            <asp:Label ID="Label96" runat="server" Text="SLN免疫组化："></asp:Label>&nbsp;&nbsp;
                            <asp:DropDownList ID="DropDownList21" runat="server" Height="20px" Width="150px" BackColor="#E6E6E6" ViewStateMode="Inherit" AutoPostBack="True" OnSelectedIndexChanged="DropDownList21_SelectedIndexChanged">
                                <asp:ListItem>PR</asp:ListItem>
                                <asp:ListItem>ER</asp:ListItem>
                                <asp:ListItem>HER-2</asp:ListItem>
                                <asp:ListItem>Ki-67</asp:ListItem>
                                <asp:ListItem>p53</asp:ListItem>
                                <asp:ListItem>Cyclin B</asp:ListItem>
                                <asp:ListItem>Cyclin D</asp:ListItem>
                                <asp:ListItem>Cyclin E</asp:ListItem>
                                <asp:ListItem>EGFR</asp:ListItem>
                                <asp:ListItem>PS2</asp:ListItem>
                                <asp:ListItem>BRCA-1</asp:ListItem>
                                <asp:ListItem>BRCA-2</asp:ListItem>
                                <asp:ListItem>其它</asp:ListItem>
                            </asp:DropDownList>
                            <asp:TextBox ID="TextBox165" runat="server" Height="20px" Width="90px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                        </div>

                        <div style="height: 30px; width: 400px;clear:both;">
                            <asp:Label ID="Label97" runat="server" Text="SLNB操作者："></asp:Label>&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="TextBox56" runat="server" Height="20px" Width="150px"></asp:TextBox>
                        </div>
                    </div>
                    </asp:Panel>
                </div>
                </asp:View>

        <%--b3--%>
        <asp:View ID="View11" runat="server">
                <div class="e">
                    <asp:Panel ID="Panel8" runat="server" GroupingText="示踪信息" Font-Size="Medium">
                        <div class="b_2_1"><%--因为此板块的内容样式与b2页面第一版块样式“b_2_1”相类似，故进行引用--%>
                            <div style="height: 30px; width: 500px;">
                            <asp:Label ID="Label98" runat="server" Text="示踪方法："></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:DropDownList ID="DropDownList22" runat="server" Height="20px" Width="110px" BackColor="#E6E6E6" ViewStateMode="Inherit" AutoPostBack="True" OnSelectedIndexChanged="DropDownList22_SelectedIndexChanged">
                                <asp:ListItem>核素法</asp:ListItem>
                                <asp:ListItem>染料</asp:ListItem>
                                <asp:ListItem>荧光染料</asp:ListItem>
                                <asp:ListItem>磁性染料</asp:ListItem>
                                <asp:ListItem>联合法</asp:ListItem>
                            </asp:DropDownList>
                            <asp:TextBox ID="TextBox166" runat="server" Height="20px" Width="90px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                            </div>

                            <div style="height: 30px; width: 400px;">
                            <asp:Label ID="Label99" runat="server" Text="示踪药： "></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:DropDownList ID="DropDownList23" runat="server" Height="20px" Width="110px" BackColor="#E6E6E6">
                                <asp:ListItem>99mTc</asp:ListItem>
                                <asp:ListItem>美兰</asp:ListItem>
                                <asp:ListItem>纳米素</asp:ListItem>
                                <asp:ListItem>专利兰</asp:ListItem>
                                <asp:ListItem>吲哚氢氯</asp:ListItem>
                                <asp:ListItem>超磁性氧化铁</asp:ListItem>
                            </asp:DropDownList><br />
                            </div>

                            <div style="height: 30px; width: 400px;">
                            <asp:Label ID="Label100" runat="server" Text="注射量： "></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:DropDownList ID="DropDownList24" runat="server" Height="20px" Width="110px" BackColor="#E6E6E6">
                                <asp:ListItem>0.5ml</asp:ListItem>
                                <asp:ListItem>1.0ml</asp:ListItem>
                                <asp:ListItem>1.5ml</asp:ListItem>
                                <asp:ListItem>2.0ml</asp:ListItem>
                            </asp:DropDownList><br />
                            </div>
                            
                            <asp:Label ID="Label101" runat="server" Text="注射位置： "></asp:Label><br />

                            <div style="height: 60px; width: 200px;margin-left:10px;float:left;">
                            <asp:RadioButtonList ID="RadioButtonList11" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList11_SelectedIndexChanged" Height="30px">
                                <asp:ListItem>肱二头肌、肱三头肌间沟</asp:ListItem>
                                
                                <asp:ListItem>其它</asp:ListItem>
                                </asp:RadioButtonList>
                            </div>

                            <div style="height: 60px; width: 450px;margin-left:10px;margin-top:2px;">
                            <asp:Label ID="Label102" runat="server" Text="距离腋窝皱襞"></asp:Label>
                            <asp:TextBox ID="TextBox57" runat="server" Width="40px" Height="15px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                            <asp:Label ID="Label103" runat="server" Text="cm"></asp:Label>
                            <%--一位小数--%>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator57" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox57" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                            <br />
                            <asp:TextBox ID="TextBox58" runat="server" Width="150px" Height="15px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                            </div>

                            <div style="height: 30px; width: 400px;clear:both;">
                            <asp:Label ID="Label104" runat="server" Text="注射层次："></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:DropDownList ID="DropDownList25" runat="server" Height="20px" Width="110px" BackColor="#E6E6E6" ViewStateMode="Inherit">
                                <asp:ListItem>皮内</asp:ListItem>
                                <asp:ListItem>皮下</asp:ListItem>
                            </asp:DropDownList><br />
                            </div>

                            <div style="height: 30px; width: 400px;">
                            <asp:Label ID="Label105" runat="server" Text="注射时间："></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <%--日历修正--%>
                    <asp:TextBox ID="TextBox59" runat="server" Height="20px" Width="60px"></asp:TextBox>
                    <asp:Image ID="Image6" runat="server" Width="20px" Height="20px" ImageUrl="images_logo/Calendar_logo.png" />
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender6" runat="server" TargetControlID="TextBox59" PopupButtonID="Image6" Format="yyyy-MM-dd" FirstDayOfWeek="Monday"/>

                            <asp:TextBox ID="TextBox60" runat="server" Height="20px" Width="40px"></asp:TextBox>
                            <asp:Label ID="Label106" runat="server" Text=":"></asp:Label>
                            <asp:TextBox ID="TextBox61" runat="server" Height="20px" Width="40px"></asp:TextBox>
                            <asp:Label ID="Label107" runat="server" Text=":"></asp:Label>
                            <asp:TextBox ID="TextBox62" runat="server" Height="20px" Width="40px"></asp:TextBox>
                            <br />
                            </div>

                            <div style="height: 30px; width: 400px;">
                            <asp:Label ID="Label108" runat="server" Text="手术开始时间："></asp:Label>&nbsp;
                            <%--日历修正--%>
                    <asp:TextBox ID="TextBox63" runat="server" Height="20px" Width="60px"></asp:TextBox>
                    <asp:Image ID="Image7" runat="server" Width="20px" Height="20px" ImageUrl="images_logo/Calendar_logo.png" />
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender7" runat="server" TargetControlID="TextBox63" PopupButtonID="Image7" Format="yyyy-MM-dd" FirstDayOfWeek="Monday"/>

                            <asp:TextBox ID="TextBox64" runat="server" Height="20px" Width="40px"></asp:TextBox>
                            <asp:Label ID="Label109" runat="server" Text=":"></asp:Label>
                            <asp:TextBox ID="TextBox65" runat="server" Height="20px" Width="40px"></asp:TextBox>
                            <asp:Label ID="Label110" runat="server" Text=":"></asp:Label>
                            <asp:TextBox ID="TextBox66" runat="server" Height="20px" Width="40px"></asp:TextBox>
                            <br />
                            </div>
                        </div>                  
                    </asp:Panel>

                    <asp:Panel ID="Panel9" runat="server" GroupingText="ARM信息" Font-Size="Medium">
                    <div class="b_2_2">
                        <div style="height: 30px; width: 400px;">
                            <asp:Label ID="Label111" runat="server" Text="摘除ARM时间："></asp:Label>&nbsp;
                            <%--日历修正--%>
                    <asp:TextBox ID="TextBox67" runat="server" Height="20px" Width="60px"></asp:TextBox>
                    <asp:Image ID="Image8" runat="server" Width="20px" Height="20px" ImageUrl="images_logo/Calendar_logo.png" />
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender8" runat="server" TargetControlID="TextBox67" PopupButtonID="Image8" Format="yyyy-MM-dd" FirstDayOfWeek="Monday"/>
                            
                            <asp:TextBox ID="TextBox68" runat="server" Height="20px" Width="40px"></asp:TextBox>
                            <asp:Label ID="Label112" runat="server" Text=":"></asp:Label>
                            <asp:TextBox ID="TextBox69" runat="server" Height="20px" Width="40px"></asp:TextBox>
                            <asp:Label ID="Label113" runat="server" Text=":"></asp:Label>
                            <asp:TextBox ID="TextBox70" runat="server" Height="20px" Width="40px"></asp:TextBox>
                            <br />
                        </div>

                        <div style="height: 30px; width: 400px;clear:both;">
                            <asp:Label ID="Label114" runat="server" Text="ARM位置："></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:DropDownList ID="DropDownList26" runat="server" Height="20px" Width="150px" BackColor="#E6E6E6" ViewStateMode="Inherit">
                                <asp:ListItem>A 肋间臂神经</asp:ListItem>
                                <asp:ListItem>B 前锯肌</asp:ListItem>
                                <asp:ListItem>C 肩胛下脉管束</asp:ListItem>
                                <asp:ListItem>D 背阔肌外缘</asp:ListItem>
                                <asp:ListItem>E 腋静脉</asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <div style="height: 30px; width: 400px;clear:both;">
                            <asp:Label ID="Label115" runat="server" Text="ARM数目："></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:DropDownList ID="DropDownList27" runat="server" Height="20px" Width="150px" BackColor="#E6E6E6" ViewStateMode="Inherit">
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                                <asp:ListItem>＞4</asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <div style="height: 30px; width: 400px;clear:both;">
                            <asp:Label ID="Label116" runat="server" Text="SLN类型："></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:DropDownList ID="DropDownList28" runat="server" Height="20px" Width="150px" BackColor="#E6E6E6" ViewStateMode="Inherit">
                                <asp:ListItem>串联：1->1</asp:ListItem>
                                <asp:ListItem>独立</asp:ListItem>
                                <asp:ListItem>串联：1->多</asp:ListItem>
                                <asp:ListItem>融合</asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <div style="height: 30px; width: 400px;clear:both;">
                            <asp:Label ID="Label125" runat="server" Text="SLN病理(冰冻)："></asp:Label>
                            <asp:TextBox ID="TextBox74" runat="server" Height="20px" Width="150px"></asp:TextBox>
                        </div>

                        <div style="height: 30px; width: 400px;clear:both;">
                            <asp:Label ID="Label127" runat="server" Text="操作者："></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="TextBox75" runat="server" Height="20px" Width="150px"></asp:TextBox>
                        </div>
                    </div>
                    </asp:Panel>
                </div>
                </asp:View>

        <%--b4--%>
        <asp:View ID="View12" runat="server">
                <div class="e">
                    <asp:Panel ID="Panel10" runat="server" GroupingText="术后病理" Font-Size="Medium">
                    <div class="b_2_1">
                        <div style="height: 80px; width: 90px;margin-left:10px;float:left;">
                            <asp:RadioButtonList ID="RadioButtonList12" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList12_SelectedIndexChanged">
                                <asp:ListItem>SNL病理</asp:ListItem>
                                <asp:ListItem>ARM病理</asp:ListItem>
                            </asp:RadioButtonList>
                        </div>

                            <div style="height: 40px; width: 450px;margin-left:10px;padding-top:3px;">
                            <asp:TextBox ID="TextBox71" runat="server" Width="90px" Height="20px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                            <asp:Label ID="Label118" runat="server" Text="免疫组化"></asp:Label>
                            <asp:TextBox ID="TextBox73" runat="server" Width="90px" Height="20px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                            <br />
                            <asp:TextBox ID="TextBox72" runat="server" Width="90px" Height="20px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                            <asp:Label ID="Label117" runat="server" Text="免疫组化"></asp:Label>
                            <asp:TextBox ID="TextBox76" runat="server" Width="90px" Height="20px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                            </div>
                    </div>
                    </asp:Panel>

                    <asp:Panel ID="Panel11" runat="server" GroupingText="患肢情况随访" Font-Size="Medium">
                    <div class="b_2_1">
                    <table border="0" cellspacing="0">
                        <tr>
                            
                            <td align="center" width="170px" height="30px"></td>
                            <td align="center" width="70px">术前</td>
                            <td align="center" width="70px">术后1月</td>
                            <td align="center" width="70px">术后3月</td>
                            <td align="center" width="70px">术后6月</td>
                            <td align="center" width="70px">术后1年</td>
                            <td align="center" width="70px">术后2年</td>
                        </tr>
    		            <tr>
    		                <td height="30px">患肢(肘上10cm)/ml</td>
    		            	<td><asp:TextBox ID="TextBox77" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox78" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox79" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox80" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox81" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox82" runat="server" height="30px" width="70px"></asp:TextBox></td>
    		            </tr>
    		            <tr>
    			            <td height="30px">对侧肢(肘上10cm)/ml</td>
    			            <td><asp:TextBox ID="TextBox83" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox84" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox85" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox86" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox87" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox88" runat="server" height="30px" width="70px"></asp:TextBox></td>
    		            </tr>
    		            <tr>
    		        	    <td height="30px">体重/kg</td>
                            <td><asp:TextBox ID="TextBox89" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox90" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox91" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox92" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox93" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox94" runat="server" height="30px" width="70px"></asp:TextBox></td>
    		            </tr>
    		            <tr>
    			           <td height="30px">患肢(肘下10cm)/ml</td>
    			           <td><asp:TextBox ID="TextBox95" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox96" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox97" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox98" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox99" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox100" runat="server" height="30px" width="70px"></asp:TextBox></td>
    		           </tr>
    		           <tr>
    			           <td height="30px">对侧肢(肘下10cm)/ml</td>
    			           <td><asp:TextBox ID="TextBox101" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox102" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox103" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox104" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox105" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox106" runat="server" height="30px" width="70px"></asp:TextBox></td>
    		           </tr>
    		           <tr>
    			           <td height="30px">体重/kg</td>
    			           <td><asp:TextBox ID="TextBox107" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox108" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox109" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox110" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox111" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox112" runat="server" height="30px" width="70px"></asp:TextBox></td>
    		           </tr>
                        <tr>
    			           <td height="30px">患侧手腕/ml</td>
    			           <td><asp:TextBox ID="TextBox113" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox114" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox115" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox116" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox117" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox118" runat="server" height="30px" width="70px"></asp:TextBox></td>
    		           </tr>
                        <tr>
    			            <td height="30px">对侧手腕/ml</td>
    			            <td><asp:TextBox ID="TextBox119" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox120" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox121" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox122" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox123" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox124" runat="server" height="30px" width="70px"></asp:TextBox></td>
    		           </tr>
                        <tr>
    			           <td height="30px">体重/kg</td>
    			           <td><asp:TextBox ID="TextBox125" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox126" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox127" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox128" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox129" runat="server" height="30px" width="70px"></asp:TextBox></td>
                            <td><asp:TextBox ID="TextBox130" runat="server" height="30px" width="70px"></asp:TextBox></td>
    		           </tr>
    	            </table>
                    </div>
                    </asp:Panel>
                </div>
                </asp:View>
        </asp:MultiView>
    </asp:View>

    <%--二级菜单c--%>
    <asp:View ID="View5" runat="server">
        
        <asp:Menu ID="Menu7" runat="server" OnMenuItemClick="Menu7_MenuItemClick" Orientation="Horizontal" BackColor="#fff4f4">
                <Items>
                    <asp:MenuItem Text="术前化疗" Value="1"></asp:MenuItem>
                    <asp:MenuItem Text="术后化疗" Value="2"></asp:MenuItem>
                </Items>

               <LevelMenuItemStyles>
                    <asp:MenuItemStyle Font-Underline="False"  ForeColor="#cc0066"  CssClass="item2" />
                </LevelMenuItemStyles>
                <LevelSelectedStyles>
                    <asp:MenuItemStyle BackColor="White" Font-Underline="False" CssClass="title" ForeColor="Black" BorderStyle="Solid" BorderColor="#ff99ff" BorderWidth="1px" Font-Size="Large" />
                </LevelSelectedStyles>

            </asp:Menu>

        <asp:MultiView ID="MultiView7" runat="server" ActiveViewIndex="0">
        <%--c1--%>
        <asp:View ID="View29" runat="server">
                    <div class="e">
                        <%--<asp:Panel ID="Panel64" runat="server" Font-Size="Small" GroupingText="术前化疗" Height="600px">--%>
                        <asp:Panel ID="Panel64" runat="server" Font-Size="Medium" GroupingText="术前化疗" >
                            <asp:Panel ID="Panel65" runat="server"  Width="100%">
                            
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label322" runat="server" Text="是否接受新辅助化疗"></asp:Label>
                            <asp:RadioButton ID="RadioButton150" runat="server" GroupName="hl" Text="是" AutoPostBack="True" OnCheckedChanged="RadioButton150_CheckedChanged" />
                            <asp:RadioButton ID="RadioButton151" runat="server" GroupName="hl" Text="否" AutoPostBack="True" OnCheckedChanged="RadioButton151_CheckedChanged" />
                            <br /><br />
                            <asp:Panel ID="Panel66" runat="server"  Enabled="False" Width="100%">
                                &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label323" runat="server" Text="共化疗"></asp:Label>
                                <asp:TextBox ID="TextBox268" runat="server" Height="20" Width="50"></asp:TextBox>
                                <asp:Label ID="Label324" runat="server" Text="周期"></asp:Label>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator58" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox268" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                <br /><br />
                                &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label325" runat="server" Text="化疗方案："></asp:Label>
                                <br /><br />
                                <table>
                                    <tr>
                                        <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                        <td>
                                <asp:Label ID="Label326" runat="server" Text="第1周期方案"></asp:Label>
                                &nbsp;&nbsp;
                                            </td>
                                        <td>
                                <asp:DropDownList ID="DropDownList67" runat="server" Height="20" Width="45" BackColor="#E6E6E6">
                                    <asp:ListItem Selected="True"></asp:ListItem>
                                    <asp:ListItem>C</asp:ListItem>
                                    <asp:ListItem>E</asp:ListItem>
                                    <asp:ListItem>F</asp:ListItem>
                                    <asp:ListItem>P</asp:ListItem>
                                    <asp:ListItem>T</asp:ListItem>
                                    <asp:ListItem>Cb</asp:ListItem>
                                </asp:DropDownList><asp:TextBox ID="TextBox269" runat="server" Height="20" Width="40"></asp:TextBox>
                                <asp:Label ID="Label327" runat="server" Text="mg,"></asp:Label>
                                &nbsp;
                                            </td>
                                        <td>
                                <asp:DropDownList ID="DropDownList68" runat="server" Height="20" Width="45" BackColor="#E6E6E6">
                                    <asp:ListItem Selected="True"></asp:ListItem>
                                    <asp:ListItem>C</asp:ListItem>
                                    <asp:ListItem>E</asp:ListItem>
                                    <asp:ListItem>F</asp:ListItem>
                                    <asp:ListItem>P</asp:ListItem>
                                    <asp:ListItem>T</asp:ListItem>
                                    <asp:ListItem>Cb</asp:ListItem>
                                </asp:DropDownList><asp:TextBox ID="TextBox270" runat="server" Height="20" Width="40"></asp:TextBox>
                                <asp:Label ID="Label328" runat="server" Text="mg,"></asp:Label>
                                 &nbsp;
                                            </td>
                                        <td>
                                <asp:DropDownList ID="DropDownList69" runat="server" Height="20" Width="45" BackColor="#E6E6E6">
                                    <asp:ListItem Selected="True"></asp:ListItem>
                                    <asp:ListItem>C</asp:ListItem>
                                    <asp:ListItem>E</asp:ListItem>
                                    <asp:ListItem>F</asp:ListItem>
                                    <asp:ListItem>P</asp:ListItem>
                                    <asp:ListItem>T</asp:ListItem>
                                    <asp:ListItem>Cb</asp:ListItem>
                                </asp:DropDownList><asp:TextBox ID="TextBox271" runat="server" Height="20" Width="40"></asp:TextBox>
                                <asp:Label ID="Label329" runat="server" Text="mg。"></asp:Label>
                                 &nbsp;
                                            </td>
                                        <td style="width: 150px">
                                <asp:Label ID="Label330" runat="server" Text="日期:"></asp:Label>
                                <%--日历修正--%>
                    <asp:TextBox ID="TextBox272" runat="server" Height="20" Width="80"></asp:TextBox>
                    <asp:Image ID="Image9" runat="server" Width="20px" Height="20px" ImageUrl="images_logo/Calendar_logo.png" />
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender9" runat="server" TargetControlID="TextBox272" PopupButtonID="Image9" Format="yyyy-MM-dd" FirstDayOfWeek="Monday"/>

                                </td>
                                </tr>
                                    <tr>
                                        <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                        <td></td>
                                        <td>
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator60" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox269" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                        </td>
                                        <td>
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator61" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox270" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>

                                        </td>
                                        <td>
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator62" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox271" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>

                                        </td>
                                        <td></td>
                                    </tr>
                                </table>

                                &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label331" runat="server" Text="化疗后评估："></asp:Label>
                                <asp:TextBox ID="TextBox273" runat="server" Height="20" Width="50"></asp:TextBox>
                                <asp:Label ID="Label332" runat="server" Text="次"></asp:Label>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator59" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox273" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                <br /><br />

                                &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label333" runat="server" Text="第一次评估,"></asp:Label>
                                &nbsp;&nbsp;
                                <asp:Label ID="Label334" runat="server" Text="日期"></asp:Label>
                                <%--日历修正--%>
                    <asp:TextBox ID="TextBox274" runat="server" Height="20" Width="80"></asp:TextBox>
                    <asp:Image ID="Image10" runat="server" Width="20px" Height="20px" ImageUrl="images_logo/Calendar_logo.png" />
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender10" runat="server" TargetControlID="TextBox274" PopupButtonID="Image10" Format="yyyy-MM-dd" FirstDayOfWeek="Monday"/>

                                <asp:Label ID="Label335" runat="server" Text=", RECIST评估"></asp:Label>
                                <asp:DropDownList ID="DropDownList70" runat="server" Height="20" Width="50" BackColor="#E6E6E6">
                                    <asp:ListItem Selected="True">PD</asp:ListItem>
                                    <asp:ListItem>SD</asp:ListItem>
                                    <asp:ListItem>PR</asp:ListItem>
                                    <asp:ListItem>CR</asp:ListItem>
                                </asp:DropDownList>
                                <asp:Label ID="Label336" runat="server" Text="备注："></asp:Label>
                                <asp:TextBox ID="TextBox275" runat="server" Height="20" Width="100"></asp:TextBox>
                                <br /><br />
                                </asp:Panel>
                            </asp:Panel>
                        </asp:Panel>

                    </div>
                </asp:View>

        <%--c2--%>
        <asp:View ID="View30" runat="server">
                <div class="e">
                    <asp:Panel ID="Panel67" runat="server" Font-Size="Medium" GroupingText="术后化疗">
                        <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label337" runat="server" Text="是否接受术后辅助化疗"></asp:Label>
                        <asp:RadioButton ID="RadioButton152" runat="server" GroupName="c2l" Text="是" OnCheckedChanged="RadioButton152_CheckedChanged" AutoPostBack="True" />
                        <asp:RadioButton ID="RadioButton153" runat="server" GroupName="c2l" Text="否" OnCheckedChanged="RadioButton153_CheckedChanged" AutoPostBack="True" />
                        <br /><br />
                        <asp:Panel ID="Panel68" runat="server"  Width="680px" Enabled="False">
                            &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label338" runat="server" Text="共化疗"></asp:Label>
                            <asp:TextBox ID="TextBox276" runat="server" Height="20" Width="50"></asp:TextBox>
                            <asp:Label ID="Label339" runat="server" Text="周期"></asp:Label>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator66" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox276" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                            <br /><br />
                            &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label340" runat="server" Text="化疗方案："></asp:Label>
                            <br /><br />
                            <table>
                                <tr>
                                    <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                    <td>
                            <asp:Label ID="Label341" runat="server" Text="第1周期方案"></asp:Label>
                            &nbsp;&nbsp;
                                        </td>
                                    <td>
                            <asp:DropDownList ID="DropDownList71" runat="server" Height="20" Width="45" BackColor="#E6E6E6">
                                <asp:ListItem Selected="True"></asp:ListItem>
                                <asp:ListItem>C</asp:ListItem>
                                <asp:ListItem>E</asp:ListItem>
                                <asp:ListItem>F</asp:ListItem>
                                <asp:ListItem>P</asp:ListItem>
                                <asp:ListItem>T</asp:ListItem>
                                <asp:ListItem>Cb</asp:ListItem>
                            </asp:DropDownList><asp:TextBox ID="TextBox277" runat="server" Height="20" Width="40"></asp:TextBox>
                            <asp:Label ID="Label342" runat="server" Text="mg,"></asp:Label>
                            &nbsp;
                                        </td>
                                    <td>
                            <asp:DropDownList ID="DropDownList72" runat="server" Height="20" Width="45" BackColor="#E6E6E6">
                                <asp:ListItem Selected="True"></asp:ListItem>
                                <asp:ListItem>C</asp:ListItem>
                                <asp:ListItem>E</asp:ListItem>
                                <asp:ListItem>F</asp:ListItem>
                                <asp:ListItem>P</asp:ListItem>
                                <asp:ListItem>T</asp:ListItem>
                                <asp:ListItem>Cb</asp:ListItem>
                            </asp:DropDownList><asp:TextBox ID="TextBox278" runat="server" Height="20" Width="40"></asp:TextBox>
                            <asp:Label ID="Label343" runat="server" Text="mg,"></asp:Label>
                                &nbsp;
                                        </td>
                                    <td>
                            <asp:DropDownList ID="DropDownList73" runat="server" Height="20" Width="45" BackColor="#E6E6E6">
                                <asp:ListItem Selected="True"></asp:ListItem>
                                <asp:ListItem>C</asp:ListItem>
                                <asp:ListItem>E</asp:ListItem>
                                <asp:ListItem>F</asp:ListItem>
                                <asp:ListItem>P</asp:ListItem>
                                <asp:ListItem>T</asp:ListItem>
                                <asp:ListItem>Cb</asp:ListItem>
                            </asp:DropDownList><asp:TextBox ID="TextBox279" runat="server" Height="20" Width="40"></asp:TextBox>
                            <asp:Label ID="Label344" runat="server" Text="mg。"></asp:Label>
                                &nbsp;
                                        </td>
                                    <td>
                            <asp:Label ID="Label345" runat="server" Text="日期："></asp:Label>
                            <%--日历修正--%>
                    <asp:TextBox ID="TextBox280" runat="server" Height="20" Width="80"></asp:TextBox>
                    <asp:Image ID="Image11" runat="server" Width="20px" Height="20px" ImageUrl="images_logo/Calendar_logo.png" />
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender11" runat="server" TargetControlID="TextBox280" PopupButtonID="Image11" Format="yyyy-MM-dd" FirstDayOfWeek="Monday"/>

                                    </td>
                                        </tr>
                                    <tr>
                                        <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                        <td></td>
                                        <td>
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator63" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox277" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                        </td>
                                        <td>
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator64" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox278" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>

                                        </td>
                                        <td>
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator65" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox279" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>

                                        </td>
                                        <td></td>
                                    </tr>
                            </table>

                            &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label346" runat="server" Text="化疗不良反应："></asp:Label>
                            <asp:CheckBox ID="CheckBox55" runat="server" Text="血液系统" ValidationGroup="fy" />
                            <asp:CheckBox ID="CheckBox56" runat="server" Text="胃肠道系统" ValidationGroup="fy" />
                            <asp:CheckBox ID="CheckBox57" runat="server" Text="肝功能" ValidationGroup="fy" />
                            <asp:CheckBox ID="CheckBox58" runat="server" Text="肾功能" ValidationGroup="fy" />
                            <asp:CheckBox ID="CheckBox59" runat="server" Text="心功能" ValidationGroup="fy" />
                            <asp:CheckBox ID="CheckBox60" runat="server" Text="糖代谢异常" ValidationGroup="fy" />
                            <asp:CheckBox ID="CheckBox61" runat="server" Text="脂代谢异常" ValidationGroup="fy" />
                            <br /><br />

                            &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label347" runat="server" Text="血液系统："></asp:Label>
                            <asp:DropDownList ID="DropDownList74" runat="server" Height="20" Width="50" BackColor="#E6E6E6">
                                <asp:ListItem Selected="True">急性</asp:ListItem>
                                <asp:ListItem>迟发</asp:ListItem>
                            </asp:DropDownList>
                            &nbsp;
                            <asp:Label ID="Label348" runat="server" Text="表现："></asp:Label>
                            <asp:TextBox ID="TextBox281" runat="server" Height="20" Width="100"></asp:TextBox>
                            <asp:Label ID="Label349" runat="server" Text="处理："></asp:Label>
                            <asp:TextBox ID="TextBox282" runat="server" Height="20" Width="100"></asp:TextBox>
                            <br /><br />
                        </asp:Panel>
                    </asp:Panel>
                </div>
            </asp:View>
        </asp:MultiView>
    </asp:View>

    <%--二级菜单d--%>
    <asp:View ID="View6" runat="server">
        
        <asp:Menu ID="Menu4" runat="server" Orientation="Horizontal" OnMenuItemClick="Menu4_MenuItemClick" BackColor="#fff4f4">
                <Items>
                    <asp:MenuItem Text="一般" Value="1"></asp:MenuItem>
                    <asp:MenuItem Text="乳腺复发转移 " Value="2"></asp:MenuItem>
                    <asp:MenuItem Text="诊疗异常反应 " Value="3"></asp:MenuItem>
                </Items>

                <LevelMenuItemStyles>
                    <asp:MenuItemStyle Font-Underline="False"  ForeColor="#cc0066"  CssClass="item2" />
                </LevelMenuItemStyles>
                <LevelSelectedStyles>
                    <asp:MenuItemStyle BackColor="White" Font-Underline="False" CssClass="title" ForeColor="Black" BorderStyle="Solid" BorderColor="#ff99ff" BorderWidth="1px" Font-Size="Large" />
                </LevelSelectedStyles>

            </asp:Menu>
        
        <asp:MultiView ID="MultiView4" runat="server" ActiveViewIndex="0">
        <%--d1--%>
        <asp:View ID="View13" runat="server">
                <div class="e">
                    <asp:Panel ID="Panel12" runat="server" GroupingText="一般" Font-Size="Medium">
                    <div class="b_2_1">
                        <div style="height: 30px; width: 540px;clear:both;">
                            <asp:Label ID="Label119" runat="server" Text="病理"></asp:Label>&nbsp;
                            <asp:TextBox ID="TextBox131" runat="server" Height="20px" Width="90px"></asp:TextBox>
                            <asp:Label ID="Label121" runat="server" Text="， 淋巴结"></asp:Label>
                            <asp:TextBox ID="TextBox132" runat="server" Height="20px" Width="90px"></asp:TextBox>
                            <asp:Label ID="Label123" runat="server" Text="， 分子类型"></asp:Label>
                            <asp:TextBox ID="TextBox133" runat="server" Height="20px" Width="90px"></asp:TextBox>
                        </div>

                        <div style="height: 40px; width: 590px;clear:both;">
                            <asp:Label ID="Label120" runat="server" Text="术后治疗"></asp:Label>&nbsp;
                            <asp:CheckBox ID="CheckBox1" runat="server" Text="化疗 " TextAlign="Left" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" />
                            <asp:TextBox ID="TextBox134" runat="server" Height="20px" Width="90px" AutoPostBack="True" Enabled="False"></asp:TextBox>&nbsp;&nbsp;&nbsp;
                            <asp:CheckBox ID="CheckBox2" runat="server" Text="放疗 " TextAlign="Left"  AutoPostBack="True" OnCheckedChanged="CheckBox2_CheckedChanged"/>
                            <asp:TextBox ID="TextBox135" runat="server" Height="20px" Width="90px" AutoPostBack="True" Enabled="False"></asp:TextBox>&nbsp;&nbsp;&nbsp;
                            <asp:CheckBox ID="CheckBox3" runat="server" Text="内分泌 " TextAlign="Left" AutoPostBack="True" OnCheckedChanged="CheckBox3_CheckedChanged"/>
                            <asp:TextBox ID="TextBox136" runat="server" Height="20px" Width="90px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                        </div>

                        <div style="height: 40px; width: 590px;clear:both;margin-left:73px">
                            <asp:CheckBox ID="CheckBox4" runat="server" Text="靶向 " TextAlign="Left" AutoPostBack="True" OnCheckedChanged="CheckBox4_CheckedChanged"/>
                            <asp:TextBox ID="TextBox137" runat="server" Height="20px" Width="90px" AutoPostBack="True" Enabled="False"></asp:TextBox>&nbsp;&nbsp;&nbsp;
                            <asp:CheckBox ID="CheckBox5" runat="server" Text="生物治疗 " TextAlign="Left" AutoPostBack="True" OnCheckedChanged="CheckBox5_CheckedChanged"/>
                            <asp:TextBox ID="TextBox138" runat="server" Height="20px" Width="90px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                        </div>
                    </div>
                    </asp:Panel>
                </div>
                </asp:View>

        <%--d2--%>
        <asp:View ID="View14" runat="server">
                <div class="e">
                    <asp:Panel ID="Panel13" runat="server" GroupingText="乳腺复发转移" Font-Size="Medium">
                    <div class="b_2_1">
                        <div style="height: 30px; width: 660px;clear:both;">
                            <asp:Label ID="Label122" runat="server" Text="术后"></asp:Label>&nbsp;
                            <asp:TextBox ID="TextBox139" runat="server" Height="20px" Width="90px"></asp:TextBox>
                            <asp:DropDownList ID="DropDownList29" runat="server" Height="20px" Width="40px" BackColor="#E6E6E6" ViewStateMode="Inherit">
                                <asp:ListItem>年</asp:ListItem>
                                <asp:ListItem>月</asp:ListItem>
                            </asp:DropDownList>&nbsp;&nbsp;
                            <asp:Label ID="Label124" runat="server" Text=" 复查："></asp:Label>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator67" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox139" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                        </div>

                        <table border="0" cellspacing="0">
                        <tr>
                            <td align="left" width="130px" height="30px">
                                <asp:Label ID="Label126" runat="server" Text="查体： 胸壁： "></asp:Label>
                            </td>
                            <td align="left" width="580px" height="30px">
                                <asp:RadioButtonList ID="RadioButtonList17" runat="server" AutoPostBack="True" RepeatDirection="Horizontal" RepeatLayout="Flow" OnSelectedIndexChanged="RadioButtonList17_SelectedIndexChanged">
                                    <asp:ListItem>正常</asp:ListItem>
                                    <asp:ListItem>异常</asp:ListItem>
                                </asp:RadioButtonList>
                                <asp:TextBox ID="TextBox140" runat="server" Height="20px" Width="90px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                                <asp:Label ID="Label132" runat="server" Text="，对侧： "></asp:Label>
                                <asp:RadioButtonList ID="RadioButtonList18" runat="server" AutoPostBack="True" RepeatDirection="Horizontal" RepeatLayout="Flow" OnSelectedIndexChanged="RadioButtonList18_SelectedIndexChanged">
                                    <asp:ListItem>正常</asp:ListItem>
                                    <asp:ListItem>异常</asp:ListItem>
                                </asp:RadioButtonList>
                                <asp:TextBox ID="TextBox145" runat="server" Height="20px" Width="90px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="left" width="130px" height="30px">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="Label129" runat="server" Text="腋下： "></asp:Label>
                            </td>
                            <td align="left" width="650px" height="30px">
                                <asp:RadioButtonList ID="RadioButtonList15" runat="server" AutoPostBack="True" RepeatDirection="Horizontal" RepeatLayout="Flow" OnSelectedIndexChanged="RadioButtonList15_SelectedIndexChanged">
                                    <asp:ListItem>正常</asp:ListItem>
                                    <asp:ListItem>异常</asp:ListItem>
                                </asp:RadioButtonList>
                                <asp:TextBox ID="TextBox142" runat="server" Height="20px" Width="90px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                                <asp:Label ID="Label130" runat="server" Text="，对侧： "></asp:Label>
                                <asp:RadioButtonList ID="RadioButtonList16" runat="server" AutoPostBack="True" RepeatDirection="Horizontal" OnSelectedIndexChanged="RadioButtonList16_SelectedIndexChanged" RepeatLayout="Flow">
                                    <asp:ListItem>正常</asp:ListItem>
                                    <asp:ListItem>异常</asp:ListItem>
                                </asp:RadioButtonList>
                                <asp:TextBox ID="TextBox144" runat="server" Height="20px" Width="90px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                            </td>
                        </tr>
    		            <tr>
                            <td align="left" width="130px" height="30px">
                                <asp:Label ID="Label131" runat="server" Text="胸片： "></asp:Label>
                            </td>
                            <td align="left" width="650px" height="30px">
                                <asp:RadioButtonList ID="RadioButtonList13" runat="server" AutoPostBack="True" RepeatDirection="Horizontal" RepeatLayout="Flow" OnSelectedIndexChanged="RadioButtonList13_SelectedIndexChanged">
                                    <asp:ListItem>正常</asp:ListItem>
                                    <asp:ListItem>异常</asp:ListItem>
                                </asp:RadioButtonList>
                                <asp:TextBox ID="TextBox141" runat="server" Height="20px" Width="90px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                                <asp:CheckBox ID="CheckBox6" runat="server" Text="，进一步检查： " TextAlign="Left" AutoPostBack="True" OnCheckedChanged="CheckBox6_CheckedChanged" />
                                <asp:TextBox ID="TextBox143" runat="server" Height="20px" Width="90px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                                <asp:CheckBox ID="CheckBox7" runat="server" Text="复查 " AutoPostBack="True" TextAlign="Left" OnCheckedChanged="CheckBox7_CheckedChanged" />
                                <asp:TextBox ID="TextBox146" runat="server" Height="20px" Width="30px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                                <asp:Label ID="Label128" runat="server" Text="月"></asp:Label>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator68" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox146" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="left" width="130px" height="30px">
                                <asp:Label ID="Label133" runat="server" Text="BUS： "></asp:Label>
                            </td>
                            <td align="left" width="650px" height="30px">
                                <asp:RadioButtonList ID="RadioButtonList14" runat="server" AutoPostBack="True" RepeatDirection="Horizontal" RepeatLayout="Flow" OnSelectedIndexChanged="RadioButtonList14_SelectedIndexChanged">
                                    <asp:ListItem>正常</asp:ListItem>
                                    <asp:ListItem>异常</asp:ListItem>
                                </asp:RadioButtonList>
                                <asp:TextBox ID="TextBox147" runat="server" Height="20px" Width="90px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                                <asp:CheckBox ID="CheckBox8" runat="server" AutoPostBack="True" Text="，进一步检查： " TextAlign="Left" OnCheckedChanged="CheckBox8_CheckedChanged" />
                                <asp:TextBox ID="TextBox148" runat="server" Height="20px" Width="90px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                                <asp:CheckBox ID="CheckBox9" runat="server" AutoPostBack="True" Text="复查 " TextAlign="Left" OnCheckedChanged="CheckBox9_CheckedChanged" />
                                <asp:TextBox ID="TextBox149" runat="server" Height="20px" Width="30px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                                <asp:Label ID="Label134" runat="server" Text="月"></asp:Label>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator69" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox149" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="left" width="130px" height="30px">
                                <asp:Label ID="Label135" runat="server" Text="肿瘤标志物： "></asp:Label>
                            </td>
                            <td align="left" width="650px" height="30px">
                                <asp:RadioButtonList ID="RadioButtonList19" runat="server" AutoPostBack="True" RepeatDirection="Horizontal" RepeatLayout="Flow" OnSelectedIndexChanged="RadioButtonList19_SelectedIndexChanged">
                                    <asp:ListItem>正常</asp:ListItem>
                                    <asp:ListItem>异常</asp:ListItem>
                                </asp:RadioButtonList>
                                <asp:TextBox ID="TextBox150" runat="server" Height="20px" Width="90px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                                <asp:CheckBox ID="CheckBox10" runat="server" AutoPostBack="True" Text="，进一步检查： " TextAlign="Left" OnCheckedChanged="CheckBox10_CheckedChanged" />
                                <asp:TextBox ID="TextBox151" runat="server" Height="20px" Width="90px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                                <asp:CheckBox ID="CheckBox11" runat="server" AutoPostBack="True" Text="复查 " TextAlign="Left" OnCheckedChanged="CheckBox11_CheckedChanged" />
                                <asp:TextBox ID="TextBox152" runat="server" Height="20px" Width="30px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                                <asp:Label ID="Label136" runat="server" Text="月"></asp:Label>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator70" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox152" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="left" width="130px" height="30px">
                                <asp:Label ID="Label137" runat="server" Text="CT： "></asp:Label>
                            </td>
                            <td align="left" width="650px" height="30px">
                                <asp:RadioButtonList ID="RadioButtonList20" runat="server" AutoPostBack="True" RepeatDirection="Horizontal" RepeatLayout="Flow" OnSelectedIndexChanged="RadioButtonList20_SelectedIndexChanged">
                                    <asp:ListItem>正常</asp:ListItem>
                                    <asp:ListItem>异常</asp:ListItem>
                                </asp:RadioButtonList>
                                <asp:TextBox ID="TextBox153" runat="server" Height="20px" Width="90px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                                <asp:CheckBox ID="CheckBox12" runat="server" AutoPostBack="True" Text="，进一步检查： " TextAlign="Left" OnCheckedChanged="CheckBox12_CheckedChanged" />
                                <asp:TextBox ID="TextBox154" runat="server" Height="20px" Width="90px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                                <asp:CheckBox ID="CheckBox13" runat="server" AutoPostBack="True" Text="复查 " TextAlign="Left" OnCheckedChanged="CheckBox13_CheckedChanged" />
                                <asp:TextBox ID="TextBox155" runat="server" Height="20px" Width="30px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                                <asp:Label ID="Label138" runat="server" Text="月"></asp:Label>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator71" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox155" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="left" width="130px" height="30px">
                                <asp:Label ID="Label139" runat="server" Text="ECT： "></asp:Label>
                            </td>
                            <td align="left" width="650px" height="30px">
                                <asp:RadioButtonList ID="RadioButtonList21" runat="server" AutoPostBack="True" RepeatDirection="Horizontal" RepeatLayout="Flow" OnSelectedIndexChanged="RadioButtonList21_SelectedIndexChanged">
                                    <asp:ListItem>正常</asp:ListItem>
                                    <asp:ListItem>异常</asp:ListItem>
                                </asp:RadioButtonList>
                                <asp:TextBox ID="TextBox156" runat="server" Height="20px" Width="90px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                                <asp:CheckBox ID="CheckBox14" runat="server" AutoPostBack="True" Text="，进一步检查： " TextAlign="Left" OnCheckedChanged="CheckBox14_CheckedChanged" />
                                <asp:TextBox ID="TextBox157" runat="server" Height="20px" Width="90px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                                <asp:CheckBox ID="CheckBox15" runat="server" AutoPostBack="True" Text="复查 " TextAlign="Left" OnCheckedChanged="CheckBox15_CheckedChanged"/>
                                <asp:TextBox ID="TextBox158" runat="server" Height="20px" Width="30px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                                <asp:Label ID="Label140" runat="server" Text="月"></asp:Label>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator72" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox158" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="left" width="130px" height="30px">
                                <asp:Label ID="Label141" runat="server" Text="PET-CT： "></asp:Label>
                            </td>
                            <td align="left" width="650px" height="30px">
                                <asp:RadioButtonList ID="RadioButtonList22" runat="server" AutoPostBack="True" RepeatDirection="Horizontal" RepeatLayout="Flow" OnSelectedIndexChanged="RadioButtonList22_SelectedIndexChanged">
                                    <asp:ListItem>正常</asp:ListItem>
                                    <asp:ListItem>异常</asp:ListItem>
                                </asp:RadioButtonList>
                                <asp:TextBox ID="TextBox159" runat="server" Height="20px" Width="90px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                                <asp:CheckBox ID="CheckBox16" runat="server" AutoPostBack="True" Text="，进一步检查： " TextAlign="Left" OnCheckedChanged="CheckBox16_CheckedChanged" />
                                <asp:TextBox ID="TextBox160" runat="server" Height="20px" Width="90px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                                <asp:CheckBox ID="CheckBox17" runat="server" AutoPostBack="True" Text="复查 " TextAlign="Left" OnCheckedChanged="CheckBox17_CheckedChanged" />
                                <asp:TextBox ID="TextBox161" runat="server" Height="20px" Width="30px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                                <asp:Label ID="Label142" runat="server" Text="月"></asp:Label>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator73" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox161" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="left" width="130px" height="30px">
                                <asp:Label ID="Label143" runat="server" Text="结论： "></asp:Label>
                            </td>
                            <td align="left" width="650px" height="30px">
                                <asp:RadioButtonList ID="RadioButtonList23" runat="server" AutoPostBack="True" RepeatDirection="Horizontal" RepeatLayout="Flow" OnSelectedIndexChanged="RadioButtonList23_SelectedIndexChanged">
                                    <asp:ListItem Value="正常">正常</asp:ListItem>
                                    <asp:ListItem>否</asp:ListItem>
                                </asp:RadioButtonList>
                                <asp:DropDownList ID="DropDownList30" runat="server" Height="20px" Width="80px" BackColor="#E6E6E6" AutoPostBack="True">
                                    <asp:ListItem>复发</asp:ListItem>
                                    <asp:ListItem>转移</asp:ListItem>
                                </asp:DropDownList>
                                <asp:TextBox ID="TextBox162" runat="server" Height="20px" Width="150px" AutoPostBack="True" Enabled="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="left" width="130px" height="30px">
                                <asp:Label ID="Label144" runat="server" Text="治疗： "></asp:Label>
                            </td>
                            <td align="left" width="650px" height="30px">
                                <asp:TextBox ID="TextBox163" runat="server" Height="20px" Width="300px"></asp:TextBox>
                            </td>
                        </tr>
    	            </table>
                    </div>
                    </asp:Panel>
                </div>
                </asp:View>

        <%--d3--%>
        <asp:View ID="View15" runat="server">
                <div class="e">
                    <asp:Panel ID="Panel40" runat="server" GroupingText="诊疗异常反应" Font-Size="Medium">
                        <br />
                        <table style="border-collapse:collapse;border:none;">
                            <tr>
                                <td>UCG:</td>
                                <td>

                                    <asp:RadioButton ID="RadioButton26" runat="server" GroupName="d3.1" Text="正常"   /></td>
                                    <td><asp:RadioButton ID="RadioButton27" runat="server" GroupName="d3.1" Text="异常" />
                                    
                                </td>
                                
                                <td><asp:TextBox ID="TextBox203" runat="server" Height="20px" Width="80px"></asp:TextBox>，</td>
                                <td>结论：<asp:TextBox ID="TextBox204" runat="server" Height="20px" Width="80px"></asp:TextBox>，</td>
                                <td>建议<asp:TextBox ID="TextBox205" runat="server" Height="20px" Width="80px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>肝肾功：</td>
                                <td>
                                    <asp:RadioButton ID="RadioButton28" runat="server" GroupName="d3.2" Text="正常" /></td>
                                    <td><asp:RadioButton ID="RadioButton29" runat="server" GroupName="d3.2" Text="异常" />
                                    
                                </td>
                                <td><asp:TextBox ID="TextBox206" runat="server" Height="20px" Width="80px"></asp:TextBox>，</td>
                                <td>结论：<asp:TextBox ID="TextBox207" runat="server" Height="20px" Width="80px"></asp:TextBox>，</td>
                                <td>建议<asp:TextBox ID="TextBox208" runat="server" Height="20px" Width="80px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>血糖：</td>
                                <td>
                                    <asp:RadioButton ID="RadioButton30" runat="server" GroupName="d3.3" Text="正常" /></td>
                                    <td><asp:RadioButton ID="RadioButton31" runat="server" GroupName="d3.3" Text="异常" />
                                    
                                </td>
                                <td><asp:TextBox ID="TextBox209" runat="server" Height="20px" Width="80px"></asp:TextBox>，</td>
                                <td>结论：<asp:TextBox ID="TextBox210" runat="server" Height="20px" Width="80px"></asp:TextBox>，</td>
                                <td>建议<asp:TextBox ID="TextBox211" runat="server" Height="20px" Width="80px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>血脂：</td>
                                <td>
                                    <asp:RadioButton ID="RadioButton32" runat="server" GroupName="d3.4" Text="正常" /></td>
                                    <td><asp:RadioButton ID="RadioButton33" runat="server" GroupName="d3.4" Text="异常" />
                                   
                                </td>
                                <td><asp:TextBox ID="TextBox212" runat="server" Height="20px" Width="80px"></asp:TextBox>，</td>
                                <td>结论：<asp:TextBox ID="TextBox213" runat="server" Height="20px" Width="80px" ></asp:TextBox>，</td>
                                <td>建议<asp:TextBox ID="TextBox214" runat="server" Height="20px" Width="80px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>骨密度：</td>
                                <td>
                                    <asp:RadioButton ID="RadioButton34" runat="server" GroupName="d3.5" Text="正常" /></td>
                                   <td> <asp:RadioButton ID="RadioButton35" runat="server" GroupName="d3.5" Text="异常" />
                                   
                                </td>
                                <td><asp:TextBox ID="TextBox215" runat="server" Height="20px" Width="80px"></asp:TextBox>，</td>
                                <td>结论：<asp:TextBox ID="TextBox216" runat="server" Height="20px" Width="80px"></asp:TextBox>，</td>
                                <td>建议<asp:TextBox ID="TextBox217" runat="server" Height="20px" Width="80px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>激素水平：</td>
                                <td>
                                    <asp:RadioButton ID="RadioButton36" runat="server" GroupName="d3.6" Text="未绝经" /></td>
                                    <td><asp:RadioButton ID="RadioButton37" runat="server" GroupName="d3.6" Text="绝经" />
                                    
                                </td><td></td>
                                <td >更换内分泌药<asp:TextBox ID="TextBox218" runat="server" Height="20px" Width="80px"></asp:TextBox></td>
                                <td ></td>
                            </tr>
                        </table>
                        <br />
                    </asp:Panel>
                </div>
                </asp:View>
        </asp:MultiView>

        <div style="width:370px; margin:20px auto; ">
        <asp:Button ID="Button8" runat="server" Height="30" Width="110" Text="生成随访问卷" OnClick="Button8_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button12" runat="server" Height="30" Width="85" Text="导入问卷" OnClick="Button12_Click" Visible="False"/>
        </div>
    </asp:View>

    
    <%--二级菜单e--%>
    <asp:View ID="View7" runat="server">
        
        <asp:Menu ID="Menu6" runat="server" OnMenuItemClick="Menu6_MenuItemClick" Orientation="Horizontal" BackColor="#fff4f4">
            <Items>
                <asp:MenuItem Text="根治信息" Value="1"></asp:MenuItem>
                <asp:MenuItem Text="根治术相关" Value="2"></asp:MenuItem>
                <asp:MenuItem Text="手术相关" Value="3"></asp:MenuItem>
            </Items>

               <LevelMenuItemStyles>
                    <asp:MenuItemStyle Font-Underline="False"  ForeColor="#cc0066" CssClass="item2" />
                </LevelMenuItemStyles>
                <LevelSelectedStyles>
                    <asp:MenuItemStyle BackColor="White" Font-Underline="False" CssClass="title" ForeColor="Black" BorderStyle="Solid" BorderColor="#ff99ff" BorderWidth="1px" Font-Size="Large" />
                </LevelSelectedStyles>

        </asp:Menu>
        
        <asp:MultiView ID="MultiView6" runat="server" ActiveViewIndex="0">
        <%--e1页面--%>
        <asp:View ID="View21" runat="server">
                <div class="e">
                    <asp:Panel ID="Panel41" runat="server" GroupingText="基本信息" Font-Size="Medium">
                        <table>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>手术方式：</td>
                                <td >
                                    <asp:RadioButtonList ID="RadioButtonList24" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                        <asp:ListItem>全乳切除</asp:ListItem>
                                        <asp:ListItem>根Ⅰ甲</asp:ListItem>
                                        <asp:ListItem>根Ⅰ乙</asp:ListItem>
                                        <asp:ListItem>根Ⅱ</asp:ListItem>
                                    </asp:RadioButtonList></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>术前诊断：</td>
                                <td>
                                    <asp:RadioButtonList ID="RadioButtonList25" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                        <asp:ListItem>粗针吸</asp:ListItem>
                                        <asp:ListItem>冰冻</asp:ListItem>
                                    </asp:RadioButtonList></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>切口设计：</td>
                                <td>
                                    <asp:RadioButtonList ID="RadioButtonList26" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                        <asp:ListItem>横</asp:ListItem>
                                        <asp:ListItem>纵</asp:ListItem>
                                    </asp:RadioButtonList></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td></td>
                                <td>距肿瘤边缘或切检瘢痕<asp:TextBox ID="TextBox219" runat="server" Width="65px" Height="20px"></asp:TextBox>cm
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator74" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox219" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>皮下打水：</td>
                                <td>
                                    <asp:RadioButtonList ID="RadioButtonList27" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                        <asp:ListItem>有</asp:ListItem>
                                        <asp:ListItem>无</asp:ListItem>
                                    </asp:RadioButtonList></td>
                            </tr>
                        </table>
                    </asp:Panel>
                    <asp:Panel ID="Panel42" runat="server" GroupingText="分离皮瓣" Font-Size="Medium">
                        <table>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>范围：</td>
                                <td>上至<asp:TextBox ID="TextBox220" runat="server" Width="100px" Height="20px"></asp:TextBox>下至<asp:TextBox ID="TextBox221" runat="server" Width="100px" Height="20px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td></td>
                                <td>内至<asp:TextBox ID="TextBox222" runat="server" Width="100px" Height="20px"></asp:TextBox>外至<asp:TextBox ID="TextBox223" runat="server" Width="100px" Height="20px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>厚度：</td>
                                <td>
                                    <asp:RadioButtonList ID="RadioButtonList28" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                        <asp:ListItem>薄</asp:ListItem>
                                        <asp:ListItem>中</asp:ListItem>
                                        <asp:ListItem>厚</asp:ListItem>
                                    </asp:RadioButtonList></td>
                            </tr>
                        </table>
                    </asp:Panel>
                    <asp:Panel ID="Panel43" runat="server" GroupingText="全乳切除" Font-Size="Medium">
                        <table>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>切除</td>
                                <td>
                                    <asp:RadioButtonList ID="RadioButtonList29" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                        <asp:ListItem>保留</asp:ListItem>
                                        <asp:ListItem>部分切除</asp:ListItem>
                                        <asp:ListItem>全切除胸大肌筋膜</asp:ListItem>
                                    </asp:RadioButtonList></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>胸肌受累</td>
                                <td>
                                    <asp:RadioButtonList ID="RadioButtonList30" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                        <asp:ListItem>有</asp:ListItem>
                                        <asp:ListItem>无</asp:ListItem>
                                    </asp:RadioButtonList></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td class="auto-style1">胸大肌部分切</td>
                                 <td class="auto-style1">
                                    <asp:RadioButtonList ID="RadioButtonList31" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                        <asp:ListItem>有</asp:ListItem>
                                        <asp:ListItem>无</asp:ListItem>
                                    </asp:RadioButtonList></td>
                            </tr>
                        </table>
                    </asp:Panel>
                </div>
                </asp:View>

        <%--e2页面--%>
        <asp:View ID="View22" runat="server">
                <div class="e">
                    <asp:Panel ID="Panel46" runat="server" GroupingText="保留胸大小肌" Font-Size="Medium">
                        <table>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>胸肌间脂肪</td>
                                <td>
                                    <asp:RadioButtonList ID="RadioButtonList45" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                        <asp:ListItem>多</asp:ListItem>
                                        <asp:ListItem>中</asp:ListItem>
                                        <asp:ListItem>少</asp:ListItem>
                                    </asp:RadioButtonList></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>切除</td>
                                <td>
                                    <asp:RadioButtonList ID="RadioButtonList46" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                        <asp:ListItem>全部</asp:ListItem>
                                        <asp:ListItem>部分</asp:ListItem>
                                    </asp:RadioButtonList></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>可见肿大淋巴结</td>
                                <td>
                                    <asp:RadioButton ID="RadioButton22" runat="server" Text="有" GroupName="e21" />
                                    <asp:TextBox ID="TextBox232" runat="server" Width="50px" Height="20px"></asp:TextBox>个&nbsp;
                                    <asp:RadioButton ID="RadioButton23" runat="server" Text="无" GroupName="e21" /></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td></td>
                                <td>
                                  &nbsp;&nbsp;&nbsp;&nbsp;   
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator75" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox232" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>胸前神经</td>
                                <td>
                                    <asp:RadioButtonList ID="RadioButtonList47" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                        <asp:ListItem>保留</asp:ListItem>
                                        <asp:ListItem>切除</asp:ListItem>
                                    </asp:RadioButtonList></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>解剖过程</td>
                                <td>
                                    <asp:TextBox ID="TextBox233" runat="server"  Height="20px"></asp:TextBox></td>
                            </tr>
                        </table>
                    </asp:Panel>
                    <asp:Panel ID="Panel47" runat="server" GroupingText="保留胸大肌" Font-Size="Medium">
                        <table>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>胸肌间脂肪</td>
                                <td>
                                    <asp:RadioButtonList ID="RadioButtonList48" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                        <asp:ListItem>多</asp:ListItem>
                                        <asp:ListItem>中</asp:ListItem>
                                        <asp:ListItem>少</asp:ListItem>
                                    </asp:RadioButtonList></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>切除</td>
                                <td>
                                    <asp:RadioButtonList ID="RadioButtonList49" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                        <asp:ListItem>全部</asp:ListItem>
                                        <asp:ListItem>部分</asp:ListItem>
                                    </asp:RadioButtonList></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>可见肿大淋巴结</td>
                                <td><asp:RadioButton ID="RadioButton24" runat="server" Text="有" GroupName="e22" /><asp:TextBox ID="TextBox234" runat="server" Width="50px" Height="20px"></asp:TextBox>个&nbsp;
                                    <asp:RadioButton ID="RadioButton25" runat="server" Text="无" GroupName="e22" /></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td></td>
                                <td>
                                  &nbsp;&nbsp;&nbsp;&nbsp;   
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator76" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox234" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>将胸大肌掀起，胸前神经</td>
                                <td>
                                    <asp:RadioButtonList ID="RadioButtonList50" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                        <asp:ListItem>保留</asp:ListItem>
                                        <asp:ListItem>切除</asp:ListItem>
                                    </asp:RadioButtonList></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td></td>
                                <td>
                                    <asp:CheckBox ID="CheckBox30" runat="server" Text="切断胸小肌喙突端" /></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>解剖过程</td>
                                <td>
                                    <asp:TextBox ID="TextBox235" runat="server" Height="20px"></asp:TextBox></td>
                            </tr>
                        </table>
                    </asp:Panel>
                    <asp:Panel ID="Panel48" runat="server" GroupingText="根治术" Font-Size="Medium">
                        <table>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>胸大肌</td>
                                <td>保留<asp:TextBox ID="TextBox236" runat="server" Width="50px" Height="20px"></asp:TextBox>条，</td>
                                <td>宽约<asp:TextBox ID="TextBox237" runat="server" Width="50px" Height="20px"></asp:TextBox>cm</td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td></td>
                                <td>
                                  &nbsp;&nbsp;&nbsp;&nbsp;   
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator77" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox236" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td>
                                  &nbsp;&nbsp;&nbsp;&nbsp;   
                        <%--一位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator78" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox237" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td></td>
                                <td>
                                    <asp:CheckBox ID="CheckBox31" runat="server" Text="切断胸大肌肱骨端" /></td>
                                <td><asp:CheckBox ID="CheckBox32" runat="server" Text="切断胸小肌喙突端" /></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>解剖过程</td>
                                <td colspan="2">
                                    <asp:TextBox ID="TextBox238" runat="server" Height="20px"></asp:TextBox></td>
                            </tr>
                        </table>
                    </asp:Panel>
                </div>
                </asp:View>

        <%--e3页面--%>
        <asp:View ID="View23" runat="server">
                <div class="e">
                   <asp:Panel ID="Panel44" runat="server" GroupingText="腋下情况" Font-Size="Medium">
                        <table>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td colspan="2">腋脉管带周围肿大淋巴结</td>
                                <td class="auto-style1" colspan="2">
                                    <asp:RadioButtonList ID="RadioButtonList32" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                        <asp:ListItem>有</asp:ListItem>
                                        <asp:ListItem>无</asp:ListItem>
                                    </asp:RadioButtonList></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td></td>
                                <td>肿大淋巴结</td>
                                <td>
                                    <asp:TextBox ID="TextBox224" runat="server" Width="50px" Height="20px"></asp:TextBox>个</td>
                                <td><asp:TextBox ID="TextBox225" runat="server" Width="50px" Height="20px"></asp:TextBox>cm<asp:RadioButtonList ID="RadioButtonList33" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                        <asp:ListItem>软</asp:ListItem>
                                        <asp:ListItem>一般</asp:ListItem>
                                        <asp:ListItem>硬</asp:ListItem>
                                    </asp:RadioButtonList></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td></td>
                                <td></td>
                                <td>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator79" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox224" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td>
                        <%--一位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator80" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox225" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td colspan="2">和腋静脉管或鞘膜粘粒</td>
                                <td colspan="2"><asp:RadioButtonList ID="RadioButtonList34" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                        <asp:ListItem>有</asp:ListItem>
                                        <asp:ListItem>无</asp:ListItem>
                                    </asp:RadioButtonList></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td></td>
                                <td>切除</td>
                                <td colspan="2"><asp:RadioButtonList ID="RadioButtonList35" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                        <asp:ListItem>顺利</asp:ListItem>
                                        <asp:ListItem>困难</asp:ListItem>
                                        <asp:ListItem>无法完全切除</asp:ListItem>
                                    </asp:RadioButtonList></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td colspan="2">腋静脉损伤，缝合切断</td>
                                <td colspan="2"><asp:RadioButtonList ID="RadioButtonList36" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                        <asp:ListItem>有</asp:ListItem>
                                        <asp:ListItem>无</asp:ListItem>
                                    </asp:RadioButtonList></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td colspan="2">腋尖有无可见肿大淋巴结</td>
                                <td><asp:TextBox ID="TextBox226" runat="server" Width="50px" Height="20px"></asp:TextBox>个</td>
                                <td><asp:TextBox ID="TextBox227" runat="server" Width="50px" Height="20px"></asp:TextBox>cm<asp:RadioButtonList ID="RadioButtonList37" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                        <asp:ListItem>软</asp:ListItem>
                                        <asp:ListItem>一般</asp:ListItem>
                                        <asp:ListItem>硬</asp:ListItem>
                                    </asp:RadioButtonList></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td></td>
                                <td></td>
                                <td>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator81" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox226" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td>
                        <%--一位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator82" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox227" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td colspan="2">和锁下静脉鞘粘粒</td>
                                <td colspan="2"><asp:RadioButtonList ID="RadioButtonList38" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                        <asp:ListItem>有</asp:ListItem>
                                        <asp:ListItem>无</asp:ListItem>
                                    </asp:RadioButtonList></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>胸背神经</td>
                                <td><asp:RadioButtonList ID="RadioButtonList39" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                        <asp:ListItem>保留</asp:ListItem>
                                        <asp:ListItem>切除</asp:ListItem>
                                    </asp:RadioButtonList></td>
                                <td colspan="2"></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>胸长神经</td>
                                <td><asp:RadioButtonList ID="RadioButtonList40" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                        <asp:ListItem>保留</asp:ListItem>
                                        <asp:ListItem>切除</asp:ListItem>
                                    </asp:RadioButtonList></td>
                                <td colspan="2"></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>肩胛下脉管</td>
                                <td><asp:RadioButtonList ID="RadioButtonList41" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                        <asp:ListItem>保留</asp:ListItem>
                                        <asp:ListItem>切除</asp:ListItem>
                                    </asp:RadioButtonList></td>
                                <td colspan="2"></td>
                            </tr>
                        </table>
                    </asp:Panel>
                    <asp:Panel ID="Panel45" runat="server" GroupingText="手术信息" Font-Size="Medium">
                        <table>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>负压引流：</td>
                                <td class="auto-style2"><asp:TextBox ID="TextBox228" runat="server" Width="50px" Height="20px"></asp:TextBox>条
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator83" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox228" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>缝合皮肤：</td>
                                <td class="auto-style2">张力<asp:RadioButtonList ID="RadioButtonList42" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                        <asp:ListItem>大</asp:ListItem>
                                        <asp:ListItem>中</asp:ListItem>
                                        <asp:ListItem>小</asp:ListItem>
                                    </asp:RadioButtonList></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td></td>
                                <td class="auto-style2">植皮<asp:RadioButtonList ID="RadioButtonList43" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                        <asp:ListItem>有</asp:ListItem>
                                        <asp:ListItem>无</asp:ListItem>
                                    </asp:RadioButtonList></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td></td>
                                <td class="auto-style2">面积<asp:TextBox ID="TextBox229" runat="server" Width="50px" Height="20px"></asp:TextBox>cm<sup>2</sup>
                        <%--2位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator84" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox229" ValidationExpression="^[0-9]+(.[0-9]{2})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>出血量：</td>
                                <td class="auto-style2"><asp:RadioButtonList ID="RadioButtonList44" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                        <asp:ListItem>多</asp:ListItem>
                                        <asp:ListItem>中</asp:ListItem>
                                        <asp:ListItem>少</asp:ListItem>
                                    </asp:RadioButtonList></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>手术时间：</td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="TextBox230" runat="server" Width="50px" Height="20px"></asp:TextBox>小时<asp:TextBox ID="TextBox231" runat="server" Width="50px" Height="20px"></asp:TextBox>分</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </div>
                </asp:View>
        </asp:MultiView>
    </asp:View>

    <%--二级菜单f--%>
    <asp:View ID="View8" runat="server">
        
        <asp:Menu ID="Menu5" runat="server" OnMenuItemClick="Menu5_MenuItemClick" Orientation="Horizontal" BackColor="#fff4f4">
                <Items>
                    <asp:MenuItem Text="术前信息1" Value="1" Selected="True"></asp:MenuItem>
                    <asp:MenuItem Text="术前信息2" Value="2"></asp:MenuItem>
                    <asp:MenuItem Text="手术信息" Value="3"></asp:MenuItem>
                    <asp:MenuItem Text="术后信息" Value="4"></asp:MenuItem>
                    <asp:MenuItem Text="生活质量及美学指标" Value="5"></asp:MenuItem>
                </Items>

            <LevelMenuItemStyles>
                    <asp:MenuItemStyle Font-Underline="False"  ForeColor="#cc0066" CssClass="item2" />
                </LevelMenuItemStyles>
                <LevelSelectedStyles>
                    <asp:MenuItemStyle BackColor="White" Font-Underline="False" CssClass="title" ForeColor="Black" BorderStyle="Solid" BorderColor="#ff99ff" BorderWidth="1px" Font-Size="Large" />
                </LevelSelectedStyles>

            </asp:Menu>

        <asp:MultiView ID="MultiView5" runat="server" ActiveViewIndex="0">
        <%--f1--%>
        <asp:View ID="View16" runat="server">
                <div class="e">
                    <asp:Panel ID="Panel19" runat="server" GroupingText="体检信息" Font-Size="Medium">
                        <br />
                        <table>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>
                        <asp:Label ID="Label151" runat="server" Text="肿瘤部位（钟表法）："></asp:Label></td>
                                <td>
                        <asp:TextBox ID="TextBox167" runat="server" Height="15px" Width="30px"></asp:TextBox>
                        <asp:Label ID="Label152" runat="server" Text="侧" BorderColor="White"></asp:Label>
                        <asp:TextBox ID="TextBox168" runat="server" Height="15px" Width="30px"></asp:TextBox>
                        <asp:Label ID="Label153" runat="server" Text="点" Height="10px" ></asp:Label> &nbsp&nbsp&nbsp&nbsp</td>
                                <td>
                        <asp:Label ID="Label154" runat="server" Text="肿瘤大小："></asp:Label></td>
                                <td>
                        <asp:TextBox ID="TextBox169" runat="server" Height="15px" Width="30px"></asp:TextBox>
                        <asp:Label ID="Label155" runat="server" Text="×"></asp:Label></td>
                                <td>
                        <asp:TextBox ID="TextBox170" runat="server" Height="15px" Width="30px"></asp:TextBox>
                        <asp:Label ID="Label156" runat="server" Text="cm" ></asp:Label>&nbsp&nbsp&nbsp&nbsp</td>
                                <td>
                        <asp:Label ID="Label157" runat="server" Text="肿瘤与乳头距离："></asp:Label></td>
                                <td>
                        <asp:TextBox ID="TextBox171" runat="server" Height="15px" Width="30px"></asp:TextBox>
                         <asp:Label ID="Label158" runat="server" Text="cm" ></asp:Label></td>
                            </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td>
                        <%--1位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator85" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox169" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td>
                        <%--1位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator86" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox170" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td></td>
                                <td>
                        <%--1位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator87" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox171" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                    <asp:Panel ID="Panel20" runat="server" GroupingText="乳房形态学基线测量" Font-Size="Medium">
                        <div class="e">
                    <asp:Panel ID="Panel21" runat="server" GroupingText="乳房位置测量" CssClass="form" >
                        <br />
                        <table>
                            <tr>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td>
                        <asp:Label ID="Label159" runat="server" Text="胸乳距："></asp:Label></td>
                                <td>
                        <asp:TextBox ID="TextBox172" runat="server" Height="15px" Width="30px"></asp:TextBox>
                        <asp:Label ID="Label160" runat="server" Text="cm" ></asp:Label></td>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td>
                        <asp:Label ID="Label161" runat="server" Text="乳胸距："></asp:Label></td>
                                <td>
                        <asp:TextBox ID="TextBox173" runat="server" Height="15px" Width="30px"></asp:TextBox>
                        <asp:Label ID="Label162" runat="server" Text="cm"></asp:Label></td>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td>
                        <asp:Label ID="Label163" runat="server" Text="锁胸距："></asp:Label></td>
                                <td>
                        <asp:TextBox ID="TextBox174" runat="server" Height="15px" Width="30px"></asp:TextBox>
                        <asp:Label ID="Label164" runat="server" Text="cm" ></asp:Label></td>
                            </tr>
                            <tr>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td></td>
                                <td>
                        <%--1位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator88" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox172" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td></td>
                                <td>
                        <%--1位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator89" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox173" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td></td>
                                <td>
                        <%--1位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator90" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox174" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            </table>
                        <table>
                            <tr>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td>
                        <asp:Label ID="Label165" runat="server" Text="胸骨正中距："></asp:Label></td>
                                <td>
                        <asp:TextBox ID="TextBox175" runat="server" Height="15px" Width="30px"></asp:TextBox>
                        <asp:Label ID="Label166" runat="server" Text="cm" ></asp:Label>
                                    </td>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td>
                        <asp:Label ID="Label167" runat="server" Text="乳头间距：" ></asp:Label></td>
                                <td>
                        <asp:TextBox ID="TextBox176" runat="server" Height="15px" Width="30px"></asp:TextBox>
                        <asp:Label ID="Label168" runat="server" Text="cm"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td></td>
                                <td>
                        <%--1位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator91" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox175" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td></td>
                                <td>
                        <%--1位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator92" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox176" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel></div>
                   <div class="e">
                    <asp:Panel ID="Panel22" runat="server" GroupingText="乳房形态测量" CssClass="form" Font-Size="Medium">
                        <br />
                        <table>
                            <tr>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td>
                        <asp:Label ID="Label169" runat="server" Text="乳房基底横径："></asp:Label></td>
                                <td>
                        <asp:TextBox ID="TextBox177" runat="server" Height="15px" Width="30px"></asp:TextBox>
                        <asp:Label ID="Label170" runat="server" Text="cm"></asp:Label></td>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td>
                        <asp:Label ID="Label171" runat="server" Text="乳房内侧半径："></asp:Label></td>
                                <td>
                        <asp:TextBox ID="TextBox178" runat="server" Height="15px" Width="30px"></asp:TextBox>
                        <asp:Label ID="Label172" runat="server" Text="cm"></asp:Label></td>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td>
                        <asp:Label ID="Label173" runat="server" Text="乳房外侧半径：" ></asp:Label></td>
                                <td>
                        <asp:TextBox ID="TextBox179" runat="server" Height="15px" Width="30px"></asp:TextBox>
                        <asp:Label ID="Label174" runat="server" Text="cm" ></asp:Label></td>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td>
                        <asp:Label ID="Label175" runat="server" Text="乳房下侧半径："></asp:Label></td>
                                <td>
                        <asp:TextBox ID="TextBox180" runat="server" Height="15px" Width="30px"></asp:TextBox>
                        <asp:Label ID="Label176" runat="server" Text="cm"  ></asp:Label></td>
                            </tr>
                            <tr>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td></td>
                                <td>
                        <%--1位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator93" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox177" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td></td>
                                <td>
                        <%--1位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator94" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox178" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td></td>
                                <td>
                        <%--1位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator95" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox179" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td></td>
                                <td>
                        <%--1位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator96" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox180" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                        </table>
                        <table>
                            <tr>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td>
                        <asp:Label ID="Label177" runat="server" Text="乳头至下皱襞体表距离："></asp:Label></td>
                                <td>
                        <asp:TextBox ID="TextBox181" runat="server" Height="15px" Width="30px"></asp:TextBox>
                        <asp:Label ID="Label178" runat="server" Text="cm"  ></asp:Label></td>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td>
                        <asp:Label ID="Label179" runat="server" Text="乳晕直径："></asp:Label></td>
                                <td>
                        <asp:TextBox ID="TextBox182" runat="server" Height="15px" Width="30px"></asp:TextBox>
                        <asp:Label ID="Label180" runat="server" Text="cm" ></asp:Label></td>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td>
                        <asp:Label ID="Label181" runat="server" Text="乳头直径："></asp:Label></td>
                                <td>
                        <asp:TextBox ID="TextBox183" runat="server" Height="15px" Width="30px"></asp:TextBox>
                        <asp:Label ID="Label182" runat="server" Text="cm" ></asp:Label></td>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td>
                        <asp:Label ID="Label183" runat="server" Text="乳房高度：" ></asp:Label></td>
                                <td>
                        <asp:TextBox ID="TextBox184" runat="server" Height="15px" Width="30px" AutoPostBack="True"></asp:TextBox>
                        <asp:Label ID="Label184" runat="server" Text="cm"  ></asp:Label></td>
                        </tr>
                            <tr>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td></td>
                                <td>
                        <%--1位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator97" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox181" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td></td>
                                <td>
                        <%--1位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator98" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox182" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td></td>
                                <td>
                        <%--1位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator99" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox183" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td></td>
                                <td>
                        <%--1位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator100" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox184" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                       </div>

                   <div class="e">
                        <asp:Panel ID="Panel23" runat="server" GroupingText="其他" CssClass="form" Font-Size="Medium">
                        <br />
                        <table>
                            <tr>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td>
                        <asp:Label ID="Label185" runat="server" Text="胸围Ⅰ(经腋下)："  ></asp:Label></td>
                                <td>
                        <asp:TextBox ID="TextBox185" runat="server" Height="15px" Width="30px"></asp:TextBox>
                        <asp:Label ID="Label186" runat="server" Text="cm" ></asp:Label></td>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td>
                        <asp:Label ID="Label187" runat="server" Text="胸围Ⅱ(经乳头)："></asp:Label></td>
                                <td>
                        <asp:TextBox ID="TextBox186" runat="server" Height="15px" Width="30px"></asp:TextBox>
                        <asp:Label ID="Label188" runat="server" Text="cm" ></asp:Label></td>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td>
                        <asp:Label ID="Label189" runat="server" Text="胸围Ⅲ(经下皱襞)：" ></asp:Label></td>
                                <td>
                        <asp:TextBox ID="TextBox187" runat="server" Height="15px" Width="30px"></asp:TextBox>
                        <asp:Label ID="Label190" runat="server" Text="cm" ></asp:Label></td>
                                </tr>
                            <tr>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td></td>
                                <td>
                        <%--1位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator101" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox185" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td></td>
                                <td>
                        <%--1位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator102" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox186" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td></td>
                                <td>
                        <%--1位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator103" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox187" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            </table>
                    </asp:Panel>
                       </div><div class="e">
                    <asp:Panel ID="Panel24" runat="server" GroupingText="乳房体积" CssClass="form" ForeColor="Black" Font-Size="Medium">
                        <br />
                        &nbsp&nbsp&nbsp&nbsp<asp:Label ID="Label191" runat="server" Text="乳房体积=1/3Π×"></asp:Label>
                        <asp:Label ID="Label388" runat="server" Text="乳房高度"></asp:Label>
                        <asp:Label ID="Label389" runat="server" Text=" "></asp:Label> <%--读值--%>
                        <asp:Label ID="Label390" runat="server" Text="²×(3×乳房半径"></asp:Label>

                        <asp:TextBox ID="TextBox188" runat="server" Height="15px" Width="30px"></asp:TextBox><%--乳房半径--%>
                        <asp:Label ID="Label192" runat="server" Text="-乳房高度"></asp:Label>
                        <asp:Label ID="Label392" runat="server" Text=" "></asp:Label><%--读值--%>
                        <asp:Label ID="Label391" runat="server" Text="）="></asp:Label>

                        <asp:TextBox ID="TextBox189" runat="server" Enabled="False" Height="15px" Width="50px"></asp:TextBox><%--点击按钮后计算--%>
                        <asp:Label ID="Label193" runat="server" Text="ml"></asp:Label>
                        &nbsp&nbsp&nbsp&nbsp 
                        <asp:Button ID="Button9" runat="server" Text="更新" CssClass="button" OnClick="Button9_Click"  /><br /><br /><%--OnClick="Button9_Click"--%> <%--第一个公式结束--%>

                        &nbsp&nbsp&nbsp&nbsp<asp:Label ID="Label194" runat="server" Text="乳房体积=250+50×胸围差×（"></asp:Label>
                        <asp:Label ID="Label398" runat="server" Text=" "></asp:Label> <%--读值--%>
                        <asp:Label ID="Label414" runat="server" Text="-"></asp:Label> 
                        <asp:Label ID="Label416" runat="server" Text=" "></asp:Label> <%--读值--%>
                        <asp:Label ID="Label415" runat="server" Text="）+20×超重体重"></asp:Label> 
                        <asp:TextBox ID="TextBox190" runat="server" Height="15px" Width="30px"></asp:TextBox>
                        <asp:Label ID="Label195" runat="server" Text="="></asp:Label> 

                        <asp:TextBox ID="TextBox191" runat="server" Enabled="False" Height="15px" Width="50px"></asp:TextBox><%--点击按钮后计算--%>
                        <asp:Label ID="Label196" runat="server" Text="ml" ></asp:Label>
                        &nbsp&nbsp&nbsp&nbsp 
                        <asp:Button ID="Button10" runat="server" Text="更新" CssClass="button" OnClick="Button10_Click" />
                        <br /><br />
                    </asp:Panel></div>
                    </asp:Panel>
                </div>
                </asp:View>

        <%--f2--%>
        <asp:View ID="View17" runat="server">
                <div class="e">
                    <asp:Panel ID="Panel25" runat="server" GroupingText="影像信息" CssClass="from2" Font-Size="Medium">
                        <asp:TextBox ID="f2Tb1" runat="server" Height="100px" Width="700px" TextMode="MultiLine"></asp:TextBox>

                    </asp:Panel>

                    <asp:Panel ID="Panel26" runat="server" GroupingText="诊断信息" CssClass="from2" Font-Size="Medium">
                        <asp:TextBox ID="f2Tb2" runat="server" Height="100px" Width="700px" TextMode="MultiLine"></asp:TextBox>

                    </asp:Panel>
                    <asp:Panel ID="Panel27" runat="server" GroupingText="治疗信息" CssClass="from2" Font-Size="Medium">
                        <asp:TextBox ID="f2Tb3" runat="server" Height="100px" Width="700px" TextMode="MultiLine"></asp:TextBox>

                    </asp:Panel>
                </div>
                </asp:View>

        <%--f3--%>
        <asp:View ID="View18" runat="server">
                <div class="e">
                    <asp:Panel ID="Panel28" runat="server" GroupingText="&nbsp;手术信息" Font-Size="Medium">
                        <br />
                       <div class="inline"> &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label197" runat="server" Text="切口类型："></asp:Label>
                           <asp:RadioButton ID="RadioButton1" runat="server" Text="放射型" GroupName="f31"  /> &nbsp;&nbsp;&nbsp;&nbsp;
                           <asp:RadioButton ID="RadioButton2" runat="server" Text="弧形（垂直于放射型）" GroupName="f31" /> &nbsp;&nbsp;&nbsp;&nbsp;
                           <asp:RadioButton ID="RadioButton3" runat="server" Text="其他 &nbsp"  GroupName="f31" OnCheckedChanged="RadioButton3_CheckedChanged" AutoPostBack="True" />
                           <asp:TextBox ID="TextBox310" runat="server" Enabled="False"></asp:TextBox>
                       </div>
                        <br /><br />
                        <div class="inline">
                            <table>
                                <tr>
                                    <td>
                            &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                    <td>
                            <asp:Label ID="Label198" runat="server" Text="标本大小："></asp:Label>
                            <asp:Label ID="Label199" runat="server" Text="横径"></asp:Label></td>
                                    <td>
                            <asp:TextBox ID="TextBox192" runat="server" Height="15px" Width="30px"></asp:TextBox>
                            <asp:Label ID="Label200" runat="server" Text="cm"></asp:Label></td>
                                    <td>
                             &nbsp;&nbsp;&nbsp;&nbsp; </td>
                                    <td>
                            <asp:Label ID="Label201" runat="server" Text="纵径"></asp:Label></td>
                                    <td>
                            <asp:TextBox ID="TextBox193" runat="server" Height="15px" Width="30px"></asp:TextBox>
                            <asp:Label ID="Label202" runat="server" Text="cm"></asp:Label></td>
                                    <td>
                             &nbsp;&nbsp;&nbsp;&nbsp; </td>
                                    <td>
                            <asp:Label ID="Label203" runat="server" Text="体积(排水法)"></asp:Label></td>
                                    <td>
                            <asp:TextBox ID="TextBox194" runat="server" Height="15px" Width="30px"></asp:TextBox>
                            <asp:Label ID="Label204" runat="server" Text="ml"></asp:Label></td>
                                    </tr>
                            <tr>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td></td>
                                <td>
                        <%--1位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator104" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox192" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td></td>
                                <td>
                        <%--1位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator105" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox193" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td>&nbsp&nbsp&nbsp&nbsp</td>
                                <td></td>
                                <td>
                        <%--1位小数--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator106" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox194" ValidationExpression="^[0-9]+(.[0-9]{1})?$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                                </table>
                        </div><br /><br />
                        <div>
                            &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label205" runat="server" Text="切缘病理："></asp:Label>
                            <asp:RadioButton ID="RadioButton4" runat="server" GroupName="f32" Text="阴性" /> &nbsp&nbsp&nbsp&nbsp  &nbsp&nbsp&nbsp&nbsp 
                            <asp:RadioButton ID="RadioButton5" runat="server" GroupName="f32" Text="阳性" />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label206" runat="server" Text="位置(按照钟表标准化)"></asp:Label>
                            <asp:TextBox ID="TextBox195" runat="server" Height="15px" Width="30px"></asp:TextBox>
                            <asp:Label ID="Label207" runat="server" Text="点"></asp:Label>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator107" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox195" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                        </div>
                        <div >
                            <br />&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label208" runat="server" Text="是否二次扩切："></asp:Label>
                            <asp:RadioButton ID="RadioButton6" runat="server" GroupName="f33" Text="否"  AutoPostBack="True" OnCheckedChanged="RadioButton6_CheckedChanged"/> 
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp 
                            <asp:RadioButton ID="RadioButton7" runat="server" GroupName="f33" Text="是" OnCheckedChanged="RadioButton7_CheckedChanged" AutoPostBack="True" /><br />
                            <asp:Panel ID="Panel29" runat="server">
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="Label209" runat="server" Text="二次切缘病理："></asp:Label>
                                <asp:RadioButton ID="RadioButton8" runat="server" GroupName="f34" Text="阴性" Enabled="False" /> &nbsp&nbsp&nbsp&nbsp  &nbsp&nbsp&nbsp&nbsp 
                                <asp:RadioButton ID="RadioButton9" runat="server" GroupName="f34" Text="阳性" Enabled="False" />
                                <br /> &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="Label210" runat="server" Text="位置(按照钟表标准化)"></asp:Label>
                                <asp:TextBox ID="TextBox196" runat="server" Height="15px" Width="30px" Enabled="False"></asp:TextBox>
                                <asp:Label ID="Label211" runat="server" Text="点"></asp:Label>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator108" runat="server" ErrorMessage="*输入有误" ControlToValidate="TextBox196" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                            </asp:Panel>
                        </div><br/>

                        <div>
                            &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label212" runat="server" Text="保乳术是否成功："></asp:Label>
                            <asp:RadioButton ID="RadioButton10" runat="server" GroupName="f35" Text="是" /> &nbsp&nbsp&nbsp&nbsp  &nbsp&nbsp&nbsp&nbsp 
                            <asp:RadioButton ID="RadioButton11" runat="server" GroupName="f35" Text="否" /><br />
                        </div><br />

                        <div>
                            &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label213" runat="server" Text="前哨淋巴结活检："></asp:Label>
                            <asp:RadioButton ID="RadioButton12" runat="server" GroupName="f36" Text="是" /> &nbsp&nbsp&nbsp&nbsp  &nbsp&nbsp&nbsp&nbsp 
                            <asp:RadioButton ID="RadioButton13" runat="server" GroupName="f36" Text="否" /><br />
                        </div><br />

                        <div>
                            &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label214" runat="server" Text="是否保乳整形："></asp:Label>&nbsp&nbsp&nbsp
                            <asp:RadioButton ID="RadioButton14" runat="server" GroupName="f37" Text="否" AutoPostBack="True" OnCheckedChanged="RadioButton14_CheckedChanged"/> &nbsp&nbsp&nbsp&nbsp  &nbsp&nbsp&nbsp&nbsp 
                            <asp:RadioButton ID="RadioButton15" runat="server" GroupName="f37" Text="是" AutoPostBack="True" OnCheckedChanged="RadioButton15_CheckedChanged"/>&nbsp&nbsp&nbsp&nbsp  &nbsp&nbsp&nbsp&nbsp 
                            <asp:Label ID="Label215" runat="server" Text="整形方式"></asp:Label>
                            <asp:TextBox ID="TextBox311" runat="server" Enabled="False"></asp:TextBox>
                            <br /><br />
                        </div>
                    </asp:Panel>
                </div>
                </asp:View>

        <%--f4--%>
        <asp:View ID="View19" runat="server">
                <div class="e">
                    <asp:Panel ID="Panel30" runat="server" GroupingText="术后信息" Font-Size="Medium">
                        <br />
                        <table>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>
                        <asp:Label ID="Label216" runat="server" Text="引流时间(天)"></asp:Label></td>
                                <td>
                        <asp:TextBox ID="f4Tb1" runat="server" Height="15px" Width="80px"></asp:TextBox></td>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>
                        <asp:Label ID="Label217" runat="server" Text="引流总量(ml)"></asp:Label></td>
                                <td>
                        <asp:TextBox ID="f4Tb2" runat="server" Height="15px" Width="80px"></asp:TextBox></td>
                                </tr>
                            <tr>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td></td>
                                <td>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator109" runat="server" ErrorMessage="*输入有误" ControlToValidate="f4Tb1" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                                <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td></td>
                                <td>
                        <%--纯数字--%>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator110" runat="server" ErrorMessage="*输入有误" ControlToValidate="f4Tb2" ValidationExpression="^[0-9]*$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                        </table>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label218" runat="server" Text="是否术后感染："></asp:Label>
                        &nbsp&nbsp&nbsp
                        <asp:RadioButton ID="f4Rb1" runat="server" GroupName="f41" Text="否" AutoPostBack="True" OnCheckedChanged="RadioButton16_CheckedChanged"/>
                        &nbsp&nbsp&nbsp&nbsp  &nbsp&nbsp&nbsp&nbsp 
                        <asp:RadioButton ID="f4Rb2" runat="server" GroupName="f41" Text="是" AutoPostBack="True" OnCheckedChanged="RadioButton17_CheckedChanged"/>
                        &nbsp&nbsp&nbsp&nbsp  &nbsp&nbsp&nbsp&nbsp 
                        <asp:Label ID="Label219" runat="server" Text="处理方式"></asp:Label>
                        <asp:TextBox ID="f4Tb3" runat="server" Enabled="False"></asp:TextBox>
                        <br /><br />
                    </asp:Panel>

                    <asp:Panel ID="Panel31" runat="server" GroupingText="术后放疗" Height="270px" Font-Size="Medium">
                        <asp:TextBox ID="f4Tb4" runat="server" Height="100px" Width="700px" TextMode="MultiLine"></asp:TextBox>
                    </asp:Panel>
                </div>
                </asp:View>

        <%--f5--%>
        <asp:View ID="View20" runat="server">
                <div class="e">
                    <asp:Panel ID="Panel32" runat="server" GroupingText="主观美容及功能评估" Font-Size="Medium">
                        <asp:Panel ID="Panel33" runat="server" ScrollBars="Vertical" Width="100%" height="680px">
                        <div class="e"><asp:Panel ID="Panel34" runat="server" GroupingText="Harris分级标准评估" CssClass="form" Font-Size="Medium">
                        
                            <table id="table1" style="border-top-width: 3px; border-style: solid none solid none; border-spacing: 0; border-left-width: 5px; border-color: #C0C0C0; margin-left: 15px; width: auto;" class="form">
  <tr>
     <td style="border-width: thin;border-spacing: 0; border-color: #C0C0C0; text-align: center; border-right-style: solid; border-bottom-style: solid;">分级</td>
     <td style=" border-width: thin;border-spacing: 0; border-color: #C0C0C0; text-align: center; border-bottom-style: solid;">标准</td>
   </tr>
   <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0" ><asp:RadioButton ID="RadioButton18" runat="server" Text="非常好"  GroupName="f52" /></td>
     <td><asp:Label ID="Label220" runat="server" Text="非常好的对称性，无可见的畸变和皮肤改变。"></asp:Label></td>
   </tr>
   <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0"><asp:RadioButton ID="RadioButton19" runat="server" Text="很好"  GroupName="f52" /></td>
     <td><asp:Label ID="Label221" runat="server" Text="轻微的皮肤改变、退缩或水肿；轻微的毛细血管扩张，轻微的色素沉着，或乳头乳晕复合体缺失。"></asp:Label></td>
   </tr>
   <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0" class="auto-style3"><asp:RadioButton ID="RadioButton20" runat="server" Text="一般" GroupName="f52" /></td>
     <td class="auto-style3" ><asp:Label ID="Label222" runat="server" Text="中度的乳头或乳房对称性畸变，中度的色素沉着，明显的皮肤退缩、水肿或毛细血管扩张。"></asp:Label></td>
   </tr>
   <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0"><asp:RadioButton ID="RadioButton21" runat="server" Text="较差" GroupName="f52" /></td>
     <td ><asp:Label ID="Label223" runat="server" Text="明显的畸变、水肿或纤维化，或者严重的色素沉着。"></asp:Label></td>
   </tr>
    </table> 
     <asp:Label ID="Label224" runat="server" Text="注：非常好=0，很好=1，一般=2，较差=3" Font-Size="Small"></asp:Label><br />

                        </asp:Panel></div>
                       
                        <div class="e"><asp:Panel ID="Panel35" runat="server" GroupingText="BCTOS美容及功能评分" CssClass="form" Font-Size="Medium">
   <asp:Panel ID="Panel36" runat="server" ScrollBars="Vertical" Height="150px" CssClass="form" >
                            <table id="table2" style="padding: 5px; border-top-width: 3px; border-style: solid none solid none; border-spacing: 0; border-left-width: 5px; border-color: #C0C0C0; margin-left: 15px;" class="form">
   <tr>
     <td style="border-right: thin solid #C0C0C0; border-bottom: thin solid #C0C0C0; border-spacing: 0; text-align: center; border-left-color: #C0C0C0; border-left-width: thin; border-top-color: #C0C0C0; border-top-width: thin; width: 240px;" class="auto-style5" >项目</td>
     <td style=" border-width: thin;border-spacing: 0; border-color: #C0C0C0; text-align: center; border-bottom-style: solid;" class="auto-style4">ND</td>
       <td style=" border-width: thin;border-spacing: 0; border-color: #C0C0C0; text-align: center; border-bottom-style: solid;" class="auto-style4">SD</td>
       <td style=" border-width: thin;border-spacing: 0; border-color: #C0C0C0; text-align: center; border-bottom-style: solid;" class="auto-style4">MD</td>
       <td style=" border-width: thin;border-spacing: 0; border-color: #C0C0C0; text-align: center; border-bottom-style: solid;" class="auto-style4">LD</td>
   </tr>
   <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0; width: 240px;" ><asp:Label ID="Label225" runat="server" Text="乳房大小"></asp:Label></td>
     <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList51" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="ND" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="SD" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="MD" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="LD" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>
    <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0; width: 240px;" ><asp:Label ID="Label394" runat="server" Text="乳房质地(有无硬化)"></asp:Label></td>
     <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList82" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="ND" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="SD" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="MD" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="LD" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>
   
   <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0; width: 240px;" class="auto-style3"><asp:Label ID="Label226" runat="server" Text="乳房形状"></asp:Label></td>
      <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList52" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="ND" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="SD" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="MD" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="LD" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>
  
         <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0; width: 240px;" class="auto-style3" ><asp:Label ID="Label227" runat="server" Text="乳房挺度（高度）"></asp:Label></td>
   
          <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList53" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="ND" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="SD" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="MD" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="LD" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>

         <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0; width: 240px;" class="auto-style3" ><asp:Label ID="Label228" runat="server" Text="乳房皮肤颜色"></asp:Label></td>
      <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList54" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="ND" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="SD" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="MD" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="LD" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>

         <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0; width: 240px;" class="auto-style3" ><asp:Label ID="Label229" runat="server" Text="乳房敏感度（感觉）"></asp:Label></td>
      <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList55" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="ND" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="SD" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="MD" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="LD" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>

        <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0; width: 240px;" class="auto-style3" ><asp:Label ID="Label230" runat="server" Text="乳房外观"></asp:Label></td>
      <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList56" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="ND" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="SD" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="MD" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="LD" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>
        
         <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0; width: 240px;" class="auto-style3" ><asp:Label ID="Label231" runat="server" Text="瘢痕组织"></asp:Label></td>
       <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList57" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="ND" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="SD" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="MD" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="LD" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>

         <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0; width: 240px;" class="auto-style3" ><asp:Label ID="Label232" runat="server" Text="乳房肿胀"></asp:Label></td>
        <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList58" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="ND" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="SD" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="MD" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="LD" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>

         <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0; width: 240px;" class="auto-style3" ><asp:Label ID="Label233" runat="server" Text="乳房疼痛"></asp:Label></td>
      <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList59" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="ND" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="SD" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="MD" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="LD" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>

         <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0; width: 240px;" class="auto-style3" ><asp:Label ID="Label234" runat="server" Text="乳房触感（有无触痛）"></asp:Label></td>
     <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList60" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="ND" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="SD" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="MD" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="LD" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>

         <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0; width: 240px;" class="auto-style3" ><asp:Label ID="Label235" runat="server" Text="肩部疼痛"></asp:Label></td>
      <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList61" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="ND" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="SD" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="MD" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="LD" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>

         <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0; width: 240px;" class="auto-style3" ><asp:Label ID="Label236" runat="server" Text="肩部僵硬"></asp:Label></td>
       <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList62" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="ND" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="SD" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="MD" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="LD" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>

         <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0; width: 240px;" class="auto-style3" ><asp:Label ID="Label237" runat="server" Text="肩部活动"></asp:Label></td>
      <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList63" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="ND" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="SD" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="MD" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="LD" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>

         <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0; width: 240px;" class="auto-style3" ><asp:Label ID="Label238" runat="server" Text="上肢疼痛"></asp:Label></td>
       <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList64" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="ND" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="SD" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="MD" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="LD" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>

         <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0; width: 240px;" class="auto-style3" ><asp:Label ID="Label239" runat="server" Text="上肢僵硬"></asp:Label></td>
       <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList65" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="ND" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="SD" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="MD" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="LD" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>

         <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0; width: 240px;" class="auto-style3"><asp:Label ID="Label240" runat="server" Text="上肢活动"></asp:Label></td>
        <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList66" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="ND" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="SD" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="MD" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="LD" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>

         <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0; width: 240px;" class="auto-style3" ><asp:Label ID="Label241" runat="server" Text="上肢肿胀"></asp:Label></td>
      <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList67" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="ND" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="SD" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="MD" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="LD" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>

         <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0; width: 240px;" class="auto-style3" ><asp:Label ID="Label242" runat="server" Text="提举重物的能力"></asp:Label></td>
        <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList68" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="ND" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="SD" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="MD" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="LD" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>

         <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0; width: 240px;" class="auto-style3"><asp:Label ID="Label243" runat="server" Text="肋部疼痛"></asp:Label></td>
       <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList69" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="ND" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="SD" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="MD" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="LD" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>

        <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0; width: 240px;" class="auto-style3"><asp:Label ID="Label244" runat="server" Text="乳罩的合适度"></asp:Label></td>
       <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList70" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="ND" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="SD" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="MD" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="LD" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>

        <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0; width: 240px;" class="auto-style3" ><asp:Label ID="Label245" runat="server" Text="衣服的合适度"></asp:Label></td>
       <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList71" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="ND" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="SD" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="MD" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="LD" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>
    </table> </asp:Panel>
     <asp:Label ID="Label246" runat="server" Text="注：ND(=0):No Difference,与对侧相比无区别；SD(=1):Slight Difference，与对侧相比有轻微区别；MD(=2):Moderate Difference,与对侧相比有中度区别；LD(=3):Large Difference,与对侧相比有很大区别。" Font-Size="Small"></asp:Label><br />
      </asp:Panel></div>
                       
                        <div class="e"><asp:Panel ID="Panel37" runat="server" GroupingText="BIS身体形象评分" CssClass="form" Font-Size="Medium">
 <asp:Panel ID="Panel38" runat="server" ScrollBars="Vertical" Height="150px" CssClass="form" Width="100%">
            <table id="table3" style="border-top-width: 3px; border-style: solid none solid none; border-spacing: 0; border-left-width: 5px; border-color: #C0C0C0; width: 89%; margin-left: 15px;" class="form">
   <tr>
     <td style="border-width: thin;border-spacing: 0; border-color: #C0C0C0; text-align: center; border-right-style: solid; border-bottom-style: solid; width: 220px;" >项目</td>
     <td style=" border-width: thin;border-spacing: 0; border-color: #C0C0C0; text-align: center; border-bottom-style: solid;" class="auto-style4">&nbsp;&nbsp;一点也不</td>
       <td style=" border-width: thin;border-spacing: 0; border-color: #C0C0C0; text-align: center; border-bottom-style: solid;" class="auto-style4">有一点</td>
       <td style=" border-width: thin;border-spacing: 0; border-color: #C0C0C0; text-align: center; border-bottom-style: solid;" class="auto-style4">相当多</td>
       <td style=" border-width: thin;border-spacing: 0; border-color: #C0C0C0; text-align: center; border-bottom-style: solid;" class="auto-style4">非常</td>
   </tr>
   <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0" ><asp:Label ID="Label247" runat="server" Text="您经常对您的形象很在意吗？"></asp:Label></td>
     <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList72" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="一点也不" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="有一点" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="相当多" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="非常" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>
   
   <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0" class="auto-style3"><asp:Label ID="Label248" runat="server" Text="您感到因为您的疾病或治疗，导致您在身体上的吸引力不如从前了吗？"></asp:Label></td>
      <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList73" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="一点也不" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="有一点" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="相当多" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="非常" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>
  
         <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0" class="auto-style3"><asp:Label ID="Label249" runat="server" Text="在您着装后，您对您的形象有不满意吗？"></asp:Label></td>
     <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList74" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="一点也不" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="有一点" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="相当多" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="非常" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>

         <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0" class="auto-style3"><asp:Label ID="Label250" runat="server" Text="您感到因为您的疾病或治疗，导致您的女性气质降低吗？"></asp:Label></td>
      <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList75" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="一点也不" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="有一点" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="相当多" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="非常" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>

         <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0" class="auto-style3"><asp:Label ID="Label251" runat="server" Text="您感到很难面对您的裸体吗？"></asp:Label></td>
      <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList76" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="一点也不" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="有一点" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="相当多" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="非常" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>

        <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0" class="auto-style3"><asp:Label ID="Label252" runat="server" Text="您感到因为您的疾病或治疗，导致您的吸引力降低吗？"></asp:Label></td>
      <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList77" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="一点也不" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="有一点" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="相当多" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="非常" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>
        
         <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0" class="auto-style3"><asp:Label ID="Label253" runat="server" Text="您有因为您的形象而躲避人群吗？"></asp:Label></td>
      <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList78" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="一点也不" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="有一点" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="相当多" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="非常" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>

         <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0" class="auto-style3"><asp:Label ID="Label254" runat="server" Text="您感到因为您的治疗而导致您的身体不完整吗？"></asp:Label></td>
      <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList79" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="一点也不" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="有一点" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="相当多" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="非常" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>

         <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0" class="auto-style3"><asp:Label ID="Label255" runat="server" Text="您对您的身体有不满意吗？"></asp:Label></td>
    <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList80" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="一点也不" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="有一点" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="相当多" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="非常" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>

         <tr style="border-style: groove none solid none; border-bottom-width: 2px; border-top-width: 5px; border-color: #C0C0C0">
     <td style="border-right-style: solid; border-width: thin; border-spacing: 0;border-color: #C0C0C0" class="auto-style3"><asp:Label ID="Label256" runat="server" Text="您对您的伤疤的外观有不满意吗？"></asp:Label></td>
     <td  style="text-align: center;"colspan="4" class="auto-style4">
         <asp:RadioButtonList ID="RadioButtonList81" runat="server" RepeatDirection="Horizontal"  RepeatColumns="4"  Width="480px" ForeColor="White" TextAlign="Left">
             <asp:ListItem  Text="一点也不" Value="0"> </asp:ListItem>
             <asp:ListItem  Text="有一点" Value="1"> </asp:ListItem>
             <asp:ListItem  Text="相当多" Value="2"> </asp:ListItem>
             <asp:ListItem  Text="非常" Value="3"> </asp:ListItem>
         </asp:RadioButtonList>
     </td>
   </tr>
  
    </table> </asp:Panel>
     <asp:Label ID="Label257" runat="server" Text="注：一点也不=0；有一点=1；相当多=2；非常=3" Font-Size="Small"></asp:Label><br />
      
      </asp:Panel></div>

                        <div class="e"><asp:Panel ID="Panel39" runat="server" GroupingText="客观美容及功能评估" CssClass="form" Font-Size="Medium">
          <br />
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Label ID="Label258" runat="server" Text="对患侧及健侧乳房体积的评估-体积变化VD(%)="></asp:Label>
          <asp:TextBox ID="TextBox199" runat="server"></asp:TextBox>
          <br /><br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Label ID="Label259" runat="server" Text="乳房对称性的评估-乳头对称性的变化ND(%)="></asp:Label>
          <asp:TextBox ID="TextBox200" runat="server"></asp:TextBox>
          <br /><br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Label ID="Label260" runat="server" Text="纤维化的评估-增厚或硬化的组织占乳房的体积比F(%)="></asp:Label>
          <asp:TextBox ID="TextBox201" runat="server"></asp:TextBox>
          <br /><br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Label ID="Label261" runat="server" Text="毛细血管扩张的评估-毛细血管扩张占乳房皮肤的比例T(%)"></asp:Label>
          <asp:TextBox ID="TextBox202" runat="server"></asp:TextBox>
          <br /><br />
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button11" runat="server" Text="计算：" /><br /><br />
      </asp:Panel></div>
           </asp:Panel>             
      </asp:Panel>
                </div>
                </asp:View>
        </asp:MultiView>
    </asp:View>
    </asp:MultiView>

    </asp:Panel>
    </div>
    </div>
    </asp:Panel>

    <%--页面右边底部按钮--%>
    <div class="btn">
        <br/>
        <asp:Button ID="Button1" runat="server" Text="确定" Height="30" Width="50" OnClick="Button1_Click" />
        <asp:Button ID="Button7" runat="server" Text="更新" Height="30" Width="50" OnClick="Button7_Click" Visible="False" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="取消" Height="30" Width="50" OnClick="Button2_Click" />
    </div>

    <asp:Panel ID="Panel90" runat="server" Visible="False">
   <%--插入数据库检验--%>
    <div>
    <asp:Label ID="Label43" runat="server"  Text="Label" ></asp:Label><br /><%--a1--%>
    <asp:Label ID="Label44" runat="server"  Text="Label" ></asp:Label><br /><%--a4--%>
    <asp:Label ID="Label145" runat="server"  Text="Label" ></asp:Label><br /><%--b1--%>
    <asp:Label ID="Label146" runat="server"  Text="Label" ></asp:Label><br /><%--b2--%>
    <asp:Label ID="Label147" runat="server"  Text="Label" ></asp:Label><br /><%--b3--%>
    <asp:Label ID="Label148" runat="server"  Text="Label" ></asp:Label><br /><%--b4--%>
    <asp:Label ID="Label149" runat="server"  Text="Label" ></asp:Label><br /><%--d1--%>
    <asp:Label ID="Label150" runat="server"  Text="Label" ></asp:Label><br /><%--d2--%>

    <%-- 显示f五个页面是否读入数据库成功, f2无内容！--%>
    <asp:Label ID="Label399" runat="server" Text="Label" ></asp:Label><br /><%--f1--%>
    <asp:Label ID="f2LbInsert" runat="server" Text="Label" ></asp:Label><br /><%--f2--%>
    <asp:Label ID="Label400" runat="server" Text="Label" ></asp:Label><br /><%--f3--%>
    <asp:Label ID="Label401" runat="server" Text="Label" ></asp:Label><br /><%--f4--%>
    <asp:Label ID="Label402" runat="server" Text="Label" ></asp:Label><br /><%--f5--%>

    <%--对鸿鸿建的四个数据库进行检验--%>
    <br /><br /><br />
    <asp:Label ID="Label403" runat="server" Text="Label" ></asp:Label><br /><%--d3--%>
    <asp:Label ID="Label404" runat="server" Text="Label"></asp:Label><br /><%--e1--%>
    <asp:Label ID="Label405" runat="server" Text="Label" ></asp:Label><br /><%--e2--%>
    <asp:Label ID="Label406" runat="server" Text="Label" ></asp:Label><br /><%--e3--%>

    <%--对敏珊建的7个数据库进行检验--%>
    <br /><br /><br />
    <asp:Label ID="Label407" runat="server" Text="Label" ></asp:Label><br /><%--a2--%>
    <asp:Label ID="Label408" runat="server" Text="Label" ></asp:Label><br /><%--a3--%>
    <asp:Label ID="Label409" runat="server" Text="Label" ></asp:Label><br /><%--a5--%>
    <asp:Label ID="Label410" runat="server" Text="Label" ></asp:Label><br /><%--a6--%>
    <asp:Label ID="Label411" runat="server" Text="Label" ></asp:Label><br /><%--a7--%>
    <asp:Label ID="Label412" runat="server" Text="Label" ></asp:Label><br /><%--c1--%>
    <asp:Label ID="Label413" runat="server" Text="Label" ></asp:Label><br /><%--c2--%>
    </div>

    <%--删除数据检验--%>
    <div>
        <%--a--%>
            <asp:Label ID="Label450" runat="server" Text="Label" ></asp:Label><br />
            <asp:Label ID="Label451" runat="server" Text="Label" ></asp:Label><br />
            <asp:Label ID="Label452" runat="server" Text="Label" ></asp:Label><br />
            <asp:Label ID="Label453" runat="server" Text="Label" ></asp:Label><br />
            <asp:Label ID="Label454" runat="server" Text="Label" ></asp:Label><br />
            <asp:Label ID="Label455" runat="server" Text="Label" ></asp:Label><br />
            <asp:Label ID="Label456" runat="server" Text="Label" ></asp:Label><br /><br />
        <%--b--%>
            <asp:Label ID="Label457" runat="server" Text="Label" ></asp:Label><br />
            <asp:Label ID="Label458" runat="server" Text="Label" ></asp:Label><br />
            <asp:Label ID="Label459" runat="server" Text="Label" ></asp:Label><br />
            <asp:Label ID="Label460" runat="server" Text="Label" ></asp:Label><br /><br />
        <%--c--%>
            <asp:Label ID="Label461" runat="server" Text="Label"></asp:Label><br />
            <asp:Label ID="Label462" runat="server" Text="Label" ></asp:Label><br /><br />
        <%--d--%>
            <asp:Label ID="Label463" runat="server" Text="Label" ></asp:Label><br />
            <asp:Label ID="Label464" runat="server" Text="Label" ></asp:Label><br />
            <asp:Label ID="Label465" runat="server" Text="Label" ></asp:Label><br /><br />
        <%--e--%>
            <asp:Label ID="Label466" runat="server" Text="Label" ></asp:Label><br />
            <asp:Label ID="Label467" runat="server" Text="Label" ></asp:Label><br />
            <asp:Label ID="Label468" runat="server" Text="Label"></asp:Label><br /><br />
        <%--f--%>
            <asp:Label ID="Label469" runat="server" Text="Label" ></asp:Label><br />
            <asp:Label ID="Label470" runat="server" Text="Label" ></asp:Label><br />
            <asp:Label ID="Label471" runat="server" Text="Label" ></asp:Label><br />
            <asp:Label ID="Label472" runat="server" Text="Label"></asp:Label><br />
            <asp:Label ID="f2LbDelecte" runat="server" Text="Label" ></asp:Label><br /><br />
    </div>

    <%--更新数据检验--%>
    <div>
        
        <asp:Label ID="a1LbUpdate" runat="server" Text="Label" ></asp:Label><br />
        <asp:Label ID="a2LbUpdate" runat="server" Text="Label" ></asp:Label><br />
        <asp:Label ID="a3LbUpdate" runat="server" Text="Label" ></asp:Label><br />
        <asp:Label ID="a4LbUpdate" runat="server" Text="Label" ></asp:Label><br />
        <asp:Label ID="a5LbUpdate" runat="server" Text="Label" ></asp:Label><br />
        <asp:Label ID="a6LbUpdate" runat="server" Text="Label" ></asp:Label><br />
        <asp:Label ID="a7LbUpdate" runat="server" Text="Label" ></asp:Label><br />
        <br /><br /><br />
        <asp:Label ID="b1LbUpdate" runat="server" Text="Label" ></asp:Label><br />
        <asp:Label ID="b2LbUpdate" runat="server" Text="Label" ></asp:Label><br />
        <asp:Label ID="b3LbUpdate" runat="server" Text="Label" ></asp:Label><br />
        <asp:Label ID="b4LbUpdate" runat="server" Text="Label" ></asp:Label><br />
        <br /><br /><br />
        <asp:Label ID="c1LbUpdate" runat="server" Text="Label" ></asp:Label><br />
        <asp:Label ID="c2LbUpdate" runat="server" Text="Label" ></asp:Label><br />
        <br /><br /><br />
        <asp:Label ID="d1LbUpdate" runat="server" Text="Label" ></asp:Label><br />
        <asp:Label ID="d2LbUpdate" runat="server" Text="Label" ></asp:Label><br />
        <asp:Label ID="d3LbUpdate" runat="server" Text="Label" ></asp:Label><br />
        <br /><br /><br />
        <asp:Label ID="e1LbUpdate" runat="server" Text="Label" ></asp:Label><br />
        <asp:Label ID="e2LbUpdate" runat="server" Text="Label" ></asp:Label><br />
        <asp:Label ID="e3LbUpdate" runat="server" Text="Label" ></asp:Label><br />
        <br /><br /><br />
        <asp:Label ID="f1LbUpdate" runat="server" Text="Label" ></asp:Label><br />
        <asp:Label ID="f2LbUpdate" runat="server" Text="Label" ></asp:Label><br />
        <asp:Label ID="f3LbUpdate" runat="server" Text="Label" ></asp:Label><br />
        <asp:Label ID="f4LbUpdate" runat="server" Text="Label" ></asp:Label><br />
        <asp:Label ID="f5LbUpdate" runat="server" Text="Label" ></asp:Label><br />
    </div>
    </asp:Panel>

    </div>
    </form>
</body>

</html>

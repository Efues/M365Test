namespace M365TEST
{
  partial class FormMain
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      buttonGetTeamList = new Button();
      groupBox1 = new GroupBox();
      textBoxStatus = new TextBox();
      groupBox2 = new GroupBox();
      textBoxUserInfo = new TextBox();
      label5 = new Label();
      textBoxPassword = new TextBox();
      textBoxUserName = new TextBox();
      label3 = new Label();
      label4 = new Label();
      textBoxClientID = new TextBox();
      textBoxTenantID = new TextBox();
      label2 = new Label();
      label1 = new Label();
      buttonAuthTest = new Button();
      groupBox3 = new GroupBox();
      textBoxMsg = new TextBox();
      label8 = new Label();
      textBoxChannelID = new TextBox();
      label7 = new Label();
      textBoxTeamID = new TextBox();
      label6 = new Label();
      buttonTeamGetChannelList = new Button();
      buttonTeamTest = new Button();
      groupBox4 = new GroupBox();
      textBoxVal3 = new TextBox();
      textBoxVal2 = new TextBox();
      textBoxVal1 = new TextBox();
      textBoxColName3 = new TextBox();
      textBoxColName2 = new TextBox();
      textBoxColName1 = new TextBox();
      buttonAddNewItem = new Button();
      label15 = new Label();
      label16 = new Label();
      label17 = new Label();
      label14 = new Label();
      label13 = new Label();
      label12 = new Label();
      buttonGetColumn = new Button();
      textBoxListID = new TextBox();
      buttonGetList = new Button();
      label11 = new Label();
      textBoxSiteID = new TextBox();
      label10 = new Label();
      textBoxSiteSearchKey = new TextBox();
      label9 = new Label();
      buttonGetSiteList = new Button();
      groupBox1.SuspendLayout();
      groupBox2.SuspendLayout();
      groupBox3.SuspendLayout();
      groupBox4.SuspendLayout();
      SuspendLayout();
      // 
      // buttonGetTeamList
      // 
      buttonGetTeamList.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      buttonGetTeamList.Location = new Point(156, 120);
      buttonGetTeamList.Name = "buttonGetTeamList";
      buttonGetTeamList.Size = new Size(96, 23);
      buttonGetTeamList.TabIndex = 0;
      buttonGetTeamList.Text = "Get Team List";
      buttonGetTeamList.UseVisualStyleBackColor = true;
      buttonGetTeamList.Click += button1_Click;
      // 
      // groupBox1
      // 
      groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      groupBox1.Controls.Add(textBoxStatus);
      groupBox1.Location = new Point(12, 434);
      groupBox1.Name = "groupBox1";
      groupBox1.Size = new Size(1117, 197);
      groupBox1.TabIndex = 1;
      groupBox1.TabStop = false;
      groupBox1.Text = "Status";
      // 
      // textBoxStatus
      // 
      textBoxStatus.Dock = DockStyle.Fill;
      textBoxStatus.Location = new Point(3, 19);
      textBoxStatus.Multiline = true;
      textBoxStatus.Name = "textBoxStatus";
      textBoxStatus.Size = new Size(1111, 175);
      textBoxStatus.TabIndex = 0;
      // 
      // groupBox2
      // 
      groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      groupBox2.Controls.Add(textBoxUserInfo);
      groupBox2.Controls.Add(label5);
      groupBox2.Controls.Add(textBoxPassword);
      groupBox2.Controls.Add(textBoxUserName);
      groupBox2.Controls.Add(label3);
      groupBox2.Controls.Add(label4);
      groupBox2.Controls.Add(textBoxClientID);
      groupBox2.Controls.Add(textBoxTenantID);
      groupBox2.Controls.Add(label2);
      groupBox2.Controls.Add(label1);
      groupBox2.Controls.Add(buttonAuthTest);
      groupBox2.Location = new Point(12, 12);
      groupBox2.Name = "groupBox2";
      groupBox2.Size = new Size(1117, 173);
      groupBox2.TabIndex = 2;
      groupBox2.TabStop = false;
      groupBox2.Text = "認証テスト";
      // 
      // textBoxUserInfo
      // 
      textBoxUserInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      textBoxUserInfo.Location = new Point(462, 56);
      textBoxUserInfo.Multiline = true;
      textBoxUserInfo.Name = "textBoxUserInfo";
      textBoxUserInfo.ReadOnly = true;
      textBoxUserInfo.Size = new Size(649, 81);
      textBoxUserInfo.TabIndex = 13;
      // 
      // label5
      // 
      label5.AutoSize = true;
      label5.Location = new Point(462, 28);
      label5.Name = "label5";
      label5.Size = new Size(54, 15);
      label5.TabIndex = 12;
      label5.Text = "User Info";
      // 
      // textBoxPassword
      // 
      textBoxPassword.Location = new Point(96, 114);
      textBoxPassword.Name = "textBoxPassword";
      textBoxPassword.PasswordChar = '*';
      textBoxPassword.Size = new Size(360, 23);
      textBoxPassword.TabIndex = 11;
      textBoxPassword.UseSystemPasswordChar = true;
      // 
      // textBoxUserName
      // 
      textBoxUserName.Location = new Point(96, 85);
      textBoxUserName.Name = "textBoxUserName";
      textBoxUserName.Size = new Size(360, 23);
      textBoxUserName.TabIndex = 10;
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(19, 117);
      label3.Name = "label3";
      label3.Size = new Size(60, 15);
      label3.TabIndex = 9;
      label3.Text = "Password:";
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Location = new Point(19, 88);
      label4.Name = "label4";
      label4.Size = new Size(64, 15);
      label4.TabIndex = 8;
      label4.Text = "UsetName:";
      // 
      // textBoxClientID
      // 
      textBoxClientID.Location = new Point(96, 54);
      textBoxClientID.Name = "textBoxClientID";
      textBoxClientID.Size = new Size(360, 23);
      textBoxClientID.TabIndex = 7;
      // 
      // textBoxTenantID
      // 
      textBoxTenantID.Location = new Point(96, 25);
      textBoxTenantID.Name = "textBoxTenantID";
      textBoxTenantID.Size = new Size(360, 23);
      textBoxTenantID.TabIndex = 6;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(19, 57);
      label2.Name = "label2";
      label2.Size = new Size(54, 15);
      label2.TabIndex = 5;
      label2.Text = "Client ID:";
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(19, 28);
      label1.Name = "label1";
      label1.Size = new Size(59, 15);
      label1.TabIndex = 4;
      label1.Text = "Tenant ID:";
      // 
      // buttonAuthTest
      // 
      buttonAuthTest.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      buttonAuthTest.Location = new Point(1015, 144);
      buttonAuthTest.Name = "buttonAuthTest";
      buttonAuthTest.Size = new Size(96, 23);
      buttonAuthTest.TabIndex = 3;
      buttonAuthTest.Text = "Auth test";
      buttonAuthTest.UseVisualStyleBackColor = true;
      buttonAuthTest.Click += buttonAuthTest_Click;
      // 
      // groupBox3
      // 
      groupBox3.Controls.Add(textBoxMsg);
      groupBox3.Controls.Add(label8);
      groupBox3.Controls.Add(textBoxChannelID);
      groupBox3.Controls.Add(label7);
      groupBox3.Controls.Add(textBoxTeamID);
      groupBox3.Controls.Add(label6);
      groupBox3.Controls.Add(buttonTeamGetChannelList);
      groupBox3.Controls.Add(buttonTeamTest);
      groupBox3.Controls.Add(buttonGetTeamList);
      groupBox3.Location = new Point(12, 191);
      groupBox3.Name = "groupBox3";
      groupBox3.Size = new Size(467, 149);
      groupBox3.TabIndex = 3;
      groupBox3.TabStop = false;
      groupBox3.Text = "Teams Test";
      // 
      // textBoxMsg
      // 
      textBoxMsg.Location = new Point(96, 80);
      textBoxMsg.Name = "textBoxMsg";
      textBoxMsg.Size = new Size(360, 23);
      textBoxMsg.TabIndex = 19;
      textBoxMsg.Text = "Hello World!!";
      // 
      // label8
      // 
      label8.AutoSize = true;
      label8.Location = new Point(19, 83);
      label8.Name = "label8";
      label8.Size = new Size(33, 15);
      label8.TabIndex = 18;
      label8.Text = "Msg:";
      // 
      // textBoxChannelID
      // 
      textBoxChannelID.Location = new Point(96, 51);
      textBoxChannelID.Name = "textBoxChannelID";
      textBoxChannelID.Size = new Size(360, 23);
      textBoxChannelID.TabIndex = 17;
      // 
      // label7
      // 
      label7.AutoSize = true;
      label7.Location = new Point(19, 54);
      label7.Name = "label7";
      label7.Size = new Size(67, 15);
      label7.TabIndex = 16;
      label7.Text = "Channel ID:";
      // 
      // textBoxTeamID
      // 
      textBoxTeamID.Location = new Point(96, 22);
      textBoxTeamID.Name = "textBoxTeamID";
      textBoxTeamID.Size = new Size(360, 23);
      textBoxTeamID.TabIndex = 15;
      // 
      // label6
      // 
      label6.AutoSize = true;
      label6.Location = new Point(19, 25);
      label6.Name = "label6";
      label6.Size = new Size(51, 15);
      label6.TabIndex = 14;
      label6.Text = "Team ID:";
      // 
      // buttonTeamGetChannelList
      // 
      buttonTeamGetChannelList.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      buttonTeamGetChannelList.Location = new Point(258, 120);
      buttonTeamGetChannelList.Name = "buttonTeamGetChannelList";
      buttonTeamGetChannelList.Size = new Size(96, 23);
      buttonTeamGetChannelList.TabIndex = 2;
      buttonTeamGetChannelList.Text = "Get Channel List";
      buttonTeamGetChannelList.UseVisualStyleBackColor = true;
      buttonTeamGetChannelList.Click += buttonTeamGetChannelList_Click;
      // 
      // buttonTeamTest
      // 
      buttonTeamTest.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      buttonTeamTest.Location = new Point(360, 120);
      buttonTeamTest.Name = "buttonTeamTest";
      buttonTeamTest.Size = new Size(96, 23);
      buttonTeamTest.TabIndex = 1;
      buttonTeamTest.Text = "Send Message";
      buttonTeamTest.UseVisualStyleBackColor = true;
      buttonTeamTest.Click += buttonTeamTest_Click;
      // 
      // groupBox4
      // 
      groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      groupBox4.Controls.Add(textBoxVal3);
      groupBox4.Controls.Add(textBoxVal2);
      groupBox4.Controls.Add(textBoxVal1);
      groupBox4.Controls.Add(textBoxColName3);
      groupBox4.Controls.Add(textBoxColName2);
      groupBox4.Controls.Add(textBoxColName1);
      groupBox4.Controls.Add(buttonAddNewItem);
      groupBox4.Controls.Add(label15);
      groupBox4.Controls.Add(label16);
      groupBox4.Controls.Add(label17);
      groupBox4.Controls.Add(label14);
      groupBox4.Controls.Add(label13);
      groupBox4.Controls.Add(label12);
      groupBox4.Controls.Add(buttonGetColumn);
      groupBox4.Controls.Add(textBoxListID);
      groupBox4.Controls.Add(buttonGetList);
      groupBox4.Controls.Add(label11);
      groupBox4.Controls.Add(textBoxSiteID);
      groupBox4.Controls.Add(label10);
      groupBox4.Controls.Add(textBoxSiteSearchKey);
      groupBox4.Controls.Add(label9);
      groupBox4.Controls.Add(buttonGetSiteList);
      groupBox4.Location = new Point(485, 194);
      groupBox4.Name = "groupBox4";
      groupBox4.Size = new Size(644, 234);
      groupBox4.TabIndex = 4;
      groupBox4.TabStop = false;
      groupBox4.Text = "SharePoint Test";
      // 
      // textBoxVal3
      // 
      textBoxVal3.Location = new Point(490, 165);
      textBoxVal3.Name = "textBoxVal3";
      textBoxVal3.Size = new Size(136, 23);
      textBoxVal3.TabIndex = 39;
      // 
      // textBoxVal2
      // 
      textBoxVal2.Location = new Point(490, 136);
      textBoxVal2.Name = "textBoxVal2";
      textBoxVal2.Size = new Size(136, 23);
      textBoxVal2.TabIndex = 38;
      // 
      // textBoxVal1
      // 
      textBoxVal1.Location = new Point(490, 107);
      textBoxVal1.Name = "textBoxVal1";
      textBoxVal1.Size = new Size(136, 23);
      textBoxVal1.TabIndex = 37;
      // 
      // textBoxColName3
      // 
      textBoxColName3.Location = new Point(178, 166);
      textBoxColName3.Name = "textBoxColName3";
      textBoxColName3.Size = new Size(239, 23);
      textBoxColName3.TabIndex = 36;
      // 
      // textBoxColName2
      // 
      textBoxColName2.Location = new Point(178, 137);
      textBoxColName2.Name = "textBoxColName2";
      textBoxColName2.Size = new Size(239, 23);
      textBoxColName2.TabIndex = 35;
      // 
      // textBoxColName1
      // 
      textBoxColName1.Location = new Point(178, 108);
      textBoxColName1.Name = "textBoxColName1";
      textBoxColName1.Size = new Size(239, 23);
      textBoxColName1.TabIndex = 34;
      // 
      // buttonAddNewItem
      // 
      buttonAddNewItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      buttonAddNewItem.Location = new Point(542, 205);
      buttonAddNewItem.Name = "buttonAddNewItem";
      buttonAddNewItem.Size = new Size(96, 23);
      buttonAddNewItem.TabIndex = 33;
      buttonAddNewItem.Text = "Add New Item";
      buttonAddNewItem.UseVisualStyleBackColor = true;
      buttonAddNewItem.Click += buttonAddNewItem_Click;
      // 
      // label15
      // 
      label15.AutoSize = true;
      label15.Location = new Point(440, 168);
      label15.Name = "label15";
      label15.Size = new Size(44, 15);
      label15.TabIndex = 32;
      label15.Text = "Value3:";
      // 
      // label16
      // 
      label16.AutoSize = true;
      label16.Location = new Point(440, 139);
      label16.Name = "label16";
      label16.Size = new Size(44, 15);
      label16.TabIndex = 31;
      label16.Text = "Value2:";
      // 
      // label17
      // 
      label17.AutoSize = true;
      label17.Location = new Point(440, 111);
      label17.Name = "label17";
      label17.Size = new Size(44, 15);
      label17.TabIndex = 30;
      label17.Text = "Value1:";
      // 
      // label14
      // 
      label14.AutoSize = true;
      label14.Location = new Point(108, 169);
      label14.Name = "label14";
      label14.Size = new Size(64, 15);
      label14.TabIndex = 29;
      label14.Text = "ColName3:";
      // 
      // label13
      // 
      label13.AutoSize = true;
      label13.Location = new Point(108, 140);
      label13.Name = "label13";
      label13.Size = new Size(64, 15);
      label13.TabIndex = 28;
      label13.Text = "ColName2:";
      // 
      // label12
      // 
      label12.AutoSize = true;
      label12.Location = new Point(108, 112);
      label12.Name = "label12";
      label12.Size = new Size(64, 15);
      label12.TabIndex = 27;
      label12.Text = "ColName1:";
      // 
      // buttonGetColumn
      // 
      buttonGetColumn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      buttonGetColumn.Location = new Point(440, 205);
      buttonGetColumn.Name = "buttonGetColumn";
      buttonGetColumn.Size = new Size(96, 23);
      buttonGetColumn.TabIndex = 26;
      buttonGetColumn.Text = "Get Column";
      buttonGetColumn.UseVisualStyleBackColor = true;
      buttonGetColumn.Click += buttonGetColumn_Click;
      // 
      // textBoxListID
      // 
      textBoxListID.Location = new Point(106, 77);
      textBoxListID.Name = "textBoxListID";
      textBoxListID.Size = new Size(532, 23);
      textBoxListID.TabIndex = 25;
      // 
      // buttonGetList
      // 
      buttonGetList.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      buttonGetList.Location = new Point(338, 205);
      buttonGetList.Name = "buttonGetList";
      buttonGetList.Size = new Size(96, 23);
      buttonGetList.TabIndex = 24;
      buttonGetList.Text = "Get List";
      buttonGetList.UseVisualStyleBackColor = true;
      buttonGetList.Click += buttonGetList_Click;
      // 
      // label11
      // 
      label11.AutoSize = true;
      label11.Location = new Point(11, 80);
      label11.Name = "label11";
      label11.Size = new Size(42, 15);
      label11.TabIndex = 23;
      label11.Text = "List ID:";
      // 
      // textBoxSiteID
      // 
      textBoxSiteID.Location = new Point(106, 48);
      textBoxSiteID.Name = "textBoxSiteID";
      textBoxSiteID.Size = new Size(532, 23);
      textBoxSiteID.TabIndex = 20;
      // 
      // label10
      // 
      label10.AutoSize = true;
      label10.Location = new Point(11, 51);
      label10.Name = "label10";
      label10.Size = new Size(43, 15);
      label10.TabIndex = 22;
      label10.Text = "Site ID:";
      // 
      // textBoxSiteSearchKey
      // 
      textBoxSiteSearchKey.Location = new Point(106, 19);
      textBoxSiteSearchKey.Name = "textBoxSiteSearchKey";
      textBoxSiteSearchKey.Size = new Size(107, 23);
      textBoxSiteSearchKey.TabIndex = 21;
      // 
      // label9
      // 
      label9.AutoSize = true;
      label9.Location = new Point(11, 25);
      label9.Name = "label9";
      label9.Size = new Size(89, 15);
      label9.TabIndex = 20;
      label9.Text = "Site Search Key:";
      // 
      // buttonGetSiteList
      // 
      buttonGetSiteList.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      buttonGetSiteList.Location = new Point(236, 205);
      buttonGetSiteList.Name = "buttonGetSiteList";
      buttonGetSiteList.Size = new Size(96, 23);
      buttonGetSiteList.TabIndex = 20;
      buttonGetSiteList.Text = "Get Site List";
      buttonGetSiteList.UseVisualStyleBackColor = true;
      buttonGetSiteList.Click += buttonGetSiteList_Click;
      // 
      // FormMain
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1141, 643);
      Controls.Add(groupBox4);
      Controls.Add(groupBox3);
      Controls.Add(groupBox2);
      Controls.Add(groupBox1);
      Name = "FormMain";
      Text = "M365 Test";
      FormClosing += FormMain_FormClosing;
      Load += Form1_Load;
      groupBox1.ResumeLayout(false);
      groupBox1.PerformLayout();
      groupBox2.ResumeLayout(false);
      groupBox2.PerformLayout();
      groupBox3.ResumeLayout(false);
      groupBox3.PerformLayout();
      groupBox4.ResumeLayout(false);
      groupBox4.PerformLayout();
      ResumeLayout(false);
    }

    #endregion

    private Button buttonGetTeamList;
    private GroupBox groupBox1;
    private TextBox textBoxStatus;
    private GroupBox groupBox2;
    private Button buttonAuthTest;
    private Label label1;
    private Label label2;
    private TextBox textBoxClientID;
    private TextBox textBoxTenantID;
    private TextBox textBoxPassword;
    private TextBox textBoxUserName;
    private Label label3;
    private Label label4;
    private TextBox textBoxUserInfo;
    private Label label5;
    private GroupBox groupBox3;
    private Button buttonTeamTest;
    private Button buttonTeamGetChannelList;
    private TextBox textBoxTeamID;
    private Label label6;
    private TextBox textBoxChannelID;
    private Label label7;
    private TextBox textBoxMsg;
    private Label label8;
    private GroupBox groupBox4;
    private Button buttonGetSiteList;
    private TextBox textBoxSiteSearchKey;
    private Label label9;
    private TextBox textBoxSiteID;
    private Label label10;
    private Label label11;
    private Button buttonGetList;
    private Button buttonGetColumn;
    private TextBox textBoxListID;
    private Label label15;
    private Label label16;
    private Label label17;
    private Label label14;
    private Label label13;
    private Label label12;
    private Button buttonAddNewItem;
    private TextBox textBoxVal3;
    private TextBox textBoxVal2;
    private TextBox textBoxVal1;
    private TextBox textBoxColName3;
    private TextBox textBoxColName2;
    private TextBox textBoxColName1;
  }
}

using Azure.Identity;
using Microsoft.Graph;
using Microsoft.Graph.Models;

namespace M365TEST
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      textBoxClientID.Text = Properties.Settings.Default.ClientID;
      textBoxTenantID.Text = Properties.Settings.Default.TenantID;
      textBoxUserName.Text = Properties.Settings.Default.UserName;
      textBoxSiteSearchKey.Text = Properties.Settings.Default.SiteSearchKey;

      textBoxColName1.Text = Properties.Settings.Default.ColName1;
      textBoxColName2.Text = Properties.Settings.Default.ColName2;
      textBoxColName3.Text = Properties.Settings.Default.ColName3;

      textBoxVal1.Text = Properties.Settings.Default.Val1;
      textBoxVal2.Text = Properties.Settings.Default.Val2;
      textBoxVal3.Text = Properties.Settings.Default.Val3;
    }
    private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      SaveCtrlInputToSetting();
    }

    #region Auth test
    private async void buttonAuthTest_Click(object sender, EventArgs e)
    {
      SaveCtrlInputToSetting();
      await AuthTest();
    }
    async Task AuthTest()
    {
      try
      {
        GraphServiceClient graphClient = CreateClient();
        var resp = await graphClient.Me.GetAsync();
        textBoxUserInfo.Clear();
        textBoxUserInfo.Text += $"ID:{resp.Id}";
        textBoxUserInfo.Text += System.Environment.NewLine;
        textBoxUserInfo.Text += $"DisplayName:{resp.DisplayName}";
        textBoxUserInfo.Text += System.Environment.NewLine;
      }
      catch (Exception ex)
      {
        DisplayException(ex);
      }
    }
    #endregion

    #region Teams test
    private async void button1_Click(object sender, EventArgs e)
    {
      await TeamsGetList();
    }
    private async void buttonTeamGetChannelList_Click(object sender, EventArgs e)
    {
      await TeamsGetChannel();
    }
    private async void buttonTeamTest_Click(object sender, EventArgs e)
    {
      await TeamsSendMessage();
    }
    async Task TeamsGetChannel()
    {
      try
      {
        textBoxStatus.Clear();
        var graphClient = CreateClient();
        var teamID = textBoxTeamID.Text;
        var channels = await graphClient.Teams[teamID].Channels.GetAsync();
        if (channels?.Value != null)
        {
          textBoxStatus.Text += "Success to get channel info";
          textBoxStatus.Text += Environment.NewLine;
          foreach (var val in channels.Value)
          {
            textBoxStatus.Text += $"ID:{val.Id}";
            textBoxStatus.Text += Environment.NewLine;
            textBoxStatus.Text += $"DisplayName:{val.DisplayName}";
            textBoxStatus.Text += Environment.NewLine;
            textBoxStatus.Text += $"Description:{val.Description}";
            textBoxStatus.Text += Environment.NewLine;

            textBoxChannelID.Text = val.Id;
          }
        }

      }
      catch (Exception ex)
      {
        DisplayException(ex);
      }
    }
    async Task TeamsSendMessage()
    {
      try
      {
        textBoxStatus.Clear();
        var graphClient = CreateClient();

        var message = new Microsoft.Graph.Models.Message
        {
          Body = new ItemBody
          {
            Content = textBoxMsg.Text,
            ContentType = BodyType.Text
          },
        };

        var teamID = textBoxTeamID.Text;
        var channelID = textBoxChannelID.Text;
        await graphClient.Teams[teamID].Channels[channelID].Messages
          .PostAsync(new ChatMessage()
          {
            Body = new ItemBody
            {
              Content = textBoxMsg.Text,
              ContentType = BodyType.Text
            }
          });
        textBoxStatus.Text += "Message is sent.";
        textBoxStatus.Text += Environment.NewLine;
      }
      catch (Exception ex)
      {
        DisplayException(ex);
      }
    }
    async Task TeamsGetList()
    {
      try
      {
        textBoxStatus.Clear();
        GraphServiceClient graphClient = CreateClient();
        var resp = await graphClient.Me.JoinedTeams.GetAsync();
        if (resp?.Value != null)
        {
          textBoxStatus.Text += "Success to get team info";
          textBoxStatus.Text += Environment.NewLine;
          foreach (var val in resp.Value)
          {
            textBoxStatus.Text += $"ID:{val.Id}";
            textBoxStatus.Text += Environment.NewLine;
            textBoxStatus.Text += $"DisplayName:{val.DisplayName}";
            textBoxStatus.Text += Environment.NewLine;
            textBoxStatus.Text += $"Description:{val.Description}";
            textBoxStatus.Text += Environment.NewLine;

            textBoxTeamID.Text = val.Id;
          }
        }
      }
      catch (Exception ex)
      {
        DisplayException(ex);
      }
    }
    #endregion

    #region SharePoint test
    private async void buttonGetSiteList_Click(object sender, EventArgs e)
    {
      await SharePointGetSiteList();
    }
    private async void buttonGetList_Click(object sender, EventArgs e)
    {
      await SharePointGetList();
    }
    private async void buttonGetColumn_Click(object sender, EventArgs e)
    {
      await SharePointGetColumns();
    }
    private async void buttonAddNewItem_Click(object sender, EventArgs e)
    {
      await SharePointAddNewItemIntoList();
    }
    async Task SharePointAddNewItemIntoList()
    {
      try
      {
        textBoxStatus.Clear();
        var graphClient = CreateClient();

        var message = new Microsoft.Graph.Models.ListItem
        {
          Fields = new FieldValueSet(),
        };
        message.Fields.AdditionalData.Add(textBoxColName1.Text, textBoxVal1.Text);
        message.Fields.AdditionalData.Add(textBoxColName2.Text, textBoxVal2.Text);
        message.Fields.AdditionalData.Add(textBoxColName3.Text, textBoxVal3.Text);

        var siteID = textBoxSiteID.Text;
        var listID = textBoxListID.Text;
        await graphClient.Sites[siteID].Lists[listID].Items
          .PostAsync(message);
        textBoxStatus.Text += "Message is sent.";
        textBoxStatus.Text += Environment.NewLine;
      }
      catch (Exception ex)
      {
        DisplayException(ex);
      }
    }
    async Task SharePointGetSiteList()
    {
      try
      {
        textBoxStatus.Clear();
        var graphClient = CreateClient();
        var siteSearchKey = textBoxSiteSearchKey.Text;
        var sites = await graphClient.Sites.GetAsync((requestConfiguration) =>
        {
          requestConfiguration.QueryParameters.Search = siteSearchKey;
        });
        if (sites?.Value != null)
        {
          textBoxStatus.Text += "Success to get sites";
          textBoxStatus.Text += Environment.NewLine;
          textBoxStatus.Text += Environment.NewLine;
          foreach (var val in sites.Value)
          {
            textBoxStatus.Text += $"ID:{val.Id}";
            textBoxStatus.Text += Environment.NewLine;
            textBoxStatus.Text += $"DisplayName:{val.DisplayName}";
            textBoxStatus.Text += Environment.NewLine;
            textBoxStatus.Text += $"Description:{val.Description}";
            textBoxStatus.Text += Environment.NewLine;
            textBoxStatus.Text += Environment.NewLine;

            textBoxSiteID.Text = val.Id;
          }
        }

      }
      catch (Exception ex)
      {
        DisplayException(ex);
      }
    }
    async Task SharePointGetList()
    {
      try
      {
        textBoxStatus.Clear();
        var graphClient = CreateClient();
        var siteID = textBoxSiteID.Text;

        var lists = await graphClient.Sites[siteID].Lists.GetAsync();
        if (lists?.Value != null)
        {
          textBoxStatus.Text += "Success to get lists";
          textBoxStatus.Text += Environment.NewLine;
          textBoxStatus.Text += Environment.NewLine;
          foreach (var val in lists.Value)
          {
            textBoxStatus.Text += $"ID:{val.Id}";
            textBoxStatus.Text += Environment.NewLine;
            textBoxStatus.Text += $"DisplayName:{val.DisplayName}";
            textBoxStatus.Text += Environment.NewLine;
            textBoxStatus.Text += $"Description:{val.Description}";
            textBoxStatus.Text += Environment.NewLine;
            textBoxStatus.Text += Environment.NewLine;

            textBoxListID.Text = val.Id;
          }
        }

      }
      catch (Exception ex)
      {
        DisplayException(ex);
      }
    }
    async Task SharePointGetColumns()
    {
      try
      {
        textBoxStatus.Clear();
        var graphClient = CreateClient();
        var siteID = textBoxSiteID.Text;
        var listID = textBoxListID.Text;

        var cols = await graphClient.Sites[siteID].Lists[listID].Columns.GetAsync();
        if (cols?.Value != null)
        {
          textBoxStatus.Text += "Success to get cols";
          textBoxStatus.Text += Environment.NewLine;
          textBoxStatus.Text += Environment.NewLine;
          foreach (var val in cols.Value)
          {
            textBoxStatus.Text += $"ID:{val.Id}";
            textBoxStatus.Text += Environment.NewLine;
            textBoxStatus.Text += $"name:{val.Name}";
            textBoxStatus.Text += Environment.NewLine;
            textBoxStatus.Text += $"Description:{val.DisplayName}";
            textBoxStatus.Text += Environment.NewLine;
            textBoxStatus.Text += Environment.NewLine;
          }
        }

      }
      catch (Exception ex)
      {
        DisplayException(ex);
      }
    }
    #endregion

    #region common
    private GraphServiceClient CreateClient()
    {
      var scopes = new[] { "User.Read" };
      var tenantId = textBoxTenantID.Text;
      var clientId = textBoxClientID.Text;

      // using Azure.Identity;
      var options = new TokenCredentialOptions
      {
        AuthorityHost = AzureAuthorityHosts.AzurePublicCloud
      };

      var userName = textBoxUserName.Text;
      var password = textBoxPassword.Text;

      var userNamePasswordCredential = 
        new UsernamePasswordCredential(userName, password, tenantId, clientId, options);

      var graphClient = new GraphServiceClient(userNamePasswordCredential, scopes);
      return graphClient;
    }
    private void SaveCtrlInputToSetting()
    {
      Properties.Settings.Default.ClientID = textBoxClientID.Text;
      Properties.Settings.Default.TenantID = textBoxTenantID.Text;
      Properties.Settings.Default.UserName = textBoxUserName.Text;
      Properties.Settings.Default.SiteSearchKey = textBoxSiteSearchKey.Text;

      Properties.Settings.Default.ColName1 = textBoxColName1.Text;
      Properties.Settings.Default.ColName2 = textBoxColName2.Text;
      Properties.Settings.Default.ColName3 = textBoxColName3.Text;

      Properties.Settings.Default.Val1 = textBoxVal1.Text;
      Properties.Settings.Default.Val2 = textBoxVal2.Text;
      Properties.Settings.Default.Val3 = textBoxVal3.Text;

      Properties.Settings.Default.Save();
    }
    private void DisplayException(Exception ex)
    {
      textBoxStatus.Text += ex.Message;
      textBoxStatus.Text += Environment.NewLine;
      textBoxStatus.Text += ex.InnerException?.Message;
      textBoxStatus.Text += Environment.NewLine;
    }
    #endregion
  }
}

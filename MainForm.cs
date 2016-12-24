using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salesforce2SendGrid
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'sendGridDataSet.Recipients' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.recipientsTableAdapter.Fill(this.sendGridDataSet.Recipients);
            // TODO: このコード行はデータを 'salesforceDataSet.Contact' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.contactTableAdapter.Fill(this.salesforceDataSet.Contact);
        }

        private void btReload_Click(object sender, EventArgs e)
        {
            this.recipientsTableAdapter.Fill(this.sendGridDataSet.Recipients);
        }

        private void btImport_Click(object sender, EventArgs e)
        {
            var sendGridMap = this.dgvDestination.Rows
                .Cast<DataGridViewRow>()
                .Select(o => (SendGridDataSet.RecipientsRow)((DataRowView)o.DataBoundItem).Row)
                .ToDictionary(o => o.Email, o => o);

            var selectedList = this.dgvSource.Rows.Cast<DataGridViewRow>()
                .Where(o => o.Selected)
                .Select(o => (SalesforceDataSet.ContactRow)((DataRowView)o.DataBoundItem).Row)
                .ToList();


            this.btImport.Enabled = false;

            Task.Factory.StartNew(() =>
            {
                var processed = 0;

                foreach (var selected in selectedList)
                {
                    Invoke(new Action(() => this.Text = "処理中... (" + (processed + 1) + " / " + selectedList.Count + ")" ));

                    if (sendGridMap.ContainsKey(selected.Email) || selected.IsEmailNull())
                    {
                        continue;
                    }
                    
                    this.recipientsTableAdapter.Insert(
                        DBNull.Value, DBNull.Value, DBNull.Value,
                        selected.Email, selected.IsFirstNameNull() ? "" : selected.FirstName, selected.LastName,
                        DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value);

                    processed++;
                }
            })
            .ContinueWith(task =>
            {
                // エラー処理は省略

                Invoke(new Action(() =>
                {
                    this.btImport.Enabled = true;
                    this.Text = "完了";
                }));
            });
        }
    }
}

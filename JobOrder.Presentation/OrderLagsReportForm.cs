using JobOrder.Presentation.Integration.ViewModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Threading;

namespace JobOrder.Presentation
{
    public partial class OrderLagsReportForm: Form
    {
        public OrderLagsReportForm()
        {
            InitializeComponent();
            ConfigureApp();
        }

        private void ConfigureApp()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private async Task<List<OrderLagViewModel>> GetOrderLagsAsync()
        {
            HttpClient http = new HttpClient();
            var responseAsString =  await http.GetStringAsync("http://localhost:45567/api/Report/orderlags");
            var orderLagsArrayAsString = JObject.Parse(responseAsString).SelectToken("value").ToString();
            return JsonConvert.DeserializeObject<List<OrderLagViewModel>>(orderLagsArrayAsString);
        }

        private List<string> GetLagReasons(List<OrderLagViewModel> datasource)
        {
            return datasource.GroupBy(x => x.LagReason).Select(x => x.Key).ToList();
        }

        private List<OrderLagGroupViewModel> GroupOrders(List<OrderLagViewModel> datasource)
        {
            return (from o in datasource
                    group o by o.OrderName into g
                    select new OrderLagGroupViewModel { OrderName = g.Key, DataSource = g }
             ).ToList();
        }

        private void UpdateDataGridView()
        {
            var result = Task.Run(async () => await GetOrderLagsAsync()).Result;
            var groupedDataSource = GroupOrders(result);
            var lagReasons = GetLagReasons(result);

            reportGridView.Columns.Clear();
            reportGridView.Columns.Add("IsEmri", "İş Emri");

            //add other lag reason columns to gridview
            foreach (var lagReason in lagReasons)
            {
                reportGridView.Columns.Add(lagReason.RemoveSpaces(), lagReason);
            }

            //add all rows as empty
            reportGridView.Rows.Add(groupedDataSource.Count);

            
            for (int rowIndex = 0; rowIndex < groupedDataSource.Count; rowIndex++)
            {
                //fill order name cell on the row
                reportGridView.Rows[rowIndex].Cells["IsEmri"].Value = groupedDataSource[rowIndex].OrderName;

                //fill other lag durations on the row
                foreach (var groupedOrderLag in groupedDataSource[rowIndex].DataSource)
                {
                    reportGridView.Rows[rowIndex].Cells[groupedOrderLag.LagReason.RemoveSpaces()].Value = groupedOrderLag.LagDuration.ToString();
                }
            }
        }

        private void refreshButton_Click(object sender, System.EventArgs e)
        {
            UpdateDataGridView();
        }

        private void OrderLagsReportForm_Load(object sender, System.EventArgs e)
        {
            UpdateDataGridView();
        }
    }

    
}

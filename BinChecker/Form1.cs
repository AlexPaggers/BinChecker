using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void CheckBinsButton_Click(object sender, EventArgs e)
        {
            OutputLabel.Text = "Getting data...";
            
            var requestResult = await BinRequestSender.SendRequestAsync(dateTimePicker.Value);

            var jsonResult = JsonConvert.DeserializeObject(requestResult).ToString();

            List<BinCollectionInfo> collectionInfoList = BinCollectionInfoParser.Parse(jsonResult).ToList();
            List<BinCollectionInfo> sortedList = collectionInfoList.OrderBy(o => o.NextCollectionDate).ToList();

            string labelOutput =
                "Next bin day is " +
                sortedList[0].NextCollectionDate +
                " and is " +
                sortedList[0].BinToCollect.ToString() +
                "\n Next week on " +
                sortedList[1].NextCollectionDate +
                " it'll be " +
                sortedList[1].BinToCollect.ToString();

            OutputLabel.Text = labelOutput;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker.Value = DateTime.Now;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace epicSpiesAssetTrackerChallenge
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                string[] assets = new string[0];
                double[] elections = new double[0];
                double[] acts = new double[0];

                ViewState.Add("Assets", assets);
                ViewState.Add("Elections", elections);
                ViewState.Add("Acts", acts);

            }

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            string[] assets = (string[])ViewState["Assets"];
            double[] elections = (double[])ViewState["Elections"];
            double[] acts = (double[])ViewState["Acts"];

            int newLength = assets.Length +  1;

            Array.Resize(ref assets, newLength);
            Array.Resize(ref elections, newLength);
            Array.Resize(ref acts, newLength);

            int newIndex = assets.GetUpperBound(0);

            assets[newIndex] = assetTextBox.Text;
            elections[newIndex] = double.Parse(eleTextBox.Text);
            acts[newIndex] = double.Parse(actTextBox.Text);

            ViewState["Assets"] = assets;
            ViewState["Elections"] = elections;
            ViewState["Acts"] = acts;

            resultLabel.Text = string.Format("Total Elections Rigged: {0}<br />" +
                "Average Acts of Subterfuge per asset: {1:N2}<br />" +
                "(Last Asset you Added: {2})",
                elections.Sum(),
                acts.Average(),
                assets[newIndex]);



            assetTextBox.Text = "";
            eleTextBox.Text = "";
            actTextBox.Text = "";



        }
    }
}
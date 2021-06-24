using System;
using System.Windows.Forms;
using unirest_net.http;

namespace covidStats
{
    public partial class Form1 : Form
    {
        private HttpResponse<string> response;
        public Form1()
        {
            InitializeComponent();
            datePicker.Value = DateTime.Now;
            displayStats();
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            displayStats();
        }

        private void displayStats()
        {
            var stats = getStats(datePicker.Value, "UA");
            var newStats = getNewStats(datePicker.Value, "UA");

            casesResult.Text = find(stats, "cases").Trim(' ');
            deathsResult.Text = find(stats, "deaths").Trim(' ');
            recoveredResult.Text = find(stats, "recovered").Trim(' ');

            newCasesResult.Text = find(newStats, "cases").Trim(' ');
            newDeathsResult.Text = find(newStats, "deaths").Trim(' ');
            newRecoveredResult.Text = find(newStats, "recovered").Trim(' ');
        }

        private string getStats(DateTime date, string country)
        {
            response = Unirest.get("https://covid19-api.org/api/status/" + country + "?date=" + convertDate(date)).asString();
            return response.Body;
        }

        private string getNewStats(DateTime date, string country)
        {
            string lateStats = getStats(date, country);
            string earlierStats = getStats(date.AddDays(-1), country);
            string result = "{\n\"country\": \"" + country + "\",\n\"new_cases\": " + (Convert.ToInt64(find(lateStats, "cases")) - Convert.ToInt64(find(earlierStats, "cases"))).ToString()
                + ",\n\"new_deaths\": " + (Convert.ToInt64(find(lateStats, "deaths")) - Convert.ToInt64(find(earlierStats, "deaths"))).ToString()
                + ",\n\"new_recovered\": " + (Convert.ToInt64(find(lateStats, "recovered")) - Convert.ToInt64(find(earlierStats, "recovered"))).ToString()
                + "\n}";
            return result;
        }

        private string convertDate(DateTime date)
        {
            string year = date.Year.ToString();
            string month = date.Month < 10 ? "0" + date.Month.ToString() : date.Month.ToString();
            string day = date.Day < 10 ? "0" + date.Day.ToString() : date.Day.ToString();

            return year + "-" + month + "-" + day;
        }

        private string find(string response, string item) // Find given element in stringified JSON object
        {
            response = response.Trim('{');
            response = response.Trim('}');
            response = response.Replace('"', '\0');
            response += ";";

            int matchIndex = response.IndexOf(item);

            if (matchIndex == -1)
                return "Item not found";
            else
            {
                int endIndex = matchIndex + item.Length + 1;
                for (int i = matchIndex + item.Length + 1; i < response.Length; i++)
                {
                    if (response[i] == ',' || response[i] == ';')
                    {
                        endIndex = i - 1;
                        break;
                    }
                }

                return response.Substring(matchIndex + item.Length + 3, endIndex - matchIndex - item.Length - 2);
            }
        }
    }
}

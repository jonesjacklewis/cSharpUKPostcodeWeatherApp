using System.Text.RegularExpressions;
namespace cSharpWeatherApp
{
    public partial class formLocation : Form
    {
        public formLocation(string tempFile)
        {
            InitializeComponent();
            btnSubmit.Enabled = false;
   

            if (File.Exists(tempFile))
            {
                File.Delete(tempFile);
            }

         }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string postCode = txtPostcode.Text;

            formDetails formDetails = new formDetails(postCode);
            this.Hide();
            formDetails.Closed += (s, args) => this.Close();
            formDetails.Show();

        }

        private void txtPostcode_TextChanged(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;

            string postCode = txtPostcode.Text;
            // https://stackoverflow.com/questions/164979/regex-for-matching-uk-postcodes
            Regex postCodeRegex = new Regex(@"([Gg][Ii][Rr] 0[Aa]{2})|((([A-Za-z][0-9]{1,2})|(([A-Za-z][A-Ha-hJ-Yj-y][0-9]{1,2})|(([A-Za-z][0-9][A-Za-z])|([A-Za-z][A-Ha-hJ-Yj-y][0-9][A-Za-z]?))))\s?[0-9][A-Za-z]{2})");

            if(postCodeRegex.Matches(postCode).Count() > 0)
            {
                btnSubmit.Enabled = true;
            }
         


        }

        private void formLocation_Load(object sender, EventArgs e)
        { 
        }
        }
}
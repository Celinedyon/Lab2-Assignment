namespace biscyle_business
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            lblStartErr.Text   = "";
            lblEndErr.Text     = "";
            txtStart.BackColor = Color.FromArgb(245, 247, 250);
            txtEnd.BackColor   = Color.FromArgb(245, 247, 250);

            bool ok = true;

            if (!int.TryParse(txtStart.Text, out int start) || start < 0 || start > 23)
            {
                lblStartErr.Text   = "⚠  Enter an integer between 0 and 23.";
                txtStart.BackColor = Color.FromArgb(255, 235, 235);
                ok = false;
            }

            if (!int.TryParse(txtEnd.Text, out int end) || end < 1 || end > 24)
            {
                lblEndErr.Text   = "⚠  Enter an integer between 1 and 24.";
                txtEnd.BackColor = Color.FromArgb(255, 235, 235);
                ok = false;
            }

            if (!ok) return;

            if (start >= end)
            {
                lblStartErr.Text   = "⚠  Starting time must be less than ending time.";
                txtStart.BackColor = Color.FromArgb(255, 235, 235);
                return;
            }

            int total = 0;
            txtResult.Clear();
            txtResult2.Clear();
            lblTotal.Text = "";

            // split hours across two columns: left = first half, right = second half
            var hours = Enumerable.Range(start, end - start).ToList();
            int mid   = (hours.Count + 1) / 2;

            for (int i = 0; i < hours.Count; i++)
            {
                int h    = hours[i];
                int rate = h < 7 ? 500 : h < 14 ? 1000 : h < 19 ? 1500 : h < 21 ? 1000 : 500;
                total   += rate;

                string line = $"  Hr {h,2} → {rate,5} RWF\n";
                if (i < mid)
                    txtResult.AppendText(line);
                else
                    txtResult2.AppendText(line);
            }

            lblTotal.Text = $"  Total rental  :  {total} RWF";
        }

        private void BtnExit_Click(object sender, EventArgs e) => Application.Exit();
    }
}

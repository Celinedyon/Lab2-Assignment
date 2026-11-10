namespace biscyle_business
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // ── Palette ───────────────────────────────────────────────
            var clrBg     = Color.FromArgb(245, 247, 250);
            var clrHeader = Color.FromArgb(30,  90, 160);
            var clrAccent = Color.FromArgb(0,  140, 186);
            var clrCard   = Color.White;
            var clrErr    = Color.FromArgb(200, 50,  50);
            var clrExit   = Color.FromArgb(180, 50,  50);
            var clrDiv    = Color.FromArgb(230, 235, 245);

            // ── Form ──────────────────────────────────────────────────
            this.Text            = "Bicycle Rental Calculator";
            this.ClientSize      = new Size(500, 780);
            this.BackColor       = clrBg;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.Font            = new Font("Segoe UI", 10f);
            this.StartPosition   = FormStartPosition.CenterScreen;

            // ── Header ────────────────────────────────────────────────
            pnlHeader           = new Panel();
            lblTitle            = new Label();
            pnlHeader.BackColor = clrHeader;
            pnlHeader.Dock      = DockStyle.Top;
            pnlHeader.Height    = 68;

            lblTitle.Text      = "Bicycle Rental Calculator";
            lblTitle.ForeColor = Color.White;
            lblTitle.Font      = new Font("Segoe UI", 15f, FontStyle.Bold);
            lblTitle.AutoSize  = false;
            lblTitle.Dock      = DockStyle.Fill;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            pnlHeader.Controls.Add(lblTitle);

            // ── Subtitle ──────────────────────────────────────────────
            lblSub           = new Label();
            lblSub.Text      = "Enter rental hours below to calculate the cost";
            lblSub.ForeColor = Color.FromArgb(100, 110, 130);
            lblSub.Font      = new Font("Segoe UI", 9f, FontStyle.Bold | FontStyle.Italic);
            lblSub.AutoSize  = false;
            lblSub.Size      = new Size(452, 22);
            lblSub.Location  = new Point(24, 78);
            lblSub.TextAlign = ContentAlignment.MiddleLeft;

            // ── Input card ────────────────────────────────────────────
            pnlBody             = new Panel();
            pnlBody.BackColor   = clrCard;
            pnlBody.Location    = new Point(24, 108);
            pnlBody.Size        = new Size(452, 210);
            pnlBody.BorderStyle = BorderStyle.FixedSingle;

            pnlDivider           = new Panel();
            pnlDivider.BackColor = clrDiv;
            pnlDivider.Location  = new Point(0, 108);
            pnlDivider.Size      = new Size(452, 1);

            lblStart           = new Label();
            lblStart.Text      = "Starting Time  (0 – 23)";
            lblStart.ForeColor = Color.FromArgb(60, 60, 80);
            lblStart.Font      = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            lblStart.Location  = new Point(20, 18);
            lblStart.AutoSize  = true;

            txtStart             = new TextBox();
            txtStart.Location    = new Point(20, 44);
            txtStart.Size        = new Size(410, 35);
            txtStart.BackColor   = clrBg;
            txtStart.BorderStyle = BorderStyle.FixedSingle;
            txtStart.Font        = new Font("Segoe UI", 10.5f);

            lblStartErr           = new Label();
            lblStartErr.ForeColor = clrErr;
            lblStartErr.Font      = new Font("Segoe UI", 8.5f);
            lblStartErr.Location  = new Point(20, 76);
            lblStartErr.AutoSize  = true;
            lblStartErr.Text      = "";

            lblEnd           = new Label();
            lblEnd.Text      = "Ending Time  (1 – 24)";
            lblEnd.ForeColor = Color.FromArgb(60, 60, 80);
            lblEnd.Font      = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            lblEnd.Location  = new Point(20, 116);
            lblEnd.AutoSize  = true;

            txtEnd             = new TextBox();
            txtEnd.Location    = new Point(20, 142);
            txtEnd.Size        = new Size(410, 35);
            txtEnd.BackColor   = clrBg;
            txtEnd.BorderStyle = BorderStyle.FixedSingle;
            txtEnd.Font        = new Font("Segoe UI", 10.5f);

            lblEndErr           = new Label();
            lblEndErr.ForeColor = clrErr;
            lblEndErr.Font      = new Font("Segoe UI", 8.5f);
            lblEndErr.Location  = new Point(20, 174);
            lblEndErr.AutoSize  = true;
            lblEndErr.Text      = "";

            pnlBody.Controls.AddRange(new Control[]
                { pnlDivider, lblStart, txtStart, lblStartErr, lblEnd, txtEnd, lblEndErr });

            // ── Buttons ───────────────────────────────────────────────
            btnCalculate                          = new Button();
            btnCalculate.Text                     = "Calculate Rental";
            btnCalculate.Location                 = new Point(24, 334);
            btnCalculate.Size                     = new Size(218, 44);
            btnCalculate.BackColor                = clrAccent;
            btnCalculate.ForeColor                = Color.White;
            btnCalculate.FlatStyle                = FlatStyle.Flat;
            btnCalculate.FlatAppearance.BorderSize = 0;
            btnCalculate.Font                     = new Font("Segoe UI", 10.5f, FontStyle.Bold);
            btnCalculate.Cursor                   = Cursors.Hand;
            btnCalculate.Click                   += BtnCalculate_Click;

            btnExit                          = new Button();
            btnExit.Text                     = "Exit";
            btnExit.Location                 = new Point(258, 334);
            btnExit.Size                     = new Size(218, 44);
            btnExit.BackColor                = clrExit;
            btnExit.ForeColor                = Color.White;
            btnExit.FlatStyle                = FlatStyle.Flat;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Font                     = new Font("Segoe UI", 10.5f, FontStyle.Bold);
            btnExit.Cursor                   = Cursors.Hand;
            btnExit.Click                   += BtnExit_Click;

            // ── Result card — tall enough for all 24 rows + total ─────
            // 24 rows × 20px + total line + padding ≈ 580px content
            pnlResult             = new Panel();
            pnlResult.BackColor   = clrCard;
            pnlResult.Location    = new Point(24, 394);
            pnlResult.Size        = new Size(452, 356);
            pnlResult.BorderStyle = BorderStyle.FixedSingle;

            lblResultTitle           = new Label();
            lblResultTitle.Text      = "Hourly Breakdown & Total";
            lblResultTitle.ForeColor = clrAccent;
            lblResultTitle.Font      = new Font("Segoe UI", 10f, FontStyle.Bold);
            lblResultTitle.Location  = new Point(12, 10);
            lblResultTitle.AutoSize  = true;

            pnlResultDivider           = new Panel();
            pnlResultDivider.BackColor = clrDiv;
            pnlResultDivider.Location  = new Point(0, 36);
            pnlResultDivider.Size      = new Size(452, 1);

            txtResult             = new RichTextBox();
            txtResult.Location    = new Point(12, 44);
            txtResult.Size        = new Size(200, 260);
            txtResult.ReadOnly    = true;
            txtResult.BackColor   = clrCard;
            txtResult.BorderStyle = BorderStyle.None;
            txtResult.Font        = new Font("Consolas", 9.5f);
            txtResult.ScrollBars  = RichTextBoxScrollBars.None;

            txtResult2             = new RichTextBox();
            txtResult2.Location    = new Point(220, 44);
            txtResult2.Size        = new Size(200, 260);
            txtResult2.ReadOnly    = true;
            txtResult2.BackColor   = clrCard;
            txtResult2.BorderStyle = BorderStyle.None;
            txtResult2.Font        = new Font("Consolas", 9.5f);
            txtResult2.ScrollBars  = RichTextBoxScrollBars.None;

            lblTotal               = new Label();
            lblTotal.Location      = new Point(12, 312);
            lblTotal.Size          = new Size(426, 26);
            lblTotal.Font          = new Font("Consolas", 9.5f, FontStyle.Bold);
            lblTotal.ForeColor     = clrAccent;

            pnlResult.Controls.AddRange(new Control[]
                { lblResultTitle, pnlResultDivider, txtResult, txtResult2, lblTotal });

            // ── Add to form ───────────────────────────────────────────
            this.Controls.AddRange(new Control[]
                { pnlHeader, lblSub, pnlBody, btnCalculate, btnExit, pnlResult });
        }

        private Panel       pnlHeader        = null!;
        private Label       lblTitle         = null!;
        private Label       lblSub           = null!;
        private Panel       pnlBody          = null!;
        private Panel       pnlDivider       = null!;
        private Label       lblStart         = null!;
        private Label       lblEnd           = null!;
        private Panel       pnlResult        = null!;
        private Panel       pnlResultDivider = null!;
        private Label       lblResultTitle   = null!;
        private TextBox     txtStart         = null!;
        private TextBox     txtEnd           = null!;
        private Label       lblStartErr      = null!;
        private Label       lblEndErr        = null!;
        private Button      btnCalculate     = null!;
        private Button      btnExit          = null!;
        private RichTextBox txtResult        = null!;
        private RichTextBox txtResult2       = null!;
        private Label       lblTotal         = null!;
    }
}

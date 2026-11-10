namespace Mushuroom_type
{
    public partial class Form1 : Form
    {
        private int  _step    = 1;
        private bool _hasRing = false;
        private bool _hasCup  = false;

        public Form1()
        {
            InitializeComponent();
            btnYes.Click   += BtnYes_Click;
            btnNo.Click    += BtnNo_Click;
            btnReset.Click += BtnReset_Click;
        }

        private void BtnYes_Click(object? sender, EventArgs e) => Advance(true);
        private void BtnNo_Click(object? sender, EventArgs e)  => Advance(false);

        private void Advance(bool answer)
        {
            lstLog.Items.Add($"Q{_step}: {lblQuestion.Text}  →  {(answer ? "YES" : "NO")}");

            switch (_step)
            {
                case 1:
                    _hasRing         = answer;
                    _step            = 2;
                    lblQuestion.Text = "Does your mushroom have a convex cup?";
                    break;

                case 2:
                    _hasCup = answer;

                    if (_hasRing && !_hasCup)
                    {
                        ShowResult("Your mushroom is: Coprin chevelu");
                        return;
                    }
                    if (!_hasRing && _hasCup)
                    {
                        ShowResult("Your mushroom is: Pied bleu");
                        return;
                    }

                    _step            = 3;
                    lblQuestion.Text = _hasRing
                        ? "Does your mushroom grow in a forest?"
                        : "Does your mushroom have gills?";
                    break;

                case 3:
                    if (_hasRing)
                        ShowResult(answer
                            ? "Your mushroom is: Amanite tue-mouche"
                            : "Your mushroom is: Agaric Jaunissant");
                    else
                        ShowResult(answer
                            ? "Your mushroom is: Girolle"
                            : "Your mushroom is: Cepe de Bordeaux");
                    break;
            }
        }

        private void ShowResult(string text)
        {
            lstLog.Items.Add($"→ {text}");
            lblResult.Text    = text;
            lblResult.Visible = true;
            btnYes.Enabled    = false;
            btnNo.Enabled     = false;
        }

        private void BtnReset_Click(object? sender, EventArgs e)
        {
            _step            = 1;
            _hasRing         = false;
            _hasCup          = false;
            lblQuestion.Text = "Does your mushroom have a ring?";
            lblResult.Text   = "";
            lblResult.Visible = false;
            btnYes.Enabled   = true;
            btnNo.Enabled    = true;
            lstLog.Items.Clear();
        }
    }
}

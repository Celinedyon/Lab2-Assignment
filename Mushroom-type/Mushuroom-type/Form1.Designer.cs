namespace Mushuroom_type
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            grpMushrooms = new GroupBox();
            lblM1 = new Label();
            lblM2 = new Label();
            lblM3 = new Label();
            lblM4 = new Label();
            lblM5 = new Label();
            lblM6 = new Label();
            lblQuestion = new Label();
            btnYes = new Button();
            btnNo = new Button();
            lblResult = new Label();
            btnReset = new Button();
            lblLog = new Label();
            lstLog = new ListBox();
            pnlHeader.SuspendLayout();
            grpMushrooms.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Black;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1275, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1275, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Mushroom Type Identifier";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpMushrooms
            // 
            grpMushrooms.BackColor = Color.White;
            grpMushrooms.Controls.Add(lblM1);
            grpMushrooms.Controls.Add(lblM2);
            grpMushrooms.Controls.Add(lblM3);
            grpMushrooms.Controls.Add(lblM4);
            grpMushrooms.Controls.Add(lblM5);
            grpMushrooms.Controls.Add(lblM6);
            grpMushrooms.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpMushrooms.ForeColor = Color.Black;
            grpMushrooms.Location = new Point(30, 80);
            grpMushrooms.Name = "grpMushrooms";
            grpMushrooms.Size = new Size(540, 140);
            grpMushrooms.TabIndex = 1;
            grpMushrooms.TabStop = false;
            grpMushrooms.Text = "Think of one of these mushrooms";
            // 
            // lblM1
            // 
            lblM1.Font = new Font("Segoe UI", 10F);
            lblM1.ForeColor = Color.Black;
            lblM1.Location = new Point(20, 26);
            lblM1.Name = "lblM1";
            lblM1.Size = new Size(240, 26);
            lblM1.TabIndex = 0;
            lblM1.Text = "Agaric Jaunissant";
            // 
            // lblM2
            // 
            lblM2.Font = new Font("Segoe UI", 10F);
            lblM2.ForeColor = Color.Black;
            lblM2.Location = new Point(351, 26);
            lblM2.Name = "lblM2";
            lblM2.Size = new Size(240, 26);
            lblM2.TabIndex = 1;
            lblM2.Text = "Amanite tue-mouche";
            // 
            // lblM3
            // 
            lblM3.Font = new Font("Segoe UI", 10F);
            lblM3.ForeColor = Color.Black;
            lblM3.Location = new Point(20, 60);
            lblM3.Name = "lblM3";
            lblM3.Size = new Size(240, 26);
            lblM3.TabIndex = 2;
            lblM3.Text = "Cepe de Bordeaux";
            // 
            // lblM4
            // 
            lblM4.Font = new Font("Segoe UI", 10F);
            lblM4.ForeColor = Color.Black;
            lblM4.Location = new Point(351, 60);
            lblM4.Name = "lblM4";
            lblM4.Size = new Size(240, 26);
            lblM4.TabIndex = 3;
            lblM4.Text = "Coprin chevelu";
            // 
            // lblM5
            // 
            lblM5.Font = new Font("Segoe UI", 10F);
            lblM5.ForeColor = Color.Black;
            lblM5.Location = new Point(20, 94);
            lblM5.Name = "lblM5";
            lblM5.Size = new Size(240, 26);
            lblM5.TabIndex = 4;
            lblM5.Text = "Girolle";
            // 
            // lblM6
            // 
            lblM6.Font = new Font("Segoe UI", 10F);
            lblM6.ForeColor = Color.Black;
            lblM6.Location = new Point(351, 94);
            lblM6.Name = "lblM6";
            lblM6.Size = new Size(240, 26);
            lblM6.TabIndex = 5;
            lblM6.Text = "Pied bleu";
            // 
            // lblQuestion
            // 
            lblQuestion.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblQuestion.ForeColor = Color.Black;
            lblQuestion.Location = new Point(139, 223);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(540, 40);
            lblQuestion.TabIndex = 2;
            lblQuestion.Text = "Does your mushroom have a ring?";
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.FromArgb(0, 102, 204);
            btnYes.Cursor = Cursors.Hand;
            btnYes.FlatAppearance.BorderSize = 0;
            btnYes.FlatStyle = FlatStyle.Flat;
            btnYes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnYes.ForeColor = Color.White;
            btnYes.Location = new Point(101, 299);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(255, 50);
            btnYes.TabIndex = 3;
            btnYes.Text = "YES";
            btnYes.UseVisualStyleBackColor = false;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.FromArgb(204, 0, 0);
            btnNo.Cursor = Cursors.Hand;
            btnNo.FlatAppearance.BorderSize = 0;
            btnNo.FlatStyle = FlatStyle.Flat;
            btnNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNo.ForeColor = Color.White;
            btnNo.Location = new Point(452, 299);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(255, 50);
            btnNo.TabIndex = 4;
            btnNo.Text = "NO";
            btnNo.UseVisualStyleBackColor = false;
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblResult.ForeColor = Color.Black;
            lblResult.Location = new Point(30, 362);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(540, 36);
            lblResult.TabIndex = 5;
            lblResult.Visible = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Black;
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(30, 414);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(787, 50);
            btnReset.TabIndex = 6;
            btnReset.Text = "Start Over";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // lblLog
            // 
            lblLog.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLog.ForeColor = Color.Black;
            lblLog.Location = new Point(850, 80);
            lblLog.Name = "lblLog";
            lblLog.Size = new Size(150, 26);
            lblLog.TabIndex = 7;
            lblLog.Text = "Click History";
            // 
            // lstLog
            // 
            lstLog.Font = new Font("Segoe UI", 9F);
            lstLog.ItemHeight = 25;
            lstLog.Location = new Point(850, 110);
            lstLog.Name = "lstLog";
            lstLog.Size = new Size(393, 354);
            lstLog.TabIndex = 7;
            // 
            // Form1
            // 
            BackColor = Color.White;
            ClientSize = new Size(1275, 642);
            Controls.Add(pnlHeader);
            Controls.Add(grpMushrooms);
            Controls.Add(lblQuestion);
            Controls.Add(btnYes);
            Controls.Add(btnNo);
            Controls.Add(lblResult);
            Controls.Add(btnReset);
            Controls.Add(lblLog);
            Controls.Add(lstLog);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mushroom Type Identifier";
            pnlHeader.ResumeLayout(false);
            grpMushrooms.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel    pnlHeader    = null!;
        private Label    lblTitle     = null!;
        private GroupBox grpMushrooms = null!;
        private Label    lblM1        = null!;
        private Label    lblM2        = null!;
        private Label    lblM3        = null!;
        private Label    lblM4        = null!;
        private Label    lblM5        = null!;
        private Label    lblM6        = null!;
        private Label    lblQuestion  = null!;
        private Button   btnYes       = null!;
        private Button   btnNo        = null!;
        private Label    lblResult    = null!;
        private Button   btnReset     = null!;
        private Label    lblLog       = null!;
        private ListBox  lstLog       = null!;
    }
}

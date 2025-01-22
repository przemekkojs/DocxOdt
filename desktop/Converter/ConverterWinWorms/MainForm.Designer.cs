namespace ConverterWinWorms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            lbl_author = new Label();
            panel3 = new Panel();
            panel5 = new Panel();
            tlp_whole = new TableLayoutPanel();
            btn_convert = new Button();
            tlp_left = new TableLayoutPanel();
            btn_change_input = new Button();
            txt_source_path = new TextBox();
            tlp_right = new TableLayoutPanel();
            btn_change_output = new Button();
            txt_output_path = new TextBox();
            panel4 = new Panel();
            panel7 = new Panel();
            cb_output = new ComboBox();
            txt_output_files = new TextBox();
            panel6 = new Panel();
            cb_input = new ComboBox();
            txt_source_files = new TextBox();
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            mi_help = new ToolStripMenuItem();
            mi_docs = new ToolStripMenuItem();
            mi_repo = new ToolStripMenuItem();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            tlp_whole.SuspendLayout();
            tlp_left.SuspendLayout();
            tlp_right.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(lbl_author);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 433);
            panel2.Name = "panel2";
            panel2.Size = new Size(802, 20);
            panel2.TabIndex = 1;
            // 
            // lbl_author
            // 
            lbl_author.Dock = DockStyle.Left;
            lbl_author.Location = new Point(0, 0);
            lbl_author.Name = "lbl_author";
            lbl_author.Size = new Size(800, 20);
            lbl_author.TabIndex = 0;
            lbl_author.Text = "© Przemysław Kojs 2025";
            lbl_author.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(802, 398);
            panel3.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(tlp_whole);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 300);
            panel5.MaximumSize = new Size(0, 100);
            panel5.Name = "panel5";
            panel5.Size = new Size(802, 98);
            panel5.TabIndex = 1;
            // 
            // tlp_whole
            // 
            tlp_whole.ColumnCount = 3;
            tlp_whole.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlp_whole.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tlp_whole.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlp_whole.Controls.Add(btn_convert, 1, 0);
            tlp_whole.Controls.Add(tlp_left, 0, 0);
            tlp_whole.Controls.Add(tlp_right, 2, 0);
            tlp_whole.Dock = DockStyle.Fill;
            tlp_whole.Location = new Point(0, 0);
            tlp_whole.Name = "tlp_whole";
            tlp_whole.RowCount = 1;
            tlp_whole.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_whole.Size = new Size(802, 98);
            tlp_whole.TabIndex = 1;
            // 
            // btn_convert
            // 
            btn_convert.AccessibleRole = AccessibleRole.PushButton;
            btn_convert.Dock = DockStyle.Bottom;
            btn_convert.FlatAppearance.BorderSize = 0;
            btn_convert.Location = new Point(270, 52);
            btn_convert.Name = "btn_convert";
            btn_convert.Size = new Size(261, 43);
            btn_convert.TabIndex = 4;
            btn_convert.Text = "Konwertuj";
            btn_convert.UseVisualStyleBackColor = true;
            btn_convert.Click += btn_convert_Click;
            // 
            // tlp_left
            // 
            tlp_left.ColumnCount = 1;
            tlp_left.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_left.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_left.Controls.Add(btn_change_input, 0, 1);
            tlp_left.Controls.Add(txt_source_path, 0, 0);
            tlp_left.Dock = DockStyle.Fill;
            tlp_left.Location = new Point(3, 3);
            tlp_left.Name = "tlp_left";
            tlp_left.RowCount = 2;
            tlp_left.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_left.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_left.Size = new Size(261, 92);
            tlp_left.TabIndex = 0;
            // 
            // btn_change_input
            // 
            btn_change_input.Dock = DockStyle.Fill;
            btn_change_input.Location = new Point(3, 49);
            btn_change_input.Name = "btn_change_input";
            btn_change_input.Size = new Size(255, 40);
            btn_change_input.TabIndex = 0;
            btn_change_input.Text = "Zmień...";
            btn_change_input.UseVisualStyleBackColor = true;
            btn_change_input.Click += btn_change_input_Click;
            // 
            // txt_source_path
            // 
            txt_source_path.Dock = DockStyle.Fill;
            txt_source_path.Location = new Point(3, 3);
            txt_source_path.Multiline = true;
            txt_source_path.Name = "txt_source_path";
            txt_source_path.ReadOnly = true;
            txt_source_path.Size = new Size(255, 40);
            txt_source_path.TabIndex = 1;
            // 
            // tlp_right
            // 
            tlp_right.ColumnCount = 1;
            tlp_right.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_right.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_right.Controls.Add(btn_change_output, 0, 1);
            tlp_right.Controls.Add(txt_output_path, 0, 0);
            tlp_right.Dock = DockStyle.Fill;
            tlp_right.Location = new Point(537, 3);
            tlp_right.Name = "tlp_right";
            tlp_right.RowCount = 2;
            tlp_right.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_right.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_right.Size = new Size(262, 92);
            tlp_right.TabIndex = 1;
            // 
            // btn_change_output
            // 
            btn_change_output.Dock = DockStyle.Fill;
            btn_change_output.Location = new Point(3, 49);
            btn_change_output.Name = "btn_change_output";
            btn_change_output.Size = new Size(256, 40);
            btn_change_output.TabIndex = 0;
            btn_change_output.Text = "Zmień...";
            btn_change_output.UseVisualStyleBackColor = true;
            btn_change_output.Click += btn_change_output_Click;
            // 
            // txt_output_path
            // 
            txt_output_path.BorderStyle = BorderStyle.FixedSingle;
            txt_output_path.Dock = DockStyle.Fill;
            txt_output_path.Location = new Point(3, 3);
            txt_output_path.Multiline = true;
            txt_output_path.Name = "txt_output_path";
            txt_output_path.ReadOnly = true;
            txt_output_path.Size = new Size(256, 40);
            txt_output_path.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel6);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(802, 300);
            panel4.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(cb_output);
            panel7.Controls.Add(txt_output_files);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(400, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(402, 300);
            panel7.TabIndex = 1;
            // 
            // cb_output
            // 
            cb_output.Dock = DockStyle.Bottom;
            cb_output.FormattingEnabled = true;
            cb_output.Items.AddRange(new object[] { "odt" });
            cb_output.Location = new Point(0, 272);
            cb_output.Name = "cb_output";
            cb_output.Size = new Size(402, 28);
            cb_output.TabIndex = 1;
            cb_output.SelectedIndexChanged += cb_output_SelectedIndexChanged;
            // 
            // txt_output_files
            // 
            txt_output_files.Dock = DockStyle.Fill;
            txt_output_files.Location = new Point(0, 0);
            txt_output_files.Multiline = true;
            txt_output_files.Name = "txt_output_files";
            txt_output_files.ReadOnly = true;
            txt_output_files.Size = new Size(402, 300);
            txt_output_files.TabIndex = 0;
            txt_output_files.Text = "Nie znaleziono plików wyjściowych...";
            // 
            // panel6
            // 
            panel6.Controls.Add(cb_input);
            panel6.Controls.Add(txt_source_files);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(400, 300);
            panel6.TabIndex = 0;
            // 
            // cb_input
            // 
            cb_input.Dock = DockStyle.Bottom;
            cb_input.FormattingEnabled = true;
            cb_input.Items.AddRange(new object[] { "docx", "doc" });
            cb_input.Location = new Point(0, 272);
            cb_input.Name = "cb_input";
            cb_input.Size = new Size(400, 28);
            cb_input.TabIndex = 1;
            cb_input.SelectedIndexChanged += cb_input_SelectedIndexChanged;
            // 
            // txt_source_files
            // 
            txt_source_files.Dock = DockStyle.Fill;
            txt_source_files.Location = new Point(0, 0);
            txt_source_files.Multiline = true;
            txt_source_files.Name = "txt_source_files";
            txt_source_files.ReadOnly = true;
            txt_source_files.Size = new Size(400, 300);
            txt_source_files.TabIndex = 0;
            txt_source_files.Text = "Nie znaleziono plików wejściowych...";
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 35);
            panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mi_help });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(802, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "Menu";
            // 
            // mi_help
            // 
            mi_help.DropDownItems.AddRange(new ToolStripItem[] { mi_docs, mi_repo });
            mi_help.Name = "mi_help";
            mi_help.Size = new Size(68, 24);
            mi_help.Text = "Pomoc";
            // 
            // mi_docs
            // 
            mi_docs.Name = "mi_docs";
            mi_docs.Size = new Size(224, 26);
            mi_docs.Text = "Dokumentacja";
            mi_docs.Click += mi_docs_Click;
            // 
            // mi_repo
            // 
            mi_repo.Name = "mi_repo";
            mi_repo.Size = new Size(224, 26);
            mi_repo.Text = "Repozytorium";
            mi_repo.Click += mi_repo_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 453);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(820, 500);
            MinimumSize = new Size(820, 500);
            Name = "MainForm";
            Text = "Konwerter";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tlp_whole.ResumeLayout(false);
            tlp_left.ResumeLayout(false);
            tlp_left.PerformLayout();
            tlp_right.ResumeLayout(false);
            tlp_right.PerformLayout();
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Label lbl_author;
        private TableLayoutPanel tlp_whole;
        private TableLayoutPanel tlp_left;
        private TableLayoutPanel tlp_right;
        private Button btn_change_input;
        private Button btn_change_output;
        private TextBox txt_source_files;
        private TextBox txt_output_files;
        private TextBox txt_source_path;
        private Button btn_convert;
        private TextBox txt_output_path;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mi_help;
        private ToolStripMenuItem mi_docs;
        private ToolStripMenuItem mi_repo;
        private ComboBox cb_input;
        private ComboBox cb_output;
    }
}
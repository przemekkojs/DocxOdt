using Converter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterWinWorms
{
    public partial class MainForm : Form
    {
        private static readonly Color HOVER_BLUE = Color.FromArgb(0, 49, 131);
        private static readonly Color MAIN_BLUE = Color.FromArgb(0, 35, 93);
        private static readonly Color FONT_COLOE = Color.Black;
        private static readonly Color BACKGROUND_COLOR = Color.White;

        private static readonly string FONT = "Segoe UI";
        private const string FILES_NOT_FOUND = "Nie znaleziono plików";

        public Converter.Convert Behaviour { get; private set; }

        public MainForm()
        {
            InitializeComponent();

            ApplyFormStyle(this);
            this.Text = "Konwerter";

            ApplyButtonStyle(btn_change_input);
            ApplyButtonStyle(btn_change_output);
            ApplyButtonStyle(btn_convert);

            ApplyPanelStyle(panel1);
            ApplyPanelStyle(panel2);
            ApplyPanelStyle(panel3);
            ApplyPanelStyle(panel4);
            ApplyPanelStyle(panel5);
            ApplyPanelStyle(panel6);
            ApplyPanelStyle(panel7);
            ApplyPanelStyle(tlp_left);
            ApplyPanelStyle(tlp_right);
            ApplyPanelStyle(tlp_whole);

            ApplyTextBoxStyle(txt_output_files);
            ApplyTextBoxStyle(txt_source_files);
            ApplyTextBoxStyle(txt_output_path);
            ApplyTextBoxStyle(txt_source_path);

            ApplyMenuStyle(menuStrip1);
            ApplyMenuItemStyle(mi_help);

            Behaviour = new();

            txt_output_path.Text = Behaviour.IO.OutputDirectory;
            txt_source_path.Text = Behaviour.IO.InputDirectory;

            cb_input.SelectedIndex = 0;
            cb_output.SelectedIndex = 0;

            ScanInput();
            ScanOutput();
        }

        private static void ApplyButtonStyle(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = MAIN_BLUE;
            button.ForeColor = BACKGROUND_COLOR;
            button.Font = new Font(FONT, 8, FontStyle.Regular);
            button.Cursor = Cursors.Hand;
            button.MouseEnter += (s, e) => button.BackColor = HOVER_BLUE;
            button.MouseLeave += (s, e) => button.BackColor = MAIN_BLUE;
        }

        private static void ApplyFormStyle(Form form)
        {
            form.BackColor = BACKGROUND_COLOR;
        }

        private static void ApplyPanelStyle(Panel panel)
        {
            panel.Margin = new Padding(0);
            panel.BorderStyle = BorderStyle.None;
            panel.BackColor = BACKGROUND_COLOR;
        }

        private static void ApplyTextBoxStyle(TextBox textBox)
        {
            textBox.BorderStyle = BorderStyle.None;
            textBox.BackColor = BACKGROUND_COLOR;
            textBox.ReadOnly = true;
            textBox.Font = new Font(FONT, 8, FontStyle.Regular);
        }

        private static void ApplyMenuStyle(MenuStrip menu)
        {
            menu.BackColor = BACKGROUND_COLOR;
        }

        private static void ApplyMenuItemStyle(ToolStripMenuItem menuItem)
        {
            menuItem.BackColor = MAIN_BLUE;
            menuItem.ForeColor = BACKGROUND_COLOR;

            menuItem.MouseEnter += (s, e) => menuItem.BackColor = HOVER_BLUE;
            menuItem.MouseHover += (s, e) => menuItem.BackColor = HOVER_BLUE;
            menuItem.MouseDown += (s, e) => menuItem.BackColor = HOVER_BLUE;
            menuItem.MouseUp += (s, e) => menuItem.BackColor = MAIN_BLUE;
            menuItem.MouseLeave += (s, e) => menuItem.BackColor = MAIN_BLUE;
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            switch (cb_input.SelectedIndex)
            {
                case 0: //docx
                    Behaviour.DocxToOdtMultiple();
                    break;
                case 1: //doc
                    Behaviour.DocToOdtMultiple();
                    break;
                default:
                    throw new NotImplementedException();
            }

            ScanInput();
            ScanOutput();
        }

        private void btn_change_output_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Wybierz folder docelowy";
                folderDialog.ShowNewFolderButton = false;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    var path = folderDialog.SelectedPath;
                    Behaviour.ChangeOutputDirectory(path);
                    txt_output_path.Text = path;
                    ScanOutput();
                }
            }
        }

        private void btn_change_input_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Wybierz folder źródłowy";
                folderDialog.ShowNewFolderButton = false;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    var path = folderDialog.SelectedPath;
                    Behaviour.ChangeInputDirectory(path);
                    txt_source_path.Text = path;
                    ScanInput();
                }
            }
        }

        private static void ScanDirectory(TextBox textBox, string dir, string extension)
        {
            textBox.Clear();
            var list = Converter.Convert
                .GetFilesByExtension(dir, extension);

            if (list.Count == 0)
                textBox.Text = FILES_NOT_FOUND;
            else
            {
                foreach (var elem in list)
                {
                    textBox.Text += $"{elem.Split('\\').Last()}{Environment.NewLine}";
                }
            }
        }

        private void ScanOutput() => ScanDirectory(txt_output_files, Behaviour.IO.OutputDirectory, cb_output.Text);
        private void ScanInput() => ScanDirectory(txt_source_files, Behaviour.IO.InputDirectory, cb_input.Text);

        private void lbl_github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/przemekkojs/DocxOdt",
                UseShellExecute = true,
            });
        }

        private void cb_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScanInput();
        }

        private void cb_output_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScanOutput();
        }

        private void mi_repo_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/przemekkojs/DocxOdt",
                UseShellExecute = true,
            });
        }

        private void mi_docs_Click(object sender, EventArgs e)
        {
            // TODO: Właściwy link
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/przemekkojs/DocxOdt",
                UseShellExecute = true,
            });
        }
    }
}

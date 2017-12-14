using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryTsm
{
    public partial class DirectoryTsm : Form
    {
        public DirectoryTsm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog(this) != DialogResult.OK) return;

                var regex = new Regex(@":\\(?:\w+\\)*");
                if (regex.IsMatch(dialog.SelectedPath))
                {
                    inputPath.Text = dialog.SelectedPath;
                }
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var scanner = new Scanner(inputPath.Text);
            try
            {
                scanner.ScanFiles();
            }
            catch(DirectoryNotFoundException exception)
            {
                MessageBox.Show(this, exception.Message);
                return;
            }

            if (scanner.WriteFile())
            {
                MessageBox.Show("Done! Import string written to " + scanner.GetOutputPath());
            }
            else
            {
                MessageBox.Show("Something went wrong, while trying to write output.");
            }

        }
    }
}

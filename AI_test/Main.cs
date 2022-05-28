using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace AI_test
{
    public partial class Main : Form
    {
        RedService redService;
        public Main()
        {
            InitializeComponent();
            redService = new RedService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            RedRepositoryResponse red;
            var filePath = string.Empty;
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.InitialDirectory = @"C:\\";
                dlg.Filter = "txt files (*.txt)|*.txt|All Files (*.*)|*.*";
                dlg.FilterIndex = 1;
                dlg.RestoreDirectory = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    filePath = dlg.FileName;
                    var fileStream = dlg.OpenFile();
                }
                txtPath.Text = "";
                txtPath.Text = filePath;
                red = redService.Consult(filePath);
                txtPatrones.Text = "";
                txtPatrones.Text = red.Red.Patrones.ToString();
                txtEntradas.Text = "";
                txtEntradas.Text = red.Red.Entrada.ToString();
            }
        }
    }
}

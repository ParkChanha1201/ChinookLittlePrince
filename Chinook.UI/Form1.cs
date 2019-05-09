using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chinook.Data;

namespace Chinook.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnRun_Click(object sender, EventArgs e)   //수정중
        {
            int value = DataRepository.Album.GetTrackArtistCount(txtKeyword.Text);

            txtResult.Text = value.ToString();
        }
    }
}

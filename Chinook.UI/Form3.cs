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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            //todo: Artist의 ArtistId를 검색해 해당 가수가 가장 많이 소유하고 있는 곡의 장르를 표시한다.
            if (DataRepository.Album != null)
                txtResult.Text = DataRepository.Album.GetByPK(int.Parse(txtInput.Text)).Title;

        }
    }
}

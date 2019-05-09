using Chinook.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinook.UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            //todo: Album의 AlbumId를 검색해 가격을 표시한다.
            int albumId = int.Parse(txtInput.Text);
            txtResult.Text = DataRepository.Album.GetPrice(albumId).ToString() + "딸라";
        }
    }
}

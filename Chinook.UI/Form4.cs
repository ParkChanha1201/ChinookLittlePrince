﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
          private void BtnResult_Click(object sender, EventArgs e)
        {
            int value = DataRepository.Album.GetAlbumCountByArtistName(txtInput.Text);

            txtResult.Text = value.ToString();
        }
    }
}

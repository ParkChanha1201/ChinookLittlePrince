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
            List<Track> resultTracks = DataRepository.Track.GetTop5Tracks(int.Parse(txtInput.Text));

            List<string> resultList = new List<string>();
            foreach (Track resultTrack in resultTracks)
            {
                resultList.Add(resultTrack.Name);
            }
            listResultList.DataSource = null;
            listResultList.DataSource = resultList;
        }
    }
}

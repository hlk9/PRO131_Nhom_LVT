using Examination_BUS.Services;
using Examination_DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Examination_PRL.Forms.Participant
{
    public partial class Dashboard_P : Telerik.WinControls.UI.RadForm
    {
        FeedbackServices _ser = new FeedbackServices();
        public Dashboard_P()
        {
            InitializeComponent();
            _ser = new FeedbackServices();

        }




        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tbt_Content.Text = "";

            tbt_IDParticipant.Text = "";
            tbt_Name.Text = "";

            tbt_Title.Text = "";
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {

            Feedback fb = new Feedback()
            {

                Title = tbt_Title.Text,
                Name = tbt_Name.Text,
                IdParticipant = tbt_IDParticipant.Text,
                Content = tbt_Content.Text,
                Status = true,


            };
            bool add = (_ser.Send(fb));
            if (add) MessageBox.Show("Gửi thành công!");
            else MessageBox.Show("Gửi thất bại!");




        }


    }
}

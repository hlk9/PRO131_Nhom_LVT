using Examination_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Examination_PRL.Forms.Staff.Schedule
{
    public partial class ScheduleManagement : Telerik.WinControls.UI.RadForm
    {
        ScheduleServices scheduleServices = new ScheduleServices();
        public ScheduleManagement()
        {
            InitializeComponent();
        }
        public void LoadData()
        {


        }
    }
}

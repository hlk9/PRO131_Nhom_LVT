using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Examination_PRL.Forms.Staff.Home
{
    public partial class Home : Telerik.WinControls.UI.RadForm
    {
        public Home()
        {
            InitializeComponent();

            RoundRectShape roundRectShape = new RoundRectShape();
            roundRectShape.Radius = 30;
            radPanel1.RootElement.Shape = roundRectShape;
            radPanel1.RootElement.ApplyShapeToControl = true;
            radPanel2.RootElement.Shape = roundRectShape;
            radPanel2.RootElement.ApplyShapeToControl = true;
            radPanel3.RootElement.Shape = roundRectShape;
            radPanel3.RootElement.ApplyShapeToControl = true;




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App.View
{
    public static class ControlController
    {
        public static void OnEnter(object sender, EventArgs e, ToolTip tooltip)
        {
            tooltip.Show(tooltip.GetToolTip(sender as Control), (sender as Control), 3500);
        }

        public static void OnLeave(object sender, EventArgs e, ToolTip tooltip)
        {
            tooltip.Hide(sender as Control);
        }
    }
}

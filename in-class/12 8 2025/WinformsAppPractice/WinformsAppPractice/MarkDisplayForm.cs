using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsAppPractice
{
    public partial class MarkDisplayForm : Form
    {
        public MarkDisplayForm(int Mark1, int Mark2, int Mark3)
        {
            InitializeComponent();

            int average = (Mark1 + Mark2 + Mark3) / 3;

            AverageMarksDisplay.Text = $"Average Marks: {average}";
        }
    }
}

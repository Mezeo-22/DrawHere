using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawHere
{
    public partial class Create : Form
    {
        int xPicSize;
        int yPicSize;
        string canvasName;
        public Create()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                xPicSize = Convert.ToInt32(xSizeText.Text);
                yPicSize = Convert.ToInt32(ySizeText.Text);
                canvasName = nameText.Text;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            this.DialogResult = DialogResult.OK;
        }

        public Int32 GetX() { return xPicSize; }

        public Int32 GetY() { return yPicSize; }

        public String GetName() { return canvasName; }

        public Int32 GetTime() { return Convert.ToInt32(timeUpDown.Value); }
    }
}

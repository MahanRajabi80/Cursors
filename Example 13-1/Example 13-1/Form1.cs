using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example_13_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            object[] cur = {Cursors.AppStarting,Cursors.Arrow,Cursors.Cross,Cursors.Default,
                               Cursors.Hand,Cursors.Help,Cursors.HSplit,Cursors.IBeam,Cursors.No,
                               Cursors.NoMove2D,Cursors.NoMoveHoriz,Cursors.NoMoveVert,
                               Cursors.PanEast,Cursors.PanNE,Cursors.PanNorth,Cursors.PanNW,
                               Cursors.PanSE,Cursors.PanSouth,Cursors.PanSW,Cursors.PanWest,
                               Cursors.SizeAll,Cursors.SizeNESW,Cursors.SizeNS,Cursors.SizeNWSE,
                               Cursors.SizeWE,Cursors.UpArrow,Cursors.VSplit,Cursors.WaitCursor
                           };
            cmbCursors.Items.AddRange((object[])cur);
            cmbCursors.SelectedIndex = 0;
            this.Cursor = Cursors.AppStarting;
        }
        //------------------------------------------------------------
        private void cmbCursors_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Cursor = (Cursor)cmbCursors.Items[cmbCursors.SelectedIndex];
        }
    }
}

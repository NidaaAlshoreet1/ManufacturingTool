using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Input;
using System.Drawing;
// GLControl in den Host -Container einfügen
using System.Windows.Forms.Integration;
using OpenTK.WinForms;
using System.Windows.Forms;


namespace ManufacturingTool
{
    public partial class MainForm_Designer : Form
    {
        public MainForm_Designer()
        {
            InitializeComponent();
        }
    }

    partial class MainForm_Designer
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            // Zeile Muss in WPF geschrieben werden
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

        #endregion
    }
}

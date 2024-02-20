using System;
using System.Windows.Forms;

namespace Napominalka
{
    public partial class Form1
    {


        private System.ComponentModel.IContainer components = null;
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private Panel panel1;
        private TextBox textBox1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
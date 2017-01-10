using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTF_BACKEND.DataContract;

namespace DropThatFile
{
    public partial class Login : Form
    {
        public Login()
        {
            test rere = new test();
            InitializeComponent();
            this.textBox1.Text = rere.testService;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Juggernaut.Authentication.QueryManager.Context;
using Juggernaut.Authentication.EntityModel;

namespace TestGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JuggernautContext db = new JuggernautContext();

            var users = db.JuggernautUsers.OrderBy(j => j.Surname).ThenBy(j => j.GivenName).ToList();

            
        }
    }
}

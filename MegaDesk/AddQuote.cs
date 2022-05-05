using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            //Set Maximum and minimums of desk numericals
            num_Width.Maximum = Desk.MAX_DEPTH;
            num_Width.Minimum = Desk.MIN_DEPTH;
            num_Depth.Maximum = Desk.MAX_DEPTH;
            num_Depth.Minimum = Desk.MIN_DEPTH;
            num_Drawers.Maximum = Desk.MAX_DESK_DRAWERS;
            num_Drawers.Minimum = Desk.MIN_DESK_DRAWERS;

            //Set Dropdown Menu Values
            List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            //List<ShippingOption> shipping = Enum.GetValues(typeof(ShippingOption)).Cast<ShippingOption>().ToList();

            combo_Material.DataSource = materials;
            combo_Material.SelectedIndex = -1;
            //TODO add shipping descriptions as data source
            //combo_Order.DataSource = shipping;
            combo_Order.SelectedIndex = -1;
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)this.Tag).Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

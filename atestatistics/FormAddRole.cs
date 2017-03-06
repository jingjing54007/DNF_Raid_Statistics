using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atestatistics
{
    public partial class FormAddRole : Form
    {
        public Role NewRole;

        public FormAddRole()
        {
            InitializeComponent();
            EditTimes.Maximum = 3;
            EditTimes.Minimum = 0;
            EditPos.Items.AddRange(Role.RoleTypes);
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            NewRole = new Role();
            NewRole.BelongTo = EditBelong.Text;
            NewRole.RoleType = EditType.Text;
            NewRole.RoleLevel = EditPos.Text;
            NewRole.RoleName = EditName.Text;
            NewRole.TimesLeft = (int)EditTimes.Value;
            DialogResult = DialogResult.OK;
        }
    }
}

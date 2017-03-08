using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace atestatistics
{
    public partial class Form1 : Form
    {

        public static string DataFile = "data.txt";
        public List<Role> roles;

        public Form1()
        {
            roles = new List<Role>();
            InitializeComponent();

            DataTable.MouseDoubleClick += DataTable_DoubleClick;
            GridView view = (GridView)DataTable.Views[0];
            
            view.RowCellStyle += view_RowCellStyle;
            view.OptionsCustomization.AllowQuickHideColumns = false;
            
            LoadData();
            Refresh();
        }

        public void LoadData()
        {
            if (File.Exists(DataFile))
            {
                try
                {
                    string[] content = File.ReadAllLines(DataFile);
                    foreach (string str in content)
                    {
                        Role r = Role.FromString(str);
                        roles.Add(r);
                    }
                    DataTable.Views[0].PopulateColumns();
                    DataTable.DataSource = roles;
                }
                catch(Exception ex)
                {
                    string errmsg = "数据文件损坏\n" + ex.StackTrace;
                    MessageBox.Show(errmsg);
                }
            }
            else
            {
                MessageBox.Show("数据文件不存在，已自动在当前目录下创建");
                StreamWriter sw = File.CreateText(DataFile);
                sw.Close();
            }

        }

        public void Refresh()
        {
            DataTable.RefreshDataSource();
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            foreach(Role r in roles)
            {
                r.TimesLeft = 3;
            }
            Refresh();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            FormAddRole add = new FormAddRole();
            if(add.ShowDialog() == DialogResult.OK)
            {
                Role n = add.NewRole;
                roles.Add(n);
                Refresh();
            }
        }

        private void ButtonBatch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("在打开的文本编辑器中按以下格式添加或修改记录：\n号主,角色名,职业,位置,剩余次数\n注意逗号是英文逗号，除剩余次数外其他位置可以留空，每个角色一行\n修改后记得保存");
            System.Diagnostics.Process.Start("data.txt");
        }

        public void WriteToFile()
        {
            StreamWriter sw = new StreamWriter(File.OpenWrite(DataFile));
            foreach (Role r in roles)
            {
                sw.WriteLine(r.ToString());
            }
            sw.Flush();
            sw.Close();
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            roles.Clear();
            LoadData();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteToFile();
        }

        private void DataTable_DoubleClick(object sender, MouseEventArgs e)
        {
            GridView view = (GridView)DataTable.Views[0];
            
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            if(e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                DoRowDoubleClick(view, pt);
            }
            else if(e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                DoRowRightClick(view, pt);
            }
        }

        private void DoRowRightClick(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                if (roles[info.RowHandle].TimesLeft < 3)
                {
                    roles[info.RowHandle].TimesLeft++;
                    Refresh();
                }
                else
                {
                    MessageBox.Show("这个咸鱼角色已经剩余3次了");
                }
            }
        }

        private void DoRowDoubleClick(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                if(roles[info.RowHandle].TimesLeft > 0)
                {
                    roles[info.RowHandle].TimesLeft--;
                    Refresh();
                }
                else
                {
                    MessageBox.Show("这个咸鱼角色已经不能再打团了");
                }
            }
        }

        private void view_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if(roles[e.RowHandle].TimesLeft == 3)
            {
                e.Appearance.BackColor = Color.GreenYellow;
            }
            else if (roles[e.RowHandle].TimesLeft == 2)
            {
                e.Appearance.BackColor = Color.ForestGreen;
            }
            else if (roles[e.RowHandle].TimesLeft == 1)
            {
                e.Appearance.BackColor = Color.Orange;
            }
            else if (roles[e.RowHandle].TimesLeft == 0)
            {
                e.Appearance.BackColor = Color.OrangeRed;
            }
        }
    }
}

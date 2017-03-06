namespace atestatistics
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonReset = new System.Windows.Forms.Button();
            this.DataTable = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BelongTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoleType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoleLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TimesLeft = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonBatch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonReset
            // 
            this.ButtonReset.Location = new System.Drawing.Point(675, 13);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(75, 23);
            this.ButtonReset.TabIndex = 1;
            this.ButtonReset.Text = "重置次数";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // DataTable
            // 
            this.DataTable.Location = new System.Drawing.Point(12, 13);
            this.DataTable.MainView = this.gridView1;
            this.DataTable.Name = "DataTable";
            this.DataTable.Size = new System.Drawing.Size(647, 469);
            this.DataTable.TabIndex = 2;
            this.DataTable.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BelongTo,
            this.RoleName,
            this.RoleType,
            this.RoleLevel,
            this.TimesLeft});
            this.gridView1.GridControl = this.DataTable;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // BelongTo
            // 
            this.BelongTo.Caption = "号主";
            this.BelongTo.Name = "BelongTo";
            this.BelongTo.Visible = true;
            this.BelongTo.VisibleIndex = 0;
            // 
            // RoleName
            // 
            this.RoleName.Caption = "角色名";
            this.RoleName.Name = "RoleName";
            this.RoleName.Visible = true;
            this.RoleName.VisibleIndex = 1;
            // 
            // RoleType
            // 
            this.RoleType.Caption = "职业";
            this.RoleType.Name = "RoleType";
            this.RoleType.Visible = true;
            this.RoleType.VisibleIndex = 2;
            // 
            // RoleLevel
            // 
            this.RoleLevel.Caption = "位置";
            this.RoleLevel.Name = "RoleLevel";
            this.RoleLevel.Visible = true;
            this.RoleLevel.VisibleIndex = 3;
            // 
            // TimesLeft
            // 
            this.TimesLeft.Caption = "剩余次数";
            this.TimesLeft.Name = "TimesLeft";
            this.TimesLeft.Visible = true;
            this.TimesLeft.VisibleIndex = 4;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(675, 43);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 3;
            this.ButtonAdd.Text = "添加角色";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonBatch
            // 
            this.ButtonBatch.Location = new System.Drawing.Point(675, 73);
            this.ButtonBatch.Name = "ButtonBatch";
            this.ButtonBatch.Size = new System.Drawing.Size(75, 23);
            this.ButtonBatch.TabIndex = 4;
            this.ButtonBatch.Text = "批量添加";
            this.ButtonBatch.UseVisualStyleBackColor = true;
            this.ButtonBatch.Click += new System.EventHandler(this.ButtonBatch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "点击列名右上角的漏斗进行筛选，将某列标题拖拽到上方区域可以以此列分组";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 506);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "双击对应的行使某角色的剩余次数减少一次";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "手动编辑此软件所在目录下的data.txt进行批量修改";
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Location = new System.Drawing.Point(675, 458);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(75, 23);
            this.ButtonRefresh.TabIndex = 8;
            this.ButtonRefresh.Text = "刷新";
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 547);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(573, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "对于角色的位置，请尽量只使用以下定义：帝王C, 晴天C, 震颤C, 舰炮C, 体奶, 精奶, 光兵, 斩铁, 咸鱼, 狗混子";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 576);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonBatch);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.DataTable);
            this.Controls.Add(this.ButtonReset);
            this.Name = "Form1";
            this.Text = "流水团角色统计 by 北一 业火丶苍云";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonReset;
        private DevExpress.XtraGrid.GridControl DataTable;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn BelongTo;
        private DevExpress.XtraGrid.Columns.GridColumn RoleName;
        private DevExpress.XtraGrid.Columns.GridColumn RoleType;
        private DevExpress.XtraGrid.Columns.GridColumn RoleLevel;
        private DevExpress.XtraGrid.Columns.GridColumn TimesLeft;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonBatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonRefresh;
        private System.Windows.Forms.Label label4;
    }
}


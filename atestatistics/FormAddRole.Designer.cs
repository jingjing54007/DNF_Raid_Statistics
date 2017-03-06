namespace atestatistics
{
    partial class FormAddRole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.EditBelong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EditName = new System.Windows.Forms.TextBox();
            this.EditType = new System.Windows.Forms.TextBox();
            this.EditPos = new System.Windows.Forms.ComboBox();
            this.EditTimes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EditTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "号主";
            // 
            // EditBelong
            // 
            this.EditBelong.Location = new System.Drawing.Point(61, 13);
            this.EditBelong.Name = "EditBelong";
            this.EditBelong.Size = new System.Drawing.Size(100, 20);
            this.EditBelong.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "角色名";
            // 
            // EditName
            // 
            this.EditName.Location = new System.Drawing.Point(61, 40);
            this.EditName.Name = "EditName";
            this.EditName.Size = new System.Drawing.Size(100, 20);
            this.EditName.TabIndex = 3;
            // 
            // EditType
            // 
            this.EditType.Location = new System.Drawing.Point(61, 67);
            this.EditType.Name = "EditType";
            this.EditType.Size = new System.Drawing.Size(100, 20);
            this.EditType.TabIndex = 4;
            // 
            // EditPos
            // 
            this.EditPos.FormattingEnabled = true;
            this.EditPos.Location = new System.Drawing.Point(61, 94);
            this.EditPos.Name = "EditPos";
            this.EditPos.Size = new System.Drawing.Size(121, 21);
            this.EditPos.TabIndex = 5;
            // 
            // EditTimes
            // 
            this.EditTimes.Location = new System.Drawing.Point(61, 127);
            this.EditTimes.Name = "EditTimes";
            this.EditTimes.Size = new System.Drawing.Size(120, 20);
            this.EditTimes.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "职业";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "位置";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "剩余";
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Location = new System.Drawing.Point(51, 164);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(75, 23);
            this.ButtonCreate.TabIndex = 10;
            this.ButtonCreate.Text = "添加";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // FormAddRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 208);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EditTimes);
            this.Controls.Add(this.EditPos);
            this.Controls.Add(this.EditType);
            this.Controls.Add(this.EditName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EditBelong);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddRole";
            this.Text = "FormAddRole";
            ((System.ComponentModel.ISupportInitialize)(this.EditTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EditBelong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EditName;
        private System.Windows.Forms.TextBox EditType;
        private System.Windows.Forms.ComboBox EditPos;
        private System.Windows.Forms.NumericUpDown EditTimes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonCreate;
    }
}
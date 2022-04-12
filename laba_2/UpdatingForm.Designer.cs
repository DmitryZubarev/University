namespace laba_2
{
    partial class UpdatingForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFaculty = new System.Windows.Forms.TabPage();
            this.tabPageCourse = new System.Windows.Forms.TabPage();
            this.tabPageGroup = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFaculties = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewFName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCourses = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNewCName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.textBoxNewGName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageFaculty.SuspendLayout();
            this.tabPageCourse.SuspendLayout();
            this.tabPageGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnUpdate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(524, 268);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(3, 217);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(518, 48);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFaculty);
            this.tabControl1.Controls.Add(this.tabPageCourse);
            this.tabControl1.Controls.Add(this.tabPageGroup);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(518, 208);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageFaculty
            // 
            this.tabPageFaculty.Controls.Add(this.textBoxNewFName);
            this.tabPageFaculty.Controls.Add(this.label2);
            this.tabPageFaculty.Controls.Add(this.comboBoxFaculties);
            this.tabPageFaculty.Controls.Add(this.label1);
            this.tabPageFaculty.Location = new System.Drawing.Point(4, 22);
            this.tabPageFaculty.Name = "tabPageFaculty";
            this.tabPageFaculty.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFaculty.Size = new System.Drawing.Size(510, 182);
            this.tabPageFaculty.TabIndex = 0;
            this.tabPageFaculty.Text = "Факультет";
            this.tabPageFaculty.UseVisualStyleBackColor = true;
            // 
            // tabPageCourse
            // 
            this.tabPageCourse.Controls.Add(this.textBoxNewCName);
            this.tabPageCourse.Controls.Add(this.label4);
            this.tabPageCourse.Controls.Add(this.comboBoxCourses);
            this.tabPageCourse.Controls.Add(this.label3);
            this.tabPageCourse.Location = new System.Drawing.Point(4, 22);
            this.tabPageCourse.Name = "tabPageCourse";
            this.tabPageCourse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCourse.Size = new System.Drawing.Size(510, 182);
            this.tabPageCourse.TabIndex = 1;
            this.tabPageCourse.Text = "Курс";
            this.tabPageCourse.UseVisualStyleBackColor = true;
            // 
            // tabPageGroup
            // 
            this.tabPageGroup.Controls.Add(this.textBoxNewGName);
            this.tabPageGroup.Controls.Add(this.comboBoxGroups);
            this.tabPageGroup.Controls.Add(this.label6);
            this.tabPageGroup.Controls.Add(this.label5);
            this.tabPageGroup.Location = new System.Drawing.Point(4, 22);
            this.tabPageGroup.Name = "tabPageGroup";
            this.tabPageGroup.Size = new System.Drawing.Size(510, 182);
            this.tabPageGroup.TabIndex = 2;
            this.tabPageGroup.Text = "Группа";
            this.tabPageGroup.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Факультет для изменения:";
            // 
            // comboBoxFaculties
            // 
            this.comboBoxFaculties.FormattingEnabled = true;
            this.comboBoxFaculties.Location = new System.Drawing.Point(256, 5);
            this.comboBoxFaculties.Name = "comboBoxFaculties";
            this.comboBoxFaculties.Size = new System.Drawing.Size(248, 21);
            this.comboBoxFaculties.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(163, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Новое название";
            // 
            // textBoxNewFName
            // 
            this.textBoxNewFName.Location = new System.Drawing.Point(124, 100);
            this.textBoxNewFName.Name = "textBoxNewFName";
            this.textBoxNewFName.Size = new System.Drawing.Size(261, 20);
            this.textBoxNewFName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Курс для изменения";
            // 
            // comboBoxCourses
            // 
            this.comboBoxCourses.FormattingEnabled = true;
            this.comboBoxCourses.Location = new System.Drawing.Point(194, 9);
            this.comboBoxCourses.Name = "comboBoxCourses";
            this.comboBoxCourses.Size = new System.Drawing.Size(310, 21);
            this.comboBoxCourses.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(168, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Новое название";
            // 
            // textBoxNewCName
            // 
            this.textBoxNewCName.Location = new System.Drawing.Point(146, 112);
            this.textBoxNewCName.Name = "textBoxNewCName";
            this.textBoxNewCName.Size = new System.Drawing.Size(225, 20);
            this.textBoxNewCName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(5, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Группа для изменения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(170, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Новое название";
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.FormattingEnabled = true;
            this.comboBoxGroups.Location = new System.Drawing.Point(212, 12);
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.Size = new System.Drawing.Size(293, 21);
            this.comboBoxGroups.TabIndex = 2;
            // 
            // textBoxNewGName
            // 
            this.textBoxNewGName.Location = new System.Drawing.Point(154, 108);
            this.textBoxNewGName.Name = "textBoxNewGName";
            this.textBoxNewGName.Size = new System.Drawing.Size(216, 20);
            this.textBoxNewGName.TabIndex = 3;
            // 
            // UpdatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 268);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UpdatingForm";
            this.Text = "Обновить данные";
            this.Load += new System.EventHandler(this.UpdatingForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageFaculty.ResumeLayout(false);
            this.tabPageFaculty.PerformLayout();
            this.tabPageCourse.ResumeLayout(false);
            this.tabPageCourse.PerformLayout();
            this.tabPageGroup.ResumeLayout(false);
            this.tabPageGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFaculty;
        private System.Windows.Forms.TextBox textBoxNewFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFaculties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageCourse;
        private System.Windows.Forms.TextBox textBoxNewCName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCourses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPageGroup;
        private System.Windows.Forms.TextBox textBoxNewGName;
        private System.Windows.Forms.ComboBox comboBoxGroups;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}
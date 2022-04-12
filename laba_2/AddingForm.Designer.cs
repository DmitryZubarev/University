namespace laba_2
{
    partial class AddingForm
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
            this.btnAdding = new System.Windows.Forms.Button();
            this.tabControlAdding = new System.Windows.Forms.TabControl();
            this.tabPageFaculty = new System.Windows.Forms.TabPage();
            this.textBoxNewFaculty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFaculties = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageCourse = new System.Windows.Forms.TabPage();
            this.textBoxNewCourse = new System.Windows.Forms.TextBox();
            this.comboBoxFaculties2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCourses2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageGroup = new System.Windows.Forms.TabPage();
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.textBoxNewGroup = new System.Windows.Forms.TextBox();
            this.comboBoxCourses3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControlAdding.SuspendLayout();
            this.tabPageFaculty.SuspendLayout();
            this.tabPageCourse.SuspendLayout();
            this.tabPageGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnAdding, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabControlAdding, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(614, 410);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAdding
            // 
            this.btnAdding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdding.Location = new System.Drawing.Point(3, 351);
            this.btnAdding.Name = "btnAdding";
            this.btnAdding.Size = new System.Drawing.Size(608, 56);
            this.btnAdding.TabIndex = 0;
            this.btnAdding.Text = "Добавить";
            this.btnAdding.UseVisualStyleBackColor = false;
            this.btnAdding.Click += new System.EventHandler(this.btnAdding_Click);
            // 
            // tabControlAdding
            // 
            this.tabControlAdding.Controls.Add(this.tabPageFaculty);
            this.tabControlAdding.Controls.Add(this.tabPageCourse);
            this.tabControlAdding.Controls.Add(this.tabPageGroup);
            this.tabControlAdding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdding.Location = new System.Drawing.Point(3, 3);
            this.tabControlAdding.Name = "tabControlAdding";
            this.tabControlAdding.SelectedIndex = 0;
            this.tabControlAdding.Size = new System.Drawing.Size(608, 342);
            this.tabControlAdding.TabIndex = 1;
            // 
            // tabPageFaculty
            // 
            this.tabPageFaculty.Controls.Add(this.textBoxNewFaculty);
            this.tabPageFaculty.Controls.Add(this.label2);
            this.tabPageFaculty.Controls.Add(this.comboBoxFaculties);
            this.tabPageFaculty.Controls.Add(this.label1);
            this.tabPageFaculty.Location = new System.Drawing.Point(4, 22);
            this.tabPageFaculty.Name = "tabPageFaculty";
            this.tabPageFaculty.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFaculty.Size = new System.Drawing.Size(600, 316);
            this.tabPageFaculty.TabIndex = 0;
            this.tabPageFaculty.Text = "Факультет";
            this.tabPageFaculty.UseVisualStyleBackColor = true;
            // 
            // textBoxNewFaculty
            // 
            this.textBoxNewFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewFaculty.Location = new System.Drawing.Point(94, 173);
            this.textBoxNewFaculty.Name = "textBoxNewFaculty";
            this.textBoxNewFaculty.Size = new System.Drawing.Size(396, 26);
            this.textBoxNewFaculty.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(90, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите название нового факультета в поле";
            // 
            // comboBoxFaculties
            // 
            this.comboBoxFaculties.FormattingEnabled = true;
            this.comboBoxFaculties.Location = new System.Drawing.Point(230, 7);
            this.comboBoxFaculties.Name = "comboBoxFaculties";
            this.comboBoxFaculties.Size = new System.Drawing.Size(364, 21);
            this.comboBoxFaculties.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Существующие факультеты:";
            // 
            // tabPageCourse
            // 
            this.tabPageCourse.Controls.Add(this.textBoxNewCourse);
            this.tabPageCourse.Controls.Add(this.comboBoxFaculties2);
            this.tabPageCourse.Controls.Add(this.label5);
            this.tabPageCourse.Controls.Add(this.label4);
            this.tabPageCourse.Controls.Add(this.comboBoxCourses2);
            this.tabPageCourse.Controls.Add(this.label3);
            this.tabPageCourse.Location = new System.Drawing.Point(4, 22);
            this.tabPageCourse.Name = "tabPageCourse";
            this.tabPageCourse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCourse.Size = new System.Drawing.Size(600, 316);
            this.tabPageCourse.TabIndex = 1;
            this.tabPageCourse.Text = "Курс";
            this.tabPageCourse.UseVisualStyleBackColor = true;
            // 
            // textBoxNewCourse
            // 
            this.textBoxNewCourse.Location = new System.Drawing.Point(204, 242);
            this.textBoxNewCourse.Name = "textBoxNewCourse";
            this.textBoxNewCourse.Size = new System.Drawing.Size(214, 20);
            this.textBoxNewCourse.TabIndex = 5;
            // 
            // comboBoxFaculties2
            // 
            this.comboBoxFaculties2.FormattingEnabled = true;
            this.comboBoxFaculties2.Location = new System.Drawing.Point(204, 102);
            this.comboBoxFaculties2.Name = "comboBoxFaculties2";
            this.comboBoxFaculties2.Size = new System.Drawing.Size(390, 21);
            this.comboBoxFaculties2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(200, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Введите название курса";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Выберите факультет";
            // 
            // comboBoxCourses2
            // 
            this.comboBoxCourses2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCourses2.FormattingEnabled = true;
            this.comboBoxCourses2.Location = new System.Drawing.Point(179, 6);
            this.comboBoxCourses2.Name = "comboBoxCourses2";
            this.comboBoxCourses2.Size = new System.Drawing.Size(415, 21);
            this.comboBoxCourses2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Существующие курсы:";
            // 
            // tabPageGroup
            // 
            this.tabPageGroup.Controls.Add(this.comboBoxGroups);
            this.tabPageGroup.Controls.Add(this.textBoxNewGroup);
            this.tabPageGroup.Controls.Add(this.comboBoxCourses3);
            this.tabPageGroup.Controls.Add(this.label8);
            this.tabPageGroup.Controls.Add(this.label7);
            this.tabPageGroup.Controls.Add(this.label6);
            this.tabPageGroup.Location = new System.Drawing.Point(4, 22);
            this.tabPageGroup.Name = "tabPageGroup";
            this.tabPageGroup.Size = new System.Drawing.Size(600, 316);
            this.tabPageGroup.TabIndex = 2;
            this.tabPageGroup.Text = "Группа";
            this.tabPageGroup.UseVisualStyleBackColor = true;
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.FormattingEnabled = true;
            this.comboBoxGroups.Location = new System.Drawing.Point(211, 64);
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.Size = new System.Drawing.Size(384, 21);
            this.comboBoxGroups.TabIndex = 5;
            // 
            // textBoxNewGroup
            // 
            this.textBoxNewGroup.Location = new System.Drawing.Point(158, 239);
            this.textBoxNewGroup.Name = "textBoxNewGroup";
            this.textBoxNewGroup.Size = new System.Drawing.Size(281, 20);
            this.textBoxNewGroup.TabIndex = 4;
            // 
            // comboBoxCourses3
            // 
            this.comboBoxCourses3.FormattingEnabled = true;
            this.comboBoxCourses3.Location = new System.Drawing.Point(127, 3);
            this.comboBoxCourses3.Name = "comboBoxCourses3";
            this.comboBoxCourses3.Size = new System.Drawing.Size(468, 21);
            this.comboBoxCourses3.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(154, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Введите название новой группы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(5, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Существующие группы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Выберите курс";
            // 
            // AddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 410);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddingForm";
            this.Text = "Добавление данных";
            this.Load += new System.EventHandler(this.AddingForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControlAdding.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnAdding;
        private System.Windows.Forms.TabControl tabControlAdding;
        private System.Windows.Forms.TabPage tabPageFaculty;
        private System.Windows.Forms.TextBox textBoxNewFaculty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFaculties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageCourse;
        private System.Windows.Forms.TextBox textBoxNewCourse;
        private System.Windows.Forms.ComboBox comboBoxFaculties2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCourses2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPageGroup;
        private System.Windows.Forms.ComboBox comboBoxGroups;
        private System.Windows.Forms.TextBox textBoxNewGroup;
        private System.Windows.Forms.ComboBox comboBoxCourses3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}
namespace Simple_Login_Form
{
    partial class Form2
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            menueToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            panel_Inp = new Panel();
            btnClear = new Button();
            btnAdd = new Button();
            txtAgeIn = new TextBox();
            txtGenderIn = new TextBox();
            txtDegreeIn = new TextBox();
            textNameIn = new TextBox();
            lblGender = new Label();
            lblDegree = new Label();
            lblAge = new Label();
            lblName = new Label();
            panel_out = new Panel();
            txtAgeShow = new TextBox();
            txtGenderShow = new TextBox();
            txtDegreeShow = new TextBox();
            txtNameShow = new TextBox();
            stdGender = new Label();
            stdDegree = new Label();
            stdAge = new Label();
            stdName = new Label();
            openToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            panel_Inp.SuspendLayout();
            panel_out.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(958, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, menueToolStripMenuItem, exitToolStripMenuItem, openToolStripMenuItem, closeToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(270, 34);
            newToolStripMenuItem.Text = "New";
            // 
            // menueToolStripMenuItem
            // 
            menueToolStripMenuItem.Name = "menueToolStripMenuItem";
            menueToolStripMenuItem.Size = new Size(270, 34);
            menueToolStripMenuItem.Text = "Menue";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(270, 34);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "Edit";
            // 
            // panel_Inp
            // 
            panel_Inp.BackColor = Color.LightSteelBlue;
            panel_Inp.Controls.Add(btnClear);
            panel_Inp.Controls.Add(btnAdd);
            panel_Inp.Controls.Add(txtAgeIn);
            panel_Inp.Controls.Add(txtGenderIn);
            panel_Inp.Controls.Add(txtDegreeIn);
            panel_Inp.Controls.Add(textNameIn);
            panel_Inp.Controls.Add(lblGender);
            panel_Inp.Controls.Add(lblDegree);
            panel_Inp.Controls.Add(lblAge);
            panel_Inp.Controls.Add(lblName);
            panel_Inp.Location = new Point(12, 56);
            panel_Inp.Name = "panel_Inp";
            panel_Inp.Size = new Size(420, 351);
            panel_Inp.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(221, 256);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(41, 256);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 34);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtAgeIn
            // 
            txtAgeIn.Location = new Point(202, 71);
            txtAgeIn.Name = "txtAgeIn";
            txtAgeIn.Size = new Size(150, 31);
            txtAgeIn.TabIndex = 7;
            // 
            // txtGenderIn
            // 
            txtGenderIn.Location = new Point(202, 165);
            txtGenderIn.Name = "txtGenderIn";
            txtGenderIn.Size = new Size(150, 31);
            txtGenderIn.TabIndex = 6;
            // 
            // txtDegreeIn
            // 
            txtDegreeIn.Location = new Point(202, 119);
            txtDegreeIn.Name = "txtDegreeIn";
            txtDegreeIn.Size = new Size(150, 31);
            txtDegreeIn.TabIndex = 5;
            // 
            // textNameIn
            // 
            textNameIn.Location = new Point(202, 25);
            textNameIn.Name = "textNameIn";
            textNameIn.Size = new Size(150, 31);
            textNameIn.TabIndex = 4;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(41, 171);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(92, 32);
            lblGender.TabIndex = 3;
            lblGender.Text = "Gender";
            // 
            // lblDegree
            // 
            lblDegree.AutoSize = true;
            lblDegree.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDegree.Location = new Point(41, 125);
            lblDegree.Name = "lblDegree";
            lblDegree.Size = new Size(92, 32);
            lblDegree.TabIndex = 2;
            lblDegree.Text = "Degree";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(41, 77);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(56, 32);
            lblAge.TabIndex = 1;
            lblAge.Text = "Age";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(41, 31);
            lblName.Name = "lblName";
            lblName.Size = new Size(78, 32);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // panel_out
            // 
            panel_out.BackColor = Color.LightSteelBlue;
            panel_out.Controls.Add(txtAgeShow);
            panel_out.Controls.Add(txtGenderShow);
            panel_out.Controls.Add(txtDegreeShow);
            panel_out.Controls.Add(txtNameShow);
            panel_out.Controls.Add(stdGender);
            panel_out.Controls.Add(stdDegree);
            panel_out.Controls.Add(stdAge);
            panel_out.Controls.Add(stdName);
            panel_out.Location = new Point(504, 56);
            panel_out.Name = "panel_out";
            panel_out.Size = new Size(420, 351);
            panel_out.TabIndex = 10;
            // 
            // txtAgeShow
            // 
            txtAgeShow.Location = new Point(202, 95);
            txtAgeShow.Name = "txtAgeShow";
            txtAgeShow.Size = new Size(150, 31);
            txtAgeShow.TabIndex = 7;
            // 
            // txtGenderShow
            // 
            txtGenderShow.Location = new Point(202, 243);
            txtGenderShow.Name = "txtGenderShow";
            txtGenderShow.Size = new Size(150, 31);
            txtGenderShow.TabIndex = 6;
            // 
            // txtDegreeShow
            // 
            txtDegreeShow.Location = new Point(202, 171);
            txtDegreeShow.Name = "txtDegreeShow";
            txtDegreeShow.Size = new Size(150, 31);
            txtDegreeShow.TabIndex = 5;
            // 
            // txtNameShow
            // 
            txtNameShow.Location = new Point(202, 25);
            txtNameShow.Name = "txtNameShow";
            txtNameShow.Size = new Size(150, 31);
            txtNameShow.TabIndex = 4;
            // 
            // stdGender
            // 
            stdGender.AutoSize = true;
            stdGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stdGender.Location = new Point(41, 240);
            stdGender.Name = "stdGender";
            stdGender.Size = new Size(92, 32);
            stdGender.TabIndex = 3;
            stdGender.Text = "Gender";
            // 
            // stdDegree
            // 
            stdDegree.AutoSize = true;
            stdDegree.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stdDegree.Location = new Point(41, 171);
            stdDegree.Name = "stdDegree";
            stdDegree.Size = new Size(92, 32);
            stdDegree.TabIndex = 2;
            stdDegree.Text = "Degree";
            // 
            // stdAge
            // 
            stdAge.AutoSize = true;
            stdAge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stdAge.Location = new Point(41, 95);
            stdAge.Name = "stdAge";
            stdAge.Size = new Size(56, 32);
            stdAge.TabIndex = 1;
            stdAge.Text = "Age";
            // 
            // stdName
            // 
            stdName.AutoSize = true;
            stdName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stdName.Location = new Point(41, 31);
            stdName.Name = "stdName";
            stdName.Size = new Size(78, 32);
            stdName.TabIndex = 0;
            stdName.Text = "Name";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(270, 34);
            openToolStripMenuItem.Text = "Open";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(270, 34);
            closeToolStripMenuItem.Text = "Close";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(270, 34);
            saveToolStripMenuItem.Text = "Save";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 450);
            Controls.Add(panel_out);
            Controls.Add(panel_Inp);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel_Inp.ResumeLayout(false);
            panel_Inp.PerformLayout();
            panel_out.ResumeLayout(false);
            panel_out.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem menueToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private Panel panel_Inp;
        private Label lblGender;
        private Label lblDegree;
        private Label lblAge;
        private Label lblName;
        private TextBox txtAgeIn;
        private TextBox txtGenderIn;
        private TextBox txtDegreeIn;
        private TextBox textNameIn;
        private Button btnClear;
        private Button btnAdd;
        private Panel panel_out;
        private TextBox txtAgeShow;
        private TextBox txtGenderShow;
        private TextBox txtDegreeShow;
        private TextBox txtNameShow;
        private Label stdGender;
        private Label stdDegree;
        private Label stdAge;
        private Label stdName;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
    }
}
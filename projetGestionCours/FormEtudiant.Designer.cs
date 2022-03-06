namespace projetGestionCours
{
    partial class FormEtudiant
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
            this.txt_StudentEmailID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_StudentAddress = new System.Windows.Forms.TextBox();
            this.cmb_Class = new System.Windows.Forms.ComboBox();
            this.grid_Student = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Student_DOB = new System.Windows.Forms.DateTimePicker();
            this.txt_StudentMatricule = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_StudentLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_StudentFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.img_Box = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Student)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_StudentEmailID
            // 
            this.txt_StudentEmailID.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudentEmailID.Location = new System.Drawing.Point(111, 122);
            this.txt_StudentEmailID.Name = "txt_StudentEmailID";
            this.txt_StudentEmailID.Size = new System.Drawing.Size(264, 26);
            this.txt_StudentEmailID.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 38;
            this.label6.Text = "Email ID:";
            // 
            // txt_StudentAddress
            // 
            this.txt_StudentAddress.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudentAddress.Location = new System.Drawing.Point(111, 164);
            this.txt_StudentAddress.Multiline = true;
            this.txt_StudentAddress.Name = "txt_StudentAddress";
            this.txt_StudentAddress.Size = new System.Drawing.Size(645, 88);
            this.txt_StudentAddress.TabIndex = 16;
            // 
            // cmb_Class
            // 
            this.cmb_Class.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Class.FormattingEnabled = true;
            this.cmb_Class.Location = new System.Drawing.Point(494, 125);
            this.cmb_Class.Name = "cmb_Class";
            this.cmb_Class.Size = new System.Drawing.Size(263, 26);
            this.cmb_Class.TabIndex = 10;
            // 
            // grid_Student
            // 
            this.grid_Student.AllowUserToAddRows = false;
            this.grid_Student.AllowUserToDeleteRows = false;
            this.grid_Student.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.grid_Student.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid_Student.Location = new System.Drawing.Point(42, 350);
            this.grid_Student.Name = "grid_Student";
            this.grid_Student.ReadOnly = true;
            this.grid_Student.Size = new System.Drawing.Size(778, 272);
            this.grid_Student.TabIndex = 37;
            this.grid_Student.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Student_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_StudentEmailID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_StudentAddress);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.Student_DOB);
            this.groupBox1.Controls.Add(this.cmb_Class);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_StudentMatricule);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_StudentLastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_StudentFirstName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 291);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Etudiant Details";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 18);
            this.label13.TabIndex = 27;
            this.label13.Text = "Address :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(406, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Class :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Date Of birth :";
            // 
            // Student_DOB
            // 
            this.Student_DOB.CalendarFont = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_DOB.CustomFormat = "dd/MM/yyyy";
            this.Student_DOB.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Student_DOB.Location = new System.Drawing.Point(112, 76);
            this.Student_DOB.Name = "Student_DOB";
            this.Student_DOB.Size = new System.Drawing.Size(263, 26);
            this.Student_DOB.TabIndex = 5;
            // 
            // txt_StudentMatricule
            // 
            this.txt_StudentMatricule.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudentMatricule.Location = new System.Drawing.Point(494, 84);
            this.txt_StudentMatricule.Name = "txt_StudentMatricule";
            this.txt_StudentMatricule.Size = new System.Drawing.Size(263, 26);
            this.txt_StudentMatricule.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(406, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Matricule :";
            // 
            // txt_StudentLastName
            // 
            this.txt_StudentLastName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudentLastName.Location = new System.Drawing.Point(494, 35);
            this.txt_StudentLastName.Name = "txt_StudentLastName";
            this.txt_StudentLastName.Size = new System.Drawing.Size(263, 26);
            this.txt_StudentLastName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name :";
            // 
            // txt_StudentFirstName
            // 
            this.txt_StudentFirstName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudentFirstName.Location = new System.Drawing.Point(112, 35);
            this.txt_StudentFirstName.Name = "txt_StudentFirstName";
            this.txt_StudentFirstName.Size = new System.Drawing.Size(263, 26);
            this.txt_StudentFirstName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name :";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(48, 298);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(153, 40);
            this.btn_Close.TabIndex = 20;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(48, 251);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(153, 40);
            this.btn_Delete.TabIndex = 19;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(48, 203);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(153, 40);
            this.btn_Update.TabIndex = 18;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(48, 156);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(153, 40);
            this.btn_Insert.TabIndex = 17;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(432, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 33);
            this.label14.TabIndex = 36;
            this.label14.Text = "Etudiant";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.img_Box);
            this.groupBox2.Controls.Add(this.btn_Close);
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Controls.Add(this.btn_Update);
            this.groupBox2.Controls.Add(this.btn_Insert);
            this.groupBox2.Location = new System.Drawing.Point(838, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 394);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Etudiant Details";
            // 
            // img_Box
            // 
            this.img_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_Box.Image = global::projetGestionCours.Properties.Resources.img;
            this.img_Box.InitialImage = null;
            this.img_Box.Location = new System.Drawing.Point(48, 34);
            this.img_Box.Name = "img_Box";
            this.img_Box.Size = new System.Drawing.Size(155, 103);
            this.img_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Box.TabIndex = 9;
            this.img_Box.TabStop = false;
            // 
            // FormEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1145, 648);
            this.Controls.Add(this.grid_Student);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormEtudiant";
            this.Text = "FormEtudiant";
            ((System.ComponentModel.ISupportInitialize)(this.grid_Student)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_StudentEmailID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_StudentAddress;
        private System.Windows.Forms.ComboBox cmb_Class;
        private System.Windows.Forms.PictureBox img_Box;
        private System.Windows.Forms.DataGridView grid_Student;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Student_DOB;
        private System.Windows.Forms.TextBox txt_StudentMatricule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_StudentLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_StudentFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
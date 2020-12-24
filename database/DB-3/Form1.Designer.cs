namespace DB_3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nametext = new System.Windows.Forms.TextBox();
            this.contact_no_text = new System.Windows.Forms.TextBox();
            this.id_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.age_numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.gender_comboBox1 = new System.Windows.Forms.ComboBox();
            this.studentdataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDBDataSet1 = new DB_3.StudentDBDataSet1();
            this.insertButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.student_dataTableAdapter = new DB_3.StudentDBDataSet1TableAdapters.student_dataTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchtext = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.age_numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact_no";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Age";
            // 
            // nametext
            // 
            this.nametext.Location = new System.Drawing.Point(229, 129);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(135, 22);
            this.nametext.TabIndex = 6;
            // 
            // contact_no_text
            // 
            this.contact_no_text.Location = new System.Drawing.Point(229, 323);
            this.contact_no_text.Name = "contact_no_text";
            this.contact_no_text.Size = new System.Drawing.Size(135, 22);
            this.contact_no_text.TabIndex = 8;
            // 
            // id_text
            // 
            this.id_text.Location = new System.Drawing.Point(229, 193);
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(135, 22);
            this.id_text.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 43);
            this.label2.TabIndex = 11;
            this.label2.Text = "Student Details";
            // 
            // age_numericUpDown1
            // 
            this.age_numericUpDown1.Location = new System.Drawing.Point(229, 252);
            this.age_numericUpDown1.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.age_numericUpDown1.Name = "age_numericUpDown1";
            this.age_numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.age_numericUpDown1.TabIndex = 12;
            this.age_numericUpDown1.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // gender_comboBox1
            // 
            this.gender_comboBox1.FormattingEnabled = true;
            this.gender_comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender_comboBox1.Location = new System.Drawing.Point(228, 383);
            this.gender_comboBox1.Name = "gender_comboBox1";
            this.gender_comboBox1.Size = new System.Drawing.Size(121, 24);
            this.gender_comboBox1.TabIndex = 13;
            // 
            // studentdataBindingSource
            // 
            this.studentdataBindingSource.DataMember = "student_data";
            this.studentdataBindingSource.DataSource = this.studentDBDataSet1;
            // 
            // studentDBDataSet1
            // 
            this.studentDBDataSet1.DataSetName = "StudentDBDataSet1";
            this.studentDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(110, 477);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 15;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(518, 477);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = "search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(380, 477);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 17;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(243, 477);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 23);
            this.deletebutton.TabIndex = 18;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // student_dataTableAdapter
            // 
            this.student_dataTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(433, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(701, 319);
            this.dataGridView1.TabIndex = 19;
            // 
            // searchtext
            // 
            this.searchtext.Location = new System.Drawing.Point(648, 477);
            this.searchtext.Name = "searchtext";
            this.searchtext.Size = new System.Drawing.Size(100, 22);
            this.searchtext.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 592);
            this.Controls.Add(this.searchtext);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.gender_comboBox1);
            this.Controls.Add(this.age_numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id_text);
            this.Controls.Add(this.contact_no_text);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.age_numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.TextBox contact_no_text;
        private System.Windows.Forms.TextBox id_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown age_numericUpDown1;
        private System.Windows.Forms.ComboBox gender_comboBox1;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deletebutton;
        private StudentDBDataSet1 studentDBDataSet1;
        private System.Windows.Forms.BindingSource studentdataBindingSource;
        private StudentDBDataSet1TableAdapters.student_dataTableAdapter student_dataTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchtext;
    }
}


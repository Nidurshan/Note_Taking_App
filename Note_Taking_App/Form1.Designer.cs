namespace Note_Taking_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtTitle = new TextBox();
            txtMessage = new TextBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            btnNew = new Button();
            btnSave = new Button();
            btnRead = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 142);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 196);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Message";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(142, 139);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(167, 23);
            txtTitle.TabIndex = 2;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(142, 193);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(230, 144);
            txtMessage.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(472, 142);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(267, 198);
            dataGridView1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Mono", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(294, 37);
            label3.Name = "label3";
            label3.Size = new Size(255, 35);
            label3.TabIndex = 5;
            label3.Text = "Note Taking App";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(209, 385);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(90, 34);
            btnNew.TabIndex = 6;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(315, 385);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 34);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(421, 385);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(90, 34);
            btnRead.TabIndex = 8;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(526, 385);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 34);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(830, 472);
            Controls.Add(btnDelete);
            Controls.Add(btnRead);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(txtMessage);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTitle;
        private TextBox txtMessage;
        private DataGridView dataGridView1;
        private Label label3;
        private Button btnNew;
        private Button btnSave;
        private Button btnRead;
        private Button btnDelete;
    }
}

namespace NoteTakingApp
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
            Title = new RichTextBox();
            DeleteNote = new Button();
            SaveNote = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Content = new RichTextBox();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Location = new Point(84, 93);
            Title.Name = "Title";
            Title.Size = new Size(111, 24);
            Title.TabIndex = 0;
            Title.Text = "";
            // 
            // DeleteNote
            // 
            DeleteNote.BackColor = SystemColors.Control;
            DeleteNote.Font = new Font("Ink Free", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteNote.Location = new Point(347, 278);
            DeleteNote.Name = "DeleteNote";
            DeleteNote.Size = new Size(83, 26);
            DeleteNote.TabIndex = 3;
            DeleteNote.Text = "Delete";
            DeleteNote.UseVisualStyleBackColor = false;
            DeleteNote.Click += DeleteNote_Click;
            // 
            // SaveNote
            // 
            SaveNote.BackColor = SystemColors.Control;
            SaveNote.Font = new Font("Ink Free", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            SaveNote.Location = new Point(107, 278);
            SaveNote.Name = "SaveNote";
            SaveNote.Size = new Size(62, 30);
            SaveNote.TabIndex = 4;
            SaveNote.Text = "Save";
            SaveNote.UseVisualStyleBackColor = false;
            SaveNote.Click += SaveNote_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Ink Free", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(15, 9);
            label1.Name = "label1";
            label1.Size = new Size(152, 36);
            label1.TabIndex = 5;
            label1.Text = "Notes App";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ink Free", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(97, 72);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 6;
            label2.Text = "New Note";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ink Free", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(216, 70);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 7;
            label3.Text = "Previous Notes";
            // 
            // Content
            // 
            Content.Location = new Point(84, 123);
            Content.Name = "Content";
            Content.Size = new Size(111, 149);
            Content.TabIndex = 8;
            Content.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Ink Free", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(23, 96);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 9;
            label4.Text = "Title:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Ink Free", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(23, 123);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 10;
            label5.Text = "Text:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(216, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(329, 176);
            dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(557, 330);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Content);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SaveNote);
            Controls.Add(DeleteNote);
            Controls.Add(Title);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox Title;
        private Button DeleteNote;
        private Button SaveNote;
        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox Content;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
    }
}
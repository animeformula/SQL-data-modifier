namespace sql_table_modifier
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
            this.ConnectSQLBtn = new System.Windows.Forms.Button();
            this.StudentIDText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SubjectText = new System.Windows.Forms.TextBox();
            this.StudentNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.FindText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.FindBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectSQLBtn
            // 
            this.ConnectSQLBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectSQLBtn.Location = new System.Drawing.Point(12, 12);
            this.ConnectSQLBtn.Name = "ConnectSQLBtn";
            this.ConnectSQLBtn.Size = new System.Drawing.Size(125, 48);
            this.ConnectSQLBtn.TabIndex = 0;
            this.ConnectSQLBtn.Text = "Connect Sql";
            this.ConnectSQLBtn.UseVisualStyleBackColor = true;
            this.ConnectSQLBtn.Click += new System.EventHandler(this.ConnectSQLBtn_Click);
            // 
            // StudentIDText
            // 
            this.StudentIDText.Location = new System.Drawing.Point(121, 63);
            this.StudentIDText.Multiline = true;
            this.StudentIDText.Name = "StudentIDText";
            this.StudentIDText.Size = new System.Drawing.Size(103, 22);
            this.StudentIDText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InsertBtn
            // 
            this.InsertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertBtn.Location = new System.Drawing.Point(143, 12);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(125, 48);
            this.InsertBtn.TabIndex = 8;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(274, 12);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(125, 48);
            this.UpdateBtn.TabIndex = 9;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(405, 12);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(256, 48);
            this.DeleteBtn.TabIndex = 10;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(449, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Subject";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SubjectText
            // 
            this.SubjectText.Location = new System.Drawing.Point(558, 63);
            this.SubjectText.Multiline = true;
            this.SubjectText.Name = "SubjectText";
            this.SubjectText.Size = new System.Drawing.Size(103, 22);
            this.SubjectText.TabIndex = 13;
            // 
            // StudentNameText
            // 
            this.StudentNameText.Location = new System.Drawing.Point(338, 63);
            this.StudentNameText.Multiline = true;
            this.StudentNameText.Name = "StudentNameText";
            this.StudentNameText.Size = new System.Drawing.Size(103, 22);
            this.StudentNameText.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(230, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Student Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 273);
            this.dataGridView1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(13, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 32);
            this.label4.TabIndex = 17;
            this.label4.Text = "Find by ID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FindText
            // 
            this.FindText.Location = new System.Drawing.Point(121, 371);
            this.FindText.Multiline = true;
            this.FindText.Name = "FindText";
            this.FindText.Size = new System.Drawing.Size(278, 32);
            this.FindText.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(558, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 33);
            this.button1.TabIndex = 19;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FindBtn
            // 
            this.FindBtn.BackColor = System.Drawing.Color.Lime;
            this.FindBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindBtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.FindBtn.Location = new System.Drawing.Point(405, 371);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(103, 33);
            this.FindBtn.TabIndex = 20;
            this.FindBtn.Text = "Find";
            this.FindBtn.UseVisualStyleBackColor = false;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 415);
            this.Controls.Add(this.FindBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FindText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StudentNameText);
            this.Controls.Add(this.SubjectText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentIDText);
            this.Controls.Add(this.ConnectSQLBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectSQLBtn;
        private System.Windows.Forms.TextBox StudentIDText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SubjectText;
        private System.Windows.Forms.TextBox StudentNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FindText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button FindBtn;
    }
}


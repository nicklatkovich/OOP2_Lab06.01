namespace OOP_Lab06._01 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose( );
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( ) {
            this.TextInput = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextInput
            // 
            this.TextInput.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextInput.Location = new System.Drawing.Point(238, 12);
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(188, 32);
            this.TextInput.TabIndex = 1;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(281, 61);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(111, 23);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ListBox
            // 
            this.ListBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 24;
            this.ListBox.Location = new System.Drawing.Point(12, 12);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(220, 364);
            this.ListBox.TabIndex = 3;
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Location = new System.Drawing.Point(281, 90);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(111, 23);
            this.ButtonRemove.TabIndex = 4;
            this.ButtonRemove.Text = "Remove";
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // ButtonSort
            // 
            this.ButtonSort.Location = new System.Drawing.Point(281, 119);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(111, 23);
            this.ButtonSort.TabIndex = 5;
            this.ButtonSort.Text = "Change Sort";
            this.ButtonSort.UseVisualStyleBackColor = true;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 389);
            this.Controls.Add(this.ButtonSort);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TextInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextInput;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Button ButtonRemove;
        private System.Windows.Forms.Button ButtonSort;
    }
}


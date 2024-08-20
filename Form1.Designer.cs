namespace Lecture_6_Arrays
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
            btnSimpleArray = new Button();
            lbxArrays = new ListBox();
            btnWriteArrayToFile = new Button();
            btnReadDataIn = new Button();
            btn2DArray = new Button();
            btnLists = new Button();
            btnListFind = new Button();
            btnSortingAdvanced = new Button();
            SuspendLayout();
            // 
            // btnSimpleArray
            // 
            btnSimpleArray.Location = new Point(300, 75);
            btnSimpleArray.Name = "btnSimpleArray";
            btnSimpleArray.Size = new Size(93, 30);
            btnSimpleArray.TabIndex = 0;
            btnSimpleArray.Text = "SimpleArray";
            btnSimpleArray.UseVisualStyleBackColor = true;
            btnSimpleArray.Click += btnSimpleArray_Click;
            // 
            // lbxArrays
            // 
            lbxArrays.FormattingEnabled = true;
            lbxArrays.ItemHeight = 15;
            lbxArrays.Location = new Point(452, 54);
            lbxArrays.Name = "lbxArrays";
            lbxArrays.Size = new Size(347, 394);
            lbxArrays.TabIndex = 1;
            lbxArrays.SelectedIndexChanged += lbxArrays_SelectedIndexChanged;
            // 
            // btnWriteArrayToFile
            // 
            btnWriteArrayToFile.Location = new Point(299, 128);
            btnWriteArrayToFile.Name = "btnWriteArrayToFile";
            btnWriteArrayToFile.Size = new Size(94, 43);
            btnWriteArrayToFile.TabIndex = 2;
            btnWriteArrayToFile.Text = "Write to File";
            btnWriteArrayToFile.UseVisualStyleBackColor = true;
            btnWriteArrayToFile.Click += btnWriteArrayToFile_Click;
            // 
            // btnReadDataIn
            // 
            btnReadDataIn.Location = new Point(296, 186);
            btnReadDataIn.Name = "btnReadDataIn";
            btnReadDataIn.Size = new Size(97, 33);
            btnReadDataIn.TabIndex = 3;
            btnReadDataIn.Text = "Read Data In";
            btnReadDataIn.UseVisualStyleBackColor = true;
            btnReadDataIn.Click += btnReadDataIn_Click;
            // 
            // btn2DArray
            // 
            btn2DArray.Location = new Point(296, 237);
            btn2DArray.Name = "btn2DArray";
            btn2DArray.Size = new Size(97, 23);
            btn2DArray.TabIndex = 4;
            btn2DArray.Text = "2D Arrays";
            btn2DArray.UseVisualStyleBackColor = true;
            btn2DArray.Click += btn2DArray_Click;
            // 
            // btnLists
            // 
            btnLists.Location = new Point(296, 276);
            btnLists.Name = "btnLists";
            btnLists.Size = new Size(97, 42);
            btnLists.TabIndex = 5;
            btnLists.Text = "Working with Lists";
            btnLists.UseVisualStyleBackColor = true;
            btnLists.Click += btnLists_Click;
            // 
            // btnListFind
            // 
            btnListFind.Location = new Point(296, 334);
            btnListFind.Name = "btnListFind";
            btnListFind.Size = new Size(97, 42);
            btnListFind.TabIndex = 6;
            btnListFind.Text = "Find in Lists";
            btnListFind.UseVisualStyleBackColor = true;
            btnListFind.Click += btnListFind_Click;
            // 
            // btnSortingAdvanced
            // 
            btnSortingAdvanced.Location = new Point(296, 382);
            btnSortingAdvanced.Name = "btnSortingAdvanced";
            btnSortingAdvanced.Size = new Size(97, 42);
            btnSortingAdvanced.TabIndex = 7;
            btnSortingAdvanced.Text = "Advanced sorting";
            btnSortingAdvanced.UseVisualStyleBackColor = true;
            btnSortingAdvanced.Click += btnSortingAdvanced_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSortingAdvanced);
            Controls.Add(btnListFind);
            Controls.Add(btnLists);
            Controls.Add(btn2DArray);
            Controls.Add(btnReadDataIn);
            Controls.Add(btnWriteArrayToFile);
            Controls.Add(lbxArrays);
            Controls.Add(btnSimpleArray);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSimpleArray;
        private ListBox lbxArrays;
        private Button btnWriteArrayToFile;
        private Button btnReadDataIn;
        private Button btn2DArray;
        private Button btnLists;
        private Button btnListFind;
        private Button btnSortingAdvanced;
    }
}

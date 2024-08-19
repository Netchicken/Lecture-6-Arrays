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
            lbxArrays.Size = new Size(285, 244);
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
            btnReadDataIn.Location = new Point(303, 187);
            btnReadDataIn.Name = "btnReadDataIn";
            btnReadDataIn.Size = new Size(75, 23);
            btnReadDataIn.TabIndex = 3;
            btnReadDataIn.Text = "Read Data In";
            btnReadDataIn.UseVisualStyleBackColor = true;
            btnReadDataIn.Click += btnReadDataIn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}

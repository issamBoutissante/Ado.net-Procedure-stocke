
namespace Stored_Procedures
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
            this.NumClient = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComptesdataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TestReturnValue = new System.Windows.Forms.Button();
            this.returnValueTxt = new System.Windows.Forms.TextBox();
            this.outputTxt = new System.Windows.Forms.TextBox();
            this.TestOutput = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ComptesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NumClient
            // 
            this.NumClient.FormattingEnabled = true;
            this.NumClient.Location = new System.Drawing.Point(185, 67);
            this.NumClient.Name = "NumClient";
            this.NumClient.Size = new System.Drawing.Size(121, 21);
            this.NumClient.TabIndex = 10;
            this.NumClient.SelectedIndexChanged += new System.EventHandler(this.NumClient_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Comptes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Num Client";
            // 
            // ComptesdataGridView
            // 
            this.ComptesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComptesdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.ComptesdataGridView.Location = new System.Drawing.Point(75, 111);
            this.ComptesdataGridView.Name = "ComptesdataGridView";
            this.ComptesdataGridView.Size = new System.Drawing.Size(231, 129);
            this.ComptesdataGridView.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "num compte";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "solde";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "type";
            this.Column3.Name = "Column3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Les procedures stockee dans une application ado";
            // 
            // TestReturnValue
            // 
            this.TestReturnValue.Location = new System.Drawing.Point(312, 142);
            this.TestReturnValue.Name = "TestReturnValue";
            this.TestReturnValue.Size = new System.Drawing.Size(108, 23);
            this.TestReturnValue.TabIndex = 11;
            this.TestReturnValue.Text = "Test Return Value";
            this.TestReturnValue.UseVisualStyleBackColor = true;
            this.TestReturnValue.Click += new System.EventHandler(this.TestReturnValue_Click);
            // 
            // returnValueTxt
            // 
            this.returnValueTxt.Location = new System.Drawing.Point(439, 142);
            this.returnValueTxt.Name = "returnValueTxt";
            this.returnValueTxt.Size = new System.Drawing.Size(100, 20);
            this.returnValueTxt.TabIndex = 12;
            // 
            // outputTxt
            // 
            this.outputTxt.Location = new System.Drawing.Point(439, 179);
            this.outputTxt.Name = "outputTxt";
            this.outputTxt.Size = new System.Drawing.Size(100, 20);
            this.outputTxt.TabIndex = 14;
            // 
            // TestOutput
            // 
            this.TestOutput.Location = new System.Drawing.Point(312, 179);
            this.TestOutput.Name = "TestOutput";
            this.TestOutput.Size = new System.Drawing.Size(108, 23);
            this.TestOutput.TabIndex = 13;
            this.TestOutput.Text = "Test Output";
            this.TestOutput.UseVisualStyleBackColor = true;
            this.TestOutput.Click += new System.EventHandler(this.TestOutput_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Last Page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 269);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outputTxt);
            this.Controls.Add(this.TestOutput);
            this.Controls.Add(this.returnValueTxt);
            this.Controls.Add(this.TestReturnValue);
            this.Controls.Add(this.NumClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComptesdataGridView);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComptesdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NumClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ComptesdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TestReturnValue;
        private System.Windows.Forms.TextBox returnValueTxt;
        private System.Windows.Forms.TextBox outputTxt;
        private System.Windows.Forms.Button TestOutput;
        private System.Windows.Forms.Button button1;
    }
}
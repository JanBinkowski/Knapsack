
namespace KnapsackForm
{
    partial class Knapsack
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSeed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.rtbTotalValue = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbSequence = new System.Windows.Forms.RichTextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSeed);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // tbSeed
            // 
            this.tbSeed.Location = new System.Drawing.Point(446, 20);
            this.tbSeed.Name = "tbSeed";
            this.tbSeed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbSeed.Size = new System.Drawing.Size(78, 20);
            this.tbSeed.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Generator seed =";
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(238, 20);
            this.tbC.Name = "tbC";
            this.tbC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbC.Size = new System.Drawing.Size(70, 20);
            this.tbC.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Capacity =";
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(59, 20);
            this.tbN.Name = "tbN";
            this.tbN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbN.Size = new System.Drawing.Size(67, 20);
            this.tbN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "n =";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbItems);
            this.groupBox2.Controls.Add(this.rtbTotalValue);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rtbSequence);
            this.groupBox2.Location = new System.Drawing.Point(12, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 171);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Items.AddRange(new object[] {
            "Item\tWeight\tValue"});
            this.lbItems.Location = new System.Drawing.Point(6, 18);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(142, 147);
            this.lbItems.TabIndex = 4;
            // 
            // rtbTotalValue
            // 
            this.rtbTotalValue.Location = new System.Drawing.Point(351, 132);
            this.rtbTotalValue.Name = "rtbTotalValue";
            this.rtbTotalValue.ReadOnly = true;
            this.rtbTotalValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbTotalValue.Size = new System.Drawing.Size(81, 18);
            this.rtbTotalValue.TabIndex = 3;
            this.rtbTotalValue.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(235, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total value:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 48);
            this.label4.MaximumSize = new System.Drawing.Size(150, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 36);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sequence of inserted items:";
            // 
            // rtbSequence
            // 
            this.rtbSequence.Location = new System.Drawing.Point(351, 18);
            this.rtbSequence.Name = "rtbSequence";
            this.rtbSequence.ReadOnly = true;
            this.rtbSequence.Size = new System.Drawing.Size(173, 96);
            this.rtbSequence.TabIndex = 0;
            this.rtbSequence.Text = "";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(250, 70);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(70, 20);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // Knapsack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 281);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Knapsack";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbTotalValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbSequence;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.Button btnGenerate;
    }
}


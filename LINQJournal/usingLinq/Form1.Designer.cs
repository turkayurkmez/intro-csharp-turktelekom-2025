namespace usingLinq
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
            splitContainer1 = new SplitContainer();
            buttonOrder = new Button();
            buttonMax = new Button();
            buttonGetp = new Button();
            dataGridView1 = new DataGridView();
            buttonGroup = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(buttonGroup);
            splitContainer1.Panel1.Controls.Add(buttonOrder);
            splitContainer1.Panel1.Controls.Add(buttonMax);
            splitContainer1.Panel1.Controls.Add(buttonGetp);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // buttonOrder
            // 
            buttonOrder.Location = new Point(40, 132);
            buttonOrder.Name = "buttonOrder";
            buttonOrder.Size = new Size(175, 29);
            buttonOrder.TabIndex = 2;
            buttonOrder.Text = "Sırala";
            buttonOrder.UseVisualStyleBackColor = true;
            buttonOrder.Click += buttonOrder_Click;
            // 
            // buttonMax
            // 
            buttonMax.Location = new Point(41, 81);
            buttonMax.Name = "buttonMax";
            buttonMax.Size = new Size(174, 29);
            buttonMax.TabIndex = 1;
            buttonMax.Text = "En pahalı ürün";
            buttonMax.UseVisualStyleBackColor = true;
            buttonMax.Click += buttonMax_Click;
            // 
            // buttonGetp
            // 
            buttonGetp.Location = new Point(36, 39);
            buttonGetp.Name = "buttonGetp";
            buttonGetp.Size = new Size(179, 29);
            buttonGetp.TabIndex = 0;
            buttonGetp.Text = "Get Products";
            buttonGetp.UseVisualStyleBackColor = true;
            buttonGetp.Click += buttonGetp_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(526, 446);
            dataGridView1.TabIndex = 0;
            // 
            // buttonGroup
            // 
            buttonGroup.Location = new Point(40, 185);
            buttonGroup.Name = "buttonGroup";
            buttonGroup.Size = new Size(175, 29);
            buttonGroup.TabIndex = 3;
            buttonGroup.Text = "Gruplama";
            buttonGroup.UseVisualStyleBackColor = true;
            buttonGroup.Click += buttonGroup_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private Button buttonGetp;
        private Button buttonMax;
        private Button buttonOrder;
        private Button buttonGroup;
    }
}

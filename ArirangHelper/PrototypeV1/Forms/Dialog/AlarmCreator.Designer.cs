namespace PrototypeV1.Forms.Dialog
{
    partial class AlarmCreator
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
            panel_Container = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            panel6 = new Panel();
            comboBox_Type = new ComboBox();
            panel7 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            comboBox_ClientTarget = new ComboBox();
            panel3 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel_Container.SuspendLayout();
            panel8.SuspendLayout();
            panel10.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Container
            // 
            panel_Container.Controls.Add(panel8);
            panel_Container.Controls.Add(panel4);
            panel_Container.Controls.Add(panel2);
            panel_Container.Controls.Add(panel1);
            panel_Container.Dock = DockStyle.Fill;
            panel_Container.Location = new Point(0, 0);
            panel_Container.Name = "panel_Container";
            panel_Container.Size = new Size(454, 190);
            panel_Container.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(panel10);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 132);
            panel8.Name = "panel8";
            panel8.Size = new Size(454, 50);
            panel8.TabIndex = 4;
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(107, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(347, 50);
            panel9.TabIndex = 4;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(50, 50, 50);
            panel10.Controls.Add(label3);
            panel10.Dock = DockStyle.Left;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(107, 50);
            panel10.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(17, 16);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 1;
            label3.Text = "Options";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel7);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 82);
            panel4.Name = "panel4";
            panel4.Size = new Size(454, 50);
            panel4.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(comboBox_Type);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(107, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(347, 50);
            panel6.TabIndex = 4;
            // 
            // comboBox_Type
            // 
            comboBox_Type.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Type.FormattingEnabled = true;
            comboBox_Type.Items.AddRange(new object[] { "로컬 감지", "광물 소멸" });
            comboBox_Type.Location = new Point(14, 13);
            comboBox_Type.Name = "comboBox_Type";
            comboBox_Type.Size = new Size(311, 23);
            comboBox_Type.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(50, 50, 50);
            panel7.Controls.Add(label2);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(107, 50);
            panel7.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(17, 16);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "Type";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(454, 50);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(comboBox_ClientTarget);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(107, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(347, 50);
            panel5.TabIndex = 4;
            // 
            // comboBox_ClientTarget
            // 
            comboBox_ClientTarget.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_ClientTarget.FormattingEnabled = true;
            comboBox_ClientTarget.Location = new Point(14, 13);
            comboBox_ClientTarget.Name = "comboBox_ClientTarget";
            comboBox_ClientTarget.Size = new Size(311, 23);
            comboBox_ClientTarget.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(50, 50, 50);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(107, 50);
            panel3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(17, 17);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 1;
            label1.Text = "Client Target";
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 32);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(373, 5);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "생성";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(7, 4);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "새로고침";
            button1.UseVisualStyleBackColor = true;
            // 
            // AlarmCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(454, 190);
            ControlBox = false;
            Controls.Add(panel_Container);
            Name = "AlarmCreator";
            Text = "AlarmCreator";
            panel_Container.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Container;
        private Panel panel1;
        private Panel panel2;
        private ComboBox comboBox_ClientTarget;
        private Label label1;
        private Panel panel5;
        private Panel panel3;
        private Button button1;
        private Panel panel4;
        private Panel panel6;
        private ComboBox comboBox_Type;
        private Panel panel7;
        private Label label2;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Label label3;
        private Button button2;
    }
}
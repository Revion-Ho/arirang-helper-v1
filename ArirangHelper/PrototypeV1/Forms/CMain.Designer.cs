namespace PrototypeV1.Forms
{
    partial class CMain
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
            menuStrip1 = new MenuStrip();
            프로그램ToolStripMenuItem = new ToolStripMenuItem();
            MenuItem_EXIT = new ToolStripMenuItem();
            panel_Container = new Panel();
            statusStrip1 = new StatusStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 프로그램ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1097, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 프로그램ToolStripMenuItem
            // 
            프로그램ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MenuItem_EXIT });
            프로그램ToolStripMenuItem.Name = "프로그램ToolStripMenuItem";
            프로그램ToolStripMenuItem.Size = new Size(67, 20);
            프로그램ToolStripMenuItem.Text = "프로그램";
            // 
            // MenuItem_EXIT
            // 
            MenuItem_EXIT.Name = "MenuItem_EXIT";
            MenuItem_EXIT.Size = new Size(180, 22);
            MenuItem_EXIT.Text = "끝내기";
            // 
            // panel_Container
            // 
            panel_Container.Dock = DockStyle.Fill;
            panel_Container.Location = new Point(0, 24);
            panel_Container.Name = "panel_Container";
            panel_Container.Size = new Size(1097, 702);
            panel_Container.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 726);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1097, 22);
            statusStrip1.TabIndex = 2;
            // 
            // CMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 748);
            ControlBox = false;
            Controls.Add(panel_Container);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CMain";
            Text = "CMain";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 프로그램ToolStripMenuItem;
        private ToolStripMenuItem MenuItem_EXIT;
        private Panel panel_Container;
        private StatusStrip statusStrip1;
    }
}
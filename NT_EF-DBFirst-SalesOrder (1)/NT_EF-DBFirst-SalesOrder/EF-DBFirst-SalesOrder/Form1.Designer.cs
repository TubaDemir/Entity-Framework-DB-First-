namespace EF_DBFirst_SalesOrder
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siparilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişGörüntülemeDüzeltmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparilerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparilerToolStripMenuItem
            // 
            this.siparilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişGirişToolStripMenuItem,
            this.siparişGörüntülemeDüzeltmeToolStripMenuItem});
            this.siparilerToolStripMenuItem.Name = "siparilerToolStripMenuItem";
            this.siparilerToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.siparilerToolStripMenuItem.Text = "Sipariler";
            // 
            // siparişGirişToolStripMenuItem
            // 
            this.siparişGirişToolStripMenuItem.Name = "siparişGirişToolStripMenuItem";
            this.siparişGirişToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.siparişGirişToolStripMenuItem.Text = "Sipariş Giriş";
            this.siparişGirişToolStripMenuItem.Click += new System.EventHandler(this.siparişGirişToolStripMenuItem_Click);
            // 
            // siparişGörüntülemeDüzeltmeToolStripMenuItem
            // 
            this.siparişGörüntülemeDüzeltmeToolStripMenuItem.Name = "siparişGörüntülemeDüzeltmeToolStripMenuItem";
            this.siparişGörüntülemeDüzeltmeToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.siparişGörüntülemeDüzeltmeToolStripMenuItem.Text = "Sipariş Görüntüleme / Düzeltme";
            this.siparişGörüntülemeDüzeltmeToolStripMenuItem.Click += new System.EventHandler(this.siparişGörüntülemeDüzeltmeToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(73, 153);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(636, 205);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişGörüntülemeDüzeltmeToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}


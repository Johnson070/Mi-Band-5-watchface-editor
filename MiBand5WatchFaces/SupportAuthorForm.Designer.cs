
namespace MiBand5WatchFaces
{
    partial class SupportAuthorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupportAuthorForm));
            this.BTCbutton = new System.Windows.Forms.Button();
            this.ETHbutton = new System.Windows.Forms.Button();
            this.USDTbutton = new System.Windows.Forms.Button();
            this.PayPalbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTCbutton
            // 
            resources.ApplyResources(this.BTCbutton, "BTCbutton");
            this.BTCbutton.Name = "BTCbutton";
            this.BTCbutton.UseVisualStyleBackColor = true;
            this.BTCbutton.Click += new System.EventHandler(this.BTCbutton_Click);
            // 
            // ETHbutton
            // 
            resources.ApplyResources(this.ETHbutton, "ETHbutton");
            this.ETHbutton.Name = "ETHbutton";
            this.ETHbutton.UseVisualStyleBackColor = true;
            this.ETHbutton.Click += new System.EventHandler(this.ETHbutton_Click);
            // 
            // USDTbutton
            // 
            resources.ApplyResources(this.USDTbutton, "USDTbutton");
            this.USDTbutton.Name = "USDTbutton";
            this.USDTbutton.UseVisualStyleBackColor = true;
            this.USDTbutton.Click += new System.EventHandler(this.USDTbutton_Click);
            // 
            // PayPalbutton
            // 
            resources.ApplyResources(this.PayPalbutton, "PayPalbutton");
            this.PayPalbutton.Name = "PayPalbutton";
            this.PayPalbutton.UseVisualStyleBackColor = true;
            this.PayPalbutton.Click += new System.EventHandler(this.PayPalbutton_Click);
            // 
            // SupportAuthorForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PayPalbutton);
            this.Controls.Add(this.USDTbutton);
            this.Controls.Add(this.ETHbutton);
            this.Controls.Add(this.BTCbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SupportAuthorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTCbutton;
        private System.Windows.Forms.Button ETHbutton;
        private System.Windows.Forms.Button USDTbutton;
        private System.Windows.Forms.Button PayPalbutton;
    }
}
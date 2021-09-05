
namespace Travel_Hut
{
    partial class TravelHut
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
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.displayTravelInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGetInfo.Location = new System.Drawing.Point(334, 171);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(75, 23);
            this.btnGetInfo.TabIndex = 0;
            this.btnGetInfo.Text = "Get Info\r\n\r\n";
            this.btnGetInfo.UseVisualStyleBackColor = false;
            this.btnGetInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // displayTravelInfo
            // 
            this.displayTravelInfo.Location = new System.Drawing.Point(172, 265);
            this.displayTravelInfo.Multiline = true;
            this.displayTravelInfo.Name = "displayTravelInfo";
            this.displayTravelInfo.Size = new System.Drawing.Size(420, 147);
            this.displayTravelInfo.TabIndex = 1;
            this.displayTravelInfo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TravelHut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayTravelInfo);
            this.Controls.Add(this.btnGetInfo);
            this.Name = "TravelHut";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.TextBox displayTravelInfo;
    }
}


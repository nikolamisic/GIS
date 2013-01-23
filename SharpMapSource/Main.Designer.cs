namespace SharpMapSource
{
    partial class Main
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
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomFull = new System.Windows.Forms.Button();
            this.pbxMapa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMapa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Location = new System.Drawing.Point(12, 12);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(75, 23);
            this.btnZoomIn.TabIndex = 0;
            this.btnZoomIn.Text = "Zoom in";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Location = new System.Drawing.Point(93, 12);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(75, 23);
            this.btnZoomOut.TabIndex = 1;
            this.btnZoomOut.Text = "Zoom out";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomFull
            // 
            this.btnZoomFull.Location = new System.Drawing.Point(174, 12);
            this.btnZoomFull.Name = "btnZoomFull";
            this.btnZoomFull.Size = new System.Drawing.Size(75, 23);
            this.btnZoomFull.TabIndex = 2;
            this.btnZoomFull.Text = "Zoom to full";
            this.btnZoomFull.UseVisualStyleBackColor = true;
            this.btnZoomFull.Click += new System.EventHandler(this.btnZoomFull_Click);
            // 
            // pbxMapa
            // 
            this.pbxMapa.Location = new System.Drawing.Point(12, 41);
            this.pbxMapa.Name = "pbxMapa";
            this.pbxMapa.Size = new System.Drawing.Size(747, 301);
            this.pbxMapa.TabIndex = 3;
            this.pbxMapa.TabStop = false;
            this.pbxMapa.Click += new System.EventHandler(this.pbxMapa_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 354);
            this.Controls.Add(this.pbxMapa);
            this.Controls.Add(this.btnZoomFull);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.btnZoomIn);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMapa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomFull;
        private System.Windows.Forms.PictureBox pbxMapa;
    }
}


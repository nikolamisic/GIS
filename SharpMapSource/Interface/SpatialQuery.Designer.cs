namespace SharpMapSource.Interface
{
    partial class SpatialQuery
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
            this._cmbLayer1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._cmbOperation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this._cmbLayer2 = new System.Windows.Forms.ComboBox();
            this._txtbDistance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._cmbUnits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _cmbLayer1
            // 
            this._cmbLayer1.FormattingEnabled = true;
            this._cmbLayer1.Location = new System.Drawing.Point(131, 6);
            this._cmbLayer1.Name = "_cmbLayer1";
            this._cmbLayer1.Size = new System.Drawing.Size(121, 21);
            this._cmbLayer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prikazi sve geometrije iz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "koje";
            // 
            // _cmbOperation
            // 
            this._cmbOperation.FormattingEnabled = true;
            this._cmbOperation.Items.AddRange(new object[] {
            "se seku",
            "su unutar",
            "su van"});
            this._cmbOperation.Location = new System.Drawing.Point(131, 45);
            this._cmbOperation.Name = "_cmbOperation";
            this._cmbOperation.Size = new System.Drawing.Size(121, 21);
            this._cmbOperation.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "od layera:";
            // 
            // _cmbLayer2
            // 
            this._cmbLayer2.FormattingEnabled = true;
            this._cmbLayer2.Location = new System.Drawing.Point(131, 103);
            this._cmbLayer2.Name = "_cmbLayer2";
            this._cmbLayer2.Size = new System.Drawing.Size(121, 21);
            this._cmbLayer2.TabIndex = 5;
            // 
            // _txtbDistance
            // 
            this._txtbDistance.Location = new System.Drawing.Point(131, 71);
            this._txtbDistance.Name = "_txtbDistance";
            this._txtbDistance.Size = new System.Drawing.Size(26, 20);
            this._txtbDistance.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "sa distancom:";
            // 
            // _cmbUnits
            // 
            this._cmbUnits.FormattingEnabled = true;
            this._cmbUnits.Items.AddRange(new object[] {
            "metrima",
            "centimetrima",
            "kilometrima"});
            this._cmbUnits.Location = new System.Drawing.Point(199, 72);
            this._cmbUnits.Name = "_cmbUnits";
            this._cmbUnits.Size = new System.Drawing.Size(53, 21);
            this._cmbUnits.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "u";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Izvrsi Upit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SpatialQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 178);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._cmbUnits);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._txtbDistance);
            this.Controls.Add(this._cmbLayer2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._cmbOperation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cmbLayer1);
            this.Name = "SpatialQuery";
            this.Text = "SpatialQuery";
            this.Load += new System.EventHandler(this.SpatialQuery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _cmbLayer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _cmbOperation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _cmbLayer2;
        private System.Windows.Forms.TextBox _txtbDistance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox _cmbUnits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}
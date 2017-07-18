namespace DesignPatterns.Proxy.Exemplo
{
	partial class frmImage
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
			this.pcbImage = new System.Windows.Forms.PictureBox();
			this.ofdSelect = new System.Windows.Forms.OpenFileDialog();
			this.btnSelect = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.txtPath = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
			this.SuspendLayout();
			// 
			// pcbImage
			// 
			this.pcbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pcbImage.Location = new System.Drawing.Point(12, 12);
			this.pcbImage.Name = "pcbImage";
			this.pcbImage.Size = new System.Drawing.Size(838, 389);
			this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcbImage.TabIndex = 0;
			this.pcbImage.TabStop = false;
			// 
			// btnSelect
			// 
			this.btnSelect.Location = new System.Drawing.Point(12, 433);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(838, 23);
			this.btnSelect.TabIndex = 1;
			this.btnSelect.Text = "Select Image";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(12, 462);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(838, 23);
			this.btnLoad.TabIndex = 2;
			this.btnLoad.Text = "Load Image";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// txtPath
			// 
			this.txtPath.Location = new System.Drawing.Point(12, 407);
			this.txtPath.Name = "txtPath";
			this.txtPath.ReadOnly = true;
			this.txtPath.Size = new System.Drawing.Size(838, 20);
			this.txtPath.TabIndex = 3;
			this.txtPath.Text = "Select an image...";
			// 
			// frmImage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(862, 497);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.pcbImage);
			this.Name = "frmImage";
			this.Text = "Image Proxy";
			((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pcbImage;
		private System.Windows.Forms.OpenFileDialog ofdSelect;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.TextBox txtPath;
	}
}


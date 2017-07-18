using DesignPatterns.Proxy.Exemplo.Contracts;
using DesignPatterns.Proxy.Exemplo.Implementations;
using System;
using System.Windows.Forms;

namespace DesignPatterns.Proxy.Exemplo
{
	/// <summary>
	/// Proxy pattern example. In this example, we have a container that shows an chosen imagem only when user
	/// clicks on button "Load Image". The image class renders a high resolution image, process that needs a lot
	/// of memory. To avoid unnecessary loading until the user clicks the button, a proxy class is created to the
	/// image class, allowing the image to be loaded only when "GetImage" method is called, and not during class
	/// creation.
	/// 
	/// The goal of proxy pattern is to control codes where performance is something to consider. As other examples,
	/// the image loading could have been managed in a different way, but this approach was chosen to show how to
	/// apply the pattern.
	/// </summary>
	public partial class frmImage : Form
	{
		private IImage _selectedImage;

		public frmImage()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Select image button click event.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSelect_Click(object sender, EventArgs e)
		{
			var dialogResult = ofdSelect.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				_selectedImage = new ImageProxy(ofdSelect.FileName);
				txtPath.Text = "Selected: " + ofdSelect.FileName;
			}
		}

		/// <summary>
		/// Loads a selected image to the display box.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnLoad_Click(object sender, EventArgs e)
		{
			if (_selectedImage == null)
			{
				MessageBox.Show("Select an image to load on box.");
				return;
			}
			pcbImage.Image = _selectedImage.GetImage();
			pcbImage.Refresh();
			txtPath.Text = "Loaded image";
		}
	}
}

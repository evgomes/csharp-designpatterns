using DesignPatterns.Proxy.Exemplo.Contracts;
using System.Drawing;

namespace DesignPatterns.Proxy.Exemplo.Implementations
{
	/// <summary>
	/// Proxy to high resolution image class. Manages the image loading to avoid unnecessary memory usage.
	/// </summary>
	public class ImageProxy : IImage
	{
		private string _imagePath;
		private HighResolutionImage _highResolutionImage;

		public ImageProxy(string imagePath)
		{
			_imagePath = imagePath;
		}

		/// <summary>
		/// This method loads and returns the high resolution image.
		/// </summary>
		/// <returns>Loaded image.</returns>
		public Image GetImage()
		{
			_highResolutionImage = new HighResolutionImage(_imagePath);
			return _highResolutionImage.GetImage();
		}
	}
}

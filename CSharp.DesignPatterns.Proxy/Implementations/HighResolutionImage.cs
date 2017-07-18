using DesignPatterns.Proxy.Exemplo.Contracts;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;

namespace DesignPatterns.Proxy.Exemplo.Implementations
{
	/// <summary>
	/// Represents a high resolution image.
	/// </summary>
	public class HighResolutionImage : IImage
	{
		/// <summary>
		/// Image to load.
		/// </summary>
		private Image _image;

		public HighResolutionImage(string caminhoImagem)
		{
			LoadImage(caminhoImagem);
		}

		/// <summary>
		/// Loads a high resolution image.
		/// </summary>
		/// <param name="imagePath">Image path on disk.</param>
		private void LoadImage(string imagePath)
		{
			using (Stream stream = new FileStream(imagePath, FileMode.Open))
			{
				// Read all image bytes.
				var bytes = new byte[stream.Length + 1];
				stream.Read(bytes, 0, bytes.Length);

				// Load a bitmap from image bytes.
				_image = (Bitmap)new ImageConverter().ConvertFrom(bytes);
			}

			// Creates a graphics object to define image's quality.
			Graphics imageGraphics = Graphics.FromImage(_image);
			imageGraphics.InterpolationMode = InterpolationMode.High;

			// Draws the high resolution image.
			imageGraphics.DrawImage(_image, 0, 0);
			imageGraphics.Dispose();
		}

		/// <summary>
		/// Returns a loaded high resolution image.
		/// </summary>
		/// <returns>Loaded image.</returns>
		public Image GetImage() => _image;
	}
}
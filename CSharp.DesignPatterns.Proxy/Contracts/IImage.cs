using System.Drawing;

namespace DesignPatterns.Proxy.Exemplo.Contracts
{
	/// <summary>
	/// Contrat that defines the methods an image class has to implement.
	/// </summary>
	public interface IImage
	{
		/// <summary>
		/// Shows an image.
		/// </summary>
		Image GetImage();
	}
}

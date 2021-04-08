using MaterialSkin.Example.Utilities;
using System.Drawing;

namespace MaterialSkin.Example
{
    public static class Resources
    {
        private static Image GetBitmap(string name)
        {
            using var stream = ResourcesUtilities.ReadFileAsStream(name);

            return Image.FromStream(stream);
        }

        internal static Image baseline_bluetooth_black_24dp => GetBitmap("baseline_bluetooth_black_24dp.png");
        internal static Image baseline_fingerprint_black_24dp => GetBitmap("baseline_fingerprint_black_24dp.png");
        internal static Image baseline_favorite_border_black_24dp => GetBitmap("baseline_favorite_border_black_24dp.png");
        internal static Image plus => GetBitmap("plus.png");
        internal static Image minus => GetBitmap("minus.png");
    }
}

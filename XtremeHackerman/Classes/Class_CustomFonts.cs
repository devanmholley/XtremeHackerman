using System;
using System.Drawing;
using System.Drawing.Text;

namespace XtremeHackerman.Classes
{
    /// <summary>
    /// This class implements custom fonts. Add a .ttf to Resources.resx to access it here.
    /// Code taken/modified from this: https://stackoverflow.com/a/23519499
    /// </summary>
    internal abstract class Class_CustomFonts
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        private static readonly PrivateFontCollection Fonts = new PrivateFontCollection();

        /// <summary>
        /// Retrieves a Font object using a custom embedded font.
        /// </summary>
        /// <param name="fontName">byte[] value representing the name of an embedded resource file.</param>
        /// <param name="fontSize">Float value representing desired font size.</param>
        /// <returns>Font object with custom font and specified size</returns>
        public static Font GetFont(byte[] fontName, float fontSize)
        {
            byte[] fontData = fontName;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            Fonts.AddMemoryFont(fontPtr, fontName.Length);
            AddFontMemResourceEx(fontPtr, (uint)fontName.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            return new Font(Fonts.Families[0], fontSize);
        }
    }
}
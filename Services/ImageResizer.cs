namespace ImagesResizerFunction.Services
{
    public class ImageResizer : IImageResizer
    {
        public void Resize(Stream input, Stream output)
        {

            if (input == null || output == null)
            {
                throw new ArgumentNullException("Input and output parameters cannot be null");
            }

            using (Image image = Image.Load(input, out IImageFormat format))
            {
                var dimensions = dimensionsBySize[ImageSize];

                if (format == null)
                {
                    throw new ArgumentException("Format Invalid");
                }

                if (image.Width >= dimensions.Item1 || image.Height >= dimensions.Item2)
                {
                    image.Mutate(x => x.Resize(dimensions.Item1, dimensions.Item2));
                }

                image.Save(output, format);
            }

        }

        public enum ImageSize { ExtraSmall, Small, Medium }
        private static readonly Dictionary<ImageSize, (int, int)> dimensionsBySize = new Dictionary<ImageSize, (int, int)>()
        {
            {
              ImageSize.ExtraSmall, (35, 35),
              ImageSize.Small, (75, 75),
              ImageSize.Medium, (155, 155)
            }
        };
    }
}

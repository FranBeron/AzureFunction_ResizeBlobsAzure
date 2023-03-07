using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ImagesResizerFunction.Services
{
     public interface IImageResizer
    {
        void Resize(Stream input, Stream output);
    }
}

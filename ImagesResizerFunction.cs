using System;
using System.IO;
using ImagesResizerFunction.Services;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ImagesResizerFunction
{
    [StorageAccount("BlobConnectionString")]
    public class ImagesResizerFunction
    {
        private readonly IImageResizer imageResizer;

        public ImagesResizerFunction(IImageResizer imageResizer)
        {
            this.imageResizer = imageResizer;
        }

        [FunctionName("ImagesResizerFunction")]
        public void Run([BlobTrigger("HERE_NAME_CONTAINER_1/{name}")] Stream inputBlob, [Blob("HERE_NAME_CONTAINER_2/{name}", FileAccess.Write)] Stream outputBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {inputBlob.Length} Bytes");
            try
            {
                this.imageResizer.Resize(inputBlob, outputBlob);
                log.LogInformation("Blob resized in blob storage");
            }
            catch (Exception e)
            {

                log.LogError("Blob resize was fails, blob name: " + name, e);
            }
        }
    }
}

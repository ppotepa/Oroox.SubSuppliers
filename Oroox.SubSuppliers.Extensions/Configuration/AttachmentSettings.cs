using System.ComponentModel.DataAnnotations.Schema;

namespace Oroox.SubSuppliers.Extensions.Configuration
{
    public class AttachmentSettings
    {
        public int MaxAttachmentFileSize { get; set; }
        public string SupportedExtensionsString { get; set; }

        [NotMapped]
        public string[] SupportedExtensions
        {
            get 
            {
                return this.SupportedExtensionsString.Split(',');
            }
        }
    }

}

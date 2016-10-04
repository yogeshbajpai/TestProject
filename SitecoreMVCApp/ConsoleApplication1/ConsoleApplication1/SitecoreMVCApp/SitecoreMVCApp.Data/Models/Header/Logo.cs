using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace SitecoreMVCApp.Data.Models.Header
{
    [SitecoreType(AutoMap = true)]
    public class Logo : SitecoreItem
    {
        [SitecoreField("LogoUrl")]
        public virtual Link LogoUrl { get; set; }

        [SitecoreField("Image")]
        public virtual Image Image { get; set; }
    }
}

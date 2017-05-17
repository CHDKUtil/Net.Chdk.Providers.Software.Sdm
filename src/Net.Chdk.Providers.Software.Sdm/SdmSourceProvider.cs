using System.Globalization;
using Net.Chdk.Model.Software;
using Net.Chdk.Providers.Software.Product;

namespace Net.Chdk.Providers.Software.Sdm
{
    sealed class SdmSourceProvider : ProductSourceProvider
    {
        protected override string ProductName => "SDM";

        protected override string GetChannelName(SoftwareProductInfo product)
        {
            return null;
        }

        protected override CultureInfo GetLanguage(SoftwareSourceInfo source)
        {
            return null;
        }
    }
}

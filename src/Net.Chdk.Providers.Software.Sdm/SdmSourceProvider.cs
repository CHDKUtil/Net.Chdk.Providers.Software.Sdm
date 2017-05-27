using Net.Chdk.Providers.Software.Product;

namespace Net.Chdk.Providers.Software.Sdm
{
    sealed class SdmSourceProvider : ProductSourceProvider
    {
        protected override string CategoryName => "PS";
        protected override string ProductName => "SDM";
    }
}

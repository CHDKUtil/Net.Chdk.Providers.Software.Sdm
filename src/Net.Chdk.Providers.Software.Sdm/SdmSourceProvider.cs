using Microsoft.Extensions.Logging;
using Net.Chdk.Providers.Software.Product;

namespace Net.Chdk.Providers.Software.Sdm
{
    sealed class SdmSourceProvider : ProductSourceProvider
    {
        public SdmSourceProvider(ILoggerFactory loggerFactory)
            : base(loggerFactory.CreateLogger<SdmSourceProvider>())
        {
        }

        public override string ProductName => "SDM";

        protected override string CategoryName => "PS";
    }
}

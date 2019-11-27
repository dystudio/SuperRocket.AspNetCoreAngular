using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace SuperRocket.AspNetCoreAngular.Localization
{
    public static class AspNetCoreAngularLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AspNetCoreAngularConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AspNetCoreAngularLocalizationConfigurer).GetAssembly(),
                        "SuperRocket.AspNetCoreAngular.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}

using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace FluentValidationIssue.Localization
{
    public static class FluentValidationIssueLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(FluentValidationIssueConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(FluentValidationIssueLocalizationConfigurer).GetAssembly(),
                        "FluentValidationIssue.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}

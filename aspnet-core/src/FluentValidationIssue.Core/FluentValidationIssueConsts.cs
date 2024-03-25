using FluentValidationIssue.Debugging;

namespace FluentValidationIssue
{
    public class FluentValidationIssueConsts
    {
        public const string LocalizationSourceName = "FluentValidationIssue";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "8c2a5d2af762448db012734df84fc052";
    }
}

namespace ATNetCoreTelegramBot.ViewModels;

public class AppSettingsViewModel
{
    #region Properties

    public required AppDetailsViewModel AppDetails { get; set; }

    #endregion

    #region Classes

    public class AppDetailsViewModel
    {
        public string Version { get; set; }
    }

    #endregion
}
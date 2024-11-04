namespace ContosoTraders.Api.Core.Constants;

internal class KeyVaultConstants
{
    #region secrets

    public static readonly string SecretNameJwtAudience = "jwtAudience";

    public static readonly string SecretNameJwtAuthority = "jwtAuthority";

    public static readonly string SecretNameAppInsightsConnectionString = "appInsightsConnectionString";

    public static readonly string SecretNameImagesEndpoint = "imagesEndpoint";

    public static readonly string SecretNameProductsDbConnectionString = "productsDbConnectionString";

    public static readonly string SecretNameProfilesDbConnectionString = "profilesDbConnectionString";

    // AAD conn strings have Authentication=Active Directory Default set in them instead of User ID=<userid>;Password=<password>;
    public static readonly string SecretNameProductsDbAADConnectionString = "productsDbAADConnectionString";
    public static readonly string SecretNameProfilesDbAADConnectionString = "profilesDbAADConnectionString";

    public static readonly string SecretNameCartsDbEndpoint = "cartsDbEndpoint";

    public static readonly string SecretNameStocksDbEndpoint = "stocksDbEndpoint";

    public static readonly string SecretNameCognitiveServicesEndpoint = "cognitiveServicesEndpoint";

    public static readonly string SecretNameCognitiveServicesAccountKey = "cognitiveServicesAccountKey";

    #endregion
}
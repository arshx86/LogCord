#region

#nullable enable
using Newtonsoft.Json;

#endregion

namespace LogCord.Modules.Models;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class DiscordAccount
{
    [JsonProperty("accent_color")] public object? AccentColor;

    [JsonProperty("avatar")] public object Avatar;

    [JsonProperty("avatar_decoration")] public object? AvatarDecoration;

    [JsonProperty("banner")] public object Banner;

    [JsonProperty("banner_color")] public object? BannerColor;

    [JsonProperty("bio")] public string? Bio;

    [JsonProperty("discriminator")] public string Discriminator;

    [JsonProperty("email")] public string Email;

    [JsonProperty("flags")] public int? Flags;

    [JsonProperty("id")] public string Id;

    [JsonProperty("locale")] public string Locale;

    [JsonProperty("mfa_enabled")] public bool? MfaEnabled;

    [JsonProperty("nsfw_allowed")] public bool? NsfwAllowed;

    [JsonProperty("phone")] public object? Phone;

    [JsonProperty("pronouns")] public string? Pronouns;

    [JsonProperty("public_flags")] public int? PublicFlags;

    [JsonProperty("username")] public string Username;

    [JsonProperty("verified")] public bool Verified;
}
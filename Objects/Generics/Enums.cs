using System.Runtime.Serialization;

namespace KitsuSharp.Objects;

public enum Subtype
{
    /// <summary>
    /// Original net animation
    /// </summary>
    [EnumMember(Value = "ONA")]
    ONA,
    /// <summary>
    /// Original video animation
    /// </summary>
    [EnumMember(Value = "OVA")]
    OVA,
    [EnumMember(Value = "TV")]
    TV,
    [EnumMember(Value = "movie")]
    Movie,
    [EnumMember(Value = "music")]
    Music,
    [EnumMember(Value = "special")]
    Special
}

public enum Status
{
    [EnumMember(Value = "Current")]
    Current,
    [EnumMember(Value = "finished")]
    Finished,
    [EnumMember(Value = "tba")]
    TBA,
    [EnumMember(Value = "unreleased")]
    Unreleased,
    [EnumMember(Value = "upcoming")]
    Upcoming
}

public enum AgeRating
{
    /// <summary>
    /// General Audiences
    /// </summary>
    [EnumMember(Value = "G")]
    G,
    /// <summary>
    /// Parental Guidance Suggested
    /// </summary>
    [EnumMember(Value = "PG")]
    PG,
    /// <summary>
    /// Restricted
    /// </summary>
    [EnumMember(Value = "R")]
    R,
    /// <summary>
    /// Explicit
    /// </summary>
    [EnumMember(Value = "R18")]
    R18
}
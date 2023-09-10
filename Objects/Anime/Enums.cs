using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace KitsuSharp.Objects.Anime;

public enum AnimeStatus
{
    [EnumMember(Value = "current")]
    Current,

    [EnumMember(Value = "finished")]
    Finished,

    [EnumMember(Value = "tba")]
    Tba,

    [EnumMember(Value = "unreleased")]
    Unreleased,

    [EnumMember(Value = "upcoming")]
    Upcoming,
}

public enum SubType
{
    [EnumMember(Value = "ONA")]
    ONA,

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

public enum AgeRating
{
    [EnumMember(Value = "G")]
    G,

    [EnumMember(Value = "PG")]
    PG,

    [EnumMember(Value = "R")]
    R,

    [EnumMember(Value = "R18")]
    R18,
}


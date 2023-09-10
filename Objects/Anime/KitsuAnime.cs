using KitsuSharp.Objects.Anime;

namespace KitsuSharp;

public class KitsuAnime
{

}

public class KitsuAnimeAttributes
{
    /// <summary>
    /// 
    /// </summary>
    public string CreatedAt { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string UpdatedAt { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Slug { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Synopsis { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public int CoverImageTopOffset { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Titles Titles { get; set; }

    public string CanonicalTitle { get; set; }

    public string[] AbbreviatedTitles { get; set; }

    public float AverageRating { get; set; }

    public int UserCount { get; set; }

    public int FavoritesCount { get; set; }

    public string StartDate { get; set; }

    public string EndDate { get; set; }

    public string NextRelease { get; set; }

    public int PopularityRank { get; set; }

    public int RatingRank { get; set; }

    public AgeRating AgeRating { get; set; }

    public string AgeRatingGuide { get; set; }

    public SubType SubType { get; set; }

    public AnimeStatus Status { get; set; }

    public string TBA { get; set; }

    public PosterImage PosterImage { get; set; }
}

public struct Titles
{
    public string En { get; set; }

    public string En_Jp { get; set; }

    public string Ja_Jp { get; set; }
}

public class PosterImage
{
    public string Tiny { get; set; }
    public string Large { get; set; }

    public string Small { get; set; }

    public string Medium { get; set; }

    public string Original { get; set; }

    public string Meta { get; set; }
}
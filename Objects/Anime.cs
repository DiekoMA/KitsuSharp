using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitsuSharp.Objects;

public class Anime
{
    public string Id { get; set; }
    
    public string Type { get; set; }
    
    public Link Links { get; set; }
    
    public Attributes Attributes { get; set; }
    
    public Relationship Relationships { get; set; }
}

public class Attributes
{
    public string CreatedAt { get; set; }
    
    public string UpdatedAt { get; set; }
    
    public string Slug { get; set; }
    
    public string Synopsis { get; set; }
    
    public string Description { get; set; }
    
    public int CoverImageTopOffset { get; set; }
    
    public Title Titles { get; set; }
    
    public string CanonicalTitle { get; set; }
    
    public string[] AbbreviatedTitles { get; set; } 
    
    public string AverageRating { get; set; }

    public RatingFrequency RatingFrequencies { get; set; }
    
    public int UserCount { get; set; }
    
    public int FavouritesCount { get; set; }
    
    public string StartDate { get; set; }
    
    public string EndDate { get; set; }
    
    public string NextRelease { get; set; }
    
    public int PopularityRank { get; set; }

    public AgeRating AgeRating { get; set; }

    public string AgeRatingGuide { get; set; }
    
    public Subtype Subtype { get; set; }
    
    public Status Status { get; set; }
    
    public string Tba { get; set; }
    
    public Image PosterImage { get; set; }
    
    public Image CoverImage { get; set; }
    
    public int EpisodeCount { get; set; }
    
    /// <summary>
    /// The average length of an episode for this specific anime.
    /// </summary>
    public int? EpisodeLength { get; set; }
    
    /// <summary>
    /// The total length of all the episodes of the anime.
    /// </summary>
    public int TotalLength { get; set; }
    
    public string YoutubeVideoId { get; set; }
    
    public Subtype ShowType { get; set; }
    
    public bool NSFW { get; set; }
}

public class AnimeResponse
{
    public List<Anime>? Data { get; set; }
}
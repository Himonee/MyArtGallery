using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGallery.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if(!context.Arts.Any())
            {
                context.AddRange
                    (
                     new ArtClass { Id = 1, Name = "Sculpture", Price = 45, ShortDescription = "", ImageThumbnailUrl = "/images/Doll.jpeg" },
                     new ArtClass { Id = 2, Name = "Photography", Price = 45, ShortDescription = "", ImageThumbnailUrl = "/images/SankarBhagvanfull.jpg" },
                     new ArtClass { Id = 3, Name = "Conceptual Art", Price = 45, ShortDescription = "", ImageThumbnailUrl = "/images/RangoliDoll.jpg" },
                     new ArtClass { Id = 4, Name = "Calligraphy", Price = 45, ShortDescription = "", ImageThumbnailUrl = "/images/SankarBhagvanhalf1.jpg" },
                     new ArtClass { Id = 5, Name = "Calligraphy", Price = 45, ShortDescription = "", ImageThumbnailUrl = "/images/Doll.jpg" },
                     new ArtClass { Id = 6, Name = "Calligraphy", Price = 45, ShortDescription = "", ImageThumbnailUrl = "/images/SankarBhagvanhalf2.jpg" },
                     new ArtClass { Id = 7, Name = "Calligraphy", Price = 45, ShortDescription = "", ImageThumbnailUrl = "/images/Nature.jpg" },
                     new ArtClass { Id = 8, Name = "Fine Art", Price = 350, ShortDescription = "Fine art is art developed primarily for aesthetics or beauty. Fine art is a visual art considered to have been created primarily for aesthetic and intellectual purposes and judged for its beauty and meaningfulness.", ImageThumbnailUrl = " /images/fineart1.jpg" }

                    );
                context.SaveChanges();
            };
        }
    }
}

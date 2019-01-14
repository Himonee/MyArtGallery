using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGallery.Models
{
    public interface IArtRepository
    {
        IEnumerable<ArtClass> getAllArtClasses();

        ArtClass GetArtClassById(int ArtId);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtGallery.Models
{
    public class ArtRepository: IArtRepository
    {
        private readonly AppDbContext _appDbContext;
        public ArtRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<ArtClass> getAllArtClasses()
        {
            return _appDbContext.Arts;
        }

        public ArtClass GetArtClassById(int ArtId)
        {
            return _appDbContext.Arts.FirstOrDefault(a => a.Id == ArtId);
        }
    }
}

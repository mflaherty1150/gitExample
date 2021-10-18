using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeArt_Interface
{
    public interface IArtPiece
    {
        string ArtistName { get; set; }
        string WorkName { get; set; }
    }
}

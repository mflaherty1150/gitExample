using RealTimeArt_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painting
{
    public class Painting : IArtPiece
    {
        public string ArtistName { get; set; }
        public string WorkName { get; set; }
        public DateTime createDate { get; set; }
        public double Age
        {
            get => (DateTime.Now - createDate).TotalDays / 365.25;
        }
    }
}

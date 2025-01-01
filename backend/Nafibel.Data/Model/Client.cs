using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Nafibel.Data.Model
{
    [Index(nameof(Email), IsUnique = true)]
    public class Client : Person
    {
        public AgeRangeNum AgeRange { get; set; }

    }

    public enum AgeRangeNum
    {
        BelowTen,
        TenEighteen,
        EighteenThirty,
        ThirtyFortyFive,
        FortyFiveSixty,
        SixtyAbove,
    }
}

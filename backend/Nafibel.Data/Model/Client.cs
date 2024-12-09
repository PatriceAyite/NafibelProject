using System.ComponentModel.DataAnnotations;

namespace Nafibel.Data.Model
{
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

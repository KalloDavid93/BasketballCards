using System.Collections;
using System.ComponentModel;

namespace Basketball_Card_Tracker.Sorting
{
    public interface ICustomSorter : IComparer
    {
        ListSortDirection SortDirection { get; set; }
    }
}

using Data.Models;
using ProductsCartWeb.Dtos;

namespace ProductsCartWeb.EventArgs
{
    public class DragAndDropEventArgs
    {
        public int RowFromIndex { get; set; } = -1;
        public int ItemFromIndex { get; set; } = -1;
        public int RowToIndex { get; set; } = -1;
        public int ItemToIndex { get; set; } = -1;

        public int[] Values { get => new[] { RowFromIndex, ItemFromIndex, RowToIndex, ItemToIndex}; }
    }
}

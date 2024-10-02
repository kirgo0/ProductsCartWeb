using Data.Models;
using ProductsCartWeb.Dtos;

namespace ProductsCartWeb.EventArgs
{
    public class DragAndDropEventArgs
    {
        public int IndexToDrop { get; set; }
        public ItemDTO Product { get; set; }
        public Action SuccessAction { get; set; }

        public DragAndDropEventArgs(int indexToDrop, ItemDTO product, Action successAction)
        {
            IndexToDrop = indexToDrop;
            Product = product;
            SuccessAction = successAction;
        }
    }
}

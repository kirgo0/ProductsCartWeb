using Data.Models;

namespace ProductsCartWeb.EventArgs
{
    public class DragAndDropEventArgs
    {
        public int IndexToDrop { get; set; }
        public Product Product { get; set; }
        public Action SuccessAction { get; set; }

        public DragAndDropEventArgs(int indexToDrop, Product product, Action successAction)
        {
            IndexToDrop = indexToDrop;
            Product = product;
            SuccessAction = successAction;
        }
    }
}

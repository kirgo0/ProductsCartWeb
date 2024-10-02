namespace ProductsCartWeb.Dtos
{
    public class ItemRowDTO
    {
        public List<ItemDTO> Items { get; set; } = new List<ItemDTO>();
        public int SelectedItemIndex { get; set; } = -1;
        public ItemDTO SelectedItem { get; set; } = null;

        public ItemRowDTO(List<ItemDTO> items) 
        {
            Items = items;
        }

    }
}

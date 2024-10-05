namespace ProductsCartWeb.Dtos
{
    public class ItemRowDTO
    {
        public List<ItemDTO> Items { get; set; } = new List<ItemDTO>();
        public int SelectedItemIndex { get; set; } = -1;
        public int Count => Items.Count;
        public string? RowName { get; set; }
        public ItemDTO SelectedItem
        {
            get
            {
                if (SelectedItemIndex < 0 || SelectedItemIndex >= Items.Count) return null;
                return Items[SelectedItemIndex];
            }
        }
        public ItemDTO this[int index]
        {
            get => Items[index];
        }
        public ItemRowDTO(List<ItemDTO> items) 
        {
            Items = items;
        }


    }
}

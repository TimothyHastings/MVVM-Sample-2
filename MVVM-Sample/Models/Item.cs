using System;

namespace MVVMSample
{
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }

        // TH: Initialise - make sure Id is initialised with a new GUID (required for delete).
        public Item()
        {
            Id = Guid.NewGuid().ToString();
            Text = "";
            Description = "";
        }
    }
}

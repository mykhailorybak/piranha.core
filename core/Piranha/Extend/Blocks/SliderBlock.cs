using Piranha.Models;
using System.Text;

namespace Piranha.Extend.Blocks
{
    [BlockGroupType(Name = "Slider block", Category = "Content", Icon = "Sliders", Display = BlockDisplayMode.MasterDetail)]
    public class SliderBlock : BlockGroup, ISearchable
    {
        public string GetIndexedContent()
        {
            var content = new StringBuilder();

            foreach (var item in Items)
            {
                if (item is ISearchable searchItem)
                {
                    var value = searchItem.GetIndexedContent();

                    if (!string.IsNullOrEmpty(value))
                    {
                        content.AppendLine(value);
                    }
                }
            }
            return content.ToString();
        }
    }
}

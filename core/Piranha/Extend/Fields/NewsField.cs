using System;
using System.Collections.Generic;
using System.Text;

namespace Piranha.Extend.Fields
{
    [FieldType(Name = "News", Shorthand = "News", Component = "news-field")]
    public class NewsField : IField, IEquatable<NewsField>
    {
        public bool Equals(NewsField other)
        {
            throw new NotImplementedException();
        }

        public string GetTitle()
        {
            throw new NotImplementedException();
        }
    }
}

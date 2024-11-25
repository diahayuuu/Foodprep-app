using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodprep.cs
{
    public class Recipe
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public override string ToString() => Title;
    }
}

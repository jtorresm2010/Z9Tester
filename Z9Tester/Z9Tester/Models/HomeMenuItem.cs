using System;
using System.Collections.Generic;
using System.Text;

namespace Z9Tester.Models
{
    public enum MenuItemType
    {
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}

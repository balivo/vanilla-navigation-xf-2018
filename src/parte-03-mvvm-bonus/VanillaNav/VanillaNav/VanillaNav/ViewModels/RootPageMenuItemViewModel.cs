using System;

namespace VanillaNav.ViewModels
{
    public class RootPageMenuItemViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Type TargetType { get; set; }
    }
}
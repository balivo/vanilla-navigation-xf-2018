using System;

namespace VanillaNav.Services.Navigation
{
    sealed class NavigationService
    {
        private static Lazy<NavigationService> _Lazy = new Lazy<NavigationService>(() => new NavigationService());

        public static NavigationService Current { get => _Lazy.Value; }

        private NavigationService()
        {

        }
    }
}

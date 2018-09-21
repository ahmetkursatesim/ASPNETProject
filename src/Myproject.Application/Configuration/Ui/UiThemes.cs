using System.Collections.Generic;

namespace Myproject.Configuration.Ui
{
    public static class UiThemes
    {
        public static List<UiThemeInfo> All { get; }

        static UiThemes()
        {
            All = new List<UiThemeInfo>
            {
              
                new UiThemeInfo("Black", "black")
            };
        }
    }
}

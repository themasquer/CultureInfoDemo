using System.Globalization;
using Microsoft.AspNetCore.Localization;

namespace _038_CultureInfoDemo.Utils.Bases
{
    public abstract class CultureUtilBase
    {
        private readonly List<CultureInfo> _cultures;

        protected CultureUtilBase(string culture = "tr-TR")
        {
            _cultures = new List<CultureInfo>();
            _cultures.Add(new CultureInfo(culture));
        }

        public virtual Action<RequestLocalizationOptions> AddCulture()
        {
            Action<RequestLocalizationOptions> action = options =>
            {
                options.DefaultRequestCulture = new RequestCulture(_cultures.FirstOrDefault().Name);
                options.SupportedCultures = _cultures;
                options.SupportedUICultures = _cultures;
            };
            return action;
        }

        public virtual RequestLocalizationOptions UseCulture()
        {
            RequestLocalizationOptions options = new RequestLocalizationOptions()
            {
                DefaultRequestCulture = new RequestCulture(_cultures.FirstOrDefault().Name),
                SupportedCultures = _cultures,
                SupportedUICultures = _cultures
            };
            return options;
        }
    }
}

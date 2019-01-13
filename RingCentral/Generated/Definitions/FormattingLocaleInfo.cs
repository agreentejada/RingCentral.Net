using Newtonsoft.Json;

namespace RingCentral
{
    public class FormattingLocaleInfo : Serializable
    {
        // Internal identifier of a formatting language
        public string id;
        // Localization code of a formatting language
        public string localeCode;
        public string name;
    }
}
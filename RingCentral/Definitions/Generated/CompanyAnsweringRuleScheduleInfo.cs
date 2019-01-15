using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CompanyAnsweringRuleScheduleInfo : Serializable
    {
        // Weekly schedule. If specified, ranges cannot be specified
        public CompanyAnsweringRuleWeeklyScheduleInfoRequest weeklyRanges;
        // Specific data ranges. If specified, weeklyRanges cannot be specified
        public RangesInfo[] ranges;
        // Reference to Business Hours or After Hours schedule = ['BusinessHours', 'AfterHours']
        // Enum: BusinessHours, AfterHours
        public string @ref;
    }
}
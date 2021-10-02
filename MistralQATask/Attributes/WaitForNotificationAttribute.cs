using Atata;

namespace MistralQATask.Attributes
{
    public class WaitForNotificationAttribute : WaitForElementAttribute
    {
        public WaitForNotificationAttribute(TriggerEvents on = TriggerEvents.AfterClickOrSet)
            : base(WaitBy.Class, Constants.Attributes.Notification, Until.VisibleThenMissing, on)
        {
            AbsenceTimeout = 10; 
        }
    }
}

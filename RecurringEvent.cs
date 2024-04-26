using System.Collections.Immutable;

namespace CS_First_HTTP_Client;

public class RecurringEvent
{
    
    
    public async Task<ImmutableArray<RecurringEvent>> GetRecurringEvent(
        bool isPublic = true);
    
    public async Task<ImmutableArray<RecurringEvent>> GetRecurringEvent(
        bool allDay = false);

    public readonly record struct attendees["aria.wang@winsor.edu", "jinseo.kim@winsor.edu"];

    public readonly record struct cycleDays["Day 1", "Day 6"];
}
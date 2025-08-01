﻿//
// Copyright ical.net project maintainers and contributors.
// Licensed under the MIT license.
//

using System;
using System.Diagnostics;
using System.Reflection;

namespace Ical.Net;

public static class AlarmAction
{
    public const string Name = "ACTION";
    public const string Key = "ACTION";
    public static readonly StringComparison Comparison = StringComparison.Ordinal;

    public const string Audio = "AUDIO";
    public const string Display = "DISPLAY";
    public const string Email = "EMAIL";

    [Obsolete("Procedure was deprecated by RFC-5545")]
    public const string Procedure = "PROCEDURE";
}

public static class TriggerRelation
{
    public const string Name = "TRIGGER";
    public const string Key = "TRIGGER";
    public static readonly StringComparison Comparison = StringComparison.Ordinal;

    public const string Start = "START";
    public const string End = "END";
}

public static class Components
{
    public const string Alarm = "VALARM";
    public const string Calendar = "VCALENDAR";
    public const string Freebusy = "VFREEBUSY";
    public const string Timezone = "VTIMEZONE";
    public const string Daylight = "DAYLIGHT";
    public const string Standard = "STANDARD";
}

public static class EventParticipationStatus
{
    public const string Name = "PARTSTAT";
    public const string Key = "PARTSTAT";
    public static readonly StringComparison Comparison = StringComparison.Ordinal;

    /// <summary> Event needs action </summary>
    public const string NeedsAction = "NEEDS-ACTION";
    /// <summary> Event accepted </summary>
    public const string Accepted = "ACCEPTED";
    /// <summary> Event declined </summary>
    public const string Declined = "DECLINED";
    /// <summary> Event tentatively accepted </summary>
    public const string Tentative = "TENTATIVE";
    /// <summary> Event delegated </summary>
    public const string Delegated = "DELEGATED";

    public static string Default => NeedsAction;
}

public static class ToDoParticipationStatus
{
    public const string Name = "PARTSTAT";
    public const string Key = "PARTSTAT";
    public static readonly StringComparison Comparison = StringComparison.Ordinal;

    /// <summary> To-do needs action </summary>
    public const string NeedsAction = "NEEDS-ACTION";
    /// <summary> To-do accepted </summary>
    public const string Accepted = "ACCEPTED";
    /// <summary> To-do declined </summary>
    public const string Declined = "DECLINED";
    /// <summary> To-do tentatively accepted </summary>
    public const string Tentative = "TENTATIVE";
    /// <summary> To-do delegated </summary>
    public const string Delegated = "DELEGATED";
    /// <summary> To-do completed </summary>
    public const string Completed = "COMPLETED";
    /// <summary> To-do in process </summary>
    public const string InProcess = "IN-PROCESS";

    public static string Default => NeedsAction;
}

public static class JournalParticipationStatus
{
    public const string Name = "PARTSTAT";
    public const string Key = "PARTSTAT";
    public static readonly StringComparison Comparison = StringComparison.Ordinal;

    public const string NeedsAction = "NEEDS-ACTION";
    public const string Accepted = "ACCEPTED";
    public const string Declined = "DECLINED";

    public static string Default => NeedsAction;
}

public static class ParticipationRole
{
    public const string Role = "ROLE";

    /// <summary> Indicates the chair of the calendar entity </summary>
    public const string Chair = "CHAIR";

    /// <summary> Indicates a participant whose participation is required </summary>
    public const string RequiredParticipant = "REQ-PARTICIPANT";

    /// <summary> Indicates a participant whose participation is optional </summary>
    public const string OptionalParticipant = "OPT-PARTICIPANT";

    /// <summary> Indicates a participant who is copied for information purposes only </summary>
    public const string NonParticipant = "NON-PARTICIPANT";

    public static string Default => RequiredParticipant;
    public static string ParamName => Role;
}

public class SerializationConstants
{
    public const string LineBreak = "\r\n";
}

/// <summary>
/// Status codes available to an <see cref="CalendarComponents.CalendarEvent"/> item
/// </summary>
public static class EventStatus
{
    public const string Name = "VEVENT";
    public static readonly StringComparison Comparison = StringComparison.Ordinal;

    public const string Tentative = "TENTATIVE";
    public const string Confirmed = "CONFIRMED";
    public const string Cancelled = "CANCELLED";
}

/// <summary>
/// Status codes available to a <see cref="CalendarComponents.Todo"/> item.
/// </summary>
public static class TodoStatus
{
    public const string Name = "VTODO";
    public const string Key = "STATUS";
    public static readonly StringComparison Comparison = StringComparison.Ordinal;

    public const string NeedsAction = "NEEDS-ACTION";
    public const string Completed = "COMPLETED";
    public const string InProcess = "IN-PROCESS";
    public const string Cancelled = "CANCELLED";
}

/// <summary>
/// Status codes available to a <see cref="CalendarComponents.Journal"/> entry.
/// </summary>
public static class JournalStatus
{
    public const string Name = "VJOURNAL";
    public const string Key = "STATUS";
    public static readonly StringComparison Comparison = StringComparison.Ordinal;

    public const string Draft = "DRAFT";
    public const string Final = "FINAL";
    public const string Cancelled = "CANCELLED";
}

public enum FreeBusyStatus
{
    Free = 0,
    BusyTentative = 1,
    BusyUnavailable = 2,
    Busy = 3
}

public enum FrequencyType
{
    Secondly,
    Minutely,
    Hourly,
    Daily,
    Weekly,
    Monthly,
    Yearly
}

/// <summary>
/// Indicates the occurrence of the specific day within a
/// MONTHLY or YEARLY recurrence frequency. For example, within
/// a MONTHLY frequency, consider the following:
///
/// RecurrencePattern r = new RecurrencePattern();
/// r.Frequency = FrequencyType.Monthly;
/// r.ByDay.Add(new WeekDay(DayOfWeek.Monday, FrequencyOccurrence.First));
///
/// The above example represents the first Monday within the month,
/// whereas if FrequencyOccurrence.Last were specified, it would
/// represent the last Monday of the month.
///
/// For a YEARLY frequency, consider the following:
///
/// Recur r = new Recur();
/// r.Frequency = FrequencyType.Yearly;
/// r.ByDay.Add(new WeekDay(DayOfWeek.Monday, FrequencyOccurrence.Second));
///
/// The above example represents the second Monday of the year.  This can
/// also be represented with the following code:
///
/// r.ByDay.Add(new WeekDay(DayOfWeek.Monday, 2));
/// </summary>
public enum FrequencyOccurrence
{
    Last = -1,
    SecondToLast = -2,
    ThirdToLast = -3,
    FourthToLast = -4,
    FifthToLast = -5,
    First = 1,
    Second = 2,
    Third = 3,
    Fourth = 4,
    Fifth = 5
}

public static class TransparencyType
{
    public const string Name = "TRANSP";
    public const string Key = "TRANSP";
    public static readonly StringComparison Comparison = StringComparison.Ordinal;

    public const string Opaque = "OPAQUE";
    public const string Transparent = "TRANSPARENT";
}

public static class LibraryMetadata
{
    private static readonly string _assemblyVersion = GetAssemblyVersion();

    /// <summary>
    /// The <c>VERSION</c> property for iCalendar objects generated by this library (RFC 5545 Section 3.7.4),
    /// unless overridden by user code.
    /// </summary>
    public const string Version = "2.0";

    /// <summary>
    /// The default <c>PRODID</c> property for iCalendar objects generated by this library (RFC 5545 Section 3.7.3),
    /// unless overridden by user code.
    /// <remarks>
    /// The text between the double slashes represents the organization or software that created the iCalendar object.
    /// </remarks>
    /// </summary>
    public static string ProdId => $"-//github.com/ical-org/ical.net//NONSGML ical.net {_assemblyVersion}//EN";

    private static string GetAssemblyVersion()
    {
        var assembly = typeof(LibraryMetadata).Assembly;
        var fileVersionAttribute = assembly.GetCustomAttribute<AssemblyFileVersionAttribute>();
        return fileVersionAttribute?.Version ?? assembly.GetName().Version?.ToString() ?? "1.0.0.0";
    }
}

public static class CalendarScales
{
    public const string Gregorian = "GREGORIAN";
}

public static class CalendarMethods
{
    /// <summary>
    /// Used to publish an iCalendar object to one or
    /// more "Calendar Users".  There is no interactivity
    /// between the publisher and any other "Calendar User".
    /// An example might include a baseball team publishing
    /// its schedule to the public.
    /// </summary>
    public const string Publish = "PUBLISH";

    /// <summary>
    /// Used to schedule an iCalendar object with other
    /// "Calendar Users".  Requests are interactive in
    /// that they require the receiver to respond using
    /// the reply methods.  Meeting requests, busy-time
    /// requests, and the assignment of tasks to other
    /// "Calendar Users" are all examples.  Requests are
    /// also used by the Organizer to update the status
    /// of an iCalendar object.
    /// </summary>
    public const string Request = "REQUEST";

    /// <summary>
    /// A reply is used in response to a request to
    /// convey Attendee status to the Organizer.
    /// Replies are commonly used to respond to meeting
    /// and task requests.
    /// </summary>
    public const string Reply = "REPLY";

    /// <summary>
    /// Add one or more new instances to an existing
    /// recurring iCalendar object.
    /// </summary>
    public const string Add = "ADD";

    /// <summary>
    /// Cancel one or more instances of an existing
    /// iCalendar object.
    /// </summary>
    public const string Cancel = "CANCEL";

    /// <summary>
    /// Used by an Attendee to request the latest
    /// version of an iCalendar object.
    /// </summary>
    public const string Refresh = "REFRESH";

    /// <summary>
    /// Used by an Attendee to negotiate a change in an
    /// iCalendar object.  Examples include the request
    /// to change a proposed event time or change the
    /// due date for a task.
    /// </summary>
    public const string Counter = "COUNTER";

    /// <summary>
    /// Used by the Organizer to decline the proposed
    /// counter-proposal.
    /// </summary>
    public const string DeclineCounter = "DECLINECOUNTER";
}

/// <summary>
/// The defaults used for regular expressions.
/// </summary>
public static class RegexDefaults
{
    /// <summary>
    /// The default timeout for regular expressions in milliseconds.
    /// </summary>
    public const int TimeoutMilliseconds = 2000;
    /// <summary>
    /// The default timeout for regular expressions.
    /// </summary>
    public static readonly TimeSpan Timeout = TimeSpan.FromMilliseconds(TimeoutMilliseconds);
}

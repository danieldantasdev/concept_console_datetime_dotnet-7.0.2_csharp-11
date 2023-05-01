//DateTime

var now = DateTime.Now;
var today = DateTime.Today;

var threeDaysAgo = now.AddDays(-3);
var threeDaysAfter = now.AddDays(3);
var sixMonthsLater = today.AddMonths(6);
var twoYearsLater = today.AddYears(2);

var shortDate = now.ToShortDateString();
var longDate = now.ToLongDateString();

var shortTime = now.ToShortTimeString();
var longTime = now.ToLongTimeString();

var date = now.Date;
var day = now.Day;
var year = now.Year;
var hour = now.Hour;
var minute = now.Minute;
var second = now.Second;

var dayOfWeek = now.DayOfWeek;

if (dayOfWeek == DayOfWeek.Monday) Console.WriteLine("Monday");

var dayOfYear = now.DayOfYear;

//format
Console.WriteLine("Format DateTime");
var formats = new[] { "d", "D", "f", "F", "g", "G", "m", "r", "o", "s", "t", "T", "u", "U", "y" };

foreach (var format in formats) Console.WriteLine("DateTime format {0}: {1}", format, now.ToString(format));
// Console.WriteLine($"DateTime format {format}: {now.ToString(format)}");
var dateFormatInterpolation = $"Data format {now:dd-MM-yyyy}";
var dateFormatToString = $"Data format {now.ToString("dd-MM-yyyy")}";
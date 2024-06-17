using System.Globalization;

namespace PhoneNumber.Data.Convertor
{
	public static class DateConvertor
	{
		public static string ToShamsi(this DateTime value)
		{
			PersianCalendar cl = new PersianCalendar();
			return cl.GetYear(value) + "/" + cl.GetMonth(value).ToString("00") + "/" + cl.GetDayOfMonth(value).ToString("00");
		}
	}
}

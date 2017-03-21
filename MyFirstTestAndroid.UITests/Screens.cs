using System;
using Xamarin.UITest.Queries;

namespace MyFirstTestAndroid.UITests
{
	public class AndroidMainScreen : IMainScreen
	{
		public Func<AppQuery, AppQuery> FirstNameEditText { get; } = c => c.Id (AndroidMainScreenIds.FirstNameEditText);
		public Func<AppQuery, AppQuery> LastNameEditText { get; }  = c => c.Id (AndroidMainScreenIds.LastNameEditText);
		public Func<AppQuery, AppQuery> SubmitButton { get; }  = c => c.Id (AndroidMainScreenIds.SubmitButton);
		public Func<AppQuery, AppQuery> StatusTextView { get; }  = c => c.Id (AndroidMainScreenIds.StatusTextView);
	}

	public class IosMainScreen : IMainScreen
	{
		public Func<AppQuery, AppQuery> FirstNameEditText { get; } = c => c.Id (IosMainScreenIds.FirstNameEditText);
		public Func<AppQuery, AppQuery> LastNameEditText { get; } = c => c.Id (IosMainScreenIds.LastNameEditText);
		public Func<AppQuery, AppQuery> SubmitButton { get; } = c => c.Id (IosMainScreenIds.SubmitButton);
		public Func<AppQuery, AppQuery> StatusTextView { get; } = c => c.Id (IosMainScreenIds.StatusTextView);
	}

	public interface IMainScreen
	{
		Func<AppQuery, AppQuery> FirstNameEditText { get; }
		Func<AppQuery, AppQuery> LastNameEditText { get; }
		Func<AppQuery, AppQuery> SubmitButton { get; }
		Func<AppQuery, AppQuery> StatusTextView { get; }
	}

	public static class AndroidMainScreenIds
	{
		public static string FirstNameEditText = "firstNameEditText";
		public static string LastNameEditText = "lastNameEditText";
		public static string SubmitButton = "submitButton";
		public static string StatusTextView = "statusTextView";
	}

	public static class IosMainScreenIds
	{
		public static string FirstNameEditText = "firstNameEditText";
		public static string LastNameEditText = "lastNameEditText";
		public static string SubmitButton = "submitButton";
		public static string StatusTextView = "statusTextView";
	}
}
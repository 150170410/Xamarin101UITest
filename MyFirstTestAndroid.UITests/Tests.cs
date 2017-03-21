using System;
using System.Configuration;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;

namespace MyFirstTestAndroid.UITests
{
	[TestFixture]
	public class Tests
	{
		AndroidApp app;

		[SetUp]
		public void BeforeEachTest ()
		{
			app = ConfigureApp.Android
			                  .EnableLocalScreenshots ()
			                  .StartApp ();
		}

		[TestCase("John", "Smith")]
		[TestCase ("Mark", "Jones")]
		public void ClickSubmitButton (string firstName, string lastname)
		{
			Func<AppQuery, AppQuery> firstNameEditText = c => c.Id ("firstNameEditText");
			Func<AppQuery, AppQuery> lastNameEditText = c => c.Id ("lastNameEditText");
			Func<AppQuery, AppQuery> submitButton = c => c.Id ("submitButton");
			Func<AppQuery, AppQuery> statusTextView = c => c.Id ("statusTextView");

			app.EnterText (firstNameEditText, firstName);
			app.EnterText (lastNameEditText, lastname);
			app.Screenshot ("Name entered");
			app.Tap (submitButton);

			AppResult [] results = app.Query (statusTextView);
			app.Screenshot ("Submit Button Pressed");

			var t = results [0].Text;

			Assert.AreEqual ($"Thank you {firstName} {lastname}", results [0].Text);
		}
	}
}

using System;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;

namespace MyFirstTestAndroid.UITests
{
	[TestFixture]
	public class Tests2
	{
		AndroidApp app;
		IMainScreen _mainScreen;

		[SetUp]
		public void BeforeEachTest ()
		{
			_mainScreen = new AndroidMainScreen ();

#if DEBUG
			app = ConfigureApp.Android.EnableLocalScreenshots ()
			                  .StartApp ();
#else
			app = ConfigureApp.Android
			                  .ApkFile ("../../../com.jamoby.myfirsttestandroid-Signed.apk")
			                  .StartApp ();
#endif
		}

		[Test]
		public void ReplTest()
		{
			app.Repl ();
		}

		[TestCase ("John", "Smith")]
		[TestCase ("Mark", "Jones")]
		[Category ("Default")]
		public void ClickSubmitButton (string firstName, string lastname)
		{
			app.EnterText (_mainScreen.FirstNameEditText, firstName);
			app.EnterText (_mainScreen.LastNameEditText, lastname);
			app.Screenshot ("Name entered");
			app.Tap (_mainScreen.SubmitButton);

			AppResult [] results = app.Query (_mainScreen.StatusTextView);
			app.Screenshot ("Submit Button Pressed");

			var t = results [0].Text;

			Assert.AreEqual ($"Thank you {firstName} {lastname}", results [0].Text);
		}

		[Category("SmokeTest")]
		[Test]
		public void SmokeTest1 ()
		{
			Console.WriteLine ("SmokeTest1 Running ...");
		}

		[Category ("SmokeTest")]
		[Test]
		public void SmokeTest2 ()
		{
			Console.WriteLine ("SmokeTest2 Running ...");
		}

		[Category ("SmokeTest")]
		[Category ("QA")]
		[Test]
		public void SmokeTest3 ()
		{
			Console.WriteLine ("SmokeTest3 Running ...");
		}
	}
}

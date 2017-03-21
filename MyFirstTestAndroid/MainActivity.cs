using Android.App;
using Android.Widget;
using Android.OS;

namespace MyFirstTestAndroid
{
	[Activity (Label = "Thank you App", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		EditText _firstNameTextView;
		EditText _lastNameTextView;
		TextView _statusLabel;
		Button _submitButton;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.Main);

			_firstNameTextView = FindViewById<EditText> (Resource.Id.firstNameEditText);
			_lastNameTextView = FindViewById<EditText> (Resource.Id.lastNameEditText);
			_submitButton = FindViewById<Button> (Resource.Id.submitButton);
			_statusLabel = FindViewById<TextView> (Resource.Id.statusTextView);

			_submitButton.Click += (sender, e) => 
			{
				_statusLabel.Text = $"Thank you {_firstNameTextView.Text} {_lastNameTextView.Text}";
			};
		}
	}
}


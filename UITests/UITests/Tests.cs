using NUnit.Framework;

using Xamarin.UITest;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
using System.Linq;

namespace UITests
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		readonly Query TextInput;

		public Tests(Platform platform)
		{
			this.platform = platform;

			TextInput = x => x.Marked("TextInputAccessibilityId");
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void AppLaunches()
		{
			app.Screenshot("First screen.");
		}

		[Test]
		public void EnterText()
		{
			//Arrange
			const string enteredText = "Hello World";

			//Act
			app.Tap(TextInput);
			app.ClearText();
			app.EnterText(enteredText);
			app.DismissKeyboard();

			//Assert
			var retrivedText = app.Query(TextInput)?.FirstOrDefault()?.Text;
			Assert.AreEqual(enteredText, retrivedText);
		}

		[Ignore]
		[Test]
		public void Repl()
		{
			app.Repl();
		}
	}
}

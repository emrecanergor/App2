using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest
{
	[TestFixture(Platform.Android)]
	//[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}
        /*
        [Test]
        public void ScreenShotDeneme()
        {
            app.Screenshot("First_Screen");
        }
        */
        [Test]
        public void XYZTextIsDisplayed()
        {

            app.EnterText("entry_xyz", "XYZ");

            app.Tap("buton_xyz");

            var AppResult = app.Query("label_xyz").First(result => result.Text == "XYZ");

            Assert.IsTrue(AppResult != null, "label bla bla");


            //AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
            //app.Screenshot("Welcome screen.");

            //Assert.IsTrue(results.Any());
        }


        [Test]
        public void ButtonTapAgain()
        {

            app.EnterText("entry_xyz", "qwerty_XD");

            app.Tap("buton_xyz");


            app.Tap("buton_xyz");
            app.Tap("buton_xyz");

            app.ClearText("entry_xyz");

            app.EnterText("entry_xyz", "Deneme1-2-3-321");

            app.Tap("buton_xyz");
            
            var AppResult = app.Query("label_xyz").First(result => result.Text == "Deneme1-2-3-321");

            Assert.IsTrue(AppResult != null, "label bla bla");


            //AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
            //app.Screenshot("Welcome screen.");

            //Assert.IsTrue(results.Any());
        }
    }
}

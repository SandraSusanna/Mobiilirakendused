using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace FirstApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.first_layout);

            var textView = FindViewById<TextView>(Resource.Id.textView1);
            var btnTest = FindViewById<Button>(Resource.Id.button1);

            var btnPlus = FindViewById<Button>(Resource.Id.button2);
            var btnMinus = FindViewById<Button>(Resource.Id.button3);
            var btnMulti = FindViewById<Button>(Resource.Id.button4);
            var btnDivide = FindViewById<Button>(Resource.Id.button5);


            var nr1 = FindViewById<EditText>(Resource.Id.editText1);
            var nr2 = FindViewById<EditText>(Resource.Id.editText2);



            btnTest.Click += delegate
            {
                textView.Text = "IT WORKS!";
            };

            btnPlus.Click += delegate
            {
                var result = double.Parse(nr1.Text) + double.Parse(nr2.Text);
                textView.Text = result.ToString();
            };

            btnMinus.Click += delegate
            {
                var result = double.Parse(nr1.Text) - double.Parse(nr2.Text);
                textView.Text = result.ToString();
            };

            btnMulti.Click += delegate
            {
                var result = double.Parse(nr1.Text) * double.Parse(nr2.Text);
                textView.Text = result.ToString();
            };

            btnDivide.Click += delegate
            {
                var result = double.Parse(nr1.Text) / double.Parse(nr2.Text);
                textView.Text = result.ToString();
            };
        }
    }
}
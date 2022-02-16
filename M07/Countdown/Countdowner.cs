namespace Countdown
{
    public class CountDownEventArgs
    {
        public CountDownEventArgs(int seconds) { Seconds = seconds; }

        public int Seconds { get; }

        private void Timer()
        {
            int count = 0;
            while (count < 5)
            {
                Console.WriteLine(SendMessage());
                Thread.Sleep(Seconds * 1000);
                count++;
            }
        }

        public static string SendMessage() => $"Current time is: {DateTime.Now}";

        public delegate void CountDownEventHandler(object sender, CountDownEventArgs e);

        public event CountDownEventHandler? CountDown;

        public virtual void RaiseCountDowner()
        {
            if (CountDown != null)
            {
                CountDown?.Invoke(this, new CountDownEventArgs(Seconds));
                Timer();
            }
        }
    }
}
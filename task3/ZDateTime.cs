using System;
using System.Globalization;


namespace task3
{
    public class ZDateTime
    {
        public DateTime CurrentTime { get; set; } = DateTime.Now;

        public string FirstFormat { get; set; }

        public string SecondFormat { get; set; }

        public void ToFirst()
        {
            FirstFormat = (CurrentTime.ToString("d",
                CultureInfo.CreateSpecificCulture("en-NZ"))) + " " + (CurrentTime.ToString("t",
                CultureInfo.CreateSpecificCulture("hr-HR")));
        }

        public void ToSecond()
        {
            SecondFormat = (CurrentTime.ToString("d",
                CultureInfo.CreateSpecificCulture("en-US"))) + " " + (CurrentTime.ToString("t",
                CultureInfo.CreateSpecificCulture("en-US")));
        }

        public void CountDigits()
        {
            int[] arr = new int[10];
            int number = 0;
            
            foreach (char c in FirstFormat) {
                int diff = c - '0';

                if (diff < 0 || diff > 9) continue;
                
                arr[diff]++;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Amount of " + number + "'s" + " : " + arr[i]);
                number++;
            }
        }
    }
}
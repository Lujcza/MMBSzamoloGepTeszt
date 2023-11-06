using System.Text.RegularExpressions;
using System.Linq;
namespace ConsoleApp1009
{
    public class Egyenl
    {
        public string egyenlet;
        public Egyenl(string egyenlet)
        {
            this.egyenlet = egyenlet;
        }
        public bool IsMath()
        {
            var pelda = $"^[0-9]+[\\+\\-\\*\\/][0-9]+$";
            return Regex.IsMatch(this.egyenlet, pelda);
        }
        public int solve()
        {
            if (this.egyenlet.Contains('+'))
            {
                string[] numbers = this.egyenlet.Split('+');
                return Convert.ToInt32(numbers[0]) + Convert.ToInt32(numbers[1]);
            }
            else if (this.egyenlet.Contains('-'))
            {
                string[] numbers = this.egyenlet.Split('-');
                return Convert.ToInt32(numbers[0]) - Convert.ToInt32(numbers[1]);
            }
            else if (this.egyenlet.Contains('*'))
            {
                string[] numbers = this.egyenlet.Split('*');
                return Convert.ToInt32(numbers[0]) * Convert.ToInt32(numbers[1]);
            }
            else
            {
                string[] numbers = this.egyenlet.Split('/');
                return Convert.ToInt32(numbers[0]) / Convert.ToInt32(numbers[1]);
            }
        }
    }
}
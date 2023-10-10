using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanonicalDataModel
{
    public class SASTranslator
    {
        public int day;
        public string month;
        public int year;
        public SASTranslator() { }

        public SASTranslator(DateTime date)
        {
            this.day = date.Day;
            switch (date.Month)
            {
                case 1:
                    this.month = nameof(Month.January);
                    break;
                case 2:
                    this.month= nameof(Month.February);
                    break;
                case 3:
                    this.month = nameof(Month.March);
                    break;
                case 4:
                    this.month = nameof(Month.April);
                    break;
                case 5:
                    this.month = nameof(Month.May);
                    break;
                case 6:
                    this.month = nameof(Month.June);
                    break;
                case 7:
                    this.month = nameof(Month.Juli);
                    break;
                case 8:
                    this.month = nameof(Month.August);
                    break;
                case 9:
                    this.month = nameof(Month.September);
                    break;
                case 10:
                    this.month = nameof(Month.October);
                    break;
                case 11:
                    this.month = nameof(Month.November);
                    break;
                case 12:
                    this.month = nameof(Month.December);
                    break;
                default:
                    break;
            }
            this.year = date.Year;
        }

    }
}

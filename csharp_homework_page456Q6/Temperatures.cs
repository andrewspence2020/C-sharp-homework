using System.Linq;

namespace Temperatures {
    class Temperatures {
        double[] temps;

        public Temperatures(params double[] temps) {
            this.temps = temps;
        }

        public double GetHighest() {
            return temps.Max();
        }

        public double GetLowest() {
            return temps.Min();
        }

        public double GetAverage() {
            return GetTotalOfTemps() / temps.Length;
        }

        public double GetAverageWithoutLowest() {
            return (GetTotalOfTemps() - GetLowest()) / (temps.Length - 1);
        }

        public int GetNumberOfDaysUnder(double temp) {
            int numberOfDays = 0;
            foreach (double _temp in temps) {
                if (temp > _temp) {
                    numberOfDays++;
                }
            }
            return numberOfDays;
        }

        private double GetTotalOfTemps() {
            double total = 0;
            foreach (double temp in temps) {
                total += temp;
            }
            return total;
        }

        public override string ToString() {
            return $"{"Minimum",-10} | {"Maximum",-10} | {"Average",-10}" +
                $"\n{GetLowest(),-10:f1} | {GetHighest(),-10:f1} | {GetAverage(),-10:f1}";
        }
    }
}

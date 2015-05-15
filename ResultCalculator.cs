using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeresJegySzamolo
{
    class ResultCalculator
    {
        private List<double> results;
        private bool isbuko;

        public ResultCalculator()
        {
            results = new List<double>(6);
            isbuko = false;
        }

        public void addResult(double result)
        {
            if (result == 1.0)
                isbuko = true;
            results.Add(result);
        }

        public void RemoveAll()
        {
            if(results.Count != 0){
            for (int i = 0; i < results.Capacity; i++)
                results.RemoveAt(0);
            isbuko = false;
            }
        }

        public double MeresJegy(int index)
        {
            if (isbuko)
                return 1;
            else if (index <= 0)
                throw new ArgumentNullException("Ilyen mérés nincs!");
            else
            {
                switch (index)
                {
                    case 1:
                        return ((results[1] + results[2] + results[3]) / 3) * 0.2 + results[4] * 0.2 + results[5] * 0.6;
                    case 2:
                        return ((results[1] + results[3] + results[4]) / 3) * 0.2 + results[2] * 0.2 + results[5] * 0.6;
                    case 3:
                        return ((results[1] + results[2] + results[3] + results[4]) / 4) * 0.3 + results[5] * 0.7;
                    case 4:
                        return ((results[0] + results[1] + results[2] + results[3] + results[4]) / 5) * 0.3 + results[5] * 0.7;
                    default: return 1.0;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeresJegySzamolo
{
    /**
     * Ez az osztály teremt kapcsolatot a View és a model között. Ebből csak egy kell, így
     * a Singelton tervezési mintát használom.
     **/
    class JegyController
    {
        private int meresindex;
        private static ResultCalculator calc = new ResultCalculator();
        private static JegyController instance = null;
        public static JegyController Instance
        {
            get
            {
                if (instance == null)
                    instance = new JegyController();
                return instance;
            }
        }
        public int MeresIndex
        {
            get
            {
                return meresindex;
            }
            set
            {
                if (value <= 0 || value > 4)
                    throw new ArgumentException("Ilyen mérés nincs!");
                meresindex = value;
            }
        }
        protected JegyController() {
            //calc = new ResultCalculator();
        }

        public void AddResults(double[] results)
        {
            for (int i = 0; i < results.Length; i++)
            {
                calc.addResult(results[i]);
            }
        }

        public double GetTheResult()
        {
            return Math.Round(calc.MeresJegy(meresindex),0);
        }

        public void ClearTheResults()
        {
            calc.RemoveAll();
        }
    }
}

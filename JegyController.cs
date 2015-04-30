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
        private ResultCalculator calc;
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
                    throw new ArgumentException("Ilen mérés nincs!");
                meresindex = value;
            }
        }
        protected JegyController() {
            calc = new ResultCalculator();
        }

        public void AddResults(double[] results)
        {
            for (int i = 0; i < results.Length; i++)
            {
                calc.addResult(results[i]);
            }
        }

        public int GetTheResult()
        {
            return int.Parse(calc.MeresJegy(meresindex).ToString());
        }

        public void ClearTheResults()
        {
            calc.RemoveAll();
        }
    }
}

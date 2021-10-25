using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace task0
{
    public class Procent : MonoBehaviour
    {
        private void Start()
        {
            GetComponent<Controller>().countSumTrunc += CountSumTrunc;
        }

        public double CountPr(double sum, int pr)
        {
            return sum / 100 * pr;
        }

        public double CountSum(double sum, int pr)
        {
            return sum + CountPr(sum, pr);
        }

        public int CountSumTrunc(double sum, int pr)
        {
            return Convert.ToInt32(Math.Round(CountSum(sum, pr)));
        }
    }
}


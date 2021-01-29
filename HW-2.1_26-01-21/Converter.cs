using System;
using System.Collections.Generic;
using System.Text;

namespace HW_2._1_26_01_21
{
    class Converter
    {
        private double usd { get; set; }
        private double eur { get; set; }
        private double rub { get; set; }
        public Converter(double USD, double EUR, double RUB)
        {
            usd = USD;
            eur = EUR;
            rub = RUB;
        }
        public double tjsToUsd(double tjs)
        {
            return Math.Round(tjs / usd, 4);
        }
        public double tjsToEur(double tjs)
        {
            return Math.Round(tjs / eur, 4);
        }
        public double tjsToRub(double tjs)
        {
            return Math.Round(tjs / rub, 4);
        }
        public double usdToTjs(double USD)
        {
            return Math.Round(USD * usd, 4);
        }
        public double eurToTjs(double EUR)
        {
            return Math.Round(EUR * eur, 4);
        }
        public double rubToTjs(double RUB)
        {
            return Math.Round(RUB * rub, 4);
        }
    }
}

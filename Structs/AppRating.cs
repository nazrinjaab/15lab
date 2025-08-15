using _15lab.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15lab.Structs
{
    internal struct AppRating
    {
        public double Performance;
        public double Design;
        public double Features;
        public double ValueForMoney;

        public AppRating ( double performance, double design, double features, double valueForMoney )
        {
            Performance = performance;
            Design = design;
            Features = features;
            ValueForMoney = valueForMoney;
        }
        public static bool IsValidScore( double score )
        {
            return score >= 0 && score <= 10;
        }
        
        public double GetAverageScore()
        {
            return AppHelper.CalculateAverage( Design, Features, Performance, ValueForMoney );
        }
        public override string ToString()
        {
            return $"design: {Design} /n performance: {Performance}/n features: {Features}/n valueformoney {ValueForMoney}/n getaveragescore {GetAverageScore} ";
        }
    }
}

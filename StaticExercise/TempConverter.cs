using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {

        public static double FarenheitToCelcius(double farenheit)

        { 
            var result = (farenheit - 32) / 1.8;

            return result;
        } 
    
        public static double CelciusToFarenheit(double celcius)
    {
        return (celcius * 9) / 5 + 32;
    }
}
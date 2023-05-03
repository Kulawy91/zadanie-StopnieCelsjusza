using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_StopnieCelsjusza
{
    public class Temperatura
    {
        
        private double stopniekelwina;
        private double stopniefahrenheita;
        private double stopniecelsjusza;
        public double stopnieCelsjusza; //jednostka bazowa Celsjusz
        public double StopnieFahrenheita2;//jednostka bazowa Fahrenheita
        public double stopnieKelwina2;//jednostka bazowa Kelwin
        public double stopnieCelsjusza2//konwersja celsjusza na kelwina
        {
            get
            {
                stopniecelsjusza = stopnieKelwina2 - 273.15;
                return stopniecelsjusza;
            }
        }
        public double stopnieKelwina //konwersja Fahrenheit na Kelwina
        {
            
            get 
            {
                stopniekelwina = ((StopnieFahrenheita2-32)/1.8) + 273.15;
                return stopniekelwina;
            }
            set
            {
                if (stopniekelwina<0)
                {
                    throw new ArgumentException("Temperatura musi być większa od zera.");
                }
            }
        }
        public double StopnieFahrenheita //Celsjusz na Fahrenheit
        {
            get
            {
                stopniefahrenheita = (2*stopnieCelsjusza)+32;
                return stopniefahrenheita;
             }
            set
            {
                if (StopnieFahrenheita<0)
                {
                    throw new ArgumentException("Temperatura musi być większa od zera.");
                }
            }
        }
        public double stopnieCelsjusza3 //Fahrenheit na Celsjusza
        {
            get
            {
                stopniecelsjusza = (StopnieFahrenheita2-32)/1.8;
                return stopniecelsjusza;
            }
        }
    }
}


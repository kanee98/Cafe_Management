/**  
* Created by KanishkaUdapitiya on 10/22/2016.  
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cafe_Management_System
{
    class Cafe
    {
        // Default Constructor
        public Cafe()
        {
            newlatte_Coff = 0.0;
            newespresson = 0.0;
            newIced_Latte = 0.0;
            newvalee_Coff = 0.0;
            newafri_Coff = 0.0;
            newameri_Coff = 0.0;
            newcapp_Coff = 0.0;
            newiceCapp_Coff = 0.0;

            newc_Cake = 0.0;
            newv_Cake = 0.0;
            newbF_Cake = 0.0;
            newcB_Cake = 0.0;
            newcL_Cake = 0.0;
            newcK_Cake = 0.0;
            newR_Cake = 0.0;
            newK_Cake = 0.0;
        }

        // Overload Constructor
        public Cafe(double latte_Coff, double espresson, double iced_Latte,double vale_Coff, double afri_Coff, double ameri_Coff, double capp_Coff, double iCapp_Coff, double c_Cakes, double vl_Cakes, double bf_Cakes, double cb_Cakes, double cl_Cakes, double ck_Cakes, double r_Cakes, double k_Cakes)
        {
            // Coffee
            newlatte_Coff = latte_Coff;
            newespresson = espresson;
            newIced_Latte = iced_Latte;
            newvalee_Coff = vale_Coff;
            newafri_Coff = afri_Coff;
            newameri_Coff = ameri_Coff;
            newcapp_Coff =capp_Coff;
            newiceCapp_Coff = iCapp_Coff;

            // Cake
            newc_Cake = c_Cakes;
            newv_Cake =vl_Cakes;
            newbF_Cake = bf_Cakes;
            newcB_Cake = cb_Cakes;
            newcL_Cake = cl_Cakes;
            newcK_Cake = ck_Cakes;
            newR_Cake = r_Cakes;
            newK_Cake = k_Cakes;

        }

        // Accessor Functions
        public double getlatte_Coff()
        {
            return newlatte_Coff;
        }

        public double getespresson()
        {
            return newespresson;
        }

        public double geticed_Latte()
        {
            return newIced_Latte;
        }

        public double getvale_Coff()
        {
            return newvalee_Coff;
        }

        public double getafri_Coff()
        {
            return newafri_Coff;
        }

        public double getameri_Coff()
        {
            return newameri_Coff;
        }

        public double getcapp_Coff()
        {
            return newcapp_Coff;
        }

        public double getiCapp_Coff()
        {
            return newiceCapp_Coff;
        }

        public double getc_Cakes()
        {
            return newc_Cake;
        }

        public double getvl_Cakes()
        {
            return newv_Cake;
        }

        public double getbf_Cakes()
        {
            return newbF_Cake;
        }

        public double getcb_Cakes()
        {
            return newcB_Cake;
        }

        public double getcl_Cakes()
        {
            return newcL_Cake;
        }

        public double getck_Cakes()
        {
            return newcK_Cake;
        }

        public double getr_Cakes()
        {
            return newR_Cake;
        }

        public double getk_Cakes()
        {
            return newK_Cake;
        }

        // Memeber Variables Declared For Coffe
        private double newlatte_Coff;
        private double newespresson;
        private double newIced_Latte;
        private double newvalee_Coff;
        private double newafri_Coff;
        private double newameri_Coff;
        private double newcapp_Coff;
        private double newiceCapp_Coff;

        // Member Variables Declared For Cake
        private double newc_Cake;
        private double newv_Cake;
        private double newbF_Cake;
        private double newcB_Cake;
        private double newcL_Cake;
        private double newcK_Cake;
        private double newR_Cake;
        private double newK_Cake;
    }
}

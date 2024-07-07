using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.MODELS
{
    public class Customer
    {
        //  Customer's Details
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Id { get; set; }
        public string Phone { get; set; }
        public DateTime PurchaseDate { get; set; }
        //Glasses Details
        public string GModel { get; set; }
        public int GPD { get; set; }
        //Right eye
        public double GRNumber { get; set; }
        public double GRcylinder { get; set; }
        public int GRAxis { get; set; }
        public double GRAddition { get; set; }
        public int GRPrizma { get; set; }
        public double GRindex { get; set; }
        //Left eye
        public double GLNumber { get; set; }
        public double GLcylinder { get; set; }
        public int GLAxis { get; set; }
        public double GLAddition { get; set; }
        public int GLPrizma { get; set; }
        public double GLIndex { get; set; }
        //Contact Lenses
        //Right eye
        public double RNumber { get; set; }
        public double Rcylinder { get; set; }
        public int RAxis { get; set; }
        public double RBC { get; set; }
        //Left eye
        public double LNumber { get; set; }
        public double Lcylinder { get; set; }
        public int LAxis { get; set; }
        public double LBC { get; set; }
        //Prev Glasses Details
        public int PreGPD { get; set; }
        //Right eye
        public double PreGRNumber { get; set; }
        public double PreGRcylinder { get; set; }
        public int PreGRAxis { get; set; }
        public double PreGRAddition { get; set; }
        public int PreGRPrizma { get; set; }
        public double PreGRindex { get; set; }
        //Left eye
        public double PreGLNumber { get; set; }
        public double PreGLcylinder { get; set; }
        public int PreGLAxis { get; set; }
        public double PreGLAddition { get; set; }
        public int PreGLPrizma { get; set; }
        public double PreGLIndex { get; set; }

    }
}

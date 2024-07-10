﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class CustomerDto
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
        public string GRNumber { get; set; }
        public string GRcylinder { get; set; }
        public int GRAxis { get; set; }
        public string GRAddition { get; set; }
        public string GRPrizma { get; set; }
        public double GRindex { get; set; }
        //Left eye
        public string GLNumber { get; set; }
        public string GLcylinder { get; set; }
        public int GLAxis { get; set; }
        public string GLAddition { get; set; }
        public string GLPrizma { get; set; }
        public double GLIndex { get; set; }
        //Contact Lenses
        //Right eye
        public string RNumber { get; set; }
        public string Rcylinder { get; set; }
        public int RAxis { get; set; }
        public double RBC { get; set; }
        //Left eye
        public string LNumber { get; set; }
        public string Lcylinder { get; set; }
        public int LAxis { get; set; }
        public double LBC { get; set; }
        //Prev Glasses Details
        public int PreGPD { get; set; }
        //Right eye
        public string PreGRNumber { get; set; }
        public string PreGRcylinder { get; set; }
        public int PreGRAxis { get; set; }
        public string PreGRAddition { get; set; }
        public string PreGRPrizma { get; set; }
        public double PreGRindex { get; set; }
        //Left eye
        public string PreGLNumber { get; set; }
        public string PreGLcylinder { get; set; }
        public int PreGLAxis { get; set; }
        public string PreGLAddition { get; set; }
        public string PreGLPrizma { get; set; }
        public double PreGLIndex { get; set; }
    }
}

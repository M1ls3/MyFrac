using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2_
{
    class MyFrac
    {
        protected long nom, denom; 

        public MyFrac(long nom_, long denom_)
        {
            if (denom_ == 0) { throw new Exception("Denominator cannot be 0 or lower!"); }
            if (denom_ < 0) { nom = -nom_; denom = -denom_; }
            else { nom = nom_; denom = denom_; }
            nom_ = Math.Abs(nom_);
            denom_ = Math.Abs(denom_);
            while (nom_ != 0 && denom_ != 0)
            {
                if (nom_ > denom_) { nom_ = nom_ % denom_; }
                else { denom_ = denom_ % nom_; }
            }
            nom /= nom_ + denom_;
            denom /= nom_ + denom_;
        }

        public override string ToString() { return nom + "/" + denom; }

        public static string ToStringWithIntegerPart(MyFrac f)
        {
            if (Math.Abs(f.nom) > f.denom)
            {
                string negative = f.nom < 0 ? "-" : "";
                return negative + "(" + Math.Abs(f.nom) / f.denom + "+" + Math.Abs(f.nom) % f.denom + "/" + f.denom + ")";
            }
            else { return f.ToString(); }
        }

        public static double DoubleValue(MyFrac f) { return (double)f.nom / (double)f.denom; }
        public static MyFrac operator +(MyFrac f1, MyFrac f2) { return new MyFrac(f1.nom * f2.denom + f2.nom * f1.denom, f1.denom * f2.denom); }
        public static MyFrac operator -(MyFrac f1, MyFrac f2) { return new MyFrac(f1.nom * f2.denom - f2.nom * f1.denom, f1.denom * f2.denom); }
        public static MyFrac operator *(MyFrac f1, MyFrac f2) { return new MyFrac(f1.nom * f2.nom, f1.denom * f2.denom); }
        public static MyFrac operator /(MyFrac f1, MyFrac f2) { return new MyFrac(f1.nom * f2.denom, f1.denom * f2.nom); }

        public static MyFrac CalcSum1(int n)
        {
            MyFrac res = new MyFrac(0, 1);
            for (long i = 1; i <= n; i++)
            {
                MyFrac add = new MyFrac(1, i * (i + 1));
                res = (res + add);
            }
            return res;
        }

        public static MyFrac CalcSum2(int n)
        {
            MyFrac res = new MyFrac(1, 1), unit = new MyFrac(1, 1);
            for (long i = 2; i <= n; i++)
            {
                MyFrac fracForMinus = new MyFrac(1, i * i);
                MyFrac mult = (unit - fracForMinus);
                res = (res * mult);
            }
            return res;
        }
    }
}
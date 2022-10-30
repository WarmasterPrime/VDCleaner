using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VDCleaner.assets.Extensions
{
	public static class MathExt
	{
		public const double PI							=3.141592653589793138462643383279502884197;
		public const double E							=2.718281828459045135360287471352662497757;
		public const double SpeedOfLight				=299792458;
		public const double GravitationalConstant		=0.000000000066743;

		public static double Perimeter(object area)
		{
			if(area.IsNumeric())
				return (double)(4*area.RestoreCast());
			throw new ArgumentException("Parameter value must be a numerical data-type... \""+area.GetType().Name+"\" was given.");
		}

		public static double Circumference(object radius)
		{
			if(radius.IsNumeric())
				return (double)(2*PI*radius.RestoreCast());
			throw new ArgumentException("Parameter value must be a numerical data-type... \""+radius.GetType().Name+"\" was given.");
		}

		public static double Area(object size)
		{
			if((size!=null) && size.IsNumeric())
				return (double)(System.Math.Pow(size.RestoreCast(),2));
			throw new ArgumentException("Parameter value must be a numerical data-type... \""+size.GetType().Name+"\" was given.");
		}

		public static double Area(object length,object width=null)
		{
			if(length.IsNumeric() || width.IsNumeric())
			{
				if(!length.IsNumeric())
					length=width;
				else if(!width.IsNumeric())
					width=length;
				return (double)(length.RestoreCast() * width.RestoreCast());
			}
			throw new ArgumentException("Parameter value must be a numerical data-type... Length -> \""+length.GetType().Name+"\" and Width -> \""+width.GetType().Name+"\" were given.");
		}

		public static double AreaCircle(object radius)
		{
			if((radius!=null) && radius.IsNumeric())
				return (double)(PI*System.Math.Pow(radius.RestoreCast(),2));
			throw new ArgumentException("Parameter value must be a numerical data-type... \""+radius.GetType().Name+"\" was given.");
		}

		public static double AreaCube(object size)
		{
			if((size!=null)&&size.IsNumeric())
				return (double)(6*System.Math.Pow(size.RestoreCast(),2));
			throw new ArgumentException("Parameter value must be a numerical data-type... \""+size.GetType().Name+"\" was given.");
		}

		public static double AreaCylinder(object radius,object height)
		{
			if((radius!=null&&height!=null)&&radius.IsNumeric() && height.IsNumeric())
				return (double)(2*PI*radius.RestoreCast()*height.RestoreCast());
			throw new ArgumentException("Parameter value must be a numerical data-type... Radius -> \""+radius.GetType().Name+"\" and Height -> \""+height.GetType().Name+"\" were given.");
		}

		public static double AreaCone(object radius,object length)
		{
			if((radius!=null&&length!=null)&&radius.IsNumeric() && length.IsNumeric())
				return (double)((PI*System.Math.Pow(radius.RestoreCast(),2))+(PI*radius.RestoreCast()*length.RestoreCast()));
			throw new ArgumentException("Parameter value must be a numerical data-type... Radius -> \""+radius.GetType().Name+"\" and Height -> \""+length.GetType().Name+"\" were given.");
		}

		public static double AreaSphere(object radius)
		{
			if((radius!=null)&&radius.IsNumeric())
				return (double)(4*PI*System.Math.Pow(radius.RestoreCast(),2));
			throw new ArgumentException("Parameter value must be a numerical data-type... \""+radius.GetType().Name+"\" was given.");
		}

		public static double VolumeCube(object size)
		{
			if((size!=null)&&size.IsNumeric())
				return (double)(System.Math.Pow(size.RestoreCast(),3));
			throw new ArgumentException("Parameter value must be a numerical data-type... \""+size.GetType().Name+"\" was given.");
		}

		public static double VolumeCylinder(object b,object h)
		{
			if((b!=null&&h!=null)&&b.IsNumeric()&&h.IsNumeric())
				return (double)(b.RestoreCast()*h.RestoreCast());
			throw new ArgumentException("Parameter value must be a numerical data-type... Base -> \""+b.GetType().Name+"\" and Height -> \""+h.GetType().Name+"\" were given.");
		}

		public static double VolumeCone(object b,object h)
		{
			if((b!=null&&h!=null)&&b.IsNumeric()&&h.IsNumeric())
				return (double)(b.RestoreCast()*h.RestoreCast()/3);
			throw new ArgumentException("Parameter value must be a numerical data-type... Base -> \""+b.GetType().Name+"\" and Height -> \""+h.GetType().Name+"\" were given.");
		}

		public static double VolumeSphere(object radius)
		{
			if((radius!=null)&&radius.IsNumeric())
				return (double)(4*PI*System.Math.Pow(radius.RestoreCast(),3)/3);
			throw new ArgumentException("Parameter value must be a numerical data-type... \""+radius.GetType().Name+"\" was given.");
		}

		public static double MaxVolumeSphere(object radius)
		{
			if(radius.IsNumeric())
				return (double)(4/3*(PI*System.Math.Pow(radius.RestoreCast(),3)));
			throw new ArgumentException("Parameter values must be a numerical data-type.");
		}

		public static double SurfaceAreaSphere(object radius)
		{
			if(radius.IsNumeric())
				return (double)(4*PI*System.Math.Pow(radius.RestoreCast(),2));
			throw new ArgumentException("Parameter values must be a numerical data-type.");
		}

		public static double Hypotenuse(object a,object b)
		{
			if((a!=null&&b!=null)&&a.IsNumeric()&&b.IsNumeric())
				return System.Math.Sqrt(System.Math.Pow(a.RestoreCast(),2) + System.Math.Pow(b.RestoreCast(),2));
			throw new ArgumentException("Parameter value must be a numerical data-type... a -> \""+a.GetType().Name+"\" and b -> \""+b.GetType().Name+"\" were given.");
		}

		public static double[] Quadratic(object a,object b,object c)
		{
			if((a!=null&&b!=null&&c!=null)&&c.IsNumeric()&&b.IsNumeric()&&c.IsNumeric())
			{
				double ax=(double)a.RestoreCast();
				double bx=(double)b.RestoreCast();
				double cx=(double)c.RestoreCast();
				if(ax==0)
					throw new ArgumentException("\"a\" cannot have a value of zero as it will result in division by zero.");
				double n=-1*bx;
				double bs=System.Math.Sqrt(System.Math.Pow(bx,2)-(4*ax*cx));
				double dv=2*ax;
				double r0=(n+bs)/dv;
				double r1=(n-bs)/dv;
				return new double[] {r0,r1};
			}
			throw new ArgumentException("Parameter values must be a numerical data-type.");
		}
		/*
		public static double DifferenceOfTwoSquares(object a,object b)
		{
			if(a.IsNumeric()&&b.IsNumeric())
			{
				double ax=a.RestoreCast();
				double bx=b.RestoreCast();
				return (System.Math.Pow(ax,2)-System.Math.Pow(bx,2)
			}
		}
		*/

		public static double Slope(object x,object y,object x1,object y1)
		{
			if(x.IsNumeric() && y.IsNumeric() && x1.IsNumeric() && y1.IsNumeric())
				return ((double)y1.RestoreCast()-(double)y.RestoreCast()) / ((double)x1.RestoreCast()-(double)x.RestoreCast());
			throw new ArgumentException("Parameter values must be a numerical data-type.");
		}

		public static double Slope(object x,object y)
		{
			if(x.IsNumeric() && y.IsNumeric())
				return (double)y.RestoreCast()/(double)x.RestoreCast();
			throw new ArgumentException("Parameter values must be a numerical data-type.");
		}

		public static double Energy(object mass)
		{
			if(mass.IsNumeric())
				return (double)mass.RestoreCast()*System.Math.Pow(SpeedOfLight,2);
			throw new ArgumentException("Parameter values must be a numerical data-type.");
		}
		/// <summary>
		/// Gets the gravitational force between the two objects.
		/// </summary>
		/// <param name="mass1"></param>
		/// <param name="mass2"></param>
		/// <param name="distance_between_objects_center"></param>
		/// <returns></returns>
		public static double Gravity(object mass1,object mass2,object distance_between_objects_center)
		{
			if(mass1.IsNumeric()&&mass2.IsNumeric()&&distance_between_objects_center.IsNumeric())
				return (double)GravitationalConstant*(mass2.RestoreCast()*mass2.RestoreCast()/System.Math.Pow(distance_between_objects_center.RestoreCast(),2));
			throw new ArgumentException("Parameter values must be a numerical data-type.");
		}

		public static double LiquidForce(object pressure,object area)
		{
			if(pressure.IsNumeric()&&area.IsNumeric())
				return (double)pressure.RestoreCast()*area.RestoreCast();
			throw new ArgumentException("Parameter values must be a numerical data-type.");
		}






		// throw new ArgumentException("Parameter value must be a numerical data-type... \""+radius.GetType().Name+"\" was given.");

	}
}

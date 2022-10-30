using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDCleaner.assets.Extensions.Math
{
	public class Engineering
	{

		private double _Voltage;
		private double _Current;
		private double _Resistance;
		private double _Power;
		private double _Watts;
		private double _Inductance;
		private double _Capacitance;
		private double _VoltageDrop;
		private double _PrimaryTurns;
		private double _SecondaryTurns;
		private double _TransformerEfficiency;
		private double _Impedance;
		private double _VoltageRatio;
		private double _TurnsRatio;
		private double _MutualInductance;

		public double Voltage
		{
			get
			{
				if(_Current>0&&_Resistance>0)
					return _Current*_Resistance;
				else if(_Power>0&&_Resistance>0)
					return System.Math.Sqrt(_Power*_Resistance);
				else if(_Power>0&&_Current>0)
					return _Power/_Current;
				else
					throw new ArgumentException("Some variables have not been set or are invalid.");
			}
			set
			{
				_Voltage=value;
			}
		}
		public double Current
		{
			get
			{
				if(_Voltage>0&&_Resistance>0)
					return _Voltage/_Resistance;
				else if(_Power>0&&_Voltage>0)
					return _Power/_Voltage;
				else if(_Power>0&&_Resistance>0)
					return  System.Math.Sqrt(_Power/_Resistance);
				else
					throw new ArgumentException("Some variables have not been set or are invalid.");
			}
			set
			{
				_Current=value;
			}
		}
		public double Resistance
		{
			get
			{
				if(_Voltage>0&&_Current>0)
					return _Voltage/_Current;
				else if(_Voltage>0&&_Power>0)
					return System.Math.Pow(_Voltage,2)/_Power;
				else if(_Power>0&&_Current>0)
					return _Power/System.Math.Pow(_Current,2);
				else
					throw new ArgumentException("Some variables have not been set or are invalid.");
			}
			set
			{
				_Resistance=value;
			}
		}
		public double Power
		{
			get
			{
				if(_Voltage>0&&_Current>0)
					return _Voltage*_Current;
				else if(_Current>0&&_Resistance>0)
					return System.Math.Pow(_Current,2)*_Resistance;
				else if(_Voltage>0&&_Resistance>0)
					return System.Math.Pow(_Voltage,2)/_Resistance;
				throw new ArgumentException("Some variables have not been set or are invalid.");
			}
			set
			{
				_Power=value;
			}
		}
		public double Watts
		{
			get
			{
				if(_Voltage>0)
					return _Voltage*_Current;
				else
					return Voltage*_Current;
			}
		}
		public double Inductance;
		public double Capacitance;
		public double VoltageDrop;
		public double PrimaryTurns;
		public double SecondaryTurns;
		public double TransformerEfficiency;
		public double Impedance;
		public double VoltageRatio;
		public double TurnsRatio;
		public double MutualInductance;

		public double[] Inductors;
		public double[] Capacitors;
		public double[] Resistors;

		public bool IsSeriesCircuit=true;

		public Engineering() { }

		public double GetInductance()
		{
			double res=0;
			if(IsSeriesCircuit)
				foreach(double i in Inductors)
					res+=i;
			else
			{
				foreach(double i in Inductors)
					res+=1/i;
				res=1/res;
			}
			return res;
		}

		public double GetCapacitance()
		{
			double res=0;
			if(IsSeriesCircuit)
			{
				foreach(double c in Capacitors)
					res+=1/c;
				res=1/res;
			}
			else
				foreach(double c in Capacitors)
					res+=c;
			return res;
		}

		public double GetResistance()
		{
			double res=0;
			if(IsSeriesCircuit)
				foreach(double r in Resistors)
					res+=r;
			else
			{
				foreach(double r in Resistors)
					res+=1/r;
				res=1/res;
			}
			return res;
		}






	}
}

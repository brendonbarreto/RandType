﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomType;

namespace RandomType.Console
{
	class Program
	{
		static void Main(string[] args)
		{
			var part = RandomTypeGenerator.Generate<Dictionary<List<Part>, float>>(c =>
			{
				c.Min.ListSize = 40;
				c.Max.ListSize = 40;
			});

			//var ints = RandomTypeGenerator.GenerateList<DayOfWeek>(m =>
			//{
			//	m.Min.ListSize = 500;
			//	m.Max.ListSize = 500;
			//});
		}

		public class Part
		{
			public long Long { get; set; }

			public List<TimeSpan> TimeSpanList { get; set; }

			public byte[] ByteArray { get; set; }

			public byte Byte { get; set; }

			public List<byte> ByteList { get; set; }

			public List<Batata> BatataList { get; set; }

			public Batata[] BatataArray { get; set; }

			public int[] IntArray { get; set; }

			public char Char { get; set; }

			public List<float> Float { get; set; }

			public List<double> DoubleList { get; set; }

			public List<bool> BoolList { get; set; }

			public List<long> LongList { get; set; }

			public List<DateTime> DateList { get; set; }

			public EnumTest? EnumNulable { get; set; }

			public EnumTest Enum { get; set; }

			//public Dictionary<int, float> Dick { get; set; }
		}

		public class Batata
		{
			public int Hue { get; set; }
		}

		public enum EnumTest
		{
			Auto, Value2
		}
	}
}

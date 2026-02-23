using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetFactBasedOnClearAreaEffector : gameEffector
	{
		private CName _fact;
		private CArray<CName> _factSuffixes;
		private CArray<CFloat> _vectorRotations;
		private CInt32 _value;
		private CFloat _distance;
		private CFloat _width;
		private CFloat _fromHeight;
		private CFloat _height;

		[Ordinal(0)] 
		[RED("fact")] 
		public CName Fact
		{
			get => GetProperty(ref _fact);
			set => SetProperty(ref _fact, value);
		}

		[Ordinal(1)] 
		[RED("factSuffixes")] 
		public CArray<CName> FactSuffixes
		{
			get => GetProperty(ref _factSuffixes);
			set => SetProperty(ref _factSuffixes, value);
		}

		[Ordinal(2)] 
		[RED("vectorRotations")] 
		public CArray<CFloat> VectorRotations
		{
			get => GetProperty(ref _vectorRotations);
			set => SetProperty(ref _vectorRotations, value);
		}

		[Ordinal(3)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(4)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetProperty(ref _distance);
			set => SetProperty(ref _distance, value);
		}

		[Ordinal(5)] 
		[RED("width")] 
		public CFloat Width
		{
			get => GetProperty(ref _width);
			set => SetProperty(ref _width, value);
		}

		[Ordinal(6)] 
		[RED("fromHeight")] 
		public CFloat FromHeight
		{
			get => GetProperty(ref _fromHeight);
			set => SetProperty(ref _fromHeight, value);
		}

		[Ordinal(7)] 
		[RED("height")] 
		public CFloat Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}

		public SetFactBasedOnClearAreaEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

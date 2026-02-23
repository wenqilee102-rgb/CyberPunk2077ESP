using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameRange : CVariable
	{
		private CFloat _minValue;
		private CFloat _maxValue;

		[Ordinal(0)] 
		[RED("minValue")] 
		public CFloat MinValue
		{
			get => GetProperty(ref _minValue);
			set => SetProperty(ref _minValue, value);
		}

		[Ordinal(1)] 
		[RED("maxValue")] 
		public CFloat MaxValue
		{
			get => GetProperty(ref _maxValue);
			set => SetProperty(ref _maxValue, value);
		}

		public gameRange(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

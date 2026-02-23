using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OutlineData : CVariable
	{
		private CEnum<EOutlineType> _outlineType;
		private CFloat _outlineOpacity;

		[Ordinal(0)] 
		[RED("outlineType")] 
		public CEnum<EOutlineType> OutlineType
		{
			get => GetProperty(ref _outlineType);
			set => SetProperty(ref _outlineType, value);
		}

		[Ordinal(1)] 
		[RED("outlineOpacity")] 
		public CFloat OutlineOpacity
		{
			get => GetProperty(ref _outlineOpacity);
			set => SetProperty(ref _outlineOpacity, value);
		}

		public OutlineData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

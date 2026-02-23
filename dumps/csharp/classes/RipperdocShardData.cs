using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocShardData : IScriptable
	{
		private CInt32 _count;
		private CEnum<gamedataQuality> _quality;

		[Ordinal(0)] 
		[RED("Count")] 
		public CInt32 Count
		{
			get => GetProperty(ref _count);
			set => SetProperty(ref _count, value);
		}

		[Ordinal(1)] 
		[RED("Quality")] 
		public CEnum<gamedataQuality> Quality
		{
			get => GetProperty(ref _quality);
			set => SetProperty(ref _quality, value);
		}

		public RipperdocShardData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

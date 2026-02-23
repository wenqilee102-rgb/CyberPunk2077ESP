using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocPerkData : IScriptable
	{
		private TweakDBID _perk;
		private CEnum<gamedataNewPerkSlotType> _area;
		private CInt32 _level;

		[Ordinal(0)] 
		[RED("Perk")] 
		public TweakDBID Perk
		{
			get => GetProperty(ref _perk);
			set => SetProperty(ref _perk, value);
		}

		[Ordinal(1)] 
		[RED("Area")] 
		public CEnum<gamedataNewPerkSlotType> Area
		{
			get => GetProperty(ref _area);
			set => SetProperty(ref _area, value);
		}

		[Ordinal(2)] 
		[RED("Level")] 
		public CInt32 Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}

		public RipperdocPerkData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewPerkSoldEvent : redEvent
	{
		private CEnum<gamedataNewPerkType> _perkType;
		private CInt32 _perkLevelSold;

		[Ordinal(0)] 
		[RED("perkType")] 
		public CEnum<gamedataNewPerkType> PerkType
		{
			get => GetProperty(ref _perkType);
			set => SetProperty(ref _perkType, value);
		}

		[Ordinal(1)] 
		[RED("perkLevelSold")] 
		public CInt32 PerkLevelSold
		{
			get => GetProperty(ref _perkLevelSold);
			set => SetProperty(ref _perkLevelSold, value);
		}

		public NewPerkSoldEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

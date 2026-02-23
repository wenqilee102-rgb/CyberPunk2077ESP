using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkUserData : IScriptable
	{
		private CEnum<gamedataStatType> _statType;
		private CEnum<CyberwareScreenType> _cyberwareScreenType;
		private CEnum<gamedataNewPerkType> _perkType;

		[Ordinal(0)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetProperty(ref _statType);
			set => SetProperty(ref _statType, value);
		}

		[Ordinal(1)] 
		[RED("cyberwareScreenType")] 
		public CEnum<CyberwareScreenType> CyberwareScreenType
		{
			get => GetProperty(ref _cyberwareScreenType);
			set => SetProperty(ref _cyberwareScreenType, value);
		}

		[Ordinal(2)] 
		[RED("perkType")] 
		public CEnum<gamedataNewPerkType> PerkType
		{
			get => GetProperty(ref _perkType);
			set => SetProperty(ref _perkType, value);
		}

		public PerkUserData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

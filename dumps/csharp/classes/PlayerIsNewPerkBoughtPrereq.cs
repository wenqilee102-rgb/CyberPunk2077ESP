using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerIsNewPerkBoughtPrereq : gameIScriptablePrereq
	{
		private CBool _invert;
		private CEnum<gamedataNewPerkType> _perkType;
		private CInt32 _level;

		[Ordinal(0)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetProperty(ref _invert);
			set => SetProperty(ref _invert, value);
		}

		[Ordinal(1)] 
		[RED("perkType")] 
		public CEnum<gamedataNewPerkType> PerkType
		{
			get => GetProperty(ref _perkType);
			set => SetProperty(ref _perkType, value);
		}

		[Ordinal(2)] 
		[RED("level")] 
		public CInt32 Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}

		public PlayerIsNewPerkBoughtPrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

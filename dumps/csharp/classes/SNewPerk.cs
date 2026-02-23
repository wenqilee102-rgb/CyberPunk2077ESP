using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SNewPerk : CVariable
	{
		private CEnum<gamedataNewPerkType> _type;
		private CInt32 _currLevel;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataNewPerkType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("currLevel")] 
		public CInt32 CurrLevel
		{
			get => GetProperty(ref _currLevel);
			set => SetProperty(ref _currLevel, value);
		}

		public SNewPerk(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

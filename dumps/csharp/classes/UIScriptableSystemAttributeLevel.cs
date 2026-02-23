using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIScriptableSystemAttributeLevel : CVariable
	{
		private CEnum<gamedataStatType> _stat;
		private CInt32 _level;

		[Ordinal(0)] 
		[RED("stat")] 
		public CEnum<gamedataStatType> Stat
		{
			get => GetProperty(ref _stat);
			set => SetProperty(ref _stat, value);
		}

		[Ordinal(1)] 
		[RED("level")] 
		public CInt32 Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}

		public UIScriptableSystemAttributeLevel(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

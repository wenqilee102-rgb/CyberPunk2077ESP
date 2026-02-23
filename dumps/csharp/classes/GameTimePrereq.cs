using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameTimePrereq : gameIScriptablePrereq
	{
		private CFloat _delay;
		private CBool _repeated;
		private CEnum<gamedataStatType> _delayFromStat;

		[Ordinal(0)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetProperty(ref _delay);
			set => SetProperty(ref _delay, value);
		}

		[Ordinal(1)] 
		[RED("repeated")] 
		public CBool Repeated
		{
			get => GetProperty(ref _repeated);
			set => SetProperty(ref _repeated, value);
		}

		[Ordinal(2)] 
		[RED("delayFromStat")] 
		public CEnum<gamedataStatType> DelayFromStat
		{
			get => GetProperty(ref _delayFromStat);
			set => SetProperty(ref _delayFromStat, value);
		}

		public GameTimePrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

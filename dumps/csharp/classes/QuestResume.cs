using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestResume : ActionBool
	{
		private CFloat _pauseTime;

		[Ordinal(39)] 
		[RED("pauseTime")] 
		public CFloat PauseTime
		{
			get => GetProperty(ref _pauseTime);
			set => SetProperty(ref _pauseTime, value);
		}

		public QuestResume(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

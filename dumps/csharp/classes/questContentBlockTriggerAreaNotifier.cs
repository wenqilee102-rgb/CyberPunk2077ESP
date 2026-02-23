using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questContentBlockTriggerAreaNotifier : worldITriggerAreaNotifer
	{
		private CBool _resetTokenSpawnTimer;

		[Ordinal(3)] 
		[RED("resetTokenSpawnTimer")] 
		public CBool ResetTokenSpawnTimer
		{
			get => GetProperty(ref _resetTokenSpawnTimer);
			set => SetProperty(ref _resetTokenSpawnTimer, value);
		}

		public questContentBlockTriggerAreaNotifier(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

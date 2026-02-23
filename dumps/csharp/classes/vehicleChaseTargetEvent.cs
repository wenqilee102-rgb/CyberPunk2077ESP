using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleChaseTargetEvent : redEvent
	{
		private CBool _inProgress;

		[Ordinal(0)] 
		[RED("inProgress")] 
		public CBool InProgress
		{
			get => GetProperty(ref _inProgress);
			set => SetProperty(ref _inProgress, value);
		}

		public vehicleChaseTargetEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

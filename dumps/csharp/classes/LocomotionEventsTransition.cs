using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LocomotionEventsTransition : LocomotionTransition
	{
		private CBool _causeContactDestruction;
		private CBool _activatedDestructionComponent;
		private CBool _ignoreBarbedWire;

		[Ordinal(3)] 
		[RED("causeContactDestruction")] 
		public CBool CauseContactDestruction
		{
			get => GetProperty(ref _causeContactDestruction);
			set => SetProperty(ref _causeContactDestruction, value);
		}

		[Ordinal(4)] 
		[RED("activatedDestructionComponent")] 
		public CBool ActivatedDestructionComponent
		{
			get => GetProperty(ref _activatedDestructionComponent);
			set => SetProperty(ref _activatedDestructionComponent, value);
		}

		[Ordinal(5)] 
		[RED("ignoreBarbedWire")] 
		public CBool IgnoreBarbedWire
		{
			get => GetProperty(ref _ignoreBarbedWire);
			set => SetProperty(ref _ignoreBarbedWire, value);
		}

		public LocomotionEventsTransition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

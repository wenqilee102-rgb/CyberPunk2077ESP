using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorFindTeleportPositionTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _patrolPath;
		private CHandle<AIArgumentMapping> _teleportPosition;
		private CHandle<AIArgumentMapping> _teleportRotation;

		[Ordinal(1)] 
		[RED("patrolPath")] 
		public CHandle<AIArgumentMapping> PatrolPath
		{
			get => GetProperty(ref _patrolPath);
			set => SetProperty(ref _patrolPath, value);
		}

		[Ordinal(2)] 
		[RED("teleportPosition")] 
		public CHandle<AIArgumentMapping> TeleportPosition
		{
			get => GetProperty(ref _teleportPosition);
			set => SetProperty(ref _teleportPosition, value);
		}

		[Ordinal(3)] 
		[RED("teleportRotation")] 
		public CHandle<AIArgumentMapping> TeleportRotation
		{
			get => GetProperty(ref _teleportRotation);
			set => SetProperty(ref _teleportRotation, value);
		}

		public AIbehaviorFindTeleportPositionTaskDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

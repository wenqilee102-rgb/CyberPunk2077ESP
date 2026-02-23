using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorTrackPatrolProgressNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		private CHandle<AIArgumentMapping> _pathParameters;
		private CHandle<AIArgumentMapping> _patrolProgress;
		private CHandle<AIArgumentMapping> _startFromClosestPoint;
		private CHandle<AIArgumentMapping> _patrolContinuationPolicy;
		private CHandle<AIArgumentMapping> _teleportPositionAfterTimeSkipping;
		private CHandle<AIArgumentMapping> _teleportRotationAfterTimeSkipping;
		private CHandle<AIArgumentMapping> _handleTeleportRequest;
		private CHandle<AIArgumentMapping> _fastForwardAfterTeleport;

		[Ordinal(1)] 
		[RED("pathParameters")] 
		public CHandle<AIArgumentMapping> PathParameters
		{
			get => GetProperty(ref _pathParameters);
			set => SetProperty(ref _pathParameters, value);
		}

		[Ordinal(2)] 
		[RED("patrolProgress")] 
		public CHandle<AIArgumentMapping> PatrolProgress
		{
			get => GetProperty(ref _patrolProgress);
			set => SetProperty(ref _patrolProgress, value);
		}

		[Ordinal(3)] 
		[RED("startFromClosestPoint")] 
		public CHandle<AIArgumentMapping> StartFromClosestPoint
		{
			get => GetProperty(ref _startFromClosestPoint);
			set => SetProperty(ref _startFromClosestPoint, value);
		}

		[Ordinal(4)] 
		[RED("patrolContinuationPolicy")] 
		public CHandle<AIArgumentMapping> PatrolContinuationPolicy
		{
			get => GetProperty(ref _patrolContinuationPolicy);
			set => SetProperty(ref _patrolContinuationPolicy, value);
		}

		[Ordinal(5)] 
		[RED("teleportPositionAfterTimeSkipping")] 
		public CHandle<AIArgumentMapping> TeleportPositionAfterTimeSkipping
		{
			get => GetProperty(ref _teleportPositionAfterTimeSkipping);
			set => SetProperty(ref _teleportPositionAfterTimeSkipping, value);
		}

		[Ordinal(6)] 
		[RED("teleportRotationAfterTimeSkipping")] 
		public CHandle<AIArgumentMapping> TeleportRotationAfterTimeSkipping
		{
			get => GetProperty(ref _teleportRotationAfterTimeSkipping);
			set => SetProperty(ref _teleportRotationAfterTimeSkipping, value);
		}

		[Ordinal(7)] 
		[RED("handleTeleportRequest")] 
		public CHandle<AIArgumentMapping> HandleTeleportRequest
		{
			get => GetProperty(ref _handleTeleportRequest);
			set => SetProperty(ref _handleTeleportRequest, value);
		}

		[Ordinal(8)] 
		[RED("fastForwardAfterTeleport")] 
		public CHandle<AIArgumentMapping> FastForwardAfterTeleport
		{
			get => GetProperty(ref _fastForwardAfterTeleport);
			set => SetProperty(ref _fastForwardAfterTeleport, value);
		}

		public AIbehaviorTrackPatrolProgressNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

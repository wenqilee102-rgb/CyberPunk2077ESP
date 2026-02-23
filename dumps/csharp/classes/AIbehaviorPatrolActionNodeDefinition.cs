using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorPatrolActionNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _path;
		private CHandle<AIArgumentMapping> _patrolProgress;
		private CHandle<AIArgumentMapping> _startFromClosestPoint;
		private CHandle<AIArgumentMapping> _patrolContinuationPolicy;
		private CHandle<AIArgumentMapping> _playStartAnimation;
		private CHandle<AIArgumentMapping> _fastForwardAfterTeleport;
		private CHandle<AIArgumentMapping> _workspotData;
		private CHandle<AIArgumentMapping> _dependentWorkspotData;
		private CHandle<AIArgumentMapping> _lookAtTarget;
		private CHandle<AIArgumentMapping> _usePathContext;
		private CHandle<AIArgumentMapping> _useOffMeshLinkReservation;

		[Ordinal(1)] 
		[RED("path")] 
		public CHandle<AIArgumentMapping> Path
		{
			get => GetProperty(ref _path);
			set => SetProperty(ref _path, value);
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
		[RED("playStartAnimation")] 
		public CHandle<AIArgumentMapping> PlayStartAnimation
		{
			get => GetProperty(ref _playStartAnimation);
			set => SetProperty(ref _playStartAnimation, value);
		}

		[Ordinal(6)] 
		[RED("fastForwardAfterTeleport")] 
		public CHandle<AIArgumentMapping> FastForwardAfterTeleport
		{
			get => GetProperty(ref _fastForwardAfterTeleport);
			set => SetProperty(ref _fastForwardAfterTeleport, value);
		}

		[Ordinal(7)] 
		[RED("workspotData")] 
		public CHandle<AIArgumentMapping> WorkspotData
		{
			get => GetProperty(ref _workspotData);
			set => SetProperty(ref _workspotData, value);
		}

		[Ordinal(8)] 
		[RED("dependentWorkspotData")] 
		public CHandle<AIArgumentMapping> DependentWorkspotData
		{
			get => GetProperty(ref _dependentWorkspotData);
			set => SetProperty(ref _dependentWorkspotData, value);
		}

		[Ordinal(9)] 
		[RED("lookAtTarget")] 
		public CHandle<AIArgumentMapping> LookAtTarget
		{
			get => GetProperty(ref _lookAtTarget);
			set => SetProperty(ref _lookAtTarget, value);
		}

		[Ordinal(10)] 
		[RED("usePathContext")] 
		public CHandle<AIArgumentMapping> UsePathContext
		{
			get => GetProperty(ref _usePathContext);
			set => SetProperty(ref _usePathContext, value);
		}

		[Ordinal(11)] 
		[RED("useOffMeshLinkReservation")] 
		public CHandle<AIArgumentMapping> UseOffMeshLinkReservation
		{
			get => GetProperty(ref _useOffMeshLinkReservation);
			set => SetProperty(ref _useOffMeshLinkReservation, value);
		}

		public AIbehaviorPatrolActionNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDriveAvSimpleTreeNodeDefinition : AIbehaviorDriveTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _timeToTravel;
		private CHandle<AIArgumentMapping> _distanceToTravel;
		private CHandle<AIArgumentMapping> _useEaseInFunction;
		private CHandle<AIArgumentMapping> _useEaseOutFunction;
		private CHandle<AIArgumentMapping> _movementDirection;
		private CHandle<AIArgumentMapping> _useForwardDirection;
		private CHandle<AIArgumentMapping> _easeBounceMultiplier;
		private CHandle<AIArgumentMapping> _despawnAtTheEnd;
		private CHandle<AIArgumentMapping> _disableVFXs;
		private CHandle<AIArgumentMapping> _facePlayer;
		private CHandle<AIArgumentMapping> _doLandingRotation;
		private CHandle<AIArgumentMapping> _interruptTaskOnLandingFound;
		private CHandle<AIArgumentMapping> _attemptToSendEarlyDismountCommand;

		[Ordinal(1)] 
		[RED("timeToTravel")] 
		public CHandle<AIArgumentMapping> TimeToTravel
		{
			get => GetProperty(ref _timeToTravel);
			set => SetProperty(ref _timeToTravel, value);
		}

		[Ordinal(2)] 
		[RED("distanceToTravel")] 
		public CHandle<AIArgumentMapping> DistanceToTravel
		{
			get => GetProperty(ref _distanceToTravel);
			set => SetProperty(ref _distanceToTravel, value);
		}

		[Ordinal(3)] 
		[RED("useEaseInFunction")] 
		public CHandle<AIArgumentMapping> UseEaseInFunction
		{
			get => GetProperty(ref _useEaseInFunction);
			set => SetProperty(ref _useEaseInFunction, value);
		}

		[Ordinal(4)] 
		[RED("useEaseOutFunction")] 
		public CHandle<AIArgumentMapping> UseEaseOutFunction
		{
			get => GetProperty(ref _useEaseOutFunction);
			set => SetProperty(ref _useEaseOutFunction, value);
		}

		[Ordinal(5)] 
		[RED("movementDirection")] 
		public CHandle<AIArgumentMapping> MovementDirection
		{
			get => GetProperty(ref _movementDirection);
			set => SetProperty(ref _movementDirection, value);
		}

		[Ordinal(6)] 
		[RED("useForwardDirection")] 
		public CHandle<AIArgumentMapping> UseForwardDirection
		{
			get => GetProperty(ref _useForwardDirection);
			set => SetProperty(ref _useForwardDirection, value);
		}

		[Ordinal(7)] 
		[RED("easeBounceMultiplier")] 
		public CHandle<AIArgumentMapping> EaseBounceMultiplier
		{
			get => GetProperty(ref _easeBounceMultiplier);
			set => SetProperty(ref _easeBounceMultiplier, value);
		}

		[Ordinal(8)] 
		[RED("despawnAtTheEnd")] 
		public CHandle<AIArgumentMapping> DespawnAtTheEnd
		{
			get => GetProperty(ref _despawnAtTheEnd);
			set => SetProperty(ref _despawnAtTheEnd, value);
		}

		[Ordinal(9)] 
		[RED("disableVFXs")] 
		public CHandle<AIArgumentMapping> DisableVFXs
		{
			get => GetProperty(ref _disableVFXs);
			set => SetProperty(ref _disableVFXs, value);
		}

		[Ordinal(10)] 
		[RED("facePlayer")] 
		public CHandle<AIArgumentMapping> FacePlayer
		{
			get => GetProperty(ref _facePlayer);
			set => SetProperty(ref _facePlayer, value);
		}

		[Ordinal(11)] 
		[RED("doLandingRotation")] 
		public CHandle<AIArgumentMapping> DoLandingRotation
		{
			get => GetProperty(ref _doLandingRotation);
			set => SetProperty(ref _doLandingRotation, value);
		}

		[Ordinal(12)] 
		[RED("interruptTaskOnLandingFound")] 
		public CHandle<AIArgumentMapping> InterruptTaskOnLandingFound
		{
			get => GetProperty(ref _interruptTaskOnLandingFound);
			set => SetProperty(ref _interruptTaskOnLandingFound, value);
		}

		[Ordinal(13)] 
		[RED("attemptToSendEarlyDismountCommand")] 
		public CHandle<AIArgumentMapping> AttemptToSendEarlyDismountCommand
		{
			get => GetProperty(ref _attemptToSendEarlyDismountCommand);
			set => SetProperty(ref _attemptToSendEarlyDismountCommand, value);
		}

		public AIbehaviorDriveAvSimpleTreeNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

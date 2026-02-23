using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDrivePanicTreeNodeDefinition : AIbehaviorDriveTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _allowSimplifiedMovement;
		private CHandle<AIArgumentMapping> _ignoreTickets;
		private CHandle<AIArgumentMapping> _disableStuckDetection;
		private CHandle<AIArgumentMapping> _useSpeedBasedLookupRange;
		private CHandle<AIArgumentMapping> _tryDriveAwayFromPlayer;
		private CHandle<AIArgumentMapping> _needDriver;

		[Ordinal(1)] 
		[RED("allowSimplifiedMovement")] 
		public CHandle<AIArgumentMapping> AllowSimplifiedMovement
		{
			get => GetProperty(ref _allowSimplifiedMovement);
			set => SetProperty(ref _allowSimplifiedMovement, value);
		}

		[Ordinal(2)] 
		[RED("ignoreTickets")] 
		public CHandle<AIArgumentMapping> IgnoreTickets
		{
			get => GetProperty(ref _ignoreTickets);
			set => SetProperty(ref _ignoreTickets, value);
		}

		[Ordinal(3)] 
		[RED("disableStuckDetection")] 
		public CHandle<AIArgumentMapping> DisableStuckDetection
		{
			get => GetProperty(ref _disableStuckDetection);
			set => SetProperty(ref _disableStuckDetection, value);
		}

		[Ordinal(4)] 
		[RED("useSpeedBasedLookupRange")] 
		public CHandle<AIArgumentMapping> UseSpeedBasedLookupRange
		{
			get => GetProperty(ref _useSpeedBasedLookupRange);
			set => SetProperty(ref _useSpeedBasedLookupRange, value);
		}

		[Ordinal(5)] 
		[RED("tryDriveAwayFromPlayer")] 
		public CHandle<AIArgumentMapping> TryDriveAwayFromPlayer
		{
			get => GetProperty(ref _tryDriveAwayFromPlayer);
			set => SetProperty(ref _tryDriveAwayFromPlayer, value);
		}

		[Ordinal(6)] 
		[RED("needDriver")] 
		public CHandle<AIArgumentMapping> NeedDriver
		{
			get => GetProperty(ref _needDriver);
			set => SetProperty(ref _needDriver, value);
		}

		public AIbehaviorDrivePanicTreeNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

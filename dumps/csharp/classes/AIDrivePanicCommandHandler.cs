using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIDrivePanicCommandHandler : AICommandHandlerBase
	{
		private CHandle<AIArgumentMapping> _outAllowSimplifiedMovement;
		private CHandle<AIArgumentMapping> _outIgnoreTickets;
		private CHandle<AIArgumentMapping> _outDisableStuckDetection;
		private CHandle<AIArgumentMapping> _outUseSpeedBasedLookupRange;
		private CHandle<AIArgumentMapping> _outTryDriveAwayFromPlayer;

		[Ordinal(1)] 
		[RED("outAllowSimplifiedMovement")] 
		public CHandle<AIArgumentMapping> OutAllowSimplifiedMovement
		{
			get => GetProperty(ref _outAllowSimplifiedMovement);
			set => SetProperty(ref _outAllowSimplifiedMovement, value);
		}

		[Ordinal(2)] 
		[RED("outIgnoreTickets")] 
		public CHandle<AIArgumentMapping> OutIgnoreTickets
		{
			get => GetProperty(ref _outIgnoreTickets);
			set => SetProperty(ref _outIgnoreTickets, value);
		}

		[Ordinal(3)] 
		[RED("outDisableStuckDetection")] 
		public CHandle<AIArgumentMapping> OutDisableStuckDetection
		{
			get => GetProperty(ref _outDisableStuckDetection);
			set => SetProperty(ref _outDisableStuckDetection, value);
		}

		[Ordinal(4)] 
		[RED("outUseSpeedBasedLookupRange")] 
		public CHandle<AIArgumentMapping> OutUseSpeedBasedLookupRange
		{
			get => GetProperty(ref _outUseSpeedBasedLookupRange);
			set => SetProperty(ref _outUseSpeedBasedLookupRange, value);
		}

		[Ordinal(5)] 
		[RED("outTryDriveAwayFromPlayer")] 
		public CHandle<AIArgumentMapping> OutTryDriveAwayFromPlayer
		{
			get => GetProperty(ref _outTryDriveAwayFromPlayer);
			set => SetProperty(ref _outTryDriveAwayFromPlayer, value);
		}

		public AIDrivePanicCommandHandler(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

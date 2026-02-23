using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questvehiclePanicParams : questVehicleSpecificCommandParams
	{
		private CBool _allowSimplifiedMovement;
		private CBool _ignoreTickets;
		private CBool _disableStuckDetection;
		private CBool _useSpeedBasedLookupRange;
		private CBool _tryDriveAwayFromPlayer;

		[Ordinal(3)] 
		[RED("allowSimplifiedMovement")] 
		public CBool AllowSimplifiedMovement
		{
			get => GetProperty(ref _allowSimplifiedMovement);
			set => SetProperty(ref _allowSimplifiedMovement, value);
		}

		[Ordinal(4)] 
		[RED("ignoreTickets")] 
		public CBool IgnoreTickets
		{
			get => GetProperty(ref _ignoreTickets);
			set => SetProperty(ref _ignoreTickets, value);
		}

		[Ordinal(5)] 
		[RED("disableStuckDetection")] 
		public CBool DisableStuckDetection
		{
			get => GetProperty(ref _disableStuckDetection);
			set => SetProperty(ref _disableStuckDetection, value);
		}

		[Ordinal(6)] 
		[RED("useSpeedBasedLookupRange")] 
		public CBool UseSpeedBasedLookupRange
		{
			get => GetProperty(ref _useSpeedBasedLookupRange);
			set => SetProperty(ref _useSpeedBasedLookupRange, value);
		}

		[Ordinal(7)] 
		[RED("tryDriveAwayFromPlayer")] 
		public CBool TryDriveAwayFromPlayer
		{
			get => GetProperty(ref _tryDriveAwayFromPlayer);
			set => SetProperty(ref _tryDriveAwayFromPlayer, value);
		}

		public questvehiclePanicParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

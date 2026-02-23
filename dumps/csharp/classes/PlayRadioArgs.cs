using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayRadioArgs : IScriptable
	{
		private ScriptGameInstance _instance;
		private CFloat _delay;
		private CName _entryName;
		private CBool _onlyPlayIfPlayerIsBeingChased;
		private CBool _shouldCheckDistrictAfterDelay;
		private CBool _handleVehicleEntranceEdgeCase;
		private CBool _handleVehicleLostOrSpottedEdgeCase;
		private CEnum<EStarState> _stateUsedOnRequest;

		[Ordinal(0)] 
		[RED("instance")] 
		public ScriptGameInstance Instance
		{
			get => GetProperty(ref _instance);
			set => SetProperty(ref _instance, value);
		}

		[Ordinal(1)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetProperty(ref _delay);
			set => SetProperty(ref _delay, value);
		}

		[Ordinal(2)] 
		[RED("entryName")] 
		public CName EntryName
		{
			get => GetProperty(ref _entryName);
			set => SetProperty(ref _entryName, value);
		}

		[Ordinal(3)] 
		[RED("onlyPlayIfPlayerIsBeingChased")] 
		public CBool OnlyPlayIfPlayerIsBeingChased
		{
			get => GetProperty(ref _onlyPlayIfPlayerIsBeingChased);
			set => SetProperty(ref _onlyPlayIfPlayerIsBeingChased, value);
		}

		[Ordinal(4)] 
		[RED("shouldCheckDistrictAfterDelay")] 
		public CBool ShouldCheckDistrictAfterDelay
		{
			get => GetProperty(ref _shouldCheckDistrictAfterDelay);
			set => SetProperty(ref _shouldCheckDistrictAfterDelay, value);
		}

		[Ordinal(5)] 
		[RED("handleVehicleEntranceEdgeCase")] 
		public CBool HandleVehicleEntranceEdgeCase
		{
			get => GetProperty(ref _handleVehicleEntranceEdgeCase);
			set => SetProperty(ref _handleVehicleEntranceEdgeCase, value);
		}

		[Ordinal(6)] 
		[RED("handleVehicleLostOrSpottedEdgeCase")] 
		public CBool HandleVehicleLostOrSpottedEdgeCase
		{
			get => GetProperty(ref _handleVehicleLostOrSpottedEdgeCase);
			set => SetProperty(ref _handleVehicleLostOrSpottedEdgeCase, value);
		}

		[Ordinal(7)] 
		[RED("stateUsedOnRequest")] 
		public CEnum<EStarState> StateUsedOnRequest
		{
			get => GetProperty(ref _stateUsedOnRequest);
			set => SetProperty(ref _stateUsedOnRequest, value);
		}

		public PlayRadioArgs(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

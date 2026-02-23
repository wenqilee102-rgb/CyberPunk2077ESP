using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisionModeComponent : gameComponent
	{
		private CHandle<HighlightEditableData> _defaultHighlightData;
		private CArray<CHandle<FocusForcedHighlightData>> _forcedHighlights;
		private CHandle<FocusForcedHighlightData> _activeForcedHighlight;
		private CHandle<FocusForcedHighlightData> _currentDefaultHighlight;
		private CArray<gameVisionModeSystemRevealIdentifier> _activeRevealRequests;
		private CBool _isFocusModeActive;
		private CBool _wasCleanedUp;
		private CArray<entEntityID> _slaveObjectsToHighlight;

		[Ordinal(4)] 
		[RED("defaultHighlightData")] 
		public CHandle<HighlightEditableData> DefaultHighlightData
		{
			get => GetProperty(ref _defaultHighlightData);
			set => SetProperty(ref _defaultHighlightData, value);
		}

		[Ordinal(5)] 
		[RED("forcedHighlights")] 
		public CArray<CHandle<FocusForcedHighlightData>> ForcedHighlights
		{
			get => GetProperty(ref _forcedHighlights);
			set => SetProperty(ref _forcedHighlights, value);
		}

		[Ordinal(6)] 
		[RED("activeForcedHighlight")] 
		public CHandle<FocusForcedHighlightData> ActiveForcedHighlight
		{
			get => GetProperty(ref _activeForcedHighlight);
			set => SetProperty(ref _activeForcedHighlight, value);
		}

		[Ordinal(7)] 
		[RED("currentDefaultHighlight")] 
		public CHandle<FocusForcedHighlightData> CurrentDefaultHighlight
		{
			get => GetProperty(ref _currentDefaultHighlight);
			set => SetProperty(ref _currentDefaultHighlight, value);
		}

		[Ordinal(8)] 
		[RED("activeRevealRequests")] 
		public CArray<gameVisionModeSystemRevealIdentifier> ActiveRevealRequests
		{
			get => GetProperty(ref _activeRevealRequests);
			set => SetProperty(ref _activeRevealRequests, value);
		}

		[Ordinal(9)] 
		[RED("isFocusModeActive")] 
		public CBool IsFocusModeActive
		{
			get => GetProperty(ref _isFocusModeActive);
			set => SetProperty(ref _isFocusModeActive, value);
		}

		[Ordinal(10)] 
		[RED("wasCleanedUp")] 
		public CBool WasCleanedUp
		{
			get => GetProperty(ref _wasCleanedUp);
			set => SetProperty(ref _wasCleanedUp, value);
		}

		[Ordinal(11)] 
		[RED("slaveObjectsToHighlight")] 
		public CArray<entEntityID> SlaveObjectsToHighlight
		{
			get => GetProperty(ref _slaveObjectsToHighlight);
			set => SetProperty(ref _slaveObjectsToHighlight, value);
		}

		public gameVisionModeComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

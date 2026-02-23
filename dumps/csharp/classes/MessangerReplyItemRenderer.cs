using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MessangerReplyItemRenderer : JournalEntryListItemController
	{
		private CBool _selectedState;
		private CBool _isQuestImportant;
		private CBool _isActive;
		private CName _stateDefault;
		private CName _stateSelected;
		private CName _stateQuestDefault;
		private CName _stateQuestSelected;
		private CName _stateDisabled;

		[Ordinal(19)] 
		[RED("selectedState")] 
		public CBool SelectedState
		{
			get => GetProperty(ref _selectedState);
			set => SetProperty(ref _selectedState, value);
		}

		[Ordinal(20)] 
		[RED("isQuestImportant")] 
		public CBool IsQuestImportant
		{
			get => GetProperty(ref _isQuestImportant);
			set => SetProperty(ref _isQuestImportant, value);
		}

		[Ordinal(21)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(22)] 
		[RED("stateDefault")] 
		public CName StateDefault
		{
			get => GetProperty(ref _stateDefault);
			set => SetProperty(ref _stateDefault, value);
		}

		[Ordinal(23)] 
		[RED("stateSelected")] 
		public CName StateSelected
		{
			get => GetProperty(ref _stateSelected);
			set => SetProperty(ref _stateSelected, value);
		}

		[Ordinal(24)] 
		[RED("stateQuestDefault")] 
		public CName StateQuestDefault
		{
			get => GetProperty(ref _stateQuestDefault);
			set => SetProperty(ref _stateQuestDefault, value);
		}

		[Ordinal(25)] 
		[RED("stateQuestSelected")] 
		public CName StateQuestSelected
		{
			get => GetProperty(ref _stateQuestSelected);
			set => SetProperty(ref _stateQuestSelected, value);
		}

		[Ordinal(26)] 
		[RED("stateDisabled")] 
		public CName StateDisabled
		{
			get => GetProperty(ref _stateDisabled);
			set => SetProperty(ref _stateDisabled, value);
		}

		public MessangerReplyItemRenderer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

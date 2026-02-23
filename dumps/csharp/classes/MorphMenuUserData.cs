using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MorphMenuUserData : inkUserData
	{
		private CBool _optionsListInitialized;
		private CBool _updatingFinalizedState;
		private CEnum<gameuiCharacterCustomizationEditTag> _editMode;

		[Ordinal(0)] 
		[RED("optionsListInitialized")] 
		public CBool OptionsListInitialized
		{
			get => GetProperty(ref _optionsListInitialized);
			set => SetProperty(ref _optionsListInitialized, value);
		}

		[Ordinal(1)] 
		[RED("updatingFinalizedState")] 
		public CBool UpdatingFinalizedState
		{
			get => GetProperty(ref _updatingFinalizedState);
			set => SetProperty(ref _updatingFinalizedState, value);
		}

		[Ordinal(2)] 
		[RED("editMode")] 
		public CEnum<gameuiCharacterCustomizationEditTag> EditMode
		{
			get => GetProperty(ref _editMode);
			set => SetProperty(ref _editMode, value);
		}

		public MorphMenuUserData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

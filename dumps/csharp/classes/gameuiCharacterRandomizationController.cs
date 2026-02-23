using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterRandomizationController : inkWidgetLogicController
	{
		private inkWidgetReference _punkSlider;
		private inkGridWidgetReference _locksGrid;
		private CEnum<gameuiCharacterCustomizationEditTag> _editMode;
		private CBool _inputDisabled;
		private CArray<CEnum<gamedataCharacterRandomizationCategory>> _lockedCategories;
		private CArray<CEnum<gamedataCharacterRandomizationCategory>> _excludedCatergoriesMirror;
		private CArray<wCHandle<inkWidget>> _lockWidgets;
		private CArray<wCHandle<RandomizationLockListItem>> _lockLogics;
		private CArray<CHandle<gamedataCharacterRandomizationCategoryUI_Record>> _lockDatas;
		private CHandle<gameuiCharacterRandomizationParametersData> _data;
		private wCHandle<gameuiICharacterCustomizationSystem> _customizationSystem;
		private wCHandle<PunkScoreSelectorControllerInt> _punkSliderController;

		[Ordinal(1)] 
		[RED("punkSlider")] 
		public inkWidgetReference PunkSlider
		{
			get => GetProperty(ref _punkSlider);
			set => SetProperty(ref _punkSlider, value);
		}

		[Ordinal(2)] 
		[RED("locksGrid")] 
		public inkGridWidgetReference LocksGrid
		{
			get => GetProperty(ref _locksGrid);
			set => SetProperty(ref _locksGrid, value);
		}

		[Ordinal(3)] 
		[RED("editMode")] 
		public CEnum<gameuiCharacterCustomizationEditTag> EditMode
		{
			get => GetProperty(ref _editMode);
			set => SetProperty(ref _editMode, value);
		}

		[Ordinal(4)] 
		[RED("inputDisabled")] 
		public CBool InputDisabled
		{
			get => GetProperty(ref _inputDisabled);
			set => SetProperty(ref _inputDisabled, value);
		}

		[Ordinal(5)] 
		[RED("lockedCategories")] 
		public CArray<CEnum<gamedataCharacterRandomizationCategory>> LockedCategories
		{
			get => GetProperty(ref _lockedCategories);
			set => SetProperty(ref _lockedCategories, value);
		}

		[Ordinal(6)] 
		[RED("excludedCatergoriesMirror")] 
		public CArray<CEnum<gamedataCharacterRandomizationCategory>> ExcludedCatergoriesMirror
		{
			get => GetProperty(ref _excludedCatergoriesMirror);
			set => SetProperty(ref _excludedCatergoriesMirror, value);
		}

		[Ordinal(7)] 
		[RED("lockWidgets")] 
		public CArray<wCHandle<inkWidget>> LockWidgets
		{
			get => GetProperty(ref _lockWidgets);
			set => SetProperty(ref _lockWidgets, value);
		}

		[Ordinal(8)] 
		[RED("lockLogics")] 
		public CArray<wCHandle<RandomizationLockListItem>> LockLogics
		{
			get => GetProperty(ref _lockLogics);
			set => SetProperty(ref _lockLogics, value);
		}

		[Ordinal(9)] 
		[RED("lockDatas")] 
		public CArray<CHandle<gamedataCharacterRandomizationCategoryUI_Record>> LockDatas
		{
			get => GetProperty(ref _lockDatas);
			set => SetProperty(ref _lockDatas, value);
		}

		[Ordinal(10)] 
		[RED("data")] 
		public CHandle<gameuiCharacterRandomizationParametersData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(11)] 
		[RED("customizationSystem")] 
		public wCHandle<gameuiICharacterCustomizationSystem> CustomizationSystem
		{
			get => GetProperty(ref _customizationSystem);
			set => SetProperty(ref _customizationSystem, value);
		}

		[Ordinal(12)] 
		[RED("punkSliderController")] 
		public wCHandle<PunkScoreSelectorControllerInt> PunkSliderController
		{
			get => GetProperty(ref _punkSliderController);
			set => SetProperty(ref _punkSliderController, value);
		}

		public gameuiCharacterRandomizationController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

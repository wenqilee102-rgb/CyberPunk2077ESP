using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeShooterHUDController : inkWidgetLogicController
	{
		private inkImageWidgetReference _selectedWeaponSlot;
		private inkImageWidgetReference _secondWeaponSlot;
		private inkImageWidgetReference _thirdWeaponSlot;
		private inkWidgetReference _healthContainer;
		private inkWidgetReference _continueText;
		private inkImageWidgetReference _continueCountdownWidget;
		private inkImageWidgetReference _levelName;
		private inkImageWidgetReference _levelNumber1;
		private inkImageWidgetReference _levelNumber2;
		private inkWidgetReference _levelFinishCard;

		[Ordinal(1)] 
		[RED("selectedWeaponSlot")] 
		public inkImageWidgetReference SelectedWeaponSlot
		{
			get => GetProperty(ref _selectedWeaponSlot);
			set => SetProperty(ref _selectedWeaponSlot, value);
		}

		[Ordinal(2)] 
		[RED("secondWeaponSlot")] 
		public inkImageWidgetReference SecondWeaponSlot
		{
			get => GetProperty(ref _secondWeaponSlot);
			set => SetProperty(ref _secondWeaponSlot, value);
		}

		[Ordinal(3)] 
		[RED("thirdWeaponSlot")] 
		public inkImageWidgetReference ThirdWeaponSlot
		{
			get => GetProperty(ref _thirdWeaponSlot);
			set => SetProperty(ref _thirdWeaponSlot, value);
		}

		[Ordinal(4)] 
		[RED("healthContainer")] 
		public inkWidgetReference HealthContainer
		{
			get => GetProperty(ref _healthContainer);
			set => SetProperty(ref _healthContainer, value);
		}

		[Ordinal(5)] 
		[RED("continueText")] 
		public inkWidgetReference ContinueText
		{
			get => GetProperty(ref _continueText);
			set => SetProperty(ref _continueText, value);
		}

		[Ordinal(6)] 
		[RED("continueCountdownWidget")] 
		public inkImageWidgetReference ContinueCountdownWidget
		{
			get => GetProperty(ref _continueCountdownWidget);
			set => SetProperty(ref _continueCountdownWidget, value);
		}

		[Ordinal(7)] 
		[RED("levelName")] 
		public inkImageWidgetReference LevelName
		{
			get => GetProperty(ref _levelName);
			set => SetProperty(ref _levelName, value);
		}

		[Ordinal(8)] 
		[RED("levelNumber1")] 
		public inkImageWidgetReference LevelNumber1
		{
			get => GetProperty(ref _levelNumber1);
			set => SetProperty(ref _levelNumber1, value);
		}

		[Ordinal(9)] 
		[RED("levelNumber2")] 
		public inkImageWidgetReference LevelNumber2
		{
			get => GetProperty(ref _levelNumber2);
			set => SetProperty(ref _levelNumber2, value);
		}

		[Ordinal(10)] 
		[RED("levelFinishCard")] 
		public inkWidgetReference LevelFinishCard
		{
			get => GetProperty(ref _levelFinishCard);
			set => SetProperty(ref _levelFinishCard, value);
		}

		public gameuiarcadeShooterHUDController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

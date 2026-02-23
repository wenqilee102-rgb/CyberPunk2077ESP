using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewPerkTabsController : inkWidgetLogicController
	{
		private inkTextWidgetReference _tabText;
		private inkTextWidgetReference _currentAttributePoints;
		private inkImageWidgetReference _currentAttributeIcon;
		private inkWidgetReference _leftArrow;
		private inkWidgetReference _rightArrow;
		private inkWidgetReference _attributePointsWrapper;
		private inkTextWidgetReference _attributePointsText;
		private inkWidgetReference _perkPointsWrapper;
		private inkTextWidgetReference _perkPointsText;
		private inkWidgetReference _espionagePointsWrapper;
		private inkTextWidgetReference _espionagePointsText;
		private CArray<inkWidgetReference> _bars;
		private wCHandle<PlayerDevelopmentDataManager> _dataManager;
		private CHandle<NewPerksScreenInitData> _initData;
		private CBool _isEspionageUnlocked;

		[Ordinal(1)] 
		[RED("tabText")] 
		public inkTextWidgetReference TabText
		{
			get => GetProperty(ref _tabText);
			set => SetProperty(ref _tabText, value);
		}

		[Ordinal(2)] 
		[RED("currentAttributePoints")] 
		public inkTextWidgetReference CurrentAttributePoints
		{
			get => GetProperty(ref _currentAttributePoints);
			set => SetProperty(ref _currentAttributePoints, value);
		}

		[Ordinal(3)] 
		[RED("currentAttributeIcon")] 
		public inkImageWidgetReference CurrentAttributeIcon
		{
			get => GetProperty(ref _currentAttributeIcon);
			set => SetProperty(ref _currentAttributeIcon, value);
		}

		[Ordinal(4)] 
		[RED("leftArrow")] 
		public inkWidgetReference LeftArrow
		{
			get => GetProperty(ref _leftArrow);
			set => SetProperty(ref _leftArrow, value);
		}

		[Ordinal(5)] 
		[RED("rightArrow")] 
		public inkWidgetReference RightArrow
		{
			get => GetProperty(ref _rightArrow);
			set => SetProperty(ref _rightArrow, value);
		}

		[Ordinal(6)] 
		[RED("attributePointsWrapper")] 
		public inkWidgetReference AttributePointsWrapper
		{
			get => GetProperty(ref _attributePointsWrapper);
			set => SetProperty(ref _attributePointsWrapper, value);
		}

		[Ordinal(7)] 
		[RED("attributePointsText")] 
		public inkTextWidgetReference AttributePointsText
		{
			get => GetProperty(ref _attributePointsText);
			set => SetProperty(ref _attributePointsText, value);
		}

		[Ordinal(8)] 
		[RED("perkPointsWrapper")] 
		public inkWidgetReference PerkPointsWrapper
		{
			get => GetProperty(ref _perkPointsWrapper);
			set => SetProperty(ref _perkPointsWrapper, value);
		}

		[Ordinal(9)] 
		[RED("perkPointsText")] 
		public inkTextWidgetReference PerkPointsText
		{
			get => GetProperty(ref _perkPointsText);
			set => SetProperty(ref _perkPointsText, value);
		}

		[Ordinal(10)] 
		[RED("espionagePointsWrapper")] 
		public inkWidgetReference EspionagePointsWrapper
		{
			get => GetProperty(ref _espionagePointsWrapper);
			set => SetProperty(ref _espionagePointsWrapper, value);
		}

		[Ordinal(11)] 
		[RED("espionagePointsText")] 
		public inkTextWidgetReference EspionagePointsText
		{
			get => GetProperty(ref _espionagePointsText);
			set => SetProperty(ref _espionagePointsText, value);
		}

		[Ordinal(12)] 
		[RED("bars")] 
		public CArray<inkWidgetReference> Bars
		{
			get => GetProperty(ref _bars);
			set => SetProperty(ref _bars, value);
		}

		[Ordinal(13)] 
		[RED("dataManager")] 
		public wCHandle<PlayerDevelopmentDataManager> DataManager
		{
			get => GetProperty(ref _dataManager);
			set => SetProperty(ref _dataManager, value);
		}

		[Ordinal(14)] 
		[RED("initData")] 
		public CHandle<NewPerksScreenInitData> InitData
		{
			get => GetProperty(ref _initData);
			set => SetProperty(ref _initData, value);
		}

		[Ordinal(15)] 
		[RED("isEspionageUnlocked")] 
		public CBool IsEspionageUnlocked
		{
			get => GetProperty(ref _isEspionageUnlocked);
			set => SetProperty(ref _isEspionageUnlocked, value);
		}

		public NewPerkTabsController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

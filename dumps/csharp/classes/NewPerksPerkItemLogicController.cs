using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewPerksPerkItemLogicController : inkWidgetLogicController
	{
		private inkImageWidgetReference _icon;
		private inkImageWidgetReference _iconGhost;
		private inkWidgetReference _lockIcon;
		private inkTextWidgetReference _requiredPointsText;
		private inkTextWidgetReference _levelText;
		private inkWidgetReference _dEV_notYetImplemented;
		private wCHandle<NewPerksPerkContainerLogicController> _container;
		private CHandle<NewPerksPerkItemInitData> _initData;
		private CBool _isUnlocked;
		private CInt32 _currentLevel;
		private CBool _hovered;
		private CHandle<inkanimProxy> _maxedAnimProxy;
		private CArray<CHandle<inkanimProxy>> _animProxies;
		private CBool _isRelic;

		[Ordinal(1)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(2)] 
		[RED("iconGhost")] 
		public inkImageWidgetReference IconGhost
		{
			get => GetProperty(ref _iconGhost);
			set => SetProperty(ref _iconGhost, value);
		}

		[Ordinal(3)] 
		[RED("lockIcon")] 
		public inkWidgetReference LockIcon
		{
			get => GetProperty(ref _lockIcon);
			set => SetProperty(ref _lockIcon, value);
		}

		[Ordinal(4)] 
		[RED("requiredPointsText")] 
		public inkTextWidgetReference RequiredPointsText
		{
			get => GetProperty(ref _requiredPointsText);
			set => SetProperty(ref _requiredPointsText, value);
		}

		[Ordinal(5)] 
		[RED("levelText")] 
		public inkTextWidgetReference LevelText
		{
			get => GetProperty(ref _levelText);
			set => SetProperty(ref _levelText, value);
		}

		[Ordinal(6)] 
		[RED("DEV_notYetImplemented")] 
		public inkWidgetReference DEV_notYetImplemented
		{
			get => GetProperty(ref _dEV_notYetImplemented);
			set => SetProperty(ref _dEV_notYetImplemented, value);
		}

		[Ordinal(7)] 
		[RED("container")] 
		public wCHandle<NewPerksPerkContainerLogicController> Container
		{
			get => GetProperty(ref _container);
			set => SetProperty(ref _container, value);
		}

		[Ordinal(8)] 
		[RED("initData")] 
		public CHandle<NewPerksPerkItemInitData> InitData
		{
			get => GetProperty(ref _initData);
			set => SetProperty(ref _initData, value);
		}

		[Ordinal(9)] 
		[RED("isUnlocked")] 
		public CBool IsUnlocked
		{
			get => GetProperty(ref _isUnlocked);
			set => SetProperty(ref _isUnlocked, value);
		}

		[Ordinal(10)] 
		[RED("currentLevel")] 
		public CInt32 CurrentLevel
		{
			get => GetProperty(ref _currentLevel);
			set => SetProperty(ref _currentLevel, value);
		}

		[Ordinal(11)] 
		[RED("hovered")] 
		public CBool Hovered
		{
			get => GetProperty(ref _hovered);
			set => SetProperty(ref _hovered, value);
		}

		[Ordinal(12)] 
		[RED("maxedAnimProxy")] 
		public CHandle<inkanimProxy> MaxedAnimProxy
		{
			get => GetProperty(ref _maxedAnimProxy);
			set => SetProperty(ref _maxedAnimProxy, value);
		}

		[Ordinal(13)] 
		[RED("animProxies")] 
		public CArray<CHandle<inkanimProxy>> AnimProxies
		{
			get => GetProperty(ref _animProxies);
			set => SetProperty(ref _animProxies, value);
		}

		[Ordinal(14)] 
		[RED("isRelic")] 
		public CBool IsRelic
		{
			get => GetProperty(ref _isRelic);
			set => SetProperty(ref _isRelic, value);
		}

		public NewPerksPerkItemLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipStatController : inkWidgetLogicController
	{
		private inkTextWidgetReference _statName;
		private inkTextWidgetReference _statValue;
		private inkWidgetReference _statComparedContainer;
		private inkTextWidgetReference _statComparedValue;
		private inkImageWidgetReference _arrow;
		private CEnum<EMeasurementUnit> _measurementUnit;
		private CHandle<userSettingsUserSettings> _settings;
		private CHandle<ItemTooltipStatSettingsListener> _settingsListener;
		private CName _groupPath;
		private CBool _bigFontEnabled;
		private CBool _inCrafting;

		[Ordinal(1)] 
		[RED("statName")] 
		public inkTextWidgetReference StatName
		{
			get => GetProperty(ref _statName);
			set => SetProperty(ref _statName, value);
		}

		[Ordinal(2)] 
		[RED("statValue")] 
		public inkTextWidgetReference StatValue
		{
			get => GetProperty(ref _statValue);
			set => SetProperty(ref _statValue, value);
		}

		[Ordinal(3)] 
		[RED("statComparedContainer")] 
		public inkWidgetReference StatComparedContainer
		{
			get => GetProperty(ref _statComparedContainer);
			set => SetProperty(ref _statComparedContainer, value);
		}

		[Ordinal(4)] 
		[RED("statComparedValue")] 
		public inkTextWidgetReference StatComparedValue
		{
			get => GetProperty(ref _statComparedValue);
			set => SetProperty(ref _statComparedValue, value);
		}

		[Ordinal(5)] 
		[RED("arrow")] 
		public inkImageWidgetReference Arrow
		{
			get => GetProperty(ref _arrow);
			set => SetProperty(ref _arrow, value);
		}

		[Ordinal(6)] 
		[RED("measurementUnit")] 
		public CEnum<EMeasurementUnit> MeasurementUnit
		{
			get => GetProperty(ref _measurementUnit);
			set => SetProperty(ref _measurementUnit, value);
		}

		[Ordinal(7)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		[Ordinal(8)] 
		[RED("settingsListener")] 
		public CHandle<ItemTooltipStatSettingsListener> SettingsListener
		{
			get => GetProperty(ref _settingsListener);
			set => SetProperty(ref _settingsListener, value);
		}

		[Ordinal(9)] 
		[RED("groupPath")] 
		public CName GroupPath
		{
			get => GetProperty(ref _groupPath);
			set => SetProperty(ref _groupPath, value);
		}

		[Ordinal(10)] 
		[RED("bigFontEnabled")] 
		public CBool BigFontEnabled
		{
			get => GetProperty(ref _bigFontEnabled);
			set => SetProperty(ref _bigFontEnabled, value);
		}

		[Ordinal(11)] 
		[RED("inCrafting")] 
		public CBool InCrafting
		{
			get => GetProperty(ref _inCrafting);
			set => SetProperty(ref _inCrafting, value);
		}

		public ItemTooltipStatController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiControllerSettingsGameController : gameuiMenuGameController
	{
		private CArray<inkWidgetReference> _defaultWidgets;
		private CArray<inkWidgetReference> _southpawWidgets;
		private CArray<inkWidgetReference> _legacyWidgets;
		private inkWidgetReference _generalInputPanel;
		private inkWidgetReference _vehicleInputPanel;
		private inkWidgetReference _vehicleCombatInputPanel;
		private inkWidgetReference _selectorWidget;
		private inkWidgetReference _schemeLegacyRef;
		private inkWidgetReference _schemeAgileRef;
		private inkWidgetReference _schemeAlternativeRef;
		private inkWidgetReference _inputSettingSelectorRef;
		private CName _inputSettingGroupName;
		private CName _inputSettingVarName;
		private inkWidgetReference _buttonHintsManagerRef;
		private wCHandle<ButtonHints> _buttonHintsController;
		private wCHandle<inkListController> _selectorCtrl;
		private CArray<inkWidgetReference> _inputPanel;
		private CInt32 _currentTab;
		private wCHandle<SettingsSelectorControllerListString> _inputSettingSelector;
		private CHandle<InputSettingsVarListener> _inputSettingsListener;
		private CHandle<userSettingsUserSettings> _settings;
		private CHandle<userSettingsGroup> _inputSettingGroup;
		private CHandle<userSettingsVar> _inputSettingVar;

		[Ordinal(3)] 
		[RED("defaultWidgets")] 
		public CArray<inkWidgetReference> DefaultWidgets
		{
			get => GetProperty(ref _defaultWidgets);
			set => SetProperty(ref _defaultWidgets, value);
		}

		[Ordinal(4)] 
		[RED("southpawWidgets")] 
		public CArray<inkWidgetReference> SouthpawWidgets
		{
			get => GetProperty(ref _southpawWidgets);
			set => SetProperty(ref _southpawWidgets, value);
		}

		[Ordinal(5)] 
		[RED("legacyWidgets")] 
		public CArray<inkWidgetReference> LegacyWidgets
		{
			get => GetProperty(ref _legacyWidgets);
			set => SetProperty(ref _legacyWidgets, value);
		}

		[Ordinal(6)] 
		[RED("generalInputPanel")] 
		public inkWidgetReference GeneralInputPanel
		{
			get => GetProperty(ref _generalInputPanel);
			set => SetProperty(ref _generalInputPanel, value);
		}

		[Ordinal(7)] 
		[RED("vehicleInputPanel")] 
		public inkWidgetReference VehicleInputPanel
		{
			get => GetProperty(ref _vehicleInputPanel);
			set => SetProperty(ref _vehicleInputPanel, value);
		}

		[Ordinal(8)] 
		[RED("vehicleCombatInputPanel")] 
		public inkWidgetReference VehicleCombatInputPanel
		{
			get => GetProperty(ref _vehicleCombatInputPanel);
			set => SetProperty(ref _vehicleCombatInputPanel, value);
		}

		[Ordinal(9)] 
		[RED("selectorWidget")] 
		public inkWidgetReference SelectorWidget
		{
			get => GetProperty(ref _selectorWidget);
			set => SetProperty(ref _selectorWidget, value);
		}

		[Ordinal(10)] 
		[RED("schemeLegacyRef")] 
		public inkWidgetReference SchemeLegacyRef
		{
			get => GetProperty(ref _schemeLegacyRef);
			set => SetProperty(ref _schemeLegacyRef, value);
		}

		[Ordinal(11)] 
		[RED("schemeAgileRef")] 
		public inkWidgetReference SchemeAgileRef
		{
			get => GetProperty(ref _schemeAgileRef);
			set => SetProperty(ref _schemeAgileRef, value);
		}

		[Ordinal(12)] 
		[RED("schemeAlternativeRef")] 
		public inkWidgetReference SchemeAlternativeRef
		{
			get => GetProperty(ref _schemeAlternativeRef);
			set => SetProperty(ref _schemeAlternativeRef, value);
		}

		[Ordinal(13)] 
		[RED("inputSettingSelectorRef")] 
		public inkWidgetReference InputSettingSelectorRef
		{
			get => GetProperty(ref _inputSettingSelectorRef);
			set => SetProperty(ref _inputSettingSelectorRef, value);
		}

		[Ordinal(14)] 
		[RED("inputSettingGroupName")] 
		public CName InputSettingGroupName
		{
			get => GetProperty(ref _inputSettingGroupName);
			set => SetProperty(ref _inputSettingGroupName, value);
		}

		[Ordinal(15)] 
		[RED("inputSettingVarName")] 
		public CName InputSettingVarName
		{
			get => GetProperty(ref _inputSettingVarName);
			set => SetProperty(ref _inputSettingVarName, value);
		}

		[Ordinal(16)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(17)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(18)] 
		[RED("selectorCtrl")] 
		public wCHandle<inkListController> SelectorCtrl
		{
			get => GetProperty(ref _selectorCtrl);
			set => SetProperty(ref _selectorCtrl, value);
		}

		[Ordinal(19)] 
		[RED("inputPanel")] 
		public CArray<inkWidgetReference> InputPanel
		{
			get => GetProperty(ref _inputPanel);
			set => SetProperty(ref _inputPanel, value);
		}

		[Ordinal(20)] 
		[RED("currentTab")] 
		public CInt32 CurrentTab
		{
			get => GetProperty(ref _currentTab);
			set => SetProperty(ref _currentTab, value);
		}

		[Ordinal(21)] 
		[RED("inputSettingSelector")] 
		public wCHandle<SettingsSelectorControllerListString> InputSettingSelector
		{
			get => GetProperty(ref _inputSettingSelector);
			set => SetProperty(ref _inputSettingSelector, value);
		}

		[Ordinal(22)] 
		[RED("inputSettingsListener")] 
		public CHandle<InputSettingsVarListener> InputSettingsListener
		{
			get => GetProperty(ref _inputSettingsListener);
			set => SetProperty(ref _inputSettingsListener, value);
		}

		[Ordinal(23)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		[Ordinal(24)] 
		[RED("inputSettingGroup")] 
		public CHandle<userSettingsGroup> InputSettingGroup
		{
			get => GetProperty(ref _inputSettingGroup);
			set => SetProperty(ref _inputSettingGroup, value);
		}

		[Ordinal(25)] 
		[RED("inputSettingVar")] 
		public CHandle<userSettingsVar> InputSettingVar
		{
			get => GetProperty(ref _inputSettingVar);
			set => SetProperty(ref _inputSettingVar, value);
		}

		public gameuiControllerSettingsGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DlcDescriptionController : inkWidgetLogicController
	{
		private inkTextWidgetReference _titleRef;
		private inkTextWidgetReference _descriptionRef;
		private inkTextWidgetReference _guideRef;
		private inkImageWidgetReference _imageRef;
		private inkWidgetReference _settingSelectorRef;
		private wCHandle<inkSettingsSelectorController> _settingSelector;
		private CHandle<DLCSettingsVarListener> _settingsListener;
		private CHandle<userSettingsVar> _settingVar;
		private CBool _isPreGame;

		[Ordinal(1)] 
		[RED("titleRef")] 
		public inkTextWidgetReference TitleRef
		{
			get => GetProperty(ref _titleRef);
			set => SetProperty(ref _titleRef, value);
		}

		[Ordinal(2)] 
		[RED("descriptionRef")] 
		public inkTextWidgetReference DescriptionRef
		{
			get => GetProperty(ref _descriptionRef);
			set => SetProperty(ref _descriptionRef, value);
		}

		[Ordinal(3)] 
		[RED("guideRef")] 
		public inkTextWidgetReference GuideRef
		{
			get => GetProperty(ref _guideRef);
			set => SetProperty(ref _guideRef, value);
		}

		[Ordinal(4)] 
		[RED("imageRef")] 
		public inkImageWidgetReference ImageRef
		{
			get => GetProperty(ref _imageRef);
			set => SetProperty(ref _imageRef, value);
		}

		[Ordinal(5)] 
		[RED("settingSelectorRef")] 
		public inkWidgetReference SettingSelectorRef
		{
			get => GetProperty(ref _settingSelectorRef);
			set => SetProperty(ref _settingSelectorRef, value);
		}

		[Ordinal(6)] 
		[RED("settingSelector")] 
		public wCHandle<inkSettingsSelectorController> SettingSelector
		{
			get => GetProperty(ref _settingSelector);
			set => SetProperty(ref _settingSelector, value);
		}

		[Ordinal(7)] 
		[RED("settingsListener")] 
		public CHandle<DLCSettingsVarListener> SettingsListener
		{
			get => GetProperty(ref _settingsListener);
			set => SetProperty(ref _settingsListener, value);
		}

		[Ordinal(8)] 
		[RED("settingVar")] 
		public CHandle<userSettingsVar> SettingVar
		{
			get => GetProperty(ref _settingVar);
			set => SetProperty(ref _settingVar, value);
		}

		[Ordinal(9)] 
		[RED("isPreGame")] 
		public CBool IsPreGame
		{
			get => GetProperty(ref _isPreGame);
			set => SetProperty(ref _isPreGame, value);
		}

		public DlcDescriptionController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

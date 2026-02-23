using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameControllerPersistentDot : gameuiHUDGameController
	{
		private CHandle<userSettingsUserSettings> _settings;
		private CHandle<PersistentDotSettingsListener> _settingsListener;
		private CName _groupPath;
		private CBool _isAiming;
		private CHandle<redCallbackObject> _psmUpperBodyStateCallback;

		[Ordinal(9)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		[Ordinal(10)] 
		[RED("settingsListener")] 
		public CHandle<PersistentDotSettingsListener> SettingsListener
		{
			get => GetProperty(ref _settingsListener);
			set => SetProperty(ref _settingsListener, value);
		}

		[Ordinal(11)] 
		[RED("groupPath")] 
		public CName GroupPath
		{
			get => GetProperty(ref _groupPath);
			set => SetProperty(ref _groupPath, value);
		}

		[Ordinal(12)] 
		[RED("isAiming")] 
		public CBool IsAiming
		{
			get => GetProperty(ref _isAiming);
			set => SetProperty(ref _isAiming, value);
		}

		[Ordinal(13)] 
		[RED("psmUpperBodyStateCallback")] 
		public CHandle<redCallbackObject> PsmUpperBodyStateCallback
		{
			get => GetProperty(ref _psmUpperBodyStateCallback);
			set => SetProperty(ref _psmUpperBodyStateCallback, value);
		}

		public CrosshairGameControllerPersistentDot(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

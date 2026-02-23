using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DlcMenuGameController : gameuiMenuGameController
	{
		private inkWidgetReference _buttonHintsRef;
		private inkCompoundWidgetReference _containersRef;
		private CHandle<userSettingsUserSettings> _settings;
		private CHandle<userSettingsGroup> _dlcSettingsGroup;

		[Ordinal(3)] 
		[RED("buttonHintsRef")] 
		public inkWidgetReference ButtonHintsRef
		{
			get => GetProperty(ref _buttonHintsRef);
			set => SetProperty(ref _buttonHintsRef, value);
		}

		[Ordinal(4)] 
		[RED("containersRef")] 
		public inkCompoundWidgetReference ContainersRef
		{
			get => GetProperty(ref _containersRef);
			set => SetProperty(ref _containersRef, value);
		}

		[Ordinal(5)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		[Ordinal(6)] 
		[RED("dlcSettingsGroup")] 
		public CHandle<userSettingsGroup> DlcSettingsGroup
		{
			get => GetProperty(ref _dlcSettingsGroup);
			set => SetProperty(ref _dlcSettingsGroup, value);
		}

		public DlcMenuGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

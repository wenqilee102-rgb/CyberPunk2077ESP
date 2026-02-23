using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SettingsMenuUserData : gameuiMenuGameController
	{
		private CBool _isDlcSettings;
		private CBool _isBenchmarkSettings;

		[Ordinal(3)] 
		[RED("isDlcSettings")] 
		public CBool IsDlcSettings
		{
			get => GetProperty(ref _isDlcSettings);
			set => SetProperty(ref _isDlcSettings, value);
		}

		[Ordinal(4)] 
		[RED("isBenchmarkSettings")] 
		public CBool IsBenchmarkSettings
		{
			get => GetProperty(ref _isBenchmarkSettings);
			set => SetProperty(ref _isBenchmarkSettings, value);
		}

		public SettingsMenuUserData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadioVolumeSettingsController : inkSettingsSelectorController
	{
		private inkTextWidgetReference _value;

		[Ordinal(16)] 
		[RED("value")] 
		public inkTextWidgetReference Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public RadioVolumeSettingsController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

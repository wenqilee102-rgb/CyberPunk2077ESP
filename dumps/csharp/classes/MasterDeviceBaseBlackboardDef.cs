using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MasterDeviceBaseBlackboardDef : DeviceBaseBlackboardDef
	{
		private gamebbScriptID_Variant _thumbnailWidgetsData;
		private gamebbScriptID_Bool _cleanPassword;

		[Ordinal(7)] 
		[RED("ThumbnailWidgetsData")] 
		public gamebbScriptID_Variant ThumbnailWidgetsData
		{
			get => GetProperty(ref _thumbnailWidgetsData);
			set => SetProperty(ref _thumbnailWidgetsData, value);
		}

		[Ordinal(8)] 
		[RED("CleanPassword")] 
		public gamebbScriptID_Bool CleanPassword
		{
			get => GetProperty(ref _cleanPassword);
			set => SetProperty(ref _cleanPassword, value);
		}

		public MasterDeviceBaseBlackboardDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

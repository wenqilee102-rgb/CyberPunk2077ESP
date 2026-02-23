using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiWorldMapPlayerMappinController : gameuiBaseWorldMapMappinController
	{
		private inkImageWidgetReference _coneIconWidget;

		[Ordinal(28)] 
		[RED("coneIconWidget")] 
		public inkImageWidgetReference ConeIconWidget
		{
			get => GetProperty(ref _coneIconWidget);
			set => SetProperty(ref _coneIconWidget, value);
		}

		public gameuiWorldMapPlayerMappinController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeArcadeBackgroundController : inkWidgetLogicController
	{
		private CArray<inkWidgetReference> _backgroundLayerList;

		[Ordinal(1)] 
		[RED("backgroundLayerList")] 
		public CArray<inkWidgetReference> BackgroundLayerList
		{
			get => GetProperty(ref _backgroundLayerList);
			set => SetProperty(ref _backgroundLayerList, value);
		}

		public gameuiarcadeArcadeBackgroundController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

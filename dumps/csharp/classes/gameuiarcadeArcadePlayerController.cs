using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeArcadePlayerController : inkWidgetLogicController
	{
		private CArray<gameuiarcadeArcadeColliderData> _colliderList;

		[Ordinal(1)] 
		[RED("colliderList")] 
		public CArray<gameuiarcadeArcadeColliderData> ColliderList
		{
			get => GetProperty(ref _colliderList);
			set => SetProperty(ref _colliderList, value);
		}

		public gameuiarcadeArcadePlayerController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

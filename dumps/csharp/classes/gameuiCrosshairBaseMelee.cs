using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCrosshairBaseMelee : gameuiCrosshairBaseGameController
	{
		private CHandle<redCallbackObject> _meleeStateBlackboardId;

		[Ordinal(29)] 
		[RED("meleeStateBlackboardId")] 
		public CHandle<redCallbackObject> MeleeStateBlackboardId
		{
			get => GetProperty(ref _meleeStateBlackboardId);
			set => SetProperty(ref _meleeStateBlackboardId, value);
		}

		public gameuiCrosshairBaseMelee(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

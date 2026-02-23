using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleShopPlayerBalanceCallback : gameInventoryScriptCallback
	{
		private wCHandle<gameuiVehicleShopGameController> _owner;

		[Ordinal(1)] 
		[RED("owner")] 
		public wCHandle<gameuiVehicleShopGameController> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		public VehicleShopPlayerBalanceCallback(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

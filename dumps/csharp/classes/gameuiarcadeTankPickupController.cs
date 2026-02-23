using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeTankPickupController : gameuiarcadeArcadeObjectController
	{
		private inkWidgetReference _pickup;
		private inkWidgetReference _pickupText;

		[Ordinal(3)] 
		[RED("pickup")] 
		public inkWidgetReference Pickup
		{
			get => GetProperty(ref _pickup);
			set => SetProperty(ref _pickup, value);
		}

		[Ordinal(4)] 
		[RED("pickupText")] 
		public inkWidgetReference PickupText
		{
			get => GetProperty(ref _pickupText);
			set => SetProperty(ref _pickupText, value);
		}

		public gameuiarcadeTankPickupController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

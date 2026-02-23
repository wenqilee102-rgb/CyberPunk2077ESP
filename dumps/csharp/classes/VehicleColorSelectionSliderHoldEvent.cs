using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleColorSelectionSliderHoldEvent : redEvent
	{
		private CInt32 _direction;

		[Ordinal(0)] 
		[RED("direction")] 
		public CInt32 Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}

		public VehicleColorSelectionSliderHoldEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

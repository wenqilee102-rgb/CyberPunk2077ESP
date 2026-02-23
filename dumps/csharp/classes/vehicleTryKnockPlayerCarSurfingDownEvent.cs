using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleTryKnockPlayerCarSurfingDownEvent : redEvent
	{
		private Vector3 _impactPoint;

		[Ordinal(0)] 
		[RED("impactPoint")] 
		public Vector3 ImpactPoint
		{
			get => GetProperty(ref _impactPoint);
			set => SetProperty(ref _impactPoint, value);
		}

		public vehicleTryKnockPlayerCarSurfingDownEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

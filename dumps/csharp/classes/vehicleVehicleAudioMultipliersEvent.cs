using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleVehicleAudioMultipliersEvent : redEvent
	{
		private audioVehicleMultipliers _multipliers;

		[Ordinal(0)] 
		[RED("multipliers")] 
		public audioVehicleMultipliers Multipliers
		{
			get => GetProperty(ref _multipliers);
			set => SetProperty(ref _multipliers, value);
		}

		public vehicleVehicleAudioMultipliersEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

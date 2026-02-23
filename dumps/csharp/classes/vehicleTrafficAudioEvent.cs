using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleTrafficAudioEvent : redEvent
	{
		private CEnum<audioTrafficVehicleAudioAction> _audioAction;

		[Ordinal(0)] 
		[RED("audioAction")] 
		public CEnum<audioTrafficVehicleAudioAction> AudioAction
		{
			get => GetProperty(ref _audioAction);
			set => SetProperty(ref _audioAction, value);
		}

		public vehicleTrafficAudioEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

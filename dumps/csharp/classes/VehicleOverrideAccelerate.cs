using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleOverrideAccelerate : ActionBool
	{
		private CBool _isRequestedFormOtherDevice;

		[Ordinal(39)] 
		[RED("isRequestedFormOtherDevice")] 
		public CBool IsRequestedFormOtherDevice
		{
			get => GetProperty(ref _isRequestedFormOtherDevice);
			set => SetProperty(ref _isRequestedFormOtherDevice, value);
		}

		public VehicleOverrideAccelerate(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadioControllerPS : MediaDeviceControllerPS
	{
		private RadioSetup _radioSetup;
		private CBool _wasRadioSetup;

		[Ordinal(112)] 
		[RED("radioSetup")] 
		public RadioSetup RadioSetup
		{
			get => GetProperty(ref _radioSetup);
			set => SetProperty(ref _radioSetup, value);
		}

		[Ordinal(113)] 
		[RED("wasRadioSetup")] 
		public CBool WasRadioSetup
		{
			get => GetProperty(ref _wasRadioSetup);
			set => SetProperty(ref _wasRadioSetup, value);
		}

		public RadioControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

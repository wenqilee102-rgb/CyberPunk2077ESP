using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HoloFeederControllerPS : ScriptableDeviceComponentPS
	{
		private CName _turnOnSFX;
		private CName _turnOffSFX;

		[Ordinal(107)] 
		[RED("turnOnSFX")] 
		public CName TurnOnSFX
		{
			get => GetProperty(ref _turnOnSFX);
			set => SetProperty(ref _turnOnSFX, value);
		}

		[Ordinal(108)] 
		[RED("turnOffSFX")] 
		public CName TurnOffSFX
		{
			get => GetProperty(ref _turnOffSFX);
			set => SetProperty(ref _turnOffSFX, value);
		}

		public HoloFeederControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

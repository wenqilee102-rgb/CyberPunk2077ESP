using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SniperNestControllerPS : SensorDeviceControllerPS
	{
		private CName _vfxNameOnShoot;
		private CBool _isRippedOff;

		[Ordinal(150)] 
		[RED("vfxNameOnShoot")] 
		public CName VfxNameOnShoot
		{
			get => GetProperty(ref _vfxNameOnShoot);
			set => SetProperty(ref _vfxNameOnShoot, value);
		}

		[Ordinal(151)] 
		[RED("isRippedOff")] 
		public CBool IsRippedOff
		{
			get => GetProperty(ref _isRippedOff);
			set => SetProperty(ref _isRippedOff, value);
		}

		public SniperNestControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

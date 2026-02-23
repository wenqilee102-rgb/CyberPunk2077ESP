using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cameraShotEffect_LookAtVehicle : vehicleTimedCinematicCameraShotEffect
	{
		private Vector4 _aimOffset;
		private CBool _ignoreHorizontal;
		private CBool _ignoreVertical;

		[Ordinal(3)] 
		[RED("aimOffset")] 
		public Vector4 AimOffset
		{
			get => GetProperty(ref _aimOffset);
			set => SetProperty(ref _aimOffset, value);
		}

		[Ordinal(4)] 
		[RED("ignoreHorizontal")] 
		public CBool IgnoreHorizontal
		{
			get => GetProperty(ref _ignoreHorizontal);
			set => SetProperty(ref _ignoreHorizontal, value);
		}

		[Ordinal(5)] 
		[RED("ignoreVertical")] 
		public CBool IgnoreVertical
		{
			get => GetProperty(ref _ignoreVertical);
			set => SetProperty(ref _ignoreVertical, value);
		}

		public cameraShotEffect_LookAtVehicle(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

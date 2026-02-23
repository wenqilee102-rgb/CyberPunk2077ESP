using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cameraShotRoot_FixedShot : vehicleCinematicCameraShotRoot
	{
		private Transform _offsetFromInitialPosition;

		[Ordinal(0)] 
		[RED("offsetFromInitialPosition")] 
		public Transform OffsetFromInitialPosition
		{
			get => GetProperty(ref _offsetFromInitialPosition);
			set => SetProperty(ref _offsetFromInitialPosition, value);
		}

		public cameraShotRoot_FixedShot(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

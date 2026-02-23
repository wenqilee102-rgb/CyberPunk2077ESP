using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HoloFeeder : InteractiveDevice
	{
		private CHandle<entIPlacedComponent> _feederMesh;
		private CHandle<entIPlacedComponent> _feederMesh1;

		[Ordinal(98)] 
		[RED("feederMesh")] 
		public CHandle<entIPlacedComponent> FeederMesh
		{
			get => GetProperty(ref _feederMesh);
			set => SetProperty(ref _feederMesh, value);
		}

		[Ordinal(99)] 
		[RED("feederMesh1")] 
		public CHandle<entIPlacedComponent> FeederMesh1
		{
			get => GetProperty(ref _feederMesh1);
			set => SetProperty(ref _feederMesh1, value);
		}

		public HoloFeeder(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

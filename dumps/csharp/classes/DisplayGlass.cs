using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DisplayGlass : InteractiveDevice
	{
		private CHandle<entIPlacedComponent> _collider;
		private CHandle<entIPlacedComponent> _mesh;
		private CBool _isDestroyed;

		[Ordinal(98)] 
		[RED("collider")] 
		public CHandle<entIPlacedComponent> Collider
		{
			get => GetProperty(ref _collider);
			set => SetProperty(ref _collider, value);
		}

		[Ordinal(99)] 
		[RED("mesh")] 
		public CHandle<entIPlacedComponent> Mesh
		{
			get => GetProperty(ref _mesh);
			set => SetProperty(ref _mesh, value);
		}

		[Ordinal(100)] 
		[RED("isDestroyed")] 
		public CBool IsDestroyed
		{
			get => GetProperty(ref _isDestroyed);
			set => SetProperty(ref _isDestroyed, value);
		}

		public DisplayGlass(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

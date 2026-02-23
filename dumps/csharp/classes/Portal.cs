using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Portal : InteractiveDevice
	{
		private NodeRef _exitNode;
		private NodeRef _linkedPortal;
		private wCHandle<entIPlacedComponent> _renderToTextureComponent;
		private wCHandle<entIPlacedComponent> _virtualCameraComponent;
		private CBool _isInStreamRange;
		private CBool _isInTeleportRange;
		private CBool _isOnOtherSide;
		private wCHandle<entIPlacedComponent> _playerBlocker;
		private wCHandle<entMeshComponent> _screen;

		[Ordinal(98)] 
		[RED("exitNode")] 
		public NodeRef ExitNode
		{
			get => GetProperty(ref _exitNode);
			set => SetProperty(ref _exitNode, value);
		}

		[Ordinal(99)] 
		[RED("LinkedPortal")] 
		public NodeRef LinkedPortal
		{
			get => GetProperty(ref _linkedPortal);
			set => SetProperty(ref _linkedPortal, value);
		}

		[Ordinal(100)] 
		[RED("renderToTextureComponent")] 
		public wCHandle<entIPlacedComponent> RenderToTextureComponent
		{
			get => GetProperty(ref _renderToTextureComponent);
			set => SetProperty(ref _renderToTextureComponent, value);
		}

		[Ordinal(101)] 
		[RED("virtualCameraComponent")] 
		public wCHandle<entIPlacedComponent> VirtualCameraComponent
		{
			get => GetProperty(ref _virtualCameraComponent);
			set => SetProperty(ref _virtualCameraComponent, value);
		}

		[Ordinal(102)] 
		[RED("isInStreamRange")] 
		public CBool IsInStreamRange
		{
			get => GetProperty(ref _isInStreamRange);
			set => SetProperty(ref _isInStreamRange, value);
		}

		[Ordinal(103)] 
		[RED("isInTeleportRange")] 
		public CBool IsInTeleportRange
		{
			get => GetProperty(ref _isInTeleportRange);
			set => SetProperty(ref _isInTeleportRange, value);
		}

		[Ordinal(104)] 
		[RED("isOnOtherSide")] 
		public CBool IsOnOtherSide
		{
			get => GetProperty(ref _isOnOtherSide);
			set => SetProperty(ref _isOnOtherSide, value);
		}

		[Ordinal(105)] 
		[RED("playerBlocker")] 
		public wCHandle<entIPlacedComponent> PlayerBlocker
		{
			get => GetProperty(ref _playerBlocker);
			set => SetProperty(ref _playerBlocker, value);
		}

		[Ordinal(106)] 
		[RED("screen")] 
		public wCHandle<entMeshComponent> Screen
		{
			get => GetProperty(ref _screen);
			set => SetProperty(ref _screen, value);
		}

		public Portal(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

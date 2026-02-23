using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DataTerm : InteractiveDevice
	{
		private CHandle<gameFastTravelPointData> _linkedFastTravelPoint;
		private NodeRef _exitNode;
		private NodeRef _metroAnimationNode;
		private CBool _subwayGateBroken;
		private CHandle<FastTravelComponent> _fastTravelComponent;
		private CHandle<entIPlacedComponent> _lockColiderComponent;
		private gameNewMappinID _mappinID;
		private CBool _isShortGlitchActive;
		private gameDelayID _shortGlitchDelayID;
		private CHandle<entIPlacedComponent> _hologramMeshGreen;
		private CHandle<entIPlacedComponent> _hologramMeshRed;

		[Ordinal(98)] 
		[RED("linkedFastTravelPoint")] 
		public CHandle<gameFastTravelPointData> LinkedFastTravelPoint
		{
			get => GetProperty(ref _linkedFastTravelPoint);
			set => SetProperty(ref _linkedFastTravelPoint, value);
		}

		[Ordinal(99)] 
		[RED("exitNode")] 
		public NodeRef ExitNode
		{
			get => GetProperty(ref _exitNode);
			set => SetProperty(ref _exitNode, value);
		}

		[Ordinal(100)] 
		[RED("metroAnimationNode")] 
		public NodeRef MetroAnimationNode
		{
			get => GetProperty(ref _metroAnimationNode);
			set => SetProperty(ref _metroAnimationNode, value);
		}

		[Ordinal(101)] 
		[RED("SubwayGateBroken")] 
		public CBool SubwayGateBroken
		{
			get => GetProperty(ref _subwayGateBroken);
			set => SetProperty(ref _subwayGateBroken, value);
		}

		[Ordinal(102)] 
		[RED("fastTravelComponent")] 
		public CHandle<FastTravelComponent> FastTravelComponent
		{
			get => GetProperty(ref _fastTravelComponent);
			set => SetProperty(ref _fastTravelComponent, value);
		}

		[Ordinal(103)] 
		[RED("lockColiderComponent")] 
		public CHandle<entIPlacedComponent> LockColiderComponent
		{
			get => GetProperty(ref _lockColiderComponent);
			set => SetProperty(ref _lockColiderComponent, value);
		}

		[Ordinal(104)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get => GetProperty(ref _mappinID);
			set => SetProperty(ref _mappinID, value);
		}

		[Ordinal(105)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetProperty(ref _isShortGlitchActive);
			set => SetProperty(ref _isShortGlitchActive, value);
		}

		[Ordinal(106)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetProperty(ref _shortGlitchDelayID);
			set => SetProperty(ref _shortGlitchDelayID, value);
		}

		[Ordinal(107)] 
		[RED("hologramMeshGreen")] 
		public CHandle<entIPlacedComponent> HologramMeshGreen
		{
			get => GetProperty(ref _hologramMeshGreen);
			set => SetProperty(ref _hologramMeshGreen, value);
		}

		[Ordinal(108)] 
		[RED("hologramMeshRed")] 
		public CHandle<entIPlacedComponent> HologramMeshRed
		{
			get => GetProperty(ref _hologramMeshRed);
			set => SetProperty(ref _hologramMeshRed, value);
		}

		public DataTerm(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

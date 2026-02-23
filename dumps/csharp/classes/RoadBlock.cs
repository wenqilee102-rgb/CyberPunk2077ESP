using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RoadBlock : InteractiveDevice
	{
		private CFloat _openingSpeed;
		private CArray<NodeRef> _coverObjectRefs;
		private CHandle<entAnimationControllerComponent> _animationController;
		private CHandle<AIOffMeshConnectionComponent> _offMeshConnection;
		private CHandle<AnimFeature_RoadBlock> _animFeature;
		private CEnum<EAnimationType> _animationType;
		private CBool _forceEnableLink;
		private CArray<worldGlobalNodeRef> _globalCoverObjectRefs;
		private CBool _areGlobalCoverRefsInitialized;

		[Ordinal(98)] 
		[RED("openingSpeed")] 
		public CFloat OpeningSpeed
		{
			get => GetProperty(ref _openingSpeed);
			set => SetProperty(ref _openingSpeed, value);
		}

		[Ordinal(99)] 
		[RED("coverObjectRefs")] 
		public CArray<NodeRef> CoverObjectRefs
		{
			get => GetProperty(ref _coverObjectRefs);
			set => SetProperty(ref _coverObjectRefs, value);
		}

		[Ordinal(100)] 
		[RED("animationController")] 
		public CHandle<entAnimationControllerComponent> AnimationController
		{
			get => GetProperty(ref _animationController);
			set => SetProperty(ref _animationController, value);
		}

		[Ordinal(101)] 
		[RED("offMeshConnection")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnection
		{
			get => GetProperty(ref _offMeshConnection);
			set => SetProperty(ref _offMeshConnection, value);
		}

		[Ordinal(102)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_RoadBlock> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}

		[Ordinal(103)] 
		[RED("animationType")] 
		public CEnum<EAnimationType> AnimationType
		{
			get => GetProperty(ref _animationType);
			set => SetProperty(ref _animationType, value);
		}

		[Ordinal(104)] 
		[RED("forceEnableLink")] 
		public CBool ForceEnableLink
		{
			get => GetProperty(ref _forceEnableLink);
			set => SetProperty(ref _forceEnableLink, value);
		}

		[Ordinal(105)] 
		[RED("globalCoverObjectRefs")] 
		public CArray<worldGlobalNodeRef> GlobalCoverObjectRefs
		{
			get => GetProperty(ref _globalCoverObjectRefs);
			set => SetProperty(ref _globalCoverObjectRefs, value);
		}

		[Ordinal(106)] 
		[RED("areGlobalCoverRefsInitialized")] 
		public CBool AreGlobalCoverRefsInitialized
		{
			get => GetProperty(ref _areGlobalCoverRefsInitialized);
			set => SetProperty(ref _areGlobalCoverRefsInitialized, value);
		}

		public RoadBlock(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

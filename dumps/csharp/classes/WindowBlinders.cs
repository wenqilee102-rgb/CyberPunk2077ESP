using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WindowBlinders : InteractiveDevice
	{
		private CHandle<AnimFeature_SimpleDevice> _animFeature;
		private CName _workspotSideName;
		private CHandle<gameLightComponent> _portalLight;
		private CHandle<gameLightComponent> _portalLight2;
		private CHandle<gameLightComponent> _portalLight3;
		private CHandle<gameLightComponent> _portalLight4;
		private CArray<CName> _sideTriggerNames;
		private CArray<CHandle<gameStaticTriggerAreaComponent>> _triggerComponents;
		private CHandle<entIPlacedComponent> _interactionBlockingCollider;

		[Ordinal(98)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_SimpleDevice> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}

		[Ordinal(99)] 
		[RED("workspotSideName")] 
		public CName WorkspotSideName
		{
			get => GetProperty(ref _workspotSideName);
			set => SetProperty(ref _workspotSideName, value);
		}

		[Ordinal(100)] 
		[RED("portalLight")] 
		public CHandle<gameLightComponent> PortalLight
		{
			get => GetProperty(ref _portalLight);
			set => SetProperty(ref _portalLight, value);
		}

		[Ordinal(101)] 
		[RED("portalLight2")] 
		public CHandle<gameLightComponent> PortalLight2
		{
			get => GetProperty(ref _portalLight2);
			set => SetProperty(ref _portalLight2, value);
		}

		[Ordinal(102)] 
		[RED("portalLight3")] 
		public CHandle<gameLightComponent> PortalLight3
		{
			get => GetProperty(ref _portalLight3);
			set => SetProperty(ref _portalLight3, value);
		}

		[Ordinal(103)] 
		[RED("portalLight4")] 
		public CHandle<gameLightComponent> PortalLight4
		{
			get => GetProperty(ref _portalLight4);
			set => SetProperty(ref _portalLight4, value);
		}

		[Ordinal(104)] 
		[RED("sideTriggerNames")] 
		public CArray<CName> SideTriggerNames
		{
			get => GetProperty(ref _sideTriggerNames);
			set => SetProperty(ref _sideTriggerNames, value);
		}

		[Ordinal(105)] 
		[RED("triggerComponents")] 
		public CArray<CHandle<gameStaticTriggerAreaComponent>> TriggerComponents
		{
			get => GetProperty(ref _triggerComponents);
			set => SetProperty(ref _triggerComponents, value);
		}

		[Ordinal(106)] 
		[RED("interactionBlockingCollider")] 
		public CHandle<entIPlacedComponent> InteractionBlockingCollider
		{
			get => GetProperty(ref _interactionBlockingCollider);
			set => SetProperty(ref _interactionBlockingCollider, value);
		}

		public WindowBlinders(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

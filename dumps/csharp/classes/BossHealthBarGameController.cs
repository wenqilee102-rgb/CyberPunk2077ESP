using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BossHealthBarGameController : gameuiHUDGameController
	{
		private inkWidgetReference _healthControllerRef;
		private inkTextWidgetReference _healthPercentage;
		private inkTextWidgetReference _bossName;
		private inkCompoundWidgetReference _dividerContainerRef;
		private CHandle<BossHealthStatListener> _statListener;
		private wCHandle<NPCPuppet> _boss;
		private wCHandle<NameplateBarLogicController> _healthController;
		private CArray<CFloat> _thresholds;
		private wCHandle<inkWidget> _root;
		private CHandle<inkanimProxy> _unfoldAnimation;
		private CHandle<inkanimProxy> _foldAnimation;
		private CHandle<redCallbackObject> _fastTravelCallbackID;
		private CArray<wCHandle<NPCPuppet>> _bossPuppets;

		[Ordinal(9)] 
		[RED("healthControllerRef")] 
		public inkWidgetReference HealthControllerRef
		{
			get => GetProperty(ref _healthControllerRef);
			set => SetProperty(ref _healthControllerRef, value);
		}

		[Ordinal(10)] 
		[RED("healthPercentage")] 
		public inkTextWidgetReference HealthPercentage
		{
			get => GetProperty(ref _healthPercentage);
			set => SetProperty(ref _healthPercentage, value);
		}

		[Ordinal(11)] 
		[RED("bossName")] 
		public inkTextWidgetReference BossName
		{
			get => GetProperty(ref _bossName);
			set => SetProperty(ref _bossName, value);
		}

		[Ordinal(12)] 
		[RED("dividerContainerRef")] 
		public inkCompoundWidgetReference DividerContainerRef
		{
			get => GetProperty(ref _dividerContainerRef);
			set => SetProperty(ref _dividerContainerRef, value);
		}

		[Ordinal(13)] 
		[RED("statListener")] 
		public CHandle<BossHealthStatListener> StatListener
		{
			get => GetProperty(ref _statListener);
			set => SetProperty(ref _statListener, value);
		}

		[Ordinal(14)] 
		[RED("boss")] 
		public wCHandle<NPCPuppet> Boss
		{
			get => GetProperty(ref _boss);
			set => SetProperty(ref _boss, value);
		}

		[Ordinal(15)] 
		[RED("healthController")] 
		public wCHandle<NameplateBarLogicController> HealthController
		{
			get => GetProperty(ref _healthController);
			set => SetProperty(ref _healthController, value);
		}

		[Ordinal(16)] 
		[RED("thresholds")] 
		public CArray<CFloat> Thresholds
		{
			get => GetProperty(ref _thresholds);
			set => SetProperty(ref _thresholds, value);
		}

		[Ordinal(17)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(18)] 
		[RED("unfoldAnimation")] 
		public CHandle<inkanimProxy> UnfoldAnimation
		{
			get => GetProperty(ref _unfoldAnimation);
			set => SetProperty(ref _unfoldAnimation, value);
		}

		[Ordinal(19)] 
		[RED("foldAnimation")] 
		public CHandle<inkanimProxy> FoldAnimation
		{
			get => GetProperty(ref _foldAnimation);
			set => SetProperty(ref _foldAnimation, value);
		}

		[Ordinal(20)] 
		[RED("fastTravelCallbackID")] 
		public CHandle<redCallbackObject> FastTravelCallbackID
		{
			get => GetProperty(ref _fastTravelCallbackID);
			set => SetProperty(ref _fastTravelCallbackID, value);
		}

		[Ordinal(21)] 
		[RED("bossPuppets")] 
		public CArray<wCHandle<NPCPuppet>> BossPuppets
		{
			get => GetProperty(ref _bossPuppets);
			set => SetProperty(ref _bossPuppets, value);
		}

		public BossHealthBarGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

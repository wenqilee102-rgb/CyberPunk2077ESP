using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleColorInkController : gameuiHUDGameController
	{
		private wCHandle<vehicleBaseObject> _vehicle;
		private wCHandle<gameIBlackboard> _vehicleBlackboard;
		private wCHandle<VehicleComponentPS> _vehiclePS;
		private wCHandle<inkWidget> _root;
		private CHandle<inkanimProxy> _animProxy;
		private CHandle<inkanimProxy> _glitchAnimProxy;
		private CHandle<inkanimProxy> _spoilerAnimProxy;
		private inkWidgetReference _primaryColorPane;
		private inkWidgetReference _secondaryColorPane;
		private CArray<inkImageWidgetReference> _primaryColor;
		private CArray<inkImageWidgetReference> _secondaryColor;
		private CEnum<VehicleVisualCustomizationWidgetCarPart> _carPartType;
		private CHandle<redCallbackObject> _colorModDefinition;
		private CColor _cachedPrimaryColor;
		private CColor _cachedSecondaryColor;
		private CHandle<redCallbackObject> _colorSecondaryCodeListener;
		private CHandle<redCallbackObject> _vehicleCollisionListener;
		private CHandle<redCallbackObject> _vehicleDamageListener;
		private CHandle<redCallbackObject> _vehicleModBlockedByDamageListener;
		private CHandle<redCallbackObject> _vehicleModActiveListener;
		private CHandle<redCallbackObject> _vehicleTPPCallbackID;
		private CHandle<redCallbackObject> _vehicleSpeedListener;
		private VehicleVisualCustomizationTemplate _cachedTemplate;
		private CBool _moddingBlockedByDamage;
		private CBool _visualCustomizationActive;
		private CBool _spoilerDeployed;
		private CBool _cachedTppView;
		private CHandle<inkanimProxy> _fakeUpdateProxy;
		private CHandle<inkanimProxy> _damageAnimLoopProxy;

		[Ordinal(9)] 
		[RED("vehicle")] 
		public wCHandle<vehicleBaseObject> Vehicle
		{
			get => GetProperty(ref _vehicle);
			set => SetProperty(ref _vehicle, value);
		}

		[Ordinal(10)] 
		[RED("vehicleBlackboard")] 
		public wCHandle<gameIBlackboard> VehicleBlackboard
		{
			get => GetProperty(ref _vehicleBlackboard);
			set => SetProperty(ref _vehicleBlackboard, value);
		}

		[Ordinal(11)] 
		[RED("vehiclePS")] 
		public wCHandle<VehicleComponentPS> VehiclePS
		{
			get => GetProperty(ref _vehiclePS);
			set => SetProperty(ref _vehiclePS, value);
		}

		[Ordinal(12)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(13)] 
		[RED("AnimProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(14)] 
		[RED("GlitchAnimProxy")] 
		public CHandle<inkanimProxy> GlitchAnimProxy
		{
			get => GetProperty(ref _glitchAnimProxy);
			set => SetProperty(ref _glitchAnimProxy, value);
		}

		[Ordinal(15)] 
		[RED("SpoilerAnimProxy")] 
		public CHandle<inkanimProxy> SpoilerAnimProxy
		{
			get => GetProperty(ref _spoilerAnimProxy);
			set => SetProperty(ref _spoilerAnimProxy, value);
		}

		[Ordinal(16)] 
		[RED("primaryColorPane")] 
		public inkWidgetReference PrimaryColorPane
		{
			get => GetProperty(ref _primaryColorPane);
			set => SetProperty(ref _primaryColorPane, value);
		}

		[Ordinal(17)] 
		[RED("secondaryColorPane")] 
		public inkWidgetReference SecondaryColorPane
		{
			get => GetProperty(ref _secondaryColorPane);
			set => SetProperty(ref _secondaryColorPane, value);
		}

		[Ordinal(18)] 
		[RED("primaryColor")] 
		public CArray<inkImageWidgetReference> PrimaryColor
		{
			get => GetProperty(ref _primaryColor);
			set => SetProperty(ref _primaryColor, value);
		}

		[Ordinal(19)] 
		[RED("secondaryColor")] 
		public CArray<inkImageWidgetReference> SecondaryColor
		{
			get => GetProperty(ref _secondaryColor);
			set => SetProperty(ref _secondaryColor, value);
		}

		[Ordinal(20)] 
		[RED("carPartType")] 
		public CEnum<VehicleVisualCustomizationWidgetCarPart> CarPartType
		{
			get => GetProperty(ref _carPartType);
			set => SetProperty(ref _carPartType, value);
		}

		[Ordinal(21)] 
		[RED("colorModDefinition")] 
		public CHandle<redCallbackObject> ColorModDefinition
		{
			get => GetProperty(ref _colorModDefinition);
			set => SetProperty(ref _colorModDefinition, value);
		}

		[Ordinal(22)] 
		[RED("cachedPrimaryColor")] 
		public CColor CachedPrimaryColor
		{
			get => GetProperty(ref _cachedPrimaryColor);
			set => SetProperty(ref _cachedPrimaryColor, value);
		}

		[Ordinal(23)] 
		[RED("cachedSecondaryColor")] 
		public CColor CachedSecondaryColor
		{
			get => GetProperty(ref _cachedSecondaryColor);
			set => SetProperty(ref _cachedSecondaryColor, value);
		}

		[Ordinal(24)] 
		[RED("colorSecondaryCodeListener")] 
		public CHandle<redCallbackObject> ColorSecondaryCodeListener
		{
			get => GetProperty(ref _colorSecondaryCodeListener);
			set => SetProperty(ref _colorSecondaryCodeListener, value);
		}

		[Ordinal(25)] 
		[RED("vehicleCollisionListener")] 
		public CHandle<redCallbackObject> VehicleCollisionListener
		{
			get => GetProperty(ref _vehicleCollisionListener);
			set => SetProperty(ref _vehicleCollisionListener, value);
		}

		[Ordinal(26)] 
		[RED("vehicleDamageListener")] 
		public CHandle<redCallbackObject> VehicleDamageListener
		{
			get => GetProperty(ref _vehicleDamageListener);
			set => SetProperty(ref _vehicleDamageListener, value);
		}

		[Ordinal(27)] 
		[RED("vehicleModBlockedByDamageListener")] 
		public CHandle<redCallbackObject> VehicleModBlockedByDamageListener
		{
			get => GetProperty(ref _vehicleModBlockedByDamageListener);
			set => SetProperty(ref _vehicleModBlockedByDamageListener, value);
		}

		[Ordinal(28)] 
		[RED("vehicleModActiveListener")] 
		public CHandle<redCallbackObject> VehicleModActiveListener
		{
			get => GetProperty(ref _vehicleModActiveListener);
			set => SetProperty(ref _vehicleModActiveListener, value);
		}

		[Ordinal(29)] 
		[RED("vehicleTPPCallbackID")] 
		public CHandle<redCallbackObject> VehicleTPPCallbackID
		{
			get => GetProperty(ref _vehicleTPPCallbackID);
			set => SetProperty(ref _vehicleTPPCallbackID, value);
		}

		[Ordinal(30)] 
		[RED("vehicleSpeedListener")] 
		public CHandle<redCallbackObject> VehicleSpeedListener
		{
			get => GetProperty(ref _vehicleSpeedListener);
			set => SetProperty(ref _vehicleSpeedListener, value);
		}

		[Ordinal(31)] 
		[RED("cachedTemplate")] 
		public VehicleVisualCustomizationTemplate CachedTemplate
		{
			get => GetProperty(ref _cachedTemplate);
			set => SetProperty(ref _cachedTemplate, value);
		}

		[Ordinal(32)] 
		[RED("moddingBlockedByDamage")] 
		public CBool ModdingBlockedByDamage
		{
			get => GetProperty(ref _moddingBlockedByDamage);
			set => SetProperty(ref _moddingBlockedByDamage, value);
		}

		[Ordinal(33)] 
		[RED("visualCustomizationActive")] 
		public CBool VisualCustomizationActive
		{
			get => GetProperty(ref _visualCustomizationActive);
			set => SetProperty(ref _visualCustomizationActive, value);
		}

		[Ordinal(34)] 
		[RED("spoilerDeployed")] 
		public CBool SpoilerDeployed
		{
			get => GetProperty(ref _spoilerDeployed);
			set => SetProperty(ref _spoilerDeployed, value);
		}

		[Ordinal(35)] 
		[RED("cachedTppView")] 
		public CBool CachedTppView
		{
			get => GetProperty(ref _cachedTppView);
			set => SetProperty(ref _cachedTppView, value);
		}

		[Ordinal(36)] 
		[RED("fakeUpdateProxy")] 
		public CHandle<inkanimProxy> FakeUpdateProxy
		{
			get => GetProperty(ref _fakeUpdateProxy);
			set => SetProperty(ref _fakeUpdateProxy, value);
		}

		[Ordinal(37)] 
		[RED("damageAnimLoopProxy")] 
		public CHandle<inkanimProxy> DamageAnimLoopProxy
		{
			get => GetProperty(ref _damageAnimLoopProxy);
			set => SetProperty(ref _damageAnimLoopProxy, value);
		}

		public vehicleColorInkController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

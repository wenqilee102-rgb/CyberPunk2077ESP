using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkGameSettingsResource : CResource
	{
		private rRef<inkFullscreenCompositionResource> _compositionResource;
		private CArray<raRef<inkTextureAtlas>> _permanentTextureAtlases;
		private CArray<raRef<inkTextureAtlas>> _permanentTextureAtlasesPC;
		private CArray<raRef<inkTextureAtlas>> _permanentTextureAtlasesDurango;
		private CArray<raRef<inkTextureAtlas>> _permanentTextureAtlasesOrbis;
		private CArray<raRef<inkTextureAtlas>> _permanentTextureAtlasesProspero;
		private CArray<raRef<inkTextureAtlas>> _permanentTextureAtlasesStadiaSwitch;
		private CArray<raRef<inkTextureAtlas>> _permanentTextureAtlasesStadia;
		private CArray<raRef<inkTextureAtlas>> _permanentTextureAtlasesStadiaDurango;
		private CArray<raRef<inkTextureAtlas>> _permanentTextureAtlasesStadiaOrbis;
		private CArray<inkStyleThemeDescriptor> _themes;
		private rRef<inkLayersResource> _layersResource;
		private raRef<inkTextureAtlas> _iconReferenceFallbackTextureAtlas;
		private raRef<Bink> _initLoadingScreenLogoLoopVideo;
		private raRef<inkWidgetLibraryResource> _npcNameplateResource;
		private rRef<inkShapeCollectionResource> _defaultShapeCollectionResource;
		private raRef<JsonResource> _globalTVBinkLengthDataResource;
		private raRef<inkWidgetLibraryResource> _worldMapFloorplanWidgetResource;
		private raRef<entEntityTemplate> _gpsAugmentedRealitySignEntity;
		private raRef<inkWidgetLibraryResource> _gpsAugmentedRealityWidgetTurnLeft;
		private raRef<inkWidgetLibraryResource> _gpsAugmentedRealityWidgetTurnRight;
		private raRef<inkWidgetLibraryResource> _gpsAugmentedRealityWidgetTurnBack;
		private raRef<CResource> _malePresetResource;
		private raRef<CResource> _femalePresetResource;
		private raRef<CResource> _fallbackHeadCustomizationFpp;
		private raRef<CResource> _fallbackHeadCustomizationTpp;
		private raRef<CResource> _fallbackHeadCustomizationTppFaceRig;
		private raRef<CResource> _fallbackBodyCustomization;
		private raRef<CResource> _fallbackArmsCustomization;
		private raRef<CResource> _vsetSceneResource;
		private raRef<inkTextureAtlas> _keyboardIconsAtlas;
		private raRef<inkTextureAtlas> _steamIconsAtlas;
		private raRef<inkTextureAtlas> _durangoIconsAtlas;
		private raRef<inkTextureAtlas> _orbisIconsAtlas;
		private raRef<inkTextureAtlas> _prosperoIconsAtlas;
		private raRef<inkTextureAtlas> _nintendoSwitchIconsAtlas;
		private raRef<inkTextureAtlas> _stadiaIconsAtlas;
		private raRef<inkTextureAtlas> _stadiaDurangoIconsAtlas;
		private raRef<inkTextureAtlas> _stadiaOrbisIconsAtlas;

		[Ordinal(1)] 
		[RED("compositionResource")] 
		public rRef<inkFullscreenCompositionResource> CompositionResource
		{
			get => GetProperty(ref _compositionResource);
			set => SetProperty(ref _compositionResource, value);
		}

		[Ordinal(2)] 
		[RED("permanentTextureAtlases")] 
		public CArray<raRef<inkTextureAtlas>> PermanentTextureAtlases
		{
			get => GetProperty(ref _permanentTextureAtlases);
			set => SetProperty(ref _permanentTextureAtlases, value);
		}

		[Ordinal(3)] 
		[RED("permanentTextureAtlasesPC")] 
		public CArray<raRef<inkTextureAtlas>> PermanentTextureAtlasesPC
		{
			get => GetProperty(ref _permanentTextureAtlasesPC);
			set => SetProperty(ref _permanentTextureAtlasesPC, value);
		}

		[Ordinal(4)] 
		[RED("permanentTextureAtlasesDurango")] 
		public CArray<raRef<inkTextureAtlas>> PermanentTextureAtlasesDurango
		{
			get => GetProperty(ref _permanentTextureAtlasesDurango);
			set => SetProperty(ref _permanentTextureAtlasesDurango, value);
		}

		[Ordinal(5)] 
		[RED("permanentTextureAtlasesOrbis")] 
		public CArray<raRef<inkTextureAtlas>> PermanentTextureAtlasesOrbis
		{
			get => GetProperty(ref _permanentTextureAtlasesOrbis);
			set => SetProperty(ref _permanentTextureAtlasesOrbis, value);
		}

		[Ordinal(6)] 
		[RED("permanentTextureAtlasesProspero")] 
		public CArray<raRef<inkTextureAtlas>> PermanentTextureAtlasesProspero
		{
			get => GetProperty(ref _permanentTextureAtlasesProspero);
			set => SetProperty(ref _permanentTextureAtlasesProspero, value);
		}

		[Ordinal(7)] 
		[RED("permanentTextureAtlasesStadiaSwitch")] 
		public CArray<raRef<inkTextureAtlas>> PermanentTextureAtlasesStadiaSwitch
		{
			get => GetProperty(ref _permanentTextureAtlasesStadiaSwitch);
			set => SetProperty(ref _permanentTextureAtlasesStadiaSwitch, value);
		}

		[Ordinal(8)] 
		[RED("permanentTextureAtlasesStadia")] 
		public CArray<raRef<inkTextureAtlas>> PermanentTextureAtlasesStadia
		{
			get => GetProperty(ref _permanentTextureAtlasesStadia);
			set => SetProperty(ref _permanentTextureAtlasesStadia, value);
		}

		[Ordinal(9)] 
		[RED("permanentTextureAtlasesStadiaDurango")] 
		public CArray<raRef<inkTextureAtlas>> PermanentTextureAtlasesStadiaDurango
		{
			get => GetProperty(ref _permanentTextureAtlasesStadiaDurango);
			set => SetProperty(ref _permanentTextureAtlasesStadiaDurango, value);
		}

		[Ordinal(10)] 
		[RED("permanentTextureAtlasesStadiaOrbis")] 
		public CArray<raRef<inkTextureAtlas>> PermanentTextureAtlasesStadiaOrbis
		{
			get => GetProperty(ref _permanentTextureAtlasesStadiaOrbis);
			set => SetProperty(ref _permanentTextureAtlasesStadiaOrbis, value);
		}

		[Ordinal(11)] 
		[RED("themes")] 
		public CArray<inkStyleThemeDescriptor> Themes
		{
			get => GetProperty(ref _themes);
			set => SetProperty(ref _themes, value);
		}

		[Ordinal(12)] 
		[RED("layersResource")] 
		public rRef<inkLayersResource> LayersResource
		{
			get => GetProperty(ref _layersResource);
			set => SetProperty(ref _layersResource, value);
		}

		[Ordinal(13)] 
		[RED("iconReferenceFallbackTextureAtlas")] 
		public raRef<inkTextureAtlas> IconReferenceFallbackTextureAtlas
		{
			get => GetProperty(ref _iconReferenceFallbackTextureAtlas);
			set => SetProperty(ref _iconReferenceFallbackTextureAtlas, value);
		}

		[Ordinal(14)] 
		[RED("initLoadingScreenLogoLoopVideo")] 
		public raRef<Bink> InitLoadingScreenLogoLoopVideo
		{
			get => GetProperty(ref _initLoadingScreenLogoLoopVideo);
			set => SetProperty(ref _initLoadingScreenLogoLoopVideo, value);
		}

		[Ordinal(15)] 
		[RED("npcNameplateResource")] 
		public raRef<inkWidgetLibraryResource> NpcNameplateResource
		{
			get => GetProperty(ref _npcNameplateResource);
			set => SetProperty(ref _npcNameplateResource, value);
		}

		[Ordinal(16)] 
		[RED("defaultShapeCollectionResource")] 
		public rRef<inkShapeCollectionResource> DefaultShapeCollectionResource
		{
			get => GetProperty(ref _defaultShapeCollectionResource);
			set => SetProperty(ref _defaultShapeCollectionResource, value);
		}

		[Ordinal(17)] 
		[RED("globalTVBinkLengthDataResource")] 
		public raRef<JsonResource> GlobalTVBinkLengthDataResource
		{
			get => GetProperty(ref _globalTVBinkLengthDataResource);
			set => SetProperty(ref _globalTVBinkLengthDataResource, value);
		}

		[Ordinal(18)] 
		[RED("worldMapFloorplanWidgetResource")] 
		public raRef<inkWidgetLibraryResource> WorldMapFloorplanWidgetResource
		{
			get => GetProperty(ref _worldMapFloorplanWidgetResource);
			set => SetProperty(ref _worldMapFloorplanWidgetResource, value);
		}

		[Ordinal(19)] 
		[RED("gpsAugmentedRealitySignEntity")] 
		public raRef<entEntityTemplate> GpsAugmentedRealitySignEntity
		{
			get => GetProperty(ref _gpsAugmentedRealitySignEntity);
			set => SetProperty(ref _gpsAugmentedRealitySignEntity, value);
		}

		[Ordinal(20)] 
		[RED("gpsAugmentedRealityWidgetTurnLeft")] 
		public raRef<inkWidgetLibraryResource> GpsAugmentedRealityWidgetTurnLeft
		{
			get => GetProperty(ref _gpsAugmentedRealityWidgetTurnLeft);
			set => SetProperty(ref _gpsAugmentedRealityWidgetTurnLeft, value);
		}

		[Ordinal(21)] 
		[RED("gpsAugmentedRealityWidgetTurnRight")] 
		public raRef<inkWidgetLibraryResource> GpsAugmentedRealityWidgetTurnRight
		{
			get => GetProperty(ref _gpsAugmentedRealityWidgetTurnRight);
			set => SetProperty(ref _gpsAugmentedRealityWidgetTurnRight, value);
		}

		[Ordinal(22)] 
		[RED("gpsAugmentedRealityWidgetTurnBack")] 
		public raRef<inkWidgetLibraryResource> GpsAugmentedRealityWidgetTurnBack
		{
			get => GetProperty(ref _gpsAugmentedRealityWidgetTurnBack);
			set => SetProperty(ref _gpsAugmentedRealityWidgetTurnBack, value);
		}

		[Ordinal(23)] 
		[RED("malePresetResource")] 
		public raRef<CResource> MalePresetResource
		{
			get => GetProperty(ref _malePresetResource);
			set => SetProperty(ref _malePresetResource, value);
		}

		[Ordinal(24)] 
		[RED("femalePresetResource")] 
		public raRef<CResource> FemalePresetResource
		{
			get => GetProperty(ref _femalePresetResource);
			set => SetProperty(ref _femalePresetResource, value);
		}

		[Ordinal(25)] 
		[RED("fallbackHeadCustomizationFpp")] 
		public raRef<CResource> FallbackHeadCustomizationFpp
		{
			get => GetProperty(ref _fallbackHeadCustomizationFpp);
			set => SetProperty(ref _fallbackHeadCustomizationFpp, value);
		}

		[Ordinal(26)] 
		[RED("fallbackHeadCustomizationTpp")] 
		public raRef<CResource> FallbackHeadCustomizationTpp
		{
			get => GetProperty(ref _fallbackHeadCustomizationTpp);
			set => SetProperty(ref _fallbackHeadCustomizationTpp, value);
		}

		[Ordinal(27)] 
		[RED("fallbackHeadCustomizationTppFaceRig")] 
		public raRef<CResource> FallbackHeadCustomizationTppFaceRig
		{
			get => GetProperty(ref _fallbackHeadCustomizationTppFaceRig);
			set => SetProperty(ref _fallbackHeadCustomizationTppFaceRig, value);
		}

		[Ordinal(28)] 
		[RED("fallbackBodyCustomization")] 
		public raRef<CResource> FallbackBodyCustomization
		{
			get => GetProperty(ref _fallbackBodyCustomization);
			set => SetProperty(ref _fallbackBodyCustomization, value);
		}

		[Ordinal(29)] 
		[RED("fallbackArmsCustomization")] 
		public raRef<CResource> FallbackArmsCustomization
		{
			get => GetProperty(ref _fallbackArmsCustomization);
			set => SetProperty(ref _fallbackArmsCustomization, value);
		}

		[Ordinal(30)] 
		[RED("vsetSceneResource")] 
		public raRef<CResource> VsetSceneResource
		{
			get => GetProperty(ref _vsetSceneResource);
			set => SetProperty(ref _vsetSceneResource, value);
		}

		[Ordinal(31)] 
		[RED("keyboardIconsAtlas")] 
		public raRef<inkTextureAtlas> KeyboardIconsAtlas
		{
			get => GetProperty(ref _keyboardIconsAtlas);
			set => SetProperty(ref _keyboardIconsAtlas, value);
		}

		[Ordinal(32)] 
		[RED("steamIconsAtlas")] 
		public raRef<inkTextureAtlas> SteamIconsAtlas
		{
			get => GetProperty(ref _steamIconsAtlas);
			set => SetProperty(ref _steamIconsAtlas, value);
		}

		[Ordinal(33)] 
		[RED("durangoIconsAtlas")] 
		public raRef<inkTextureAtlas> DurangoIconsAtlas
		{
			get => GetProperty(ref _durangoIconsAtlas);
			set => SetProperty(ref _durangoIconsAtlas, value);
		}

		[Ordinal(34)] 
		[RED("orbisIconsAtlas")] 
		public raRef<inkTextureAtlas> OrbisIconsAtlas
		{
			get => GetProperty(ref _orbisIconsAtlas);
			set => SetProperty(ref _orbisIconsAtlas, value);
		}

		[Ordinal(35)] 
		[RED("prosperoIconsAtlas")] 
		public raRef<inkTextureAtlas> ProsperoIconsAtlas
		{
			get => GetProperty(ref _prosperoIconsAtlas);
			set => SetProperty(ref _prosperoIconsAtlas, value);
		}

		[Ordinal(36)] 
		[RED("nintendoSwitchIconsAtlas")] 
		public raRef<inkTextureAtlas> NintendoSwitchIconsAtlas
		{
			get => GetProperty(ref _nintendoSwitchIconsAtlas);
			set => SetProperty(ref _nintendoSwitchIconsAtlas, value);
		}

		[Ordinal(37)] 
		[RED("stadiaIconsAtlas")] 
		public raRef<inkTextureAtlas> StadiaIconsAtlas
		{
			get => GetProperty(ref _stadiaIconsAtlas);
			set => SetProperty(ref _stadiaIconsAtlas, value);
		}

		[Ordinal(38)] 
		[RED("stadiaDurangoIconsAtlas")] 
		public raRef<inkTextureAtlas> StadiaDurangoIconsAtlas
		{
			get => GetProperty(ref _stadiaDurangoIconsAtlas);
			set => SetProperty(ref _stadiaDurangoIconsAtlas, value);
		}

		[Ordinal(39)] 
		[RED("stadiaOrbisIconsAtlas")] 
		public raRef<inkTextureAtlas> StadiaOrbisIconsAtlas
		{
			get => GetProperty(ref _stadiaOrbisIconsAtlas);
			set => SetProperty(ref _stadiaOrbisIconsAtlas, value);
		}

		public inkGameSettingsResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

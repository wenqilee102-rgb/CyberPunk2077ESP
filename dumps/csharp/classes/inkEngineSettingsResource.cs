using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkEngineSettingsResource : CResource
	{
		private rRef<inkFullscreenCompositionResource> _fallbackCompositionResource;
		private rRef<inkShapeCollectionResource> _fallbackShapeCollectionResource;
		private rRef<inkTextureAtlas> _fallbackIconAtlasResource;
		private raRef<JsonResource> _inputKeyIconsDefinitionResource;
		private rRef<inkFontFamilyResource> _fallbackFontFamilyPath;
		private rRef<CBitmapTexture> _blackTexture;
		private rRef<CBitmapTexture> _advertMissingFormatTexture;
		private rRef<CBitmapTexture> _advertWrongResourceTexture;
		private rRef<inkTextureAtlas> _fallbackTextureAtlas;
		private rRef<IMaterial> _imageTilingMaterial;
		private rRef<IMaterial> _imageNineSliceMaterial;
		private rRef<IMaterial> _depthMaterial;
		private rRef<inkTextureAtlas> _whiteMaskAtlas;
		private rRef<CMaterialTemplate> _defaultBinkMaterial;
		private rRef<CBitmapTexture> _tooManyBinksTexture;
		private rRef<CBitmapTexture> _componentMissingTexture;

		[Ordinal(1)] 
		[RED("fallbackCompositionResource")] 
		public rRef<inkFullscreenCompositionResource> FallbackCompositionResource
		{
			get => GetProperty(ref _fallbackCompositionResource);
			set => SetProperty(ref _fallbackCompositionResource, value);
		}

		[Ordinal(2)] 
		[RED("fallbackShapeCollectionResource")] 
		public rRef<inkShapeCollectionResource> FallbackShapeCollectionResource
		{
			get => GetProperty(ref _fallbackShapeCollectionResource);
			set => SetProperty(ref _fallbackShapeCollectionResource, value);
		}

		[Ordinal(3)] 
		[RED("fallbackIconAtlasResource")] 
		public rRef<inkTextureAtlas> FallbackIconAtlasResource
		{
			get => GetProperty(ref _fallbackIconAtlasResource);
			set => SetProperty(ref _fallbackIconAtlasResource, value);
		}

		[Ordinal(4)] 
		[RED("inputKeyIconsDefinitionResource")] 
		public raRef<JsonResource> InputKeyIconsDefinitionResource
		{
			get => GetProperty(ref _inputKeyIconsDefinitionResource);
			set => SetProperty(ref _inputKeyIconsDefinitionResource, value);
		}

		[Ordinal(5)] 
		[RED("fallbackFontFamilyPath")] 
		public rRef<inkFontFamilyResource> FallbackFontFamilyPath
		{
			get => GetProperty(ref _fallbackFontFamilyPath);
			set => SetProperty(ref _fallbackFontFamilyPath, value);
		}

		[Ordinal(6)] 
		[RED("blackTexture")] 
		public rRef<CBitmapTexture> BlackTexture
		{
			get => GetProperty(ref _blackTexture);
			set => SetProperty(ref _blackTexture, value);
		}

		[Ordinal(7)] 
		[RED("advertMissingFormatTexture")] 
		public rRef<CBitmapTexture> AdvertMissingFormatTexture
		{
			get => GetProperty(ref _advertMissingFormatTexture);
			set => SetProperty(ref _advertMissingFormatTexture, value);
		}

		[Ordinal(8)] 
		[RED("advertWrongResourceTexture")] 
		public rRef<CBitmapTexture> AdvertWrongResourceTexture
		{
			get => GetProperty(ref _advertWrongResourceTexture);
			set => SetProperty(ref _advertWrongResourceTexture, value);
		}

		[Ordinal(9)] 
		[RED("fallbackTextureAtlas")] 
		public rRef<inkTextureAtlas> FallbackTextureAtlas
		{
			get => GetProperty(ref _fallbackTextureAtlas);
			set => SetProperty(ref _fallbackTextureAtlas, value);
		}

		[Ordinal(10)] 
		[RED("imageTilingMaterial")] 
		public rRef<IMaterial> ImageTilingMaterial
		{
			get => GetProperty(ref _imageTilingMaterial);
			set => SetProperty(ref _imageTilingMaterial, value);
		}

		[Ordinal(11)] 
		[RED("imageNineSliceMaterial")] 
		public rRef<IMaterial> ImageNineSliceMaterial
		{
			get => GetProperty(ref _imageNineSliceMaterial);
			set => SetProperty(ref _imageNineSliceMaterial, value);
		}

		[Ordinal(12)] 
		[RED("depthMaterial")] 
		public rRef<IMaterial> DepthMaterial
		{
			get => GetProperty(ref _depthMaterial);
			set => SetProperty(ref _depthMaterial, value);
		}

		[Ordinal(13)] 
		[RED("whiteMaskAtlas")] 
		public rRef<inkTextureAtlas> WhiteMaskAtlas
		{
			get => GetProperty(ref _whiteMaskAtlas);
			set => SetProperty(ref _whiteMaskAtlas, value);
		}

		[Ordinal(14)] 
		[RED("defaultBinkMaterial")] 
		public rRef<CMaterialTemplate> DefaultBinkMaterial
		{
			get => GetProperty(ref _defaultBinkMaterial);
			set => SetProperty(ref _defaultBinkMaterial, value);
		}

		[Ordinal(15)] 
		[RED("tooManyBinksTexture")] 
		public rRef<CBitmapTexture> TooManyBinksTexture
		{
			get => GetProperty(ref _tooManyBinksTexture);
			set => SetProperty(ref _tooManyBinksTexture, value);
		}

		[Ordinal(16)] 
		[RED("componentMissingTexture")] 
		public rRef<CBitmapTexture> ComponentMissingTexture
		{
			get => GetProperty(ref _componentMissingTexture);
			set => SetProperty(ref _componentMissingTexture, value);
		}

		public inkEngineSettingsResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

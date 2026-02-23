using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkFullscreenCompositionResource : CResource
	{
		private CArray<inkCompositionPreset> _compositionPresets;
		private raRef<CBitmapTexture> _backgroundMenuTextureUHDRes;
		private raRef<CBitmapTexture> _backgroundMenuTextureFHDRes;
		private CHandle<inkCompositionPreviewSettings> _previewSettings;

		[Ordinal(1)] 
		[RED("compositionPresets")] 
		public CArray<inkCompositionPreset> CompositionPresets
		{
			get => GetProperty(ref _compositionPresets);
			set => SetProperty(ref _compositionPresets, value);
		}

		[Ordinal(2)] 
		[RED("backgroundMenuTextureUHDRes")] 
		public raRef<CBitmapTexture> BackgroundMenuTextureUHDRes
		{
			get => GetProperty(ref _backgroundMenuTextureUHDRes);
			set => SetProperty(ref _backgroundMenuTextureUHDRes, value);
		}

		[Ordinal(3)] 
		[RED("backgroundMenuTextureFHDRes")] 
		public raRef<CBitmapTexture> BackgroundMenuTextureFHDRes
		{
			get => GetProperty(ref _backgroundMenuTextureFHDRes);
			set => SetProperty(ref _backgroundMenuTextureFHDRes, value);
		}

		[Ordinal(4)] 
		[RED("previewSettings")] 
		public CHandle<inkCompositionPreviewSettings> PreviewSettings
		{
			get => GetProperty(ref _previewSettings);
			set => SetProperty(ref _previewSettings, value);
		}

		public inkFullscreenCompositionResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

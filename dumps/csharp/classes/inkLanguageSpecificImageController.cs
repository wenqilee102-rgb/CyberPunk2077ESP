using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLanguageSpecificImageController : inkWidgetLogicController
	{
		private CArray<inkLanguageSpecificImagData> _languages;
		private raRef<inkTextureAtlas> _fallbackTextureAtlas;
		private CName _fallbackPartName;

		[Ordinal(1)] 
		[RED("languages")] 
		public CArray<inkLanguageSpecificImagData> Languages
		{
			get => GetProperty(ref _languages);
			set => SetProperty(ref _languages, value);
		}

		[Ordinal(2)] 
		[RED("fallbackTextureAtlas")] 
		public raRef<inkTextureAtlas> FallbackTextureAtlas
		{
			get => GetProperty(ref _fallbackTextureAtlas);
			set => SetProperty(ref _fallbackTextureAtlas, value);
		}

		[Ordinal(3)] 
		[RED("fallbackPartName")] 
		public CName FallbackPartName
		{
			get => GetProperty(ref _fallbackPartName);
			set => SetProperty(ref _fallbackPartName, value);
		}

		public inkLanguageSpecificImageController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

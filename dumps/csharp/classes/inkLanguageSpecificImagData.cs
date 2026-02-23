using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLanguageSpecificImagData : CVariable
	{
		private CEnum<inkLanguageId> _languageID;
		private raRef<inkTextureAtlas> _textureAtlasForLanguage;
		private CName _partNameForLanguage;

		[Ordinal(0)] 
		[RED("languageID")] 
		public CEnum<inkLanguageId> LanguageID
		{
			get => GetProperty(ref _languageID);
			set => SetProperty(ref _languageID, value);
		}

		[Ordinal(1)] 
		[RED("textureAtlasForLanguage")] 
		public raRef<inkTextureAtlas> TextureAtlasForLanguage
		{
			get => GetProperty(ref _textureAtlasForLanguage);
			set => SetProperty(ref _textureAtlasForLanguage, value);
		}

		[Ordinal(2)] 
		[RED("partNameForLanguage")] 
		public CName PartNameForLanguage
		{
			get => GetProperty(ref _partNameForLanguage);
			set => SetProperty(ref _partNameForLanguage, value);
		}

		public inkLanguageSpecificImagData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

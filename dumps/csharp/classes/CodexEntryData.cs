using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CodexEntryData : GenericCodexEntryData
	{
		private CInt32 _category;
		private CEnum<CodexImageType> _imageType;

		[Ordinal(12)] 
		[RED("category")] 
		public CInt32 Category
		{
			get => GetProperty(ref _category);
			set => SetProperty(ref _category, value);
		}

		[Ordinal(13)] 
		[RED("imageType")] 
		public CEnum<CodexImageType> ImageType
		{
			get => GetProperty(ref _imageType);
			set => SetProperty(ref _imageType, value);
		}

		public CodexEntryData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkGalleryData : CVariable
	{
		private CArray<CUInt32> _favorites;

		[Ordinal(0)] 
		[RED("favorites")] 
		public CArray<CUInt32> Favorites
		{
			get => GetProperty(ref _favorites);
			set => SetProperty(ref _favorites, value);
		}

		public inkGalleryData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

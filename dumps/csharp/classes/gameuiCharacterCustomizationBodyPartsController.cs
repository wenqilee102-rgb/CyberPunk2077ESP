using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationBodyPartsController : gameuiICharacterCustomizationBodyPartsController
	{
		private CBool _isHiddenInFpp;

		[Ordinal(3)] 
		[RED("isHiddenInFpp")] 
		public CBool IsHiddenInFpp
		{
			get => GetProperty(ref _isHiddenInFpp);
			set => SetProperty(ref _isHiddenInFpp, value);
		}

		public gameuiCharacterCustomizationBodyPartsController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

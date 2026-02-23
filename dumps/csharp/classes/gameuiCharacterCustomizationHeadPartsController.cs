using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationHeadPartsController : gameuiCharacterCustomizationBodyPartsController
	{
		private CName _groupName;

		[Ordinal(4)] 
		[RED("groupName")] 
		public CName GroupName
		{
			get => GetProperty(ref _groupName);
			set => SetProperty(ref _groupName, value);
		}

		public gameuiCharacterCustomizationHeadPartsController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

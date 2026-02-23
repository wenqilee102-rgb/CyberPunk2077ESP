using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationNailsController : gameuiCharacterCustomizationBodyPartsController
	{
		private CName _nailsGroupName;

		[Ordinal(4)] 
		[RED("nailsGroupName")] 
		public CName NailsGroupName
		{
			get => GetProperty(ref _nailsGroupName);
			set => SetProperty(ref _nailsGroupName, value);
		}

		public gameuiCharacterCustomizationNailsController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

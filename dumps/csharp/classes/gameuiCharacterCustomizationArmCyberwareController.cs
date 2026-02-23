using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationArmCyberwareController : gameuiCharacterCustomizationBodyPartsController
	{
		private CName _defaultGroupName;
		private CArray<raRef<appearanceAppearanceResource>> _additionalCyberArmAppearances;

		[Ordinal(4)] 
		[RED("defaultGroupName")] 
		public CName DefaultGroupName
		{
			get => GetProperty(ref _defaultGroupName);
			set => SetProperty(ref _defaultGroupName, value);
		}

		[Ordinal(5)] 
		[RED("additionalCyberArmAppearances")] 
		public CArray<raRef<appearanceAppearanceResource>> AdditionalCyberArmAppearances
		{
			get => GetProperty(ref _additionalCyberArmAppearances);
			set => SetProperty(ref _additionalCyberArmAppearances, value);
		}

		public gameuiCharacterCustomizationArmCyberwareController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

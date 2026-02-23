using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationOptionVersionPrereq : CVariable
	{
		private CName _optionName;
		private CName _definitionName;

		[Ordinal(0)] 
		[RED("optionName")] 
		public CName OptionName
		{
			get => GetProperty(ref _optionName);
			set => SetProperty(ref _optionName, value);
		}

		[Ordinal(1)] 
		[RED("definitionName")] 
		public CName DefinitionName
		{
			get => GetProperty(ref _definitionName);
			set => SetProperty(ref _definitionName, value);
		}

		public gameuiCharacterCustomizationOptionVersionPrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

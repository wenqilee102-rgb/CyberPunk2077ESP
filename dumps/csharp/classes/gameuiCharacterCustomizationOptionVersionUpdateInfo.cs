using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationOptionVersionUpdateInfo : CVariable
	{
		private CArray<CName> _curOptionNames;
		private CName _curDefintionName;
		private CArray<gameuiCharacterCustomizationOptionVersionPrereq> _optionPrereqs;
		private CName _newOptionName;
		private CName _newDefinitionName;
		private CBool _replaceCurOption;

		[Ordinal(0)] 
		[RED("curOptionNames")] 
		public CArray<CName> CurOptionNames
		{
			get => GetProperty(ref _curOptionNames);
			set => SetProperty(ref _curOptionNames, value);
		}

		[Ordinal(1)] 
		[RED("curDefintionName")] 
		public CName CurDefintionName
		{
			get => GetProperty(ref _curDefintionName);
			set => SetProperty(ref _curDefintionName, value);
		}

		[Ordinal(2)] 
		[RED("optionPrereqs")] 
		public CArray<gameuiCharacterCustomizationOptionVersionPrereq> OptionPrereqs
		{
			get => GetProperty(ref _optionPrereqs);
			set => SetProperty(ref _optionPrereqs, value);
		}

		[Ordinal(3)] 
		[RED("newOptionName")] 
		public CName NewOptionName
		{
			get => GetProperty(ref _newOptionName);
			set => SetProperty(ref _newOptionName, value);
		}

		[Ordinal(4)] 
		[RED("newDefinitionName")] 
		public CName NewDefinitionName
		{
			get => GetProperty(ref _newDefinitionName);
			set => SetProperty(ref _newDefinitionName, value);
		}

		[Ordinal(5)] 
		[RED("replaceCurOption")] 
		public CBool ReplaceCurOption
		{
			get => GetProperty(ref _replaceCurOption);
			set => SetProperty(ref _replaceCurOption, value);
		}

		public gameuiCharacterCustomizationOptionVersionUpdateInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

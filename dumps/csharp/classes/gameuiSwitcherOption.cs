using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSwitcherOption : CVariable
	{
		private CInt32 _index;
		private CArray<CName> _names;
		private CString _localizedName;
		private CArray<gameuiCharacterCustomizationAction> _actions;
		private redTagList _tags;
		private gameuiCharacterRandomizationInfo _randomizationInfo;

		[Ordinal(0)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		[Ordinal(1)] 
		[RED("names")] 
		public CArray<CName> Names
		{
			get => GetProperty(ref _names);
			set => SetProperty(ref _names, value);
		}

		[Ordinal(2)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get => GetProperty(ref _localizedName);
			set => SetProperty(ref _localizedName, value);
		}

		[Ordinal(3)] 
		[RED("actions")] 
		public CArray<gameuiCharacterCustomizationAction> Actions
		{
			get => GetProperty(ref _actions);
			set => SetProperty(ref _actions, value);
		}

		[Ordinal(4)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}

		[Ordinal(5)] 
		[RED("randomizationInfo")] 
		public gameuiCharacterRandomizationInfo RandomizationInfo
		{
			get => GetProperty(ref _randomizationInfo);
			set => SetProperty(ref _randomizationInfo, value);
		}

		public gameuiSwitcherOption(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

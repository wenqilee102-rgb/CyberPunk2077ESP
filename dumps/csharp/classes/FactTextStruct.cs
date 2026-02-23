using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FactTextStruct : CVariable
	{
		private CArray<CName> _locKeyList;
		private inkTextWidgetReference _description;
		private CName _factName;

		[Ordinal(0)] 
		[RED("locKeyList")] 
		public CArray<CName> LocKeyList
		{
			get => GetProperty(ref _locKeyList);
			set => SetProperty(ref _locKeyList, value);
		}

		[Ordinal(1)] 
		[RED("description")] 
		public inkTextWidgetReference Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(2)] 
		[RED("factName")] 
		public CName FactName
		{
			get => GetProperty(ref _factName);
			set => SetProperty(ref _factName, value);
		}

		public FactTextStruct(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ParamData : CVariable
	{
		private CString _name;
		private CString _type;
		private CVariant _defaultValue;

		[Ordinal(0)] 
		[RED("name")] 
		public CString Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CString Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(2)] 
		[RED("defaultValue")] 
		public CVariant DefaultValue
		{
			get => GetProperty(ref _defaultValue);
			set => SetProperty(ref _defaultValue, value);
		}

		public ParamData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

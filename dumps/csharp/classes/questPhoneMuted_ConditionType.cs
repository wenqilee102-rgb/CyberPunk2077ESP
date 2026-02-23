using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPhoneMuted_ConditionType : questISystemConditionType
	{
		private CName _groupName;
		private CBool _inverted;

		[Ordinal(0)] 
		[RED("groupName")] 
		public CName GroupName
		{
			get => GetProperty(ref _groupName);
			set => SetProperty(ref _groupName, value);
		}

		[Ordinal(1)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetProperty(ref _inverted);
			set => SetProperty(ref _inverted, value);
		}

		public questPhoneMuted_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

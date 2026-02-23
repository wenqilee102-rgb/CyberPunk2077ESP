using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerAddDevelopmentPoint_NodeType : questIEntityManager_NodeType
	{
		private CInt32 _value;
		private CEnum<gamedataDevelopmentPointType> _type;

		[Ordinal(0)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<gamedataDevelopmentPointType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		public questEntityManagerAddDevelopmentPoint_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

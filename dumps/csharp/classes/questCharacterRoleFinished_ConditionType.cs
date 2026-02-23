using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterRoleFinished_ConditionType : questICharacterConditionType
	{
		private gameEntityReference _objectRef;
		private CEnum<AIFiniteRoleType> _role;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("role")] 
		public CEnum<AIFiniteRoleType> Role
		{
			get => GetProperty(ref _role);
			set => SetProperty(ref _role, value);
		}

		public questCharacterRoleFinished_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

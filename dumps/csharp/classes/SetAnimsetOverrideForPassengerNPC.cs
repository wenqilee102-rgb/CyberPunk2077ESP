using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetAnimsetOverrideForPassengerNPC : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _isNPCMounted;

		[Ordinal(0)] 
		[RED("IsNPCMounted")] 
		public CHandle<AIArgumentMapping> IsNPCMounted
		{
			get => GetProperty(ref _isNPCMounted);
			set => SetProperty(ref _isNPCMounted, value);
		}

		public SetAnimsetOverrideForPassengerNPC(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

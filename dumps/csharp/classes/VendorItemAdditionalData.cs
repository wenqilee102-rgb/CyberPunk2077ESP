using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorItemAdditionalData : IScriptable
	{
		private gameSItemStackRequirementData _requirement;
		private CBool _isAvailable;

		[Ordinal(0)] 
		[RED("Requirement")] 
		public gameSItemStackRequirementData Requirement
		{
			get => GetProperty(ref _requirement);
			set => SetProperty(ref _requirement, value);
		}

		[Ordinal(1)] 
		[RED("IsAvailable")] 
		public CBool IsAvailable
		{
			get => GetProperty(ref _isAvailable);
			set => SetProperty(ref _isAvailable, value);
		}

		public VendorItemAdditionalData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

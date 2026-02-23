using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickSlotsDisabledDecisions : QuickSlotsDecisions
	{
		private wCHandle<gameObject> _executionOwner;
		private CBool _hasStatusEffect;

		[Ordinal(0)] 
		[RED("executionOwner")] 
		public wCHandle<gameObject> ExecutionOwner
		{
			get => GetProperty(ref _executionOwner);
			set => SetProperty(ref _executionOwner, value);
		}

		[Ordinal(1)] 
		[RED("hasStatusEffect")] 
		public CBool HasStatusEffect
		{
			get => GetProperty(ref _hasStatusEffect);
			set => SetProperty(ref _hasStatusEffect, value);
		}

		public QuickSlotsDisabledDecisions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

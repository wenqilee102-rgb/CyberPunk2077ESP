using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetKeepStrategyOnSearch : AIVehicleTaskAbstract
	{
		private CHandle<AIArgumentMapping> _keep;

		[Ordinal(0)] 
		[RED("keep")] 
		public CHandle<AIArgumentMapping> Keep
		{
			get => GetProperty(ref _keep);
			set => SetProperty(ref _keep, value);
		}

		public SetKeepStrategyOnSearch(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
